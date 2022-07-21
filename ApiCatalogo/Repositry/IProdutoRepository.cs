using ApiCatalogo.Models;

namespace ApiCatalogo.Repositry
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        IEnumerable<Produto> GetProdutoPorPreco();
    }
}
