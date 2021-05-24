using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab16_CountriesIO
{
    class CountriesTextFile
    {

        public static List<Countries> WriteList()
        {
            List<Countries> countries = Countries.GetCountries();

            StreamWriter writer = new StreamWriter("../../../countries.txt");

            Console.WriteLine("Please input a country name:");
            string name = Console.ReadLine();
            Console.WriteLine("What is the national language?");
            string lang = Console.ReadLine();
            Console.WriteLine("What type of climate does the country have?:");
            string temp = Console.ReadLine();
            Console.WriteLine("What continent is the country apart of?:");
            string cont = Console.ReadLine();
            Countries input = new Countries(name, lang, temp, cont);

            countries.Add(input);

            foreach (Countries country in countries)
            {

                writer.WriteLine($"{country.Name}|{country.Language}|{country.Climate}|{country.Continent}");
                Console.WriteLine($"{country.Name}|{country.Language}|{country.Climate}|{country.Continent}");

            }
            writer.Close();
            return countries;
        }

        public static List<Countries> ReadList()
        {
            List<Countries> countries = new List<Countries>();
            StreamReader reader = new StreamReader("../../../countries.txt");
            string nation = reader.ReadLine();

            while (nation != null)
            {
                string[] countryProperties = nation.Split('|');

                countries.Add(new Countries(countryProperties[0], countryProperties[1], countryProperties[2], countryProperties[3]));


                Console.WriteLine(nation);
                nation = reader.ReadLine();


            }
            reader.Close();
            return countries;
        }
    }
}