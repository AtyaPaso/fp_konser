using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FP_Konser.Controller
{
    class AuthController
    {
        private View.LoginWindow _window;
        private Model.UserModel _user;

        public AuthController(View.LoginWindow window)
        {
            _window = window;
            
            _user = new Model.UserModel();
        }

        public Boolean Login()
        {
            _user.username = _window.txtUsername.Text;
            _user.password = _window.txtPassword.Password;

            DataSet data = _user.getUserByUsernamePassword();
            
            if(data.Tables[0].Rows.Count > 0)
            {
                App.Current.Properties["ID_USER"] = data.Tables[0].Rows[0]["id_user"].ToString();
                return true;
            } else
            {
                return false;
            }
        }
    }
}
