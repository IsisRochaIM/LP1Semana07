using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color(200, 20, 50);
            Console.WriteLine(red.Grey);
            Console.WriteLine(red.Red);
            Console.WriteLine(red.Blue);
            Console.WriteLine(red.Green);
            Console.WriteLine(red.Alpha);

            Sphere bola = new Sphere(red, 34);
            bola.Throw();
            bola.Throw();
            bola.Throw();
            Console.WriteLine(bola.Arremessos);
            bola.Pop();
            bola.Throw();
            Console.WriteLine(bola.Arremessos);
        }
    }
}
