using System.Collections.Generic;
public class Employee
{
    public string FirstName{ get; set;}
    public string Surname{ get; set;}
    public string Address{ get; set;}
    public char Gender{ get; set;} ='M';
    public double Salary{ get; set;}
    public static List<Employee> GetEmployes()
    {
         var e1 =new Employee()
        {
            FirstName= "Dipesh",
            Surname ="Khanal",
            Address ="Koteshwor",
            Gender = 'M',
            Salary = 2000.0
        };
        var e2 =new Employee()
        {
            FirstName= "Dipesh1",
            Surname ="Khanal",
            Address ="Koteshwor",
            Gender = 'M',
            Salary = 2000.0
        };
        var e3 =new Employee()
        {
            FirstName= "Dipesh2",
            Surname ="Khanal",
            Address ="Koteshwor",
            Gender = 'M',
            Salary = 2000.0
        };
        var e4 =new Employee()
        {
            FirstName= "Dipesh3",
            Surname ="Khanal",
            Address ="Koteshwor",
            Gender = 'M',
            Salary = 2000.0
        };
        var e5 =new Employee()
        {
            FirstName= "Dipesh4",
            Surname ="Khanal",
            Address ="Koteshwor",
            Gender = 'M',
            Salary = 2000.0
        };
        List<Employee> employees = new List<Employee>(){ e1,e2,e3,e4,e5};
    }

}