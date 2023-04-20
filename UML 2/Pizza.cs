using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_2
{
    public class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return ($"\nNo {Number} \nName {Name} \n{Price}kr ");
        }
    }
}
    

