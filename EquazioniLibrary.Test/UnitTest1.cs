using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(5)]
        [DataRow(-5)]
        public void IsDeterminedTest(double a)
        {
            bool risposta_attesa = true;

            bool risposta = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [TestMethod]
        public void IsDeterminedTest2()
        {
            double a = 0;
            bool risposta_attesa = false;

            bool risposta = EquazioniLibrary.Equazioni.IsDetermined(a);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 0, b = 10;
            bool risposta_attesa = true;

            bool risposta = EquazioniLibrary.Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [DataTestMethod]
        [DataRow(10, 0)]
        [DataRow(0, 0)]
        public void IsInconsistedTest2(double a, double b)
        {
            bool risposta_attesa = false;

            bool risposta = EquazioniLibrary.Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [TestMethod]
        public void IsIndeterminedTest()
        {
            double a = 0, b = 0;
            bool risposta_attesa = true;

            bool risposta = EquazioniLibrary.Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [DataTestMethod]
        [DataRow(11, 0)]
        [DataRow(0, 11)]
        public void IsIndeterminedTest2(double a, double b)
        {
            bool risposta_attesa = false;

            bool risposta = EquazioniLibrary.Equazioni.IsIndetermined(a, b);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [DataTestMethod]
        [DataRow(5, 0, -5)]
        [DataRow(5, -5, 0)]
        [DataRow(-5, 0, 5)]
        [DataRow(-5, 5, 0)]
        public void IsDegree2Test(double a, double b, double c)
        {
            bool risposta_attesa = true;

            bool risposta = EquazioniLibrary.Equazioni.IsDegree2(a, b, c);

            Assert.AreEqual(risposta_attesa, risposta);
        }

        [DataTestMethod]
        [DataRow(0, 0, 5)]
        [DataRow(0, 5, 0)]
        public void IsDegree2Test3(double a, double b, double c)
        {
            bool risposta_attesa = false;

            bool risposta = EquazioniLibrary.Equazioni.IsDegree2(a, b, c);

            Assert.AreEqual(risposta_attesa, risposta);
        }
    }
}
