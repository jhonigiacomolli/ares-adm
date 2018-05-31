using System;
using System.Data.SqlServerCe;
using System.Data;
using SHARP_INK.Classes;
using System.Windows.Forms;


namespace SHARP_INK.Classes
{
    class Classe_OrdemServico
    {
        public void Atualizar_DadosGeral(frmOrdemServico Form, ListView LST, string SQL, string nos, Label Abrasivos, Label Catalises, Label Tintas, Label Polimentos, Label Diversos, Label Ticket)
        {
            LST.Clear();
            new Classe_Listviews().Criar_LST_ItensOS(LST);
            new Classe_Pecas().N_Pecas_Principais(Form.txtN_Pecas, nos);
            Listar_ItensOS(LST, SQL);

            Abrasivos.Text = Soma_Categorias(nos, "ABRASIVOS").ToString("N2");
            Catalises.Text = Soma_Categorias(nos, "CATALISES").ToString("N2");
            Diversos.Text = Soma_Categorias(nos, "DIVERSOS").ToString("N2");
            Polimentos.Text = Soma_Categorias(nos, "POLIDORES").ToString("N2");
            Tintas.Text = Soma_Categorias(nos, "TINTAS").ToString("N2");
            Ticket.Text = Soma_TicketVeiculo(nos).ToString("N2");

            double TK = Convert.ToDouble(Form.txtTicket.Text);
            double NPecas = Convert.ToDouble(Form.txtN_Pecas.Text);
            double MediPeca = TK / NPecas;

            Form.txtMediaPeca.Text = MediPeca.ToString("N2");
        }
        public void Atualizar_DadosFuncionarios(frmOrdemServico frmOS, ListView LSTFunc, string ID_Veiculo)
        {
            LSTFunc.Clear();
            new Classe_Listviews().Criar_LST_FuncionariosAlocados(LSTFunc);
            new Classe_BancoHoras().Listar_ApontamentosOS(LSTFunc, "SELECT * FROM OrdemServico_BancoHoras WHERE ID_Veiculo='" + ID_Veiculo + "'");

            new Classe_BancoHoras().Soma_Categorias(frmOS, ID_Veiculo);
        }

        public void Atualizar_DadosPecas(frmOrdemServico frmos, ListView LSTPecasPrin, ListView LSTPecasComp, string IDVeiculo)
        {
            LSTPecasPrin.Clear();
            LSTPecasComp.Clear();

            new Classe_Listviews().Criar_LST_PecasPrincipais(LSTPecasPrin);
            new Classe_Listviews().Criar_LST_PecasComplementares(LSTPecasComp);
            new Classe_Pecas().Listar_PecasPrincipais(LSTPecasPrin, "SELECT * FROM OrdemServico_Pecas WHERE ID_Veiculo='" + IDVeiculo + "' ORDER BY Pecas ASC");
            new Classe_Pecas().Listar_PecasComplementares(LSTPecasComp, "SELECT * FROM OrdemServico_PecasComplementares WHERE ID_Veiculo='" + IDVeiculo + "' ORDER BY Peca ASC");
            frmos.cboFiltroPeca2.Items.Add("Selecione o tipo");
            new Classes_Conexao().Get_TipoPeca(frmos.cboFiltroPeca2);
            frmos.cboFiltroPEca1.SelectedIndex = 0;
            frmos.cboFiltroPeca2.SelectedIndex = 0;

            new Classe_Pecas().Soma_DespesaPEcas(frmos, IDVeiculo);
            new Classe_Pecas().N_Pecas_Principais(frmos.lblN_PecasPrincipais, IDVeiculo);
        }

        public void Cabecalho_OrdemServico(frmOrdemServico Form, string nos, string proprietario, string veiculo, string placa, string cor, string tamanho)
        {
            Form.txtNos.Text = nos;
            Form.txtProprietario.Text = proprietario;
            Form.txtVeiculo.Text = veiculo;
            Form.txtPlaca.Text = placa;
            Form.txtCor.Text = cor;
            Form.txtTamanho.Text = tamanho;

            Form.lblRazaoSocial.Text = Classe_Empresa.RazaoSocial;
            Form.lblCNPJ.Text = Classe_Empresa.CNPJ;
            Form.lblEndereço.Text = Classe_Empresa.Endereco;
            Form.lblEmail.Text = Classe_Empresa.Email;
            Form.lblTelefone.Text = Classe_Empresa.Telefone;

            Form.lblTituloForm.Text = "SHARP INK | OS Nº " + nos;
        }

        public void Preenche_FormEdicao(frmOrdemServico frmOrdem, string Tipo, int IDProduto, int IDVeiculo, string Categoria, string Codigo, string Descricao, double quantidade, double ValorUnitario, double ValorTotal)
        {
            frmIncluirItem Form = new frmIncluirItem(frmOrdem, Tipo, IDVeiculo, IDProduto);

            Form.txtCodigo.Text = Codigo.ToString();
            Form.txtDescricao.Text = Descricao;
            Form.txtQuantidade.Text = quantidade.ToString();
            Form.txtValorUnitario.Text = ValorUnitario.ToString();
            Form.txtValorTotal.Text = ValorTotal.ToString();
            Form.txtCategoria.Text = Categoria.ToString();

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtQuantidade.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtValorUnitario.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtValorTotal.BackColor = Classe_Tema.TextBox_Edicao;

            Form.lblTituloForm.Text = "SHARP INK - Editar item";
            Form.btnGravar.Text = "Alterar";
            Form.ShowDialog();
        }

        public void Listar_ItensOS(ListView LST, string SQL)
        {
            try
            {
                LST.Items.Clear();

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        Item.SubItems.Add(DR["ID_Veiculo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["CodigoProduto"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Categoria"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Descricao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Convert.ToDecimal(DR["Quantidade"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorUnitario"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorTotal"].ToString().TrimEnd()).ToString("N2"));

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Incluir_Item(frmIncluirItem Form, string TIPO, int IDVeiculo, string Categoria, string Codigo, string Descricao, double QNT, double ValorUnitario, double ValorTotal)
        {
            if (TIPO.Equals("Tinta")) { Categoria = "TINTAS"; }

            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_Itens(ID_Veiculo,Categoria,CodigoProduto,Descricao,Quantidade,ValorUnitario,ValorTotal)" +
                            " VALUES ('" + IDVeiculo + "','" + Categoria + "','" + Codigo + "','" + Descricao + "','" + QNT + "','" + ValorUnitario + "','" + ValorTotal + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form Messagebox2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Inclusão", "o Item foi incluido com sucesso!");
                Messagebox2.ShowDialog();

                Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }


        public void Editar_Item(int ID, string ID_Veiculo, string Categoria, string Codigo, string Descricao, double QNT, double ValorUnitario, double ValorTotal)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE OrdemServico_Itens SET ID_Veiculo='" + ID_Veiculo.Replace("'", "''") + "', Categoria='" + Categoria + "', CodigoProduto='" + Codigo + "', Descricao='" + Descricao + "', Quantidade='" + QNT + "', ValorUnitario='" + ValorUnitario + "', ValorTotal='" + ValorTotal + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Excluir_Item(int ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM OrdemServico_Itens WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public double Soma_Categorias(string IDVeiculo, string Categoria)
        {
            double SOMA = 0;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM OrdemServico_Itens WHERE Categoria='" + Categoria + "' AND ID_Veiculo='" + IDVeiculo + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        SOMA = SOMA + Convert.ToDouble(DR["ValorTotal"]);
                    }
                }
                DT.Dispose();
                return SOMA;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
                return 0;
            }
        }
        public double Soma_TicketVeiculo(string IDVeiculo)
        {
            double SOMA = 0;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo='" + IDVeiculo + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        SOMA = SOMA + Convert.ToDouble(DR["ValorTotal"]);
                    }
                }
                DT.Dispose();
                return SOMA;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
                return 0;
            }
        }

        public void GraficoOS(frmOrdemServico Form)
        {
            decimal ABRASIVOS = Convert.ToDecimal(Form.txtSomaAbrasivos.Text);
            decimal CATALISADOS = Convert.ToDecimal(Form.txtSomaCatalises.Text);
            decimal TINTA = Convert.ToDecimal(Form.txtSomaTinta.Text);
            decimal POLIDORES = Convert.ToDecimal(Form.txtSomaPolidores.Text);
            decimal DIVERSOS = Convert.ToDecimal(Form.txtSomaDiversos.Text);
            decimal TOTAL = ABRASIVOS + CATALISADOS + TINTA + POLIDORES + DIVERSOS;


            Form.Grafico_Dados.Series["Dados"].Points.Clear();
            Form.Grafico_Dados.Series["Dados"].Points.AddXY("Abrasivos", ABRASIVOS / TOTAL);
            Form.Grafico_Dados.Series["Dados"].Points.AddXY("Catalisados", CATALISADOS / TOTAL);
            Form.Grafico_Dados.Series["Dados"].Points.AddXY("Tinta", TINTA / TOTAL);
            Form.Grafico_Dados.Series["Dados"].Points.AddXY("Polidores", POLIDORES / TOTAL);
            Form.Grafico_Dados.Series["Dados"].Points.AddXY("Diversos", DIVERSOS / TOTAL);
        }

        public void HabilitarBotoesApontamento(frmOrdemServico Form)
        {
            string status = "";

            if (Form.lstFuncionarios.FocusedItem != null) { status = Form.lstFuncionarios.FocusedItem.SubItems[6].Text; } else { return; }

            if (Form.lstFuncionarios.SelectedItems.Count.Equals(0) || Form.lstFuncionarios.SelectedItems.Equals(false))
            {
                Form.btnApontar.Enabled = true;
                Form.btnLiberar.Enabled = false;
                Form.btnExcluirApontamento.Enabled = false;
                Form.btnEditarApontamento.Enabled = false;
            }
            else
            {
                if (status.Equals(string.Empty))
                {
                    Form.btnApontar.Enabled = false;
                    Form.btnLiberar.Enabled = true;
                    Form.btnExcluirApontamento.Enabled = false;
                    Form.btnEditarApontamento.Enabled = false;
                }
                else
                {
                    Form.btnApontar.Enabled = false;
                    Form.btnLiberar.Enabled = false;
                    Form.btnExcluirApontamento.Enabled = true;
                    Form.btnEditarApontamento.Enabled = true;
                }
            }
        }
    }
}
