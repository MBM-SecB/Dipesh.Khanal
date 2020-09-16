class Person
{
    internal int age = 23;
    internal string name = "Kamesh";

    public int MyProperty { get; set; }

    // getter setter
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 20 && value < 30)
            {
                age = value;
            }
        }
    }
}