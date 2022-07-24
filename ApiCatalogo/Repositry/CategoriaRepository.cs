using ApiCatalogo.Data;
using ApiCatalogo.Models;
using ApiCatalogo.Pagination;
using ApiCatalogo.Repositry.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Repositry
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base (context) { }

        public async Task<PagedList<Categoria>> GetCategorias(CategoriasParameters categoriasParameters)
        {
            return await PagedList<Categoria>.ToPagedList(Get().OrderBy(on => on.CategoriaId),
                categoriasParameters.PageNumber,
                categoriasParameters.PageSize);
        }

        public async Task<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return await Get().Include(x => x.Produtos).ToListAsync();
        }
    }
}
