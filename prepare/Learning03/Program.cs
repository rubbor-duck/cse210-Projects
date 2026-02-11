Fraction test1 = new Fraction();
Console.WriteLine(test1.GetFractionString());
Console.WriteLine(test1.GetDecimalValue());

Fraction randomFraction = new Fraction();
Random random = new Random();

for (int i = 0; i<20; ++i)
{
    randomFraction.SetTop(random.Next());
    randomFraction.SetBottom(random.Next());
    Console.WriteLine($"Fraction {i}: String: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
}