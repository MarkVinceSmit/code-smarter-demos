using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanonCreator
{
    public class CanonCamera : ICamera
    {
        private string _brand = "Canon";
        public string Brand
        {
            get { return _brand; }
        }
    }


    
    public class CanonFactory : ICameraCreator
    {
        public ICamera Create()
        {
            return new CanonCamera();
        }
    }
}
