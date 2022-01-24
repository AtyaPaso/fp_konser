using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Model
{
    class UserModel
    {

        private string tabel = "pengguna";

        public string id_user { get; set; }
        public string nama_lengkap { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string jenis_kelamin { get; set; }
        public string no_telp { get; set; }


        private ModelTemplateQuery _template;

        public UserModel()
        {
            _template = new ModelTemplateQuery();
        }

        public DataSet getUserByUsernamePassword()
        {
            DataSet data;
            string kondisi = string.Format("username = '{0}' AND password = '{1}'", username, password);

            data = _template.Select(tabel, kondisi);
            return data;
        }

        public DataSet getUserById()
        {
            string kondisi = string.Format("id_user = '{0}'", id_user);
            return _template.Select(tabel, kondisi);
        }
    }
}
