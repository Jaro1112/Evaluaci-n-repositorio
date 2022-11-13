using System;
using System.Text;
namespace trabajo4
{

    class clase
    {

        static public void Main()
        {


            // 4.9

            int N3;
            int N4;
            String SoR;
            int Result;

            Console.WriteLine("Escriba el primer numero: ");
            N3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero: ");
            N4 = int.Parse(Console.ReadLine());


            Console.WriteLine("Para suma Digite S para Resta Digite R ");
            SoR = Console.ReadLine();

            switch (SoR)
            {
                case "s":

                    Result = N3 + N4;
                    Console.WriteLine($"El resultado es: {Result}");
                    break;

                case "r":

                    Result = N3 - N4;
                    Console.WriteLine($"El resultado es: {Result}");
                    break;

                default:
                    Console.WriteLine("No selecciono suma o resta");
                    break;

            }









        }
    }

}
