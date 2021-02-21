using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CanteenFoodServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(CanteenFoodService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host Started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
