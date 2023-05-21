using Newtonsoft.Json.Linq;
using Ninject;
using NLog;
using System;
using System.Configuration;
using Tws.SurveyMonkey.Data;
using TWS.ScheduledTask.SurveyMonkey.Services;

namespace TWS.ScheduledTask.SurveyMonkey
{
    public class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly SurveyLoadService 
            _service;
        public static void Main(string[] args)
        {
            try
            {
                Logger.Info("Hello world");

                var connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;

                var kernel = new StandardKernel(new ServiceModule());
                var _service = kernel.Get<SurveyLoadService>();

                 _service.Run().GetAwaiter().GetResult(); ;

            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Goodbye cruel world");
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }
    }
}
