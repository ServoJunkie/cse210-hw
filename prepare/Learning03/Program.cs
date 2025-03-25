using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        string f1_fraction_string = f1.GetFractionString();
        Console.WriteLine(f1_fraction_string);
        double f1_decimal_value = f1.GetDecimalValue();
        Console.WriteLine(f1_decimal_value);

        Fraction f2 = new Fraction(5);
        string f2_fraction_string = f2.GetFractionString();
        Console.WriteLine(f2_fraction_string);
        double f2_decimal_value = f2.GetDecimalValue();
        Console.WriteLine(f2_decimal_value);

        Fraction f3 = new Fraction(3, 4);
        string f3_fraction_string = f3.GetFractionString();
        Console.WriteLine(f3_fraction_string);
        double f3_decimal_value = f3.GetDecimalValue();
        Console.WriteLine(f3_decimal_value);

        Fraction f4 = new Fraction(1, 3);
        string f4_fraction_string = f4.GetFractionString();
        Console.WriteLine(f4_fraction_string);
        double f4_decimal_value = f4.GetDecimalValue();
        Console.WriteLine(f4_decimal_value);
    }
}