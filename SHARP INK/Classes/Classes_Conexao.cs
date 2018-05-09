using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace SHARP_INK.Classes
{
    public class Classes_Conexao
    {
        private static  string Password_DB = "++060188jhoni.fg";
        public static string strConnDatabase = @"Data Source=D:\Projeto Auto Sharp\SHARP INK\SHARP INK\Database\Database.sdf;Password=" + Password_DB + "";

        public static DataTable Preenche_DataTable (string SQL)
        {
            SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
            DataSet DS = new DataSet();
            SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL,CONN);            

            DA.Fill(DS);

            DataTable Data_Table = DS.Tables[0];
            return Data_Table;
        }
    }
}
