using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FP_Konser.Model
{
    class TiketModel
    {

        public string id_tiket { get; set; }
        public string kode_tiket { get; set; }
        public string nama_tiket { get; set; }
        public string open_gate { get; set; }
        public string tanggal_mulai { get; set; }
        public string selesai { get; set; }
        public string harga { get; set; }
        public string foto { get; set; }

        private ModelTemplateQuery _template;

        private string _table = "tiket";
        
        public TiketModel()
        {
            _template = new ModelTemplateQuery();
        }

        public DataSet getAllTiket()
        {
            return _template.Select(_table);
        }

        public DataSet getTiketById()
        {
            string kondisi = string.Format("id_tiket = '{0}'", id_tiket);
            return _template.Select(_table, kondisi);
        }

    }
}
