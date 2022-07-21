using ApiCatalogo.Models;

namespace ApiCatalogo.Repositry
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
