using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading;

using System.Threading.Tasks;


namespace hangfire2

{

    public class Jobs

    {

        public void SendMail(int id)

        {

            Console.WriteLine("prepare mail id:"+ id.ToString()+"...");

            Console.WriteLine("sending main...");

            Thread.Sleep(100);

            Console.WriteLine("send  success!");

        }

    }

}
