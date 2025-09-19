using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.GetFractionString();
        fraction1.GetDecimalValue();

        Fraction fraction2 = new Fraction(5);
        fraction2.GetFractionString();
        fraction2.GetDecimalValue();

        Fraction fraction3 = new Fraction(3, 4);
        fraction3.GetFractionString();
        fraction3.GetDecimalValue();

        Fraction fraction4 = new Fraction(1, 3);
        fraction4.GetFractionString();
        fraction4.GetDecimalValue();
    }
}

