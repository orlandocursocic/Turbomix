using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurboMix;
using Microsoft.Practices.Unity;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaIntegracionTest
    {
        IUnityContainer container;
        Receta receta;

        [TestInitialize]
        public void testInit()
        {
            container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            receta = new Receta();
        }

        [TestMethod]
        public void TestMethod1()
        {
            IRecetaService sut = container.Resolve<IRecetaService>();

            sut.Aniadir(receta);
        }
    }
}
