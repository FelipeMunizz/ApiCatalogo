using ApiCatalogo.Data;
using ApiCatalogo.Repositry.Interface;

namespace ApiCatalogo.Repositry
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProdutoRepository _produtoRepo;
        private CategoriaRepository _categoriaRepo;
        public AppDbContext _context;
        public UnitOfWork(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IProdutoRepository ProdutoRepository
        {
            get
            {
                return _produtoRepo = _produtoRepo ?? new ProdutoRepository(_context);
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepo = _categoriaRepo ?? new CategoriaRepository(_context);
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
