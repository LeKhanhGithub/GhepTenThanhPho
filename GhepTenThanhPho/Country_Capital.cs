using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhepTenThanhPho
{
    class Country_Capital
    {
        String Country;
        String Capital;
        public Country_Capital(String Country, String Capital)
        {
            this.Country = Country;
            this.Capital = Capital;
        }

        public String country { get => Country; set => Country = value; }
        public String capital { get => Capital; set => Capital = value; }
        
    }
    class Danhsach
    {
        public static List<Country_Capital> listCountry_Capital = new List<Country_Capital>();
    }
}
