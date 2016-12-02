using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]


    class Firm:System.Attribute
    {

        public string name;
        public string country;

        public Firm (string name,string country)
        {
            this.country = country;
            this.name = name;
        }
       
    }
 }

    

