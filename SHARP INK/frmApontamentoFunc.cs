using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK
{
    public partial class frmApontamentoFunc : Form
    {
        bool mouseDown;
        Point lastLocation;
        public frmApontamentoFunc()
        {
            InitializeComponent();
            new Classes_Conexao().Get_Funcao(cboFuncao);
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtFuncionario.BackColor= Classe_Tema.TextBox_Edicao;
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
            frmProdutos Funcionarios = new frmProdutos(this,"SELECT * FROM Funcionarios ORDER BY Nome ASC");
            if(Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
            {
                txtEntrada.Select();
            }
            else
            {
                cboFuncao.Select();
            }
            
            Funcionarios.Show();
        }
    }
}
