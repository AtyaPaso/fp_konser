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
    /// Interaction logic for PembayaranPage.xaml
    /// </summary>
    public partial class PembayaranPage : Page
    {

        private DetailTiketPage _detailPage;
        private Controller.PembayaranController controller;
        private string _id_tiket;

        public PembayaranPage(DetailTiketPage detail, string id_tiket)
        {
            InitializeComponent();
            controller = new Controller.PembayaranController(this, id_tiket); ;
            _detailPage = detail;
            _id_tiket = id_tiket;
            controller.loadPembayaran();
        }

        private void cbMetodePembayaran_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBayar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(cbMetodePembayaran.SelectedItem == null)
            {
                MessageBox.Show("Silahkan Pilih Metode Pembayaran Terlebih dahulu");
            } else
            {
                controller.gotoBayar();
            }
        }

        private void btnExit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
