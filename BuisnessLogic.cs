using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepemdencyInjection
{
    public class BuisnessLogic
    {
        IDataAccess obj;
        public BuisnessLogic()
        {
            obj = new DataAccess();
        }
        //Constructor Injection
        //Object of DataAccess class Passed to BuisnessLogic Class
        public BuisnessLogic(IDataAccess _data)
        {
            obj = _data;
        }

        //Property Injection
        // public IDataAccess Property { get; set; }

        //Method Injection
        //   public void SetDependency(IDataAccess d)
        //{
        //    obj = d;
        //}
        public string GetData(int id)
        {
            return obj.GetData(id);
        }
    }
}
