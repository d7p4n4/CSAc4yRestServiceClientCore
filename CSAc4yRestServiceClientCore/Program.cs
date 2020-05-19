using log4net;
using log4net.Config;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;
using static CSEFTPC4Core3ObjectService.ObjectServices.Ac4yPersistentChildEFService;

namespace CSAc4yRestServiceClientCore
{
    public class Program
    {

        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {

            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();


            GetByIdResponse response =
                new CSEFTPC4Core3RESTServiceClient().GetById(new GetByIdRequest() { Id = 12 });
        }
    }

}
