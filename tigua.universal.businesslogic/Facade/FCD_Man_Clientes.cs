using System;
using tigua.universal.model;

namespace tigua.universal.businesslogic.Facade
{
    public delegate void NotifiyOperation(object sender, EventArgs e);


    public class FCD_Man_Clientes
    {
        public event NotifiyOperation EventNotifyOPeration;

        public Cliente RegistarCliente(Cliente cliente)
        {

            try
            {
                EventNotifyOPeration?.Invoke(this, new NotifyMessagEventArgs()
                {
                    Message = "Operación completada"
                });
            }
            catch (Exception ex)
            {
                EventNotifyOPeration?.Invoke(this, new NotifyMessagEventArgs()
                {
                    Message = $"Operación no completada {ex.Message}"
                });
                //throw ex;
            }

            return cliente;
        }
    }

    public class NotifyMessagEventArgs :  EventArgs
    {
        public string Message;
    }
}
