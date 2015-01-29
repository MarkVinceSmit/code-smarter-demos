using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {

            // The hidden IF
            // int a = 4243 > 4343 ? "a" : "B";

            // using a class that doesn't use ANY if/select/switch statement
            stuff myStuff = new stuff();
            myStuff.Mode = 0;
            myStuff.PerformAction();
            myStuff.Mode = 1;
            myStuff.PerformAction();
            myStuff.Mode = 2;
            myStuff.PerformAction();
            myStuff.Mode = 1001;
            myStuff.PerformAction();
            myStuff.Mode = -20;
            myStuff.PerformAction();

            // return;


            // simple iteration
            inters i = new inters();
            foreach (int x in i.YieldIt())
            {
                Console.WriteLine( x );
            }


            // composition
            Concrete2 top = new Concrete2();
            top.AddChild( new Concrete1());
            top.AddChild(new Concrete1());
            top.AddChild(new Concrete1());
            Concrete2 Sub = new Concrete2();
            Sub.AddChild(new Concrete1());
            top.AddChild(Sub);


            // aggregate all children regardless of structure.
            foreach (var obj in top.Children())
            {
                Console.WriteLine(obj.GetHashCode() );
            }
        }
    }

    public class inters
    {
        public IEnumerable<int> YieldIt()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

    }

    public abstract class SomeBase
    {
        protected IList<SomeBase> children = new List<SomeBase>();

        public abstract void AddChild(SomeBase newChild);

        public IEnumerable<SomeBase> Children()
        {
            yield return this;

            foreach (var child in children)
            {
                yield return child;
            }
        }
    }

    public class Concrete1 : SomeBase
    {
        public override void AddChild(SomeBase child)
        {
           throw new NotSupportedException();
        }
    }

    public class Concrete2 : SomeBase
    {
        public override void AddChild(SomeBase child)
        {
            children.Add(child);
        }
    }


    public class stuff
    {
        // the jumptabl consist of all possible functionality)preferable dynamicaly loaded & build)
        // with an noop for anything out of bounds
        private Action[] jumpTable = new Action[] {
           () => {  },
            () => { Console.WriteLine("In viewmode"); },
            () => { Console.WriteLine("In editmode"); },
            () => { Console.WriteLine("New mode");},
            () => {  } 
        };

        public int Mode;    // 0 = read, 1 = edit

        public void PerformAction()
        {
            // calulate jump index for table
            int jumpIndex = Math.Max(0, Math.Min(Mode + 1, jumpTable.Length - 1));

            // execute functionality from jump table.
            jumpTable[jumpIndex]();
        }

    }

}
