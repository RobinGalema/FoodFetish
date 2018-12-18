using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Catagory
    {
        // Fields
        private string name;

        // Properties
        public string Name { get => name; set => name = value; }

        // Constructor
        public Catagory(string name)
        {
            this.name = name;
        }


    }
}
