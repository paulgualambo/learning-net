using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tigua.universal.model;

namespace learning_net
{
    /// <summary>
    /// Un delegado es un tipo de dato, que es un puntero a un metodo
    /// referencia a un metodo, tipo de datos que almacenan direcciones de 
    /// memoria hacia un metodo, y deben especificar 
    /// 
    /// 
    /// Sobrecarga de metodos 
    /// Firma de metodos
    /// 
    /// Un delegate es un tipo de referencia que puede utilizarse para encapsular un método 
    /// con nombre o anónimo.Los delegados son similares a los punteros a funciones 
    /// de C++, pero son más seguros y proporcionan mayor seguridad de tipos
    /// 
    /// 
    /// Un delegado es un tipo que representa referencias a métodos con una lista de 
    /// parámetros determinada y un tipo de valor devuelto. 
    /// Cuando se crea una instancia de un delegado, puede asociar su instancia 
    /// a cualquier método mediante una firma y un tipo de valor 
    /// devuelto compatibles. Puede invocar (o llamar) al método a través 
    /// de la instancia del delegado.
    /// 
    /// 
    /// 
    /// Se maneja con Eventos y Multitarea
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
    /// 
    /// 
    /// </summary>
    public class Delegado
    {
        //private delgateFullName mostrarNombreCompleto;

        public Delegado() {
            //PruebaDelegado = (Money m, EventArgs e) =>
            //{
            //    Console.WriteLine("Ingreso al delegado");
            //};
        }

        public bool Crear() {

            bool result = false;

            try
            {
                firstDelegate _delegate = implementacionFirstDelegate;
                _delegate("Test");

                return true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;

        }

        public string AddDelegates(string arg) {
            string result = "";

            try
            {
                addDelegate firstDel = (string cadena) =>
                {
                    result += cadena.ToUpper()+" ";
                };

                addDelegate secondDel = (string cadena) =>
                {
                    result += cadena.ToLower() + " ";
                };

                addDelegate finalDel = firstDel + secondDel;

                finalDel(arg);
                return result;
            }
            catch (Exception)
            {

                //throw;
            }

            return result;
        }


        public int Action(int val)
        {

            int result = 0;

            try
            {
                Action<int> _action1 = (int arg) =>
                {
                    result += arg;
                };

                Action<int> _action2 = (int arg) =>
                {
                    result += 2*arg;
                };

                Action<int> _action3 = (int arg) =>
                {
                    result += 3*arg;
                };

                Action<int> actionresult = _action1+_action2+_action3;

                actionresult(val);

                return result;
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }


        public int Function(int val)
        {

            int result = 0;

            try
            {
                Func<int, int> _function1 = (int arg) =>
                {
                    return arg;
                };

                Func<int, int> _function2 = (int arg) =>
                {
                    return 2*arg;
                };

                Func<int, int> _function3 = (int arg) =>
                {
                    return 4 * arg;
                };

                Func<int, int> functionResult = _function1 + _function2 + _function3;

                result = functionResult(val);

                return result;
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        public int FunctionToFunction(int val)
        {

            int result = 0;

            try
            {
                Func<int, int> _function1 = (int arg) =>
                {
                    return arg;
                };

                Func<int, int> _function2 = (int arg) =>
                {
                    return 2 * arg;
                };

                Func<int, int> _function3 = (int arg) =>
                {
                    return 4 * arg;
                };
                

                result = _function1(_function2(_function3(val)));

                return result;
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        private void implementacionFirstDelegate(string arg) {
            
        }
    }

    internal delegate void firstDelegate(string arg);

    internal delegate void addDelegate(string arg);

    internal delegate string delgateFullName(Cliente cliente);
}
