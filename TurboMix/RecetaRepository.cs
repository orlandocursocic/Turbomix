using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaRepository : IRecetaRepository
    {
        private List<Receta> listaRecetas = new List<Receta>();

        public void Crear(Receta receta)
        {
            listaRecetas.Add(receta);
        }

        public void Update(Receta receta)
        {
            //TODO
        }

        public void Delete(Receta receta)
        {
            listaRecetas.Remove(receta);
        }

        public Receta Read(String nombreReceta)
        {
            // TODO
            //return listaRecetas
            return null;
        }

        public IList<Receta> ShowAll()
        {
            return listaRecetas;
        }
    }
}
