using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)] <- Moved to AssemblyInfo.cs

namespace SingleROk
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            log.Error("this is an error message.");

            Console.ReadLine();
        }
    }
}
