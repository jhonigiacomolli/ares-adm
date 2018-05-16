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
    public partial class frmProdutos : Form
    {
        bool mouseDown;
        Point lastLocation;
        frmIncluirItem frmIncluir;

        public frmProdutos()
        {
            InitializeComponent();
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
            new Classe_Produtos().Listar_Produtos(lstProdutos, "SELECT * FROM Produtos ORDER BY Descricao ASC");
        }

        public frmProdutos(frmIncluirItem FormIncluirItem, string SQL) 
        {
            InitializeComponent();
            frmIncluir = FormIncluirItem;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
            new Classe_Produtos().Listar_Produtos(lstProdutos, SQL);
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Normal;
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

        private void frmProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnExcluir_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnEditar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnIncluir_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void cboCampo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void lstProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    txtPesquisa.Clear();
                    break;
            }

            if (e.KeyCode == Keys.Enter)
            {
                new Classe_Produtos().Pesquisa_Produtos(lstProdutos, cboCampo.Text, txtPesquisa.Text);
            }
        }

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (frmIncluir!=null)
            {
                frmIncluir.txtCodigo.Text = lstProdutos.FocusedItem.SubItems[0].Text;
                frmIncluir.txtDescricao.Text = lstProdutos.FocusedItem.SubItems[4].Text;
                frmIncluir.txtValorUnitario.Text = lstProdutos.FocusedItem.SubItems[7].Text;
                frmIncluir.txtCategoria.Text = lstProdutos.FocusedItem.SubItems[3].Text;
                this.Close();
                frmIncluir.txtQuantidade.Select();
            }           
        }
    }
}
