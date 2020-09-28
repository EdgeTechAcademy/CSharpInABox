using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpInABox
{
    class Volcano
    {
        public string Country { get; set; }
        public int Deaths { get; set; }
        public int Elevation { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int VEI { get; set; }
        public int Year { get; set; }

        public Volcano(string country, int deaths, int elevation, string location, string name, string type, int vei, int year)
        {
            Country = country;
            Deaths = deaths;
            Elevation = elevation;
            Location = location;
            Name = name;
            Type = type;
            VEI = vei;
            Year = year;
        }

        public override string ToString()
        {
            return $"In {this.Year} a {this.Type} erupted in {this.Location} killing {this.Deaths} souls";
        }

        /**
         *      RetrieveVolcanoData
         *          static utility method to read the volcano.csv file and 
         *          convert to a List<Volcano> object
         *      
         */
        public static List<Volcano> RetrieveVolcanoData()
        {
            var volcanoes = Utils.ReadFile("volcano.csv");
            List<Volcano> lVolcanoes = new List<Volcano>();
            foreach (var vText in volcanoes)
            {
                string[] attrib = vText.Split(",");
                //  Country,Death,Elevation,Location,Name,Type,VEI,Year
                Volcano v = new Volcano(
                            attrib[0], Utils.StrToInt(attrib[1]), Utils.StrToInt(attrib[2]),
                            attrib[3], attrib[4], attrib[5], Utils.StrToInt(attrib[6]),
                                                                  Utils.StrToInt(attrib[7]));
                lVolcanoes.Add(v);
            }
            lVolcanoes.Remove(lVolcanoes[0]);       //  Remove the header row
            return lVolcanoes;
        }
    }
}
