using iCAN.CLASS;
using iCAN.GUI;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iCAN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txUsername.Text.Replace("\n", ""); ;
            string password = txPassword.Password;
            User user = new User();
            if (user.check_login(username, password))
            {
                Dashboard a = new Dashboard();
                a.Show();
                frmLogin.Close();
                
            }


            //login Login = new login(txUsername.Text, txPassword.Password);
            //Login.check_login();
        }
    }
}
