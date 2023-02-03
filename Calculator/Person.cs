using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     class Person
    {
        private string? Name;//field
        public string publicName // property
        {
            get
            {
                if (Name != null)
                {
                    return Name;
                }
                return Name;
            }
            set
            {
                Name = value; 
            }
        }
        
        


    }
}
