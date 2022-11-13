namespace trabajo
{

    class TrabajoRequisitos24
    {

        static void Main()
        {
            //2.4


            int primero;
            int segundo;
            int tercero;
            int cuarto;

            int Suma;
            double media;
            int producto;

            Console.WriteLine("Ingrese el valor del primer numero");
            primero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo numero:");
            segundo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del tercer numero:");
            tercero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cuarto numero:");
            cuarto = int.Parse(Console.ReadLine());

            producto = primero * segundo * tercero * cuarto;

            Console.WriteLine("El resultado del producto es: " + producto);

            Suma = primero + segundo + tercero + cuarto;

            Console.WriteLine("El resultado de la suma es: " + Suma);

            media = Suma / 4;

            Console.WriteLine("La media aritmetica es: " + media);


        }
    }

}