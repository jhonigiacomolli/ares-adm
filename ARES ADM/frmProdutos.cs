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
    public partial class frmProdutos : Form
    {
        bool mouseDown;
        Point lastLocation;
        frmIncluirItem frmIncluir;
        frmIncluirPeca frmincluirpeca;
        frmApontamentoFunc frmapontamento;
        frmOrcamentos frmorcamentos;
        frmIncluirItemOrcamento frmincluiritemorcamento;
        public string Genero;
        public string IndexProduto;

        public frmProdutos(string Genero)
        {
            InitializeComponent();
            this.Genero = Genero;

            new Classe_Tema().TEMA_frmProdutos(this);

            if (Genero.Equals("PRODUTO"))
            {
                lblTituloForm.Text = "ARES ADM - Produtos";
                this.Text = "ARES ADM - Produtos";
                new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
                new Classe_Produtos().Listar_Produtos(lstProdutos, "SELECT * FROM Produtos ORDER BY Descricao ASC");
                txtPesquisa.Select();
            }
            if (Genero.Equals("FUNCIONARIO"))
            {
                lblTituloForm.Text = "ARES ADM - Funcionarios";
                this.Text = "ARES ADM - Funcionarios";
                new Classe_Listviews().Criar_LST_Funcionarios(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
                new Classe_Funcionario().Listar_Funcionarios(lstProdutos, "SELECT * FROM Funcionarios ORDER BY Nome ASC");
                txtPesquisa.Select();
            }
            if (Genero.Equals(Classe_Pecas.Pecas_Complementares))
            {
                lblTituloForm.Text = "ARES ADM - Peças Complementares";
                this.Text = "ARES ADM - Peças Complementares";
                new Classe_Listviews().Criar_LST_Pecas(lstProdutos);
                new Classe_Pecas().Listar_PecasComplementares(lstProdutos);
                txtPesquisa.Select();
            }

            if (Genero.Equals(Classe_Pecas.Pecas_Principais))
            {
                lblTituloForm.Text = "ARES ADM - Peças Principais";
                this.Text = "ARES ADM - Peças Principais";
                new Classe_Listviews().Criar_LST_PecasReparacao(lstProdutos);
                new Classe_Pecas().Listar_PecasPrincipais(lstProdutos);
                txtPesquisa.Select();
            }

            if (Genero.Equals("CLIENTE"))
            {
                lblTituloForm.Text = "ARES ADM - Clientes";
                this.Text = "ARES ADM - Clientes";
                new Classe_Tema().TEMA_frmProdutos(this);
                new Classe_Listviews().Criar_LST_Clientes(lstProdutos);
                new Classe_Cliente().Listar_Clientes(lstProdutos, "SELECT * FROM Clientes ORDER BY Nome ASC");
                txtPesquisa.Select();
            }
        }

        public frmProdutos(frmIncluirItem FormIncluirItem, string SQL)
        {
            InitializeComponent();
            frmIncluir = FormIncluirItem;
            Genero = string.Empty;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Produtos(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaProdutos(cboCampo);
            new Classe_Produtos().Listar_Produtos(lstProdutos, SQL);
            lblTituloForm.Text = "ARES ADM - Produtos";
            txtPesquisa.Select();
        }
        public frmProdutos(frmApontamentoFunc frmApontamento, string SQL)
        {
            InitializeComponent();
            frmapontamento = frmApontamento;
            Genero = string.Empty;
            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Funcionarios(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
            new Classe_Funcionario().Listar_Funcionarios(lstProdutos, SQL);
            lblTituloForm.Text = "ARES ADM - Funcionarios";
            txtPesquisa.Select();
        }
        public frmProdutos(string Genero, frmIncluirPeca FormIncluirPeca)
        {
            if (Genero.Equals(Classe_Pecas.Pecas_Complementares))
            {
                InitializeComponent();
                frmincluirpeca = FormIncluirPeca;
                this.Genero = Genero;

                lblTituloForm.Text = "ARES ADM - Peças Complementares";
                this.Text = "ARES ADM - Peças Complementares";
                new Classe_Listviews().Criar_LST_Pecas(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaPecasComplementares(cboCampo);
                new Classe_Pecas().Listar_PecasComplementares(lstProdutos);
                txtPesquisa.Select();
            }

            if (Genero.Equals(Classe_Pecas.Pecas_Principais))
            {
                InitializeComponent();
                frmincluirpeca = FormIncluirPeca;
                this.Genero = Genero;

                lblTituloForm.Text = "ARES ADM - Peças Principais";
                this.Text = "ARES ADM - Peças Principais";
                new Classe_Listviews().Criar_LST_PecasReparacao(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaPecasReparacao(cboCampo);
                new Classe_Pecas().Listar_PecasPrincipais(lstProdutos);
                txtPesquisa.Select();
            }

            txtPesquisa.Select();
        }

        public frmProdutos(frmIncluirItemOrcamento frmIncluirItemOrcamentos)
        {
            InitializeComponent();
            frmincluiritemorcamento = frmIncluirItemOrcamentos;

            new Classe_Tema().TEMA_frmProdutos(this);
            new Classe_Listviews().Criar_LST_Pecas(lstProdutos);
            new Classe_Listviews().Criar_CamposPesquisaPecasComplementares(cboCampo);
            new Classe_Pecas().Listar_PecasComplementares(lstProdutos);
            lblTituloForm.Text = "ARES ADM - Peças";
        }

        public frmProdutos(frmOrcamentos frmOrcamentos, string TIPO, string SQL)
        {
            if (TIPO.Equals("FUNCIONÁRIO"))
            {
                InitializeComponent();
                frmorcamentos = frmOrcamentos;
                Genero = TIPO;
                new Classe_Tema().TEMA_frmProdutos(this);
                new Classe_Listviews().Criar_LST_Funcionarios(lstProdutos);
                new Classe_Listviews().Criar_CamposPesquisaFuncionarios(cboCampo);
                new Classe_Funcionario().Listar_Funcionarios(lstProdutos, SQL);
                lblTituloForm.Text = "ARES ADM - Funcionarios";
                txtPesquisa.Select();
            }
            if (TIPO.Equals("CLIENTE"))
            {
                InitializeComponent();
                frmorcamentos = frmOrcamentos;
                Genero = TIPO;
                pnInfoClientes.Visible = true;
                new Classe_Tema().TEMA_frmProdutos(this);
                new Classe_Listviews().Criar_LST_Clientes(lstProdutos);
                new Classe_Cliente().Listar_Clientes(lstProdutos, SQL);
                lblTituloForm.Text = "ARES ADM - Clientes";
                txtPesquisa.Select();
            }
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Destaque;
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Normal;
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
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.B || e.KeyCode == Keys.C || e.KeyCode == Keys.D || e.KeyCode == Keys.E || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.I || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.M || e.KeyCode == Keys.N || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.Q || e.KeyCode == Keys.R || e.KeyCode == Keys.S || e.KeyCode == Keys.T || e.KeyCode == Keys.U || e.KeyCode == Keys.V || e.KeyCode == Keys.W || e.KeyCode == Keys.X || e.KeyCode == Keys.Y || e.KeyCode == Keys.Z || (e.Shift && e.KeyCode == Keys.D5))
            {
                txtPesquisa.Clear();
                if (e.Shift && e.KeyCode.Equals(Keys.D5)) { txtPesquisa.Text = "%"; } else { txtPesquisa.Text = e.KeyCode.ToString(); }
                txtPesquisa.Select(txtPesquisa.Text.Length, 0);
                txtPesquisa.Select();

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
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.B || e.KeyCode == Keys.C || e.KeyCode == Keys.D || e.KeyCode == Keys.E || e.KeyCode == Keys.F || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.I || e.KeyCode == Keys.J || e.KeyCode == Keys.K || e.KeyCode == Keys.L || e.KeyCode == Keys.M || e.KeyCode == Keys.N || e.KeyCode == Keys.O || e.KeyCode == Keys.P || e.KeyCode == Keys.Q || e.KeyCode == Keys.R || e.KeyCode == Keys.S || e.KeyCode == Keys.T || e.KeyCode == Keys.U || e.KeyCode == Keys.V || e.KeyCode == Keys.W || e.KeyCode == Keys.X || e.KeyCode == Keys.Y || e.KeyCode == Keys.Z || (e.Shift && e.KeyCode == Keys.D5))
            {
                txtPesquisa.Clear();
                if (e.Shift && e.KeyCode.Equals(Keys.D5)) { txtPesquisa.Text = "%"; } else { txtPesquisa.Text = e.KeyCode.ToString(); }
                txtPesquisa.Select(txtPesquisa.Text.Length, 0);
                txtPesquisa.Select();

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
                    lstProdutos.Select();
                    if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                }
                if (frmapontamento != null)
                {
                    new Classe_Funcionario().Pesquisa_Funcionario(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                    lstProdutos.Select();
                    if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                }
                if (frmincluiritemorcamento != null)
                {
                    new Classe_Pecas().Pesquisa_PecaReparacao(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                    lstProdutos.Select();
                    if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                }
                if (Genero != null)
                {
                    if (Genero.Equals(Classe_Pecas.Pecas_Complementares))
                    {
                        new Classe_Pecas().Pesquisa_PecaComplementar(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                        lstProdutos.Select();
                        if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                    }
                    if (Genero.Equals(Classe_Pecas.Pecas_Principais))
                    {
                        new Classe_Pecas().Pesquisa_PecaReparacao(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                        lstProdutos.Select();
                        if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                    }
                    if (Genero.Equals("PRODUTO"))
                    {
                        new Classe_Produtos().Pesquisa_Produtos(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                        lstProdutos.Select();
                        if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                    }
                    if (Genero.Equals("FUNCIONARIO"))
                    {
                        new Classe_Funcionario().Pesquisa_Funcionario(lstProdutos, cboCampo.Text, txtPesquisa.Text);
                        lstProdutos.Select();
                        if (lstProdutos.Items.Count > 0) { lstProdutos.Items[0].Selected = true; }
                    }
                }
            }
        }

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (frmIncluir != null)
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
                if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
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
                if (Genero.Equals(Classe_Pecas.Pecas_Complementares))
                {
                    frmincluirpeca.txtCodigo.Text = lstProdutos.FocusedItem.SubItems[0].Text;
                    frmincluirpeca.txtDescricao.Text = lstProdutos.FocusedItem.SubItems[2].Text;
                    frmincluirpeca.txtUnitario.Text = lstProdutos.FocusedItem.SubItems[5].Text;
                    frmincluirpeca.cboAplicacaoDano.Text = lstProdutos.FocusedItem.SubItems[3].Text;
                    this.Close();
                }
                if (Genero.Equals(Classe_Pecas.Pecas_Principais))
                {
                    frmincluirpeca.txtCodigo.Text = lstProdutos.FocusedItem.SubItems[0].Text;
                    frmincluirpeca.txtDescricao.Text = lstProdutos.FocusedItem.SubItems[1].Text;
                    this.Close();
                }
            }

            if (frmorcamentos != null)
            {
                if (Genero.Equals("FUNCIONÁRIO"))
                {
                    frmorcamentos.txtOrcamentista.Text = lstProdutos.FocusedItem.SubItems[1].Text;
                    frmorcamentos.ID_Orcamentista = lstProdutos.FocusedItem.SubItems[0].Text;
                    Close();
                }
                if (Genero.Equals("CLIENTE"))
                {
                    frmorcamentos.ID_CLiente = lstProdutos.FocusedItem.SubItems[0].Text;
                    frmorcamentos.txtProprietario.Text = lstProdutos.FocusedItem.SubItems[2].Text;
                    frmorcamentos.txtCPF_CNPJ.Text = lstProdutos.FocusedItem.SubItems[4].Text;
                    frmorcamentos.txtEndereco.Text = lstProdutos.FocusedItem.SubItems[6].Text;
                    frmorcamentos.txtNumero.Text = lstProdutos.FocusedItem.SubItems[7].Text;
                    frmorcamentos.txtBairro.Text = lstProdutos.FocusedItem.SubItems[8].Text;
                    frmorcamentos.txtCidade.Text = lstProdutos.FocusedItem.SubItems[9].Text;
                    frmorcamentos.txtCEP.Text = lstProdutos.FocusedItem.SubItems[10].Text;
                    frmorcamentos.cboEstado.Text = lstProdutos.FocusedItem.SubItems[11].Text;
                    frmorcamentos.txtTelefone.Text = lstProdutos.FocusedItem.SubItems[12].Text;

                    new Classe_Orcamentos().Validar_Campos_Cabecalho(frmorcamentos);

                    Close();
                }
            }

            if (frmincluiritemorcamento != null)
            {
                frmincluiritemorcamento.txtCodFabrica.Text = lstProdutos.FocusedItem.Text;
                frmincluiritemorcamento.txtDescricao.Text = lstProdutos.FocusedItem.SubItems[2].Text;
                frmincluiritemorcamento.txtValorBruto.Text = lstProdutos.FocusedItem.SubItems[6].Text;
                frmincluiritemorcamento.txtValorLiquido.Text = lstProdutos.FocusedItem.SubItems[6].Text;

                Close();
            }
        }

        private void lstProdutos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstProdutos.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexProduto = lstProdutos.FocusedItem.Index.ToString();
            new Classe_Listviews().AlteraCorSelecao(lstProdutos);

            

            if (Genero != null && Genero.Equals("CLIENTE"))
            {
                if (lstProdutos.SelectedItems.Count > 0)
                {
                    new Classe_Cliente().Info_CLientes(this, lstProdutos.FocusedItem);
                }
                else
                {
                    new Classe_Cliente().Limpar_Info_Clientes(this);
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (Genero.Equals("PRODUTO"))
            {
                frmCadastroProdutos frmcadprod = new frmCadastroProdutos(this);
                frmcadprod.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Genero.Equals("PRODUTO"))
            {
                if (lstProdutos.FocusedItem.Text != string.Empty)
                {
                    int ID = Convert.ToInt32(lstProdutos.FocusedItem.Text);
                    string grupo = lstProdutos.FocusedItem.SubItems[3].Text;
                    string codfabrica = lstProdutos.FocusedItem.SubItems[1].Text;
                    string fornecedor = lstProdutos.FocusedItem.SubItems[2].Text;
                    string descricao = lstProdutos.FocusedItem.SubItems[4].Text;
                    double custo = Convert.ToDouble(lstProdutos.FocusedItem.SubItems[6].Text);
                    double venda = Convert.ToDouble(lstProdutos.FocusedItem.SubItems[7].Text);
                    double margem = ((venda / custo) - 1) * 100;
                    frmCadastroProdutos frmcadprod = new frmCadastroProdutos(this, ID, grupo, codfabrica, fornecedor, descricao, custo, margem, venda);
                    frmcadprod.ShowDialog();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form Messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente exluir permanentemente o produto selecionado?");

            DialogResult Resposta = Messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                try
                {
                    int ID = Convert.ToInt32(lstProdutos.FocusedItem.Text);
                    new Classe_Produtos().Excluir_Produto(ID);
                }
                catch (Exception)
                {
                    Form message = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu um erro durante o processo, tente novamente ou entre em contato com o Administrador");
                    message.ShowDialog();
                }
                finally
                {
                    Form message = new frmMensagemBox(Classe_Mensagem.ALERTA, "Exclusão", "Produto excluido com sucesso!");
                    message.ShowDialog();

                    string SQL = "SELECT * FROM Produtos ORDER BY Descricao ASC";
                    new Classe_Produtos().Listar_Produtos(lstProdutos, SQL);
                }
            }
        }


    }
}
