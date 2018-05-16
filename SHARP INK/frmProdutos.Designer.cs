namespace SHARP_INK
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPalavraChave = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
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
            this.pnCabecalho.Size = new System.Drawing.Size(1200, 35);
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
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(151, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Produtos";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
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
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFechar.Controls.Add(this.label1);
            this.btnFechar.Location = new System.Drawing.Point(1165, 0);
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
            // lstProdutos
            // 
            this.lstProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProdutos.Location = new System.Drawing.Point(0, 35);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(1200, 457);
            this.lstProdutos.TabIndex = 4;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.DoubleClick += new System.EventHandler(this.lstProdutos_DoubleClick);
            this.lstProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProdutos_KeyDown);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.Silver;
            this.btnIncluir.Location = new System.Drawing.Point(10, 548);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(136, 34);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIncluir_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(152, 548);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 34);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEditar_KeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(294, 548);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 34);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExcluir_KeyDown);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPesquisa.Location = new System.Drawing.Point(192, 516);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(996, 24);
            this.txtPesquisa.TabIndex = 9;
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // lblPalavraChave
            // 
            this.lblPalavraChave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalavraChave.AutoSize = true;
            this.lblPalavraChave.ForeColor = System.Drawing.Color.Silver;
            this.lblPalavraChave.Location = new System.Drawing.Point(192, 502);
            this.lblPalavraChave.Name = "lblPalavraChave";
            this.lblPalavraChave.Size = new System.Drawing.Size(76, 13);
            this.lblPalavraChave.TabIndex = 10;
            this.lblPalavraChave.Text = "Palavra-chave";
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(10, 516);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(176, 23);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboCampo_KeyDown);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCampo.AutoSize = true;
            this.lblCampo.ForeColor = System.Drawing.Color.Silver;
            this.lblCampo.Location = new System.Drawing.Point(10, 500);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1200, 594);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblPalavraChave);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
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
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Label lblPalavraChave;
        private System.Windows.Forms.ComboBox cboCampo;
        public System.Windows.Forms.Label lblCampo;
        public System.Windows.Forms.ListView lstProdutos;
    }
}