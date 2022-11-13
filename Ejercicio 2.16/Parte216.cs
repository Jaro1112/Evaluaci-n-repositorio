namespace trabajo
{

    class TrabajoRequisitos216
    {

        static void Main()
        {
            //2.16

            int Sumados = 0;

            for (int i = 1; i < 11; i++)
            {
                Sumados = i * (i + 1) / 2;

            }

            Console.WriteLine("La suma de los numeros del 1 al 10 es: " + Sumados);


        }
    }

}