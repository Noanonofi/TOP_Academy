using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_TOP_Academy
{
    class IndependetWork
    {
        private string Text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек.А это веселая птица­синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек";

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        public void CountWordInText(string word)
        {
            string[] words = Text.Split(' ', ',', '.');
            int count = 0;

            foreach (string w in words)
            {
                if (w == word)
                {
                    count++;
                }
            }
            dictionary.Add(word, count);
            //Console.WriteLine(Convert.ToInt64(count));
        }

        public void Print()
        {
            foreach (var d in dictionary)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value.ToString());
            }
        }
    }

}
