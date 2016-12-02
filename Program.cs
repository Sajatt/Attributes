using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{

    class Program
    {
        [Firm("Nestle", "USA")]
        static void Main(string[] args)
        {    GetAttribute(typeof(Chocolate));

            System.Console.ReadLine();

        }

        public static void GetAttribute(Type t) {
            Firm myAttribute = (Firm)Attribute.GetCustomAttribute(t, typeof(Firm));
            Console.WriteLine("Firm: {0}, Country: {1}", myAttribute.name, myAttribute.country);

        
            Chocolate aa = new Chocolate(30, "Milk", 200);
            aa.Output();
            Console.ReadLine();
        }
        //ListTest a = new ListTest();
        //a.OutSorted(a.ListCollect());
        //Console.ReadLine();
            

            }
        }
    
        
                    //Console.ReadLine();

                    //ListTest a = new ListTest();
                    //a.ListCollect();

                    // ListTest b = new ListTest();
                    //a.OutSorted(a.ListCollect());

                    //Dark bb = new Dark();
                    //bb.Outputd();
                    
             
             
            
        

