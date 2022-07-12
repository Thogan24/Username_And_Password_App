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
using System.Windows.Shapes;

namespace Desktop_App_3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        private string UsernameInput = "";
        private string PasswordInput = "";
        public Window2()
        {
            InitializeComponent();
            
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void Window2_Click(object sender, RoutedEventArgs e)
        {
            ///UsernameLabel.Content = "Le j";
            UsernameInput = UsernameInputBox.Text;
            PasswordInput = PasswordInputBox.Text;

            if (UsernameInput == "" || PasswordInput == "")
            {
                MessageBox.Show($"Username or Password is null. Please enter something.");
            }

            else
            {
                MessageBox.Show($"Username - {UsernameInput} and Password - {PasswordInput} Successfully Set up");
                MainWindow objMainWindow = new MainWindow();
                this.Visibility = Visibility.Hidden;
                objMainWindow.Show();
            }
        }

        
}
}
