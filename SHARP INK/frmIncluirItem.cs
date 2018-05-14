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
    public partial class frmIncluirItem : Form
    {
        public string TIPO;
        public int IDVeiculo;
        frmOrdemServico frmordemservico;
        public frmIncluirItem(frmOrdemServico FRMORDEMSERVICO, string Tipo, int ID_Veiculo)
        {
            InitializeComponent();
            this.TIPO = Tipo;
            this.IDVeiculo = ID_Veiculo;
            this.frmordemservico = FRMORDEMSERVICO;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int ID =Convert.ToInt32(txtCodigo.Text);
            string Descricao = txtDescricao.Text;
            double qnt = Convert.ToDouble(txtQuantidade.Text);
            double ValorUni = Convert.ToDouble(txtValorUnitario.Text);
            double ValorTotal = Convert.ToDouble(txtValorTotal.Text);

            new Classe_OrdemServico().Incluir_Item(this,TIPO,IDVeiculo,null,ID.ToString(),Descricao,qnt,ValorUni,ValorTotal);
            new Classe_OrdemServico().Listar_ItensOS(frmordemservico.lstItensOS, "SELECT * FROM OrdemServico_Itens WHERE ID_Veiculo like '" + IDVeiculo + "'");
        }

        private void txtValorUnitario_Validated(object sender, EventArgs e)
        {
            double unit =Convert.ToDouble(txtValorUnitario.Text);
            double qnt =Convert.ToDouble(txtQuantidade.Text);

            double Total = unit * qnt;
            txtValorTotal.Text = Total.ToString();
        }
    }
}
