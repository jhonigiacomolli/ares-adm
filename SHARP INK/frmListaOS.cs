using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK
{
    public partial class frmListaOS : Form
    {
        bool mouseDown;
        Point lastLocation;
        public int ItemSelecionado;
        private ListViewColumnSorter lvwColumnSorter;

        public frmListaOS()
        {
            InitializeComponent();
            pnMenuOS.Height = 0;

            //Reordenar Colunas List view 
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstVeiculos.ListViewItemSorter = lvwColumnSorter;

            new Classe_Tema().TEMA_frmListaOS(this);
            new Classe_Listviews().Criar_LST_Veiculos(lstVeiculos);
            new Classe_Listviews().Criar_CamposPesquisa(cboTipoPesquisa);
            new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
            new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
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
        }

        private void lstVeiculos_MouseDown(object sender, MouseEventArgs e)
        {
            pnMenuOS.Height = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;

            frmCadastroOS cadastro = new frmCadastroOS(0 ,this);
            cadastro.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;

            string id = lstVeiculos.FocusedItem.Text.TrimEnd();
            string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text.TrimEnd();
            string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text.TrimEnd();
            string Placa = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
            string Cor = lstVeiculos.FocusedItem.SubItems[4].Text.TrimEnd();
            string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();

            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir a OS Nº " + id + "\n" + "Proprietario: " + Proprietario + "\nVeiculo: " + Veiculo + "\nPlaca: " + Placa);
            DialogResult Resposta=messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                new Classe_Veiculos().Excluir_Veiculos(int.Parse(id));
                new Classe_Veiculos().Listar_Veiculos(lstVeiculos,"SELECT * FROM Veiculos ORDER BY Situacao ASC");
                new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
            }
            else
            {
                return;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnMenuOS.Height = 0;

            string id = lstVeiculos.FocusedItem.Text.TrimEnd();
            string Proprietario = lstVeiculos.FocusedItem.SubItems[1].Text.TrimEnd();
            string Veiculo = lstVeiculos.FocusedItem.SubItems[2].Text.TrimEnd();
            string Placa = lstVeiculos.FocusedItem.SubItems[3].Text.TrimEnd();
            string Cor = lstVeiculos.FocusedItem.SubItems[4].Text.TrimEnd();
            string Tamanho = lstVeiculos.FocusedItem.SubItems[5].Text.TrimEnd();

            frmCadastroOS Edicao = new frmCadastroOS(int.Parse(id),this);
            Edicao.txtNumeroOS.Text = id;
            new Classe_Veiculos().Listar_Veiculos(Edicao, "SELECT * FROM Veiculos WHERE id='" + id + "'");
            Edicao.lblTituloForm.Text = "SHARP INK - Edição";         
            Edicao.ShowDialog();


        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Classe_Tema.TextBox_Edicao;
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.BackColor = Color.White;
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
                new Classe_Veiculos().Pesquisar_Veiculos(lstVeiculos, cboTipoPesquisa.Text, txtPesquisa.Text);
            }
        }

        private void txtPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void cboTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisa.Clear();

            if (cboTipoPesquisa.Text.Equals("Todos"))
            {
                new Classe_Veiculos().Listar_Veiculos(lstVeiculos, "SELECT * FROM Veiculos ORDER BY Situacao ASC");
                new Classe_Listviews().ColorirLinhas_veiculos(lstVeiculos);
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
            if (lstVeiculos.FocusedItem.SubItems[8].Text.Equals("AGUARDANDO"))
            {
                Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Ordem Serviço", "A Ordem de Serviço selecionada ainda não foi aberta.\n\nDeseja abri-la para ver os detalhes?");
                DialogResult Resposta = messagebox.ShowDialog();

                if (Resposta == DialogResult.OK)
                {
                    new Classe_Veiculos().Abrir_OS(int.Parse(lstVeiculos.FocusedItem.Text));
                    new Classe_Veiculos().Listar_Veiculos(lstVeiculos,"SELECT * FROM Veiculos ORDER BY Situacao ASC");
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
                
                frmOrdemServico OS = new frmOrdemServico(NOS,Proprietario,Veiculo,Placa,Cor,Tamanho);
                OS.ShowDialog();
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
    }
}
