using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FP_Konser.Controller
{
    class PembayaranController
    {
        private View.PembayaranPage _page;
        private Model.TiketModel _tiket;
        private string _id_tiket;
        private string _kode_transaksi;

        public PembayaranController(View.PembayaranPage page, string id_tiket)
        {
            _page = page;
            _tiket = new Model.TiketModel(); ;
            _id_tiket = id_tiket;
            Random r = new Random();
            _kode_transaksi = "TRK" + r.Next(9999).ToString("D4");
            _tiket.id_tiket = id_tiket;
        }

        public void loadPembayaran()
        {
            DataSet ds = _tiket.getTiketById();
            var data = ds.Tables[0].Rows[0];
            string harga = String.Format(CultureInfo.CreateSpecificCulture("id-ID"), "Rp {0:N}", data["harga"].ToString());

            _page.txtKodeTransaksi.Text = _kode_transaksi;
            _page.txtTotalTransaksi.Text = harga;
        }
        public void gotoBayar()
        {
            string metodePembayaran = _page.cbMetodePembayaran.Text;
            _page.NavigationService.Navigate(new View.BayarPage(_page, _id_tiket, _kode_transaksi, metodePembayaran));
        }
    }
}
