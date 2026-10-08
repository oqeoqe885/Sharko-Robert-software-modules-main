using System;

public class Class1
{
	public Class1()
	{

        internal class Program
    {
        static void Main(string[] args)
        {

            var x1 = 4;
            var x2 = 3;
            var w1 = 5;
            var w2 = 6;
            var b1 = 9;
            var b2 = 10;
            var y1 = x1 * w1 + b1;
            var y2 = x2 * w2 + b2;

            double r = (double)Math.Sqrt(y1 * y1 + y2 * y2);
            Console.WriteLine($"Otvet = {r}");
        }
    }
}
}
