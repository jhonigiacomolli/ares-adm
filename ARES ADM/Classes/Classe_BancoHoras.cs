using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using ARES_ADM.Classes;

namespace ARES_ADM
{
    public class Classe_BancoHoras
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();
        public static string Tipo_BancoHoras;
        public static double somaLavacao;
        public static double somaDesmontagem;
        public static double somaMontagem;
        public static double somaSolda;
        public static double somaAlinhamento;
        public static double somaFunilaria;
        public static double somaPreparacao;
        public static double somaPintura;
        public static double somaPolimento;
        public static double somaRetrabalho;
        public static double somaHigienização;
        public static double somaEletrica;
        public static double somaMecnica;
        public static double somaGeometria;
        public static double somaEstofaria;

        public void Listar_ApontamentosOS(ListView LST, string SQL)
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
                        Item.SubItems.Add(DR["ID_Funcionario"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["ID_Veiculo"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Nome"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Funcao"].ToString().TrimEnd().ToUpper());
                        if (Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO") || Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
                        {
                            Item.SubItems.Add(DR["Entrada"].ToString().TrimEnd().ToUpper());
                            Item.SubItems.Add(DR["Saida"].ToString().TrimEnd().ToUpper());
                            Item.SubItems.Add(DR["Tempo"].ToString().TrimEnd().ToUpper());
                            if (DR["Valor"].ToString() != string.Empty) { Item.SubItems.Add(Convert.ToDecimal(DR["Valor"].ToString().TrimEnd().ToUpper()).ToString("N2")); } else { Item.SubItems.Add(""); }
                            Item.SubItems.Add(DR["MO"].ToString().TrimEnd().ToUpper());
                        }
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
        public void Apontar_Funcionario(string ID_Veiculo, string ID_Funcionario, string Funcionario, string Funcao, string Entrada, string Valor)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_BancoHoras(ID_Funcionario,ID_Veiculo,Nome,Funcao,Entrada,MO,Valor)" +
                            " VALUES ('" + ID_Funcionario + "','" + ID_Veiculo + "','" + Funcionario + "','" + Funcao + "','" + Entrada + "','" + Valor + "','0')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Apontamento", "Funcionário apontado com sucesso!");
                messagebox.ShowDialog();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }

        }
        public void Apontar_Funcionario(string ID_Veiculo, string ID_Funcionario, string Funcionario, string Funcao, string Entrada, string Saida, double MO)
        {
            try
            {
                DateTime entrada = Convert.ToDateTime(Entrada);
                DateTime saida = Convert.ToDateTime(Saida);
                TimeSpan Tempo = saida.Subtract(entrada);

                double valor = Tempo.TotalHours * MO;

                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_BancoHoras(ID_Funcionario,ID_Veiculo,Nome,Funcao,Entrada,Saida,Valor,Tempo,MO)" +
                            " VALUES ('" + ID_Funcionario + "','" + ID_Veiculo + "','" + Funcionario + "','" + Funcao + "','" + Entrada + "','" + saida + "','" + valor + "','" + Tempo + "','" + MO + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Apontamento", "Funcionário apontado com sucesso!");
                messagebox.ShowDialog();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }

        }

        public void Editar_Apontamento(string ID, string ID_Funcionario, string ID_Veiculo, string Nome, string Funcao, string Entrada, string Saida, double MO)
        {
            if (Tipo_BancoHoras.Equals("APENAS REGISTRO"))
            {
                try
                {
                    SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                    string comandoSQL = "UPDATE OrdemServico_BancoHoras SET ID_Funcionario='" + ID_Funcionario.Replace("'", "''") + "', ID_Veiculo='" + ID_Veiculo + "', Nome='" + Nome + "', Funcao='" + Funcao + "' WHERE id='" + ID + "'";

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
            else
            {
                try
                {
                    TimeSpan Tempo = Convert.ToDateTime(Saida).Subtract(Convert.ToDateTime(Entrada));
                    double Valor = Tempo.TotalHours * MO;

                    SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                    string comandoSQL = "UPDATE OrdemServico_BancoHoras SET ID_Funcionario='" + ID_Funcionario.Replace("'", "''") + "', ID_Veiculo='" + ID_Veiculo + "', Nome='" + Nome + "', Funcao='" + Funcao + "', Entrada='" + Entrada + "', Saida='" + Saida + "', Valor='" + Valor + "', Tempo='" + Tempo + "', MO='" + MO + "' WHERE id='" + ID + "'";

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
        }

        public void Exluir_Apontamento(int ID)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "DELETE FROM OrdemServico_BancoHoras WHERE id=" + ID + "";
                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Excluão", "Apontamento excluido com sucesso!");
                messagebox.Show();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Liberar_Funcionario(string ID, string Entrada, string Saida, double MO)
        {
            try
            {
                DateTime entrada = Convert.ToDateTime(Entrada);
                DateTime saida = Convert.ToDateTime(Saida);
                TimeSpan Tempo = saida.Subtract(entrada);

                double valor = Tempo.TotalHours * MO;

                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "UPDATE OrdemServico_BancoHoras SET Saida='" + Saida.Replace("'", "''") + "', Tempo='" + Tempo + "', Valor='" + valor + "' WHERE id='" + ID + "'";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Liberação", "Funcionario liberado de sua função com sucesse");
                messagebox.ShowDialog();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:\n" + ex.Message);
                Messagebox.Show();
            }
        }

        public bool VerificaApontamento(frmApontamentoFunc form, string ID_Funcionario)
        {
            string Saida = string.Empty;
            string TESTE = "TRUE";
            string Nome = string.Empty;
            string Veiculo = string.Empty;

            string SQL = "SELECT * FROM OrdemServico_BancoHoras WHERE ID_Funcionario='" + ID_Funcionario + "'";
            DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                DataRow DR = DT.Rows[i];
                if (DR.RowState != DataRowState.Deleted)
                {
                    Saida = DR["Saida"].ToString().TrimEnd();
                    Nome = DR["Nome"].ToString().TrimEnd();
                    Veiculo = DR["ID_Veiculo"].ToString().TrimEnd();

                    if (Saida.Equals(string.Empty)) { TESTE = string.Empty; }
                }
            }

            if (TESTE.Equals(string.Empty))
            {
                Form messagebox = new frmMensagemBox(Classe_Mensagem.ALERTA, "Funcionário Apontado", "O funcionário: " + Nome + "\nEsta apontado na OS Nº: " + Veiculo);
                messagebox.ShowDialog();
                form.txtCodigo.Clear();
                form.txtFuncionario.Clear();
                form.cboFuncao.Items.Clear();
                Get_Funcao(form.cboFuncao);
                form.txtEntrada.Text = "";
                form.txtHoraEntrada.Clear();
                form.txtSaida.Text = "";
                form.txtHoraSaida.Clear();
                form.txtValorHora.Clear();
                form.txtCodigo.Select();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CarregaEdicaoApontamento(frmApontamentoFunc Form, string ID_Funcionario, string ID_Veiculo, string Nome, string Funcao, string Entrada, string Saida, string MO)
        {
            Form.txtCodigo.Text = ID_Funcionario;
            Form.txtFuncionario.Text = Nome;
            Get_Funcao(Form.cboFuncao);
            Form.cboFuncao.SelectedIndex = Form.cboFuncao.FindString(Funcao);

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtFuncionario.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboFuncao.BackColor = Classe_Tema.TextBox_Edicao;

            if (Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL") || Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
            {
                Form.txtEntrada.Value = Convert.ToDateTime(Entrada);
                Form.txtHoraEntrada.Text = Convert.ToDateTime(Entrada).ToLongTimeString();
                if (Saida != string.Empty) { Form.txtSaida.Value = Convert.ToDateTime(Saida); }
                if (Saida != string.Empty) { Form.txtHoraSaida.Text = Convert.ToDateTime(Saida).ToLongTimeString(); }
                Form.txtValorHora.Text = MO;

                Form.txtEntrada.CalendarMonthBackground = Classe_Tema.TextBox_Edicao;
                Form.txtHoraEntrada.BackColor = Classe_Tema.TextBox_Edicao;
                Form.txtSaida.CalendarMonthBackground = Classe_Tema.TextBox_Edicao;
                Form.txtHoraSaida.BackColor = Classe_Tema.TextBox_Edicao;
                Form.txtValorHora.BackColor = Classe_Tema.TextBox_Edicao;
            }

            Form.btnGravar.Text = "Alterar";
            Form.ShowDialog();
        }

        public void Soma_Categorias(frmOrdemServico frmOS, string ID_Veiculo)
        {
            string Funcao = "";
            somaLavacao=0;
            somaDesmontagem = 0;
            somaMontagem = 0;
            somaSolda = 0;
            somaAlinhamento = 0;
            somaFunilaria = 0;
            somaPreparacao = 0;
            somaPintura = 0;
            somaPolimento = 0;
            somaRetrabalho = 0;
            somaHigienização = 0;
            somaEletrica = 0;
            somaMecnica = 0;
            somaGeometria = 0;
            somaEstofaria = 0;

            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT * FROM OrdemServico_BancoHoras WHERE ID_Veiculo='" + ID_Veiculo + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        Funcao = DR["Funcao"].ToString().TrimEnd().ToUpper();

                        if (Funcao.Equals("LAVAÇÃO"))
                        {
                            somaLavacao = somaLavacao + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("DESMONTAGEM"))
                        {
                            somaDesmontagem = somaDesmontagem + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("MONTAGEM"))
                        {
                            somaMontagem = somaMontagem + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("SOLDA"))
                        {
                            somaSolda = somaSolda + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("ALINHAMENTO"))
                        {
                            somaAlinhamento = somaAlinhamento + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("FUNILARIA"))
                        {
                            somaFunilaria = somaFunilaria + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("PREPARAÇÃO"))
                        {
                            somaPreparacao = somaPreparacao + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("PINTURA"))
                        {
                            somaPintura = somaPintura + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("POLIMENTO"))
                        {
                            somaPolimento = somaPolimento + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("RETRABALHO"))
                        {
                            somaRetrabalho = somaRetrabalho + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("HIGIENIZAÇÃO"))
                        {
                            somaHigienização = somaHigienização + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("ELÉTRICA"))
                        {
                            somaEletrica = somaEletrica + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("MECÂNICA"))
                        {
                            somaMecnica = somaMecnica + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("GEOMETRIA"))
                        {
                            somaGeometria = somaGeometria + Convert.ToDouble(DR["Valor"]);
                        }
                        if (Funcao.Equals("ESTOFARIA"))
                        {
                            somaEstofaria = somaEstofaria + Convert.ToDouble(DR["Valor"]);
                        }
                    }
                }
                DT.Dispose();

                frmOS.lblSomaLavação.Text = Classe_BancoHoras.somaLavacao.ToString("N2");
                frmOS.lblSomaDesmontagem.Text = Classe_BancoHoras.somaDesmontagem.ToString("N2");
                frmOS.lblSomaMontagem.Text = Classe_BancoHoras.somaMontagem.ToString("N2");
                frmOS.lblSomaSolda.Text = Classe_BancoHoras.somaSolda.ToString("N2");
                frmOS.lblSomaAlinhamento.Text = Classe_BancoHoras.somaAlinhamento.ToString("N2");
                frmOS.lblSomaFunilaria.Text = Classe_BancoHoras.somaFunilaria.ToString("N2");
                frmOS.lblSomaPreparacao.Text = Classe_BancoHoras.somaPreparacao.ToString("N2");
                frmOS.lblSomaPintura.Text = Classe_BancoHoras.somaPintura.ToString("N2");
                frmOS.lblSomaPolimento.Text = Classe_BancoHoras.somaPolimento.ToString("N2");
                frmOS.lblSomaRetrabalho.Text = Classe_BancoHoras.somaRetrabalho.ToString("N2");
                frmOS.lblSomaHgienizacao.Text = Classe_BancoHoras.somaHigienização.ToString("N2");
                frmOS.lblSomaEletrica.Text = Classe_BancoHoras.somaEletrica.ToString("N2");
                frmOS.lblSomaMecanica.Text = Classe_BancoHoras.somaMecnica.ToString("N2");
                frmOS.lblSomaGeometria.Text = Classe_BancoHoras.somaGeometria.ToString("N2");
                frmOS.lblSomaEstofaria.Text = Classe_BancoHoras.somaEstofaria.ToString("N2");
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }

        public void Get_TipoBanco()
        {
            try
            {
                string SQL = "SELECT TipoBancoHoras FROM Configuracoes";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    Tipo_BancoHoras = DR["TipoBancoHoras"].ToString().TrimEnd();
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_FiltroApontamento(ComboBox CBO, string Filtro)
        {
            CBO.Items.Clear();
            try
            {
                if (Filtro.Equals("Funcionário"))
                {
                    string SQL = "SELECT Nome FROM Funcionarios ORDER BY Nome ASC";
                    SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                    DataSet DS = new DataSet();
                    SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                    DA.Fill(DS);
                    DataTable Data_Table = DS.Tables[0];

                    CBO.Items.Add("Selecione o funcionário");

                    for (int i = 0; i < Data_Table.Rows.Count; i++)
                    {
                        DataRow DR = Data_Table.Rows[i];
                        CBO.Items.Add(DR["Nome"].ToString().TrimEnd());
                    }
                }
                if (Filtro.Equals("Função"))
                {
                    string SQL = "SELECT * FROM Funcionarios_Funcao ORDER BY Funcao ASC";
                    SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                    DataSet DS = new DataSet();
                    SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                    DA.Fill(DS);
                    DataTable Data_Table = DS.Tables[0];

                    CBO.Items.Add("Selecione a função");

                    for (int i = 0; i < Data_Table.Rows.Count; i++)
                    {
                        DataRow DR = Data_Table.Rows[i];
                        CBO.Items.Add(DR["Funcao"].ToString().TrimEnd());
                    }
                }
                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Funcao(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT * FROM Funcionarios_Funcao ORDER BY Funcao ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Add("Selecione a função");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Funcao"].ToString().TrimEnd());
                }
                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
        public void Get_Funcionario(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Nome FROM Funcionarios ORDER BY Nome ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Add("Selecione o campo de filtro");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Funcao"].ToString().TrimEnd());
                }

                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void GraicoApontamento(frmOrdemServico Form)
        {
            double lavacao = Convert.ToDouble(Form.lblSomaLavação.Text);
            double desmontagem = Convert.ToDouble(Form.lblSomaDesmontagem.Text);
            double montagem = Convert.ToDouble(Form.lblSomaMontagem.Text);
            double solda = Convert.ToDouble(Form.lblSomaSolda.Text);
            double alinhamento = Convert.ToDouble(Form.lblSomaAlinhamento.Text);
            double funilaria = Convert.ToDouble(Form.lblSomaFunilaria.Text);
            double preparacao = Convert.ToDouble(Form.lblSomaPreparacao.Text);
            double pintura = Convert.ToDouble(Form.lblSomaPintura.Text);
            double polimento = Convert.ToDouble(Form.lblSomaPolimento.Text);
            double retrabalho = Convert.ToDouble(Form.lblSomaRetrabalho.Text);
            double higienizacao = Convert.ToDouble(Form.lblSomaHgienizacao.Text);
            double eletrica = Convert.ToDouble(Form.lblSomaEletrica.Text);
            double mecanica = Convert.ToDouble(Form.lblSomaMecanica.Text);
            double geometria = Convert.ToDouble(Form.lblSomaGeometria.Text);
            double estofaria = Convert.ToDouble(Form.lblSomaEstofaria.Text);
            double total = lavacao + desmontagem + montagem + solda + alinhamento + funilaria + preparacao + pintura + polimento + retrabalho + higienizacao + eletrica + mecanica + geometria + estofaria;

            Form.Grafico_Apontamentos.Series["Dados"].Points.Clear();
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Lavação", lavacao / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Desmontagem", desmontagem / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Montagem", montagem / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Solda", solda / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Alinhamento", alinhamento / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Funilaria", funilaria / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Preparação", preparacao / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Pintura", pintura / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Polimento", polimento / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Retrabalho", retrabalho / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Higienização", alinhamento / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Elétrica", eletrica / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Mecânica", mecanica / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Geometria", geometria / total);
            Form.Grafico_Apontamentos.Series["Dados"].Points.AddXY("Estofaria", estofaria / total);
        }
    }
}
