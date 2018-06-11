using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicioteste;

namespace Test1exe
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            Aluno aluno = new Aluno();
            aluno.cod = 1;
            aluno.nomep = "Felipe Vozgeral Çanca";
            aluno.data = new DateTime(1990, 04, 01);
            Assert.IsFalse(false);


        }


        [TestMethod]
        public void TestMethod2()
        {
            Aluno aluno = new Aluno();
            aluno.cod = 2;
            aluno.nomep = "Alin@  Branca";
            aluno.data = new DateTime(2020, 01, 01);
            Assert.IsFalse(false);


        }

        [TestMethod]
        public void TestMethod3()
        {
            Aluno aluno = new Aluno();
            aluno.cod = 3;
            aluno.nomep = " Alfredo Sella III";
            aluno.data = new DateTime(1986, 12, 03);
            Assert.IsFalse(false);


        }




    }
}
