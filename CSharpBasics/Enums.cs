using System;
using SelectAndLoop;

enum Complexity
{
    Easy,
    Normal,
    Hard,
}
internal class EnumDemo
{
    void UseEnums()
    {
        // SelectionStatement select;
        Complexity complexity = Complexity.Easy;
        if (complexity == Complexity.Normal)
        {
            Console.WriteLine("Complexity normal");
        }
    }
}