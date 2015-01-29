using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Reflection;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = ConfigurationManager.AppSettings["filename"];
            string typename = ConfigurationManager.AppSettings["typename"];

            ValueBuilder builder = new ValueBuilder();
            builder.SetValue("hELLO WORLD");
            var a = builder.Build();

            builder.SetValue("");
            var b = builder.Build();

            Console.WriteLine("A{1} == B{2} ??? {0}",
                Object.ReferenceEquals(a, b),
            a.Value,
            b.Value);


            Assembly asm = Assembly.Load(filename);
            ICameraCreator cameraCreator = asm.CreateInstance(typename) as ICameraCreator;

            ICamera camera = cameraCreator.Create();
            Console.WriteLine(camera.Brand);
        }
    }


    public class ValueBuilder
    {
        private object _currentValue;

        public void SetValue(object newValue)
        {
            _currentValue = newValue;
        }

        public ValueBuilder  Build()
        {
            return this.MemberwiseClone() as ValueBuilder;
        }

        public object Value
        {
            get
            {
                return _currentValue;
            } 
        }
    }
}
