namespace ARES_ADM
{
    partial class frmIncluirPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirPeca));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCustoTipo = new System.Windows.Forms.Label();
            this.lblTituloAplicacaoDano = new System.Windows.Forms.Label();
            this.lblTituloDescricao = new System.Windows.Forms.Label();
            this.lblTituloCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.cboAplicacaoDano = new System.Windows.Forms.ComboBox();
            this.cboTipoPeca = new System.Windows.Forms.ComboBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblTituloQNT = new System.Windows.Forms.Label();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.lblTituloUnitario = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.btnFechar.SuspendLayout();
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
            this.pnCabecalho.Size = new System.Drawing.Size(348, 35);
            this.pnCabecalho.TabIndex = 3;
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
            this.lblTituloForm.Size = new System.Drawing.Size(166, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "ARES ADM - Incluir peça";
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
            this.btnFechar.Controls.Add(this.label1);
            this.btnFechar.Location = new System.Drawing.Point(313, 0);
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
            // lblTituloCustoTipo
            // 
            this.lblTituloCustoTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloCustoTipo.AutoSize = true;
            this.lblTituloCustoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloCustoTipo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCustoTipo.Location = new System.Drawing.Point(12, 172);
            this.lblTituloCustoTipo.Name = "lblTituloCustoTipo";
            this.lblTituloCustoTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTituloCustoTipo.TabIndex = 12;
            this.lblTituloCustoTipo.Text = "Custo";
            // 
            // lblTituloAplicacaoDano
            // 
            this.lblTituloAplicacaoDano.AutoSize = true;
            this.lblTituloAplicacaoDano.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloAplicacaoDano.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloAplicacaoDano.Location = new System.Drawing.Point(12, 103);
            this.lblTituloAplicacaoDano.Name = "lblTituloAplicacaoDano";
            this.lblTituloAplicacaoDano.Size = new System.Drawing.Size(52, 13);
            this.lblTituloAplicacaoDano.TabIndex = 11;
            this.lblTituloAplicacaoDano.Text = "Aplicação";
            // 
            // lblTituloDescricao
            // 
            this.lblTituloDescricao.AutoSize = true;
            this.lblTituloDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloDescricao.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloDescricao.Location = new System.Drawing.Point(12, 80);
            this.lblTituloDescricao.Name = "lblTituloDescricao";
            this.lblTituloDescricao.Size = new System.Drawing.Size(53, 13);
            this.lblTituloDescricao.TabIndex = 9;
            this.lblTituloDescricao.Text = "Descrição";
            // 
            // lblTituloCodigo
            // 
            this.lblTituloCodigo.AutoSize = true;
            this.lblTituloCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloCodigo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCodigo.Location = new System.Drawing.Point(12, 57);
            this.lblTituloCodigo.Name = "lblTituloCodigo";
            this.lblTituloCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblTituloCodigo.TabIndex = 8;
            this.lblTituloCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(161, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(92, 76);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(234, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCusto.Location = new System.Drawing.Point(92, 169);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.ReadOnly = true;
            this.txtCusto.Size = new System.Drawing.Size(161, 20);
            this.txtCusto.TabIndex = 5;
            this.txtCusto.Enter += new System.EventHandler(this.txtCusto_Enter);
            this.txtCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusto_KeyDown);
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // cboAplicacaoDano
            // 
            this.cboAplicacaoDano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAplicacaoDano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAplicacaoDano.FormattingEnabled = true;
            this.cboAplicacaoDano.Location = new System.Drawing.Point(92, 99);
            this.cboAplicacaoDano.Name = "cboAplicacaoDano";
            this.cboAplicacaoDano.Size = new System.Drawing.Size(161, 21);
            this.cboAplicacaoDano.TabIndex = 2;
            this.cboAplicacaoDano.Enter += new System.EventHandler(this.cboAplicacaoDano_Enter);
            this.cboAplicacaoDano.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAplicacaoDano_KeyDown);
            this.cboAplicacaoDano.Leave += new System.EventHandler(this.cboAplicacaoDano_Leave);
            // 
            // cboTipoPeca
            // 
            this.cboTipoPeca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTipoPeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPeca.FormattingEnabled = true;
            this.cboTipoPeca.Location = new System.Drawing.Point(92, 169);
            this.cboTipoPeca.Name = "cboTipoPeca";
            this.cboTipoPeca.Size = new System.Drawing.Size(161, 21);
            this.cboTipoPeca.TabIndex = 6;
            this.cboTipoPeca.Enter += new System.EventHandler(this.cboTipoPeca_Enter);
            this.cboTipoPeca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboTipoPeca_KeyDown);
            this.cboTipoPeca.Leave += new System.EventHandler(this.cboTipoPeca_Leave);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(80, 204);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(189, 34);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Incluir";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            this.btnGravar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGravar_KeyDown);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquisa.Location = new System.Drawing.Point(259, 51);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(67, 22);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            this.btnPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPesquisa_KeyDown);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(92, 123);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(161, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            this.txtQuantidade.Validated += new System.EventHandler(this.txtQuantidade_Validated);
            // 
            // lblTituloQNT
            // 
            this.lblTituloQNT.AutoSize = true;
            this.lblTituloQNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloQNT.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloQNT.Location = new System.Drawing.Point(12, 126);
            this.lblTituloQNT.Name = "lblTituloQNT";
            this.lblTituloQNT.Size = new System.Drawing.Size(62, 13);
            this.lblTituloQNT.TabIndex = 23;
            this.lblTituloQNT.Text = "Quantidade";
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(92, 146);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(161, 20);
            this.txtUnitario.TabIndex = 4;
            this.txtUnitario.Enter += new System.EventHandler(this.txtUnitario_Enter);
            this.txtUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitario_KeyDown);
            this.txtUnitario.Leave += new System.EventHandler(this.txtUnitario_Leave);
            // 
            // lblTituloUnitario
            // 
            this.lblTituloUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloUnitario.AutoSize = true;
            this.lblTituloUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloUnitario.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloUnitario.Location = new System.Drawing.Point(12, 149);
            this.lblTituloUnitario.Name = "lblTituloUnitario";
            this.lblTituloUnitario.Size = new System.Drawing.Size(42, 13);
            this.lblTituloUnitario.TabIndex = 25;
            this.lblTituloUnitario.Text = "Unitário";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblPercent.ForeColor = System.Drawing.Color.Silver;
            this.lblPercent.Location = new System.Drawing.Point(256, 103);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(16, 13);
            this.lblPercent.TabIndex = 26;
            this.lblPercent.Text = "%";
            // 
            // frmIncluirPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(348, 248);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblTituloUnitario);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.lblTituloQNT);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cboAplicacaoDano);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTituloCustoTipo);
            this.Controls.Add(this.lblTituloAplicacaoDano);
            this.Controls.Add(this.lblTituloDescricao);
            this.Controls.Add(this.lblTituloCodigo);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.cboTipoPeca);
            this.Controls.Add(this.txtQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncluirPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARES ADM - Incluir peça";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTituloCustoTipo;
        public System.Windows.Forms.Label lblTituloAplicacaoDano;
        public System.Windows.Forms.Label lblTituloDescricao;
        public System.Windows.Forms.Label lblTituloCodigo;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Label lblTituloQNT;
        public System.Windows.Forms.Label lblTituloUnitario;
        public System.Windows.Forms.Label lblPercent;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtCusto;
        public System.Windows.Forms.ComboBox cboAplicacaoDano;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtUnitario;
        public System.Windows.Forms.ComboBox cboTipoPeca;
    }
}