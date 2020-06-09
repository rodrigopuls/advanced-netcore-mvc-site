using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BBShop.App.ViewModels;
using KissLog;

namespace BBShop.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        public HomeController(ILogger logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Errors(int id)
        {
            var modelErro = new ErrorViewModel();

            switch (id)
            {
                case 500:
                    modelErro.Message = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                    modelErro.Title = "Ocorreu um erro!";
                    modelErro.ErrorCode = id;

                    _logger.Error(modelErro.Message);
                    break;
                case 404:
                    modelErro.Message = "A página que está procurando não existe! <br/>Em caso de dúvidas entre em contato com nosso suporte.";
                    modelErro.Title = "Ops! Página não encontrada";
                    modelErro.ErrorCode = id;

                    _logger.Error(modelErro.Message);
                    break;
                case 403:
                    modelErro.Message = "Você não tem permissão para fazer isto.";
                    modelErro.Title = "Acesso Negado";
                    modelErro.ErrorCode = id;

                    _logger.Error(modelErro.Message);
                    break;
                default:
                    return StatusCode(404);
            }           


            return View("Error", modelErro);
        }
    }
}
