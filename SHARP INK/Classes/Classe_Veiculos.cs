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
            LST.Items.Clear();

            DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);
            
           for(int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow DR = DT.Rows[i];
                if (DR.RowState != DataRowState.Deleted)
                {
                    ListViewItem Item = new ListViewItem(DR["id"].ToString());
                    Item.SubItems.Add(DR["Proprietario"].ToString().ToUpper());
                    Item.SubItems.Add(DR["Veiculo"].ToString().ToUpper());
                    Item.SubItems.Add(DR["Placa"].ToString().ToUpper());
                    Item.SubItems.Add(DR["Cor"].ToString().ToUpper());
                    Item.SubItems.Add(DR["Tamanho"].ToString().ToUpper());
                    Item.SubItems.Add(Convert.ToDateTime(DR["Data_Cadastro"]).ToShortDateString());
                    if (DR["Data_Entrega"].ToString() != string.Empty) { Item.SubItems.Add(Convert.ToDateTime(DR["Data_Entrega"]).ToShortDateString()); } else {Item.SubItems.Add(string.Empty); }
                    Item.SubItems.Add(DR["Situacao"].ToString().ToUpper());

                    LST.Items.Add(Item);
                }
            }
            DT.Dispose();
        }

        public void Listar_Veiculos(frmCadastroOS Form, string SQL)
        {
            DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow DR = DT.Rows[i];
                if (DR.RowState != DataRowState.Deleted)
                {
                    Form.txtProprietario.Text = DR["Proprietario"].ToString().TrimEnd();
                    Form.txtVeiculo.Text= DR["Veiculo"].ToString().TrimEnd();
                    Form.txtPLaca.Text= DR["Placa"].ToString().TrimEnd();
                    Form.txtCor.SelectedIndex = Form.txtCor.FindString(DR["Cor"].ToString());
                    Form.txtTamanho.SelectedIndex = Form.txtTamanho.FindString(DR["Tamanho"].ToString());
                }
            }
            DT.Dispose();
        }
        public void Adicionar_Veiculo (string Proprietario, string Veiculo, string Placa, string Cor, string Tamanho, DateTime DataCadastro, string Situacao)
        {
            SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

            string comandoSQL = "INSERT INTO Veiculos(Proprietario,Veiculo,Placa,Cor,Tamanho,Data_Cadastro,Situacao)" +
                        " VALUES ('" + Proprietario + "','" + Veiculo + "','" + Placa + "','" + Cor + "','" + Tamanho + "','" + DataCadastro + "','" + Situacao + "')";

            SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
        }
        public void Editar_Veiculos(int ID, string Proprietario, string Veiculo, string Placa, string Cor, string Tamanho, DateTime DataCadastro, string Situacao)
        {
            SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

            string comandoSQL = "UPDATE Veiculos SET Proprietario='" + Proprietario.Replace("'", "''") + "', Veiculo='" + Veiculo + "', Placa='" + Placa + "', Cor='" + Cor + "', Tamanho='" + Tamanho + "' WHERE id='" + ID + "'";

            SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
        }
        public void Excluir_Veiculos(int ID)
        {
            SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

            string comandoSQL = "DELETE FROM Veiculos WHERE id=" + ID + "";
            SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

            CONN.Open();
            CMD.ExecuteNonQuery();
            CONN.Close();
        }
        public void Pesquisar_Veiculos(ListView LST, string Criterio, string Pesquisa)
        {
            string ComandoSQL=string.Empty;

            if (Criterio.Equals("Todos")) { ComandoSQL = "SELECT * FROM Veiculos"; }
            if (Criterio.Equals("Numero OS")) { ComandoSQL = "SELECT * FROM Veiculos WHERE id='" + Pesquisa + "'"; }

            Listar_Veiculos(LST, ComandoSQL);
        }
    }
}
