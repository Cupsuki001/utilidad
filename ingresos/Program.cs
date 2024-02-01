// See https://aka.ms/new-console-template for more information
using ingresos;

public class trabajo 
{
  public static void Main(string[] args) 
  {
        double ig , eg , tt;
        Class1 v = new Class1();

        do 
        {
            ig = v.validar("Digite su Ingreso: ");
            Console.WriteLine("------------------//");

        }while (ig < 1000 || ig > 50000 );

        do
        {
            eg = v.validar("Digite su egreso: ");
            Console.WriteLine("------------------//");

        } while (eg >= ig);

         v.util(ig,eg);
         v.rest();


    }
}
