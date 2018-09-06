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
            this.lstFuncionarios.ListViewItemSorter = lvwColumnSorter;
            this.lstPecasComplementares.ListViewItemSorter = lvwColumnSorter;
            this.lstPecasPrincipais.ListViewItemSorter = lvwColumnSorter;

            picLogoEmpresa.ImageLocation = Classes_Conexao.CaminhoLogo;
            new Classe_OrdemServico().Get_Grupos(cboGrupos);
            new Classe_Tema().TEMA_frmOrdemServico(this);

            new Classe_OrdemServico().Cabecalho_OrdemServico(this, nos, proprietario, veiculo, placa, cor, tamanho);
            AtualizaDadosGeral();
        }
        public void AtualizaDadosGeral()
        {
            new Classe_OrdemServico().Atualizar_DadosGeral(this, lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo like '" + ID + "'", ID, txtSomaAbrasivos, txtSomaCatalises, txtSomaTinta, txtSomaPolidores, txtSomaDiversos, txtTicket);
        }
        public void AtualizaDadosFuncionario()
        {
            new Classe_OrdemServico().Atualizar_DadosFuncionarios(this, lstFuncionarios, txtNos.Text);
        }
        public void AtualizaDadosPecas()
        {
            new Classe_OrdemServico().Atualizar_DadosPecas(this, lstPecasPrincipais, lstPecasComplementares, txtNos.Text);
        }
        public void AtualizaDadosGrafico()
        {
            new Classe_OrdemServico().GraficoOS(this);
            new Classe_BancoHoras().GraicoApontamento(this);
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
                AtualizaDadosGeral();
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
            btnPainelPecas.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelPecas.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGrafico.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGrafico.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGeral.BackColor = pnItensOS.BackColor;
            btnPainelGeral.FlatAppearance.BorderColor = pnItensOS.BackColor;
            btnPainelFuncionarios.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelFuncionarios.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;

            pnItensOS.Visible = true;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = false;

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            btnPainelPecas.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelPecas.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGrafico.BackColor = pnGraficos.BackColor;
            btnPainelGrafico.FlatAppearance.BorderColor = pnGraficos.BackColor;
            btnPainelGeral.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGeral.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelFuncionarios.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelFuncionarios.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;

            pnItensOS.Visible = false;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = true;

            AtualizaDadosFuncionario();
            AtualizaDadosGrafico();
        }

        private void btnPainelFuncionarios_Click(object sender, EventArgs e)
        {
            AtualizaDadosFuncionario();

            cboFiltroApontamento.SelectedIndex = 0;
            new Classe_BancoHoras().Get_FiltroApontamento(cboFuncao, cboFiltroApontamento.Text);

            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
            {
                btnLiberar.Visible = true;
            }
            else
            {
                btnLiberar.Visible = false;
                btnApontar.Location = btnLiberar.Location;
            }

            btnPainelPecas.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelPecas.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGrafico.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGrafico.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGeral.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGeral.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelFuncionarios.BackColor = pnFuncionarios.BackColor;
            btnPainelFuncionarios.FlatAppearance.BorderColor = pnFuncionarios.BackColor;

            pnItensOS.Visible = false;
            pnPecas.Visible = false;
            pnFuncionarios.Visible = true;
            pnGraficos.Visible = false;

            lstFuncionarios.Select();
        }

        private void btnPainelPecas_Click(object sender, EventArgs e)
        {
            btnPainelPecas.BackColor = pnPecas.BackColor;
            btnPainelPecas.FlatAppearance.BorderColor = pnPecas.BackColor;
            btnPainelGrafico.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGrafico.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelGeral.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelGeral.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;
            btnPainelFuncionarios.BackColor = Classe_Tema.MenuBotao_Normal;
            btnPainelFuncionarios.FlatAppearance.BorderColor = Classe_Tema.BordaBotao;

            pnItensOS.Visible = false;
            pnPecas.Visible = true;
            pnFuncionarios.Visible = false;
            pnGraficos.Visible = false;

            AtualizaDadosPecas();
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            frmApontamentoFunc apontar = new frmApontamentoFunc(this, txtNos.Text);

            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
            {
                apontar.Height = 250;
            }
            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO") || Classe_BancoHoras.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
            {
                apontar.Height = 190;
            }

            apontar.ShowDialog();
        }

        private void btnEditarApontamento_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstFuncionarios.FocusedItem.SubItems[0].Text);
            string ID_Funcionario = lstFuncionarios.FocusedItem.SubItems[1].Text;
            string ID_Veiculo = lstFuncionarios.FocusedItem.SubItems[2].Text;
            string Nome = lstFuncionarios.FocusedItem.SubItems[3].Text;
            string Funcao = lstFuncionarios.FocusedItem.SubItems[4].Text;
            frmApontamentoFunc func = new frmApontamentoFunc(this, ID, ID_Veiculo);

            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
            {
                func.Height = 190;
                new Classe_BancoHoras().CarregaEdicaoApontamento(func, ID_Funcionario, ID_Veiculo, Nome, Funcao, null, null, null);
            }
            else
            {
                string Entrada = lstFuncionarios.FocusedItem.SubItems[5].Text;
                string Saida = lstFuncionarios.FocusedItem.SubItems[6].Text;
                string Valor = lstFuncionarios.FocusedItem.SubItems[8].Text;
                string Tempo = lstFuncionarios.FocusedItem.SubItems[7].Text;
                string MO = lstFuncionarios.FocusedItem.SubItems[9].Text;

                new Classe_BancoHoras().CarregaEdicaoApontamento(func, ID_Funcionario, ID_Veiculo, Nome, Funcao, Entrada, Saida, MO);
            }
        }

        private void lstFuncionarios_ColumnClick(object sender, ColumnClickEventArgs e)
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
            this.lstFuncionarios.Sort();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            string ID = lstFuncionarios.FocusedItem.SubItems[0].Text;
            string Entrada = lstFuncionarios.FocusedItem.SubItems[5].Text;
            double MO = Convert.ToDouble(lstFuncionarios.FocusedItem.SubItems[9].Text);

            if (Classe_BancoHoras.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
            {
                new Classe_BancoHoras().Liberar_Funcionario(ID, Entrada, DateTime.Now.ToString(), MO);
            }
            AtualizaDadosFuncionario();
        }

        private void btnExcluirApontamento_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstFuncionarios.FocusedItem.SubItems[0].Text);

            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir permanentemento o apontamento selecionado?");
            DialogResult Resposta = messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                new Classe_BancoHoras().Exluir_Apontamento(ID);
                AtualizaDadosFuncionario();
            }
        }

        private void lstFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_OrdemServico().HabilitarBotoesApontamento(this);
        }

        private void pnFuncionarios_Click(object sender, EventArgs e)
        {
            lstFuncionarios.SelectedItems.Clear();
            new Classe_OrdemServico().HabilitarBotoesApontamento(this);
        }

        private void frmOrdemServico_Click(object sender, EventArgs e)
        {
            lstFuncionarios.SelectedItems.Clear();
            new Classe_OrdemServico().HabilitarBotoesApontamento(this);
        }

        private void cboFiltroApontamento_SelectedValueChanged(object sender, EventArgs e)
        {
            new Classe_BancoHoras().Get_FiltroApontamento(cboFuncao, cboFiltroApontamento.Text);
        }

        private void cboFuncao_SelectedValueChanged(object sender, EventArgs e)
        {
            string SQL = "";

            if (cboFuncao.SelectedIndex != 0)
            {
                if (cboFiltroApontamento.Text.Equals("Funcionário"))
                {
                    SQL = "SELECT * FROM OrdemServico_BancoHoras WHERE ID_Veiculo='" + ID + "' AND Nome='" + cboFuncao.Text + "' ORDER BY id ASC";
                }
                if (cboFiltroApontamento.Text.Equals("Função"))
                {
                    SQL = "SELECT * FROM OrdemServico_BancoHoras WHERE ID_Veiculo='" + ID + "' AND Funcao='" + cboFuncao.Text + "' ORDER BY id ASC";
                }
            }
            else
            {
                SQL = "SELECT * FROM OrdemServico_BancoHoras WHERE ID_Veiculo='" + ID + "' ORDER BY id ASC";
            }
            new Classe_BancoHoras().Listar_ApontamentosOS(lstFuncionarios, SQL);
        }

        private void lblTituloLavacao_Click(object sender, EventArgs e)
        {
            lstFuncionarios.SelectedItems.Clear();
            new Classe_OrdemServico().HabilitarBotoesApontamento(this);
        }

        private void lstFuncionarios_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstFuncionarios.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lstItensOS_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstItensOS.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void lstPecasPrincipais_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstPecasPrincipais.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lstPecasComplementares_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lstPecasComplementares.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnIncluirPecaP_Click(object sender, EventArgs e)
        {
            frmIncluirPeca principal = new frmIncluirPeca(this, txtNos.Text, string.Empty);
            principal.Height = 202;
            principal.ShowDialog();
        }

        private void btnIncluirPecaC_Click(object sender, EventArgs e)
        {
            frmIncluirPeca complementar = new frmIncluirPeca(this, txtNos.Text, string.Empty, string.Empty);
            complementar.Height = 248;
            complementar.ShowDialog();
        }

        private void btnEditarPeca_Click(object sender, EventArgs e)
        {
            //Editar Pecas Complementares
            if (lstPecasComplementares.SelectedItems.Count != 0 && lstPecasPrincipais.SelectedItems.Count == 0)
            {
                string id = lstPecasComplementares.FocusedItem.SubItems[0].Text;
                string idveiculo = lstPecasComplementares.FocusedItem.SubItems[1].Text;
                string idpeca = lstPecasComplementares.FocusedItem.SubItems[2].Text;
                string descricao = lstPecasComplementares.FocusedItem.SubItems[3].Text;
                string aplicacao = lstPecasComplementares.FocusedItem.SubItems[4].Text;
                double valor = double.Parse(lstPecasComplementares.FocusedItem.SubItems[6].Text);
                double qnt = double.Parse(lstPecasComplementares.FocusedItem.SubItems[5].Text);
                double total = double.Parse(lstPecasComplementares.FocusedItem.SubItems[7].Text);

                new Classe_Pecas().CarregaEdicao_PecasComplementar(this, id, idveiculo, idpeca, descricao, aplicacao, valor, qnt, total);
            }

            //Editar Pecas Principais
            if (lstPecasComplementares.SelectedItems.Count == 0 && lstPecasPrincipais.SelectedItems.Count != 0)
            {
                string id = lstPecasPrincipais.FocusedItem.SubItems[0].Text;
                string idveiculo = lstPecasPrincipais.FocusedItem.SubItems[1].Text;
                string idpeca = lstPecasPrincipais.FocusedItem.SubItems[2].Text;
                string descricao = lstPecasPrincipais.FocusedItem.SubItems[3].Text;
                string dano = lstPecasPrincipais.FocusedItem.SubItems[4].Text;
                string tipo = lstPecasPrincipais.FocusedItem.SubItems[5].Text;

                new Classe_Pecas().CarregaEdicao_PecasPrincipal(this, id, idpeca, idveiculo, descricao, dano, tipo);
            }
        }

        private void lstPecasPrincipais_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPecasComplementares.SelectedItems.Clear();
        }

        private void lstPecasComplementares_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPecasPrincipais.SelectedItems.Clear();
        }

        private void btnExcluirPeca_Click(object sender, EventArgs e)
        {
            Form messagebox = new frmMensagemBox(Classe_Mensagem.QUESTAO, "Exclusão", "Deseja realmente excluir o item selecionado ?");
            DialogResult Resposta = messagebox.ShowDialog();

            if (Resposta.Equals(DialogResult.OK))
            {
                //Excluir Pecas Complementares
                if (lstPecasComplementares.SelectedItems.Count != 0 && lstPecasPrincipais.SelectedItems.Count == 0)
                {
                    new Classe_Pecas().Excluir_PecaComplementar(this, lstPecasComplementares.FocusedItem.SubItems[0].Text);
                }
                //Excluir Pecas Principais
                if (lstPecasComplementares.SelectedItems.Count == 0 && lstPecasPrincipais.SelectedItems.Count != 0)
                {
                    new Classe_Pecas().Excluir_PecaPrincipal(this, lstPecasPrincipais.FocusedItem.SubItems[0].Text);
                }
            }
            else
            {
                return;
            }
        }

        private void lstPecasComplementares_ColumnClick(object sender, ColumnClickEventArgs e)
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
            this.lstPecasComplementares.Sort();
        }

        private void lstPecasPrincipais_ColumnClick(object sender, ColumnClickEventArgs e)
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
            this.lstPecasPrincipais.Sort();
        }

        private void cboFiltroPEca1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFiltroPEca1.Text.Equals("Peça Principal"))
            {
                cboFiltroPeca2.Items.Clear();

                cboFiltroPeca2.Items.Add("Selecione o tipo");
                new Classe_Pecas().Get_TipoPeca(cboFiltroPeca2);
                cboFiltroPeca2.SelectedIndex = 0;
            }
            if (cboFiltroPEca1.Text.Equals("Peça Complementar"))
            {
                cboFiltroPeca2.Items.Clear();

                cboFiltroPeca2.Items.Add("Selecione a aplicação");
                new Classe_Pecas().Get_PecaAplicacao(cboFiltroPeca2);
                cboFiltroPeca2.Items.Add("OUTROS");
                cboFiltroPeca2.SelectedIndex = 0;
            }
        }

        private void cboFiltroPeca2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboFiltroPEca1.Text.Equals("Peça Principal"))
            {
                if (cboFiltroPeca2.Text.Equals("Selecione o tipo"))
                {
                    new Classe_Pecas().Listar_PecasPrincipais(lstPecasPrincipais, "SELECT * FROM OrdemServico_Pecas WHERE ID_Veiculo='" + txtNos.Text + "' ORDER BY Pecas ASC");
                    new Classe_Pecas().Listar_PecasComplementares(lstPecasComplementares, "SELECT * FROM OrdemServico_PecasComplementares WHERE ID_Veiculo='" + txtNos.Text + "' ORDER BY Peca ASC");

                }
                else
                {
                    new Classe_Pecas().Listar_PecasPrincipais(lstPecasPrincipais, "SELECT * FROM OrdemServico_Pecas WHERE Tipo='" + cboFiltroPeca2.Text + "' AND ID_Veiculo='" + txtNos.Text + "'");
                }
            }
            if (cboFiltroPEca1.Text.Equals("Peça Complementar"))
            {
                if (cboFiltroPeca2.Text.Equals("Selecione a aplicação"))
                {
                    new Classe_Pecas().Listar_PecasPrincipais(lstPecasPrincipais, "SELECT * FROM OrdemServico_Pecas WHERE ID_Veiculo='" + txtNos.Text + "' ORDER BY Pecas ASC");
                    new Classe_Pecas().Listar_PecasComplementares(lstPecasComplementares, "SELECT * FROM OrdemServico_PecasComplementares WHERE ID_Veiculo='" + txtNos.Text + "' ORDER BY Peca ASC");
                }
                else
                {
                    new Classe_Pecas().Listar_PecasComplementares(lstPecasComplementares, "SELECT * FROM OrdemServico_PecasComplementares WHERE Aplicacao='" + cboFiltroPeca2.Text + "' AND ID_Veiculo='" + txtNos.Text + "'");
                }
            }
        }
    }
}
