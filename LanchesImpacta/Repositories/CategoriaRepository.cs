using LanchesImpacta.Context;
using LanchesImpacta.Models;
using LanchesImpacta.Repositories.Interfaces;

namespace LanchesImpacta.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
