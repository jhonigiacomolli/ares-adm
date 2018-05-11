using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHARP_INK.Classes
{
    class Classe_Tema
    {
        public static Color Botao_Normal = Color.Silver;
        public static Color Botao_Sobre = Color.Maroon;
        public static Color Botao_Desativado = Color.Black;
        public static Color MenuBotao_Normal= Color.FromArgb(26, 26, 26);
        public static Color MenuBotao_Sobre = Color.FromArgb(64, 64, 64);
        public static Color TextBox_Edicao = Color.YellowGreen;
        private Color COR_Primaria = Color.FromArgb(26, 26, 26);
        private Color COR_Titulos = Color.Silver;
        private Color COR_Subtitulos = Color.Gray;
        private Color COR_FontePrimaria = Color.Black;     

        public void TEMA_frmPrincipal(frmPaginaInicial Form)
        {
            //Corpo
            Form.BackColor = COR_Primaria;

            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.Black;
            Form.btnFechar.BackColor = Color.FromArgb(120, 120, 120);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //MenuStrip
            Form.pnMenuStrip.BackColor = Color.FromArgb(37, 36, 38);
            Form.menuCadastro.BackColor = Color.FromArgb(37, 36, 38);
            Form.menuRelatorios.BackColor = Color.FromArgb(37, 36, 38);

            //Menu
            Form.pnAjuste.BackColor = COR_Primaria;
            Form.btnOrdemServico.BackColor = Botao_Normal;
            Form.btnProdutos.BackColor = Botao_Normal;
            Form.btnCatalises.BackColor = Botao_Normal;
            Form.btnUsuarios.BackColor = Botao_Normal;
            Form.btnAlocacao.BackColor = Botao_Normal;
            Form.btnConfig.BackColor = Botao_Normal;

            //Rodapé
            Form.lblTituloRodape.ForeColor = COR_Titulos;
            Form.lblDescricaoRodape.ForeColor = COR_Subtitulos;
            Form.lblEmailRodape.ForeColor = COR_Subtitulos;
            Form.lblTelefoneRodape.ForeColor = COR_Subtitulos;
            Form.txtData.ForeColor = COR_Subtitulos;
            Form.txtRelogio.ForeColor = COR_Titulos;
        }

        public void TEMA_frmListaOS(frmListaOS Form)
        {
            //Corpo
            Form.BackColor = COR_Primaria;
            Form.btnAbrir.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnAbrir.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnFinalizar.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnFinalizar.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;

            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //Menu Strip
            Form.btnOS.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnOS.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnAdicionar.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnAdicionar.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnEditar.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnEditar.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnExcluir.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnExcluir.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;          

            //Pesquisa
            Form.lblTipoPesquisa.ForeColor = COR_Titulos;
            Form.lblPesquisa.ForeColor = COR_Titulos;
            Form.txtPesquisa.BackColor = Color.White;
        }

        public void TEMA_frmCadastroOS(frmCadastroOS Form)
        {
            //Corpo
            Form.BackColor = COR_Primaria;
            Form.lblID.ForeColor = COR_Titulos;
            Form.lblProprietario.ForeColor = COR_Titulos;
            Form.lblVeiculo.ForeColor = COR_Titulos;
            Form.lblPlaca.ForeColor = COR_Titulos;
            Form.lblCor.ForeColor = COR_Titulos;
            Form.lblTamanho.ForeColor = COR_Titulos;
            Form.btnGravar.BackColor = COR_Primaria;

            Form.txtNumeroOS.ForeColor = COR_FontePrimaria;
            Form.txtProprietario.ForeColor = COR_FontePrimaria;
            Form.txtVeiculo.ForeColor = COR_FontePrimaria;
            Form.txtPLaca.ForeColor = COR_FontePrimaria;
            Form.txtCor.ForeColor = COR_FontePrimaria;
            Form.txtTamanho.ForeColor = COR_FontePrimaria;

            Form.btnGravar.BackColor = COR_Primaria;


            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;            
        }

        public void TEMA_frmMensagemBox(frmMensagemBox Form)
        {
            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //Corpo
            Form.btnNo.BackColor = COR_Primaria;
            Form.btnOk.BackColor = COR_Primaria;
            Form.btnYes.BackColor = COR_Primaria;

            Form.btnNo.ForeColor = COR_Titulos;
            Form.btnOk.ForeColor = COR_Titulos;
            Form.btnYes.ForeColor = COR_Titulos;

            Form.txtMensagem.ForeColor = COR_Titulos;
        }
    }
}
