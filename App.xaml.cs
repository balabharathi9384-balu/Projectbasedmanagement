using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace multilanguage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            CultureInfo culture = new CultureInfo("ta-IN");
            Thread.CurrentThread.CurrentUICulture = culture;
            base.OnStartup(e);
        }
    }
}


