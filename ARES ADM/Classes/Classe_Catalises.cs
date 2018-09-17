using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using ARES_ADM.Classes;
using System.Drawing;

namespace ARES_ADM.Classes
{
    class Classe_Catalises
    {
        public string strConnDatabase = Classes_Conexao.strConnDatabase.ToString();
        public static string COD_Catalise;
        public string DescricaoItemCatalise;
        public string ValorItemCatalise;
        public double SomaProporcaoCatalise;
        public double TotalCatalise;
        public static string TipoBD;
        public static string Fabricante;
        public static string Datasheet;
        public static string DatasheetIndisponivel = @"D:\Projeto Auto Sharp\SHARP INK\SHARP INK\Imagens\DatasheetIndisponivel.jpg";
        public static bool StatusBotaoDatasheet;
        public static bool VideoAplicacao;
        public static string LinkVideoAplicacao;
        public static bool StatusBotaoVideo;
        public static string NumeroPassadas;
        public static string IntervaloPassadas;
        public static string Secagem_LivrePo;
        public static string Secagem_Toque;
        public static string Secagem_Manuseio;
        public static string Secagem_Total;
        public static string Secagem_Cabine60;
        public static string Secagem_IRCurtas;
        public static string Secagem_IRMedias;


        public void Listar_ItensCatalises(frmCatalises Form, ListView LST, double QNt)
        {
            try
            {
                LST.Items.Clear();
                Soma_ProporcaoCatalise(COD_Catalise);

                //Lista os items para cada catalise do BD Original.
                if (TipoBD != null && TipoBD.Equals("ORIGINAL"))
                {
                    string SQL = "SELECT * FROM Catalises WHERE COD_Catalise='" + COD_Catalise + "'";

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

                //Lista os items para cada catalise do BD Personalizado.
                if (TipoBD != null && TipoBD.Equals("PERSONALIZADO"))
                {
                    string SQL = "SELECT * FROM Catalises_Personalizadas WHERE COD_Catalise='" + COD_Catalise + "'";

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
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }


        public void Listar_AditivosCatalises(frmCatalises Form, ListView LST, double QNt)
        {
            try
            {
                LST.Items.Clear();
                Soma_ProporcaoCatalise(COD_Catalise);
                
                //Lista os aditivos para cada catalise do BD Original.
                if (TipoBD != null && TipoBD.Equals("ORIGINAL"))
                {
                    string SQL = "SELECT * FROM Catalises_Aditivos WHERE COD_Catalise='" + COD_Catalise + "'";

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

                //Lista os aditivos para cada catalise do BD Personalizado.
                if (TipoBD != null && TipoBD.Equals("PERSONALIZADO"))
                {
                    string SQL = "SELECT * FROM Catalises_Personalizadas_Aditivos WHERE COD_Catalise='" + COD_Catalise + "'";

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
                
                if (TipoBD!=null && TipoBD.Equals("ORIGINAL"))
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
                if (TipoBD != null && TipoBD.Equals("PERSONALIZADO"))
                {
                    SomaProporcaoCatalise = 0;

                    DataTable DT = Classes_Conexao.Preenche_DataTable("SELECT Proporcao FROM Catalises_Personalizadas WHERE COD_Catalise='" + Cod_Cat + "'");

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
                // Pesquisa de Fabricantes no BD Original do sistema
                string SQL = "SELECT Fabricante FROM Catalises_Fabricantes ORDER BY Fabricante ASC";
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Add(" Selecione o FABRICANTE...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Fabricante"].ToString().TrimEnd());
                }

                // Pesquisa de Fabricantes no BD Personalizado do cliente 
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

                CBO.Sorted = true;
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
                CBO.Items.Add(" Selecione o CATEGORIA...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(DR["Categoria"].ToString().TrimEnd());
                }

                CBO.Sorted = true;
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
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);

                CBO.Items.Clear();
                CBO.Items.Add(" Selecione a CATALISE...");

                // Lista Catalises Cadastradas no BD Original do Sistema.
                if (Classe_Configuracoes.CatalisesOriginais.Equals("TRUE"))
                {
                    string SQL = "SELECT Nome_Catalise FROM Catalises_Nome ORDER BY Nome_Catalise ASC";                    
                    DataSet DS = new DataSet();
                    SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL, CONN);

                    DA.Fill(DS);
                    DataTable Data_Table = DS.Tables[0];                    

                    for (int i = 0; i < Data_Table.Rows.Count; i++)
                    {
                        DataRow DR = Data_Table.Rows[i];
                        CBO.Items.Add(string.Concat("▐  ", DR["Nome_catalise"].ToString().ToUpper().TrimEnd()));
                    }
                }
                // LIsta Catalises Cadastradas no BD Personalizado do Cliente.
                string SQL2 = "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome ORDER BY Nome_Catalise ASC";
                DataSet DS2 = new DataSet();
                SqlCeDataAdapter DA2 = new SqlCeDataAdapter(SQL2, CONN);

                DA2.Fill(DS2);
                DataTable Data_Table2 = DS2.Tables[0];
                
                for (int i = 0; i < Data_Table2.Rows.Count; i++)
                {
                    DataRow DR2 = Data_Table2.Rows[i];
                    CBO.Items.Add(string.Concat(DR2["Nome_catalise"].ToString().ToUpper().TrimEnd()));
                }

                CBO.Sorted = true;
                CBO.SelectedIndex = 0;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_Catalise_Nome(ComboBox CBO, string SQL1, string SQL2)
        {
            try
            {
                // Lista Catalises Cadastradas no BD Original do Sistema.
                SqlCeConnection CONN = new SqlCeConnection(strConnDatabase);
                DataSet DS = new DataSet();
                SqlCeDataAdapter DA = new SqlCeDataAdapter(SQL1, CONN);

                DA.Fill(DS);
                DataTable Data_Table = DS.Tables[0];

                CBO.Items.Clear();
                CBO.Items.Add(" Selecione a CATALISE...");

                for (int i = 0; i < Data_Table.Rows.Count; i++)
                {
                    DataRow DR = Data_Table.Rows[i];
                    CBO.Items.Add(string.Concat("▐  ", DR["Nome_catalise"].ToString().ToUpper().TrimEnd()));
                }

                // LIsta Catalises Cadastradas no BD Personalizado do Cliente.
                DataSet DS2 = new DataSet();
                SqlCeDataAdapter DA2 = new SqlCeDataAdapter(SQL2, CONN);

                DA2.Fill(DS2);
                DataTable Data_Table2 = DS2.Tables[0];
                
                for (int i = 0; i < Data_Table2.Rows.Count; i++)
                {
                    DataRow DR2 = Data_Table2.Rows[i];
                    CBO.Items.Add(DR2["Nome_catalise"].ToString().ToUpper().TrimEnd());
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
                string SQL = "SELECT * FROM Catalises_Nome WHERE Nome_Catalise='" + Nome.Trim(new char[] { ' ', '▐' }) + "' ORDER BY Nome_Catalise ASC";
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
                    TipoBD = DR["Tipo_BD"].ToString().TrimEnd();
                    Datasheet = DR["Link_DataSheet"].ToString().TrimEnd();
                    LinkVideoAplicacao = DR["Link_VideoAplicacao"].ToString().TrimEnd();
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

                StatusBotaoVideo = true;
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }

        public void Get_CatalisePersonalizada_Cod(string Nome)
        {
            try
            {
                string SQL = "SELECT * FROM Catalises_Personalizadas_Nome WHERE Nome_Catalise='" + Nome + "' ORDER BY Nome_Catalise ASC";
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
                    TipoBD = DR["Tipo_BD"].ToString().TrimEnd();
                    Datasheet = string.Empty;
                    LinkVideoAplicacao = string.Empty;
                    NumeroPassadas = string.Empty;
                    IntervaloPassadas = string.Empty;
                    Secagem_LivrePo = string.Empty;
                    Secagem_Toque = string.Empty;
                    Secagem_Manuseio = string.Empty;
                    Secagem_Total = string.Empty;
                    Secagem_Cabine60 = string.Empty;
                    Secagem_IRCurtas = string.Empty;
                    Secagem_IRMedias = string.Empty;
                }
                StatusBotaoVideo = false;
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
            Form.Height = 650;
            Form.btnDatasheet.BackColor = Color.DarkRed;
            StatusBotaoDatasheet = true;

            if (Datasheet != null)
            {
                Form.webBrowser1.Navigate(Datasheet);
            }
            if (Datasheet == null || Datasheet.Equals(string.Empty))
            {
                Form.webBrowser1.Navigate(DatasheetIndisponivel);
            }
        }

        public void OcultarDatasheet(frmCatalises Form)
        {
            Form.Width = 670;
            if (Classe_Configuracoes.Infotec.Equals("FALSE")){ Form.Height = 550; }
            Form.btnDatasheet.BackColor = Color.FromArgb(46, 46, 46);
            StatusBotaoDatasheet = false;
        }

        public void ExibirInfoTec(frmCatalises Form)
        {
            Form.Height = 650;
            Form.btnInfotec.BackColor = Color.DarkRed;
            Classe_Configuracoes.Infotec = "TRUE";
            Form.pnInfoTec.Visible = true;

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
            if (StatusBotaoDatasheet.Equals(false)) { Form.Height = 550; }
            Form.btnInfotec.BackColor = Color.FromArgb(46,46,46);
            Classe_Configuracoes.Infotec = "FALSE";
            Form.pnInfoTec.Visible = false;


        }
        public void Exibir_VideoPlayer(frmCatalises Form)
        {
            Form.pnPesagemCatalise.Visible = false;
            Form.pnVideoAplicacao.Visible = true;

            VideoAplicacao = true;

            Form.btnVideoAplicacao.BackColor = Color.DarkRed;

            //Form.VideoPlayer.URL = @"C:\Users\Jhoni Giacomolli\Downloads\NASIOL Brasil - Auto - MetalCoat Formula2- Aplicação.mp4";
            Form.VideoPlayer.URL = LinkVideoAplicacao;
            Form.VideoPlayer.Ctlcontrols.play();

      }

        public void Ocultar_VieoPlayer(frmCatalises Form)
        {
            Form.pnPesagemCatalise.Visible = true;
            Form.pnVideoAplicacao.Visible = false;

            VideoAplicacao = false;

            Form.btnVideoAplicacao.BackColor = Color.FromArgb(46,46,46);

            Form.VideoPlayer.Ctlcontrols.stop();
            Form.VideoPlayer.currentPlaylist.clear();

        }

        public void Redefinir_CataliseOS(frmCatalises Form, frmOrdemServico FormOS)
        {
            Form.btnDatasheet.Dispose();
            Form.btnInfotec.Dispose();
            Form.btnVideoAplicacao.Dispose();
            Form.pnCabecalho.Dispose();        

            Form.pnPesagemCatalise.Location = new Point(23, 130);
            Form.pnImagem.Location = new Point(0, 0);
            Form.pnImagem.Size = new Size(200, 120);
            Form.picLogoFabricante.Visible=false;
            Form.picImagemCatalise.Location = new Point(57, 15);
            Form.btnInserirNaOS.Visible = true;
            Form.btnCancelar.Visible = true;
            Form.Height = 480;
            
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            FormOS.pnCatalise.Controls.Add(Form);
            FormOS.pnCatalise.Visible = true;
            FormOS.pnItensOS.Visible=false;

            FormOS.btnPainelFuncionarios.Enabled = false;
            FormOS.btnPainelGeral.Enabled = false;
            FormOS.btnPainelGrafico.Enabled = false;
            FormOS.btnPainelPecas.Enabled = false;
            
            Form.Show();
        }

        public void InserirCatalise_OS(frmOrdemServico FormOS, string ID, string Descricao, string Quantidade, string Valor)
        {
            double Unitario;
            double Total = Convert.ToDouble(Valor);
            double QNT = Convert.ToDouble(Quantidade);

            Unitario = (Total / QNT) * 1000;
            QNT = QNT / 1000;

            try
            {
                SqlCeConnection CONN = new SqlCeConnection(Classes_Conexao.strConnDatabase);

                string comandoSQL = "INSERT INTO OrdemServico_Itens(ID_Veiculo,Categoria,CodigoProduto,Descricao,Quantidade,ValorUnitario,ValorTotal)" +
                            " VALUES ('" + ID + "','CATALISES','','" + Descricao.Trim(new char[] { ' ', '▐' }) + "','" + QNT + "','" + Unitario + "','" + Valor + "')";

                SqlCeCommand CMD = new SqlCeCommand(comandoSQL, CONN);

                CONN.Open();
                CMD.ExecuteNonQuery();
                CONN.Close();

                Form Messagebox2 = new frmMensagemBox(Classe_Mensagem.ALERTA, "Inclusão", "A catalise foi incluida com sucesso!");
                Messagebox2.ShowDialog();

                FormOS.AtualizaDadosGeral();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex.Message);
                Messagebox.Show();
            }
        }
    }
}
