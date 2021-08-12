using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_MO
    {
        public void Get_MO(ComboBox CBO)
        {
            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM MaoObra");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        CBO.Items.Add(DR["MO"].ToString().TrimEnd().ToUpper());
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public string Get_MOPintura()
        {
            string MO = string.Empty;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM MaoObra WHERE MO='Hora Pintura'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        MO = DR["ValorMO"].ToString().TrimEnd().ToUpper();
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
            return MO;
        }

        public string Get_ValorRefMO(string TipoMO)
        {
            string MO = string.Empty;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM MaoObra WHERE MO='" + TipoMO + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        MO = DR["ValorMO"].ToString().TrimEnd().ToUpper();
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
            return MO;
        }
    }
}
