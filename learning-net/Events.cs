using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_net
{
    //Notificar los mensajes
    //Los eventos no devuelven valores
    public class Events
    {

        public string mensajeDelEvento = "";

        public delegate string MessageEventHandler(object sender, CustomEventArgs e);
        public event MessageEventHandler primerEvento;

        public int Divide(int A, int B) {

            int result = 0;

            if (B != 0)
            {
                result = A / B;
            }
            else {

                //El evento devuelve un valor que establece 
                mensajeDelEvento = primerEvento?.Invoke(this, new CustomEventArgs() {
                    A = A,
                    B = B
                });

                result = 0;
            }

            return result;
        }

        public class CustomEventArgs : EventArgs
        {
            public int A;
            public int B;
        }

    }
}
