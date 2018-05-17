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
        public static Color TextBox_Normal = Color.White;
        public static Color TextBox_Desativado = Color.FromArgb(80,80,80);
        public static Color Linha_OSAberta = Color.Green;
        public static Color Linha_OSFechada = Color.FromArgb(60,60,60);
        public static Color Linha_OSAguardando = Color.Black;

        public Color COR_Primaria = Color.FromArgb(26, 26, 26);
        public Color COR_Background_Listview = Color.FromArgb(224, 224, 224);
        public Color COR_Titulos = Color.Silver;
        public Color COR_Subtitulos = Color.Gray;
        public Color COR_FontePrimaria = Color.Black;     

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
            Form.lstVeiculos.BackColor = COR_Background_Listview;

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

        public void TEMA_frmOrdemServico(frmOrdemServico Form)
        {
            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //Corpor
            Form.BackColor = COR_Primaria;
            Form.lstItensOS.BackColor = COR_Background_Listview;

            //Dados OS
            Form.lblTituloNOS.ForeColor = COR_Subtitulos;
            Form.lblTituloProprietario.ForeColor = COR_Subtitulos;
            Form.lblTituloVeiculo.ForeColor = COR_Subtitulos;
            Form.lblTituloPlaca.ForeColor = COR_Subtitulos;
            Form.lblTituloCor.ForeColor = COR_Subtitulos;
            Form.lblTituloTamanho.ForeColor = COR_Subtitulos;

            Form.txtNos.ForeColor = COR_Titulos;
            Form.txtProprietario.ForeColor = COR_Titulos;
            Form.txtVeiculo.ForeColor = COR_Titulos;
            Form.txtPlaca.ForeColor = COR_Titulos;
            Form.txtCor.ForeColor = COR_Titulos;
            Form.txtTamanho.ForeColor = COR_Titulos;
            Form.txtNos.BackColor = Color.FromArgb(30, 30, 30);
            Form.txtProprietario.BackColor = Color.FromArgb(30, 30, 30);
            Form.txtVeiculo.BackColor = Color.FromArgb(30, 30, 30);
            Form.txtPlaca.BackColor = Color.FromArgb(30, 30, 30);
            Form.txtCor.BackColor = Color.FromArgb(30, 30, 30);
            Form.txtTamanho.BackColor = Color.FromArgb(30, 30, 30);

            Form.lblRazaoSocial.ForeColor = COR_Titulos;
            Form.lblTelefone.ForeColor = COR_Titulos;
            Form.lblCNPJ.ForeColor = COR_Subtitulos;
            Form.lblEndereço.ForeColor = COR_Subtitulos;
            Form.lblEmail.ForeColor = COR_Subtitulos;

            //Painel Itens OS

            Form.pnItensOS.BackColor = Color.FromArgb(40, 40, 40);
            Form.lstItensOS.BackColor = COR_Background_Listview;

            Form.lblTicket.ForeColor = COR_Subtitulos;
            Form.lblN_Pecas.ForeColor = COR_Subtitulos;
            Form.lblMediaPecas.ForeColor = COR_Subtitulos;
            Form.lblAbrasivos.ForeColor = COR_Subtitulos;
            Form.lblCatalise.ForeColor = COR_Subtitulos;
            Form.lblTinta.ForeColor = COR_Subtitulos;
            Form.lblPolidores.ForeColor = COR_Subtitulos;
            Form.lblDIversos.ForeColor = COR_Subtitulos;

            Form.txtTicket.ForeColor = COR_Titulos;
            Form.txtN_Pecas.ForeColor = COR_Titulos;
            Form.txtMediaPeca.ForeColor = COR_Titulos;
            Form.txtSomaAbrasivos.ForeColor = COR_Titulos;
            Form.txtSomaCatalises.ForeColor = COR_Titulos;
            Form.txtSomaTinta.ForeColor = COR_Titulos;
            Form.txtSomaPolidores.ForeColor = COR_Titulos;
            Form.txtSomaDiversos.ForeColor = COR_Titulos;

            Form.btnTinta.BackColor = Color.FromArgb(40, 40, 40);
            Form.btnCatalise.BackColor = Color.FromArgb(40, 40, 40);
            Form.btnProdutos.BackColor = Color.FromArgb(40, 40, 40);
            Form.btnEditar.BackColor = Color.FromArgb(40, 40, 40);
            Form.btnExcluir.BackColor = Color.FromArgb(40, 40, 40);

            //Painell Funcionarios
            Form.lstFuncionarios.BackColor = Color.FromArgb(40, 40, 40);
            Form.lstFuncionarios.BackColor = COR_Background_Listview;
        }

        public void TEMA_frmProdutos(frmProdutos Form)
        {
            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //Corpor
            Form.BackColor = COR_Primaria;
            Form.lstProdutos.BackColor = COR_Background_Listview;

            Form.btnIncluir.BackColor = MenuBotao_Normal;
            Form.btnEditar.BackColor = MenuBotao_Normal;
            Form.btnExcluir.BackColor = MenuBotao_Normal;

            Form.btnIncluir.ForeColor = COR_Titulos;
            Form.btnEditar.ForeColor = COR_Titulos;
            Form.btnExcluir.ForeColor = COR_Titulos;

            Form.lblPalavraChave.ForeColor = COR_Titulos;
            Form.lblCampo.ForeColor = COR_Titulos;
        }

        public void TEMA_frmApontamentoFunc(frmApontamentoFunc Form)
        {
            //Cabeçalho
            Form.pnCabecalho.BackColor = Color.FromArgb(60, 60, 60);
            Form.lblTituloForm.ForeColor = COR_Titulos;

            //Corpor
            Form.BackColor = COR_Primaria;
            Form.lblCodigo.ForeColor = COR_Titulos;
            Form.lblFuncionario.ForeColor = COR_Titulos;
            Form.lblFuncao.ForeColor = COR_Titulos;
            Form.lblEntrada.ForeColor = COR_Titulos;
            Form.lblSaida.ForeColor = COR_Titulos;

            Form.btnGravar.BackColor = MenuBotao_Normal;
            Form.btnPesquisa.BackColor = MenuBotao_Normal;
        }
    }
}
