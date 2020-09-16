using System;
using System.Collections.Generic;

namespace LearningClasses
{
    public class Generic
    {
        void LearningList()
        {
            List<string> names = new List<string>();
            names.Add("Dipesh khanal");
            names.Add("Dipesh khanal");
            names.Add("Dipesh khanal");
            names.Add("Dipesh khanal");
            names.Add("Dipesh khanal");
            names.Add("Dipesh khanal");

        }
        void LearningDictionary()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("China", "Bejing ");
            foreach (var countryCaptital in countryCapitals)
            {
                Console.WriteLine(countryCaptital.Key);
            }

        }
    }
}