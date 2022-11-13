using System;
using System.Text;


namespace ejercicio44
{
    public class clase
    {
        public static void Main()
        {
            int edad= 1 , suma = 0, c = 0;
            float promedio; 
            while(edad!= 0)
            {
                Console.WriteLine("ingrese una edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                if (edad > 0)
                {
                    suma = suma + edad;
                    c++;
                }
            }

            promedio = suma / c;
            Console.WriteLine("el promedio es:"+promedio);
        }
    }
}
