using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    public class BeerKeg
    {
        public string Model { get; set; }
        public double Radius { get; set; }
        public int Height { get; set; }

        public BeerKeg(string model, double radius, int height)
        {
            Model = model;
            Radius = radius;
            Height = height;
        }

        public double GetVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }

    static void Main()
    {
        List<BeerKeg> kegs = new List<BeerKeg>();
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            BeerKeg newKeg = new BeerKeg
                (
                    model: Console.ReadLine(),
                    radius: double.Parse(Console.ReadLine()),
                    height: int.Parse(Console.ReadLine())
                );
            kegs.Add(newKeg);
        }

        BeerKeg biggestKeg = kegs.OrderByDescending(bk => bk.GetVolume()).FirstOrDefault();
        Console.WriteLine(biggestKeg.Model);
    }
}