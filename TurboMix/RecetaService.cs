
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

        public void Aniadir(Receta receta)
        {
            recetaRepository.Crear(receta);
        }

        public void Leer(String receta)
        {
            recetaRepository.Read(receta);
        }

        public void Actualizar(Receta receta)
        {
            recetaRepository.Update(receta);
        }

        public void Borrar(Receta receta)
        {
            recetaRepository.Delete(receta);
        }

        public void ListarTodo()
        {
            recetaRepository.ShowAll();
        }
    }
}
