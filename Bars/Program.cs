using DZ;
using NLog.Config;
using NLog;

namespace Bars
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("../../../NLog.config");
            ApplicationConfiguration.Initialize();
            Application.Run(new Cafe());
        }
    }
}