using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{
    class ListTest
    {

        public ListTest()
        {
        }
        public List<Chocolate> ListCollect()
        {
            List<Chocolate> Choc = new List<Chocolate>();
           
            Choc.Add(new Chocolate(30, "Milk", 200));
            Choc.Add(new Chocolate(0, "White", 300));
            Choc.Add(new Chocolate(90, "Dark", 100));
            

            Console.WriteLine(" Unsorted list: \t");
            foreach (Chocolate c in Choc)
                Console.WriteLine("{0}, {1}, {2}", c.type,c.CacaoPercent,c.calories);
            Console.ReadLine();

            return Choc;
        }

        public void OutSorted(List<Chocolate> Choc)
            {
                var calories = from c in Choc orderby c.calories select c;
                List<Chocolate> ChocSorted = calories.ToList<Chocolate>();
               // Choc.Sort();
               // Choc.Sort(delegate(Chocolate calories1, Chocolate calories2)
               //{
               //    return Chocolate.calories1.CompareTo(Chocolate.calories2);
               //});

            Console.WriteLine(" Sorted list: \t");
            foreach (Chocolate ch in ChocSorted)
                Console.WriteLine("{0}, {1}, {2}", ch.type, ch.CacaoPercent, ch.calories);
            Console.ReadLine();
            
            }
        }

    }



