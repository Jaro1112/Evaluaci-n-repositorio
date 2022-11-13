using System;
using System.Text;


namespace ejercicio_41
{
    public class program
    {
        public static int Main(object suma)
        {
            int i;
            float n, sum;
            i = 1;
            sum = 0;
            while (i <= 10)
            {
              Console.WriteLine ("Ingresa un numero: ");
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
                i++;
            }
            Console.WriteLine ($"La suma de los 10 numeros es:",suma);
            return 0;
        }
    }
