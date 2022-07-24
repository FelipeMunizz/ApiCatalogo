using ApiCatalogo.Models;
using ApiCatalogo.Pagination;

namespace ApiCatalogo.Repositry.Interface
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<IEnumerable<Categoria>> GetCategoriasProdutos();

        Task<PagedList<Categoria>> GetCategorias(CategoriasParameters categoriasParameters);
    }
}
