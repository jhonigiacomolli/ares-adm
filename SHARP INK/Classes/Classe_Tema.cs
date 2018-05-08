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

        public void Tema_frmPrincipal(frmPaginaInicial Form)
        {
            Form.BackColor = Color.FromArgb(26, 26, 26);

            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.Black;
            Form.btnFechar.BackColor = Color.FromArgb(120, 120, 120);
            Form.lblTituloForm.ForeColor = Color.Silver;

            //MenuStrip
            Form.pnMenuStrip.BackColor = Color.FromArgb(37, 36, 38);
            Form.menuCadastro.BackColor = Color.FromArgb(37, 36, 38);
            Form.menuRelatorios.BackColor = Color.FromArgb(37, 36, 38);

            //Menu
            Form.pnAjuste.BackColor = Color.FromArgb(26, 26, 26);
            Form.btnOrdemServico.BackColor = Color.Silver;
            Form.btnProdutos.BackColor = Color.Silver;
            Form.btnCatalises.BackColor = Color.Silver;
            Form.btnUsuarios.BackColor = Color.Silver;
            Form.btnAlocacao.BackColor = Color.Silver;
            Form.btnConfig.BackColor = Color.Silver;

            //Rodapé
            Form.lblTituloRodape.ForeColor = Color.Silver;
            Form.lblDescricaoRodape.ForeColor = Color.Gray;
            Form.lblEmailRodape.ForeColor = Color.Gray;
            Form.lblTelefoneRodape.ForeColor = Color.Gray;
            Form.txtData.ForeColor = Color.Gray;
            Form.txtRelogio.ForeColor = Color.Silver;
        }
    }
}
