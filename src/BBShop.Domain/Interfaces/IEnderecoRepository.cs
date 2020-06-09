using BBShop.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace BBShop.Domain.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
