using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BBShop.App.ViewModels;
using BBShop.Domain.Interfaces;
using AutoMapper;
using BBShop.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using BBShop.App.Extensions;
using KissLog;

namespace BBShop.App.Controllers
{
    [Authorize]
    public class ProdutosController : BaseController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;


        public ProdutosController(IProdutoRepository produtoRepository, 
                                  IFornecedorRepository fornecedorRepository, 
                                  IProdutoService produtoService, 
                                  IMapper mapper,
                                  INotificator notificator,
                                  ILogger logger) : base(notificator)
        {
            _produtoRepository = produtoRepository;
            _fornecedorRepository = fornecedorRepository;
            _produtoService = produtoService;
            _mapper = mapper;
            _logger = logger;
        }

        #region PUBLIC
        [AllowAnonymous]
        [Route("lista-de-produtos")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));
        }

        [AllowAnonymous]
        [Route("dados-do-produto/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto","Adicionar")]
        [Route("novo-produto")]
        public async Task<IActionResult> Create()
        {
            var produtoViewModel = await PopularFornecedores(new ProdutoViewModel());
            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto", "Adicionar")]
        [Route("novo-produto")]
        [HttpPost]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            try
            {
                produtoViewModel = await PopularFornecedores(produtoViewModel);
                if (!ModelState.IsValid) return View(produtoViewModel);

                var imgName = $"{Guid.NewGuid()}_{produtoViewModel.ImagemUpload.FileName}";

                if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgName))
                {
                    return View(produtoViewModel);
                }

                produtoViewModel.Imagem = imgName;

                await _produtoService.Adicionar(_mapper.Map<Produto>(produtoViewModel));

                if (!IsValidOperation()) return View(produtoViewModel);
            }
            catch(Exception ex)
            {
                _logger.Error(ex);
                throw;
            }

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produto", "Editar")]
        [Route("editar-produto/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produto", "Editar")]
        [Route("editar-produto/{id:guid}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id) return NotFound();

            //NÃO usar hidden fields
            //Recuper valores diretamente do banco
            var produtoAtualizacao = await ObterProduto(id);
            produtoViewModel.Fornecedor = produtoAtualizacao.Fornecedor;
            produtoViewModel.Imagem = produtoAtualizacao.Imagem;

            if (!ModelState.IsValid) return View(produtoViewModel);

            if (produtoViewModel.ImagemUpload != null)
            {
                var imgName = $"{Guid.NewGuid()}_{produtoViewModel.ImagemUpload.FileName}";

                //Subir a Imagem
                if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgName))
                {
                    return View(produtoViewModel);
                }

                //Apagar antiga se existir
                if (!string.IsNullOrEmpty(produtoViewModel.Imagem))
                {
                    if (!RemoverArquivo(produtoViewModel.Imagem))
                    {
                        return View(produtoViewModel);
                    }
                }

                produtoAtualizacao.Imagem = imgName;
            }

            //Evita que na hora de editar o usuário force a edicação de campos hidden
            //Substituir APENAS pelos valores que o usuário tem acesso no form
            produtoAtualizacao.Nome = produtoViewModel.Nome;
            produtoAtualizacao.Descricao = produtoViewModel.Descricao;
            produtoAtualizacao.Valor = produtoViewModel.Valor;
            produtoAtualizacao.Ativo = produtoViewModel.Ativo;

            await _produtoService.Atualizar(_mapper.Map<Produto>(produtoAtualizacao));

            if (!IsValidOperation()) return View(produtoViewModel);

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produto", "Excluir")]
        [Route("excluir-produto/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var produto = await ObterProduto(id);

            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        [ClaimsAuthorize("Produto", "Excluir")]
        [Route("excluir-produto/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produto = await ObterProduto(id);

            if (produto == null)
            {
                return NotFound();
            }

            await _produtoService.Remover(id);

            if (!IsValidOperation()) return View(produto);

            TempData["Sucesso"] = "Produto excluído com sucesso!";

            return RedirectToAction("Index");
        }
        #endregion
                          
        #region PRIVATE

        private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoFornecedor(id));
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }

        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel produto)
        {
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }

        private async Task<bool> UploadArquivo(IFormFile arquivo, string imgName)
        {
            if (arquivo.Length <= 0) return false;

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/upload/img", imgName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                return false;
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return true;
        }

        private bool RemoverArquivo(string imgName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/upload/img", imgName);

            if (!System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Não foi possível apagar a imagem anterior!");
                return false;
            }

            System.IO.File.Delete(path);

            return true;
        } 
        #endregion
    }
}
