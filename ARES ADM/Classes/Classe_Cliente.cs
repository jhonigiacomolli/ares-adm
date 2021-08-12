using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_Cliente
    {
        public void Listar_Clientes(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["TipoCadastro"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Nome"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Fantasia"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CPF_CNPJ"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["DataNascimento"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Endereco"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Numero"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Bairro"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Cidade"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CEP"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Estado"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Telefone"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Email"].ToString().TrimEnd().ToUpper());

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



        public void Info_CLientes(frmProdutos Form, ListViewItem Item)
        {
            if (Item.SubItems[1].Text.Equals("PESSOA FISICA")) { Form.lblTituloCPFCNPJ.Text = "CPF"; Form.lblTituloNascimento.Text = "Data Nascimento"; }
            if (Item.SubItems[1].Text.Equals("PESSOA JURÍDICA")) { Form.lblTituloCPFCNPJ.Text = "CNPJ"; Form.lblTituloNascimento.Text = "Data Abertura"; }

            Form.lblCPF_CNPJ.Text = Item.SubItems[4].Text;
            Form.lblDataNascimento.Text = Item.SubItems[5].Text;
            Form.lblEndereco.Text = string.Concat(Item.SubItems[6].Text, ", ", Item.SubItems[7].Text);
            Form.lblBairro.Text = Item.SubItems[8].Text;
            Form.lblCidade.Text = string.Concat(Item.SubItems[9].Text, " / ", Item.SubItems[11].Text);
            Form.lblCEP.Text = Item.SubItems[10].Text;
            Form.lblTelefone.Text = Item.SubItems[12].Text;
            Form.lblEmail.Text = Item.SubItems[13].Text.ToLower();

            Item = null;
        }
        public void Limpar_Info_Clientes(frmProdutos Form)
        {
            Form.lblCPF_CNPJ.Text = string.Empty;
            Form.lblDataNascimento.Text = string.Empty;
            Form.lblEndereco.Text = string.Empty;
            Form.lblBairro.Text = string.Empty;
            Form.lblCidade.Text = string.Empty;
            Form.lblCEP.Text = string.Empty;
            Form.lblTelefone.Text = string.Empty;
            Form.lblEmail.Text = string.Empty;
        }
    }
}
