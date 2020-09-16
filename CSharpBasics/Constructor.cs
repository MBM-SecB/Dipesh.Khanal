namespace LearningClasses
{

    public class Country
    {
        public string Name { get; set; }
        public int Popultion { get; set; }

        //Default constructor - parameterless
        public Country()
        {

        }
        //  constructer with parameter
        public Country(string name, int population)
        {
            Name = name;
            Popultion = population;
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal", 123456);
            var a = country2.Name;


        }
    }
}