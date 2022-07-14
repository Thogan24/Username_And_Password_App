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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public string UsernameInput_Login = "";
        public string PasswordInput_Login = "";

        bool LoginCorrect = false;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            UsernameInput_Login = UsernameInputBox_Login.Text;
            PasswordInput_Login = PasswordInputBox_Login.Text;
            //PasswordInput passwordinput = new PasswordInput();
            Window2 window2 = new Window2();
            MessageBox.Show(window2.UsernameInput);
            

            //if (UsernameInput_Login = UsernameInput && PasswordInput_Login = PasswordInput)
            //{
            //    LoginCorrect = true;
            //}
            if (LoginCorrect == true)
            {
                MainPage objMainPage = new MainPage();
                this.Visibility = Visibility.Hidden;
                objMainPage.Show();
            }
        }
        
    }
}
