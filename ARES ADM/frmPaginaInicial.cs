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
    public partial class frmPaginaInicial : Form
    {
        public static bool Formulario_Orcamento = false;
        public static bool FOrmulario_OS = false;
        public static bool Formulario_Cliente = false;
        public static bool Formulario_Produtos = false;

        frmListaOS frmORCAMENTOS;
        frmListaOS frmOS;
        frmProdutos frmPRODUTOS;
        frmCatalises frmCATALISES;
        frmConfiguracoes frmCONFIG;

        public frmPaginaInicial()
        {
            InitializeComponent();

            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - 40;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.DesktopLocation = new System.Drawing.Point(0, 0);
            double FatorLogo = (picBackgorund.Height * 0.75);
            this.picBackgorund.Padding = new Padding(0,Convert.ToInt32(FatorLogo), 0, 0);

            new Classe_Tema().TEMA_frmPrincipal(this);
            new Classe_Empresa().Empresa();
            new Classe_BancoHoras().Get_TipoBanco();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOrcamentos_MouseEnter(object sender, EventArgs e)
        {
            btnOrcamentos.BackColor = Classe_Tema.Botao_Sobre;
        }

        private void btnOrcamentos_MouseLeave(object sender, EventArgs e)
        {
            btnOrcamentos.BackColor = Classe_Tema.Botao_Normal;
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
            Close();
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

        private void btnOrdemServico_Click(object sender, EventArgs e)
        {
            if (!FOrmulario_OS)
            {
                frmOS = new frmListaOS("OS");
                frmOS.Show();

                FOrmulario_OS = true;
            }
            if (FOrmulario_OS)
            {
                frmOS.Focus();
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            frmPRODUTOS = new frmProdutos("PRODUTO");
            frmPRODUTOS.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCatalises_Click(object sender, EventArgs e)
        {
            frmCATALISES = new frmCatalises(null, null);
            frmCATALISES.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmCONFIG = new frmConfiguracoes();
            frmCONFIG.ShowDialog();
        }
        
        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            if (!Formulario_Orcamento)
            {
                frmORCAMENTOS = new frmListaOS("ORÇAMENTO");
                frmORCAMENTOS.Show();

                Formulario_Orcamento = true;
            }
            if (Formulario_Orcamento)
            {
                frmORCAMENTOS.Focus();
            }
        }

       
    }
}
