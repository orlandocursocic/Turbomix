namespace TurboMix
{
    public interface IRecetaService
    {
        IRecetaRepository recetaRepository { get; set; }

        void Actualizar(Receta receta);
        void Aniadir(Receta receta);
        void Borrar(Receta receta);
        void Leer(string receta);
        void ListarTodo();
    }
}