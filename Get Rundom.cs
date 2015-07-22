using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace DevTarining
{
    [TestFixture]
    public class Get_Rundom
    {
        int _randomNumber;
        
        public class DataGenerator
        {
            Random _rundom = new Random();
            public int GetRandomNumber(int min, int max)
            {
                return _rundom.Next(min, max);
            }
        }

        [Test]
        public void Get_Rundom_Number()
        {
            DataGenerator dataGenerator = new DataGenerator();
           
            _randomNumber =dataGenerator. GetRandomNumber(1,100);

            Console.WriteLine("{0}", _randomNumber);
        }

        [Test]
        public void Get_Rundom_String()
        {
            
        }
    }
}
