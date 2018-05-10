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
                    Form.txtProprietario.Text = DR["Proprietario"].ToString();
                    Form.txtVeiculo.Text= DR["Veiculo"].ToString();
                    Form.txtPLaca.Text= DR["Placa"].ToString();
                    Form.txtCor.Text= DR["Cor"].ToString();
                    Form.txtTamanho.Text= DR["Tamanho"].ToString();
                }
            }
            DT.Dispose();
        }
        public void Adicionar_Veiculos()
        {

        }
        public void Editar_Veiculos()
        {

        }
        public void Excluir_Veiculos()
        {

        }
    }
}
