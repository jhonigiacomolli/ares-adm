namespace ARES_ADM
{
    partial class frmCadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProdutos));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.txtCodFabrica = new System.Windows.Forms.TextBox();
            this.lblTituloCodFabrica = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTituloDescricao = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.lblTituloGrupo = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblTituloCusto = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.lblTituloVenda = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.lblTituloFornecedor = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.lblTituloMargem = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Black;
            this.pnCabecalho.Controls.Add(this.lblTituloForm);
            this.pnCabecalho.Controls.Add(this.pnFavIcon);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(408, 35);
            this.pnCabecalho.TabIndex = 9;
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
            this.lblTituloForm.Size = new System.Drawing.Size(172, 20);
            this.lblTituloForm.TabIndex = 10;
            this.lblTituloForm.Text = "ARES ADM - Cadastro";
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
            this.pnFavIcon.TabIndex = 11;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.BackgroundImage = global::ARES_ADM.Properties.Resources.Close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Location = new System.Drawing.Point(373, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtCodFabrica
            // 
            this.txtCodFabrica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodFabrica.Location = new System.Drawing.Point(99, 77);
            this.txtCodFabrica.Name = "txtCodFabrica";
            this.txtCodFabrica.Size = new System.Drawing.Size(296, 20);
            this.txtCodFabrica.TabIndex = 1;
            this.txtCodFabrica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodFabrica_KeyDown);
            // 
            // lblTituloCodFabrica
            // 
            this.lblTituloCodFabrica.AutoSize = true;
            this.lblTituloCodFabrica.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCodFabrica.Location = new System.Drawing.Point(18, 81);
            this.lblTituloCodFabrica.Name = "lblTituloCodFabrica";
            this.lblTituloCodFabrica.Size = new System.Drawing.Size(78, 13);
            this.lblTituloCodFabrica.TabIndex = 5;
            this.lblTituloCodFabrica.Text = "Código Fábrica";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(99, 130);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(296, 20);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // lblTituloDescricao
            // 
            this.lblTituloDescricao.AutoSize = true;
            this.lblTituloDescricao.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloDescricao.Location = new System.Drawing.Point(18, 134);
            this.lblTituloDescricao.Name = "lblTituloDescricao";
            this.lblTituloDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblTituloDescricao.TabIndex = 7;
            this.lblTituloDescricao.Text = "Descrição";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(99, 50);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(296, 21);
            this.cboGrupo.TabIndex = 0;
            this.cboGrupo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboGrupo_KeyDown);
            // 
            // lblTituloGrupo
            // 
            this.lblTituloGrupo.AutoSize = true;
            this.lblTituloGrupo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloGrupo.Location = new System.Drawing.Point(18, 55);
            this.lblTituloGrupo.Name = "lblTituloGrupo";
            this.lblTituloGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblTituloGrupo.TabIndex = 9;
            this.lblTituloGrupo.Text = "Grupo";
            // 
            // txtCusto
            // 
            this.txtCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCusto.Location = new System.Drawing.Point(99, 156);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(176, 20);
            this.txtCusto.TabIndex = 4;
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCusto_KeyDown);
            this.txtCusto.Validated += new System.EventHandler(this.txtCusto_Validated);
            // 
            // lblTituloCusto
            // 
            this.lblTituloCusto.AutoSize = true;
            this.lblTituloCusto.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCusto.Location = new System.Drawing.Point(18, 160);
            this.lblTituloCusto.Name = "lblTituloCusto";
            this.lblTituloCusto.Size = new System.Drawing.Size(65, 13);
            this.lblTituloCusto.TabIndex = 11;
            this.lblTituloCusto.Text = "Preço Custo";
            // 
            // txtVenda
            // 
            this.txtVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVenda.Location = new System.Drawing.Point(99, 205);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(176, 20);
            this.txtVenda.TabIndex = 6;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVenda_KeyDown);
            this.txtVenda.Validated += new System.EventHandler(this.txtVenda_Validated);
            // 
            // lblTituloVenda
            // 
            this.lblTituloVenda.AutoSize = true;
            this.lblTituloVenda.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloVenda.Location = new System.Drawing.Point(18, 209);
            this.lblTituloVenda.Name = "lblTituloVenda";
            this.lblTituloVenda.Size = new System.Drawing.Size(69, 13);
            this.lblTituloVenda.TabIndex = 13;
            this.lblTituloVenda.Text = "Preço Venda";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(99, 103);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(296, 21);
            this.cboFornecedor.TabIndex = 2;
            this.cboFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboFornecedor_KeyDown);
            // 
            // lblTituloFornecedor
            // 
            this.lblTituloFornecedor.AutoSize = true;
            this.lblTituloFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloFornecedor.Location = new System.Drawing.Point(18, 108);
            this.lblTituloFornecedor.Name = "lblTituloFornecedor";
            this.lblTituloFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblTituloFornecedor.TabIndex = 15;
            this.lblTituloFornecedor.Text = "Fornecedor";
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(60, 239);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(144, 40);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Cadastrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Silver;
            this.btnCancelar.Location = new System.Drawing.Point(210, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMargem
            // 
            this.txtMargem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMargem.Location = new System.Drawing.Point(99, 180);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(176, 20);
            this.txtMargem.TabIndex = 5;
            this.txtMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMargem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMargem_KeyDown);
            this.txtMargem.Validated += new System.EventHandler(this.txtMargem_Validated);
            // 
            // lblTituloMargem
            // 
            this.lblTituloMargem.AutoSize = true;
            this.lblTituloMargem.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloMargem.Location = new System.Drawing.Point(18, 184);
            this.lblTituloMargem.Name = "lblTituloMargem";
            this.lblTituloMargem.Size = new System.Drawing.Size(45, 13);
            this.lblTituloMargem.TabIndex = 17;
            this.lblTituloMargem.Text = "Margem";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Silver;
            this.lblPercent.Location = new System.Drawing.Point(281, 184);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(16, 13);
            this.lblPercent.TabIndex = 18;
            this.lblPercent.Text = "%";
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(408, 291);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.txtMargem);
            this.Controls.Add(this.lblTituloMargem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.lblTituloFornecedor);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.lblTituloVenda);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblTituloCusto);
            this.Controls.Add(this.cboGrupo);
            this.Controls.Add(this.lblTituloGrupo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblTituloDescricao);
            this.Controls.Add(this.txtCodFabrica);
            this.Controls.Add(this.lblTituloCodFabrica);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
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
        public System.Windows.Forms.TextBox txtCodFabrica;
        public System.Windows.Forms.Label lblTituloCodFabrica;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.Label lblTituloDescricao;
        public System.Windows.Forms.ComboBox cboGrupo;
        public System.Windows.Forms.Label lblTituloGrupo;
        public System.Windows.Forms.TextBox txtCusto;
        public System.Windows.Forms.Label lblTituloCusto;
        public System.Windows.Forms.TextBox txtVenda;
        public System.Windows.Forms.Label lblTituloVenda;
        public System.Windows.Forms.ComboBox cboFornecedor;
        public System.Windows.Forms.Label lblTituloFornecedor;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtMargem;
        public System.Windows.Forms.Label lblTituloMargem;
        public System.Windows.Forms.Label lblPercent;
    }
}