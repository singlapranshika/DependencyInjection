using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepemdencyInjection
{
    //Implement IDependency when using Method injection
    public class DataService
    {
        BuisnessLogic BL;
        public DataService()
        {
            BL = new BuisnessLogic(new DataAccess());
            // BL.Property = new DataAccess();
          //  ((IDependency)BL).SetDependency(new DataAccess());
        }
        public string GetData(int id)
        {
            return BL.GetData(id);
        }
    }
}
