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
    public partial class frmCadastroOS : Form
    {
        bool mouseDown;
        Point lastLocation;
        frmListaOS FormListaOS = new frmListaOS();
        public int ID;

        public string TIPO;

        public frmCadastroOS(int ID, frmListaOS ListaOS)
        {
            InitializeComponent();

            new Classe_Tema().TEMA_frmCadastroOS(this);

            FormListaOS = ListaOS;
            this.ID = ID;

            new Classes_Conexao().Get_Cores(txtCor);
            new Classes_Conexao().Get_Tamanho(txtTamanho);
            new Classes_Conexao().Get_Proprietario(txtProprietario);

            if (ID.Equals(0))
            {
                btnGravar.Text = "CADASTRAR";
            }
            else
            {
                btnGravar.Text = "ATUALIZAR";
                txtNumeroOS.BackColor = Classe_Tema.TextBox_Edicao;
                txtProprietario.BackColor = Classe_Tema.TextBox_Edicao;
                txtVeiculo.BackColor = Classe_Tema.TextBox_Edicao;
                txtPLaca.BackColor = Classe_Tema.TextBox_Edicao;
                txtCor.BackColor = Classe_Tema.TextBox_Edicao;
                txtTamanho.BackColor = Classe_Tema.TextBox_Edicao;
            }

            txtNumeroOS.Enabled = false;
            txtProprietario.Enabled = true;
            txtVeiculo.Enabled = true;
            txtPLaca.Enabled = true;
            txtCor.Enabled = true;
            txtTamanho.Enabled = true;
        }               

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string proprietario = txtProprietario.Text.TrimEnd();
            string veiculo = txtVeiculo.Text.TrimEnd();
            string placa = txtPLaca.Text.TrimEnd();
            string cor = txtCor.Text.TrimEnd();
            string tamanho = txtTamanho.Text.TrimEnd();
            DateTime datacadastro = DateTime.Now;
            string situacao;

            if (ID != 0)
            {                
                new Classe_Veiculos().Editar_Veiculos(ID, proprietario, veiculo, placa, cor, tamanho);
                new Classe_Veiculos().Listar_Veiculos(FormListaOS.lstVeiculos,"SELECT * FROM Veiculos ORDER BY Situacao ASC");
                new Classe_Listviews().ColorirLinhas_veiculos(FormListaOS.lstVeiculos);
                this.Close();
            }
            else
            {
                situacao = "AGUARDANDO";
                new Classe_Veiculos().Adicionar_Veiculo(proprietario, veiculo, placa, cor, tamanho, datacadastro, situacao);
                new Classe_Veiculos().Listar_Veiculos(FormListaOS.lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                new Classe_Listviews().ColorirLinhas_veiculos(FormListaOS.lstVeiculos);
                this.Close();
            }
            
        }

        private void txtNumeroOS_Validated(object sender, EventArgs e)
        {
            int ID = int.Parse(txtNumeroOS.Text);

            new Classe_Veiculos().Listar_Veiculos(this,"SELECT * FROM Veiculos WHERE id='" + ID + "'");

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

        private void txtNumeroOS_KeyDown(object sender, KeyEventArgs e)
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

        private void txtProprietario_KeyDown(object sender, KeyEventArgs e)
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

        private void txtVeiculo_KeyDown(object sender, KeyEventArgs e)
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

        private void txtPLaca_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCor_KeyDown(object sender, KeyEventArgs e)
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

        private void txtTamanho_KeyDown(object sender, KeyEventArgs e)
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

        private void btnGravar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void frmCadastroOS_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void txtNumeroOS_Enter(object sender, EventArgs e)
        {
            txtNumeroOS.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtNumeroOS_Leave(object sender, EventArgs e)
        {
            txtNumeroOS.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtProprietario_Enter(object sender, EventArgs e)
        {
            txtProprietario.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtProprietario_Leave(object sender, EventArgs e)
        {
            txtProprietario.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtVeiculo_Enter(object sender, EventArgs e)
        {
            txtVeiculo.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            txtVeiculo.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtPLaca_Enter(object sender, EventArgs e)
        {
            txtPLaca.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtPLaca_Leave(object sender, EventArgs e)
        {
            txtPLaca.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtCor_Enter(object sender, EventArgs e)
        {
            txtCor.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            txtCor.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtTamanho_Enter(object sender, EventArgs e)
        {
            txtTamanho.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtTamanho_Leave(object sender, EventArgs e)
        {
            txtTamanho.BackColor = Classe_Tema.TextBox_Normal;
        }
    }
}
