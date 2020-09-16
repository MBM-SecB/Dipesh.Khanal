using System;

public class MethodTeacher
{
    public int Multiply(int firstNum, int secondNum)
    {
        int result = firstNum * secondNum;
        return result;
    }

    public (int, int) FindMinMax(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return (min, max);
    }
}
public class MethodTester
{
    void TestMethods()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        (int Min, int Max) result = methodTeacher.FindMinMax(1, 2, 4, 5, 56, 78, 90);
        Console.WriteLine($"Minimum:{result.Min} Maximum:{result.Max}");
    }
}