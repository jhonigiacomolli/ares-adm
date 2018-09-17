using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ARES_ADM.Classes
{
    class Classe_Orcamentos
    {

        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();

        public void Validar_Campos_Cabecalho(frmOrcamentos Form)
        {
            //Verifica Painel Proprietario
            if (Form.txtProprietario.Text != string.Empty && Form.txtCPF_CNPJ.Text != string.Empty && Form.txtEndereco.Text != string.Empty
                    && Form.txtNumero.Text != string.Empty && Form.txtBairro.Text != string.Empty && Form.txtCidade.Text != string.Empty
                    && Form.cboEstado.Text != string.Empty && Form.txtCEP.Text != string.Empty && Form.txtTelefone.Text != string.Empty)
            {
                Form.icStatusProprietario.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusProprietario.BackColor = Color.Red;
            }

            //Verifica Painel Veiculo
            if (Form.txtMontadora.Text != string.Empty && Form.txtVeiculo.Text != string.Empty && Form.txtMotorizacao.Text != string.Empty
                && Form.txtPlaca.Text != string.Empty && Form.txtKM.Text != string.Empty && Form.txtNChassis.Text != string.Empty
                && Form.txtCor.Text != string.Empty && Form.txtPintura.Text != string.Empty)
            {
                Form.icStatusVeiculo.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusVeiculo.BackColor = Color.Red;
            }

            //Verifica Pianel Seguro            
            if (Form.cboSeguro.Text.Equals("SIM") && Form.cboTipoSeguro.Text != string.Empty && Form.cboSeguradora.Text != string.Empty
                && Form.txtFranquia.Text != string.Empty && Form.txtNSinistro.Text != string.Empty)
            {
                Form.icStatusSeguro.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusSeguro.BackColor = Color.Red;
            }
            if (Form.cboSeguro.Text.Equals("NÃO"))
            {
                Form.icStatusSeguro.BackColor = Color.Green;
            }
        }

        public void Seleciona_PainelDadosProprietario(frmOrcamentos Form)
        {          
            Form.pnProprietario.Visible = true;
            Form.pnDadosVeiculo.Visible = false;
            Form.pnSeguro.Visible = false;

            Form.btnDadosProprietario.BackColor = Classe_Tema.Botao_Secundario;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosSeguro.BackColor = Classe_Tema.MenuBotao_Normal;

            Validar_Campos_Cabecalho(Form);

            Form.txtProprietario.Select();
        }

        public void Seleciona_PainelDadosVeiculo(frmOrcamentos Form)
        {
            Form.pnProprietario.Visible = false;
            Form.pnDadosVeiculo.Visible = true;
            Form.pnSeguro.Visible = false;

            Form.btnDadosProprietario.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.Botao_Secundario;
            Form.btnDadosSeguro.BackColor = Classe_Tema.MenuBotao_Normal;

            Validar_Campos_Cabecalho(Form);

            Form.txtMontadora.Select();
        }

        public void Seleciona_PainelDadosSeguro(frmOrcamentos Form)
        {
            Form.pnProprietario.Visible = false;
            Form.pnDadosVeiculo.Visible = false;
            Form.pnSeguro.Visible = true;

            Form.btnDadosProprietario.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosSeguro.BackColor = Classe_Tema.Botao_Secundario;

            Validar_Campos_Cabecalho(Form);

            Form.cboSeguro.Select();
        }


        public void Valida_Seguro(frmOrcamentos Form)
        {
            if (Form.cboSeguro.Text.Equals("SIM"))
            {
                Form.cboTipoSeguro.Enabled = true;
                Form.cboSeguradora.Enabled = true;
                Form.txtFranquia.Enabled = true;
                Form.txtNSinistro.Enabled = true;
            }
            if (Form.cboSeguro.Text.Equals("NÃO"))
            {
                Form.cboTipoSeguro.Enabled = false;
                Form.cboSeguradora.Enabled = false;
                Form.txtFranquia.Enabled = false;
                Form.txtNSinistro.Enabled = false;

                Form.cboTipoSeguro.SelectedIndex = -1;
                Form.cboSeguradora.SelectedIndex = -1;
                Form.txtFranquia.Clear();
                Form.txtNSinistro.Clear();
            }
        }

        public void Validar_TipoCadastro(frmOrcamentos Form)
        {
            if (Form.cboTipoCadastro.Text.Equals("PESSOA FISICA"))
            {
                Form.lblTituloProprietario.Text = "Proprietário";
                Form.lblTituloCPF_CNPJ.Text = "CPF";
                Form.txtCPF_CNPJ.Mask = "000.000.000-00";
            }

            if (Form.cboTipoCadastro.Text.Equals("PESSOA JURÍDICA"))
            {
                Form.lblTituloProprietario.Text = "Razão Social";
                Form.lblTituloCPF_CNPJ.Text = "CNPJ";
                Form.txtCPF_CNPJ.Mask= "00.000.000/0000-00";
            }
        }

        public void Validar_TipoTelefone(frmOrcamentos Form)
        {
            if (Form.cboTipoTelefone.Text.Equals("Celular Particular"))
            {
                Form.txtTelefone.Mask = "(00) 0 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Celular Comercial"))
            {
                Form.txtTelefone.Mask = "(00) 0 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Comercial"))
            {
                Form.txtTelefone.Mask = "(00) 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Residencial"))
            {
                Form.txtTelefone.Mask = "(00) 0000 0000";
            }
        }

        public void Carregar_UF(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT UF FROM UF ORDER BY UF ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["UF"].ToString().ToUpper().TrimEnd());
                }              
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Montadoras(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Montadora FROM Montadoras ORDER BY Montadora ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Montadora"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Cor(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Cor FROM Cores ORDER BY Cor ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Cor"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_TipoPintura(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT TipoPintura FROM Tipo_Pintura ORDER BY TipoPintura ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["TipoPintura"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_TipoSeguro(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Tipo FROM Seguro_Tipos ORDER BY Tipo ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Tipo"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Seguradoras(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Seguradora FROM Seguro_Seguradoras ORDER BY Seguradora ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Seguradora"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

    }
}
