using ApiCatalogo.Models;
using ApiCatalogo.Pagination;

namespace ApiCatalogo.Repositry.Interface
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasProdutos();

        PagedList<Categoria> GetCategorias(CategoriasParameters categoriasParameters);
    }
}
