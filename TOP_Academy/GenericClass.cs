using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_TOP_Academy
{
    class GenericClass<T> where T : IComparable
    {
        int random = 1;


        private List<T> list = new List<T>();

        public GenericClass(int random)
        {
            this.random = random;
        }
        public void Add(T value)
        {
            list.Add(value);
        }

        public void CompareMyValue(T newValue)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(newValue) > 0)
                {
                    list[i] = newValue;
                }
            }
        }

        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class IntCollection : GenericClass<int>
    {

    }

    class StringCollection : GenericClass<string>
    {

    }
}