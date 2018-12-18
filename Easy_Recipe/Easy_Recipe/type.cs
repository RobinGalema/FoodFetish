using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Recipe
{
    class Type
    {
        // Fields
        private string name;

        // Properties
        public string Name { get => name; set => name = value; }

        // Constructor
        public Type(string name)
        {
            this.name = name;
        }
    }
}
