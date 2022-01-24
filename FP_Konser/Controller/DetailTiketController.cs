using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Media.Imaging;

namespace FP_Konser.Controller
{
    class DetailTiketController
    {

        private View.DetailTiketPage _page;
        private Model.TiketModel _tiket;

        private string _id_tiket;

        public DetailTiketController(View.DetailTiketPage page, string id_tiket)
        {
            _page = page;
            _tiket = new Model.TiketModel();
            _id_tiket = id_tiket;
            loadDetailTiket();
        }

        public void loadDetailTiket()
        {
            _tiket.id_tiket = _id_tiket;
            DataSet ds = _tiket.getTiketById();

            var data = ds.Tables[0].Rows[0];
            string path = App.Current.Properties["CURRENT_PATH"].ToString();
            string imagePath = path + "\\assets\\img\\" + data["foto"].ToString();
            string opengate = DateTime.Parse(data["open_gate"].ToString()).ToString("HH.mm") + " WIB";
            string start = DateTime.Parse(data["tanggal_mulai"].ToString()).ToString("HH.mm");
            string end = DateTime.Parse(data["selesai"].ToString()).ToString("HH.mm");
            string tanggal = DateTime.Parse(data["open_gate"].ToString()).ToString("dd MMMM yyyy");

            _page.txtNamaTiket.Text = data["nama_tiket"].ToString();
            _page.imgBannerTiket.Source = new BitmapImage(new Uri(imagePath));
            _page.txtLokasi.Text = data["lokasi"].ToString();
            _page.txtOpengate.Text = opengate;
            _page.txtJam.Text = start + " - " + end + " WIB";
            _page.txtTanggal.Text = tanggal;
        }

        

    }
}
