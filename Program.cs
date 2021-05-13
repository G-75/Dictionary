using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> kelimeler = new MyDictionary<string>();
            kelimeler.Add("bilek");
            kelimeler.Add("bıçak");
            kelimeler.Add("bileklik");
            kelimeler.Add("bahçe");

            foreach (var item in kelimeler.Items)
            {
                Console.WriteLine(item);


            }
        }
    }
}


