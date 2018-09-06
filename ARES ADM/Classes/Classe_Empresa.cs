using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data;

namespace ARES_ADM.Classes
{
    class Classe_Empresa
    {
        public static string RazaoSocial { get; private set; }
        public static string CNPJ { get; private set; }
        public static string Endereco { get; private set; }
        public static string Email { get; private set; }
        public static string Telefone { get; private set; }

        public void Empresa()
        {
            string SQL = "SELECT * FROM Configuracoes";
            try
            {
                DataTable DT = Classes_Conexao.Preenche_DataTable(SQL);

                DataRow DR = DT.Rows[0];

                RazaoSocial = DR["Empresa_RazaoSocial"].ToString().TrimEnd();
                CNPJ = DR["Empresa_CNPJ"].ToString().TrimEnd();
                Endereco = DR["Empresa_Endereco"].ToString().TrimEnd();
                Email = DR["Empresa_Email"].ToString().TrimEnd();
                Telefone = DR["Empresa_Telefone"].ToString().TrimEnd();

                DT.Dispose();
            }
            catch (SqlCeException ex)
            {
                Form Messagebox = new frmMensagemBox(Classe_Mensagem.CRITICO, "Erro", "Ocorreu o seguinte erro:/n" + ex);
                Messagebox.Show();
            }
        }
    }
}
