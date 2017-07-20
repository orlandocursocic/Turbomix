
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboMix
{
    public class RecetaService : IRecetaService
    {
        public IRecetaRepository recetaRepository { get; set; }

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void anyadeReceta(Receta receta)
        {
            IList<Receta> listaRecetas = recetaRepository.ShowAll();

            bool bFound = false;
            int i = 0;
            while (!bFound && i < listaRecetas.Count())
            {
                if (listaRecetas.ElementAt(i).nombre.Equals(receta.nombre))
                {
                    bFound = true;
                }
                i++;
            }

            if (!bFound)
            {
                recetaRepository.Crear(receta);
            }
            else
            {
                throw new RecetaRepetidaException();
            }
        }

        public void updateReceta(Receta receta)
        {
            IList<Receta> listaRecetas = recetaRepository.ShowAll();

            bool bFound = false;
            int i = 0;
            while (!bFound && i < listaRecetas.Count())
            {
                if (listaRecetas.ElementAt(i).nombre.Equals(receta.nombre))
                {
                    bFound = true;
                }
                i++;
            }

            if (!bFound)
            {
                throw new RecetaNoEncontradaException();
            }
            else
            {
                listaRecetas.ElementAt(i).alimentoPrincipal = receta.alimentoPrincipal;
                listaRecetas.ElementAt(i).alimentoSecundario = receta.alimentoSecundario;

                recetaRepository.Update(listaRecetas.ElementAt(i));
            }
        }

        public void deleteReceta(Receta receta)
        {
            IList<Receta> listaRecetas = recetaRepository.ShowAll();

            bool bFound = false;
            int i = 0;
            while (!bFound && i < listaRecetas.Count())
            {
                if (listaRecetas.ElementAt(i).nombre.Equals(receta.nombre))
                {
                    bFound = true;
                }
                i++;
            }

            if (!bFound)
            {
                throw new RecetaNoEncontradaException();
            }
            else
            {
                recetaRepository.Delete(receta);
            }
        }

        public Receta receta(string nombreReceta)
        {
            IList<Receta> listaRecetas = recetaRepository.ShowAll();

            Receta recetaAux;
            bool bFound = false;
            int i = 0;
            while (!bFound && i < listaRecetas.Count())
            {
                if (listaRecetas.ElementAt(i).nombre.Equals(nombreReceta))
                {
                    bFound = true;
                }
                i++;
            }

            if (!bFound)
            {
                throw new RecetaNoEncontradaException();
            }
            else
            {
                recetaAux = listaRecetas.ElementAt(i);
            }
            return recetaAux;
        }

        public IList<Receta> listReceta()
        {
            return recetaRepository.ShowAll();
        }
    }
}
