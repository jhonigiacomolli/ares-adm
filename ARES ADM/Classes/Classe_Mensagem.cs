using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARES_ADM.Classes
{
    class Classe_Mensagem
    {
        public static string ALERTA = "Alerta";
        public static string CRITICO = "Critico";
        public static string QUESTAO = "Questao";

        public void Mensagem(frmMensagemBox form,  string Categoria, string Titulo, string Mensagem)
        {
            if (Categoria == "Alerta")
            {
                form.lblTituloForm.Text = Titulo;
                form.txtMensagem.Text = Mensagem;

                form.btnNo.Visible = false;
                form.btnYes.Visible = false;
                form.btnOk.Visible = true;

                form.picIcone.BackgroundImage = Properties.Resources.Icone_Exclamação;
            }
            if (Categoria == "Critico")
            {
                form.lblTituloForm.Text = Titulo;
                form.txtMensagem.Text = Mensagem;

                form.btnNo.Visible = false;
                form.btnYes.Visible = false;
                form.btnOk.Visible = true;

                form.picIcone.BackgroundImage = Properties.Resources.Icone_Critico;
            }
            if (Categoria == "Questao")
            {
                form.lblTituloForm.Text = Titulo;
                form.txtMensagem.Text = Mensagem;

                form.btnNo.Visible = true;
                form.btnYes.Visible = true;
                form.btnOk.Visible = false;

                form.picIcone.BackgroundImage = Properties.Resources.Icone_Interogação;
            }
        }
    }
}
