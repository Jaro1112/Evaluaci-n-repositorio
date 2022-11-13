using System;
using System.Text;

namespace ejercicio517
{
    class clase
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un valor entre 1 y 3000");
            n = int.Parse(Console.ReadLine());
            if (n <= 3000 && 0 < n)
            {
                
                Console.WriteLine("Valor inicial: " + n);
                Console.WriteLine("Valor en numeros romanos:");
                Console.WriteLine(int_rom(n));
            }
            else
            {
                Console.WriteLine("El numero debe estar entre 1 y 3000");
            }
        }

        public static string int_rom(int n)
        {
            string[] simb_rom = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] int_valor = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var num_rom = new StringBuilder();
            var indi_num = 0;
            while (n != 0)
            {
                if (n >= int_valor[indi_num])
                {
                    n -= int_valor[indi_num];
                    num_rom.Append(simb_rom[indi_num]);
                }
                else
                {
                    indi_num++;
                }
            }

            return num_rom.ToString();
        }
    }
}