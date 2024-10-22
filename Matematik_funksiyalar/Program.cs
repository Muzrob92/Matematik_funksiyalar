using System;

class Program
{
    static void Main()
    {
        
        double result;
        //Asosiy matematik amallar
        result = Math.Abs(-5);      // Absolute value => 5
        result = Math.Max(3, 7);    // Maximum => 7
        result = Math.Min(3, 7);    // Minimum => 3
        result = Math.Pow(2, 3);    // Power => 2^3 = 8
        result = Math.Sqrt(16);     // Square root => 4
        //Trigonometrik funksiyalar
        
        double angleInRadians = Math.PI / 4; // 45 degrees
        double sin = Math.Sin(angleInRadians);   // Sine
        double cos = Math.Cos(angleInRadians);   // Cosine
        double tan = Math.Tan(angleInRadians);   // Tangent
        double asin = Math.Asin(0.707);          // Arcsine
        double acos = Math.Acos(0.707);          // Arccosine
        double atan = Math.Atan(1);              // Arctangent
        
        //Logarifmik va ko‘rsatkichli funksiyalar
        double logResult;

        logResult = Math.Log(10);        // Natural logarithm (base e)
        logResult = Math.Log10(100);     // Logarithm base 10
        logResult = Math.Exp(2);         // Exponential (e^2)

        //Yaxlitlash funksiyalari
        double roundResult;
        double roundResul;
        roundResult = Math.Ceiling(4.3);  // Ceiling => 5
        roundResult = Math.Floor(4.7);    // Floor => 4
        roundResul = Math.Round(4.6);    // Round => 4 (or 5 based on midpoint rounding)
        
        Console.WriteLine(asin);
        Console.WriteLine(roundResul);
    }
}