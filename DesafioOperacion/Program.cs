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
            int num1, num2;

            try
            {
                Console.Write("Ingrese un primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese un segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSuma: " + Operacion.sumar(num1, num2));
                Console.WriteLine("Resta: " + Operacion.restar(num1, num2));

                Console.WriteLine("\nToque cualquier tecla para finalizar...");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);                
            }
           

        }
    }
}
