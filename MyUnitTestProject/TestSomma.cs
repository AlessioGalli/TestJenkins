using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestJenkins;

namespace MyUnitTestProject
{
    [TestClass]
    public class TestSomma
    {
        [TestMethod]
        public void SommaOK()
        {
            // Arrange
            Program testJenkins = new Program();

            string uno = "4";
            string due = "3";
            // Act
            string esito = testJenkins.FaiSomma(uno, due);

            //// Assert
            //Assert.IsTrue(Int32.TryParse(esito, out int iEsito),"Esito non intero");
            //Assert.AreEqual(iEsito, 7f, 0,"Somma sbagliata");
        }
    }
}
