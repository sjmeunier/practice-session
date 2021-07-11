using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using PracticeSession.Core.Interfaces;
using PracticeSession.Core.Services;
using Microsoft.Extensions.Logging;

namespace PracticeSession
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging(configure => configure.AddConsole());

            services.AddSingleton<MainForm>();
            services.AddScoped<IAudioPlaybackService, AudioPlaybackService>();
        }
    }
}
