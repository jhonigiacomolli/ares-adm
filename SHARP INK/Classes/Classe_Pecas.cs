using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace SHARP_INK.Classes
{
    class Classe_Pecas
    {
        public string id { get; private set; }
        public string Grupo { get; private set; }
        public string Descricao { get; private set; }
        public string Aplicacao { get; private set; }
        public double QuantidadeEstoque { get; private set; }
        public double Custo { get; private set; }
        public double Venda { get; private set; }
        public string Fornecedor { get; private set; }


        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();

        public void Listar_Pecas(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["Grupo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Descricao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Aplicacao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["QuantidadeEstoque"].ToString().TrimEnd().ToUpper());
                        if (DR["Custo"].ToString().TrimEnd() != null && DR["Custo"].ToString().TrimEnd() != string.Empty) { Item.SubItems.Add(Convert.ToDecimal(DR["Custo"].ToString().TrimEnd()).ToString("N2")); };
                        if (DR["Venda"].ToString().TrimEnd() != null && DR["Venda"].ToString().TrimEnd() != string.Empty) { Item.SubItems.Add(Convert.ToDecimal(DR["Venda"].ToString().TrimEnd()).ToString("N2")); };
                        Item.SubItems.Add(DR["Fornecedor"].ToString().TrimEnd());

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Listar_Pecas(string ID)
        {
            string SQL = "SELECT * FROM Pecas WHERE id='" + ID + "'";
            try
            {

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        id = DR["id"].ToString();
                        Grupo = DR["Grupo"].ToString().TrimEnd().ToUpper();
                        Descricao = DR["Descricao"].ToString().TrimEnd().ToUpper();
                        Aplicacao = DR["Aplicacao"].ToString().TrimEnd().ToUpper();
                        if (DR["QuantidadeEstoque"].ToString() != string.Empty) { QuantidadeEstoque = double.Parse(DR["QuantidadeEstoque"].ToString()); }
                        Custo = Convert.ToDouble(DR["Custo"].ToString().TrimEnd());
                        Venda = Convert.ToDouble(DR["Venda"].ToString().TrimEnd());
                        Fornecedor = DR["Fornecedor"].ToString().TrimEnd();
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Listar_PecasPrincipais(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["ID_Peca"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Pecas"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Dano"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Tipo"].ToString().TrimEnd());

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Listar_PecasComplementares(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["ID_PecaComp"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Peca"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Aplicacao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Convert.ToDecimal(DR["Quantidade"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["Valor"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorTotal"].ToString().TrimEnd()).ToString("N2"));

                        LST.Items.Add(Item);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Incluir_PecaPrincipal(frmIncluirPeca Form, string ID_Veiculo, string Descricao, string Dano, string ID_peca, string Tipo)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_Pecas(ID_Veiculo,Pecas,Dano,ID_Peca,Tipo)" +
                            " VALUES ('" + ID_Veiculo + "','" + Descricao + "','" + Dano + "','" + ID_peca + "','" + Tipo + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form Messagebox2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Inclusão", "Peça incluida com sucesso!");
                Messagebox2.ShowDialog();

                Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Incluir_PecaComplementar(frmIncluirPeca Form, string ID_Veiculo, string ID_Peca, string Descricao, string Aplicacao, double Valor, double QNT, double Total)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_PecasComplementares(ID_Veiculo,ID_PecaComp,Peca,Aplicacao,Valor,Quantidade,ValorTotal)" +
                            " VALUES ('" + ID_Veiculo + "','" + ID_Peca + "','" + Descricao + "','" + Aplicacao + "','" + Valor + "','" + QNT + "','" + Total + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form Messagebox2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Inclusão", "Peça incluida com sucesso!");
                Messagebox2.ShowDialog();

                Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void CarregaEdicao_PecasComplementar(frmOrdemServico OS, string ID, string ID_Veiculo, string ID_Peca, string Descrição, string Aplicação, double Valor, double QNT, double Total)
        {
            frmIncluirPeca Form = new frmIncluirPeca(OS, ID_Veiculo, string.Empty, ID);
            Form.Height = 248;

            Form.txtCodigo.Text = ID_Peca;
            Form.txtDescricao.Text = Descrição;
            Form.cboAplicacaoDano.Text = Aplicação;
            Form.txtQuantidade.Text = QNT.ToString("N2");
            Form.txtUnitario.Text = Valor.ToString("N2");
            Form.txtCusto.Text = Total.ToString("N2");

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboAplicacaoDano.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtQuantidade.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtUnitario.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtCusto.BackColor = Classe_Tema.TextBox_Edicao;

            Form.btnGravar.Text = "Alterar";
            Form.ShowDialog();
        }
        public void CarregaEdicao_PecasPrincipal(frmOrdemServico OS, string ID, string ID_Peca, string ID_Veiculo, string Descricao, string Dano, string Tipo)
        {
            frmIncluirPeca Form = new frmIncluirPeca(OS, ID_Veiculo, ID);
            Form.Height = 202;

            Form.txtCodigo.Text = ID_Peca;
            Form.txtDescricao.Text = Descricao;
            Form.cboAplicacaoDano.Text = Dano;
            Form.cboTipoPeca.Text = Tipo;

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtDescricao.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboAplicacaoDano.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboTipoPeca.BackColor = Classe_Tema.TextBox_Edicao;

            Form.btnGravar.Text = "Alterar";
            Form.ShowDialog();
        }

        public void Atulizar_PecaComplementar(frmIncluirPeca Form, string ID, string ID_Veiculo, string ID_Peca, string Descricao, string Aplicacao, double Valor, double QNT, double Total)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE OrdemServico_PecasComplementares SET ID_Veiculo='" + ID_Veiculo.Replace("'", "''") + "', ID_PecaComp='" + ID_Peca + "', Peca='" + Descricao + "', Aplicacao='" + Aplicacao + "', Quantidade='" + QNT + "', Valor='" + Valor + "', ValorTotal='" + Total + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Alteração", "Item alterado com sucesso!");
                messagebox.ShowDialog();

                Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Atualizar_PecaPrincipal(frmIncluirPeca Form, string ID, string ID_Veiculo, string Descricao, string Dano, string ID_peca, string Tipo)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE OrdemServico_Pecas SET ID_Veiculo='" + ID_Veiculo.Replace("'", "''") + "', Pecas='" + Descricao + "', Dano='" + Dano + "', ID_Peca='" + ID_peca + "', Tipo='" + Tipo + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Alteração", "Item alterado com sucesso!");
                messagebox.ShowDialog();

                Form.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Excluir_PecaPrincipal(frmOrdemServico OS, string ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM OrdemServico_Pecas WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                OS.AtualizaDadosPecas();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Excluir_PecaComplementar(frmOrdemServico OS, string ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM OrdemServico_PecasComplementares WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                OS.AtualizaDadosPecas();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Soma_DespesaPEcas(frmOrdemServico Form, string ID_Veiculo)
        {
            double N_PecasComplementares = 0;
            double Ticket = 0;

            double SomaPeca_Carroceria = 0;
            double SomaPeca_Eletrica = 0;
            double SomaPeca_Estofados = 0;
            double SomaPeca_Freio = 0;
            double SomaPeca_Motor = 0;
            double SomaPeca_Outros = 0;
            double SomaPeca_SomAcessorios = 0;
            double SomaPeca_Suspensao = 0;
            double SomaPeca_Transmissao = 0;
            double SomaPeca_Vidros = 0;

            string Aplicacao = "";

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM OrdemServico_PecasComplementares WHERE ID_Veiculo='" + ID_Veiculo + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        Aplicacao = DR["Aplicacao"].ToString().TrimEnd().ToUpper();

                        if (Aplicacao.Equals("CARROCERIA"))
                        {
                            SomaPeca_Carroceria = SomaPeca_Carroceria + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("ELÉTRICA"))
                        {
                            SomaPeca_Eletrica = SomaPeca_Eletrica + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("ESTOFADOS"))
                        {
                            SomaPeca_Estofados = SomaPeca_Estofados + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("FREIOS"))
                        {
                            SomaPeca_Freio = SomaPeca_Freio + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("MOTOR"))
                        {
                            SomaPeca_Motor = SomaPeca_Motor + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("SOM E ACESSÓRIOS"))
                        {
                            SomaPeca_SomAcessorios = SomaPeca_SomAcessorios + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("SUSPENSÃO"))
                        {
                            SomaPeca_Suspensao = SomaPeca_Suspensao + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("TRANSMISSÃO"))
                        {
                            SomaPeca_Transmissao = SomaPeca_Transmissao + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao.Equals("VIDROS"))
                        {
                            SomaPeca_Vidros = SomaPeca_Vidros + Convert.ToDouble(DR["ValorTotal"]);
                        }
                        if (Aplicacao != "CARROCERIA" && Aplicacao != "ELÉTRICA" && Aplicacao != "ESTOFADOS" && Aplicacao != "FREIOS" && Aplicacao != "MOTOR" && Aplicacao != "SOM E ACESSÓRIOS" && Aplicacao != "SUSPENSÃO" && Aplicacao != "TRANSMISSÃO" && Aplicacao != "VIDROS")
                        {
                            SomaPeca_Outros = SomaPeca_Outros + Convert.ToDouble(DR["ValorTotal"]);
                        }

                        Ticket = Ticket + +Convert.ToDouble(DR["ValorTotal"]);

                        N_PecasComplementares = N_PecasComplementares + Convert.ToDouble(DR["Quantidade"].ToString().TrimEnd());
                    }
                    
                }
                DT.Dispose();
                
                Form.lblTicketPecas.Text = Ticket.ToString("N2");
                Form.lblN_PecasComplementares.Text = N_PecasComplementares.ToString("N1");

                Form.lblSOMA_PecaCarroceria.Text = SomaPeca_Carroceria.ToString("N2");
                Form.lblSOMA_PecaEletrica.Text = SomaPeca_Eletrica.ToString("N2");
                Form.lblSOMA_PecaEstofados.Text = SomaPeca_Estofados.ToString("N2");
                Form.lblSOMA_PecaFreios.Text = SomaPeca_Freio.ToString("N2");
                Form.lblSOMA_PecaMotor.Text = SomaPeca_Motor.ToString("N2");
                Form.lblSOMA_PecaOutros.Text = SomaPeca_Outros.ToString("N2");
                Form.lblSOMA_PecaSom.Text = SomaPeca_SomAcessorios.ToString("N2");
                Form.lblSOMA_PecaSuspensao.Text = SomaPeca_Suspensao.ToString("N2");
                Form.lblSOMA_PecaTransmissao.Text = SomaPeca_Transmissao.ToString("N2");
                Form.lblSOMA_PecaVidros.Text = SomaPeca_Vidros.ToString("N2");
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void N_Pecas_Principais(Label LBL, string ID_Veiculo)
        {
            double N_PecasPrincipais = 0;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM OrdemServico_Pecas WHERE ID_Veiculo='" + ID_Veiculo + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        double Peca = 1;
                        double Dano = double.Parse(DR["Dano"].ToString().TrimEnd());

                        N_PecasPrincipais = N_PecasPrincipais + ((Peca * Dano) / 100);
                    }
                }
                DT.Dispose();

                LBL.Text = N_PecasPrincipais.ToString("N1");
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Get_PecaAplicacao(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Aplicacao FROM Pecas_Aplicacao ORDER BY Aplicacao ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Aplicacao"].ToString().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Get_TipoPeca(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Tipo FROM Pecas_Tipo ORDER BY Tipo ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Tipo"].ToString().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_DanoPeca(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Dano FROM Pecas_Dano ORDER BY id DESC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Dano"].ToString().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
    }
}
