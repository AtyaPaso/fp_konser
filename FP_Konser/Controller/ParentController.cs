using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Controller
{
    class ParentController
    {

        private View.ParentWindow _window;
        private Model.UserModel _user;

        public ParentController(View.ParentWindow window)
        {
            _window = window;
            _user = new Model.UserModel();
        }

        public void loadUsrename()
        {
            string id = App.Current.Properties["ID_USER"].ToString();
            _user.id_user = id;
            DataSet dt = _user.getUserById();
            _window.txtUserName.Text = dt.Tables[0].Rows[0]["nama_lengkap"].ToString();
        }

    }
}
