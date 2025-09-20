using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using System.IO;

namespace multilanguage
{
    /// <summary>
    /// Interaction logic for Registrationform.xaml
    /// </summary>
    public partial class Registrationform : Window
    {
      
        public Registrationform()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //ResourceManager oresourses = new ResourceManager("Multilanguage.Properties.Resources", Assembly.GetExecutingAssembly());
            ////string[] names = txtname.Text.Split();
            ////string welcome = string.Format(oresourses.GetString("welcome"), names[0], names[1]);
            ////MessageBox.Show(welcome);
            //MessageBox.Show(oresourses.GetString("sucess"));


        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {

        }

        ////private void btnwrite_Click(object sender, RoutedEventArgs e)
        ////{
        ////    File.Create("C:\\Users\\Admin\\Documents\\Nila.txt");
        ////    //File Create
        ////    //File Write
        ////    //File Replace    

        ////    //File.WriteAllText("C:\\Users\\Admin\\Documents\\Bala.txt","Hi Welcome Bala ");
        ////}

        ////private void btnread_Click(object sender, RoutedEventArgs e)
        ////{
        ////    if(File.Exists("C:\\Users\\Admin\\Documents\\Bala1.txt"))
        ////    {
        ////        string data = File.ReadAllText("C:\\Users\\Admin\\Documents\\Bala.txt");
        ////        MessageBox.Show(data);

        ////    }
        ////    else
        ////    {
        ////        MessageBox.Show("File does not exists");
        ////    }

        ////}

        ////private void btndelete_Click(object sender, RoutedEventArgs e)
        ////{
        ////    File.Delete("C:\\Users\\Admin\\Documents\\Nila.txt");

        ////}

        ////private void btncreate_Click(object sender, RoutedEventArgs e)
        ////{

        ////}

        ////private void btnfoldercreate_Click(object sender, RoutedEventArgs e)
        ////{
        ////    Directory.CreateDirectory("C:\\Users\\Admin\\Documents\\balumoon.txt");
        ////}

        ////private void btnfolderdelete_Click(object sender, RoutedEventArgs e)
        ////{
        ////    Directory.Delete("C:\\Users\\Admin\\Documents\\balumoon.txt");
        ////}

        ////private void btnolderfiles_Click(object sender, RoutedEventArgs e)
        ////{
        ////    DirectoryInfo info = new DirectoryInfo("C:\\Users\\Admin\\Pictures\\kabaddi");
        ////    FileInfo[] listfiles=info.GetFiles();
        ////    DirectoryInfo[] listfolder=info.GetDirectories();
        ////    foreach (FileInfo item in listfiles)
        ////    {
        ////        MessageBox.Show("File name:"+item.Name);
        ////    }
        ////    foreach (DirectoryInfo item in listfolder)
        ////    { 
        ////        MessageBox.Show("Folder:"+item.Name); 
        ////    } 




        //}
    }
}
