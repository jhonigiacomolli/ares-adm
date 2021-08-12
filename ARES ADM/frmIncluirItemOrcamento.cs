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
    public partial class frmIncluirItemOrcamento : Form
    {
        bool mouseDown;
        Point lastLocation;

        public string id;
        public string CodPeca;

        frmOrcamentos frmorcamentos;

        public frmIncluirItemOrcamento(frmOrcamentos frmorcamentos,string ID)
        {
            InitializeComponent();

            id = ID;
            this.frmorcamentos = frmorcamentos;

            new Classe_Tema().TEMA_frmIncluirItemOrcamento(this);
            new Classe_Orcamentos().Carregar_Operacoes(cboOperacao);
            new Classe_MO().Get_MO(cboMO);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void lblTituloForm_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtValorBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtValorLiquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtQnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtValorBruto_Validated(object sender, EventArgs e)
        {
            if (txtValorBruto.Text != "")
            {
                txtValorLiquido.Text = new Classe_Orcamentos().Valor_Liquido(txtValorBruto.Text, txtDesconto.Text).ToString("N2");
                txtValorTotal.Text = new Classe_Orcamentos().Valor_Total(txtValorLiquido.Text, txtQnt.Text).ToString("N2");
            }


        }

        private void txtValorLiquido_Validated(object sender, EventArgs e)
        {
            if (txtValorLiquido.Text != "")
            {
                txtValorLiquido.Text = Convert.ToDouble(txtValorLiquido.Text).ToString("N2");
            }
        }

        private void txtValorTotal_Validated(object sender, EventArgs e)
        {
            if (txtValorTotal.Text != "")
            {
                txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("N2");
            }
        }

        private void cboOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtCodFabrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtQnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorBruto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorLiquido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtHoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnCodigoPeca_Click(object sender, EventArgs e)
        {
            frmProdutos Peca = new frmProdutos(this);
            txtQnt.Focus();
            Peca.ShowDialog();
        }

        private void txtQnt_Validated(object sender, EventArgs e)
        {
            txtValorLiquido.Text = new Classe_Orcamentos().Valor_Liquido(txtValorBruto.Text, txtDesconto.Text).ToString("N2");
            txtValorTotal.Text = new Classe_Orcamentos().Valor_Total(txtValorLiquido.Text, txtQnt.Text).ToString("N2");
            if (txtQnt.Text.Equals(string.Empty))
            {
                txtQnt.Text = "0,0";
            }
            else
            {
                txtQnt.Text = Convert.ToDouble(txtQnt.Text).ToString("N1");
            }
        }

        private void txtDesconto_Validated(object sender, EventArgs e)
        {
            txtValorLiquido.Text = new Classe_Orcamentos().Valor_Liquido(txtValorBruto.Text, txtDesconto.Text).ToString("N2");
            txtValorTotal.Text = new Classe_Orcamentos().Valor_Total(txtValorLiquido.Text, txtQnt.Text).ToString("N2");
            txtDesconto.Text = Convert.ToDouble(txtDesconto.Text).ToString("N1");
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOperacao.SelectedIndex>-1)
            {
                btnCodigoPeca.Visible = true;
                txtCodFabrica.Enabled = true;
                txtDescricao.Enabled = true;
                txtQnt.Enabled = true;
                txtValorBruto.Enabled = true;
                txtDesconto.Enabled = true;
                txtValorLiquido.Enabled = true;
                txtValorTotal.Enabled = true;
                cboMO.Enabled = true;
                txtValorRefMO.Enabled = true;
                txtValorMOPintura.Enabled = true;
                txtHoraMO.Enabled = true;
                txtHoraMOPintura.Enabled = true;
                txtValorTotalMO.Enabled = true;
                txtValorTotalMOPintura.Enabled = true;

                txtValorMOPintura.Text = new Classe_MO().Get_MOPintura();
            }
            else
            {
                btnCodigoPeca.Visible = false;
                txtCodFabrica.Enabled = false;
                txtDescricao.Enabled = false;
                txtQnt.Enabled = false;
                txtValorBruto.Enabled = false;
                txtDesconto.Enabled = false;
                txtValorLiquido.Enabled = false;
                txtValorTotal.Enabled = false;
                cboMO.Enabled = false;
                txtValorRefMO.Enabled = false;
                txtValorMOPintura.Enabled = false;
                txtHoraMO.Enabled = false;
                txtHoraMOPintura.Enabled = false;
                txtValorTotalMO.Enabled = false;
                txtValorTotalMOPintura.Enabled = false;


                txtValorMOPintura.Clear();
            }
        }

        private void txtHoras_Validated(object sender, EventArgs e)
        {
            if (txtHoraMO.Text != string.Empty)
            {
                txtHoraMO.Text = Convert.ToDouble(txtHoraMO.Text).ToString("N1");
                 
            }

            if (txtHoraMO.Text != string.Empty && txtValorRefMO.Text != string.Empty)
            {
                double Hora = Convert.ToDouble(txtValorRefMO.Text);
                double QNT = Convert.ToDouble(txtHoraMO.Text);

                double TotalHora = Hora * QNT;
                txtValorTotalMO.Text = TotalHora.ToString("N2");

                txtHoraMOPintura.Focus();
            }
        }

        private void txtPintura_Validated(object sender, EventArgs e)
        {
            if (txtHoraMOPintura.Text != string.Empty)
            {
                txtHoraMOPintura.Text = Convert.ToDouble(txtHoraMOPintura.Text).ToString("N1");
            }

            if (txtHoraMOPintura.Text != string.Empty && txtValorMOPintura.Text != string.Empty)
            {
                double Hora = Convert.ToDouble(txtValorMOPintura.Text);
                double QNT = Convert.ToDouble(txtHoraMOPintura.Text);

                double TotalHora = Hora * QNT;
                txtValorTotalMOPintura.Text = TotalHora.ToString("N2");
            }
        }

        private void cboMO_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorRefMO.Text = new Classe_MO().Get_ValorRefMO(cboMO.Text);            
        }

        private void cboMO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorRefMO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorMOPintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorTotalMO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtValorTotalMOPintura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            new Classe_Orcamentos().Incluir_ItemOrcamento(id, cboOperacao.Text, txtCodFabrica.Text, txtDescricao.Text,
                                                            txtQnt.Text, txtValorBruto.Text, txtDesconto.Text, txtValorLiquido.Text,
                                                            txtValorTotal.Text, cboMO.Text, txtValorRefMO.Text,
                                                            txtHoraMO.Text, txtValorTotalMO.Text, txtValorMOPintura.Text, txtHoraMOPintura.Text,
                                                            txtValorTotalMOPintura.Text);
            new Classe_Orcamentos().Listar_ItensOrcamento(frmorcamentos.lstItensOrcamento, id);
            new Classe_Orcamentos().Limpar_frmincluirItemOrcamento(this);
        }
    }
}
