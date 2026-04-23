using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color(200, 20, 50);
            Console.WriteLine(red.GetAlpha());
            Console.WriteLine(red.GetBlue());
            Console.WriteLine(red.GetGreen());
            Console.WriteLine(red.GetRed());
            Console.WriteLine(red.GetGrey());

            Sphere bola = new Sphere(red, 34);
            bola.Throw();
            bola.Throw();
            bola.Throw();
            Console.WriteLine(bola.GetTimesThrown());
            bola.Pop();
            bola.Throw();
            Console.WriteLine(bola.GetTimesThrown());

        }
    }
}
