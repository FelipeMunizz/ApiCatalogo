using ApiCatalogo.Models;
using ApiCatalogo.Pagination;

namespace ApiCatalogo.Repositry.Interface
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<PagedList<Produto>> GetProdutos(ProdutosParameters produtosParameters);
        Task<IEnumerable<Produto>> GetProdutoPorPreco();
    }
}
