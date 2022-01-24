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
    /// Interaction logic for DetailOrderPage.xaml
    /// </summary>
    public partial class DetailOrderPage : Page
    {

        private string _id_transaksi;

        private OrderPage _orderPage;
        private Controller.DetailOrderController controller;

        public DetailOrderPage(OrderPage orderPage, string id_transaksi)
        {
            InitializeComponent();
            _orderPage = orderPage;
            _id_transaksi = id_transaksi;
            controller = new Controller.DetailOrderController(this, id_transaksi);
            controller.LoadDetailOrder();
        }

        private void btnExit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
