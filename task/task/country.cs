using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class country
    {
        internal string Name;
        country azerbaijan = new country
        {
            Name = "Azerbaijan",
            City = new List<city>
            {
                new city { Name = "Baku", Population = 3306000 },
                new city { Name = "Ganja", Population = 2108000 },
                new city { Name = "Gabala", Population = 44000 },
                new city { Name = "Quba", Population = 42000 }
            }
        };

        public List<city> City { get; internal set; }

        
    }
}

    
