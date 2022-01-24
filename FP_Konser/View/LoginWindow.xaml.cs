using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FP_Konser.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        Controller.AuthController _auth;

        public LoginWindow()
        {
            InitializeComponent();
            _auth = new Controller.AuthController(this);
            App.Current.Properties["CURRENT_PATH"] = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(_auth.Login())
            {
                ParentWindow parent = new ParentWindow();

                parent.Show();
                Close();
            } else
            {
                MessageBox.Show("Username atau password salah");
            }
        }
    }
}
