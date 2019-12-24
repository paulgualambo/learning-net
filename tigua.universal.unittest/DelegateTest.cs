using System;
using learning_net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tigua.universal.unittest
{
    [TestClass]
    public class DelegateTest
    {
        [TestMethod]
        public void Creacion()
        {
            Delegado obj = new Delegado();

            bool result = obj.Crear();

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void AddDelegate()
        {
            Delegado obj = new Delegado();

            string result = obj.AddDelegates("pauL");

            Assert.AreEqual(result, "PAUL paul ");
        }


        [TestMethod]
        public void Action()
        {
            Delegado obj = new Delegado();

            int result = obj.Action(2);

            Assert.AreEqual(result, 12);
        }


        [TestMethod]
        public void Function()
        {
            Delegado obj = new Delegado();

            int result = obj.Function(2);

            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void FunctionToFunction()
        {
            Delegado obj = new Delegado();

            int result = obj.FunctionToFunction(2);

            Assert.AreEqual(result, 16);
        }
    }
}
