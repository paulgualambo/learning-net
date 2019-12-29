using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_net
{
    //Metodos anonimos, 
    //NUll conditional msg?:Invoque(i)
    //Generalmente se usan los metodos anonimos se usan cuando se utilicen
    //una sola vez
    public class AnonymusMethod
    {
        delegate string nombreCompleto(string nombres, string apelliddos);

        //Delegados genricas
        delegate N function1<in M, out N>(M value);

        public string Crear(string val1, string val2)
        {
            nombreCompleto metodoAnonimoFullNameUppper = delegate (string nombres, string apellidos)
            {
                return (nombres + " " + apellidos).ToUpper();
            };

            return metodoAnonimoFullNameUppper(val1, val2);
        }

        public int FunctionAnonimo(int num1, int num2)
        {

            Func<int, int, int> c = delegate (int a, int b)
            {
                return a + b;
            };

            Func<int, int, int> function1 = (int a, int b) =>
            {
                return a + b;
            };

            return c(num1, num2);
        }

    }
}
