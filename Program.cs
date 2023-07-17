using Katas;

string greeting = Welcome.Greet("dut%33221");
Console.WriteLine(greeting);

int area = MathCheck.AreaOrPerimeter(3, 3);
int perimeter = MathCheck.AreaOrPerimeter(3, 4);

int[] nums = new int[] { 7, 1};
int[] numbers = SortArray.ArraySorter(nums);

foreach (var a in numbers)
{
    Console.Write(a);
}
Console.WriteLine();
Console.WriteLine(area);
Console.WriteLine(perimeter);