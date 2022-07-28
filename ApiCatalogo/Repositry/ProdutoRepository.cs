using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Pagination;
using ApiCatalogo.Repositry.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repositry
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Produto>> GetProdutoPorPreco()
        {
            return await Get().OrderBy(c => c.Preco).ToListAsync();
        }

        public async Task<PagedList<Produto>> GetProdutos(ProdutosParameters produtosParameters)
        {
            return await PagedList<Produto>.ToPagedList(Get().OrderBy(on => on.ProdutoId), 
                produtosParameters.PageNumber, produtosParameters.PageSize);
        }
    }
}
