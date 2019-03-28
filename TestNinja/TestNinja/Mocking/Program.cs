using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();

            //Dep Injection via Method Parameters
            //var title = service.ReadVideoTitle(new FileReader());
        }
    }
}
