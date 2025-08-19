namespace GgtKgv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Operation waehlen (ggt/kgv/ende): ");
                string? op = Console.ReadLine()?.Trim().ToLower();

                if (op == "ende") break;
                if (op != "ggt" && op != "kgv")
                {
                    Console.WriteLine("Unbekannte Eingabe.\n");
                    continue;
                }

                ReadInt(out int first, out int second);

                int result = (op == "ggt")
                    ? MyMath.Calc_ggT(first, second)
                    : MyMath.Calc_kgV(first, second);

                ShowResult(op, first, second, result);
            }


            int[] arr = { 4, 7, 2, 9, 5 };
            Console.WriteLine($"Mittelwert: {MyMath.ArrayMean(arr)}");
            Console.WriteLine($"Minimum: {MyMath.ArrayMin(arr)}");
            Console.WriteLine($"Maximum: {MyMath.ArrayMax(arr)}");

            int a = 3, b = 8;
            Console.WriteLine($"Vor Swap: a={a}, b={b}");
            MyMath.Swap(ref a, ref b);
            Console.WriteLine($"Nach Swap: a={a}, b={b}");
        }

        public static void ReadInt(out int first, out int second)
        {
            first = ReadPositiveInt("Zahl 1: ");
            second = ReadPositiveInt("Zahl 2: ");
        }

        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();

                if (int.TryParse(s, out int value) && value > 0)
                    return value;

                Console.WriteLine("Bitte eine positive ganze Zahl eingeben.");
            }
        }

        public static void ShowResult(string op, int a, int b, int result)
        {
            Console.WriteLine($"{op} von {a} und {b} ist {result}\n");
        }
    }
}
