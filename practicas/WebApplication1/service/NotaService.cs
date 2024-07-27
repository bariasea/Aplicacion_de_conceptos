using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Services
{
    public interface INotaService
    {



        IEnumerable<Notas> GetAllNotas();
        Task<Notas> GetNotaByIdAsync(int id);



        Task AddNotaAsync(Notas nota);




        void UpdateNota(Notas nota);
        void DeleteNota(int id);

        Task LongRunningOperationAsync(); 
    }

    public class NotaService : INotaService
    {
        private readonly INotaRepository _notaRepository;

        public NotaService(INotaRepository notaRepository)
        {
            _notaRepository = notaRepository;
        }

        public IEnumerable<Notas> GetAllNotas()
        {
            return _notaRepository.GetAllNotas();
        }






        public Task<Notas> GetNotaByIdAsync(int id)
        {
            return Task.FromResult(_notaRepository.GetNotaById(id));
        }





        public Task AddNotaAsync(Notas nota)
        {
            _notaRepository.AddNota(nota);
            return Task.CompletedTask;
        }











        public void UpdateNota(Notas nota)
        {
            _notaRepository.UpdateNota(nota);
        }

        public void DeleteNota(int id)
        {
            _notaRepository.DeleteNota(id);
        }

        public async Task LongRunningOperationAsync()
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
            });
        }
    }

}