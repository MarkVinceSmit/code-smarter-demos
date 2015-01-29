using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikon
{
    public class NikonCamera : ICamera
    {
        private string _brand = "Nikon";
        public string Brand
        {
            get { return _brand; }
        }
    }

    public class NikonFactory : ICameraCreator
    {
        public ICamera Create()
        {
            return new NikonCamera();
        }
    }

}
