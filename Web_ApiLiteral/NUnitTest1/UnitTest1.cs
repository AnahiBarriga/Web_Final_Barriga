using NUnit.Framework;
using Web_ApiLiteral.Controllers;

namespace NUnitTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestNumeroGet()
        {
            //Arrange=Preparacion
            string num1 = "0";
            string esperado = "Cero";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestNumeroPost()
        {
            //Arrange=Preparacion
            string num1 = "0";
            string esperado = "Cero";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestsNumeroGet()
        {
            //Arrange=Preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestsNumeroPost()
        {
            //Arrange=Preparacion
            string num1 = "5";
            string esperado = "Cinco";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestssssNumeroGet()
        {
            //Arrange=Preparacion
            string num1 = "10";
            string esperado = "Diez";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestssNumeroPost()
        {
            //Arrange=Preparacion
            string num1 = "10";
            string esperado = "Diez";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TTTestssssNumeroGet()
        {
            //Arrange=Preparacion
            string num1 = "3";
            string esperado = "Tres";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TTestssNumeroPost()
        {
            //Arrange=Preparacion
            string num1 = "3";
            string esperado = "Tres";

            LiteralController lit = new LiteralController();
            //Act=Ejecucion
            string resultado = lit.NumeroGet(num1);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }







    }

}
