using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire.SQLite;
using Microsoft.Owin.Hosting;

　
namespace hangfire2
{
    class Program
    {
        static void Main(string[] args)
        {

　
　
            //string connStr = @"Password=king_12345;Persist Security Info=True;User ID=sa;Initial Catalog=BackProcess;Data Source=PRCDAL995L\SQLEXPRESS";
            ////var client = new BackgroundJobClient();

            //string DBPath = @"./db/hangfire.db;Version=3;";
            ////Data Source=C:\SQLITEDATABASES\SQLITEDB1.sqlite;Version=3;");

            //string liteStr = "Data Source=" + DBPath;
            //GlobalConfiguration.Configuration.UseSQLiteStorage(liteStr);
            ////GlobalConfiguration.Configuration.UseSqlServerStorage(connStr);

            const string endpoint = "http://localhost:54321";

            using (WebApp.Start<Startup>(endpoint))
            {
                Console.WriteLine();
                Console.WriteLine("{0} Hangfire Server started.", DateTime.Now);
                Console.WriteLine("{0} Dashboard is available at {1}/hangfire", DateTime.Now, endpoint);
                Console.WriteLine();
                Console.WriteLine("{0} Type JOB to add a background job.", DateTime.Now);
                Console.WriteLine("{0} Press ENTER to exit...", DateTime.Now);

　
                string command;
                while ((command = Console.ReadLine()) != String.Empty)
                {
                    //if ("job".Equals(command, StringComparison.OrdinalIgnoreCase))
                    //{
                    //    RecurringJob.AddOrUpdate(() => Console.WriteLine("{0} Background job completed successfully!", DateTime.Now.ToString()), Cron.Minutely);

                    //    //BackgroundJob.Schedule(() => Console.WriteLine("{0} Background job completed successfully!", DateTime.Now.ToString()));
                    //}
                }
            }
        }

       
    }
}
