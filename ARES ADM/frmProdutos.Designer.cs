namespace ARES_ADM
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
            this.lstProdutos = new System.Windows.Forms.ListView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPalavraChave = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.pnInfoClientes = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTituloEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblTituloTelefone = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblTituloCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTituloCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblTituloBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCPF_CNPJ = new System.Windows.Forms.Label();
            this.lblTituloEndereco = new System.Windows.Forms.Label();
            this.lblTituloNascimento = new System.Windows.Forms.Label();
            this.lblTituloCPFCNPJ = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.pnInfoClientes.SuspendLayout();
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
            this.lblTituloForm.Location = new System.Drawing.Point(42, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(149, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "ARES ADM - Produtos";
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
            this.btnFechar.Location = new System.Drawing.Point(1165, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lstProdutos
            // 
            this.lstProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProdutos.Location = new System.Drawing.Point(0, 35);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(1200, 356);
            this.lstProdutos.TabIndex = 4;
            this.lstProdutos.UseCompatibleStateImageBehavior = false;
            this.lstProdutos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstProdutos_ColumnWidthChanging);
            this.lstProdutos.SelectedIndexChanged += new System.EventHandler(this.lstProdutos_SelectedIndexChanged);
            this.lstProdutos.DoubleClick += new System.EventHandler(this.lstProdutos_DoubleClick);
            this.lstProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProdutos_KeyDown);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.Silver;
            this.btnIncluir.Location = new System.Drawing.Point(10, 545);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(136, 34);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            this.btnIncluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnIncluir_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(152, 545);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 34);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEditar_KeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(294, 545);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 34);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExcluir_KeyDown);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(192, 513);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(996, 25);
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
            this.lblPalavraChave.Location = new System.Drawing.Point(192, 499);
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
            this.cboCampo.Location = new System.Drawing.Point(10, 513);
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
            this.lblCampo.Location = new System.Drawing.Point(10, 497);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo";
            // 
            // pnInfoClientes
            // 
            this.pnInfoClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnInfoClientes.Controls.Add(this.lblEmail);
            this.pnInfoClientes.Controls.Add(this.lblTituloEmail);
            this.pnInfoClientes.Controls.Add(this.lblTelefone);
            this.pnInfoClientes.Controls.Add(this.lblTituloTelefone);
            this.pnInfoClientes.Controls.Add(this.lblCEP);
            this.pnInfoClientes.Controls.Add(this.lblTituloCEP);
            this.pnInfoClientes.Controls.Add(this.lblCidade);
            this.pnInfoClientes.Controls.Add(this.lblTituloCidade);
            this.pnInfoClientes.Controls.Add(this.lblBairro);
            this.pnInfoClientes.Controls.Add(this.lblTituloBairro);
            this.pnInfoClientes.Controls.Add(this.lblEndereco);
            this.pnInfoClientes.Controls.Add(this.lblDataNascimento);
            this.pnInfoClientes.Controls.Add(this.lblCPF_CNPJ);
            this.pnInfoClientes.Controls.Add(this.lblTituloEndereco);
            this.pnInfoClientes.Controls.Add(this.lblTituloNascimento);
            this.pnInfoClientes.Controls.Add(this.lblTituloCPFCNPJ);
            this.pnInfoClientes.Location = new System.Drawing.Point(10, 402);
            this.pnInfoClientes.Name = "pnInfoClientes";
            this.pnInfoClientes.Size = new System.Drawing.Size(1178, 87);
            this.pnInfoClientes.TabIndex = 13;
            this.pnInfoClientes.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblEmail.Location = new System.Drawing.Point(862, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 15;
            // 
            // lblTituloEmail
            // 
            this.lblTituloEmail.AutoSize = true;
            this.lblTituloEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloEmail.Location = new System.Drawing.Point(796, 36);
            this.lblTituloEmail.Name = "lblTituloEmail";
            this.lblTituloEmail.Size = new System.Drawing.Size(32, 13);
            this.lblTituloEmail.TabIndex = 14;
            this.lblTituloEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.ForeColor = System.Drawing.Color.Silver;
            this.lblTelefone.Location = new System.Drawing.Point(862, 11);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(0, 13);
            this.lblTelefone.TabIndex = 13;
            // 
            // lblTituloTelefone
            // 
            this.lblTituloTelefone.AutoSize = true;
            this.lblTituloTelefone.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloTelefone.Location = new System.Drawing.Point(796, 11);
            this.lblTituloTelefone.Name = "lblTituloTelefone";
            this.lblTituloTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTituloTelefone.TabIndex = 12;
            this.lblTituloTelefone.Text = "Telefone";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.ForeColor = System.Drawing.Color.Silver;
            this.lblCEP.Location = new System.Drawing.Point(491, 61);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(0, 13);
            this.lblCEP.TabIndex = 11;
            // 
            // lblTituloCEP
            // 
            this.lblTituloCEP.AutoSize = true;
            this.lblTituloCEP.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloCEP.Location = new System.Drawing.Point(437, 61);
            this.lblTituloCEP.Name = "lblTituloCEP";
            this.lblTituloCEP.Size = new System.Drawing.Size(28, 13);
            this.lblTituloCEP.TabIndex = 10;
            this.lblTituloCEP.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.Color.Silver;
            this.lblCidade.Location = new System.Drawing.Point(491, 36);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(0, 13);
            this.lblCidade.TabIndex = 9;
            // 
            // lblTituloCidade
            // 
            this.lblTituloCidade.AutoSize = true;
            this.lblTituloCidade.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloCidade.Location = new System.Drawing.Point(437, 36);
            this.lblTituloCidade.Name = "lblTituloCidade";
            this.lblTituloCidade.Size = new System.Drawing.Size(40, 13);
            this.lblTituloCidade.TabIndex = 8;
            this.lblTituloCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.ForeColor = System.Drawing.Color.Silver;
            this.lblBairro.Location = new System.Drawing.Point(491, 11);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(0, 13);
            this.lblBairro.TabIndex = 7;
            // 
            // lblTituloBairro
            // 
            this.lblTituloBairro.AutoSize = true;
            this.lblTituloBairro.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloBairro.Location = new System.Drawing.Point(437, 11);
            this.lblTituloBairro.Name = "lblTituloBairro";
            this.lblTituloBairro.Size = new System.Drawing.Size(34, 13);
            this.lblTituloBairro.TabIndex = 6;
            this.lblTituloBairro.Text = "Bairro";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.ForeColor = System.Drawing.Color.Silver;
            this.lblEndereco.Location = new System.Drawing.Point(105, 61);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco.TabIndex = 5;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Silver;
            this.lblDataNascimento.Location = new System.Drawing.Point(105, 36);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(0, 13);
            this.lblDataNascimento.TabIndex = 4;
            // 
            // lblCPF_CNPJ
            // 
            this.lblCPF_CNPJ.AutoSize = true;
            this.lblCPF_CNPJ.ForeColor = System.Drawing.Color.Silver;
            this.lblCPF_CNPJ.Location = new System.Drawing.Point(105, 11);
            this.lblCPF_CNPJ.Name = "lblCPF_CNPJ";
            this.lblCPF_CNPJ.Size = new System.Drawing.Size(0, 13);
            this.lblCPF_CNPJ.TabIndex = 3;
            // 
            // lblTituloEndereco
            // 
            this.lblTituloEndereco.AutoSize = true;
            this.lblTituloEndereco.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloEndereco.Location = new System.Drawing.Point(10, 61);
            this.lblTituloEndereco.Name = "lblTituloEndereco";
            this.lblTituloEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblTituloEndereco.TabIndex = 2;
            this.lblTituloEndereco.Text = "Endereço";
            // 
            // lblTituloNascimento
            // 
            this.lblTituloNascimento.AutoSize = true;
            this.lblTituloNascimento.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloNascimento.Location = new System.Drawing.Point(10, 36);
            this.lblTituloNascimento.Name = "lblTituloNascimento";
            this.lblTituloNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblTituloNascimento.TabIndex = 1;
            this.lblTituloNascimento.Text = "Data Nascimento";
            // 
            // lblTituloCPFCNPJ
            // 
            this.lblTituloCPFCNPJ.AutoSize = true;
            this.lblTituloCPFCNPJ.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloCPFCNPJ.Location = new System.Drawing.Point(10, 11);
            this.lblTituloCPFCNPJ.Name = "lblTituloCPFCNPJ";
            this.lblTituloCPFCNPJ.Size = new System.Drawing.Size(59, 13);
            this.lblTituloCPFCNPJ.TabIndex = 0;
            this.lblTituloCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1200, 591);
            this.Controls.Add(this.pnInfoClientes);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnInfoClientes.ResumeLayout(false);
            this.pnInfoClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Label lblPalavraChave;
        private System.Windows.Forms.ComboBox cboCampo;
        public System.Windows.Forms.Label lblCampo;
        public System.Windows.Forms.ListView lstProdutos;
        public System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Panel pnInfoClientes;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblTituloEmail;
        public System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.Label lblTituloTelefone;
        public System.Windows.Forms.Label lblCEP;
        public System.Windows.Forms.Label lblTituloCEP;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.Label lblTituloCidade;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.Label lblTituloBairro;
        public System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.Label lblDataNascimento;
        public System.Windows.Forms.Label lblCPF_CNPJ;
        public System.Windows.Forms.Label lblTituloEndereco;
        public System.Windows.Forms.Label lblTituloNascimento;
        public System.Windows.Forms.Label lblTituloCPFCNPJ;
    }
}