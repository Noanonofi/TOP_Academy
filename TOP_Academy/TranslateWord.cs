using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP_Academy
{
    class TranslateWord
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void translate()
        {
            dictionary.Add("Россия", "Russia");
            dictionary.Add("Ирландия", "Ireland");
            dictionary.Add("Китай", "China");

            string tmp;
            string result;
            Console.WriteLine("Введите страну на русском языке");
            tmp = Console.ReadLine();

            if (dictionary.ContainsKey(tmp))
            {
                result = dictionary.ContainsValue(tmp).ToString();
            }

        }
    }
}
