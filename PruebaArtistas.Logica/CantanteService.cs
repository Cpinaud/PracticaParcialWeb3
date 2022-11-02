using PruebaArtistas.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaArtistas.Logica
{
    public interface ICantanteService
    {
        List<Cantante> getCantantes();
        void InsertCantante(Cantante cantante);
    }

    public class CantanteService : ICantanteService
    {

        private PruebaArtistasContext _context;
        public CantanteService(PruebaArtistasContext context)
        {
            _context = context;
        }

        public List<Cantante> getCantantes()
        {
            return _context.Cantantes.ToList();
        }

        public void InsertCantante(Cantante cantante)
        {
            _context.Cantantes.Add(cantante);
            _context.SaveChanges();
        }
    }
}
