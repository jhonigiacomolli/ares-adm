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
    public partial class frmIncluirPeca : Form
    {
        bool mouseDown;
        Point lastLocation;
        frmOrdemServico frmOS;
        string Tipo = null;
        string ID_Veiculo;
        string IDEdicao;

        public frmIncluirPeca(frmOrdemServico frmOS, string ID_Veiculo, string IDEdicao)
        {
            InitializeComponent();
            this.frmOS = frmOS;
            this.ID_Veiculo = ID_Veiculo;
            this.IDEdicao = IDEdicao;
            this.Text = "ARES ADM - Peça principal";
            lblTituloForm.Text = "ARES ADM - Peça principal";
            lblTituloAplicacaoDano.Text = "Dano";
            lblTituloCustoTipo.Text = "Tipo de peça";
            lblTituloQNT.Visible = false;
            lblTituloUnitario.Visible = false;
            txtQuantidade.Visible = false;
            txtUnitario.Visible = false;
            txtCusto.Visible = false;
            new Classe_Pecas().Get_DanoPeca(cboAplicacaoDano);
            new Classe_Pecas().Get_TipoPeca(cboTipoPeca);
        }
        public frmIncluirPeca(frmOrdemServico frmOS, string ID_Veiculo, string TIPO, string IDEdicao)
        {
            InitializeComponent();
            this.frmOS = frmOS;
            this.Tipo = TIPO;
            this.ID_Veiculo = ID_Veiculo;
            this.IDEdicao = IDEdicao;
            this.Text = "ARES ADM - Peça complementar";
            lblTituloForm.Text = "ARES ADM - Peça complementar";
            lblTituloAplicacaoDano.Text = "Aplicação";
            lblPercent.Visible = false;
            lblTituloCustoTipo.Text = "Valor";
            cboTipoPeca.Visible = false;
            new Classe_Pecas().Get_PecaAplicacao(cboAplicacaoDano);
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
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (Tipo == null)
            {                
                frmProdutos pecas = new frmProdutos(Classe_Pecas.Pecas_Principais,this);                
                pecas.ShowDialog();
                cboAplicacaoDano.Select();
            }
            else
            {
                
                frmProdutos pecas = new frmProdutos(Classe_Pecas.Pecas_Complementares, this);
                pecas.ShowDialog();
                txtQuantidade.Select();
            }
            
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (Tipo!=null)
                {
                    Classe_Pecas Peca = new Classe_Pecas();
                    Peca.Listar_PecasComplementares_ID(txtCodigo.Text);
                    txtDescricao.Text = Peca.Descricao;
                    cboAplicacaoDano.Text = Peca.Aplicacao;
                    txtUnitario.Text = Peca.Venda.ToString("N2");
                }
                if (Tipo==null)
                {
                    Classe_Pecas Peca = new Classe_Pecas();
                    Peca.Listar_PecasPrincipais_ID(txtCodigo.Text);
                    txtDescricao.Text = Peca.Descricao;
                }

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cboAplicacaoDano_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cboTipoPeca_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtCodigo.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtDescricao.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void cboAplicacaoDano_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                cboAplicacaoDano.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void cboAplicacaoDano_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                cboAplicacaoDano.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtQuantidade.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtQuantidade.BackColor = Classe_Tema.TextBox_Normal;
            }
        }
        private void txtUnitario_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtUnitario.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtUnitario_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtUnitario.BackColor = Classe_Tema.TextBox_Normal;
            }
        }
        private void txtCusto_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtCusto.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                txtCusto.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void cboTipoPeca_Enter(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                cboTipoPeca.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void cboTipoPeca_Leave(object sender, EventArgs e)
        {
            if (IDEdicao.Equals(string.Empty))
            {
                cboTipoPeca.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void btnGravar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Qundo é Cadastro
            if (IDEdicao.Equals(string.Empty))
            {
                //Quando é Peça Principal
                if (Tipo == null)
                {
                    if (txtDescricao.Text != string.Empty && cboAplicacaoDano.Text != string.Empty && txtCodigo.Text != string.Empty && cboTipoPeca.Text != string.Empty)
                    {
                        new Classe_Pecas().Incluir_PecaPrincipal(this, ID_Veiculo, txtDescricao.Text, cboAplicacaoDano.Text, txtCodigo.Text, cboTipoPeca.Text);
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os campos!");
                        messagebox.Show();
                        txtCodigo.Select();
                    }
                }
                //Quando é Peça Complementar
                else
                {
                    if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && cboAplicacaoDano.Text != string.Empty && txtUnitario.Text != string.Empty && txtQuantidade.Text != string.Empty && txtCusto.Text != string.Empty)
                    {
                        new Classe_Pecas().Incluir_PecaComplementar(this, ID_Veiculo, txtCodigo.Text, txtDescricao.Text, cboAplicacaoDano.Text, double.Parse(txtUnitario.Text), double.Parse(txtQuantidade.Text), double.Parse(txtCusto.Text));
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os campos!");
                        messagebox.Show();
                        txtCodigo.Select();
                    }
                }
            }
            //Quando é edição
            else
            {
                //Quando é Edição de Peça Principal
                if (Tipo == null)
                {
                    if (txtDescricao.Text != string.Empty && cboAplicacaoDano.Text != string.Empty && txtCodigo.Text != string.Empty && cboTipoPeca.Text != string.Empty)
                    {
                        new Classe_Pecas().Atualizar_PecaPrincipal(this, IDEdicao, ID_Veiculo, txtDescricao.Text, cboAplicacaoDano.Text, txtCodigo.Text, cboTipoPeca.Text);
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os campos!");
                        messagebox.Show();
                        txtCodigo.Select();
                    }
                }
                //Quando é Edição de Peça Complementar
                else
                {
                    if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && cboAplicacaoDano.Text != string.Empty && txtUnitario.Text != string.Empty && txtQuantidade.Text != string.Empty && txtCusto.Text != string.Empty)
                    {
                        new Classe_Pecas().Atulizar_PecaComplementar(this, IDEdicao, ID_Veiculo, txtCodigo.Text, txtDescricao.Text, cboAplicacaoDano.Text,double.Parse(txtUnitario.Text),double.Parse(txtQuantidade.Text),double.Parse(txtCusto.Text));
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os campos!");
                        messagebox.Show();
                        txtCodigo.Select();
                    }
                }
            }
            frmOS.AtualizaDadosPecas();
        }

        private void txtQuantidade_Validated(object sender, EventArgs e)
        {
            if(txtQuantidade.Text!=string.Empty && txtUnitario.Text != string.Empty)
            {
                double unit =Convert.ToDouble(txtUnitario.Text);
                double QNT = Convert.ToDouble(txtQuantidade.Text);
                double soma = unit * QNT;

                txtQuantidade.Text = Convert.ToDouble(txtQuantidade.Text).ToString("N2");
                txtCusto.Text = soma.ToString("N2");
            }
        }
    }
}
