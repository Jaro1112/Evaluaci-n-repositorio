using System;

namespace trabajo
{

    class TrabajoRequisitos35
    {

        static void Main()
        {
            double Factura;

            double descuento;

            int Cantidadproduc;

            double Precio;

            double Preciobruto;

            double Iva = 0.12;

            double Ivacompra;

            Console.WriteLine("Ingrese el precio del producto");
            Precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad que va a llevar");
            Cantidadproduc = int.Parse(Console.ReadLine());

            Ivacompra = (Precio * Cantidadproduc) * 0.12;

            Console.WriteLine("El iva da un valor de: " + Ivacompra);

            Preciobruto = (Precio * Cantidadproduc) + Ivacompra;

            if (Preciobruto > 50000)
            {

                descuento = Preciobruto * 0.05;

                Factura = Preciobruto - descuento;

            }
            else
            {
                Factura = Preciobruto;

            }

            Console.WriteLine("El precio de la factura es: " + Factura);





        }
    }

}