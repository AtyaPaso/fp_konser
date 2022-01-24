using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
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
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {

        private Controller.OrderController _controller;

        public OrderPage()
        {
            InitializeComponent();
            _controller = new Controller.OrderController(this);
            _controller.loadOrder();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = dgOrder.SelectedItem;
            string id_transaksi = (dgOrder.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            NavigationService.Navigate(new DetailOrderPage(this, id_transaksi));
        }

        private void btnExit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
;        }

        private void dgOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
