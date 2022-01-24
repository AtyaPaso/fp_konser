using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Model
{
    class TransaksiModel
    {

        private string table = "transaksi";
        private ModelTemplateQuery _template;

        public string id_transaksi { get; set; }
        public string id_user { get; set; }
        public string id_tiket { get; set; }
        public string kode_transaksi { get; set; }
        public string metode_bayar { get; set; }
        public string kode_pembayaran { get; set; }

        public TransaksiModel()
        {
            _template = new ModelTemplateQuery();
        }

        public Boolean insertTransaksi()
        {
            string tabel = "transaksi(id_user, id_tiket, kode_transaksi, metode_bayar, kode_pembayaran)";
            string data = string.Format("{0},{1},'{2}','{3}','{4}'", id_user, id_tiket, kode_transaksi, metode_bayar, kode_pembayaran);
            return _template.Insert(tabel, data);
        }

        public DataSet getTransaksiOrder()
        {
            DataSet ds;
            string id = App.Current.Properties["ID_USER"].ToString();
            string select = "transaksi.id_transaksi, tiket.kode_tiket, tiket.open_gate, tiket.lokasi, tiket.harga";
            string kondisi = string.Format("INNER JOIN tiket ON transaksi.id_tiket = tiket.id_tiket WHERE transaksi.id_user = {0}", id);
            ds = _template.CustomSelect(select, table, kondisi);
            return ds;
        }

        public DataSet getTransaksiDetail()
        {
            DataSet ds;
            string select = "*";
            string kondisi = string.Format("INNER JOIN tiket ON transaksi.id_tiket = tiket.id_tiket WHERE id_transaksi = {0}", id_transaksi);
            ds = _template.CustomSelect(select, table, kondisi);
            return ds;
        }

    }
}
