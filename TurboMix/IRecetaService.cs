using System.Collections.Generic;

namespace TurboMix
{
    public interface IRecetaService
    {
        IRecetaRepository recetaRepository { get; set; }

        void updateReceta(Receta receta);
        void anyadeReceta(Receta receta);
        void deleteReceta(Receta receta);
        Receta receta(string nombreReceta);
        IList<Receta> listReceta();
    }
}