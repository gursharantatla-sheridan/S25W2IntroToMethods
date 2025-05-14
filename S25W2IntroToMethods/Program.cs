namespace S25W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);

            ChangeValue(num);

            Console.WriteLine("\nAfter changes:\n");
            Console.WriteLine("num = " + num);
        }

        static void ChangeValue(int n)
        {
            n = 100;
        }
    }
}
