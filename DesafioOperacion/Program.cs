using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese un primer numero:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese un segundo numero:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Operacion.sumar(num1,num2);
                Operacion.restar(num1,num2);


                Console.WriteLine("Toque cualquier tecla para finalizar...");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);                
            }
           

        }
    }
}
