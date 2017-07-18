using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaRepository : IRecetaRepository
    {
//        public List<Receta> listaRecetas { get; set; }
        private IList<Receta> listaRecetas = new List<Receta>();

        //public RecetaRepository() { }
        //public RecetaRepository(List<Receta> listaRecetas)
        //{
        //    this.listaRecetas = listaRecetas;
        //}

        public void Crear(Receta receta)
        {
            listaRecetas.Add(receta);
        }

        public Receta Read(String nombreReceta)
        {
            Receta receta = new Receta();
            receta.nombre = nombreReceta;
            return receta;
        }

        public IList<Receta> ShowAll()
        {
            //TODO

            return listaRecetas;
        }

        public void Update(Receta receta)
        {
            //TODO
        }

        public void Delete(Receta receta)
        {
            //TODO
        }
    }
}
