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

        public string TIPO;

        public frmCadastroOS(frmListaOS ListaOS)
        {
            InitializeComponent();
            FormListaOS = ListaOS;

            new Classes_Conexao().Get_Cores(txtCor);
            new Classes_Conexao().Get_Tamanho(txtTamanho);
            new Classes_Conexao().Get_Proprietario(txtProprietario);

            txtNumeroOS.Enabled = false;
            txtProprietario.Enabled = true;
            txtVeiculo.Enabled = true;
            txtPLaca.Enabled = true;
            txtCor.Enabled = true;
            txtTamanho.Enabled = true;
        }

        public frmCadastroOS(string Tipo, frmListaOS ListaOS)
        {
            InitializeComponent();
            FormListaOS = ListaOS;
            TIPO = Tipo;

            new Classes_Conexao().Get_Cores(txtCor);
            new Classes_Conexao().Get_Tamanho(txtTamanho);
            new Classes_Conexao().Get_Proprietario(txtProprietario);

            txtNumeroOS.Enabled = true;
            txtProprietario.Enabled = false;
            txtVeiculo.Enabled = false;
            txtPLaca.Enabled = false;
            txtCor.Enabled = false;
            txtTamanho.Enabled = false;
            
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string proprietario = txtProprietario.Text;
            string veiculo = txtVeiculo.Text;
            string placa = txtPLaca.Text;
            string cor = txtCor.Text;
            string tamanho = txtTamanho.Text;
            DateTime datacadastro = DateTime.Now;
            string situacao = "ABERTA";

            new Classe_OrdemServico().Incluir_OrdemServico(proprietario, veiculo, placa, cor, tamanho, datacadastro, situacao);
            new Classe_Veiculos().Listar_Veiculos( FormListaOS.lstVeiculos,"SELECT * FROM Veiculos");
            this.Close();
        }

        private void txtNumeroOS_Validated(object sender, EventArgs e)
        {
            int ID = int.Parse(txtNumeroOS.Text);

            new Classe_Veiculos().Listar_Veiculos(this,"SELECT * FROM Veiculos WHERE id='" + ID + "'");

        }
    }
}
