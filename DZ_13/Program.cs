namespace DZ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var pair1 = new Pair<int, string>(777, "MEEAT");
            var pair2 = new Pair<double, bool>(0.3333333333333, true);
            var pair3 = new Pair<char, char>('G', 'G');


            Console.WriteLine($"Pair 1: ({pair1.First}, {pair1.Second})");
            Console.WriteLine($"Pair 2: ({pair2.First}, {pair2.Second})");
            Console.WriteLine($"Pair 3: ({pair3.First}, {pair3.Second})");


        }
    }
}