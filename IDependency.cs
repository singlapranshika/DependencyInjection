using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepemdencyInjection
{
    //Method Injection by interface
    public interface IDependency
    {
         void SetDependency(IDataAccess d);
    }
}
