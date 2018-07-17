using System.Web.Http.Dispatcher;
using System.Web.Http.SelfHost;

namespace Archive.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args);
        }

        public static void BuildWebHost(string[]  args)
        {
            string baseAddress = "http://localhost:8080";

            var configuration = new HttpSelfHostConfiguration(baseAddress);
            configuration.Services.Replace(typeof(IAssembliesResolver), new AssembliesResolver());

            WebApiConfig.RegisterRoutes(configuration.Routes);

            using (HttpSelfHostServer server = new HttpSelfHostServer(configuration))
            {
                server.OpenAsync().Wait();
                System.Console.WriteLine("Service started at http://localhost:8080");
                System.Console.ReadLine();
            }
        }
            
    }
}
