namespace TurboMix
{
    public interface ITurboMixService
    {
        
        Plato PesarYCalentar(Alimento alimentoPrimero, Alimento alimentoSegundo);
        Plato PrepararReceta(Alimento alimentoPrimero, Alimento alimentoSegundo, Receta r);
    }
}