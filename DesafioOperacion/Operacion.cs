using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOperacion
{
    class Operacion
    {
        public static void sumar(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} = {2}",num1, num2,num1 + num2);
        }
        public static void restar(int num1, int num2)
        {
            Console.WriteLine("{0} - {1} = {2}",num1,num2,num1 - num2);
        }
    }
}
