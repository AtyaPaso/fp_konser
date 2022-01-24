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
    /// Interaction logic for BayarPage.xaml
    /// </summary>
    public partial class BayarPage : Page
    {
        private PembayaranPage _pembayaranPage;
        private Controller.BayarController controller;

        public BayarPage(PembayaranPage pembayaranPage, string id_tiket, string kode_transaksi, string metode_transfer)
        {
            InitializeComponent();
            controller = new Controller.BayarController(this, id_tiket, kode_transaksi, metode_transfer);
            _pembayaranPage = pembayaranPage;
            controller.loadBayar();
        }

        private void btnKonfirmasi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Boolean result = controller.confirm();
            if(result)
            {
                MessageBox.Show("Data Berhasil dimasukan");
                NavigationService.Navigate(new OrderPage());
            } else
            {
                MessageBox.Show("Data Gagal Dimasukan");
            }
        }
    }
}
