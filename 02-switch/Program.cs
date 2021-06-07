using System;

namespace _02_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string dia;

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda  ";
                    break;
                case 3:
                    dia = "terca";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                default:
                    dia = "invalido";
                    break;
            }

            Console.WriteLine(dia);

        }
    }
}
