using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Pagination;
using ApiCatalogo.Repositry.Interface;

namespace ApiCatalogo.Repositry
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context) { }

        public IEnumerable<Produto> GetProdutoPorPreco()
        {
            return Get().OrderBy(c => c.Preco).ToList();
        }

        public PagedList<Produto> GetProdutos(ProdutosParameters produtosParameters)
        {
            return PagedList<Produto>.ToPagedList(Get().OrderBy(on => on.ProdutoId), 
                produtosParameters.PageNumber, produtosParameters.PageSize);
        }
    }
}
