using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class BayarController
    {
        private View.BayarPage _page;
        private Model.TiketModel _tiket;
        private Model.TransaksiModel _transaksi;

        private string _id_tiket;
        private string _kode_transaksi;
        private string _metode_pembayaran;
        private string _kode_bayar;

        public BayarController(View.BayarPage page, string id_tiket, string kode_transaksi, string metode_pembayaran)
        {
            _page = page;
            _tiket = new Model.TiketModel();
            _transaksi = new Model.TransaksiModel();
            _id_tiket = id_tiket;
            _kode_transaksi = kode_transaksi;
            _metode_pembayaran = metode_pembayaran;
        }

        public void loadBayar()
        {
            _tiket.id_tiket = _id_tiket;
            DataSet ds = _tiket.getTiketById();
            string total = ds.Tables[0].Rows[0]["harga"].ToString();

            if (_metode_pembayaran == "TRANSFER")
                _kode_bayar = "2151242342421";
            if (_metode_pembayaran == "DANA")
                _kode_bayar = "083840735277";
            if (_metode_pembayaran == "INDOMARET")
                _kode_bayar = "1314234112";

            _page.txtKodeTransaksi.Text = _kode_transaksi; 
            _page.txtMetodePembayaran.Text = _metode_pembayaran;
            _page.txtKodePembayaran.Text = _kode_bayar;
            _page.txtTotal.Text = total;
        }

        public Boolean confirm()
        {
            _transaksi.id_tiket = _id_tiket;
            _transaksi.id_user = App.Current.Properties["ID_USER"].ToString();
            _transaksi.kode_pembayaran = _kode_bayar;
            _transaksi.kode_transaksi = _kode_transaksi;
            _transaksi.metode_bayar = _metode_pembayaran;

            Boolean result = _transaksi.insertTransaksi();
            return result;
        }
    }
}
