using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface INotaRepository
    {
        IEnumerable<Notas> GetAllNotas();
        Notas GetNotaById(int id);
        void AddNota(Notas nota);
        void UpdateNota(Notas nota);
        void DeleteNota(int id);
    }
}
