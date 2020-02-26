using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepemdencyInjection
{
   public  class DataAccess: IDataAccess
    {
        public DataAccess()
        { 
            
        }
        public string GetData(int id)
        {
            return "Hello"+id;
        }
    }
}
