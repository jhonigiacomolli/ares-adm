namespace SHARP_INK
{
    partial class frmApontamentoFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApontamentoFunc));
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.cboFuncao = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtSaida = new System.Windows.Forms.DateTimePicker();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.pnCabecalho.SuspendLayout();
            this.btnFechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquisa.Location = new System.Drawing.Point(286, 49);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(67, 22);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            this.btnPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPesquisa_KeyDown);
            // 
            // cboFuncao
            // 
            this.cboFuncao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboFuncao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFuncao.FormattingEnabled = true;
            this.cboFuncao.Location = new System.Drawing.Point(93, 106);
            this.cboFuncao.Name = "cboFuncao";
            this.cboFuncao.Size = new System.Drawing.Size(263, 21);
            this.cboFuncao.TabIndex = 2;
            this.cboFuncao.Enter += new System.EventHandler(this.cboFuncao_Enter);
            this.cboFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboFuncao_KeyDown);
            this.cboFuncao.Leave += new System.EventHandler(this.cboFuncao_Leave);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(91, 199);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(189, 34);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Incluir";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
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
            this.pnCabecalho.Size = new System.Drawing.Size(380, 35);
            this.pnCabecalho.TabIndex = 31;
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
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(256, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Apontamento Funcionário";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.Controls.Add(this.label1);
            this.btnFechar.Location = new System.Drawing.Point(345, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.Location = new System.Drawing.Point(93, 81);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(263, 20);
            this.txtFuncionario.TabIndex = 1;
            this.txtFuncionario.Enter += new System.EventHandler(this.txtFuncionario_Enter);
            this.txtFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFuncionario_KeyDown);
            this.txtFuncionario.Leave += new System.EventHandler(this.txtFuncionario_Leave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Silver;
            this.lblCodigo.Location = new System.Drawing.Point(20, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Location = new System.Drawing.Point(93, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.ForeColor = System.Drawing.Color.Silver;
            this.lblFuncionario.Location = new System.Drawing.Point(20, 85);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 38;
            this.lblFuncionario.Text = "Funcionário";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.ForeColor = System.Drawing.Color.Silver;
            this.lblSaida.Location = new System.Drawing.Point(20, 171);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(34, 13);
            this.lblSaida.TabIndex = 41;
            this.lblSaida.Text = "Saida";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.ForeColor = System.Drawing.Color.Silver;
            this.lblFuncao.Location = new System.Drawing.Point(20, 110);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(43, 13);
            this.lblFuncao.TabIndex = 39;
            this.lblFuncao.Text = "Função";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.ForeColor = System.Drawing.Color.Silver;
            this.lblEntrada.Location = new System.Drawing.Point(20, 147);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 40;
            this.lblEntrada.Text = "Entrada";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(227, 144);
            this.txtHoraEntrada.Mask = "99:99:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(129, 20);
            this.txtHoraEntrada.TabIndex = 4;
            this.txtHoraEntrada.Enter += new System.EventHandler(this.txtHoraEntrada_Enter);
            this.txtHoraEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoraEntrada_KeyDown);
            this.txtHoraEntrada.Leave += new System.EventHandler(this.txtHoraEntrada_Leave);
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(227, 168);
            this.txtHoraSaida.Mask = "99:99:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(129, 20);
            this.txtHoraSaida.TabIndex = 6;
            this.txtHoraSaida.Enter += new System.EventHandler(this.txtHoraSaida_Enter);
            this.txtHoraSaida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoraSaida_KeyDown);
            this.txtHoraSaida.Leave += new System.EventHandler(this.txtHoraSaida_Leave);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEntrada.Location = new System.Drawing.Point(93, 144);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(130, 20);
            this.txtEntrada.TabIndex = 3;
            this.txtEntrada.Enter += new System.EventHandler(this.txtEntrada_Enter);
            this.txtEntrada.Leave += new System.EventHandler(this.txtEntrada_Leave);
            // 
            // txtSaida
            // 
            this.txtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSaida.Location = new System.Drawing.Point(93, 168);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(130, 20);
            this.txtSaida.TabIndex = 5;
            this.txtSaida.Enter += new System.EventHandler(this.txtSaida_Enter);
            this.txtSaida.Leave += new System.EventHandler(this.txtSaida_Leave);
            // 
            // txtValorHora
            // 
            this.txtValorHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorHora.Location = new System.Drawing.Point(330, 208);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(23, 20);
            this.txtValorHora.TabIndex = 42;
            // 
            // pnFavIcon
            // 
            this.pnFavIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnFavIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFavIcon.BackgroundImage")));
            this.pnFavIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnFavIcon.Location = new System.Drawing.Point(10, 0);
            this.pnFavIcon.Name = "pnFavIcon";
            this.pnFavIcon.Size = new System.Drawing.Size(35, 35);
            this.pnFavIcon.TabIndex = 2;
            // 
            // frmApontamentoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(380, 250);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.cboFuncao);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApontamentoFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmApontamentoFunc_KeyDown);
            this.Resize += new System.EventHandler(this.frmApontamentoFunc_Resize);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFuncionario;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblFuncionario;
        public System.Windows.Forms.Label lblSaida;
        public System.Windows.Forms.Label lblFuncao;
        public System.Windows.Forms.Label lblEntrada;
        public System.Windows.Forms.ComboBox cboFuncao;
        public System.Windows.Forms.DateTimePicker txtEntrada;
        public System.Windows.Forms.DateTimePicker txtSaida;
        public System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        public System.Windows.Forms.MaskedTextBox txtHoraSaida;
        public System.Windows.Forms.TextBox txtValorHora;
    }
}