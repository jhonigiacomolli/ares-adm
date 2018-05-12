using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Text;
using System.Data;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK.Classes
{
    class Classe_Veiculos
    {
        public void Listar_Veiculos(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["Proprietario"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Veiculo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Placa"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Cor"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Tamanho"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Convert.ToDateTime(DR["Data_Cadastro"]).ToShortDateString().TrimEnd());
                        if (DR["Data_Entrega"].ToString().TrimEnd() != string.Empty) { Item.SubItems.Add(Convert.ToDateTime(DR["Data_Entrega"]).ToShortDateString().TrimEnd()); } else { Item.SubItems.Add(string.Empty); }
                        Item.SubItems.Add(DR["Situacao"].ToString().TrimEnd().ToUpper());

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch(SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO,"Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Listar_Veiculos(frmCadastroOS Form, string SQL)
        {
            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        Form.txtProprietario.Text = DR["Proprietario"].ToString().TrimEnd();
                        Form.txtVeiculo.Text = DR["Veiculo"].ToString().TrimEnd();
                        Form.txtPLaca.Text = DR["Placa"].ToString().TrimEnd();
                        Form.txtCor.SelectedIndex = Form.txtCor.FindString(DR["Cor"].ToString().TrimEnd());
                        Form.txtTamanho.SelectedIndex = Form.txtTamanho.FindString(DR["Tamanho"].ToString().TrimEnd());
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
        public void Adicionar_Veiculo (string Proprietario, string Veiculo, string Placa, string Cor, string Tamanho, DateTime DataCadastro, string Situacao)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO Veiculos(Proprietario,Veiculo,Placa,Cor,Tamanho,Data_Cadastro,Situacao)" +
                            " VALUES ('" + Proprietario + "','" + Veiculo + "','" + Placa + "','" + Cor + "','" + Tamanho + "','" + DataCadastro + "','" + Situacao + "')";

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
        public void Editar_Veiculos(int ID, string Proprietario, string Veiculo, string Placa, string Cor, string Tamanho)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE Veiculos SET Proprietario='" + Proprietario.Replace("'", "''") + "', Veiculo='" + Veiculo + "', Placa='" + Placa + "', Cor='" + Cor + "', Tamanho='" + Tamanho + "' WHERE id='" + ID + "'";

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
        public void Excluir_Veiculos(int ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM Veiculos WHERE id=" + ID + "";
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
        public void Abrir_OS(int ID)
        {
            string Situacao = "ABERTA";
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE Veiculos SET Situacao='" + Situacao.Replace("'", "''") + "' WHERE id='" + ID + "'";

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
        public void Pesquisar_Veiculos(ListView LST, string Criterio, string Pesquisa)
        {
            try
            {
                string ComandoSQL = string.Empty;

                if (Criterio.Equals("Todos")) { ComandoSQL = "SELECT * FROM Veiculos"; }
                if (Criterio.Equals("Numero OS")) { ComandoSQL = "SELECT * FROM Veiculos WHERE id='" + Pesquisa + "'"; }
                if (Criterio.Equals("Proprietário")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Proprietario like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Veículo")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Veiculo like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Placa")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Placa like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Cor")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Cor like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Tamanho")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Tamanho like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Data Cadastro")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Data_Cadastro like '" + Pesquisa + "%'"; }
                if (Criterio.Equals("Data Entrega")) { ComandoSQL = "SELECT * FROM Veiculos WHERE Data_Entrega like '" + Pesquisa + "%'"; }

                Listar_Veiculos(LST, ComandoSQL);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
    }
}
