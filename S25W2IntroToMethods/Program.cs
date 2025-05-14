namespace S25W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";
            Circle cir = new Circle();
            cir.radius = 5;

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("cir.radius = " + cir.radius);

            ChangeValue(num, str, cir);

            Console.WriteLine("\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("cir.radius = " + cir.radius);
        }

        static void ChangeValue(int n, string s, Circle c)
        {
            n = 100;
            s = "world";
            c.radius = 100;
        }
    }

    class Circle
    {
        public double radius;
    }
}
