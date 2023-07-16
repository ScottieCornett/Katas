using Katas;

string str = CamelKata.GetCamelCase("the-stealth-warrior");
string jaden = JadenCase.ToJadenCase("this is the example string");
int count = DuplicateCount.DuplicateCounter("aaadfdfdfeafdppp123455445");
int[] a = { 2, 3, 5, 6, 7, 9, 11 };
SortOdds.SortTheOdds(a);
foreach (var b in a)
{
    Console.Write(b);
}

int number = Multiplier.Multiply(3);
Console.WriteLine(count);
Console.WriteLine(str);
Console.WriteLine(jaden);
Console.WriteLine(number);