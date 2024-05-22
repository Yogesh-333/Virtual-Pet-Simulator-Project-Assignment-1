using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet_Simulator
{
    class PetDetails
    {
        public string Name { get; set; }
        public string Type { get; set; }
       
        public PetDetails(string name, string type)
        {
            Name = name;
            Type = type;
            
        }
    }
}
