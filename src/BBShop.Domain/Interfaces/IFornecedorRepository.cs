using BBShop.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace BBShop.Domain.Interfaces
{
    public interface IFornecedorRepository :  IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
