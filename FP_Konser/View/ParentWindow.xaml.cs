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
    /// Interaction logic for ParentWindow.xaml
    /// </summary>
    public partial class ParentWindow : Window
    {

        private Controller.ParentController _controller;

        public ParentWindow()
        {
            InitializeComponent();
            frmMain.Navigate(new HomePage());
            _controller = new Controller.ParentController(this);
            _controller.loadUsrename();
        }

        private void userInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            menuTooltop.Visibility = Visibility.Visible;
        }

        private void userInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            menuTooltop.Visibility = Visibility.Hidden;
        }

        private void userInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(menuTooltop.Visibility == Visibility.Hidden)
            {
                menuTooltop.Visibility = Visibility.Visible;
            } else
            {
                menuTooltop.Visibility = Visibility.Hidden;

            }
        }

        private void btnOrder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuTooltop.Visibility = Visibility.Hidden;
            frmMain.Navigate(new OrderPage());
        }

        private void btnLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Properties["ID_USER"] = null;
            LoginWindow window = new LoginWindow();
            window.Show();
            Close();
        }

        private void btnProfile_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            menuTooltop.Visibility = Visibility.Hidden;
            frmMain.Navigate(new ProfilePage());
        }
    }
}
