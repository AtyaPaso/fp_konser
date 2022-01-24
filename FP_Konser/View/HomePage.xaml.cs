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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FP_Konser.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {

        private Controller.HomeController _controller;

        public HomePage()
        {
            InitializeComponent();
            _controller = new Controller.HomeController(this);
            _controller.loadHome();
        }
        private void btnPesan_Click(object sender, RoutedEventArgs e)
        {
            string id_tiket = (sender as Button).Tag.ToString();
            this.NavigationService.Navigate(new DetailTiketPage(this, id_tiket));
        }
    }
}
