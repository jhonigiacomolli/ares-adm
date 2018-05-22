namespace SHARP_INK
{
    partial class frmListaOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaOS));
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVeiculos = new System.Windows.Forms.ListView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnOS = new System.Windows.Forms.Button();
            this.pnMenuOS = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboTipoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblTipoPesquisa = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.btnFechar.SuspendLayout();
            this.pnMenuOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(238, 20);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Ordens de Serivço";
            this.lblTituloForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseDown);
            this.lblTituloForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseMove);
            this.lblTituloForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTituloForm_MouseUp);
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
            this.pnCabecalho.Size = new System.Drawing.Size(1180, 35);
            this.pnCabecalho.TabIndex = 1;
            this.pnCabecalho.Click += new System.EventHandler(this.pnCabecalho_Click);
            this.pnCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseDown);
            this.pnCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseMove);
            this.pnCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnCabecalho_MouseUp);
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
            this.btnFechar.Location = new System.Drawing.Point(1145, 0);
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
            // lstVeiculos
            // 
            this.lstVeiculos.HideSelection = false;
            this.lstVeiculos.Location = new System.Drawing.Point(0, 76);
            this.lstVeiculos.Name = "lstVeiculos";
            this.lstVeiculos.Size = new System.Drawing.Size(1180, 392);
            this.lstVeiculos.TabIndex = 0;
            this.lstVeiculos.UseCompatibleStateImageBehavior = false;
            this.lstVeiculos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstVeiculos_ColumnClick);
            this.lstVeiculos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstVeiculos_ColumnWidthChanging);
            this.lstVeiculos.SelectedIndexChanged += new System.EventHandler(this.lstVeiculos_SelectedIndexChanged);
            this.lstVeiculos.DoubleClick += new System.EventHandler(this.lstVeiculos_DoubleClick);
            this.lstVeiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstVeiculos_KeyDown);
            this.lstVeiculos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstVeiculos_MouseDown);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.Silver;
            this.btnFinalizar.Location = new System.Drawing.Point(161, 477);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(143, 44);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar OS";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnFinalizar_KeyDown);
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.ForeColor = System.Drawing.Color.Silver;
            this.btnAbrir.Location = new System.Drawing.Point(12, 477);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(143, 44);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Ver Detalhes";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            this.btnAbrir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAbrir_KeyDown);
            // 
            // btnOS
            // 
            this.btnOS.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOS.FlatAppearance.BorderSize = 0;
            this.btnOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOS.ForeColor = System.Drawing.Color.Silver;
            this.btnOS.Location = new System.Drawing.Point(12, 41);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(113, 29);
            this.btnOS.TabIndex = 8;
            this.btnOS.Text = "Ordem de Serviço";
            this.btnOS.UseVisualStyleBackColor = true;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            this.btnOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOS_KeyDown);
            // 
            // pnMenuOS
            // 
            this.pnMenuOS.Controls.Add(this.btnExcluir);
            this.pnMenuOS.Controls.Add(this.btnEditar);
            this.pnMenuOS.Controls.Add(this.btnAdicionar);
            this.pnMenuOS.Location = new System.Drawing.Point(10, 70);
            this.pnMenuOS.Name = "pnMenuOS";
            this.pnMenuOS.Size = new System.Drawing.Size(143, 89);
            this.pnMenuOS.TabIndex = 9;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(0, 53);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 26);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExcluir_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(0, 28);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 26);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEditar_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.Silver;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(143, 25);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdicionar_KeyDown);
            // 
            // cboTipoPesquisa
            // 
            this.cboTipoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTipoPesquisa.FormattingEnabled = true;
            this.cboTipoPesquisa.Location = new System.Drawing.Point(329, 500);
            this.cboTipoPesquisa.Name = "cboTipoPesquisa";
            this.cboTipoPesquisa.Size = new System.Drawing.Size(176, 24);
            this.cboTipoPesquisa.TabIndex = 10;
            this.cboTipoPesquisa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPesquisa_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPesquisa.Location = new System.Drawing.Point(511, 499);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(643, 26);
            this.txtPesquisa.TabIndex = 11;
            this.txtPesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisa_MouseClick);
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.AutoSize = true;
            this.lblTipoPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoPesquisa.Location = new System.Drawing.Point(329, 480);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(123, 13);
            this.lblTipoPesquisa.TabIndex = 12;
            this.lblTipoPesquisa.Text = "Selecione o tipo de Filtro";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.lblPesquisa.Location = new System.Drawing.Point(508, 480);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(204, 13);
            this.lblPesquisa.TabIndex = 13;
            this.lblPesquisa.Text = "Digite a palavra passe para sua pesquisa:";
            // 
            // frmListaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1180, 541);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblTipoPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cboTipoPesquisa);
            this.Controls.Add(this.pnMenuOS);
            this.Controls.Add(this.btnOS);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lstVeiculos);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaOS";
            this.Click += new System.EventHandler(this.frmListaOS_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListaOS_KeyDown);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            this.pnMenuOS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView lstVeiculos;
        public System.Windows.Forms.Panel pnMenuOS;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnAdicionar;
        public System.Windows.Forms.Button btnOS;
        public System.Windows.Forms.ComboBox cboTipoPesquisa;
        public System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.Label lblTipoPesquisa;
        public System.Windows.Forms.Label lblPesquisa;
        public System.Windows.Forms.Button btnFinalizar;
        public System.Windows.Forms.Button btnAbrir;
    }
}