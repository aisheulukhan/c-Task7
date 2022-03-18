using System;

namespace TaskAbsInterPoli
{
    class Program
    {
        static void Main(string[] args)
        {

            //int side = Convert.ToInt32(Console.ReadLine());
            //Square s = new Square(side);

            //if (side>0)
            //{
            //    Console.WriteLine(s.CalcArea());

            //}
            //else
            //{
            //    Console.WriteLine("Yanlis melumat");
            //}

            //int Width = Convert.ToInt32(Console.ReadLine());
            //int Lenght = Convert.ToInt32(Console.ReadLine());
            //Rectangular r = new Rectangular(Width, Lenght);

            //if (Width > 0 && Lenght > 0)
            //{
            //    Console.WriteLine(r.CalcArea());
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis melumat");
            //}
            //int side = 4;
            //int Width = 6;
            //int Lenght = 10;


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
                        Console.WriteLine("Kvadratin kenarini daxil edin");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Square s = new Square(side);
                        if (side > 0)
                        {
                            Console.WriteLine($"Kvadratin sahesi: {s.CalcArea()}");

                        }
                        else
                        {
                            Console.WriteLine("Yanlis melumat");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Duzbucaqlinin enini daxil edin");
                        int Width = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Duzbucaqlinin uzunlugunu daxil edin");
                        int Lenght = Convert.ToInt32(Console.ReadLine());
                        Rectangular r = new Rectangular(Width, Lenght);
                        if (Width > 0 && Lenght > 0)
                        {
                            Console.WriteLine($"Duzbucaqlinin sahesi: {r.CalcArea()}");
                        }
                        else
                        {
                            Console.WriteLine("Yanlis melumat");
                        }
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
        public abstract int CalcArea();
        
    }
    class Square : Figure
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }

        public override int CalcArea()
        {
            return Side * Side;
        }

    }
    class Rectangular : Figure
    {
        public int Width { get; set; }
        public int Lenght { get; set; }
        public Rectangular(int width, int lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        public override int CalcArea()
        {
            return Width * Lenght;
        }
    }
}
