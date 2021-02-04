using System;
using System.Windows;

namespace ii
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();

            if (e.Args.Length > 0)
            {
                Console.WriteLine(e.Args[0]);
                mainWindow.OpenImage(e.Args[0]);
            }
            
            mainWindow.Show();
        }
    }
}