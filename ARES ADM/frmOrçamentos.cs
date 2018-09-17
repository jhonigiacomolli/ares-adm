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
    public partial class frmOrcamentos : Form
    {
        bool mouseDown;
        Point lastLocation;

        public frmOrcamentos()
        {
            InitializeComponent();

            new Classe_Tema().TEMA_frmOrcamentos(this);
            new Classe_Orcamentos().Carregar_UF(cboEstado);
            new Classe_Orcamentos().Carregar_Montadoras(txtMontadora);
            new Classe_Orcamentos().Carregar_Cor(txtCor);
            new Classe_Orcamentos().Carregar_TipoPintura(txtPintura);
            new Classe_Orcamentos().Carregar_TipoSeguro(cboTipoSeguro);
            new Classe_Orcamentos().Carregar_Seguradoras(cboSeguradora);
            new Classe_Listviews().Criar_LST_ItensOrcamento(lstItensOrcamento);
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

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnDadosProprietario_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosProprietario(this);
        }

        public void btnDadosVeiculo_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosVeiculo(this);
        }

        public void btnDadosSeguro_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Seleciona_PainelDadosSeguro(this);
        }

        private void cboSeguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoSeguro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtFranquia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNSinistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosProprietario(this);
            }
        }

        private void cboSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Valida_Seguro(this);
            new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
        }

        

        private void txtMotorizacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNChassis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtVeiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }
        
        private void txtProprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }     
        
        private void cboEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCPF_CNPJ_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Validar_TipoCadastro(this);
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosVeiculo(this);
            }
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void cboTipoTelefone_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Validar_TipoTelefone(this);
        }

        private void cboTipoTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtMontadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtPintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
                new Classe_Orcamentos().Seleciona_PainelDadosSeguro(this);
            }
        }

        private void cboSeguradora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
                new Classe_Orcamentos().Validar_Campos_Cabecalho(this);
            }
        }

        private void txtNOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAbertura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cboTipoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtOrcamentista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
