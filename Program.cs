using System;

namespace CSharp04
{
    class Program
    {
        static void Main(string[] args)
        {
            float pTotal = 0;

            Console.WriteLine("Month: ");
            string month = Console.ReadLine();

            Console.WriteLine("Import: ");
            float import = Convert.ToSingle(Console.ReadLine());

            switch(month.ToUpper()){
                case "OCTUBRE":
                case "DICIEMBRE":
                {
                    pTotal = import - (import * 0.15f);
                    break;
                }
                default:
                {
                    pTotal = import;
                    break;
                }
            }

            Console.WriteLine($"Price Total: {pTotal}");
        }
    }
}
