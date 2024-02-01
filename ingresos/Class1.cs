using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingresos
{
    internal class Class1
    {
        double a , b , u;

        public Class1 () { }
        public Class1(double a , double b) 
        {
          this.a = a;
            this.b = b;
        }

        public void util(double a, double b) 
        {
            u = a - b;
        }

        public void rest()
        {
            Console.WriteLine("La utilidad es: "+ u);
        }
        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("No se aceptan letras", error.Message);
                    Console.WriteLine("////////////////////////////////////");
                  
                }
            } while (v == 0);
            return num;
        }
    }
}
