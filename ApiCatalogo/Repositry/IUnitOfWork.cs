namespace ApiCatalogo.Repositry
{
    public interface IUnitOfWork
    {
        IProdutoRepository ProdutoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }
        void Commit();
    }
}
