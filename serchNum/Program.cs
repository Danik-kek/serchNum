using System.Globalization;

namespace serchNum_preRelease
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter n ");
            String inp = Console.ReadLine();
            bool apruvde = int.TryParse(inp, out int N);
            if (apruvde == true)
            {
                if (20 < N && N < 35)
                {
                    Console.WriteLine("n - в нашем диапозоне ");
                }
                else
                {
                    Console.WriteLine("это левое число ");
                }

            }
            else
            {
                Console.WriteLine("не балуйся другими типами данных ");
                Main();
            }
        }
    }
}
