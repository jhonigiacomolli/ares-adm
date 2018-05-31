namespace SHARP_INK
{
    partial class frmPaginaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaginaInicial));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.pnMinimizar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenuStrip = new System.Windows.Forms.Panel();
            this.menuRelatorios = new System.Windows.Forms.Button();
            this.menuCadastro = new System.Windows.Forms.Button();
            this.pnAjuste = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.btnOrdemServico = new System.Windows.Forms.PictureBox();
            this.picBackgorund = new System.Windows.Forms.PictureBox();
            this.btnProdutos = new System.Windows.Forms.PictureBox();
            this.btnCatalises = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new System.Windows.Forms.PictureBox();
            this.btnAlocacao = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.lblTituloRodape = new System.Windows.Forms.Label();
            this.lblDescricaoRodape = new System.Windows.Forms.Label();
            this.lblEmailRodape = new System.Windows.Forms.Label();
            this.lblTelefoneRodape = new System.Windows.Forms.Label();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.txtRelogio = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.pnMinimizar.SuspendLayout();
            this.btnFechar.SuspendLayout();
            this.pnMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrdemServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgorund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCatalises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.BackColor = System.Drawing.Color.Black;
            this.pnCabecalho.Controls.Add(this.pnMinimizar);
            this.pnCabecalho.Controls.Add(this.lblTituloForm);
            this.pnCabecalho.Controls.Add(this.pnFavIcon);
            this.pnCabecalho.Controls.Add(this.btnFechar);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(1475, 35);
            this.pnCabecalho.TabIndex = 0;
            // 
            // pnMinimizar
            // 
            this.pnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pnMinimizar.Controls.Add(this.label2);
            this.pnMinimizar.Location = new System.Drawing.Point(1403, 0);
            this.pnMinimizar.Name = "pnMinimizar";
            this.pnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.pnMinimizar.TabIndex = 2;
            this.pnMinimizar.Click += new System.EventHandler(this.pnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(233, 20);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP Management Solutions";
            // 
            // pnFavIcon
            // 
            this.pnFavIcon.BackColor = System.Drawing.Color.Transparent;
            this.pnFavIcon.BackgroundImage = global::SHARP_INK.Properties.Resources.FavIcon_25px_;
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
            this.btnFechar.Location = new System.Drawing.Point(1440, 0);
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
            // pnMenuStrip
            // 
            this.pnMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.pnMenuStrip.Controls.Add(this.menuRelatorios);
            this.pnMenuStrip.Controls.Add(this.menuCadastro);
            this.pnMenuStrip.Location = new System.Drawing.Point(0, 31);
            this.pnMenuStrip.Name = "pnMenuStrip";
            this.pnMenuStrip.Size = new System.Drawing.Size(1475, 65);
            this.pnMenuStrip.TabIndex = 22;
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuRelatorios.FlatAppearance.BorderSize = 0;
            this.menuRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuRelatorios.ForeColor = System.Drawing.Color.Silver;
            this.menuRelatorios.Location = new System.Drawing.Point(109, 16);
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(100, 30);
            this.menuRelatorios.TabIndex = 1;
            this.menuRelatorios.Text = "Relatorios";
            this.menuRelatorios.UseVisualStyleBackColor = false;
            // 
            // menuCadastro
            // 
            this.menuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.menuCadastro.FlatAppearance.BorderSize = 0;
            this.menuCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuCadastro.ForeColor = System.Drawing.Color.Silver;
            this.menuCadastro.Location = new System.Drawing.Point(3, 16);
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(100, 30);
            this.menuCadastro.TabIndex = 0;
            this.menuCadastro.Text = "Cadastro";
            this.menuCadastro.UseVisualStyleBackColor = false;
            // 
            // pnAjuste
            // 
            this.pnAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnAjuste.Location = new System.Drawing.Point(0, 88);
            this.pnAjuste.Name = "pnAjuste";
            this.pnAjuste.Size = new System.Drawing.Size(1475, 22);
            this.pnAjuste.TabIndex = 23;
            // 
            // pnLogo
            // 
            this.pnLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnLogo.BackgroundImage = global::SHARP_INK.Properties.Resources.Logo_Sharp_INK;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnLogo.Location = new System.Drawing.Point(0, 579);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(385, 86);
            this.pnLogo.TabIndex = 23;
            // 
            // btnOrdemServico
            // 
            this.btnOrdemServico.BackColor = System.Drawing.Color.Silver;
            this.btnOrdemServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrdemServico.BackgroundImage")));
            this.btnOrdemServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrdemServico.Location = new System.Drawing.Point(0, 102);
            this.btnOrdemServico.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrdemServico.Name = "btnOrdemServico";
            this.btnOrdemServico.Size = new System.Drawing.Size(200, 90);
            this.btnOrdemServico.TabIndex = 3;
            this.btnOrdemServico.TabStop = false;
            this.btnOrdemServico.Click += new System.EventHandler(this.btnOrdemServico_Click);
            this.btnOrdemServico.MouseEnter += new System.EventHandler(this.btnOrdemServico_MouseEnter);
            this.btnOrdemServico.MouseLeave += new System.EventHandler(this.btnOrdemServico_MouseLeave_1);
            // 
            // picBackgorund
            // 
            this.picBackgorund.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBackgorund.BackColor = System.Drawing.Color.Black;
            this.picBackgorund.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBackgorund.Image = ((System.Drawing.Image)(resources.GetObject("picBackgorund.Image")));
            this.picBackgorund.Location = new System.Drawing.Point(0, 198);
            this.picBackgorund.Name = "picBackgorund";
            this.picBackgorund.Padding = new System.Windows.Forms.Padding(0, 300, 0, 0);
            this.picBackgorund.Size = new System.Drawing.Size(1475, 375);
            this.picBackgorund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackgorund.TabIndex = 1;
            this.picBackgorund.TabStop = false;
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Silver;
            this.btnProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.BackgroundImage")));
            this.btnProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProdutos.Location = new System.Drawing.Point(195, 102);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(200, 90);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.TabStop = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            this.btnProdutos.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnProdutos.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave_1);
            // 
            // btnCatalises
            // 
            this.btnCatalises.BackColor = System.Drawing.Color.Silver;
            this.btnCatalises.BackgroundImage = global::SHARP_INK.Properties.Resources.Botao_Catalise;
            this.btnCatalises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCatalises.Location = new System.Drawing.Point(390, 102);
            this.btnCatalises.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatalises.Name = "btnCatalises";
            this.btnCatalises.Size = new System.Drawing.Size(200, 90);
            this.btnCatalises.TabIndex = 5;
            this.btnCatalises.TabStop = false;
            this.btnCatalises.MouseEnter += new System.EventHandler(this.btnCatalises_MouseEnter);
            this.btnCatalises.MouseLeave += new System.EventHandler(this.btnCatalises_MouseLeave_1);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Silver;
            this.btnUsuarios.BackgroundImage = global::SHARP_INK.Properties.Resources.Botao_Usuario;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUsuarios.Location = new System.Drawing.Point(585, 102);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 90);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseEnter += new System.EventHandler(this.btnUsuarios_MouseEnter);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave_1);
            // 
            // btnAlocacao
            // 
            this.btnAlocacao.BackColor = System.Drawing.Color.Silver;
            this.btnAlocacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlocacao.BackgroundImage")));
            this.btnAlocacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlocacao.Location = new System.Drawing.Point(780, 102);
            this.btnAlocacao.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlocacao.Name = "btnAlocacao";
            this.btnAlocacao.Size = new System.Drawing.Size(200, 90);
            this.btnAlocacao.TabIndex = 7;
            this.btnAlocacao.TabStop = false;
            this.btnAlocacao.MouseEnter += new System.EventHandler(this.btnAlocacao_MouseEnter);
            this.btnAlocacao.MouseLeave += new System.EventHandler(this.btnAlocacao_MouseLeave_1);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Silver;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfig.ImageLocation = "";
            this.btnConfig.Location = new System.Drawing.Point(975, 102);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 90);
            this.btnConfig.TabIndex = 8;
            this.btnConfig.TabStop = false;
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave_1);
            // 
            // lblTituloRodape
            // 
            this.lblTituloRodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloRodape.AutoSize = true;
            this.lblTituloRodape.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRodape.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloRodape.Location = new System.Drawing.Point(387, 600);
            this.lblTituloRodape.Name = "lblTituloRodape";
            this.lblTituloRodape.Size = new System.Drawing.Size(183, 14);
            this.lblTituloRodape.TabIndex = 24;
            this.lblTituloRodape.Text = "SHARP INK Laboratory Management";
            // 
            // lblDescricaoRodape
            // 
            this.lblDescricaoRodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescricaoRodape.AutoSize = true;
            this.lblDescricaoRodape.Font = new System.Drawing.Font("Futura Md BT", 7.25F);
            this.lblDescricaoRodape.ForeColor = System.Drawing.Color.Gray;
            this.lblDescricaoRodape.Location = new System.Drawing.Point(387, 614);
            this.lblDescricaoRodape.Name = "lblDescricaoRodape";
            this.lblDescricaoRodape.Size = new System.Drawing.Size(277, 12);
            this.lblDescricaoRodape.TabIndex = 25;
            this.lblDescricaoRodape.Text = "Ferramenta de Gerenciamento e Analise de Performance";
            // 
            // lblEmailRodape
            // 
            this.lblEmailRodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmailRodape.AutoSize = true;
            this.lblEmailRodape.Font = new System.Drawing.Font("Futura Md BT", 7.25F);
            this.lblEmailRodape.ForeColor = System.Drawing.Color.Gray;
            this.lblEmailRodape.Location = new System.Drawing.Point(388, 626);
            this.lblEmailRodape.Name = "lblEmailRodape";
            this.lblEmailRodape.Size = new System.Drawing.Size(180, 12);
            this.lblEmailRodape.TabIndex = 26;
            this.lblEmailRodape.Text = "Email :     jgwebdesign@outlook.com";
            // 
            // lblTelefoneRodape
            // 
            this.lblTelefoneRodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefoneRodape.AutoSize = true;
            this.lblTelefoneRodape.Font = new System.Drawing.Font("Futura Md BT", 7.25F);
            this.lblTelefoneRodape.ForeColor = System.Drawing.Color.Gray;
            this.lblTelefoneRodape.Location = new System.Drawing.Point(388, 638);
            this.lblTelefoneRodape.Name = "lblTelefoneRodape";
            this.lblTelefoneRodape.Size = new System.Drawing.Size(130, 12);
            this.lblTelefoneRodape.TabIndex = 27;
            this.lblTelefoneRodape.Text = "Fone :      (49) 98845 8174";
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // txtRelogio
            // 
            this.txtRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRelogio.AutoSize = true;
            this.txtRelogio.Font = new System.Drawing.Font("Futura Md BT", 20F);
            this.txtRelogio.ForeColor = System.Drawing.Color.Silver;
            this.txtRelogio.Location = new System.Drawing.Point(1317, 601);
            this.txtRelogio.Name = "txtRelogio";
            this.txtRelogio.Size = new System.Drawing.Size(129, 32);
            this.txtRelogio.TabIndex = 30;
            this.txtRelogio.Text = "00:00:00";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.AutoSize = true;
            this.txtData.Font = new System.Drawing.Font("Futura Md BT", 7.25F);
            this.txtData.ForeColor = System.Drawing.Color.Gray;
            this.txtData.Location = new System.Drawing.Point(1317, 638);
            this.txtData.MaximumSize = new System.Drawing.Size(130, 0);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(27, 12);
            this.txtData.TabIndex = 31;
            this.txtData.Text = "Data";
            this.txtData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1475, 677);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtRelogio);
            this.Controls.Add(this.lblTelefoneRodape);
            this.Controls.Add(this.lblEmailRodape);
            this.Controls.Add(this.lblDescricaoRodape);
            this.Controls.Add(this.lblTituloRodape);
            this.Controls.Add(this.pnAjuste);
            this.Controls.Add(this.pnLogo);
            this.Controls.Add(this.pnMenuStrip);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.btnOrdemServico);
            this.Controls.Add(this.picBackgorund);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnCatalises);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnAlocacao);
            this.Controls.Add(this.btnConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.pnMinimizar.ResumeLayout(false);
            this.pnMinimizar.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            this.pnMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnOrdemServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgorund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCatalises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnMinimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBackgorund;
        public System.Windows.Forms.PictureBox btnUsuarios;
        public System.Windows.Forms.PictureBox btnProdutos;
        public System.Windows.Forms.PictureBox btnCatalises;
        public System.Windows.Forms.PictureBox btnAlocacao;
        public System.Windows.Forms.PictureBox btnConfig;
        public System.Windows.Forms.PictureBox btnOrdemServico;
        public System.Windows.Forms.Panel pnMenuStrip;
        public System.Windows.Forms.Button menuRelatorios;
        public System.Windows.Forms.Button menuCadastro;
        private System.Windows.Forms.Panel pnLogo;
        public System.Windows.Forms.Panel pnAjuste;
        public System.Windows.Forms.Label lblTituloRodape;
        public System.Windows.Forms.Label lblDescricaoRodape;
        public System.Windows.Forms.Label lblEmailRodape;
        public System.Windows.Forms.Label lblTelefoneRodape;
        private System.Windows.Forms.Timer timerRelogio;
        public System.Windows.Forms.Label txtRelogio;
        public System.Windows.Forms.Label txtData;
    }
}

