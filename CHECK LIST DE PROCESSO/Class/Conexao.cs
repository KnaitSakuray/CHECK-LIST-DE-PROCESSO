using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHECK_LIST_DE_PROCESSO.Class
{
    class Conexao
    {
        /*
        private static string _ROTA = "Data Source = 192.168.108.16\\SQLEXPRESS; Initial Catalog = ROTA; Persist Security Info=True;User ID = crud; Password=2B2XWXMV";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }
        */
        private static string _ROTA = "";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }

    }
}
