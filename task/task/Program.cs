using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            country azerbaijan = new country
            {
                Name = "Azerbaycan",
                City = new List<city>
                {
                    new city { Name = "Baku", Population = 2293100 },
                    new city { Name = "Ganja", Population = 335600 },
                    new city { Name = "Mingecevir", Population = 120000 },
                    new city { Name = "Yevlax", Population = 69798 },


                }

            };
            country Turkey = new country
            {
                Name = "Turkey",
                City = new List<city>
                {
                 new city { Name = "Istanbul", Population = 15848000 },
                 new city { Name = "Burdur", Population =  95436 },
                 new city { Name = "Ankara", Population =   5397000 },
                }

            };
            country Germany = new country
            {
                Name = "Germany",
                City = new List<city>
                {
                 new city { Name = "Berlin", Population = 3574000 },
                 new city { Name = "Dortmunt", Population = 590000 }
                }

            };

          

        

        }

    }
}


   

