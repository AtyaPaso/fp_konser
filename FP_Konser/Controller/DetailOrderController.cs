using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class DetailOrderController
    {

        private View.DetailOrderPage _page;
        private Model.TransaksiModel _transaksi;

        private string _id_transaksi;

        public DetailOrderController(View.DetailOrderPage page, string id_transaksi)
        {
            _page = page;
            _transaksi = new Model.TransaksiModel();
            _id_transaksi = id_transaksi;
        }

        public void LoadDetailOrder()
        {
            _transaksi.id_transaksi = _id_transaksi;
            DataSet ds = _transaksi.getTransaksiDetail();
            var data = ds.Tables[0].Rows[0];
            string start = DateTime.Parse(data["tanggal_mulai"].ToString()).ToString("HH.mm");
            string end = DateTime.Parse(data["selesai"].ToString()).ToString("HH.mm");
            string jam = start + " - " + end ;

            _page.txtKodeTiket.Text = data["kode_tiket"].ToString();
            _page.txtNamaTiket.Text = data["nama_tiket"].ToString();
            _page.txtKodePesanan.Text = data["kode_transaksi"].ToString();
            _page.txtJam.Text = jam;
        }

    }
}
