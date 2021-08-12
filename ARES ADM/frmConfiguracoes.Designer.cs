namespace ARES_ADM
{
    partial class frmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.cboTipoBancoHoras = new System.Windows.Forms.ComboBox();
            this.lblTituloRazao = new System.Windows.Forms.Label();
            this.lblTituloEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTituloEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTituloBancoHoras = new System.Windows.Forms.Label();
            this.txtCNPJ_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTituloCNPJ = new System.Windows.Forms.Label();
            this.lblTituloTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInfoTec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDatasheet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCatalisesOriginais = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboValorCatalises = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
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
            this.pnCabecalho.Size = new System.Drawing.Size(969, 35);
            this.pnCabecalho.TabIndex = 32;
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            this.pnCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseUp);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(42, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(183, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "ARES ADM - Configurações";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
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
            this.btnFechar.Location = new System.Drawing.Point(934, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BackColor = System.Drawing.Color.Silver;
            this.txtRazaoSocial.Location = new System.Drawing.Point(135, 65);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(453, 20);
            this.txtRazaoSocial.TabIndex = 33;
            // 
            // cboTipoBancoHoras
            // 
            this.cboTipoBancoHoras.BackColor = System.Drawing.Color.Silver;
            this.cboTipoBancoHoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBancoHoras.FormattingEnabled = true;
            this.cboTipoBancoHoras.Items.AddRange(new object[] {
            "BANCO DE HORAS AUTOMÁTICO",
            "BANCO DE HORAS MANUAL",
            "APENAS REGISTRO"});
            this.cboTipoBancoHoras.Location = new System.Drawing.Point(186, 235);
            this.cboTipoBancoHoras.Name = "cboTipoBancoHoras";
            this.cboTipoBancoHoras.Size = new System.Drawing.Size(266, 21);
            this.cboTipoBancoHoras.TabIndex = 34;
            // 
            // lblTituloRazao
            // 
            this.lblTituloRazao.AutoSize = true;
            this.lblTituloRazao.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloRazao.Location = new System.Drawing.Point(45, 68);
            this.lblTituloRazao.Name = "lblTituloRazao";
            this.lblTituloRazao.Size = new System.Drawing.Size(70, 13);
            this.lblTituloRazao.TabIndex = 35;
            this.lblTituloRazao.Text = "Razao Social";
            // 
            // lblTituloEndereco
            // 
            this.lblTituloEndereco.AutoSize = true;
            this.lblTituloEndereco.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloEndereco.Location = new System.Drawing.Point(45, 116);
            this.lblTituloEndereco.Name = "lblTituloEndereco";
            this.lblTituloEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblTituloEndereco.TabIndex = 37;
            this.lblTituloEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(135, 111);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(453, 40);
            this.txtEndereco.TabIndex = 36;
            // 
            // lblTituloEmail
            // 
            this.lblTituloEmail.AutoSize = true;
            this.lblTituloEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloEmail.Location = new System.Drawing.Point(45, 158);
            this.lblTituloEmail.Name = "lblTituloEmail";
            this.lblTituloEmail.Size = new System.Drawing.Size(32, 13);
            this.lblTituloEmail.TabIndex = 39;
            this.lblTituloEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(135, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(453, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // lblTituloBancoHoras
            // 
            this.lblTituloBancoHoras.AutoSize = true;
            this.lblTituloBancoHoras.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloBancoHoras.Location = new System.Drawing.Point(45, 238);
            this.lblTituloBancoHoras.Name = "lblTituloBancoHoras";
            this.lblTituloBancoHoras.Size = new System.Drawing.Size(84, 13);
            this.lblTituloBancoHoras.TabIndex = 40;
            this.lblTituloBancoHoras.Text = "Banco de Horas";
            // 
            // txtCNPJ_CPF
            // 
            this.txtCNPJ_CPF.BackColor = System.Drawing.Color.Silver;
            this.txtCNPJ_CPF.Location = new System.Drawing.Point(135, 88);
            this.txtCNPJ_CPF.Mask = "00.000.000/0000-00";
            this.txtCNPJ_CPF.Name = "txtCNPJ_CPF";
            this.txtCNPJ_CPF.Size = new System.Drawing.Size(453, 20);
            this.txtCNPJ_CPF.TabIndex = 41;
            // 
            // lblTituloCNPJ
            // 
            this.lblTituloCNPJ.AutoSize = true;
            this.lblTituloCNPJ.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCNPJ.Location = new System.Drawing.Point(45, 92);
            this.lblTituloCNPJ.Name = "lblTituloCNPJ";
            this.lblTituloCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblTituloCNPJ.TabIndex = 42;
            this.lblTituloCNPJ.Text = "CNPJ";
            // 
            // lblTituloTelefone
            // 
            this.lblTituloTelefone.AutoSize = true;
            this.lblTituloTelefone.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloTelefone.Location = new System.Drawing.Point(45, 181);
            this.lblTituloTelefone.Name = "lblTituloTelefone";
            this.lblTituloTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTituloTelefone.TabIndex = 44;
            this.lblTituloTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.Silver;
            this.txtTelefone.Location = new System.Drawing.Point(135, 177);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(453, 20);
            this.txtTelefone.TabIndex = 43;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(277, 403);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(189, 34);
            this.btnGravar.TabIndex = 45;
            this.btnGravar.Text = "Salvar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Location = new System.Drawing.Point(472, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(189, 34);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(45, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "CATALISES - Exibir Informações Técnicas";
            // 
            // cboInfoTec
            // 
            this.cboInfoTec.BackColor = System.Drawing.Color.Silver;
            this.cboInfoTec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInfoTec.FormattingEnabled = true;
            this.cboInfoTec.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cboInfoTec.Location = new System.Drawing.Point(309, 262);
            this.cboInfoTec.Name = "cboInfoTec";
            this.cboInfoTec.Size = new System.Drawing.Size(143, 21);
            this.cboInfoTec.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(45, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "CATALISES - Exibir Boletim Técnico";
            // 
            // cboDatasheet
            // 
            this.cboDatasheet.BackColor = System.Drawing.Color.Silver;
            this.cboDatasheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatasheet.FormattingEnabled = true;
            this.cboDatasheet.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cboDatasheet.Location = new System.Drawing.Point(309, 289);
            this.cboDatasheet.Name = "cboDatasheet";
            this.cboDatasheet.Size = new System.Drawing.Size(143, 21);
            this.cboDatasheet.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(45, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "CATALISES - Exibir Catalises Originais de Fabricantes";
            // 
            // cboCatalisesOriginais
            // 
            this.cboCatalisesOriginais.BackColor = System.Drawing.Color.Silver;
            this.cboCatalisesOriginais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatalisesOriginais.FormattingEnabled = true;
            this.cboCatalisesOriginais.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cboCatalisesOriginais.Location = new System.Drawing.Point(309, 316);
            this.cboCatalisesOriginais.Name = "cboCatalisesOriginais";
            this.cboCatalisesOriginais.Size = new System.Drawing.Size(143, 21);
            this.cboCatalisesOriginais.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(45, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "CATALISES - Exibir Valor das Catalises";
            // 
            // cboValorCatalises
            // 
            this.cboValorCatalises.BackColor = System.Drawing.Color.Silver;
            this.cboValorCatalises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValorCatalises.FormattingEnabled = true;
            this.cboValorCatalises.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cboValorCatalises.Location = new System.Drawing.Point(309, 343);
            this.cboValorCatalises.Name = "cboValorCatalises";
            this.cboValorCatalises.Size = new System.Drawing.Size(143, 21);
            this.cboValorCatalises.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(274, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "Dados da Empresa";
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(969, 449);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboValorCatalises);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCatalisesOriginais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDatasheet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboInfoTec);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblTituloTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTituloCNPJ);
            this.Controls.Add(this.txtCNPJ_CPF);
            this.Controls.Add(this.lblTituloBancoHoras);
            this.Controls.Add(this.lblTituloEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTituloEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblTituloRazao);
            this.Controls.Add(this.cboTipoBancoHoras);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARES ADM - Configurações";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        public System.Windows.Forms.TextBox txtRazaoSocial;
        public System.Windows.Forms.ComboBox cboTipoBancoHoras;
        public System.Windows.Forms.Label lblTituloRazao;
        public System.Windows.Forms.Label lblTituloEndereco;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.Label lblTituloEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lblTituloBancoHoras;
        public System.Windows.Forms.MaskedTextBox txtCNPJ_CPF;
        public System.Windows.Forms.Label lblTituloCNPJ;
        public System.Windows.Forms.Label lblTituloTelefone;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboInfoTec;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboDatasheet;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboCatalisesOriginais;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cboValorCatalises;
        public System.Windows.Forms.Label label13;
    }
}