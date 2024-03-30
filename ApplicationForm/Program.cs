using log4net.Config;

// Configure LOG4NET Using configuration file.
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ApplicationForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicConfigurator.Configure();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}