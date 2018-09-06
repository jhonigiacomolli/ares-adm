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
    public partial class frmIncluirItem : Form
    {
        bool mouseDown;
        Point lastLocation;
        public string TIPO;
        public int IDVeiculo;
        public int IDProduto;
        frmOrdemServico frmordemservico;

        public frmIncluirItem(frmOrdemServico FRMORDEMSERVICO, string Tipo, int ID_Veiculo)
        {
            InitializeComponent();
            this.TIPO = Tipo;
            this.IDVeiculo = ID_Veiculo;
            this.frmordemservico = FRMORDEMSERVICO;
        }

        public frmIncluirItem(frmOrdemServico FRMORDEMSERVICO, string Tipo, int ID_Veiculo, int ID_Produto)
        {
            InitializeComponent();
            this.TIPO = Tipo;
            this.IDVeiculo = ID_Veiculo;
            this.frmordemservico = FRMORDEMSERVICO;
            this.IDProduto = ID_Produto;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != string.Empty && txtQuantidade.Text != string.Empty && txtValorUnitario.Text != string.Empty && txtValorTotal.Text != string.Empty)
            {
                string Codigo = txtCodigo.Text;
                string Categoria = txtCategoria.Text;
                string Descricao = txtDescricao.Text;
                double qnt = Convert.ToDouble(txtQuantidade.Text);
                double ValorUni = Convert.ToDouble(txtValorUnitario.Text);
                double ValorTotal = Convert.ToDouble(txtValorTotal.Text);

                if (TIPO.Equals("Editar"))
                {
                    new Classe_OrdemServico().Editar_Item(IDProduto, IDVeiculo.ToString(), Categoria, Codigo, Descricao, qnt, ValorUni, ValorTotal);
                    this.Close();
                }
                else
                {
                    new Classe_OrdemServico().Incluir_Item(this, TIPO, IDVeiculo, Categoria, Codigo, Descricao, qnt, ValorUni, ValorTotal);
                }
                frmordemservico.AtualizaDadosGeral();
            }
            else
            {
                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Dados Incompletos", "Favor preencher todos os cmampos para proceguir!");
                messagebox.Show();
            }
        }

        private void txtValorUnitario_Validated(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                double unit = Convert.ToDouble(txtValorUnitario.Text);
                double qnt = Convert.ToDouble(txtQuantidade.Text);

                double Total = unit * qnt;
                txtValorTotal.Text = Total.ToString();
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

        private void frmIncluirItem_KeyDown(object sender, KeyEventArgs e)
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
                Classe_Produtos Prod = new Classe_Produtos();
                Prod.Listar_Produtos(txtCodigo.Text);

                txtDescricao.Text = Prod.Descricao;
                txtValorUnitario.Text = Prod.Venda.ToString();
                txtQuantidade.Select();
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

        private void txtValorUnitario_KeyDown(object sender, KeyEventArgs e)
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

        private void txtValorTotal_KeyDown(object sender, KeyEventArgs e)
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
            if (TIPO != "Editar")
            {
                txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtCodigo.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtDescricao.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtQuantidade.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtQuantidade.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtValorUnitario_Enter(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtValorUnitario.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtValorUnitario_Leave(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtValorUnitario.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtValorTotal.BackColor = Classe_Tema.TextBox_Edicao;
            }
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (TIPO != "Editar")
            {
                txtValorTotal.BackColor = Classe_Tema.TextBox_Normal;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string Grupo1 = "ABRASIVOS";
            string Grupo2 = "DIVERSOS";
            string Grupo3 = "POLIDORES";
            string SQL = "SELECT * FROM Produtos WHERE Grupo='" + Grupo1 + "' OR Grupo='" + Grupo2 + "' OR Grupo='" + Grupo3 + "'";
            frmProdutos produtos = new frmProdutos(this,SQL );
            txtQuantidade.Select();
            produtos.ShowDialog();
        }
    }
}
