using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHARP_INK.Classes;
using SHARP_INK.Properties;


namespace SHARP_INK
{
    public partial class frmCatalises : Form
    {
        bool mouseDown;
        Point lastLocation;

        public frmCatalises()
        {
            InitializeComponent();
            
            new Classe_Tema().TEMA_frmCatalises(this);
            new Classe_Configuracoes().Leitura_Configuracoes();
            new Classe_Catalises().Get_Catalise_Fabricante(cboFabricante);
            new Classe_Catalises().Get_Catalise_Categoria(cboCategoria);
            new Classe_Catalises().Get_Catalise_Nome(cboCatalise);

            new Classe_Listviews().Criar_LST_Catalise(lstCatalises);
            new Classe_Listviews().Criar_LST_AditivosCatalise(lstAditivosCatalise);

            if (Classe_Configuracoes.Infotec.Equals("TRUE"))
            {
                new Classe_Catalises().ExibirInfoTec(this);
            }
            if (Classe_Configuracoes.Infotec.Equals("FALSE"))
            {
                new Classe_Catalises().OcultarInfoTec(this);
            }

            if (Classe_Configuracoes.Datasheet.Equals("TRUE"))
            {
                new Classe_Catalises().ExibirDataSheet(this);
            }
            if (Classe_Configuracoes.Datasheet.Equals("FALSE"))
            {
                new Classe_Catalises().OcultarDatasheet(this);
            }

            if (Classe_Configuracoes.ValorCatalises.Equals("TRUE")) { lblValorCatalise.Visible = true; } else { lblValorCatalise.Visible = false; }
            if (Classe_Configuracoes.ValorCatalises.Equals("FALSE")) { lblTituloValorCatalise.Text = string.Empty; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            VideoPlayer.Ctlcontrols.stop();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            VideoPlayer.Ctlcontrols.stop();
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


        private void cboFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAditivosCatalise.Items.Clear();
            lstCatalises.Items.Clear();

            if (cboFabricante.Text != " Selecione o FABRICANTE...")
            {
                picLogoFabricante.BackgroundImage = (Image)Resources.ResourceManager.GetObject(cboFabricante.Text);
            }

            if (cboFabricante.Text != " Selecione o FABRICANTE..." && cboCategoria.Text.Equals(" Selecione o CATEGORIA..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text != " Selecione o CATEGORIA..." && cboFabricante.Text.Equals(" Selecione o FABRICANTE..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Categoria='" + cboCategoria.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Categoria='" + cboCategoria.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text != " Selecione o CATEGORIA..." && cboFabricante.Text != " Selecione o FABRICANTE...")
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Categoria='" + cboCategoria.Text + "' AND Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Categoria='" + cboCategoria.Text + "' AND Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text.Equals(" Selecione o CATEGORIA...") && cboFabricante.Text.Equals(" Selecione o FABRICANTE..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome ORDER BY Nome_Catalise ASC");
            }


            lstCatalises.Select();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAditivosCatalise.Items.Clear();
            lstCatalises.Items.Clear();

            if (cboFabricante.Text != " Selecione o FABRICANTE..." && cboCategoria.Text.Equals(" Selecione o CATEGORIA..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text != " Selecione o CATEGORIA..." && cboFabricante.Text.Equals(" Selecione o FABRICANTE..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Categoria='" + cboCategoria.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Categoria='" + cboCategoria.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text != " Selecione o CATEGORIA..." && cboFabricante.Text != " Selecione o FABRICANTE...")
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome WHERE Categoria='" + cboCategoria.Text + "' AND Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome WHERE Categoria='" + cboCategoria.Text + "' AND Fabricante='" + cboFabricante.Text + "' ORDER BY Nome_Catalise ASC");
            }
            if (cboCategoria.Text.Equals(" Selecione o CATEGORIA...") && cboFabricante.Text.Equals(" Selecione o FABRICANTE..."))
            {
                new Classe_Catalises().Get_Catalise_Nome(cboCatalise, "SELECT Nome_Catalise FROM Catalises_Nome ORDER BY Nome_Catalise ASC", "SELECT Nome_Catalise FROM Catalises_Personalizadas_Nome ORDER BY Nome_Catalise ASC");
            }

            lstCatalises.Select();
        }

        private void cboCatalise_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classe_Catalises.COD_Catalise = null;
            Classe_Catalises.Fabricante = null;
            Classe_Catalises.Datasheet=null;

            txtQuantidade.Text = "0,0";

            

            new Classe_Catalises().Get_Catalise_Cod(cboCatalise.Text.Trim(new char[] { ' ', '▐' }));
            if (Classe_Catalises.COD_Catalise != null && txtQuantidade.Text != string.Empty)
            {
                new Classe_Catalises().Listar_ItensCatalises(this, lstCatalises, Double.Parse(txtQuantidade.Text));
                if (cboCatalise.Text != " Selecione a CATALISE...") { new Classe_Catalises().Listar_AditivosCatalises(this, lstAditivosCatalise, Double.Parse(txtQuantidade.Text)); } else { lstAditivosCatalise.Items.Clear(); }
            }
            if (Classe_Catalises.COD_Catalise == null && cboCatalise.Text != " Selecione a CATALISE...")
            {
                new Classe_Catalises().Get_CatalisePersonalizada_Cod(cboCatalise.Text);
                new Classe_Catalises().Listar_ItensCatalises(this, lstCatalises, Convert.ToDouble(txtQuantidade.Text));
                if (cboCatalise.Text != " Selecione a CATALISE...") { new Classe_Catalises().Listar_AditivosCatalises(this, lstAditivosCatalise, Double.Parse(txtQuantidade.Text)); } else { lstAditivosCatalise.Items.Clear(); }
            }

            if (cboCatalise.Text != " Selecione a CATALISE...")
            {
                picImagemCatalise.BackgroundImage = (Image)Resources.ResourceManager.GetObject(cboCatalise.Text.Trim(new char[] { ' ', '▐' }));
                if (Classe_Catalises.TipoBD != null && Classe_Catalises.TipoBD.Equals("ORIGINAL"))
                {
                    if (Classe_Catalises.Fabricante != null) { picLogoFabricante.BackgroundImage = (Image)Resources.ResourceManager.GetObject(Classe_Catalises.Fabricante); }
                }
                if (Classe_Catalises.TipoBD != null && Classe_Catalises.TipoBD.Equals("PERSONALIZADO"))
                {
                    picLogoFabricante.BackgroundImage = null;
                    picImagemCatalise.BackgroundImage = Resources.SEMIMAGEM;
                }
                if (Classe_Catalises.StatusBotaoDatasheet.Equals(true))
                {
                    if (Classe_Catalises.Datasheet != null)
                    {
                        webBrowser1.Navigate(Classe_Catalises.Datasheet);
                    }
                    if (Classe_Catalises.Datasheet == null || Classe_Catalises.Datasheet.Equals(string.Empty))
                    {
                        webBrowser1.Navigate(Classe_Catalises.DatasheetIndisponivel);
                    }
                }
                if (Classe_Catalises.StatusBotaoVideo.Equals(true))
                {
                    if (Classe_Catalises.VideoAplicacao.Equals(true))
                    {
                        new Classe_Catalises().Ocultar_VieoPlayer(this);
                    }
                    btnVideoAplicacao.Enabled = true;
                }
                if (Classe_Catalises.StatusBotaoVideo.Equals(false))
                {
                    new Classe_Catalises().Ocultar_VieoPlayer(this);
                    btnVideoAplicacao.Enabled = false;
                }
            }
            if (cboCatalise.Text.Equals(" Selecione a CATALISE..."))
            {
                lstCatalises.Items.Clear();
                lstAditivosCatalise.Items.Clear();
                picImagemCatalise.BackgroundImage = Resources.SEMIMAGEM;

                if (cboFabricante.Text.Equals(" Selecione o FABRICANTE..."))
                {
                    picLogoFabricante.BackgroundImage = null;
                }
                
                Classe_Catalises.NumeroPassadas = string.Empty;
                Classe_Catalises.IntervaloPassadas = string.Empty;
                Classe_Catalises.Secagem_LivrePo = string.Empty;
                Classe_Catalises.Secagem_Manuseio = string.Empty;
                Classe_Catalises.Secagem_Toque = string.Empty;
                Classe_Catalises.Secagem_Total = string.Empty;
                Classe_Catalises.Secagem_Cabine60 = string.Empty;
                Classe_Catalises.Secagem_IRCurtas = string.Empty;
                Classe_Catalises.Secagem_IRMedias = string.Empty;
            }
            if (Classe_Configuracoes.Infotec.Equals("TRUE"))
            {
                new Classe_Catalises().ExibirInfoTec(this);
            }
            lstCatalises.Select();
        }

        private void txtQuantidade_Validated(object sender, EventArgs e)
        {
            Classe_Catalises.COD_Catalise = null;

            if (txtQuantidade.Text.Equals(string.Empty))
            {
                txtQuantidade.Text = "0,0";
            }
            if (Classe_Catalises.TipoBD != null && Classe_Catalises.TipoBD.Equals("ORIGINAL"))
            {
                new Classe_Catalises().Get_Catalise_Cod(cboCatalise.Text);
            }
            if (Classe_Catalises.TipoBD != null && Classe_Catalises.TipoBD.Equals("PERSONALIZADO"))
            {
                new Classe_Catalises().Get_CatalisePersonalizada_Cod(cboCatalise.Text);
            }

            if (Classe_Catalises.COD_Catalise != null && txtQuantidade.Text != string.Empty)
            {     
                new Classe_Catalises().Listar_ItensCatalises(this, lstCatalises, Double.Parse(txtQuantidade.Text));
                if (cboCatalise.Text != " Selecione a CATALISE...") { new Classe_Catalises().Listar_AditivosCatalises(this, lstAditivosCatalise, Double.Parse(txtQuantidade.Text)); } else { lstAditivosCatalise.Items.Clear(); }
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstCatalises.Select();
                txtQuantidade.SelectAll();
            }
        }

        private void txtQuantidade_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantidade.Clear();
        }

        private void lstAditivosCatalise_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int ID = e.Item.Index;
            double SomaAditivos = 0;
            double SomaCatalise = 0;
            double SomaTotal = 0;

            for (int s = 0; s < lstCatalises.Items.Count; s++)
            {
                SomaCatalise = SomaCatalise + Convert.ToDouble(lstCatalises.Items[s].SubItems[7].Text);
            }

            for (int i = 0; i < lstAditivosCatalise.Items.Count; i++)
            {
                if (lstAditivosCatalise.Items[i].Checked == true)
                {
                    SomaAditivos = SomaAditivos + Convert.ToDouble(lstAditivosCatalise.Items[i].SubItems[7].Text);
                }
            }

            if (lstAditivosCatalise.Items[ID].Checked.Equals(true))
            {
                lstAditivosCatalise.Items[ID].UseItemStyleForSubItems = false;
                lstAditivosCatalise.Items[ID].SubItems[4].ForeColor = Color.Black;
                lstAditivosCatalise.Items[ID].SubItems[6].ForeColor = Color.Black;
                lstAditivosCatalise.Items[ID].SubItems[7].ForeColor = Color.Black;
            }
            else
            {
                lstAditivosCatalise.Items[ID].UseItemStyleForSubItems = false;
                lstAditivosCatalise.Items[ID].SubItems[4].ForeColor = new Classe_Tema().COR_Background_Listview;
                lstAditivosCatalise.Items[ID].SubItems[6].ForeColor = new Classe_Tema().COR_Background_Listview;
                lstAditivosCatalise.Items[ID].SubItems[7].ForeColor = new Classe_Tema().COR_Background_Listview;
            }

            SomaTotal = SomaCatalise + SomaAditivos;
            lblValorCatalise.Text = SomaTotal.ToString("N2");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Classe_Configuracoes.Infotec.Equals("FALSE"))
            {
                new Classe_Catalises().ExibirInfoTec(this);
                return;
            }
            if (Classe_Configuracoes.Infotec.Equals("TRUE"))
            {
                new Classe_Catalises().OcultarInfoTec(this);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(string.Empty);

            if (Classe_Catalises.StatusBotaoDatasheet.Equals(false))
            {
                new Classe_Catalises().ExibirDataSheet(this);
                return;
            }
            if (Classe_Catalises.StatusBotaoDatasheet.Equals(true))
            {
                new Classe_Catalises().OcultarDatasheet(this);
                return;
            }
        }

        private void btnVideoAplicacao_Click(object sender, EventArgs e)
        {
            if (Classe_Catalises.VideoAplicacao.Equals(true))
            {
                Classe_Catalises.VideoAplicacao = false;
                new Classe_Catalises().Ocultar_VieoPlayer(this);
                return;
            }
            if (Classe_Catalises.VideoAplicacao.Equals(false))
            {
                Classe_Catalises.VideoAplicacao = true;
                new Classe_Catalises().Exibir_VideoPlayer(this);
                return;
            }
        }
    }
}
