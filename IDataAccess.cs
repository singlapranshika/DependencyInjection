using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepemdencyInjection
{
    public interface IDataAccess
    {
       // int id { get; set; }
         string GetData(int id);
    }
}
