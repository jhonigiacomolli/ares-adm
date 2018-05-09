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
        private Color COR_Primaria = Color.FromArgb(26, 26, 26);
        private Color COR_Titulos = Color.Silver;
        private Color COR_Subtitulos = Color.Gray;

        

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
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);

            //Menu Strip
            Form.btnOS.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnOS.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnAdicionar.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnAdicionar.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnEditar.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnEditar.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;
            Form.btnExcluir.FlatAppearance.MouseOverBackColor = Classe_Tema.MenuBotao_Sobre;
            Form.btnExcluir.FlatAppearance.MouseDownBackColor = Classe_Tema.MenuBotao_Normal;


        }

    }
}
