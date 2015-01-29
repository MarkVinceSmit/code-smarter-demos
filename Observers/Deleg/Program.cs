using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Deleg
{
    public delegate void PropertyHasChangedDelegate(string oldVal, string newVal);

    class Program
    {
        static void Main(string[] args) {

            Person p = new Person();

            var eventHandler1 = new PropertyHasChangedDelegate(


               (a, b) =>
               {
                   Console.WriteLine("Superchecker NAME has changed from {0} to {1}", a, b);
               }


           );

            p.onNamechangedDelegates += eventHandler1;
            p.onNamechangedDelegates += eventHandler1;

            p.onNamechangedDelegates += new PropertyHasChangedDelegate(


                (a, b) =>
                {
                    //throw new Exception("Boo!");

                    Console.WriteLine("Name has changed from {0} to {1}", a, b);
                }


            );
            // ---- SIDE EXAMPLE-----
            // Using delegates as jump table, not as observer pattern
            //PropertyHasChangedDelegate[] jumpTabel = new PropertyHasChangedDelegate[]
            //{
            //    eventHandler1,
            //    (a, b) =>
            //    {
            //        //throw new Exception("Boo!");
            //        Console.WriteLine("Name has changed from {0} to {1}", a, b);
            //    }
            //};
            //


            p.onTelephonechangedDelegate += (a, b) => { Console.WriteLine("Telphone has changed from {0} to {1}", a, b);};

            p.onNamechangedDelegates -= eventHandler1;
            p.onNamechangedDelegates -= eventHandler1;
            p.onNamechangedDelegates -= eventHandler1;
            p.onNamechangedDelegates += null;

            p.Name = "Marvin";
            p.TelephoneNr = "555-17364-746";

            p.Name = "Snarf";
        }
    }

    public class Person
    {
        public event PropertyHasChangedDelegate onNamechangedDelegates = new PropertyHasChangedDelegate((a,b) => { });
        public event PropertyHasChangedDelegate onTelephonechangedDelegate = new PropertyHasChangedDelegate((a, b) => { });

        private string _telephoneNr;

        public string TelephoneNr
        {
            get { return _telephoneNr; }
            set
            {

                onTelephonechangedDelegate(_telephoneNr, value);
                _telephoneNr = value;
            }
        }


        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                onNamechangedDelegates(_name, value);
                _name = value;
                //PropertyHasChangedDelegate[] allObservers =
                //    onNamechangedDelegates.GetInvocationList() as PropertyHasChangedDelegate[];
                //Array.ForEach(allObservers, (obs) =>
                //{
                //    try
                //    {
                //        obs(_name, value);
                //        _name = value;
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine("Exception happened");
                //    }
                //});
            }
        }
    }


}
