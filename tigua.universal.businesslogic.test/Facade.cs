using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tigua.universal.businesslogic.Facade;
using tigua.universal.model;

namespace tigua.universal.businesslogic.test
{
    [TestClass]
    public class Facade
    {
        [TestMethod]
        public void TestNotify()
        {
            FCD_Man_Clientes obj = new FCD_Man_Clientes();

            //Se suscribe
            obj.EventNotifyOPeration += (sender, e) =>
            {
                //Grabar en babse de datos

                //Notificar con un correo electronico
            };

            obj.RegistarCliente(new Cliente());


        }
    }
}
