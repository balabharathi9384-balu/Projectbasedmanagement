using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace multilanguage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object txtname;

        public MainWindow()
        {
            InitializeComponent();
        }



        //private void btnregister_Click(object sender, RoutedEventArgs e)
        //{
        //    Registrationform r= new Registrationform();
        //    r.Show();

          
        //}

        //private void cmblanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
            


            //ComboBoxItem lang = (ComboBoxItem)cmblanguage.SelectedItem;
            //string selectlang = lang.Content.ToString();
            //switch (selectlang)
            //{
            //    case "English":
            //        {
            //            CultureInfo culture = new CultureInfo("en-US");
            //            Thread.CurrentThread.CurrentUICulture = culture;
            //            break;
            //        }
            //    case "Tamil":
            //        {
            //            CultureInfo culture = new CultureInfo("ta-IN");
            //            Thread.CurrentThread.CurrentUICulture = culture;
            //            break;
            //        }
            //    case "Hindi":
            //        {
            //            CultureInfo culture = new CultureInfo("hi-IN");
            //            Thread.CurrentThread.CurrentUICulture = culture;
            //            break;
            //        }
                   

            //}
        //}

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            Registrationform rf=new Registrationform();
            rf.Show();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {

        }

        //    private void Login_Click(object sender, RoutedEventArgs e)
        //    {
        //        ResourceManager oresourse = new ResourceManager("Registrationform.Properties.Resources", Assembly.GetExecutingAssembly());
        //        string[] names = txtname.Text.Split(',');
        //        string welcome = string.Format(oresourse.GetString("welcome"), names[0], names[1]);
        //        MessageBox.Show(welcome);
        //        MessageBox.Show(oresource.GetString("sucess"));


        //    }
    }
}