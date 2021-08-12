using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ARES_ADM.Classes;

namespace ARES_ADM
{
    public partial class frmListaOS : Form
    {
        bool mouseDown;
        Point lastLocation;
        public int ItemSelecionado;
        public string TIPO;
        private ListViewColumnSorter lvwColumnSorter;

        public frmListaOS(string Tipo)
        {
            InitializeComponent();
            pnMenuOS.Height = 0;
            TIPO = Tipo;

            //Reordenar Colunas List view 
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstVeiculos.ListViewItemSorter = lvwColumnSorter;

            if (TIPO.Equals("OS"))
            {
                new Classe_Tema().TEMA_frmListaOS(this);
                new Classe_Listviews().Criar_LST_Veiculos(lstVeiculos);
                new Classe_Listviews().Criar_CamposPesquisa(cboTipoPesquisa);
                new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);

                Text = Classe_Configuracoes.NomeModulos + " - Ordens de Serviço";
                lblTituloForm.Text = Classe_Configuracoes.NomeModulos + " - Ordens de Serviço";
                btnOS.Text = "Ordem de Serviço";
            }

            if (TIPO.Equals("ORÇAMENTO"))
            {
                new Classe_Tema().TEMA_frmListaOS(this);
                new Classe_Listviews().Criar_LST_Orcamentos(lstVeiculos);
                new Classe_Orcamentos().Listar_Orcamento(lstVeiculos);

                Text = Classe_Configuracoes.NomeModulos + " - Orçamentos";
                lblTituloForm.Text = Classe_Configuracoes.NomeModulos + " - Orçamentos";
                btnOS.Text = "Orçamentos";
            }
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
            if (TIPO.Equals("ORÇAMENTO"))
            {
                frmPaginaInicial.Formulario_Orcamento = false;
            }
            if (TIPO.Equals("OS"))
            {
                frmPaginaInicial.FOrmulario_OS = false;
            }

            this.Close();
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            if (pnMenuOS.Height == 0) 
            {
                pnMenuOS.Height = 92;
            }
            else
            {
                pnMenuOS.Height = 0;
            }
        }

        private void frmListaOS_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void pnCabecalho_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void lstVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;
            ItemSelecionado =int.Parse(lstVeiculos.FocusedItem.Text);

            new Classe_Listviews().AlteraCorSelecao(lstVeiculos,TIPO);
        }

        private void lstVeiculos_MouseDown(object sender, MouseEventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (TIPO.Equals("OS"))
            {
                pnMenuOS.Height = 0;

                frmCadastroOS cadastro = new frmCadastroOS(0, this);
                cadastro.ShowDialog();
            }

            if (TIPO.Equals("ORÇAMENTO"))
            {
                pnMenuOS.Height = 0;

                frmOrcamentos orcamento = new frmOrcamentos(this,string.Empty, Classe_Orcamentos.Formulario_Novo);
                Visible = false;
                orcamento.ShowDialog();
                Visible = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (TIPO.Equals("OS"))
            {
                pnMenuOS.Height = 0;

                string id = lstVeiculos.FocusedItem.Text.TrimEnd();
                string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text.TrimEnd();
                string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text.TrimEnd();
                string Placa = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
                string Cor = lstVeiculos.FocusedItem.SubItems[4].Text.TrimEnd();
                string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir a OS Nº " + id + "\n" + "Proprietario: " + Proprietario + "\nVeiculo: " + Veiculo + "\nPlaca: " + Placa);
                DialogResult Resposta = messagebox.ShowDialog();

                if (Resposta.Equals(DialogResult.OK))
                {
                    new Classe_Veiculos().Excluir_Veiculos(int.Parse(id));
                    new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                    new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
                }
                else
                {
                    return;
                }
            }

            if (TIPO.Equals("ORÇAMENTO"))
            {
                pnMenuOS.Height = 0;

                string id = lstVeiculos.FocusedItem.Text.TrimEnd();
                string Proprietario = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
                string Veiculo = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();
                string Placa = lstVeiculos.FocusedItem.SubItems[6].Text.TrimEnd();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir o Orçamento Nº " + id + "\n" + "Proprietario: " + Proprietario + "\nVeiculo: " + Veiculo + "\nPlaca: " + Placa);
                DialogResult Resposta = messagebox.ShowDialog();

                if (Resposta.Equals(DialogResult.OK))
                {
                    new Classe_Orcamentos().Excluir_Orcamento(id);
                    new Classe_Orcamentos().Listar_Orcamento(lstVeiculos);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TIPO.Equals("OS"))
            {
                pnMenuOS.Height = 0;

                string id = lstVeiculos.FocusedItem.Text.TrimEnd();
                string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text.TrimEnd();
                string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text.TrimEnd();
                string Placa = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
                string Cor = lstVeiculos.FocusedItem.SubItems[4].Text.TrimEnd();
                string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();

                frmCadastroOS Edicao = new frmCadastroOS(int.Parse(id), this);
                Edicao.txtNumeroOS.Text = id;
                new Classe_Veiculos().Listar_Veiculos(Edicao, "SELECT * FROM Veiculos WHERE id='" + id + "'");
                Edicao.lblTituloForm.Text = "ARES ADM - Edição";
                Edicao.ShowDialog();
            }

            if (TIPO.Equals("ORÇAMENTO"))
            {
                pnMenuOS.Height = 0;

                string ID = lstVeiculos.FocusedItem.Text;
                frmOrcamentos Orcamento = new frmOrcamentos(this, ID, Classe_Orcamentos.Formulario_Edicao);
                new Classe_Orcamentos().Cabecalho_Orcamento(lstVeiculos.FocusedItem.Text, Orcamento);
                
                Visible = false;
                Orcamento.ShowDialog();
                Visible = true;
            }
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Normal;
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    txtPesquisa.Clear();
                    lstVeiculos.Focus();
                    break;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (TIPO.Equals("OS"))
                {
                    new Classe_Veiculos().Pesquisar_Veiculos(lstVeiculos, cboTipoPesquisa.Text, txtPesquisa.Text);
                }
            }
        }

        private void txtPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void cboTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();

            if (TIPO.Equals("OS"))
            {
                if (cboTipoPesquisa.Text.Equals("Todos"))
                {
                    new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                    new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
                }
            }
        }

        private void frmListaOS_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnAbrir_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnFinalizar_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void lstVeiculos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnOS_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnAdicionar_KeyDown(object sender, KeyEventArgs e)
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

        private void btnExcluir_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (TIPO.Equals("OS")){
                if (lstVeiculos.FocusedItem.SubItems[8].Text.Equals("AGUARDANDO"))
                {
                    Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Ordem Serviço", "A Ordem de Serviço selecionada ainda não foi aberta.\n\nDeseja abri-la para ver os detalhes?");
                    DialogResult Resposta = messagebox.ShowDialog();

                    if (Resposta == DialogResult.OK)
                    {
                        new Classe_Veiculos().Abrir_OS(int.Parse(lstVeiculos.FocusedItem.Text));
                        new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                        new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
                    }
                }

                if (lstVeiculos.FocusedItem.SubItems[8].Text.Equals("ABERTA"))
                {
                    string NOS = lstVeiculos.FocusedItem.SubItems[0].Text;
                    string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text;
                    string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text;
                    string Placa = lstVeiculos.FocusedItem.SubItems[3].Text;
                    string Cor = lstVeiculos.FocusedItem.SubItems[4].Text;
                    string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text;

                    frmOrdemServico OS = new frmOrdemServico(NOS, Proprietario, Veiculo, Placa, Cor, Tamanho);
                    Visible = false;
                    OS.ShowDialog();
                    Visible = true;
                }
            }

            if (TIPO.Equals("ORÇAMENTO"))
            {
                string ID = lstVeiculos.FocusedItem.Text; 
                frmOrcamentos Orcamento = new frmOrcamentos(this,ID, Classe_Orcamentos.Formulario_Visualizacao);
                new Classe_Orcamentos().Cabecalho_Orcamento(lstVeiculos.FocusedItem.Text, Orcamento);
                
                Visible = false;
                new Classe_Orcamentos().Bloquear_Cabecalho(Orcamento);
                Orcamento.ShowDialog();
                Visible = true;
            }
        }

        private void lstVeiculos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.lstVeiculos.Sort();
        }

        private void lstVeiculos_DoubleClick(object sender, EventArgs e)
        {
            btnAbrir.PerformClick();
        }

        private void lstVeiculos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstVeiculos.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
