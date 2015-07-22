using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace DevTarining
{    
    [TestFixture]
    public class FizzBuzz
    {

        [Test]
        public void Fizz_Buzz_FizzBuzz_straight_logic()  //https://www.youtube.com/watch?v=OX5TM3q-JQg
        {
            //from 1 to 100
            //1. Check if it's devided %3 - 
               //print Fizz
            //2. Chack if it's %5  
              // print Bizz
            //3. dividable by 3 and 5 - FizzBuzz
            //4. if not % 3 and % 5 - number

            int i;
            for (i=1; i<=100; i++)
            {
                string result ="";

                if (i % 3 == 0)
                {
                    result = "Fizz";
                    //Console.WriteLine("\t{0} Fizz", i);
                }

                if (i % 5 == 0)
                {
                    result = result + "Buzz";
                    //Console.WriteLine("\t{0} Bizz", i);
                }

                if (result.Length == 0)
                {
                    result = "not %3 and %5";
                    //Console.WriteLine("\t{0} FizzBizz", i);
                }

                Console.WriteLine("\t {0}, {1}", i, result);

            }


        }

        [Test]
        public void Fizz_Buzz_with_()
        {
            for (int i = 1; i <= 100; i++)
            {
                //Console.WriteLine("counter={0}", i);
                
                bool gg;
                string ggFIZZ;
                bool ggBUZZ;
                gg = ((i % 3 == 0) || (i % 5== 0)) ? true  : false;
                ggFIZZ = (i % 3 == 0) ? "FIZZ" : "false";
                ggBUZZ = (i % 5 == 0) ? true : false;

                if (gg == true)
                {
                    if (ggFIZZ == "FIZZ")
                    {
                        Console.WriteLine("\t{0} FIZZ", i);
                    }
                    if (ggBUZZ == true)
                    {
                        Console.WriteLine("\t{0} Buzz", i);
                    }
                }
                else
                {
                    Console.WriteLine("i={0}", i);
                }
                
            }
        }
        
        

    }
}
