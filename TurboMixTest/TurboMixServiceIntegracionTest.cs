using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;
using Microsoft.Practices.Unity;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixServiceIntegracionTest
    {
        private Alimento alimento1;
        private Alimento alimento2;
        private Alimento alimentoCocinado1;
        private Alimento alimentoCocinado2;

        IUnityContainer container;

        [TestInitialize]
        public void init()
        {
            container = new UnityContainer();
            container.RegisterType<IBasculaService, BasculaService>();
            container.RegisterType<ICocinaService, CocinaService>();
            container.RegisterType<ITurboMixService, TurboMixService>();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            //IBasculaService basculaService = new BasculaService();
            //ICocinaService cocinaService = new CocinaService();

            ITurboMixService sut = container.Resolve<ITurboMixService>();
            alimento1 = new Alimento();
            alimento1.Peso = 1.5f;
            alimento1.Calentado = true;
            alimento2 = new Alimento();
            alimento2.Peso = 5f;
            alimento2.Calentado = true;

            alimentoCocinado1 = new Alimento();
            alimentoCocinado1.Peso = 1.5f;
            alimentoCocinado1.Calentado = true;
            alimentoCocinado2 = new Alimento();
            alimentoCocinado2.Peso = 5f;
            alimentoCocinado2.Calentado = true;
        }

        [TestMethod]
        public void TestPesarYCalentar()
        {
            ITurboMixService sut = container.Resolve<ITurboMixService>();

            Plato resultado = sut.PesarYCalentar(alimento1, alimento2);
            
            Plato mPlato = new Plato(alimento1, alimento2);
            Assert.AreNotEqual(mPlato, resultado);
        }

        [TestMethod]
        public void TestPesarYCocinarReceta()
        {
            ITurboMixService sut = container.Resolve<ITurboMixService>();

            Plato resultado = sut.PesarYCalentar(alimento1, alimento2);

            Plato mPlato = new Plato(alimento1, alimento2);
            Assert.AreNotEqual(mPlato, resultado);
        }
    }
}
