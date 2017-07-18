using System.Collections.Generic;

namespace TurboMix
{
    public interface IRecetaRepository
    {
        void Delete(Receta receta);
        void Crear(Receta receta);
        Receta Read(string nombreReceta);
        IList<Receta> ShowAll();
        void Update(Receta receta);
    }
}