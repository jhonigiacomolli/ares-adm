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
    public partial class frmApontamentoFunc : Form
    {
        bool mouseDown;
        Point lastLocation;
        int ID;
        public string ID_Funcionario;
        public string ID_Veiculo;
        public string Nome;
        public string Funcao;
        public string Entrada;
        public string Saida;
        public string Valor;
        public string Tempo;
        public string MO;
        public string TIPO;
        frmOrdemServico frmOrdemServico;

        public frmApontamentoFunc(frmOrdemServico frmOS, string ID_Veiculo)
        {
            InitializeComponent();
            this.ID_Veiculo = ID_Veiculo;
            this.TIPO = "INCLUSÃO";
            frmOrdemServico = frmOS;

            new Classe_BancoHoras().Get_Funcao(cboFuncao);
            new Classe_Tema().TEMA_frmApontamentoFunc(this);

        }

        public frmApontamentoFunc(frmOrdemServico frmOS, int ID, string ID_Veiculo)
        {
            InitializeComponent();
            frmOrdemServico = frmOS;
            this.ID_Veiculo = ID_Veiculo;
            this.ID = ID;
            TIPO = "EDIÇÃO";

            new Classe_Tema().TEMA_frmApontamentoFunc(this);
        }

        private void frmApontamentoFunc_Resize(object sender, EventArgs e)
        {
            if (this.Height < 250)
            {
                txtEntrada.Enabled = false;
                txtEntrada.Visible = false;
                txtSaida.Enabled = false;
                txtSaida.Visible = false;
                txtHoraEntrada.Enabled = false;
                txtHoraEntrada.Visible = false;
                txtHoraSaida.Enabled = false;
                txtHoraSaida.Visible = false;

                lblEntrada.Visible = false;
                lblSaida.Visible = false;
            }
        }        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Classe_Funcionario func = new Classe_Funcionario();
                func.Get_Funcionario(txtCodigo.Text);
                txtFuncionario.Text = func.Nome;
                txtValorHora.Text = func.ValorHora;

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void txtFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        private void cboFuncao_KeyDown(object sender, KeyEventArgs e)
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



        private void txtHoraEntrada_KeyDown(object sender, KeyEventArgs e)
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

        private void txtHoraSaida_KeyDown(object sender, KeyEventArgs e)
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

        private void frmApontamentoFunc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
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

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            txtCodigo.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtFuncionario_Enter(object sender, EventArgs e)
        {
            txtFuncionario.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtFuncionario_Leave(object sender, EventArgs e)
        {
            txtFuncionario.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void cboFuncao_Enter(object sender, EventArgs e)
        {
            cboFuncao.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void cboFuncao_Leave(object sender, EventArgs e)
        {
            cboFuncao.BackColor = Classe_Tema.TextBox_Normal;
        }



        private void txtHoraEntrada_Enter(object sender, EventArgs e)
        {
            txtHoraEntrada.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtHoraEntrada_Leave(object sender, EventArgs e)
        {
            txtHoraEntrada.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtHoraSaida_Enter(object sender, EventArgs e)
        {
            txtHoraSaida.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtHoraSaida_Leave(object sender, EventArgs e)
        {
            txtHoraSaida.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtEntrada_Enter(object sender, EventArgs e)
        {
            txtEntrada.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtEntrada_Leave(object sender, EventArgs e)
        {
            txtEntrada.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtSaida_Enter(object sender, EventArgs e)
        {
            txtSaida.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtSaida_Leave(object sender, EventArgs e)
        {
            txtSaida.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmProdutos Funcionarios = new frmProdutos(this, "SELECT * FROM Funcionarios ORDER BY Nome ASC");

            cboFuncao.Select();

            Funcionarios.Show();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string IDFuncionario = txtCodigo.Text;
            string Nome = txtFuncionario.Text;
            string Funcao = cboFuncao.Text;
            string Entrada = string.Concat(txtEntrada.Text, " ", txtHoraEntrada.Text);
            string Saida = string.Concat(txtSaida.Text, " ", txtHoraSaida.Text);
            string Valor = txtValorHora.Text;

            if (TIPO.Equals("INCLUSÃO"))
            {
                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
                {
                    if (IDFuncionario != string.Empty && Nome != string.Empty && Funcao != string.Empty && txtEntrada.Text != string.Empty && txtHoraEntrada.Text != string.Empty)
                    {
                        if (new Classe_BancoHoras().VerificaApontamento(this, IDFuncionario).Equals(false))
                        {
                            new Classe_BancoHoras().Apontar_Funcionario(ID_Veiculo, IDFuncionario, Nome, Funcao, Entrada, Saida, Convert.ToDouble(Valor));
                            frmOrdemServico.AtualizaDadosFuncionario();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os dados!");
                        messagebox.ShowDialog();

                        txtCodigo.Select();
                    }
                }
                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
                {
                    if (IDFuncionario != string.Empty && Nome != string.Empty && Funcao != string.Empty)
                    {
                        if (new Classe_BancoHoras().VerificaApontamento(this, IDFuncionario).Equals(false))
                        {
                            new Classe_BancoHoras().Apontar_Funcionario(ID_Veiculo, IDFuncionario, Nome, Funcao, DateTime.Now.ToString(), Valor);
                            frmOrdemServico.AtualizaDadosFuncionario();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os dados!");
                        messagebox.ShowDialog();

                        txtCodigo.Select();
                    }
                }
                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
                {
                    if (IDFuncionario != string.Empty && Nome != string.Empty && Funcao != string.Empty)
                    {
                        {
                            new Classe_BancoHoras().Apontar_Funcionario(ID_Veiculo, IDFuncionario, Nome, Funcao, string.Empty, string.Empty);
                            frmOrdemServico.AtualizaDadosFuncionario();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os dados!");
                        messagebox.ShowDialog();

                        txtCodigo.Select();
                    }
                }
            }

            if (TIPO.Equals("EDIÇÃO"))
            {

                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL") || Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
                {
                    if (IDFuncionario != string.Empty && Nome != string.Empty && Funcao != string.Empty && txtEntrada.Text != string.Empty && txtHoraEntrada.Text != string.Empty)
                    {
                        {
                            new Classe_BancoHoras().Editar_Apontamento(ID.ToString(), IDFuncionario, ID_Veiculo, Nome, Funcao, Entrada, Saida, Convert.ToDouble(Valor));
                            frmOrdemServico.AtualizaDadosFuncionario();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os dados!");
                        messagebox.ShowDialog();

                        txtCodigo.Select();
                    }
                }
                
                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
                {
                    if (IDFuncionario != string.Empty && Nome != string.Empty && Funcao != string.Empty)
                    {
                        {
                            new Classe_BancoHoras().Editar_Apontamento(ID.ToString(), IDFuncionario, ID_Veiculo, Nome, Funcao, string.Empty, string.Empty, 0);
                            frmOrdemServico.AtualizaDadosFuncionario();
                            this.Close();
                        }
                    }
                    else
                    {
                        Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados incompletos", "Favor preencher todos os dados!");
                        messagebox.ShowDialog();

                        txtCodigo.Select();
                    }
                }
            }
        }
    }
}


