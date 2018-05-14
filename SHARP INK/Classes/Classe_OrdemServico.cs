using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlServerCe;
using System.Data;
using SHARP_INK.Classes;
using System.Windows.Forms;


namespace SHARP_INK.Classes
{
    class Classe_OrdemServico
    {
        public void Cabecalho_OrdemServico(frmOrdemServico Form, string nos, string proprietario, string veiculo, string placa, string cor, string tamanho)
        {
            Form.txtNos.Text = nos;
            Form.txtProprietario.Text = proprietario;
            Form.txtVeiculo.Text = veiculo;
            Form.txtPlaca.Text = placa;
            Form.txtCor.Text = cor;
            Form.txtTamanho.Text = tamanho;

            Form.lblRazaoSocial.Text = Classe_Empresa.RazaoSocial;
            Form.lblCNPJ.Text = Classe_Empresa.CNPJ;
            Form.lblEndereço.Text = Classe_Empresa.Endereco;
            Form.lblEmail.Text = Classe_Empresa.Email;
            Form.lblTelefone.Text = Classe_Empresa.Telefone;

            Form.lblTituloForm.Text = "SHARP INK | OS Nº " + nos;
        }

        public void Preenche_FormEdicao(int ID,int IDVeiculo, string Descricao, double quantidade, double ValorUnitario, double ValorTotal)
        {
            frmIncluirItem Form = new frmIncluirItem(null,null,IDVeiculo);

            Form.txtCodigo.Text = ID.ToString();
            Form.txtDescricao.Text = Descricao;
            Form.txtQuantidade.Text = quantidade.ToString();
            Form.txtValorUnitario.Text = ValorUnitario.ToString();
            Form.txtValorTotal.Text = ValorTotal.ToString();

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtDescricao.BackColor= Classe_Tema.TextBox_Edicao;
            Form.txtQuantidade.BackColor= Classe_Tema.TextBox_Edicao;
            Form.txtValorUnitario.BackColor= Classe_Tema.TextBox_Edicao;
            Form.txtValorTotal.BackColor= Classe_Tema.TextBox_Edicao;

            Form.ShowDialog();
        }

        public void Excluir_Item(int ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM OrdemServico_Itens WHERE id=" + ID + "";
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

        public void Listar_ItensOS(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["ID_Veiculo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Categoria"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CodigoProduto"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Descricao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Quantidade"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["ValorUnitario"].ToString().TrimEnd());
                        Item.SubItems.Add(DR["ValorTotal"].ToString().TrimEnd());

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

        public void Incluir_Item(frmIncluirItem Form,string TIPO, int IDVeiculo,string Categoria, string Codigo, string Descricao, double QNT, double ValorUnitario, double ValorTotal)
        {
            if (TIPO.Equals("Tinta")) { Categoria = "TINTA"; }

            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_Itens(ID_Veiculo,Categoria,CodigoProduto,Descricao,Quantidade,ValorUnitario,ValorTotal)" +
                            " VALUES ('" + IDVeiculo + "','" + Categoria + "','" + Codigo + "','" + Descricao + "','" + QNT + "','" + ValorUnitario + "','" + ValorTotal + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form Messagebox2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Inclusão", "o Item foi incluido com sucesso!");
                Messagebox2.ShowDialog();

            Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
    }
}
