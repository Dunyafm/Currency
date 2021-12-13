
//IMPLICIT,EXPLICIT ETMEKLE DOLLAR MANATA CEVIRMEK

using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat(200);

            Dollar dollar = manat;

            Console.WriteLine(dollar.USD);

            Dollar dollar1 = new Dollar(200);
            Manat manat1 = dollar;
            Console.WriteLine(manat1.AZN);
        }
    }
}

class Dollar
{
    public double USD { get; set; }
    public Dollar(double usd)
    {
        USD = usd;
    }
}  
public static implicit operator Manat(Dollar dollar)
{
    return new Manat(dollar.USD * 1.7);
}

class Manat
{
    public double AZN { get; set; }
    public Manat(double azn)
    {
        AZN = azn;

    }
    public static implicit operator Dollar(Manat manat)
    {


        return new Dollar(manat.AZN / 1.7);
    }
}
