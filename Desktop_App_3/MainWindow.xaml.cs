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

namespace Desktop_App_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void Go_To_Signup_Page(object sender, RoutedEventArgs e)
        {
            Window2 objSignup = new Window2();
            this.Visibility = Visibility.Hidden;
            objSignup.Show();
        }

        private void Go_To_Login_Page(object sender, RoutedEventArgs e)
        {
            LoginPage objLoginPage = new LoginPage();
            this.Visibility = Visibility.Hidden;
            objLoginPage.Show();
        }
    }
}
