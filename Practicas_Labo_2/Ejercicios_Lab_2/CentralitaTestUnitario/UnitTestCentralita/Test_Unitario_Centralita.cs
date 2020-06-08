using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaPolimorfismo;

namespace UnitTestCentralita
{
    [TestClass]
    public class Test_Unitario_Centralita
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange

            Centralita centralitaPrueba; 

            // act

            centralitaPrueba = new Centralita("Centralita Prueba");
            
            // assert
            Assert.IsNotNull(centralitaPrueba);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethod2()
        {
            // arrange

            Centralita centralitaPrueba = new Centralita("Centralita Prueba"); ;
            Llamada l1 = new Local("local", 20.5f, "local1", 20.5f);
            Llamada l2 = new Local(l1, 20.5f);
            // act

            centralitaPrueba += l1;
            centralitaPrueba += l2;

            // assert
            //Assert.IsNotNull(centralitaPrueba);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestMethod3()
        {
            // arrange
            

            Centralita centralitaPrueba = new Centralita("Centralita Prueba"); ;
            Llamada l1 = new Provincial("Varela",Provincial.Franja.Franja_1,30,"Pehuajo");
            Llamada l2 = new Provincial(Provincial.Franja.Franja_1,l1);

            // act

            centralitaPrueba += l1;
            centralitaPrueba += l2;

            // assert
            //Assert.IsNotNull(centralitaPrueba);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // arrange
            bool compara=false;
            
            Llamada l1 = new Local("Varela", 20.5f, "Pehuajo", 20.5f);
            Llamada l2 = new Local("Varela", 20.5f, "Pehuajo", 20.5f);

            Llamada l3 = new Provincial("Varela", Provincial.Franja.Franja_1, 30, "Pehuajo");
            Llamada l4 = new Provincial("Varela", Provincial.Franja.Franja_1, 30, "Pehuajo");

            // act
            if ((l1 == l2 && l1 !=l3 && l1 != l4) &&
                (l2 != l3 && l2 != l4) &&
                (l3 == l4))
            {
                compara = true;
            }

            // assert

            Assert.IsTrue(compara);

        }
    }
}
