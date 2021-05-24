using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16_CountriesIO
{
    class Countries
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Climate { get; set; }
        public string Continent { get; set; }


        public Countries()
        {

        }

        public Countries(string name, string language, string climate, string continent)
        {
            Name = name;
            Language = language;
            Climate = climate;
            Continent = continent;
        }


        public static List<Countries> GetCountries()
        {
            List<Countries> countries = new List<Countries>
            {
                new Countries("United States", "English", "Moderate", "North America"),
                new Countries("Japan", "Japanese", "Warm", "Asia"),
                new Countries("Russia", "Russian", "Cold", "Asia" ),
                new Countries("France", "French", "Moderate", "Europe")
            };
            return countries;
        }
    }
}