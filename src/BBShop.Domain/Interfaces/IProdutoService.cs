using BBShop.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace BBShop.Domain.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
