namespace GgtKgv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            ReadInt(out first, out second);
            Console.WriteLine($"ggt von {first} und {second} ist");
        }

        public static void ReadInt(out int first, out int second) {
            Console.WriteLine("Zahl 1: ");
            first = Console.Read();
            Console.WriteLine("Zahl: ");
            second = Console.Read();

        }
    }
}
