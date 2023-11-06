using System;
class program
{
    static void Main()
    {
        double a, b, c, d, x, y, z, r;
        Console.Write("Ender value for these variables:\na = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        d = double.Parse(Console.ReadLine());

        x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        y = (5 * (a + b) * (c - d)) / (1.0 / 2 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
        r = (1 / 2.0 * a + 3.0 / 4 * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
        Console.WriteLine("x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a^2 / b^2 = {0}", x);
        Console.WriteLine("y = 5 * (a + b) * (c - d) / (1 / 2 * c) + d^2 * (a^2 - b^2) / (b - a) = {0}", y);
        Console.WriteLine("z = ((x^2 - 2 * x, 3)^3 - 4 * (x^4 + 1)) * (1 - b) / (5 * a + 3 * b) = {0}", z);
        Console.WriteLine("r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c) = {0}", r);
    }
}