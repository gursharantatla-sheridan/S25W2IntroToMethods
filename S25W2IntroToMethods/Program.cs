namespace S25W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);

            ChangeValue(num, str);

            Console.WriteLine("\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
        }

        static void ChangeValue(int n, string s)
        {
            n = 100;
            s = "world";
        }
    }
}
