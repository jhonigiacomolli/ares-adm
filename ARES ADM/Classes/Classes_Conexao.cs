using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace ARES_ADM.Classes
{
    public class Classes_Conexao
    {
        private static string Password_DB = "++060188jhoni.fg";

        public static string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        //public static string strConnDatabase = @"Data Source=" + path + @"Database\Database.sdf;Password=" + Password_DB + "";
        public static string strConnDatabase = @"Data Source=D:\PARTICULAR\Projeto Auto Sharp\ARES ADM\ARES ADM\Database\Database.sdf;Password=" + Password_DB + "";
        public static string CaminhoLogo = path + @"\Logo\Logo.png";

        public static DataTable Preenche_DataTable(string SQL)
        {
            DataTable Data_Table;

            try
            {
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                Data_Table = DS.Tables[0];

                return Data_Table;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
                return null;
            }
        }    
    }
}
