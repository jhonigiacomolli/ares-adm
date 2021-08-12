using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using ARES_ADM.Classes;

namespace ARES_ADM
{

    public partial class frmCadastroProdutos : Form
    {
        bool mouseDown;
        Point lastLocation;
        frmProdutos Produtos;
        public int ID;

        public frmCadastroProdutos(frmProdutos PRODUTOS)
        {
            InitializeComponent();
            Produtos = PRODUTOS;

            new Classe_Tema().TEMA_frmCadastroProdutos(this);
            new Classe_Produtos().Get_GruposProdutos(cboGrupo);
            new Classe_Produtos().Get_Fornecedores(cboFornecedor);
        }

        public frmCadastroProdutos(frmProdutos PRODUTOS, int ID, string Grupo, string CodFabrica, string Fornecedor, string Descricao, double Custo, double Margem, double  Venda)
        {
            InitializeComponent();
            Produtos = PRODUTOS;
            this.ID = ID;
            new Classe_Tema().TEMA_frmCadastroProdutos(this);
            new Classe_Produtos().Get_GruposProdutos(cboGrupo);
            new Classe_Produtos().Get_Fornecedores(cboFornecedor);

            cboGrupo.BackColor = Classe_Tema.TextBox_Edicao;
            txtCodFabrica.BackColor = Classe_Tema.TextBox_Edicao;
            cboFornecedor.BackColor = Classe_Tema.TextBox_Edicao;
            txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            txtCusto.BackColor = Classe_Tema.TextBox_Edicao;
            txtMargem.BackColor = Classe_Tema.TextBox_Edicao;
            txtVenda.BackColor = Classe_Tema.TextBox_Edicao;

            cboGrupo.Text = Grupo;
            txtCodFabrica.Text = CodFabrica;
            cboFornecedor.Text = Fornecedor;
            txtDescricao.Text = Descricao;
            txtCusto.Text = Custo.ToString("N2");
            txtMargem.Text = Margem.ToString("N1");
            txtVenda.Text = Venda.ToString("N2");
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void cboGrupo_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCodFabrica_KeyDown(object sender, KeyEventArgs e)
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

        private void cboFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void txtMargem_KeyDown(object sender, KeyEventArgs e)
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

        private void txtVenda_KeyDown(object sender, KeyEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboFornecedor.Text = string.Empty;
            cboGrupo.Text = string.Empty;
            txtCodFabrica.Clear();
            txtDescricao.Clear();
            txtCusto.Clear();
            txtMargem.Clear();
            txtVenda.Clear();

            Close();
        }

        private void txtMargem_Validated(object sender, EventArgs e)
        {
            if (txtMargem.Text!=string.Empty)
            {
                double Custo = Convert.ToDouble(txtCusto.Text);
                double Margem = (Convert.ToDouble(txtMargem.Text) / 100) + 1;

                double Venda = Custo * Margem;
                txtMargem.Text = Convert.ToDouble(txtMargem.Text).ToString("N1");
                txtVenda.Text = Venda.ToString("N2");
            }            
        }

        private void txtVenda_Validated(object sender, EventArgs e)
        {
            double Custo = Convert.ToDouble(txtCusto.Text);
            double Venda = Convert.ToDouble(txtVenda.Text);

            double Margem = ((Venda / Custo) - 1) * 100;
            txtMargem.Text = Margem.ToString("N1");
            txtVenda.Text = Venda.ToString("N2");
        }

        private void txtCusto_Validated(object sender, EventArgs e)
        {
            if(txtVenda.Text!=string.Empty && txtMargem.Text != string.Empty)
            {
                double Custo = Convert.ToDouble(txtCusto.Text);
                double Margem = (Convert.ToDouble(txtMargem.Text) / 100) + 1;

                double Venda = Custo * Margem;
                txtVenda.Text = Venda.ToString("N2");
            }

            txtCusto.Text = Convert.ToDouble(txtCusto.Text).ToString("N2");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string grupo = cboGrupo.Text;
            string codFabrica = txtCodFabrica.Text;
            string fornecedor = cboFornecedor.Text;
            string descricao = txtDescricao.Text;
            string custo = txtCusto.Text;
            string venda = txtVenda.Text;

            if (grupo != string.Empty && codFabrica != string.Empty && fornecedor != string.Empty && descricao != string.Empty && custo != string.Empty && venda != string.Empty)
            {
                if (ID != 0)
                {
                    try
                    {
                        new Classe_Produtos().Editar_Produto(ID, grupo, codFabrica, fornecedor, descricao, custo, venda);
                    }
                    catch(Exception)
                    {
                        Form message = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu um erro durante o processo, tente novamente ou entre em contato com o Administrador");
                        message.ShowDialog();
                    }
                    finally
                    {
                        Form message2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Alteração", "Produto alterado com sucesso!");
                        message2.ShowDialog();

                        string SQL = "SELECT * FROM Produtos ORDER BY Descricao ASC";
                        new Classe_Produtos().Listar_Produtos(Produtos.lstProdutos, SQL);
                        Close();
                    }
                }
                else
                {
                    try
                    {
                        new Classe_Produtos().Adicionar_Produto(grupo, codFabrica, fornecedor, descricao, custo, venda);
                    }
                    catch (Exception)
                    {
                        Form message3 = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu um erro durante o processo, tente novamente ou entre em contato com o Administrador");
                        message3.ShowDialog();
                    }
                    finally
                    {
                        Form message4 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Cadastro", "Produto cadastrado com sucesso!");
                        message4.ShowDialog();

                        string SQL = "SELECT * FROM Produtos ORDER BY Descricao ASC";
                        new Classe_Produtos().Listar_Produtos(Produtos.lstProdutos, SQL);
                        Close();
                    }
                }
            }
            else
            {
                Form message5 = new frmMensagemBox(Classe_Mensagem.CRITICO, "Dados Ausentes", "Favor preencher todos os campos!");
                message5.ShowDialog();
            }
        }
    }
}
