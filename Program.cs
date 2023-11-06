using System;
using System.Linq;

class Ellips
{
    public double a; 
    public double b; 

    public Ellips(double a, double b)
    {
        if (a < b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        if (a == b)
        {
            a++;
        }

        this.a = a;
        this.b = b;
    }

    public virtual void Print()
    {
        Console.WriteLine($"a={a} b={b}");
    }

    public virtual double Sqr()
    {
        return Math.PI * a * b;
    }

    public double Eks()
    {
        return Math.Sqrt(1 - (b * b) / (a * a));
    }
}


class Krug : Ellips
{
    public Krug(double r) : base(r, r)
    {
    }

    public override void Print()
    {
        Console.WriteLine($"a,b={a}");
    }

    public double Leng()
    {
        return 2 * Math.PI * a;
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            if (random.Next(2) == 0)
            {          
                double a = random.Next(1, 10);
                double b = random.Next(1, 10);
                Ellips ellips = new Ellips(a, b);

                Console.WriteLine("Елiпс:");
                ellips.Print();
                Console.WriteLine($"Площа: {ellips.Sqr()}");
                Console.WriteLine($"Ексцентриситет: {ellips.Eks()}");
            }
            else
            {
                double r = random.Next(1, 10);
                Krug krug = new Krug(r);

                Console.WriteLine("Коло:");
                krug.Print();
                Console.WriteLine($"Площа: {krug.Sqr()}");
                Console.WriteLine($"Довжина: {krug.Leng()}");
            }

            Console.WriteLine();
        }
    }
}