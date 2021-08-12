using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Drawing;

namespace ARES_ADM.Classes
{
    class Classe_Orcamentos
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();
        public static string ID_Orcamentista;

        public static string Formulario_Novo = "NOVO";
        public static string Formulario_Edicao = "EDIÇÃO";
        public static string Formulario_Visualizacao = "VISUALIZAÇÃO";

        public void Validar_Campos_Cabecalho(frmOrcamentos Form)
        {
            //Verifica Painel Proprietario
            if (Form.txtProprietario.Text != string.Empty && Form.txtCPF_CNPJ.Text != string.Empty && Form.txtEndereco.Text != string.Empty
                    && Form.txtNumero.Text != string.Empty && Form.txtBairro.Text != string.Empty && Form.txtCidade.Text != string.Empty
                    && Form.cboEstado.Text != string.Empty && Form.txtCEP.Text != string.Empty && Form.txtTelefone.Text != string.Empty)
            {
                Form.icStatusProprietario.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusProprietario.BackColor = Color.Red;
            }

            //Verifica Painel Veiculo
            if (Form.txtMontadora.Text != string.Empty && Form.txtVeiculo.Text != string.Empty && Form.txtMotorizacao.Text != string.Empty
                && Form.txtPlaca.Text != string.Empty && Form.txtKM.Text != string.Empty && Form.txtNChassis.Text != string.Empty
                && Form.txtCor.Text != string.Empty && Form.txtPintura.Text != string.Empty)
            {
                Form.icStatusVeiculo.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusVeiculo.BackColor = Color.Red;
            }

            //Verifica Pianel Seguro            
            if (Form.cboSeguro.Text.Equals("SIM") && Form.cboTipoSeguro.Text != string.Empty && Form.cboSeguradora.Text != string.Empty
                && Form.txtFranquia.Text != string.Empty && Form.txtNSinistro.Text != string.Empty)
            {
                Form.icStatusSeguro.BackColor = Color.Green;
            }
            else
            {
                Form.icStatusSeguro.BackColor = Color.Red;
            }
            if (Form.cboSeguro.Text.Equals("NÃO"))
            {
                Form.icStatusSeguro.BackColor = Color.Green;
            }
        }

        public void Seleciona_PainelDadosProprietario(frmOrcamentos Form)
        {
            Form.pnProprietario.Visible = true;
            Form.pnDadosVeiculo.Visible = false;
            Form.pnSeguro.Visible = false;

            Form.btnDadosProprietario.BackColor = Classe_Tema.Botao_Secundario;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosSeguro.BackColor = Classe_Tema.MenuBotao_Normal;

            Validar_Campos_Cabecalho(Form);

            Form.txtProprietario.Select();
        }

        public void Seleciona_PainelDadosVeiculo(frmOrcamentos Form)
        {
            Form.pnProprietario.Visible = false;
            Form.pnDadosVeiculo.Visible = true;
            Form.pnSeguro.Visible = false;

            Form.btnDadosProprietario.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.Botao_Secundario;
            Form.btnDadosSeguro.BackColor = Classe_Tema.MenuBotao_Normal;

            Validar_Campos_Cabecalho(Form);

            Form.txtMontadora.Select();
        }

        public void Seleciona_PainelDadosSeguro(frmOrcamentos Form)
        {
            Form.pnProprietario.Visible = false;
            Form.pnDadosVeiculo.Visible = false;
            Form.pnSeguro.Visible = true;

            Form.btnDadosProprietario.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosVeiculo.BackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnDadosSeguro.BackColor = Classe_Tema.Botao_Secundario;

            Validar_Campos_Cabecalho(Form);

            Form.cboSeguro.Select();
        }


        public void Valida_Seguro(frmOrcamentos Form)
        {
            if (Form.cboSeguro.Text.Equals("SIM"))
            {
                Form.cboTipoSeguro.Enabled = true;
                Form.cboSeguradora.Enabled = true;
                Form.txtFranquia.Enabled = true;
                Form.txtNSinistro.Enabled = true;
            }
            if (Form.cboSeguro.Text.Equals("NÃO"))
            {
                Form.cboTipoSeguro.Enabled = false;
                Form.cboSeguradora.Enabled = false;
                Form.txtFranquia.Enabled = false;
                Form.txtNSinistro.Enabled = false;

                Form.cboTipoSeguro.SelectedIndex = -1;
                Form.cboSeguradora.SelectedIndex = -1;
                Form.txtFranquia.Clear();
                Form.txtNSinistro.Clear();
            }
        }

        public void Validar_TipoCadastro(frmOrcamentos Form)
        {
            if (Form.cboTipoCadastro.Text.Equals("PESSOA FISICA"))
            {
                Form.btnProprietario.Text = "Proprietário";
                Form.lblTituloCPF_CNPJ.Text = "CPF";
                Form.txtCPF_CNPJ.Mask = "000.000.000-00";
            }

            if (Form.cboTipoCadastro.Text.Equals("PESSOA JURÍDICA"))
            {
                Form.btnProprietario.Text = "Razão Social";
                Form.lblTituloCPF_CNPJ.Text = "CNPJ";
                Form.txtCPF_CNPJ.Mask = "00.000.000/0000-00";
            }
        }

        public void Validar_TipoTelefone(frmOrcamentos Form)
        {
            if (Form.cboTipoTelefone.Text.Equals("Celular Particular"))
            {
                Form.txtTelefone.Mask = "(00) 0 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Celular Comercial"))
            {
                Form.txtTelefone.Mask = "(00) 0 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Comercial"))
            {
                Form.txtTelefone.Mask = "(00) 0000 0000";
            }
            if (Form.cboTipoTelefone.Text.Equals("Residencial"))
            {
                Form.txtTelefone.Mask = "(00) 0000 0000";
            }
        }

        public void Carregar_UF(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT UF FROM UF ORDER BY UF ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["UF"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Montadoras(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Montadora FROM Montadoras ORDER BY Montadora ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Montadora"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Cor(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Cor FROM Cores ORDER BY Cor ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Cor"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_TipoPintura(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT TipoPintura FROM Tipo_Pintura ORDER BY TipoPintura ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["TipoPintura"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_TipoSeguro(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Tipo FROM Seguro_Tipos ORDER BY Tipo ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Tipo"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Carregar_Seguradoras(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Seguradora FROM Seguro_Seguradoras ORDER BY Seguradora ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Seguradora"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Listar_ItensOrcamento(ListView LST, string ID)
        {
            try
            {
                string SQL = "SELECT * FROM Orcamentos_Itens WHERE ID_Orcamento='" + ID + "'";
                LST.Items.Clear();
                LST.ShowItemToolTips = true;

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        Item.SubItems.Add(DR["ID_Orcamento"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Operacao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Cod_Peca"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Descricao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Convert.ToDecimal(DR["QNT"].ToString().TrimEnd()).ToString("N1"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorUN_Bruto"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["Desconto"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorUN_Liquido"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["ValorTotal"].ToString().TrimEnd()).ToString("N2"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["Horas"].ToString().TrimEnd()).ToString("N1"));
                        Item.SubItems.Add(Convert.ToDecimal(DR["Pintura"].ToString().TrimEnd()).ToString("N1"));

                        LST.Items.Add(Item);

                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Listar_Orcamento(ListView LST)
        {
            try
            {
                string SQL = "SELECT * FROM Orcamentos";
                LST.Items.Clear();
                LST.ShowItemToolTips = true;

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        DateTime Data = Convert.ToDateTime(DR["DataAbertura"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(Data.ToShortDateString());
                        Item.SubItems.Add(DR["ID_Cliente"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Proprietario"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Montadora"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Veiculo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Placa"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Seguro"].ToString().TrimEnd().ToUpper());
                        if (DR["Total"].ToString() != string.Empty) { Item.SubItems.Add(Convert.ToDecimal(DR["Total"].ToString().TrimEnd()).ToString("N2")); }
                        Item.SubItems.Add(DR["ID_Orcamentista"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Orcamentista"].ToString().TrimEnd().ToUpper());

                        LST.Items.Add(Item);

                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Incluir_Orcamento(frmOrcamentos Orcamento, frmListaOS Form, string TipoCadastro, string IDOrcamentista, string Orcamentista, string IDCLiente, string Proprietario, string CPF_CNPJ, string Endereço, string Numero
                                      , string Bairro, string Cidade, string Estado, string CEP, string TipoTelefone, string Telefone, string Montadora, string Veiculo
                                      , string Placa, string Motorizacao, string KM, string Chassis, string Cor, string Pintura, string possuiseguro
                                      , string tiposeguro, string Seguradora, string Franquia, string Sinistro)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO Orcamentos(Proprietario,Veiculo,Placa,Seguro,Total,Montadora,DataAbertura,Orcamentista,ID_Cliente, ID_Orcamentista, TipoCadastro, CPF, Endereco, Endereco_Numero, Bairro, Cidade, Estado, CEP, TipoTelefone, Telefone, Motorizacao, KM, Chassis, Cor, Pintura, TipoSeguro, Seguradora, Franquia, Sinistro)" +
                            " VALUES ('" + Proprietario + "','" + Veiculo + "','" + Placa + "','" + possuiseguro + "','0,00','" + Montadora + "','" + DateTime.Now.ToString() + "','" + Orcamentista + "','" + IDCLiente + "','" + IDOrcamentista + "','" + TipoCadastro + "','" + CPF_CNPJ + "','" + Endereço + "','" + Numero + "','" + Bairro + "','" + Cidade + "','" + Estado + "','" + CEP + "','" + TipoTelefone + "','" + Telefone + "','" + Motorizacao + "','" + KM + "','" + Chassis + "','" + Cor + "','" + Pintura + "','" + tiposeguro + "','" + Seguradora + "','" + Franquia + "','" + Sinistro + "')";

                string comandoSQL2 = "SELECT @@IDENTITY";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);
                SqlCeCommand CMD2 = new SqlCeCommand(comandoSQL2, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                int id =Convert.ToInt32(CMD2.ExecuteScalar());
                
                CONN.Close();
                
                Orcamento.txtNOrcamento.Text = id.ToString();
                Orcamento.txtAbertura.Text = DateTime.Now.ToShortDateString();
                
                Bloquear_Cabecalho(Orcamento);
                new Classe_Listviews().Criar_LST_ItensOrcamento(Orcamento.lstItensOrcamento);
                Seleciona_PainelDadosProprietario(Orcamento);

                Listar_Orcamento(Form.lstVeiculos);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Atualizar_Orcamento(frmOrcamentos Orcamento, frmListaOS Form,string ID, string TipoCadastro, string IDOrcamentista, string Orcamentista, string IDCLiente, string Proprietario, string CPF_CNPJ, string Endereço, string Numero
                                      , string Bairro, string Cidade, string Estado, string CEP, string TipoTelefone, string Telefone, string Montadora, string Veiculo
                                      , string Placa, string Motorizacao, string KM, string Chassis, string Cor, string Pintura, string possuiseguro
                                      , string tiposeguro, string Seguradora, string Franquia, string Sinistro)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE Orcamentos SET Proprietario='" + Proprietario.Replace("'", "''") + "', Veiculo='" + Veiculo + "', Placa='" + Placa + "', Seguro='" + possuiseguro + "', Montadora='" + Montadora + "', Orcamentista='" + Orcamentista + "', ID_Cliente='" + IDCLiente + "', ID_Orcamentista='" + IDOrcamentista + "', TipoCadastro='" + TipoCadastro + "', CPF='" + CPF_CNPJ + "', Endereco='" + Endereço + "', Endereco_Numero='" + Numero + "', Bairro='" + Bairro + "', Cidade='" + Cidade + "', Estado='" + Estado + "', CEP='" + CEP + "', TipoTelefone='" + TipoTelefone + "', Telefone='" + Telefone + "', Motorizacao='" + Motorizacao + "', KM='" + KM + "', Chassis='" + Chassis + "', Cor='" + Cor + "', Pintura='" + Pintura + "', TipoSeguro='" + tiposeguro + "', Seguradora='" + Seguradora + "', Franquia='" + Franquia + "', Sinistro='" + Sinistro + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);                

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
                
                Bloquear_Cabecalho(Orcamento);
                Seleciona_PainelDadosProprietario(Orcamento);

                Listar_Orcamento(Form.lstVeiculos);
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Excluir_Orcamento(string ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM Orcamentos WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();

                string comandoSQL2 = "DELETE FROM Orcamentos_Itens WHERE ID_Orcamento=" + ID + "";
                SqlCeCommand CMD2 = new SqlCeCommand(comandoSQL2, CONN);
                
                CMD2.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
        public void Cabecalho_Orcamento(string ID, frmOrcamentos Form)
        {
            try
            {
                string SQL = "SELECT * FROM Orcamentos WHERE id='" + ID + "'";

                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        Form.txtNOrcamento.Text = DR["id"].ToString().TrimEnd();
                        Form.txtAbertura.Text = DR["DataAbertura"].ToString().TrimEnd();
                        Form.cboTipoCadastro.Text = DR["TipoCadastro"].ToString().TrimEnd();
                        Form.txtOrcamentista.Text = DR["Orcamentista"].ToString().TrimEnd();
                        Form.txtProprietario.Text = DR["Proprietario"].ToString().TrimEnd();
                        Form.txtCPF_CNPJ.Text = DR["CPF"].ToString().TrimEnd();
                        Form.txtEndereco.Text = DR["Endereco"].ToString().TrimEnd();
                        Form.txtNumero.Text = DR["Endereco_Numero"].ToString().TrimEnd();
                        Form.txtBairro.Text = DR["Bairro"].ToString().TrimEnd();
                        Form.txtCidade.Text = DR["Cidade"].ToString().TrimEnd();
                        Form.cboEstado.Text = DR["Estado"].ToString().TrimEnd();
                        Form.txtCEP.Text = DR["CEP"].ToString().TrimEnd();
                        Form.txtTelefone.Text = DR["Telefone"].ToString().TrimEnd();
                        Form.cboTipoTelefone.Text = DR["TipoTelefone"].ToString().TrimEnd();
                        Form.txtMontadora.Text = DR["Montadora"].ToString().TrimEnd();
                        Form.txtVeiculo.Text = DR["Veiculo"].ToString().TrimEnd();
                        Form.txtMotorizacao.Text = DR["Motorizacao"].ToString().TrimEnd();
                        Form.txtPlaca.Text = DR["Placa"].ToString().TrimEnd();
                        Form.txtKM.Text = DR["KM"].ToString().TrimEnd();
                        Form.txtNChassis.Text = DR["Chassis"].ToString().TrimEnd();
                        Form.txtCor.Text = DR["Cor"].ToString().TrimEnd();
                        Form.txtPintura.Text = DR["Pintura"].ToString().TrimEnd();
                        Form.cboSeguro.Text = DR["Seguro"].ToString().TrimEnd();
                        Form.cboTipoSeguro.Text = DR["TipoSeguro"].ToString().TrimEnd();
                        Form.cboSeguradora.Text = DR["Seguradora"].ToString().TrimEnd();
                        Form.txtFranquia.Text = DR["Franquia"].ToString().TrimEnd();
                        Form.txtNSinistro.Text = DR["Sinistro"].ToString().TrimEnd();

                        Validar_Campos_Cabecalho(Form);
                    }
                }
                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Bloquear_Cabecalho (frmOrcamentos Form)
        {
            Form.txtNOrcamento.Enabled = false;
            Form.txtAbertura.Enabled = false;
            Form.cboTipoCadastro.Enabled = false;
            Form.txtOrcamentista.Enabled = false;
            Form.txtProprietario.Enabled = false;
            Form.txtCPF_CNPJ.Enabled = false;
            Form.txtEndereco.Enabled = false;
            Form.txtNumero.Enabled = false;
            Form.txtBairro.Enabled = false;
            Form.txtCidade.Enabled = false;
            Form.cboEstado.Enabled = false;
            Form.txtCEP.Enabled = false;
            Form.txtTelefone.Enabled = false;
            Form.cboTipoTelefone.Enabled = false;
            Form.txtMontadora.Enabled = false;
            Form.txtVeiculo.Enabled = false;
            Form.txtMotorizacao.Enabled = false;
            Form.txtPlaca.Enabled = false;
            Form.txtKM.Enabled = false;
            Form.txtNChassis.Enabled = false;
            Form.txtCor.Enabled = false;
            Form.txtPintura.Enabled = false;
            Form.cboSeguro.Enabled = false;
            Form.cboTipoSeguro.Enabled = false;
            Form.cboSeguradora.Enabled = false;
            Form.txtFranquia.Enabled = false;
            Form.txtNSinistro.Enabled = false;

            Form.btnProprietario.Visible = false;
            Form.btnOrcamentista.Visible = false;
        }

        public void Colorir_Cabecalho(frmOrcamentos Form)
        {
            Form.cboTipoCadastro.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtOrcamentista.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtProprietario.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtCPF_CNPJ.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtEndereco.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtNumero.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtBairro.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtCidade.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboEstado.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtCEP.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtTelefone.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboTipoTelefone.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtMontadora.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtVeiculo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtMotorizacao.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtPlaca.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtKM.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtNChassis.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtCor.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtPintura.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboSeguro.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboTipoSeguro.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboSeguradora.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtFranquia.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtNSinistro.BackColor = Classe_Tema.TextBox_Edicao;            
        }

        public void Descolorir_Cabecalho(frmOrcamentos Form)
        {
            Form.cboTipoCadastro.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtOrcamentista.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtProprietario.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtCPF_CNPJ.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtEndereco.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtNumero.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtBairro.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtCidade.BackColor = Classe_Tema.TextBox_Normal;
            Form.cboEstado.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtCEP.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtTelefone.BackColor = Classe_Tema.TextBox_Normal;
            Form.cboTipoTelefone.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtMontadora.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtVeiculo.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtMotorizacao.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtPlaca.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtKM.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtNChassis.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtCor.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtPintura.BackColor = Classe_Tema.TextBox_Normal;
            Form.cboSeguro.BackColor = Classe_Tema.TextBox_Normal;
            Form.cboTipoSeguro.BackColor = Classe_Tema.TextBox_Normal;
            Form.cboSeguradora.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtFranquia.BackColor = Classe_Tema.TextBox_Normal;
            Form.txtNSinistro.BackColor = Classe_Tema.TextBox_Normal;
        }

        public void Carregar_Operacoes(ComboBox CBO)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter("SELECT Operacao FROM Orcamentos_Operacoes ORDER BY Operacao ASC", CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Operacao"].ToString().ToUpper().TrimEnd());
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public double Valor_Liquido(string ValorBruto, string Perc_Desconto)
        {
            double LIquido = 0;

            if (Perc_Desconto.Equals(string.Empty))
            {
                Perc_Desconto = "0";
            }

            if (ValorBruto != string.Empty && Perc_Desconto != string.Empty)
            {
                double Bruto = Convert.ToDouble(ValorBruto);
                double Desconto = Convert.ToDouble(Perc_Desconto)/100;

                double Percent = Bruto * Desconto;
                LIquido = Bruto - Percent;
            }
            return LIquido;
        }

        public double Valor_Total(string ValorLiquido, string QUantidade)
        {
            double Total=0;
            
            if (ValorLiquido != string.Empty && QUantidade != string.Empty)
            {
                double Liquido = Convert.ToDouble(ValorLiquido);
                double QNT = Convert.ToDouble(QUantidade);

                Total = Liquido * QNT;
            }
            return Total;
        }

        public void Incluir_ItemOrcamento(string ID_Orcamento, string Operacao, string CodPeca, string Descricao, string QNT, string ValorBruto, string Desconto, 
                                            string ValorLiquido, string ValorTotal, string TipoMO, string ValorRefHora, string Horas, string totalHoras,
                                            string valorRefPintura, string HorasPintura, string totalHorasPintura)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO Orcamentos_Itens(ID_Orcamento,Operacao,Cod_Peca,Descricao,QNT,ValorUN_Bruto,Desconto,ValorUN_Liquido,ValorTotal,Horas,Pintura,MO_ValorRef,MOPintura_ValorRef,MOPintura_Total,MO_Total,TipoMO)" +
                            " VALUES ('" + ID_Orcamento + "','" + Operacao + "','" + CodPeca + "','" + Descricao + "','" + QNT + "','" + ValorBruto + "','" + Desconto + "','" + ValorLiquido + "','" + ValorTotal + "','" + Horas + "','" + HorasPintura + "','" + ValorRefHora + "','" + valorRefPintura + "','" + totalHorasPintura + "','" + totalHoras + "','" + TipoMO + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();     
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Excluir_ItemOrcamento(string ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM Orcamentos_Itens WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Limpar_frmincluirItemOrcamento(frmIncluirItemOrcamento Form)
        {
            Form.cboOperacao.SelectedIndex = -1;
            Form.txtCodFabrica.Clear();
            Form.txtDescricao.Clear();
            Form.txtQnt.Clear();
            Form.txtValorBruto.Clear();
            Form.txtDesconto.Clear();
            Form.txtValorLiquido.Clear();
            Form.txtValorTotal.Clear();
            Form.cboMO.SelectedIndex = -1;
            Form.txtValorRefMO.Clear();
            Form.txtHoraMO.Clear();
            Form.txtValorTotalMO.Clear();
            Form.txtValorMOPintura.Clear();
            Form.txtHoraMOPintura.Clear();
            Form.txtValorTotalMOPintura.Clear();

            Form.cboOperacao.Focus();
        }
    }
}
