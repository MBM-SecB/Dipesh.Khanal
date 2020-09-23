using System;

class IterationStatement
{

    static void Main12()
    {
        IterationStatement it = new IterationStatement();
        // it.LearnForLoops();
        it.LearnWhileLoops();
        Person person = new Person();
        person.Age = 34;

    }
    void LearnForLoops()
    {
        // for (int i = 0; i <= 20; i++)
        // {
        //     Console.WriteLine("This section is for iteration statements");

        // }

        byte[] personages = { 23, 45, 48, 90 };

        for (int i = 0; i < personages.Length; i++)
        {
            if (personages[i] % 2 == 0)
                Console.WriteLine(personages[i] + " is even");
            else
                Console.WriteLine(personages[i] + " is even");

        }

        foreach (byte age in personages)
        {
            if (age % 2 == 0)
            {
                Console.WriteLine($"{age} is even");
            }
            else
            {
                Console.WriteLine($"{age} is odd");

            }
        }
    }

    void LearnWhileLoops()
    {
        char confirm = 'Y';
        // while (confirm == 'Y')
        // {
        //     Console.WriteLine(" I am inside while loop");
        //     Console.Write("Enter Y to continue: ");
        //     confirm = Console.ReadKey().KeyChar;


        // }
        do
        {
            Console.WriteLine(" I am inside while loop");
            Console.Write("Enter Y to continue: ");
            confirm = Console.ReadKey().KeyChar;
        }
        while (confirm == 'Y');
    }
}