using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using static Classwork_8_november.StudyClassWork;

namespace Classwork_TOP_Academy
{
    #region ClassHello
    delegate void SendMessage(string message);
    class Hello
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void SpellItOut(string message)
        {
            foreach (var ch in message)
            {
                Console.Write($"{ch} ");
            }
        }
        public void Reverse(string message)
        {
            var str = new String(message.Reverse().ToArray());
            Console.WriteLine(str);
        }
    }
    #endregion

    #region BankAccount
    delegate void BankAccountHandler(decimal sum);
    class BankAccount
    {
        public BankAccountHandler BankAccountHandler;
        public void Add(decimal sum)
        {
            BankAccountHandler?.Invoke(sum);
        }
    }
    class Client
    {
        private readonly string _name;
        private readonly BankAccount _bankAccount;
        public Client(string name, BankAccount bankAccount)
        {
            _name = name;
            _bankAccount = bankAccount;
            bankAccount.BankAccountHandler = AccountSumChanged;
        }
        private void AccountSumChanged(decimal sum)
        {
            Console.WriteLine($"The client's account has changed. Sum: {sum}");
        }
    }
    #endregion

    #region EventArgs

    public class FallsIllEventArgs : EventArgs
    {
        public string Address;
    }

    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this,
                new FallsIllEventArgs { Address = "123 London Road" });
        }

        public event EventHandler<FallsIllEventArgs> FallsIll;
    }

    #endregion

    #region November 15 Task
    public class Person1
    {

    }

    class November15Prog
    {
        static void Main(string[] args)
        {
            //Необобщенные типы коллекции
            var array = new ArrayList();
            array.Add(55);
            array.Add(12.3);
            array.Add(new Person());
            //-----------------------
            var stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Pop();
            var value = stack.Peek();
            //-----------------------
            var queue = new Queue();
            queue.Enqueue(5);
            queue.Dequeue();
            //-----------------------
            var hashtable = new Hashtable();
            hashtable.Contains(5);
            hashtable.Add("dog", new ArrayList());
            if (hashtable.ContainsKey("dog"))
            {
                ((ArrayList)hashtable["dog"]).Add("");
            }
            //-----------------------

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            dictionary["dog"].Add("Barsic");

            foreach (var keyinpair in dictionary)
            {
                //dictionary.Values;
                //keyinpair.Key;
            }

            var sortedList = new SortedList();

            //Обобщенные типы коллекций
            //ArrayList == new List<int>();
            //Hashtable == Dictionary<Tkey, Tvalue>
            //Stack == Stack<T>
            //Queue = Queue<T>
            //SortedList == SortedList<TKey, TValue>
            //-------- == LinkedList<T>

            //С потоками есть версии - ConcurentCollection
        }
    }

    #endregion

    #region Main
    class Program
    {
        // ---- #region EventArgs
        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }

        static void Main(string[] args)
        {

            /*
             * --- #region ClassHello
            var hello = new Hello();
            SendMessage sendMessage = hello.Display;

            sendMessage += hello.SpellItOut;
            sendMessage += hello.Reverse;
            sendMessage("Привет");
            Console.WriteLine();

            //Удалим из цепочки один из методов
            sendMessage -= hello.SpellItOut;
            sendMessage -= hello.Reverse;
            sendMessage("До свидания");
             */

            /* ---- #region BankAccount    
            var bankAccount = new BankAccount();
            var client = new Client("Alex", bankAccount);
            bankAccount.Add(45);

            var hello = new Hello();
            var action = new Action<string>(hello.Display);
            action += hello.SpellItOut;
            action("Hello");

            // ---- #region EventArgs
            /*            var person = new Person();

                        person.FallsIll += CallDoctor;

                        person.CatchACold();*/

            var propperty = new PropertyChanged__();
            propperty.PropertyChanged += IsShanges;
            propperty.Temp = "KEK";

        }
        private static void IsShanges(object sender, PropertyEventArgs eventArgs)
        {
            Console.WriteLine($"Word {eventArgs.PropertyName} changes in {sender}");
        }
    }

    #endregion
}