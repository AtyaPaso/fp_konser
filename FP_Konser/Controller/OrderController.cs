using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class OrderController
    {

        private Model.TransaksiModel _transaksi;
        private View.OrderPage _page;

        public OrderController(View.OrderPage page)
        {
            _page = page;
            _transaksi = new Model.TransaksiModel();
        }
        
        public void loadOrder()
        {
            DataSet ds = _transaksi.getTransaksiOrder();
            _page.dgOrder.ItemsSource = ds.Tables[0].DefaultView;
        }

    }
}
