using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stater
{
    class Program
    {
        static void Main(string[] args)
        {
            StateMachine sm = new StateMachine();


            sm.Transition(1);
            sm.Transition(1);



        }
    }




    public class Person
    {
        public Person(string name)
        {
            
        }

        public string Name{ get; set; }

        public void SatyHello()
        {
            

        }
    }

}
