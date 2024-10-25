class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nValue table:");
        Console.WriteLine("||==========||==========||==========||===========||");
        Console.WriteLine("||    x     ||   Y(x)   ||   S(x)   |||Y(x)-S(x)|||");
        Console.WriteLine("||==========||==========||==========||===========||");

        for (double x = a; x <= b; x += h)
        {
            double Y = Math.E * Math.Cos(x) * Math.Cos(Math.Sin(x));

            double S = 0.0;
            for (int k = 0; k <= n; k++)
            {
                S += Math.Cos(k * x) / Factorial(k);
            }

            double difference = Math.Abs(Y - S);

            Console.WriteLine("|| {0,8:F5} || {1,8:F5} || {2,8:F5} || {3,8:F5} ||", x, Y, S, difference);
            Console.WriteLine("||----------||----------||----------||----------||");
        }
    }

    static long Factorial(int k)
    {
        if (k == 0 || k == 1)
            return 1;
        long result = 1;
        for (int i = 2; i <= k; i++)
        {
            result *= i;
        }
        return result;
    }
}

