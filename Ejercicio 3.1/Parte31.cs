using System;
using System.Text;



namespace ejercicio 31
{
    public class class
    {
        public static void Main()
        {
            int numb1;
            int numb2;

            Console.WriteLine("Digite dos numeros y le diremos cual de los dos numero es el mayor");

            Console.WriteLine("Digite el primer numero");
            numb1=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite el segundo numero");
            numb2 = Convert.ToInt32(Console.ReadLine());


            if (numb1>numb2)
            {
                Console.WriteLine($"El numero mayor es* :{numb1}");
            }
            else if (numb2>numb1)
            {
                Console.WriteLine($"El numero mayor es:{numb2}");
            }
                


        }
    }
}
