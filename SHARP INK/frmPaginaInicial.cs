using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SHARP_INK.Classes;

namespace SHARP_INK
{
    public partial class frmPaginaInicial : Form
    {
        public frmPaginaInicial()
        {
            InitializeComponent();
            
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 40;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.DesktopLocation = new System.Drawing.Point(0, 0);
            double FatorLogo = (picBackgorund.Height * 0.75);
            this.picBackgorund.Padding = new Padding(0,Convert.ToInt32(FatorLogo), 0, 0);

            new Classe_Tema().Tema_frmPrincipal(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOrdemServico_MouseEnter(object sender, EventArgs e)
        {
            btnOrdemServico.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnOrdemServico_MouseLeave_1(object sender, EventArgs e)
        {
            btnOrdemServico.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnProdutos_MouseLeave_1(object sender, EventArgs e)
        {
            btnProdutos.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnProdutos_MouseEnter(object sender, EventArgs e)
        {
            btnProdutos.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnCatalises_MouseLeave_1(object sender, EventArgs e)
        {
            btnCatalises.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnCatalises_MouseEnter(object sender, EventArgs e)
        {
            btnCatalises.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnUsuarios_MouseLeave_1(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnAlocacao_MouseEnter(object sender, EventArgs e)
        {
            btnAlocacao.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnAlocacao_MouseLeave_1(object sender, EventArgs e)
        {
            btnAlocacao.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            btnConfig.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnConfig_MouseLeave_1(object sender, EventArgs e)
        {
            btnConfig.BackColor = Classe_Tema.Botao_Normal;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToLongDateString();
            txtRelogio.Text = DateTime.Now.ToLongTimeString();
        }

       
    }
}
