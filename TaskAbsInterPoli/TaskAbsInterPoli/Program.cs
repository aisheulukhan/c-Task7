using System;

namespace TaskAbsInterPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Menu-------");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");
            Console.WriteLine("--------------");
            


            int key = 0;
            do
            {
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        Console.WriteLine("End");
                        break;
                    case 1:
                        double side = 0;
                        
                        
                        while (side <= 0)
                        {
                            Console.WriteLine("Kvadratin kenarini daxil edin");
                            side = Convert.ToDouble(Console.ReadLine());
                            if (side <= 0)
                            {
                                Console.WriteLine("Yanlis melumatdir");
                            }

                        }
                        Square s = new Square(side);
                        Console.WriteLine($"Kvadratin sahesi: {s.CalcArea()}");
                        break;
                    case 2:
                        double width = 0;
                        double lenght = 0;
                        
                        while (width <= 0)
                        {
                            Console.WriteLine("Duzbucaqlinin enini daxil edin");
                            width = Convert.ToDouble(Console.ReadLine());
                            if (width <= 0)
                            {
                                Console.WriteLine("Yanlis melumatdir");
                            }
                        }
                        while (lenght <=0)
                        {
                            Console.WriteLine("Duzbucaqlinin uzunlugunu daxil edin");
                            lenght = Convert.ToDouble(Console.ReadLine());
                            if (lenght<=0)
                            {
                                Console.WriteLine("Yanlis melumatdir");
                            }


                        }
                        Rectangular r = new Rectangular(width, lenght);
                        Console.WriteLine($"Duzbucaqlinin sahesi: {r.CalcArea()}");

                        break;
                    default:
                        Console.WriteLine("Yalnis daxil etdiniz");
                        break;
                }
            } while (key != 0);
        }

    }
    abstract class Figure
    {
        public abstract double CalcArea();
        
    }
    class Square : Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double CalcArea()
        {
            return Side * Side;
        }

    }
    class Rectangular : Figure
    {
        public double Width { get; set; }
        public double Lenght { get; set; }
        public Rectangular(double width, double lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        public override double CalcArea()
        {
            return Width * Lenght;
        }
      
    }
}
