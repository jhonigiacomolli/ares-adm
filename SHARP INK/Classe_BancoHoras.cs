using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK
{
    public class Classe_BancoHoras
    {
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
                        if (Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO") || Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL"))
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

                string comandoSQL = "INSERT INTO OrdemServico_BancoHoras(ID_Funcionario,ID_Veiculo,Nome,Funcao,Entrada,MO)" +
                            " VALUES ('" + ID_Funcionario + "','" + ID_Veiculo + "','" + Funcionario + "','" + Funcao + "','" + Entrada + "','" + Valor + "')";

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
            if (Classes_Conexao.Tipo_BancoHoras.Equals("APENAS REGISTRO"))
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
                new Classes_Conexao().Get_Funcao(form.cboFuncao);
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

            DT.Dispose();

        }

        public void CarregaEdicaoApontamento(frmApontamentoFunc Form, string ID_Funcionario, string ID_Veiculo, string Nome, string Funcao, string Entrada, string Saida, string MO)
        {
            Form.txtCodigo.Text = ID_Funcionario;
            Form.txtFuncionario.Text = Nome;
            new Classes_Conexao().Get_Funcao(Form.cboFuncao);
            Form.cboFuncao.SelectedIndex = Form.cboFuncao.FindString(Funcao);

            Form.txtCodigo.BackColor = Classe_Tema.TextBox_Edicao;
            Form.txtFuncionario.BackColor = Classe_Tema.TextBox_Edicao;
            Form.cboFuncao.BackColor = Classe_Tema.TextBox_Edicao;

            if (Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS MANUAL") || Classes_Conexao.Tipo_BancoHoras.Equals("BANCO DE HORAS AUTOMÁTICO"))
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

            Form.ShowDialog();
        }
    }
}
