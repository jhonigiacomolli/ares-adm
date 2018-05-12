using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
                return null;           
            }
        }

        public void Get_Cores(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Cor FROM Cores ORDER BY Cor ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Cor"].ToString());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Get_Tamanho(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Tamanho FROM Tamanho ORDER BY id ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Tamanho"].ToString());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
        public void Get_Proprietario(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Nome FROM Proprietario ORDER BY Nome ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Nome"].ToString());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
    }
}
