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
        frmIncluirPeca frmincluirpeca;
        frmApontamentoFunc frmapontamento;
        public string Genero;

        public frmProdutos(string Genero)
        {
            InitializeComponent();
            this.Genero = Genero;

            new Classe_Tema().TEMA_frmProdutos(this);

            if (Genero.Equals("PRODUTO"))
            {
                lblTituloForm.Text = "SHARP INK - Produtos";
                this.Text = "SHARP INK - Produtos";
                new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
                new Classe_Produtos().Listar_Produtos(lstProdutos, "SELECT * FROM Produtos ORDER BY Descricao ASC");
            }
            if (Genero.Equals("FUNCIONARIO"))
            {
                lblTituloForm.Text = "SHARP INK - Funcionarios";
                this.Text = "SHARP INK - Funcionarios";
                new Classe_Listviews().Criar_LST_Funcionarios(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
                new Classe_Funcionario().Listar_Funcionarios(lstProdutos, "SELECT * FROM Funcionarios ORDER BY Nome ASC");
            }
            if (Genero.Equals("PEÇAS"))
            {
                lblTituloForm.Text = "SHARP INK - Peças";
                this.Text = "SHARP INK - Peças";
                new Classe_Listviews().Criar_LST_Pecas(lstProdutos);
                new Classe_Pecas().Listar_Pecas(lstProdutos, "SELECT * FROM Pecas ORDER BY Descricao ASC");
            }
        }

        public frmProdutos(frmIncluirItem FormIncluirItem, string SQL) 
        {
            InitializeComponent();
            lblTituloForm.Text = "SHARP INK - Produtos";
            frmIncluir = FormIncluirItem;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
            new Classe_Produtos().Listar_Produtos(lstProdutos, SQL);
        }
        public frmProdutos(frmApontamentoFunc frmApontamento, string SQL)
        {
            InitializeComponent();
            lblTituloForm.Text = "SHARP INK - Funcionarios";
            frmapontamento = frmApontamento;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Funcionarios(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
            new Classe_Funcionario().Listar_Funcionarios(lstProdutos, SQL);
        }
        public frmProdutos(frmIncluirPeca frmincluirpeca, string SQL)
        {
            InitializeComponent();
            lblTituloForm.Text = "SHARP INK - Funcionarios";
            this.frmincluirpeca = frmincluirpeca;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Pecas(lstProdutos);
            //new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
            new Classe_Pecas().Listar_Pecas(lstProdutos, SQL);
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
                    if (txtPesquisa.Text != string.Empty)
                    {
                        txtPesquisa.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (frmIncluir != null)
                {
                    new Classe_Produtos().Pesquisa_Produtos(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                }                
                if (frmapontamento != null)
                {
                    new Classe_Funcionario().Pesquisa_Funcionario(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                }
                if (Genero != null)
                {
                    if (Genero.Equals("PRODUTO"))
                    {
                        new Classe_Produtos().Pesquisa_Produtos(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                    }
                    if (Genero.Equals("FUNCIONARIO"))
                    {
                        new Classe_Funcionario().Pesquisa_Funcionario(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                    }
                }
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

            if (frmapontamento != null)
            {
                frmapontamento.txtCodigo.Text = lstProdutos.FocusedItem.SubItems[0].Text;
                frmapontamento.txtFuncionario.Text = lstProdutos.FocusedItem.SubItems[1].Text;
                frmapontamento.txtValorHora.Text = lstProdutos.FocusedItem.SubItems[10].Text;
                this.Close();
                if (Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
                {
                    frmapontamento.txtEntrada.Select();
                }
                else
                {
                    frmapontamento.cboFuncao.Select();
                }
            }

            if (frmincluirpeca != null)
            {
                frmincluirpeca.txtCodigo.Text = lstProdutos.FocusedItem.SubItems[0].Text;
                frmincluirpeca.txtDescricao.Text = lstProdutos.FocusedItem.SubItems[2].Text;
                frmincluirpeca.txtUnitario.Text = lstProdutos.FocusedItem.SubItems[5].Text;
                frmincluirpeca.cboAplicacaoDano.Text = lstProdutos.FocusedItem.SubItems[3].Text;
                this.Close();
            }        
        }

        private void lstProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstProdutos.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
