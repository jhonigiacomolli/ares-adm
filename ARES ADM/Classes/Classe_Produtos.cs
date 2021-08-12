using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_Produtos
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();

        public string id { get; private set; }
        public string Cod_Fabrica { get; private set; }
        public string Grupo { get; private set; }
        public string Descricao { get; private set; }
        public string QuantidadeEstoque { get; private set; }
        public double Custo { get; private set; }
        public double Venda { get; private set; }
        public string Fornecedor { get; private set; }

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

        public void Listar_Produtos(string ID)
        {
            string SQL = "SELECT * FROM Produtos WHERE id='" + ID + "'";
            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        id = DR["id"].ToString();
                        Cod_Fabrica = DR["Cod_Fabrica"].ToString().TrimEnd().ToUpper();
                        Fornecedor = DR["Fornecedor"].ToString().TrimEnd().ToUpper();
                        Grupo = DR["Grupo"].ToString().TrimEnd().ToUpper();
                        Descricao = DR["Descricao"].ToString().TrimEnd().ToUpper();
                        QuantidadeEstoque = DR["QuantidadeEstoque"].ToString().TrimEnd().ToUpper();
                        Custo = Convert.ToDouble(DR["ValorCusto"].ToString().TrimEnd());
                        Venda = Convert.ToDouble(DR["ValorVenda"].ToString().TrimEnd());
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

        public void Get_GruposProdutos(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Grupo FROM Produtos_Grupos ORDER BY Grupo ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Grupo"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Get_Fornecedores(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Fornecedor FROM Fornecedores ORDER BY Fornecedor ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Fornecedor"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Adicionar_Produto(string Grupo, string CodFabrica, string Fornecedor, string Descricao, string Custo, string Venda)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO Produtos(Grupo,Cod_Fabrica,Fornecedor,Descricao,ValorCusto,ValorVenda)" +
                            " VALUES ('" + Grupo + "','" + CodFabrica + "','" + Fornecedor + "','" + Descricao + "','" + Custo + "','" + Venda + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

       public void Editar_Produto(int ID, string Grupo, string CodFabrica, string Fornecedor, string Descricao, string Custo, string Venda)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE Produtos SET Grupo='" + Grupo.Replace("'", "''") + "', Cod_Fabrica='" + CodFabrica + "', Fornecedor='" + Fornecedor + "', Descricao='" + Descricao + "', ValorCusto='" + Custo + "', ValorVenda='" + Venda + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Excluir_Produto (int ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM Produtos WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
    }
}
