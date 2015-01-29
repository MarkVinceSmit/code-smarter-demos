using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICameraCreator
    {
        ICamera Create();
    }

    public interface ICamera
    {
         string Brand { get; }    
    }
}
