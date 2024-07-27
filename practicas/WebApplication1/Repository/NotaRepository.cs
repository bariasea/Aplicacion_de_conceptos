using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;  // Asegúrate de tener el espacio de nombres correcto para EntityState
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class NotaRepository : INotaRepository
    {
        private readonly DbModels _context;

        public NotaRepository(DbModels context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Notas> GetAllNotas()
        {
            return _context.Notas.ToList();
        }

        public Notas GetNotaById(int id)
        {
            return _context.Notas.Find(id);
        }

        public void AddNota(Notas nota)
        {
            _context.Notas.Add(nota);
            _context.SaveChanges();
        }

        public void UpdateNota(Notas nota)
        {
            _context.Entry(nota).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteNota(int id)
        {
            var nota = _context.Notas.Find(id);
            if (nota != null)
            {
                _context.Notas.Remove(nota);
                _context.SaveChanges();
            }
        }
    }
}
