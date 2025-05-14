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
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("cir.radius = " + cir.radius);
            Console.WriteLine("arr[0] = " + arr[0]);

            ChangeValue(num, str, cir, arr);

            Console.WriteLine("\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("cir.radius = " + cir.radius);
            Console.WriteLine("arr[0] = " + arr[0]);
        }

        static void ChangeValue(int n, string s, Circle c, int[] a)
        {
            n = 100;
            s = "world";
            c.radius = 100;
            a[0] = 100;
        }
    }

    class Circle
    {
        public double radius;
    }
}
