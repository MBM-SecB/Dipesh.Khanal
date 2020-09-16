using System;

namespace SelectAndLoop
{


    class SelectionStatement
    {

        static void Main2()
        {
            SelectionStatement s = new SelectionStatement();
            s.LearnSwitchStatements();
            // s.checkNumber();
        }
        void CheckNumber()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            if ((number & 1) == 0)
            {
                Console.WriteLine("You Entered EVEN number");
            }
            else
            {
                Console.WriteLine("You Entered ODD number");

            }
        }

        void LearnSwitchStatements()
        {
            Console.Write("Enter your hobby: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "books":
                    Console.WriteLine("Hobby is watching movies");
                    break;
                case "sports":
                    Console.WriteLine("Hobby is gaming");
                    break;
                case "gaming":
                    Console.WriteLine("Hobby is sports");
                    break;
                default:
                    Console.WriteLine("Hobby is others");
                    break;




            }
        }
    }
}