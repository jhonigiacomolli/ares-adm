using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ARES_ADM.Classes;

namespace ARES_ADM
{
    public partial class frmOrcamentos : Form
    {
        bool mouseDown;
        Point lastLocation;

        public frmListaOS FORM;
        public string ID_CLiente;
        public string ID_Orcamentista;
        public string Tipo;


        public frmOrcamentos(frmListaOS Form, string ID, string TIPO)
        {
            InitializeComponent();

            FORM = Form;
            Tipo = TIPO;

            new Classe_Tema().TEMA_frmOrcamentos(this);
            new Classe_Orcamentos().Carregar_UF(cboEstado);
            new Classe_Orcamentos().Carregar_Montadoras(txtMontadora);
            new Classe_Orcamentos().Carregar_Cor(txtCor);
            new Classe_Orcamentos().Carregar_TipoPintura(txtPintura);
            new Classe_Orcamentos().Carregar_TipoSeguro(cboTipoSeguro);
            new Classe_Orcamentos().Carregar_Seguradoras(cboSeguradora);

            if (Tipo.Equals(Classe_Orcamentos.Formulario_Visualizacao))
            {
                new Classe_Listviews().Criar_LST_ItensOrcamento(lstItensOrcamento);
                new Classe_Orcamentos().Listar_ItensOrcamento(lstItensOrcamento, ID);
            }

            if (Tipo.Equals(Classe_Orcamentos.Formulario_Novo))
            {
                lstItensOrcamento.Enabled = false;
            }

            if (Tipo.Equals(Classe_Orcamentos.Formulario_Edicao))
            {
                new Classe_Orcamentos().Colorir_Cabecalho(this);
                txtAbertura.Enabled = false;
                txtNOrcamento.Enabled = false;

                txtProprietario.Focus();
            }
        }

        private void pnCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void pnCabecalho_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lblTituloForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void lblTituloForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void lblTituloForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnDadosProprietario_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosProprietario(this);
        }

        public void btnDadosVeiculo_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosVeiculo(this);
        }

        public void btnDadosSeguro_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosSeguro(this);
        }

        private void cboSeguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoSeguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtFranquia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNSinistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosProprietario(this);
            }
        }

        private void cboSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Valida_Seguro(this);
            new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
        }



        private void txtMotorizacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNChassis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtVeiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtProprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }



        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCPF_CNPJ_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Validar_TipoCadastro(this);
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosVeiculo(this);
            }
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Validar_TipoTelefone(this);
        }

        private void cboTipoTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtMontadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtPintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosSeguro(this);
            }
        }

        private void cboSeguradora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAbertura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cboTipoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtOrcamentista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtFranquia_Validated(object sender, EventArgs e)
        {
            if (txtFranquia.Text != "")
            {
                txtFranquia.Text = Convert.ToDouble(txtFranquia.Text).ToString("N2");
            }
        }

        private void txtFranquia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnOrcamentista_Click(object sender, EventArgs e)
        {
            frmProdutos Funcionarios = new frmProdutos(this, "FUNCIONÁRIO", "SELECT * FROM Funcionarios ORDER BY Nome ASC");
            txtProprietario.Focus();
            Funcionarios.Show();
        }

        private void btnProprietario_Click(object sender, EventArgs e)
        {
            string SQL = "";

            if (cboTipoCadastro.Text.Equals("PESSOA FISICA"))
            {
                SQL = "SELECT * FROM Clientes WHERE TipoCadastro='PESSOA FISICA' ORDER BY Nome ASC";
            }
            if (cboTipoCadastro.Text.Equals("PESSOA JURÍDICA"))
            {
                SQL = "SELECT * FROM Clientes WHERE TipoCadastro='PESSOA JURÍDICA' ORDER BY Nome ASC";
            }
            if (cboTipoCadastro.Text.Equals(string.Empty))
            {
                SQL = "SELECT * FROM Clientes ORDER BY Nome ASC";
            }

            frmProdutos Cliente = new frmProdutos(this, "CLIENTE", SQL);
            Cliente.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Tipo.Equals(Classe_Orcamentos.Formulario_Novo) || Tipo.Equals(Classe_Orcamentos.Formulario_Visualizacao))
            {
                Close();
            }
            if (Tipo.Equals(Classe_Orcamentos.Formulario_Edicao))
            {
                new Classe_Listviews().Criar_LST_ItensOrcamento(lstItensOrcamento);
                new Classe_Orcamentos().Descolorir_Cabecalho(this);
                new Classe_Orcamentos().Listar_ItensOrcamento(lstItensOrcamento, txtNOrcamento.Text);
                new Classe_Orcamentos().Bloquear_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosProprietario(this);
                Tipo = Classe_Orcamentos.Formulario_Visualizacao;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cboTipoCadastro.Text.Equals(string.Empty) || txtOrcamentista.Text.Equals(string.Empty) || txtProprietario.Text.Equals(string.Empty)
                || txtCPF_CNPJ.Text.Equals(string.Empty) || txtCPF_CNPJ.Text.Equals("  ,   ,   /    -") || txtCPF_CNPJ.Text.Equals("   ,   ,   -")
                || txtVeiculo.Text.Equals(string.Empty) || txtPlaca.Text.Equals(string.Empty) || txtPlaca.Text.Equals("   -"))
            {
                string msg = "Favor Preencher os Campos: ";
                int i = 0;

                if (cboTipoCadastro.Text.Equals(string.Empty))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", Tipo de Cadastro");
                    }
                    else
                    {
                        msg = string.Concat(msg, " Tipo de Cadastro");
                        i++;
                    }
                }
                if (txtOrcamentista.Text.Equals(string.Empty))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", Orçamentista");
                    }
                    else
                    {
                        msg = string.Concat(msg, " Orçamentista");
                        i++;
                    }
                }
                if (txtProprietario.Text.Equals(string.Empty))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", Proprietário");
                    }
                    else
                    {
                        msg = string.Concat(msg, " Proprietário");
                        i++;
                    }
                }
                if (txtCPF_CNPJ.Text.Equals(string.Empty) || txtCPF_CNPJ.Text.Equals("  ,   ,   /    -") || txtCPF_CNPJ.Text.Equals("   ,   ,   -"))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", CPF ou CNPJ");
                    }
                    else
                    {
                        msg = string.Concat(msg, " CPF ou CNPJ");
                        i++;
                    }
                }
                if (txtVeiculo.Text.Equals(string.Empty))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", Veículo");
                    }
                    else
                    {
                        msg = string.Concat(msg, " Veículo");
                        i++;
                    }
                }
                if (txtPlaca.Text.Equals(string.Empty) || txtPlaca.Text.Equals("   -"))
                {
                    if (i > 0)
                    {
                        msg = string.Concat(msg, ", Placa");
                    }
                    else
                    {
                        msg = string.Concat(msg, " Placa");
                        i++;
                    }
                }

                Form messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Campo em branco", msg);
                messagebox.ShowDialog();
            }
            else
            {
                if (Tipo.Equals(Classe_Orcamentos.Formulario_Novo))
                {
                    new Classe_Orcamentos().Incluir_Orcamento(this, FORM, cboTipoCadastro.Text, ID_Orcamentista, txtOrcamentista.Text, ID_CLiente, txtProprietario.Text
                                                              , txtCPF_CNPJ.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cboEstado.Text
                                                              , txtCEP.Text, cboTipoTelefone.Text, txtTelefone.Text, txtMontadora.Text, txtVeiculo.Text, txtPlaca.Text
                                                              , txtMotorizacao.Text, txtKM.Text, txtNChassis.Text, txtCor.Text, txtPintura.Text, cboSeguro.Text
                                                              , cboTipoSeguro.Text, cboSeguradora.Text, txtFranquia.Text, txtNSinistro.Text);

                    new Classe_Listviews().Criar_LST_ItensOrcamento(lstItensOrcamento);
                }
            }
            if (Tipo.Equals(Classe_Orcamentos.Formulario_Edicao))
            {
                new Classe_Orcamentos().Atualizar_Orcamento(this, FORM,txtNOrcamento.Text, cboTipoCadastro.Text, ID_Orcamentista, txtOrcamentista.Text, ID_CLiente, txtProprietario.Text
                                          , txtCPF_CNPJ.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cboEstado.Text
                                          , txtCEP.Text, cboTipoTelefone.Text, txtTelefone.Text, txtMontadora.Text, txtVeiculo.Text, txtPlaca.Text
                                          , txtMotorizacao.Text, txtKM.Text, txtNChassis.Text, txtCor.Text, txtPintura.Text, cboSeguro.Text
                                          , cboTipoSeguro.Text, cboSeguradora.Text, txtFranquia.Text, txtNSinistro.Text);

                new Classe_Listviews().Criar_LST_ItensOrcamento(lstItensOrcamento);
                new Classe_Orcamentos().Descolorir_Cabecalho(this);
                new Classe_Orcamentos().Listar_ItensOrcamento(lstItensOrcamento, txtNOrcamento.Text);
                Tipo = Classe_Orcamentos.Formulario_Visualizacao;

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmIncluirItemOrcamento Item = new frmIncluirItemOrcamento(this,txtNOrcamento.Text);
            Item.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string ID = lstItensOrcamento.FocusedItem.Text;
            DialogResult Resposta;

            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão Item", "Deseja excluir o item selecionado?");
            Resposta = messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                new Classe_Orcamentos().Excluir_ItemOrcamento(ID);
                new Classe_Orcamentos().Listar_ItensOrcamento(lstItensOrcamento, txtNOrcamento.Text);
            }
            else
            {
                return;
            }
        }
    }
}
