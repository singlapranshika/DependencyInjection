using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace DepemdencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IDataAccess, DataAccess>();
            BuisnessLogic bl = container.Resolve<BuisnessLogic>();
            Console.WriteLine(bl.GetData(1));
           // DataService s = new DataService();
           // Console.WriteLine( s.GetData(1));
        }
    }
}
