namespace ARES_ADM
{
    partial class frmIncluirItemOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirItemOrcamento));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.lblTituloOperacao = new System.Windows.Forms.Label();
            this.txtCodFabrica = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTituloDescricao = new System.Windows.Forms.Label();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.lblTituloQnt = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.lblTituloValorBruto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblTituloDesconto = new System.Windows.Forms.Label();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.lblTituloValorLiquido = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.txtHoraMO = new System.Windows.Forms.TextBox();
            this.lblTituloHoras = new System.Windows.Forms.Label();
            this.txtHoraMOPintura = new System.Windows.Forms.TextBox();
            this.lblTituloPintura = new System.Windows.Forms.Label();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.btnCodigoPeca = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblTituloCodPEca = new System.Windows.Forms.Label();
            this.cboMO = new System.Windows.Forms.ComboBox();
            this.txtValorRefMO = new System.Windows.Forms.TextBox();
            this.txtValorMOPintura = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtValorTotalMO = new System.Windows.Forms.TextBox();
            this.txtValorTotalMOPintura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnCabecalho.Controls.Add(this.lblTituloForm);
            this.pnCabecalho.Controls.Add(this.pnFavIcon);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(395, 35);
            this.pnCabecalho.TabIndex = 5;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            this.pnCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseUp);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(42, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(185, 20);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "ARES ADM - Incluir Item";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp_1);
            // 
            // pnFavIcon
            // 
            this.pnFavIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnFavIcon.BackgroundImage = global::ARES_ADM.Properties.Resources.FavIcon;
            this.pnFavIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnFavIcon.Location = new System.Drawing.Point(10, 4);
            this.pnFavIcon.Name = "pnFavIcon";
            this.pnFavIcon.Size = new System.Drawing.Size(25, 25);
            this.pnFavIcon.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.BackgroundImage = global::ARES_ADM.Properties.Resources.Close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Location = new System.Drawing.Point(360, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Tag = "";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloOperacao
            // 
            this.lblTituloOperacao.AutoSize = true;
            this.lblTituloOperacao.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloOperacao.Location = new System.Drawing.Point(14, 55);
            this.lblTituloOperacao.Name = "lblTituloOperacao";
            this.lblTituloOperacao.Size = new System.Drawing.Size(54, 13);
            this.lblTituloOperacao.TabIndex = 79;
            this.lblTituloOperacao.Text = "Operação";
            // 
            // txtCodFabrica
            // 
            this.txtCodFabrica.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodFabrica.Enabled = false;
            this.txtCodFabrica.Location = new System.Drawing.Point(94, 77);
            this.txtCodFabrica.Name = "txtCodFabrica";
            this.txtCodFabrica.Size = new System.Drawing.Size(280, 20);
            this.txtCodFabrica.TabIndex = 1;
            this.txtCodFabrica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodFabrica_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(94, 103);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(280, 20);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // lblTituloDescricao
            // 
            this.lblTituloDescricao.AutoSize = true;
            this.lblTituloDescricao.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloDescricao.Location = new System.Drawing.Point(14, 107);
            this.lblTituloDescricao.Name = "lblTituloDescricao";
            this.lblTituloDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblTituloDescricao.TabIndex = 83;
            this.lblTituloDescricao.Text = "Descrição";
            // 
            // txtQnt
            // 
            this.txtQnt.BackColor = System.Drawing.SystemColors.Window;
            this.txtQnt.Enabled = false;
            this.txtQnt.Location = new System.Drawing.Point(94, 129);
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(280, 20);
            this.txtQnt.TabIndex = 3;
            this.txtQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQnt_KeyDown);
            this.txtQnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQnt_KeyPress);
            this.txtQnt.Validated += new System.EventHandler(this.txtQnt_Validated);
            // 
            // lblTituloQnt
            // 
            this.lblTituloQnt.AutoSize = true;
            this.lblTituloQnt.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloQnt.Location = new System.Drawing.Point(14, 133);
            this.lblTituloQnt.Name = "lblTituloQnt";
            this.lblTituloQnt.Size = new System.Drawing.Size(62, 13);
            this.lblTituloQnt.TabIndex = 85;
            this.lblTituloQnt.Text = "Quantidade";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorBruto.Enabled = false;
            this.txtValorBruto.Location = new System.Drawing.Point(94, 155);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(280, 20);
            this.txtValorBruto.TabIndex = 4;
            this.txtValorBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorBruto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorBruto_KeyDown);
            this.txtValorBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorBruto_KeyPress);
            this.txtValorBruto.Validated += new System.EventHandler(this.txtValorBruto_Validated);
            // 
            // lblTituloValorBruto
            // 
            this.lblTituloValorBruto.AutoSize = true;
            this.lblTituloValorBruto.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloValorBruto.Location = new System.Drawing.Point(14, 159);
            this.lblTituloValorBruto.Name = "lblTituloValorBruto";
            this.lblTituloValorBruto.Size = new System.Drawing.Size(59, 13);
            this.lblTituloValorBruto.TabIndex = 87;
            this.lblTituloValorBruto.Text = "Valor Bruto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(94, 181);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(280, 20);
            this.txtDesconto.TabIndex = 5;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesconto_KeyDown);
            this.txtDesconto.Validated += new System.EventHandler(this.txtDesconto_Validated);
            // 
            // lblTituloDesconto
            // 
            this.lblTituloDesconto.AutoSize = true;
            this.lblTituloDesconto.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloDesconto.Location = new System.Drawing.Point(14, 185);
            this.lblTituloDesconto.Name = "lblTituloDesconto";
            this.lblTituloDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblTituloDesconto.TabIndex = 89;
            this.lblTituloDesconto.Text = "Desconto (%)";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorLiquido.Enabled = false;
            this.txtValorLiquido.Location = new System.Drawing.Point(94, 207);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.ReadOnly = true;
            this.txtValorLiquido.Size = new System.Drawing.Size(280, 20);
            this.txtValorLiquido.TabIndex = 6;
            this.txtValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorLiquido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorLiquido_KeyDown);
            this.txtValorLiquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorLiquido_KeyPress);
            this.txtValorLiquido.Validated += new System.EventHandler(this.txtValorLiquido_Validated);
            // 
            // lblTituloValorLiquido
            // 
            this.lblTituloValorLiquido.AutoSize = true;
            this.lblTituloValorLiquido.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloValorLiquido.Location = new System.Drawing.Point(14, 211);
            this.lblTituloValorLiquido.Name = "lblTituloValorLiquido";
            this.lblTituloValorLiquido.Size = new System.Drawing.Size(70, 13);
            this.lblTituloValorLiquido.TabIndex = 91;
            this.lblTituloValorLiquido.Text = "Valor Líquido";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(94, 233);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(280, 20);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTotal_KeyDown);
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            this.txtValorTotal.Validated += new System.EventHandler(this.txtValorTotal_Validated);
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloTotal.Location = new System.Drawing.Point(14, 237);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(58, 13);
            this.lblTituloTotal.TabIndex = 93;
            this.lblTituloTotal.Text = "Valor Total";
            // 
            // txtHoraMO
            // 
            this.txtHoraMO.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoraMO.Enabled = false;
            this.txtHoraMO.Location = new System.Drawing.Point(231, 36);
            this.txtHoraMO.Name = "txtHoraMO";
            this.txtHoraMO.Size = new System.Drawing.Size(63, 20);
            this.txtHoraMO.TabIndex = 11;
            this.txtHoraMO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoras_KeyDown);
            this.txtHoraMO.Validated += new System.EventHandler(this.txtHoras_Validated);
            // 
            // lblTituloHoras
            // 
            this.lblTituloHoras.AutoSize = true;
            this.lblTituloHoras.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloHoras.Location = new System.Drawing.Point(25, 40);
            this.lblTituloHoras.Name = "lblTituloHoras";
            this.lblTituloHoras.Size = new System.Drawing.Size(77, 13);
            this.lblTituloHoras.TabIndex = 95;
            this.lblTituloHoras.Text = "Horas Funilaria";
            // 
            // txtHoraMOPintura
            // 
            this.txtHoraMOPintura.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoraMOPintura.Enabled = false;
            this.txtHoraMOPintura.Location = new System.Drawing.Point(231, 61);
            this.txtHoraMOPintura.Name = "txtHoraMOPintura";
            this.txtHoraMOPintura.Size = new System.Drawing.Size(63, 20);
            this.txtHoraMOPintura.TabIndex = 14;
            this.txtHoraMOPintura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPintura_KeyDown);
            this.txtHoraMOPintura.Validated += new System.EventHandler(this.txtPintura_Validated);
            // 
            // lblTituloPintura
            // 
            this.lblTituloPintura.AutoSize = true;
            this.lblTituloPintura.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloPintura.Location = new System.Drawing.Point(12, 64);
            this.lblTituloPintura.Name = "lblTituloPintura";
            this.lblTituloPintura.Size = new System.Drawing.Size(71, 13);
            this.lblTituloPintura.TabIndex = 97;
            this.lblTituloPintura.Text = "Horas Pintura";
            // 
            // cboOperacao
            // 
            this.cboOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Items.AddRange(new object[] {
            "PESSOA FISICA",
            "PESSOA JURÍDICA"});
            this.cboOperacao.Location = new System.Drawing.Point(94, 51);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(280, 21);
            this.cboOperacao.TabIndex = 0;
            this.cboOperacao.SelectedIndexChanged += new System.EventHandler(this.cboOperacao_SelectedIndexChanged);
            this.cboOperacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboOperacao_KeyDown);
            // 
            // btnCodigoPeca
            // 
            this.btnCodigoPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCodigoPeca.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCodigoPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigoPeca.ForeColor = System.Drawing.Color.Silver;
            this.btnCodigoPeca.Location = new System.Drawing.Point(5, 76);
            this.btnCodigoPeca.Name = "btnCodigoPeca";
            this.btnCodigoPeca.Size = new System.Drawing.Size(87, 22);
            this.btnCodigoPeca.TabIndex = 99;
            this.btnCodigoPeca.Text = "Código Peça";
            this.btnCodigoPeca.UseVisualStyleBackColor = false;
            this.btnCodigoPeca.Visible = false;
            this.btnCodigoPeca.Click += new System.EventHandler(this.btnCodigoPeca_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(10, 356);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(364, 32);
            this.btnGravar.TabIndex = 16;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblTituloCodPEca
            // 
            this.lblTituloCodPEca.AutoSize = true;
            this.lblTituloCodPEca.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCodPEca.Location = new System.Drawing.Point(14, 80);
            this.lblTituloCodPEca.Name = "lblTituloCodPEca";
            this.lblTituloCodPEca.Size = new System.Drawing.Size(68, 13);
            this.lblTituloCodPEca.TabIndex = 100;
            this.lblTituloCodPEca.Text = "Código Peça";
            // 
            // cboMO
            // 
            this.cboMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cboMO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.cboMO.ForeColor = System.Drawing.Color.Silver;
            this.cboMO.FormattingEnabled = true;
            this.cboMO.Location = new System.Drawing.Point(12, 36);
            this.cboMO.Name = "cboMO";
            this.cboMO.Size = new System.Drawing.Size(132, 21);
            this.cboMO.TabIndex = 9;
            this.cboMO.SelectedIndexChanged += new System.EventHandler(this.cboMO_SelectedIndexChanged);
            this.cboMO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboMO_KeyDown);
            // 
            // txtValorRefMO
            // 
            this.txtValorRefMO.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorRefMO.Enabled = false;
            this.txtValorRefMO.Location = new System.Drawing.Point(150, 36);
            this.txtValorRefMO.Name = "txtValorRefMO";
            this.txtValorRefMO.Size = new System.Drawing.Size(75, 20);
            this.txtValorRefMO.TabIndex = 10;
            this.txtValorRefMO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorRefMO_KeyDown);
            // 
            // txtValorMOPintura
            // 
            this.txtValorMOPintura.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorMOPintura.Enabled = false;
            this.txtValorMOPintura.Location = new System.Drawing.Point(150, 61);
            this.txtValorMOPintura.Name = "txtValorMOPintura";
            this.txtValorMOPintura.Size = new System.Drawing.Size(75, 20);
            this.txtValorMOPintura.TabIndex = 13;
            this.txtValorMOPintura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorMOPintura_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtValorTotalMOPintura);
            this.panel1.Controls.Add(this.txtValorTotalMO);
            this.panel1.Controls.Add(this.txtValorRefMO);
            this.panel1.Controls.Add(this.txtValorMOPintura);
            this.panel1.Controls.Add(this.cboMO);
            this.panel1.Controls.Add(this.lblTituloPintura);
            this.panel1.Controls.Add(this.txtHoraMO);
            this.panel1.Controls.Add(this.txtHoraMOPintura);
            this.panel1.Controls.Add(this.lblTituloHoras);
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 86);
            this.panel1.TabIndex = 8;
            // 
            // txtValorTotalMO
            // 
            this.txtValorTotalMO.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotalMO.Enabled = false;
            this.txtValorTotalMO.Location = new System.Drawing.Point(299, 36);
            this.txtValorTotalMO.Name = "txtValorTotalMO";
            this.txtValorTotalMO.ReadOnly = true;
            this.txtValorTotalMO.Size = new System.Drawing.Size(84, 20);
            this.txtValorTotalMO.TabIndex = 12;
            this.txtValorTotalMO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTotalMO_KeyDown);
            // 
            // txtValorTotalMOPintura
            // 
            this.txtValorTotalMOPintura.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotalMOPintura.Enabled = false;
            this.txtValorTotalMOPintura.Location = new System.Drawing.Point(299, 61);
            this.txtValorTotalMOPintura.Name = "txtValorTotalMOPintura";
            this.txtValorTotalMOPintura.ReadOnly = true;
            this.txtValorTotalMOPintura.Size = new System.Drawing.Size(84, 20);
            this.txtValorTotalMOPintura.TabIndex = 15;
            this.txtValorTotalMOPintura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorTotalMOPintura_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Valor Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(231, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(299, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Total Horas (R$)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(156, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 109;
            this.label4.Text = "MÃO DE OBRA";
            // 
            // frmIncluirItemOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(395, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCodigoPeca);
            this.Controls.Add(this.cboOperacao);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblTituloTotal);
            this.Controls.Add(this.txtValorLiquido);
            this.Controls.Add(this.lblTituloValorLiquido);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.lblTituloDesconto);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.lblTituloValorBruto);
            this.Controls.Add(this.txtQnt);
            this.Controls.Add(this.lblTituloQnt);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblTituloDescricao);
            this.Controls.Add(this.txtCodFabrica);
            this.Controls.Add(this.lblTituloOperacao);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.lblTituloCodPEca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncluirItemOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARES ADM - Incluir item";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        public System.Windows.Forms.Label lblTituloOperacao;
        public System.Windows.Forms.TextBox txtCodFabrica;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.Label lblTituloDescricao;
        public System.Windows.Forms.TextBox txtQnt;
        public System.Windows.Forms.Label lblTituloQnt;
        public System.Windows.Forms.TextBox txtValorBruto;
        public System.Windows.Forms.Label lblTituloValorBruto;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.Label lblTituloDesconto;
        public System.Windows.Forms.TextBox txtValorLiquido;
        public System.Windows.Forms.Label lblTituloValorLiquido;
        public System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.Label lblTituloTotal;
        public System.Windows.Forms.TextBox txtHoraMO;
        public System.Windows.Forms.Label lblTituloHoras;
        public System.Windows.Forms.TextBox txtHoraMOPintura;
        public System.Windows.Forms.Label lblTituloPintura;
        public System.Windows.Forms.ComboBox cboOperacao;
        public System.Windows.Forms.Button btnCodigoPeca;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Label lblTituloCodPEca;
        public System.Windows.Forms.ComboBox cboMO;
        public System.Windows.Forms.TextBox txtValorRefMO;
        public System.Windows.Forms.TextBox txtValorMOPintura;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtValorTotalMOPintura;
        public System.Windows.Forms.TextBox txtValorTotalMO;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
    }
}