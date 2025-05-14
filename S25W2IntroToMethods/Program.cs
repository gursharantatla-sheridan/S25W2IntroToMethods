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

            ChangeValue(ref num, ref str, cir, arr);

            Console.WriteLine("\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("cir.radius = " + cir.radius);
            Console.WriteLine("arr[0] = " + arr[0]);

            Console.WriteLine("\n\n");



            // output parameters example
            double r = 5;
            //double circum, area;

            CalculateCircumAndArea(r, out double circum, out double area);

            Console.WriteLine("Circumference = " + circum);
            Console.WriteLine("Area = " + area);



            //Console.Write("\n\nEnter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int n))
            //    Console.WriteLine("n = " + n);
            //else
            //    Console.WriteLine("Invalid input. Please try again.");

            Console.WriteLine("\n\n");



            int a = 4, b = 6, c = 2;

            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);




            // parameter array example
            int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintArray(myArr);
            PrintArray(5, 3, 2, 4, 5, 6, 7, 8, 6, 5);



            PersonInfo("John", 32);
            PersonInfo(name: "John", age: 32);
            PersonInfo(age: 32, name: "John");
            //PersonInfo(32, "John");

            PersonInfo("John");
        }


        static void PersonInfo(string name, int age = 18)
        {
            // method body
        }



        // parameter array example
        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\n\nTotal number of items = " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }




        // output parameter example
        static void CalculateCircumAndArea(double r, out double circum, out double area)
        {
            circum = 2 * Math.PI * r;
            area = Math.PI * r * r;
        }



        static void ChangeValue(ref int n, ref string s, Circle c, int[] a)
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
