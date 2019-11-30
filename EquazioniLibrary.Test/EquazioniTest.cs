using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.isDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 5;
            double b = 0;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.isDetermined(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public void TestIsInconsided()
        {
            double a = 0;
            double b = 4;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsInconsident1()
        {
            double a = 7;
            double b = 4;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsDegree2()
        {
            double a = 3;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestIsDegree21()
        {
            double a = 10;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestDelta()
        {
            double a = 2;
            double b = 7;
            double c = 3;
            double risposta_aspettata = 25;
            double risposta = Equazioni.TestDelta(a, b, c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public static void TestDelta1()
        {
            double a = 3;
            double b = 7;
            double c = 4;
            double risposta_aspettata = 12 ;
            double risposta = Equazioni.TestDelta(a,b,c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
    }
}
