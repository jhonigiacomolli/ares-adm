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
        Point lastLocation;

        private ListViewColumnSorter lvwColumnSorter;

        public frmOrdemServico(string nos, string proprietario, string veiculo, string placa, string cor, string tamanho)
        {
            InitializeComponent();
 
            //Reordenar Colunas List view 
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstItensOS.ListViewItemSorter = lvwColumnSorter;

            picLogoEmpresa.ImageLocation = Classes_Conexao.CaminhoLogo;
            new Classe_Tema().TEMA_frmOrdemServico(this);
            new Classe_Listviews().Criar_LST_ItensOS(lstItensOS);
            new Classe_OrdemServico().Cabecalho_OrdemServico(this, nos, proprietario, veiculo, placa, cor, tamanho);
            new Classe_OrdemServico().Listar_ItensOS(lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo like '" + nos + "'");            
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
            frmIncluirItem Tinta = new frmIncluirItem(this,"Tinta",Convert.ToInt32(txtNos.Text));
            Tinta.Show();
        }

        private void btnCatalise_Click(object sender, EventArgs e)
        {
            frmIncluirItem Tinta = new frmIncluirItem(this,"Catalise", Convert.ToInt32(txtNos.Text));
            Tinta.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmIncluirItem Tinta = new frmIncluirItem(this,"Produtos", Convert.ToInt32(txtNos.Text));
            Tinta.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Tipo = lstItensOS.FocusedItem.SubItems[3].Text;
            int ID = Convert.ToInt32(lstItensOS.FocusedItem.SubItems[1].Text);
            string Descricao =lstItensOS.FocusedItem.SubItems[4].Text;
            double Quantidade =Convert.ToDouble(lstItensOS.FocusedItem.SubItems[5].Text);
            double ValorUnitario = Convert.ToDouble(lstItensOS.FocusedItem.SubItems[6].Text);
            double ValorTotal = Convert.ToDouble(lstItensOS.FocusedItem.SubItems[7].Text);
            int IDVEiculo= Convert.ToInt32(txtNos.Text);

            new Classe_OrdemServico().Preenche_FormEdicao(ID,IDVEiculo,Descricao,Quantidade,ValorUnitario,ValorTotal);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir o item selecionado permanentemente?");
            DialogResult Resposta = messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                int ID = Convert.ToInt32(lstItensOS.FocusedItem.SubItems[0].Text);

                new Classe_OrdemServico().Excluir_Item(ID);
                new Classe_OrdemServico().Listar_ItensOS(lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo like '" + txtNos.Text + "'");
            }
        }
    }
}
