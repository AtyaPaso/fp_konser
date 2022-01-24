using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class ProfileController
    {

        private View.ProfilePage _page;
        private Model.UserModel _user;

        private string _id_user;

        public ProfileController(View.ProfilePage page)
        {
            _page = page;
            _user = new Model.UserModel();
            loadUser();
        }

        public void loadUser()
        {
            string id = App.Current.Properties["ID_USER"].ToString();
            _user.id_user = id;
            DataSet ds = _user.getUserById();
            var data = ds.Tables[0].Rows[0];
            string jenisKelamin = "";

            if(data["jenis_kelamin"].ToString() == "L")
            { 
                jenisKelamin = "Laki - Laki";
            } else
            {
                jenisKelamin = "Perempuan";
            }

            _page.txtNamaLengkap.Text = data["nama_lengkap"].ToString();
            _page.txtUsername.Text = data["username"].ToString();
            _page.txtJenisKelamin.Text = jenisKelamin;
            _page.txtNoTelp.Text = data["no_telp"].ToString();
        }

    }
}
