using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class HomeController
    {

        private View.HomePage _page;
        private Model.TiketModel _tiket;

        public HomeController(View.HomePage page)
        {
            _page = page;
            _tiket = new Model.TiketModel();
        }

        public void loadHome()
        {
            DataSet data = _tiket.getAllTiket();
            string path = App.Current.Properties["CURRENT_PATH"].ToString();
            for(int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                string foto = data.Tables[0].Rows[i]["foto"].ToString();
                data.Tables[0].Rows[i]["foto"] = path + "\\assets\\img\\" + foto;
            }
            _page.dgTiket.ItemsSource = data.Tables[0].DefaultView;
        }

    }
}
