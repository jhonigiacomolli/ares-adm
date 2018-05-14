namespace SHARP_INK
{
    partial class frmIncluirItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirItem));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
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
            this.pnCabecalho.Size = new System.Drawing.Size(351, 35);
            this.pnCabecalho.TabIndex = 3;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloForm.Location = new System.Drawing.Point(56, 8);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(186, 20);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Incluir Item";
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
            this.btnFechar.Location = new System.Drawing.Point(316, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 1;
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
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Silver;
            this.lblCodigo.Location = new System.Drawing.Point(3, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.Silver;
            this.lblDescricao.Location = new System.Drawing.Point(3, 86);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.Color.Silver;
            this.lblQuantidade.Location = new System.Drawing.Point(3, 117);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.ForeColor = System.Drawing.Color.Silver;
            this.lblValorUnitario.Location = new System.Drawing.Point(3, 148);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnitario.TabIndex = 6;
            this.lblValorUnitario.Text = "Valor Unitário";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblValorTotal.Location = new System.Drawing.Point(3, 179);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 82);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(263, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(76, 113);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(189, 20);
            this.txtQuantidade.TabIndex = 10;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(76, 144);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(189, 20);
            this.txtValorUnitario.TabIndex = 11;
            this.txtValorUnitario.Validated += new System.EventHandler(this.txtValorUnitario_Validated);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(76, 175);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(189, 20);
            this.txtValorTotal.TabIndex = 12;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.ForeColor = System.Drawing.Color.Silver;
            this.btnGravar.Location = new System.Drawing.Point(77, 205);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(189, 34);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Incluir";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.Color.Silver;
            this.btnPesquisa.Location = new System.Drawing.Point(272, 50);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(67, 22);
            this.btnPesquisa.TabIndex = 14;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // frmIncluirItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(351, 251);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIncluirItem";
            this.Text = "frmIncluirItem";
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
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtValorUnitario;
        public System.Windows.Forms.TextBox txtValorTotal;
    }
}