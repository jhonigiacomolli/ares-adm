using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using SHARP_INK.Classes;
using System.Drawing;

namespace SHARP_INK.Classes
{
    class Classe_Catalises
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();
        public static string COD_Catalise;
        public string DescricaoItemCatalise;
        public string ValorItemCatalise;
        public double SomaProporcaoCatalise;
        public double TotalCatalise;
        public static string Fabricante;
        public static string Datasheet;
        public static bool StatusBotaoDatasheet;
        public static string NumeroPassadas;
        public static string IntervaloPassadas;
        public static string Secagem_LivrePo;
        public static string Secagem_Toque;
        public static string Secagem_Manuseio;
        public static string Secagem_Total;
        public static string Secagem_Cabine60;
        public static string Secagem_IRCurtas;
        public static string Secagem_IRMedias;


        public void Listar_ItensCatalises(frmCatalises Form, ListView LST, string SQL, double QNt)
        {
            try
            {
                LST.Items.Clear();
                Soma_ProporcaoCatalise(COD_Catalise);
                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        ListViewItem Item = new ListViewItem(DR["id"].ToString());
                        Item.UseItemStyleForSubItems = false;

                        Item.SubItems.Add(DR["COD_Catalise"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Cod_Produto"].ToString().TrimEnd().ToUpper());

                        BUScarDetalhesItemCatalise(DR["Cod_Produto"].ToString().TrimEnd().ToUpper());

                        Item.SubItems.Add(DescricaoItemCatalise);
                        Item.SubItems.Add(DR["Proporcao"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["PesoEspecifico"].ToString().TrimEnd().ToUpper());

                        double PE = Convert.ToDouble(DR["PesoEspecifico"].ToString().TrimEnd());
                        double Prop = Convert.ToDouble(DR["Proporcao"].ToString().TrimEnd());
                        double VolumeEmb = Convert.ToDouble(DR["Volume_Embalagem"].ToString().TrimEnd());
                        double QP = 0;
                        if (QNt.Equals(string.Empty) || QNt.Equals("0")) { Item.SubItems.Add("0,0"); }
                        else
                        {
                            QP = ((QNt / SomaProporcaoCatalise) * Prop) * PE;
                            Item.SubItems.Add(QP.ToString("N1")).Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);

                        }
                        if (QNt.Equals(string.Empty) || QNt.Equals("0")) { Item.SubItems.Add("0,0"); }
                        else
                        {
                            double VP = (Convert.ToDouble(ValorItemCatalise) / (VolumeEmb * PE)) * QP;
                            Item.SubItems.Add(VP.ToString("N2"));
                            TotalCatalise = TotalCatalise + VP;
                        }
                        LST.Items.Add(Item);
                    }
                }
                Form.lblValorCatalise.Text = TotalCatalise.ToString("N2");

                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }


        public void Listar_AditivosCatalises(frmCatalises Form, ListView LST, string SQL, double QNt)
        {
            try
            {
                LST.Items.Clear();
                Soma_ProporcaoCatalise(COD_Catalise);
                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        BUScarDetalhesItemCatalise(DR["Cod_Aditivo"].ToString().TrimEnd().ToUpper());

                        ListViewItem Item = new ListViewItem(DescricaoItemCatalise);
                        Item.UseItemStyleForSubItems = false;

                        Item.SubItems.Add(DR["id"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["COD_Catalise"].ToString().TrimEnd().ToUpper());
                        Item.SubItems.Add(DR["Cod_Aditivo"].ToString().TrimEnd().ToUpper());

                        Item.SubItems.Add(Convert.ToDouble(DR["Proporcao"]).ToString("P1").TrimEnd().ToUpper()).ForeColor = new Classe_Tema().COR_Background_Listview;
                        Item.SubItems.Add(DR["PesoEspecifico"].ToString().TrimEnd().ToUpper());

                        double PE = Convert.ToDouble(DR["PesoEspecifico"].ToString().TrimEnd());
                        double Prop = Convert.ToDouble(DR["Proporcao"].ToString().TrimEnd());
                        double VolumeEmb = Convert.ToDouble(DR["VolumeEmbalagem"].ToString().TrimEnd());
                        double QP = 0;
                        if (QNt.Equals(string.Empty) || QNt.Equals("0")) { Item.SubItems.Add("0,0").ForeColor = new Classe_Tema().COR_Background_Listview; }
                        else
                        {
                            QP = (QNt * Prop) * PE;
                            Item.SubItems.Add(QP.ToString("N1"), new Classe_Tema().COR_Background_Listview, new Classe_Tema().COR_Background_Listview, new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold));

                        }
                        if (QNt.Equals(string.Empty) || QNt.Equals("0")) { Item.SubItems.Add("0,0"); }
                        else
                        {
                            double VP = (Convert.ToDouble(ValorItemCatalise) / (VolumeEmb * PE)) * QP;
                            Item.SubItems.Add(VP.ToString("N2")).ForeColor = new Classe_Tema().COR_Background_Listview;
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
        public void BUScarDetalhesItemCatalise(string Cod)
        {
            try
            {
                DescricaoItemCatalise = string.Empty;
                ValorItemCatalise = string.Empty;

                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT Descricao, ValorVenda FROM Produtos WHERE id='" + Cod + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        DescricaoItemCatalise = DR["Descricao"].ToString().TrimEnd().ToUpper();
                        ValorItemCatalise = DR["ValorVenda"].ToString().TrimEnd().ToUpper();
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
        public void Soma_ProporcaoCatalise(string Cod_Cat)
        {
            try
            {
                SomaProporcaoCatalise = 0;

                DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT Proporcao FROM Catalises WHERE COD_Catalise='" + Cod_Cat + "'");

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    DataRow DR = DT.Rows[i];
                    if (DR.RowState != DataRowState.Deleted)
                    {
                        SomaProporcaoCatalise = SomaProporcaoCatalise + Convert.ToDouble(DR["Proporcao"].ToString().TrimEnd());
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


        public void Get_Catalise_Fabricante(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Fabricante FROM Catalises_Fabricantes ORDER BY Fabricante ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Add("Selecione o FABRICANTE...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Fabricante"].ToString().TrimEnd());
                }

                string SQL2 = "SELECT Fabricante FROM Catalises_Personalizadas_Fabricantes ORDER BY Fabricante ASC";
                DataSet DS2 = new DataSet();
                SqlCeDataAdapter DA2 = new SqlCeDataAdapter(SQL2, CONN);

                DA2.Fill(DS2);
                DataTable Data_Table2 = DS2.Tables[0];

                for (int i = 0; i < Data_Table2.Rows.Count; i++)
                {
                    DataRow DR2 = Data_Table2.Rows[i];
                    CBO.Items.Add(DR2["Fabricante"].ToString().TrimEnd());
                }

                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Catalise_Categoria(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Categoria FROM Catalises_Categorias ORDER BY Categoria ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();
                CBO.Items.Add("Selecione o CATEGORIA...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Categoria"].ToString().TrimEnd());
                }

                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Catalise_Nome(ComboBox CBO)
        {
            try
            {
                string SQL = "SELECT Nome_Catalise FROM Catalises_Nome ORDER BY Nome_Catalise ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();
                CBO.Items.Add("Selecione a CATALISE...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Nome_catalise"].ToString().ToUpper().TrimEnd());
                }

                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Catalise_Nome(ComboBox CBO, string SQL)
        {
            try
            {
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();
                CBO.Items.Add("Selecione a CATALISE...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Nome_catalise"].ToString().ToUpper().TrimEnd());
                }

                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Catalise_Cod(string Nome)
        {
            try
            {
                string SQL = "SELECT * FROM Catalises_Nome WHERE Nome_Catalise='" + Nome + "' ORDER BY Nome_Catalise ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    COD_Catalise = DR["id"].ToString().TrimEnd();
                    Fabricante = DR["Fabricante"].ToString().TrimEnd();
                    Datasheet = DR["Link_DataSheet"].ToString().TrimEnd();
                    NumeroPassadas = DR["NumeroPassadas"].ToString().TrimEnd();
                    IntervaloPassadas = DR["IntervaloPassadas"].ToString().TrimEnd();
                    Secagem_LivrePo = DR["Secagem_LivrePo"].ToString().TrimEnd();
                    Secagem_Toque = DR["Secagem_Toque"].ToString().TrimEnd();
                    Secagem_Manuseio = DR["Secagem_Manuseio"].ToString().TrimEnd();
                    Secagem_Total = DR["Secagem_CuraTotal"].ToString().TrimEnd();
                    Secagem_Cabine60 = DR["Secagem_Cabine60"].ToString().TrimEnd();
                    Secagem_IRCurtas = DR["Secagem_IRcurtas"].ToString().TrimEnd();
                    Secagem_IRMedias = DR["Secagem_IRmedias"].ToString().TrimEnd();
                }
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }



        public void ExibirDataSheet(frmCatalises Form)
        {
            Form.Width = 1150;
            Form.btnDatasheet.BackColor = Color.DarkRed;
            Classe_Catalises.StatusBotaoDatasheet = true;

            if (Classe_Catalises.Datasheet != null)
            {
                Form.webBrowser1.Navigate(Classe_Catalises.Datasheet.ToString());
            }
        }

        public void OcultarDatasheet(frmCatalises Form)
        {
            Form.Width = 670;
            Form.btnDatasheet.BackColor = Color.FromArgb(46, 46, 46);
            Classe_Catalises.StatusBotaoDatasheet = false;
        }

        public void ExibirInfoTec(frmCatalises Form)
        {
            Form.Height = 665;
            Classe_Configuracoes.Infotec = "TRUE";

            Form.txtSecagem_LivrePo.Text = Secagem_LivrePo;
            Form.txtSecagem_Toque.Text = Secagem_Toque;
            Form.txtSecagem_Manuseio.Text = Secagem_Manuseio;
            Form.txtSecagem_Total.Text = Secagem_Total;
            Form.txtSecagem_Cabine.Text = Secagem_Cabine60;
            Form.txtSecagem_IRCurtas.Text = Secagem_IRCurtas;
            Form.txtSecagem_IRmedias.Text = Secagem_IRMedias;
            Form.txtNumeroPassadas.Text = NumeroPassadas;
            Form.txtIntervaloPassadas.Text = IntervaloPassadas;
        }

        public void OcultarInfoTec(frmCatalises Form)
        {
            Form.Height = 550;
            Classe_Configuracoes.Infotec = "FALSE";


        }
    }
}
