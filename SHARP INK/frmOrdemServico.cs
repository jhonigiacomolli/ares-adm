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
    public partial class frmOrdemServico : Form
    {
        bool mouseDown;
        public string ID;
        Point lastLocation;

        private ListViewColumnSorter lvwColumnSorter;

        public frmOrdemServico(string nos, string proprietario, string veiculo, string placa, string cor, string tamanho)
        {
            InitializeComponent();
            ID = nos;

            pnItensOS.Visible = true;

            //Reordenar Colunas List view 
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstItensOS.ListViewItemSorter = lvwColumnSorter;

            picLogoEmpresa.ImageLocation = Classes_Conexao.CaminhoLogo;
            new Classes_Conexao().Get_Grupos(cboGrupos);
            new Classe_Tema().TEMA_frmOrdemServico(this);

            new Classe_OrdemServico().Cabecalho_OrdemServico(this, nos, proprietario, veiculo, placa, cor, tamanho);
            AtualizaDadosOS();              
        }
        public void AtualizaDadosOS()
        {
            new Classe_OrdemServico().Atualizar_DadosOS(this, lstItensOS,lstFuncionarios, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo like '" + ID + "'", ID, txtSomaAbrasivos, txtSomaCatalises, txtSomaTinta, txtSomaPolidores, txtSomaDiversos, txtTicket);
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

        private void lstItensOS_ColumnClick(object sender, ColumnClickEventArgs e)
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
            this.lstItensOS.Sort();
        }

        private void btnTinta_Click(object sender, EventArgs e)
        {
            frmIncluirItem Tinta = new frmIncluirItem(this, "Tinta", Convert.ToInt32(txtNos.Text));
            Tinta.txtCodigo.Enabled = false;
            Tinta.txtCodigo.BackColor = Classe_Tema.TextBox_Desativado;
            Tinta.lblCodigo.ForeColor = new Classe_Tema().COR_Subtitulos;
            Tinta.btnPesquisa.Visible = false;
            Tinta.Show();
        }

        private void btnCatalise_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmIncluirItem Tinta = new frmIncluirItem(this, "Produtos", Convert.ToInt32(txtNos.Text));
            Tinta.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Tipo = "Editar";
            int IDProduto = Convert.ToInt32(lstItensOS.FocusedItem.SubItems[0].Text);
            string COdigo = lstItensOS.FocusedItem.SubItems[2].Text;
            string Categoria = lstItensOS.FocusedItem.SubItems[3].Text;
            string Descricao = lstItensOS.FocusedItem.SubItems[4].Text;
            double Quantidade = Convert.ToDouble(lstItensOS.FocusedItem.SubItems[5].Text);
            double ValorUnitario = Convert.ToDouble(lstItensOS.FocusedItem.SubItems[6].Text);
            double ValorTotal = Convert.ToDouble(lstItensOS.FocusedItem.SubItems[7].Text);
            int IDVEiculo = Convert.ToInt32(txtNos.Text);

            new Classe_OrdemServico().Preenche_FormEdicao(this, Tipo, IDProduto, IDVEiculo, Categoria, COdigo, Descricao, Quantidade, ValorUnitario, ValorTotal);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir o item selecionado permanentemente?");
            DialogResult Resposta = messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                int ID = Convert.ToInt32(lstItensOS.FocusedItem.SubItems[0].Text);

                new Classe_OrdemServico().Excluir_Item(ID);
                AtualizaDadosOS();
            }
        }

        private void cboGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrupos.Text.Equals("Selecione o grupo"))
            {
                new Classe_OrdemServico().Listar_ItensOS(lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo='" + txtNos.Text + "'");

            }
            else
            {
                new Classe_OrdemServico().Listar_ItensOS(lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE Categoria='" + cboGrupos.Text + "' AND ID_Veiculo='" + txtNos.Text + "'");
            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            pnItensOS.Visible = true;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = false;            
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            new Classe_OrdemServico().GraficoOS(this);

            pnItensOS.Visible = false;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = true;
        }

        private void btnPainelFuncionarios_Click(object sender, EventArgs e)
        {
            pnItensOS.Visible = false;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = true;
            pnGraficos.Visible = false;
        }

        private void btnPainelPecas_Click(object sender, EventArgs e)
        {
            pnItensOS.Visible = false;
            pnPecas.Visible = true;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = false;
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            frmApontamentoFunc apontar = new frmApontamentoFunc();
            if (Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
            {
                apontar.Height = 250;
            }
            if (Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO") || Classes_Conexao.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
            {
                apontar.Height = 190;
            }
            
            apontar.Show();
        }
    }
}
