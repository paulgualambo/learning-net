using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using learning_net;

namespace tigua.universal.unittest
{
    /// <summary>
    /// Descripción resumida de Eventos
    /// </summary>
    [TestClass]
    public class EventosTest
    {
        public EventosTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Creacion()
        {
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //

            Events e = new Events();

            e.primerEvento += E_primerEvento;

            e.Divide(3, 0);

            Assert.AreEqual(e.mensajeDelEvento, "La división no puede tener un dividendo de cero");
        }

        private string E_primerEvento(object sender, Events.CustomEventArgs e)
        {
            return $"La división no puede tener un dividendo de cero";
        }
    }
}
