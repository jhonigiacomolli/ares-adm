using System;
using System.Data.SqlServerCe;
using System.Data;
using SHARP_INK.Classes;
using System.Windows.Forms;

namespace SHARP_INK.Classes
{
    class Classe_Funcionario
    {
        public void Listar_Funcionarios(ListView LST, string SQL)
        {
            try
            {
                LST.Items.Clear();

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        Item.SubItems.Add(DR["Nome"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Endereco"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Telefone"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Email"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Sexo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Funcao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Salario"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Comissao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CargaHoraria"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["ValorHora"].ToString().TrimEnd().ToUpper());

                        LST.Items.Add(Item);
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

        public void Pesquisa_Funcionario(ListView LST, string Criterio, string Pesquisa)
        {
            try
            {
                string ComandoSQL = string.Empty;

                if (Criterio.Equals("Nome")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Nome like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Endereço")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Endereco like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Sexo")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Sexo like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Função")) { ComandoSQL = "SELECT * FROM Funcionarios WHERE Funcao like '" + Pesquisa + "%'"; }

                Listar_Funcionarios(LST, ComandoSQL);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

    }
}
