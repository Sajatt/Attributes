  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sw
{
    class Dark
    {
        string bitterness, type;
        int calories, CacaoPercent;




        public void Outputd()
        {

            Console.WriteLine("Please, input a taste description");
            try
            {
                bitterness = Console.ReadLine();

            }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("Please, input a type of chocolate");
            try
            {
                type = Console.ReadLine();

            }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("Please, input a percent of cocoa:");
            try
            {
                CacaoPercent = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("Please, input calories per 100g:");
            try
            {
                calories = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("Type: {0} CacaoPersent: {1} calories: {2} Bitterness: {3}", type, CacaoPercent, calories, bitterness);
        }
    }
    }
  
