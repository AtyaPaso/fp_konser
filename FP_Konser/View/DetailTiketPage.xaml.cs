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
    /// Interaction logic for DetailTiketPage.xaml
    /// </summary>
    public partial class DetailTiketPage : Page
    {
        private HomePage _home;
        private string _id_tiket;
        private Controller.DetailTiketController _controller;

        public DetailTiketPage(HomePage home, string id_tiket)
        {
            InitializeComponent();
            _home = home;
            _id_tiket = id_tiket;
            _controller = new Controller.DetailTiketController(this, id_tiket);
            _controller.loadDetailTiket();
        }

        private void btnPesan_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PembayaranPage(this, _id_tiket));
        }

        private void iconExit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
