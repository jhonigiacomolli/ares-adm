using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace SHARP_INK.Classes
{
    class Classe_Produtos
    {
        public void Listar_Produtos(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["Cod_Fabrica"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Fornecedor"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Grupo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Descricao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["QuantidadeEstoque"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorCusto"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorVenda"].ToString().TrimEnd()).ToString("N2"));

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Pesquisa_Produtos(ListView LST, string Criterio, string Pesquisa)
        {
            try
            {
                string ComandoSQL = string.Empty;
                
                if (Criterio.Equals("Código")) { ComandoSQL = "SELECT * FROM Produtos WHERE id like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Código de Fábrica")) { ComandoSQL = "SELECT * FROM Produtos WHERE Cod_Fabrica like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Grupo")) { ComandoSQL = "SELECT * FROM Produtos WHERE Grupo like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Fornecedor")) { ComandoSQL = "SELECT * FROM Produtos WHERE Fornecedor like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Descrição")) { ComandoSQL = "SELECT * FROM Produtos WHERE Descricao like '" + Pesquisa + "%'"; }

                Listar_Produtos(LST, ComandoSQL);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
        public void Criar_CamposCategorias(ComboBox TipoPesquisa)
        {
            TipoPesquisa.Items.Add("Código");
            TipoPesquisa.Items.Add("Código de Fábrica");
            TipoPesquisa.Items.Add("Grupo");
            TipoPesquisa.Items.Add("Fornecedor");
            TipoPesquisa.Items.Add("Descrição");
            TipoPesquisa.SelectedIndex = 4;
        }
    }
}
