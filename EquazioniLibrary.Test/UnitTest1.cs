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
    }
}
