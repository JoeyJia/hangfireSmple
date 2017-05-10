using Hangfire;
using Microsoft.Owin;
using Owin;
using System;
using Hangfire.SQLite;

[assembly: OwinStartup(typeof(hangfire2.Startup))]

namespace hangfire2
{
    public class Startup
    {
      
        public void Configuration(IAppBuilder app)
        {
            // Hangfire configuration
            var options = new SQLiteStorageOptions();
            //string DBPath = @"./db/hangfire.db;Version=3;";
            //Data Source=C:\SQLITEDATABASES\SQLITEDB1.sqlite;Version=3;");

            //string liteStr = "Data Source=" + DBPath;
            GlobalConfiguration.Configuration.UseSQLiteStorage("SQLiteHangfire", options);
            var option = new BackgroundJobServerOptions { WorkerCount = 1 };
            app.UseHangfireServer(option);
            app.UseHangfireDashboard();

            // Add scheduled jobs
            Jobs jobs = new Jobs();
            RecurringJob.AddOrUpdate(() => Console.WriteLine("{0} Background job completed successfully!", DateTime.Now.ToString()), Cron.Minutely);

            RecurringJob.AddOrUpdate(() => Console.WriteLine("{0} Background job completed successfully!", DateTime.Now.ToString()), Cron.Monthly(3,2));
            RecurringJob.AddOrUpdate(() => jobs.SendMail(1), Cron.Minutely);
            RecurringJob.AddOrUpdate(() => jobs.SendMail(2), Cron.Minutely);
            // Map Dashboard to the `http://<your-app>/hangfire` URL.
            ////app.UseHangfireDashboard();
            ////app.UseHangfireServer();

            //var options = new DashboardOptions { AppPath = "http://localhost:9999" };

            //app.UseHangfireDashboard("/jobs", options);

            //var options = new DashboardOptions
            //{
            //     AuthorizationFilters =
            //};
            //app.UseHangfireDashboard("/hangfire", options);

        }
    }
}
