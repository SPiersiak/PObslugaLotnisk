using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aplikacja;

namespace LogTest
{
    [TestClass]
    public class MainWindowTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string login = "login";
            string haslo = "haslo";
            int oczekiwany_wynik = 1;
            int test;
            //act
            if (((login == "") && (haslo == "")) || (login == "") || (haslo == ""))
            {
                test = 0;
            }
            else
            {
                test = 1;
            }
            //assert
            Assert.AreEqual(oczekiwany_wynik, test, 0.001, "Not Correctly");
        }
    }
}
