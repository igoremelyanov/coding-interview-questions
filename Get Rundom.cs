using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;

namespace DevTarining
{
    [TestFixture]
    public class Get_Rundom
    {
        int _randomNumber;
        public string _randomString;
        public string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        public class DataGenerator_RundomNumber
        {
            Random _rundom = new Random();
            public int GetRandomNumber(int min, int max)
            {
                return _rundom.Next(min, max);
            }
        }

        public class DataGenerator_RundomString
        {
            Random _rundom = new Random();
            public string GetRandomString(int size, string charsToUse)
            {
                var buffer = new char[size];

                for(int i = 0; i < size; i++)
                {
                     buffer[i] = charsToUse[_rundom.Next(charsToUse.Length)];
                }
                return new string(buffer);
            }
        }

        [Test, Repeat(4)]
        public void Get_Rundom_Number()
        {
            DataGenerator_RundomNumber number_dataGenerator = new DataGenerator_RundomNumber();
           
            _randomNumber =number_dataGenerator.GetRandomNumber(1,100);

            Console.WriteLine("{0}", _randomNumber);
        }

        [Test, Repeat(4)]
        public void Get_Rundom_String()
        {
            DataGenerator_RundomString str_dataGenerator = new DataGenerator_RundomString();

            _randomString = str_dataGenerator.GetRandomString(20, Chars);

            Console.WriteLine("{0}", _randomString);
            
        }
    }
}
