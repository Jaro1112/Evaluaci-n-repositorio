using System;
namespace trabajo4
{

    class clase
    {

        static public void Main()
        {


            // 4.7


            int Numerouno;

            int Numerodos;




            Console.WriteLine("Escriba el numero mayor: ");
            Numerouno = int.Parse(Console.ReadLine());


            Console.WriteLine("Escriba el numero menor: ");
            Numerodos = int.Parse(Console.ReadLine());

            if (Numerouno % Numerodos == 0)
            {

                Console.WriteLine(Numerodos + " es divisor de " + Numerouno);

            }
            else
            {

                Console.WriteLine(Numerodos + " no es divisor de " + Numerouno);

            }









        }
    }

}
