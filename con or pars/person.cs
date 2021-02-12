using System;
using System.Collections.Generic;
using System.Text;

namespace con_or_pars
{
    class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string fullName 
            
        {
            set
            {
                firstName = "S";
            }
            get
            {
                return firstName + " " + lastName;
            }

          
        
        }

        public string fullName1()
        {
           return firstName +" "+ lastName;
        }

    }
}
