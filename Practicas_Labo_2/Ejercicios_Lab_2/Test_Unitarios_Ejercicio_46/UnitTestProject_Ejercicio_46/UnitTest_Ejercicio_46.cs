using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_46_TestUnitarios;

namespace UnitTestProject_Ejercicio_46
{
    [TestClass]
    public class UnitTest_Ejercicio_46
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange

            Competencia nC; 
            //Centralita centralitaPrueba;

            // act
            
            nC = new Competencia(20, 25, Competencia.TipoVehiculo.AutosF1);


            // assert
            Assert.IsNotNull(nC.ListaVehiculosCarrera);


        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void TestMethod2()
        {
            // arrange
            Competencia nC = new Competencia(20, 50, Competencia.TipoVehiculo.MotoCross);

            AutoF1 auto1 = new AutoF1(5,"Ferrari",750);

            // act

            bool pudo = nC + auto1;


            // assert
            //Assert.IsNotNull(centralitaPrueba);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool pudo=false;
            try
            {
                // arrange
                Competencia nC = new Competencia(20, 50, Competencia.TipoVehiculo.MotoCross);

                AutoF1 auto1 = new AutoF1(5, "Ferrari", 750);
                MotoCross moto1 = new MotoCross(5, "Honda", 1000);
                // act

                //pudo = nC + auto1;
                pudo = nC + moto1;
            }
            catch (CompetenciaNoDisponibleException e)
            {
                pudo = false;
            }
            // assert

            Assert.IsTrue(pudo);

        }
        [TestMethod]
        public void TestMethod4()
        {
            bool pudo = false;

            // arrange
            Competencia nC = new Competencia(20, 50, Competencia.TipoVehiculo.MotoCross);

            //AutoF1 auto1 = new AutoF1(5, "Ferrari", 750);
            MotoCross moto1 = new MotoCross(5, "Honda", 1000);
            // act

            //pudo = nC + auto1;
            pudo = nC + moto1;
            pudo = nC - moto1;
            pudo = (nC != moto1);

            // assert

            Assert.IsTrue(pudo);

        }
    }
}
