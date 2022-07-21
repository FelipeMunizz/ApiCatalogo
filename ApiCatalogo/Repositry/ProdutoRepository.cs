using ApiCatalogo.Data;
using ApiCatalogo.Models;

namespace ApiCatalogo.Repositry
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context) { }

        public IEnumerable<Produto> GetProdutoPorPreco()
        {
            return Get().OrderBy(c => c.Preco).ToList();
        }
    }
}
