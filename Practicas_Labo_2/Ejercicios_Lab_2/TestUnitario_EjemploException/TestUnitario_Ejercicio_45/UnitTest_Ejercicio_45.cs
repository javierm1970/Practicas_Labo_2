using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exception_Ejercicio_45;

namespace TestUnitario_Ejercicio_45
{
    [TestClass]
    public class UnitTest_Ejercicio_45
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod1()
        {
            // arrange

            MiClase mC;

            // act

            mC = new MiClase();

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestMethod2()
        {
            // arrange

            //OtraClase oC = new OtraClase();
            MiClase mC;

            // act

            mC = new MiClase(0);

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod3()
        {
            // arrange

            // act

            MiClase.LanzarException();

            // assert
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMethod4()
        {
            // arrange
            OtraClase oC = new OtraClase();

            // act

            oC.MetodoDeInstancia();

            // assert
        }

    }
}
