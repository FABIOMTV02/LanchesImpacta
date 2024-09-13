using LanchesImpacta.Models;

namespace LanchesImpacta.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
