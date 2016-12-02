using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{
    [Firm("Nestle", "USA")]
     class Chocolate : Sweets
     {
             
        public string type;
        public int CacaoPercent;

        public Chocolate(int CacaoPercent, string type, int calories)
            : base(calories)
        {
            this.type = type;
            this.CacaoPercent = CacaoPercent;

            

        }

        //internal void GetAttribute(object t)
        //{
        //    throw new NotImplementedException();
        //}

        //public static void GetAttribute(Type t)
        //    {
        //        GetAttribute(typeof(Chocolate));
        //        Firm att = (Firm)Attribute.GetCustomAttribute(t, typeof(Firm));
        //}

        //public void GetAttribute(Type t)
        //{
        //    GetAttribute(typeof(Chocolate));
        //    Firm att = (Firm)Attribute.GetCustomAttribute(t, typeof(Firm));
        //    Console.WriteLine("name:{0} country {1} ", att.name, att.country);
        //}


         public void Output()
        { 
         Console.WriteLine("Type: {0} CacaoPersent: {1} calories: {2} ", type, CacaoPercent, calories);
        }
    }
}
