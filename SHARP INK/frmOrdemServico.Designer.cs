namespace SHARP_INK
{
    partial class frmOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdemServico));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.pnFavIcon = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloNOS = new System.Windows.Forms.Label();
            this.lblTituloProprietario = new System.Windows.Forms.Label();
            this.lblTituloVeiculo = new System.Windows.Forms.Label();
            this.lblTituloPlaca = new System.Windows.Forms.Label();
            this.lblTituloCor = new System.Windows.Forms.Label();
            this.lblTituloTamanho = new System.Windows.Forms.Label();
            this.txtNos = new System.Windows.Forms.Label();
            this.txtProprietario = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.Label();
            this.picLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.pnItensOS = new System.Windows.Forms.Panel();
            this.Grafico_Dados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtSomaDiversos = new System.Windows.Forms.Label();
            this.txtSomaAbrasivos = new System.Windows.Forms.Label();
            this.txtMediaPeca = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.txtSomaPolidores = new System.Windows.Forms.Label();
            this.lblN_Pecas = new System.Windows.Forms.Label();
            this.txtSomaTinta = new System.Windows.Forms.Label();
            this.lblPolidores = new System.Windows.Forms.Label();
            this.txtN_Pecas = new System.Windows.Forms.Label();
            this.lblDIversos = new System.Windows.Forms.Label();
            this.lblTinta = new System.Windows.Forms.Label();
            this.txtSomaCatalises = new System.Windows.Forms.Label();
            this.lblMediaPecas = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.Label();
            this.lblCatalise = new System.Windows.Forms.Label();
            this.lblAbrasivos = new System.Windows.Forms.Label();
            this.btnTinta = new System.Windows.Forms.Button();
            this.btnCatalise = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstItensOS = new System.Windows.Forms.ListView();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.pnCabecalho.SuspendLayout();
            this.btnFechar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).BeginInit();
            this.pnItensOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_Dados)).BeginInit();
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
            this.pnCabecalho.Size = new System.Drawing.Size(671, 35);
            this.pnCabecalho.TabIndex = 2;
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
            this.lblTituloForm.Size = new System.Drawing.Size(205, 17);
            this.lblTituloForm.TabIndex = 1;
            this.lblTituloForm.Text = "SHARP INK - Orden de Serivço";
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
            this.btnFechar.Location = new System.Drawing.Point(636, 0);
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
            // lblTituloNOS
            // 
            this.lblTituloNOS.AutoSize = true;
            this.lblTituloNOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloNOS.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloNOS.Location = new System.Drawing.Point(22, 52);
            this.lblTituloNOS.Name = "lblTituloNOS";
            this.lblTituloNOS.Size = new System.Drawing.Size(61, 13);
            this.lblTituloNOS.TabIndex = 3;
            this.lblTituloNOS.Text = "Numero OS";
            // 
            // lblTituloProprietario
            // 
            this.lblTituloProprietario.AutoSize = true;
            this.lblTituloProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloProprietario.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloProprietario.Location = new System.Drawing.Point(22, 76);
            this.lblTituloProprietario.Name = "lblTituloProprietario";
            this.lblTituloProprietario.Size = new System.Drawing.Size(60, 13);
            this.lblTituloProprietario.TabIndex = 4;
            this.lblTituloProprietario.Text = "Proprietário";
            // 
            // lblTituloVeiculo
            // 
            this.lblTituloVeiculo.AutoSize = true;
            this.lblTituloVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloVeiculo.Location = new System.Drawing.Point(22, 100);
            this.lblTituloVeiculo.Name = "lblTituloVeiculo";
            this.lblTituloVeiculo.Size = new System.Drawing.Size(41, 13);
            this.lblTituloVeiculo.TabIndex = 5;
            this.lblTituloVeiculo.Text = "Veículo";
            // 
            // lblTituloPlaca
            // 
            this.lblTituloPlaca.AutoSize = true;
            this.lblTituloPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloPlaca.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloPlaca.Location = new System.Drawing.Point(22, 124);
            this.lblTituloPlaca.Name = "lblTituloPlaca";
            this.lblTituloPlaca.Size = new System.Drawing.Size(33, 13);
            this.lblTituloPlaca.TabIndex = 6;
            this.lblTituloPlaca.Text = "Placa";
            // 
            // lblTituloCor
            // 
            this.lblTituloCor.AutoSize = true;
            this.lblTituloCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloCor.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloCor.Location = new System.Drawing.Point(22, 148);
            this.lblTituloCor.Name = "lblTituloCor";
            this.lblTituloCor.Size = new System.Drawing.Size(23, 13);
            this.lblTituloCor.TabIndex = 7;
            this.lblTituloCor.Text = "Cor";
            // 
            // lblTituloTamanho
            // 
            this.lblTituloTamanho.AutoSize = true;
            this.lblTituloTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblTituloTamanho.ForeColor = System.Drawing.Color.Silver;
            this.lblTituloTamanho.Location = new System.Drawing.Point(22, 172);
            this.lblTituloTamanho.Name = "lblTituloTamanho";
            this.lblTituloTamanho.Size = new System.Drawing.Size(50, 13);
            this.lblTituloTamanho.TabIndex = 8;
            this.lblTituloTamanho.Text = "Tamanho";
            // 
            // txtNos
            // 
            this.txtNos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtNos.ForeColor = System.Drawing.Color.Silver;
            this.txtNos.Location = new System.Drawing.Point(107, 46);
            this.txtNos.Name = "txtNos";
            this.txtNos.Size = new System.Drawing.Size(300, 25);
            this.txtNos.TabIndex = 9;
            this.txtNos.Text = "000";
            this.txtNos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProprietario
            // 
            this.txtProprietario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProprietario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtProprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtProprietario.ForeColor = System.Drawing.Color.Silver;
            this.txtProprietario.Location = new System.Drawing.Point(107, 70);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(300, 25);
            this.txtProprietario.TabIndex = 10;
            this.txtProprietario.Text = "Jhoni fernando giacomolli albuquerque";
            this.txtProprietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.txtVeiculo.Location = new System.Drawing.Point(107, 94);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(300, 25);
            this.txtVeiculo.TabIndex = 11;
            this.txtVeiculo.Text = "Fusca";
            this.txtVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtPlaca.ForeColor = System.Drawing.Color.Silver;
            this.txtPlaca.Location = new System.Drawing.Point(107, 118);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(300, 25);
            this.txtPlaca.TabIndex = 12;
            this.txtPlaca.Text = "AAA-0000";
            this.txtPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCor
            // 
            this.txtCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtCor.ForeColor = System.Drawing.Color.Silver;
            this.txtCor.Location = new System.Drawing.Point(107, 142);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(300, 25);
            this.txtCor.TabIndex = 13;
            this.txtCor.Text = "Preto";
            this.txtCor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTamanho
            // 
            this.txtTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTamanho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txtTamanho.ForeColor = System.Drawing.Color.Silver;
            this.txtTamanho.Location = new System.Drawing.Point(107, 166);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(300, 25);
            this.txtTamanho.TabIndex = 14;
            this.txtTamanho.Text = "Grande";
            this.txtTamanho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogoEmpresa
            // 
            this.picLogoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogoEmpresa.Location = new System.Drawing.Point(435, 46);
            this.picLogoEmpresa.Name = "picLogoEmpresa";
            this.picLogoEmpresa.Size = new System.Drawing.Size(197, 71);
            this.picLogoEmpresa.TabIndex = 15;
            this.picLogoEmpresa.TabStop = false;
            // 
            // pnItensOS
            // 
            this.pnItensOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnItensOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnItensOS.Controls.Add(this.Grafico_Dados);
            this.pnItensOS.Controls.Add(this.txtSomaDiversos);
            this.pnItensOS.Controls.Add(this.txtSomaAbrasivos);
            this.pnItensOS.Controls.Add(this.txtMediaPeca);
            this.pnItensOS.Controls.Add(this.lblTicket);
            this.pnItensOS.Controls.Add(this.txtSomaPolidores);
            this.pnItensOS.Controls.Add(this.lblN_Pecas);
            this.pnItensOS.Controls.Add(this.txtSomaTinta);
            this.pnItensOS.Controls.Add(this.lblPolidores);
            this.pnItensOS.Controls.Add(this.txtN_Pecas);
            this.pnItensOS.Controls.Add(this.lblDIversos);
            this.pnItensOS.Controls.Add(this.lblTinta);
            this.pnItensOS.Controls.Add(this.txtSomaCatalises);
            this.pnItensOS.Controls.Add(this.lblMediaPecas);
            this.pnItensOS.Controls.Add(this.txtTicket);
            this.pnItensOS.Controls.Add(this.lblCatalise);
            this.pnItensOS.Controls.Add(this.lblAbrasivos);
            this.pnItensOS.Controls.Add(this.btnTinta);
            this.pnItensOS.Controls.Add(this.btnCatalise);
            this.pnItensOS.Controls.Add(this.btnProdutos);
            this.pnItensOS.Controls.Add(this.btnEditar);
            this.pnItensOS.Controls.Add(this.btnExcluir);
            this.pnItensOS.Controls.Add(this.comboBox1);
            this.pnItensOS.Controls.Add(this.lstItensOS);
            this.pnItensOS.Location = new System.Drawing.Point(0, 230);
            this.pnItensOS.Name = "pnItensOS";
            this.pnItensOS.Size = new System.Drawing.Size(671, 478);
            this.pnItensOS.TabIndex = 16;
            // 
            // Grafico_Dados
            // 
            this.Grafico_Dados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grafico_Dados.BackColor = System.Drawing.Color.Transparent;
            this.Grafico_Dados.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea9.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea9.Area3DStyle.Enable3D = true;
            chartArea9.Area3DStyle.Inclination = 50;
            chartArea9.Area3DStyle.IsRightAngleAxes = false;
            chartArea9.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea9.Area3DStyle.Rotation = 60;
            chartArea9.AxisX.IsLabelAutoFit = false;
            chartArea9.AxisX.LabelStyle.Format = "%";
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.Grafico_Dados.ChartAreas.Add(chartArea9);
            legend9.Alignment = System.Drawing.StringAlignment.Center;
            legend9.BackColor = System.Drawing.Color.Transparent;
            legend9.ForeColor = System.Drawing.Color.White;
            legend9.Name = "Legend1";
            this.Grafico_Dados.Legends.Add(legend9);
            this.Grafico_Dados.Location = new System.Drawing.Point(478, 4);
            this.Grafico_Dados.Name = "Grafico_Dados";
            this.Grafico_Dados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Grafico_Dados.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Purple,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            series9.BackSecondaryColor = System.Drawing.Color.Transparent;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.Color = System.Drawing.Color.Transparent;
            series9.CustomProperties = "CollectedColor=Transparent";
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.IsXValueIndexed = true;
            series9.LabelBackColor = System.Drawing.Color.Transparent;
            series9.LabelFormat = "{0:#0.##%}";
            series9.Legend = "Legend1";
            series9.MarkerColor = System.Drawing.Color.White;
            series9.Name = "Dados";
            series9.ShadowColor = System.Drawing.Color.WhiteSmoke;
            series9.YValuesPerPoint = 3;
            this.Grafico_Dados.Series.Add(series9);
            this.Grafico_Dados.Size = new System.Drawing.Size(190, 118);
            this.Grafico_Dados.TabIndex = 128;
            this.Grafico_Dados.Text = "chart1";
            // 
            // txtSomaDiversos
            // 
            this.txtSomaDiversos.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaDiversos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSomaDiversos.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtSomaDiversos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSomaDiversos.Location = new System.Drawing.Point(372, 102);
            this.txtSomaDiversos.Name = "txtSomaDiversos";
            this.txtSomaDiversos.Size = new System.Drawing.Size(100, 20);
            this.txtSomaDiversos.TabIndex = 120;
            this.txtSomaDiversos.Text = "Soma Diversos";
            this.txtSomaDiversos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSomaAbrasivos
            // 
            this.txtSomaAbrasivos.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaAbrasivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSomaAbrasivos.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtSomaAbrasivos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSomaAbrasivos.Location = new System.Drawing.Point(372, 4);
            this.txtSomaAbrasivos.Name = "txtSomaAbrasivos";
            this.txtSomaAbrasivos.Size = new System.Drawing.Size(100, 20);
            this.txtSomaAbrasivos.TabIndex = 112;
            this.txtSomaAbrasivos.Text = "Soma Abrasivos";
            this.txtSomaAbrasivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMediaPeca
            // 
            this.txtMediaPeca.BackColor = System.Drawing.Color.Transparent;
            this.txtMediaPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMediaPeca.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtMediaPeca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMediaPeca.Location = new System.Drawing.Point(107, 54);
            this.txtMediaPeca.Name = "txtMediaPeca";
            this.txtMediaPeca.Size = new System.Drawing.Size(119, 20);
            this.txtMediaPeca.TabIndex = 127;
            this.txtMediaPeca.Text = "Média p/ Peça";
            this.txtMediaPeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.Color.Transparent;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblTicket.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTicket.Location = new System.Drawing.Point(15, 8);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(85, 13);
            this.lblTicket.TabIndex = 122;
            this.lblTicket.Text = "Ticket do Veículo";
            // 
            // txtSomaPolidores
            // 
            this.txtSomaPolidores.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaPolidores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSomaPolidores.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtSomaPolidores.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSomaPolidores.Location = new System.Drawing.Point(372, 78);
            this.txtSomaPolidores.Name = "txtSomaPolidores";
            this.txtSomaPolidores.Size = new System.Drawing.Size(100, 20);
            this.txtSomaPolidores.TabIndex = 119;
            this.txtSomaPolidores.Text = "Soma Polidores";
            this.txtSomaPolidores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblN_Pecas
            // 
            this.lblN_Pecas.BackColor = System.Drawing.Color.Transparent;
            this.lblN_Pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblN_Pecas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblN_Pecas.Location = new System.Drawing.Point(14, 33);
            this.lblN_Pecas.Name = "lblN_Pecas";
            this.lblN_Pecas.Size = new System.Drawing.Size(65, 13);
            this.lblN_Pecas.TabIndex = 123;
            this.lblN_Pecas.Text = "Nº de Peças";
            this.lblN_Pecas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSomaTinta
            // 
            this.txtSomaTinta.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaTinta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSomaTinta.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtSomaTinta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSomaTinta.Location = new System.Drawing.Point(372, 54);
            this.txtSomaTinta.Name = "txtSomaTinta";
            this.txtSomaTinta.Size = new System.Drawing.Size(100, 20);
            this.txtSomaTinta.TabIndex = 121;
            this.txtSomaTinta.Text = "Soma Tinta";
            this.txtSomaTinta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPolidores
            // 
            this.lblPolidores.BackColor = System.Drawing.Color.Transparent;
            this.lblPolidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblPolidores.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPolidores.Location = new System.Drawing.Point(241, 82);
            this.lblPolidores.Name = "lblPolidores";
            this.lblPolidores.Size = new System.Drawing.Size(126, 13);
            this.lblPolidores.TabIndex = 118;
            this.lblPolidores.Text = "Gastos com POLIDORES";
            // 
            // txtN_Pecas
            // 
            this.txtN_Pecas.BackColor = System.Drawing.Color.Transparent;
            this.txtN_Pecas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtN_Pecas.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtN_Pecas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtN_Pecas.Location = new System.Drawing.Point(107, 29);
            this.txtN_Pecas.Name = "txtN_Pecas";
            this.txtN_Pecas.Size = new System.Drawing.Size(119, 20);
            this.txtN_Pecas.TabIndex = 126;
            this.txtN_Pecas.Text = "N Pecas";
            this.txtN_Pecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDIversos
            // 
            this.lblDIversos.BackColor = System.Drawing.Color.Transparent;
            this.lblDIversos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDIversos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDIversos.Location = new System.Drawing.Point(241, 106);
            this.lblDIversos.Name = "lblDIversos";
            this.lblDIversos.Size = new System.Drawing.Size(119, 13);
            this.lblDIversos.TabIndex = 117;
            this.lblDIversos.Text = "Gastos com DIVERSOS";
            // 
            // lblTinta
            // 
            this.lblTinta.BackColor = System.Drawing.Color.Transparent;
            this.lblTinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblTinta.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTinta.Location = new System.Drawing.Point(241, 58);
            this.lblTinta.Name = "lblTinta";
            this.lblTinta.Size = new System.Drawing.Size(92, 13);
            this.lblTinta.TabIndex = 116;
            this.lblTinta.Text = "Gastos com TINTA";
            // 
            // txtSomaCatalises
            // 
            this.txtSomaCatalises.BackColor = System.Drawing.Color.Transparent;
            this.txtSomaCatalises.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSomaCatalises.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtSomaCatalises.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSomaCatalises.Location = new System.Drawing.Point(372, 29);
            this.txtSomaCatalises.Name = "txtSomaCatalises";
            this.txtSomaCatalises.Size = new System.Drawing.Size(100, 20);
            this.txtSomaCatalises.TabIndex = 115;
            this.txtSomaCatalises.Text = "Soma Catalises";
            this.txtSomaCatalises.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMediaPecas
            // 
            this.lblMediaPecas.BackColor = System.Drawing.Color.Transparent;
            this.lblMediaPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblMediaPecas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblMediaPecas.Location = new System.Drawing.Point(15, 58);
            this.lblMediaPecas.Name = "lblMediaPecas";
            this.lblMediaPecas.Size = new System.Drawing.Size(63, 13);
            this.lblMediaPecas.TabIndex = 124;
            this.lblMediaPecas.Text = "Média/Peça";
            // 
            // txtTicket
            // 
            this.txtTicket.BackColor = System.Drawing.Color.Transparent;
            this.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicket.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            this.txtTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTicket.Location = new System.Drawing.Point(107, 4);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(119, 20);
            this.txtTicket.TabIndex = 125;
            this.txtTicket.Text = "Ticket";
            this.txtTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCatalise
            // 
            this.lblCatalise.BackColor = System.Drawing.Color.Transparent;
            this.lblCatalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblCatalise.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCatalise.Location = new System.Drawing.Point(241, 33);
            this.lblCatalise.Name = "lblCatalise";
            this.lblCatalise.Size = new System.Drawing.Size(121, 13);
            this.lblCatalise.TabIndex = 114;
            this.lblCatalise.Text = "Gastos com CATALISES";
            // 
            // lblAbrasivos
            // 
            this.lblAbrasivos.BackColor = System.Drawing.Color.Transparent;
            this.lblAbrasivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblAbrasivos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAbrasivos.Location = new System.Drawing.Point(241, 8);
            this.lblAbrasivos.Name = "lblAbrasivos";
            this.lblAbrasivos.Size = new System.Drawing.Size(125, 13);
            this.lblAbrasivos.TabIndex = 113;
            this.lblAbrasivos.Text = "Gastos com ABRASIVOS";
            // 
            // btnTinta
            // 
            this.btnTinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinta.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnTinta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinta.ForeColor = System.Drawing.Color.Silver;
            this.btnTinta.Location = new System.Drawing.Point(212, 438);
            this.btnTinta.Name = "btnTinta";
            this.btnTinta.Size = new System.Drawing.Size(90, 30);
            this.btnTinta.TabIndex = 12;
            this.btnTinta.Text = "Tinta";
            this.btnTinta.UseVisualStyleBackColor = true;
            this.btnTinta.Click += new System.EventHandler(this.btnTinta_Click);
            // 
            // btnCatalise
            // 
            this.btnCatalise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatalise.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCatalise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalise.ForeColor = System.Drawing.Color.Silver;
            this.btnCatalise.Location = new System.Drawing.Point(303, 438);
            this.btnCatalise.Name = "btnCatalise";
            this.btnCatalise.Size = new System.Drawing.Size(90, 30);
            this.btnCatalise.TabIndex = 11;
            this.btnCatalise.Text = "Catalise";
            this.btnCatalise.UseVisualStyleBackColor = true;
            this.btnCatalise.Click += new System.EventHandler(this.btnCatalise_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.Silver;
            this.btnProdutos.Location = new System.Drawing.Point(394, 438);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(90, 30);
            this.btnProdutos.TabIndex = 10;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.Location = new System.Drawing.Point(485, 438);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Silver;
            this.btnExcluir.Location = new System.Drawing.Point(576, 438);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 444);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Selecione a categoria";
            // 
            // lstItensOS
            // 
            this.lstItensOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItensOS.HideSelection = false;
            this.lstItensOS.Location = new System.Drawing.Point(0, 125);
            this.lstItensOS.Name = "lstItensOS";
            this.lstItensOS.Size = new System.Drawing.Size(669, 306);
            this.lstItensOS.TabIndex = 0;
            this.lstItensOS.UseCompatibleStateImageBehavior = false;
            this.lstItensOS.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstItensOS_ColumnClick);
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.Silver;
            this.lblRazaoSocial.Location = new System.Drawing.Point(433, 122);
            this.lblRazaoSocial.MaximumSize = new System.Drawing.Size(201, 20);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(200, 15);
            this.lblRazaoSocial.TabIndex = 18;
            this.lblRazaoSocial.Text = "Razão Social";
            this.lblRazaoSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lblCNPJ.ForeColor = System.Drawing.Color.Silver;
            this.lblCNPJ.Location = new System.Drawing.Point(433, 140);
            this.lblCNPJ.MaximumSize = new System.Drawing.Size(201, 20);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(200, 10);
            this.lblCNPJ.TabIndex = 19;
            this.lblCNPJ.Text = "CNPJ";
            this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEndereço
            // 
            this.lblEndereço.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lblEndereço.ForeColor = System.Drawing.Color.Silver;
            this.lblEndereço.Location = new System.Drawing.Point(433, 149);
            this.lblEndereço.MaximumSize = new System.Drawing.Size(201, 20);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(200, 10);
            this.lblEndereço.TabIndex = 20;
            this.lblEndereço.Text = "Endereço";
            this.lblEndereço.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.lblEmail.ForeColor = System.Drawing.Color.Silver;
            this.lblEmail.Location = new System.Drawing.Point(433, 158);
            this.lblEmail.MaximumSize = new System.Drawing.Size(201, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 10);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            this.lblTelefone.ForeColor = System.Drawing.Color.Silver;
            this.lblTelefone.Location = new System.Drawing.Point(433, 167);
            this.lblTelefone.MaximumSize = new System.Drawing.Size(201, 20);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(200, 15);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(671, 707);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.pnItensOS);
            this.Controls.Add(this.picLogoEmpresa);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.txtNos);
            this.Controls.Add(this.lblTituloTamanho);
            this.Controls.Add(this.lblTituloCor);
            this.Controls.Add(this.lblTituloPlaca);
            this.Controls.Add(this.lblTituloVeiculo);
            this.Controls.Add(this.lblTituloProprietario);
            this.Controls.Add(this.lblTituloNOS);
            this.Controls.Add(this.pnCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdemServico";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.btnFechar.ResumeLayout(false);
            this.btnFechar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEmpresa)).EndInit();
            this.pnItensOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafico_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnCabecalho;
        public System.Windows.Forms.Label lblTituloForm;
        public System.Windows.Forms.Panel pnFavIcon;
        public System.Windows.Forms.Panel btnFechar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTituloNOS;
        public System.Windows.Forms.Label lblTituloProprietario;
        public System.Windows.Forms.Label lblTituloVeiculo;
        public System.Windows.Forms.Label lblTituloPlaca;
        public System.Windows.Forms.Label lblTituloCor;
        public System.Windows.Forms.Label lblTituloTamanho;
        public System.Windows.Forms.Label txtNos;
        public System.Windows.Forms.Label txtProprietario;
        public System.Windows.Forms.Label txtVeiculo;
        public System.Windows.Forms.Label txtPlaca;
        public System.Windows.Forms.Label txtCor;
        public System.Windows.Forms.Label txtTamanho;
        public System.Windows.Forms.Label lblRazaoSocial;
        public System.Windows.Forms.Label lblCNPJ;
        public System.Windows.Forms.Label lblEndereço;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button btnTinta;
        public System.Windows.Forms.Button btnCatalise;
        public System.Windows.Forms.Button btnProdutos;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.PictureBox picLogoEmpresa;
        public System.Windows.Forms.ListView lstItensOS;
        public System.Windows.Forms.Label txtSomaDiversos;
        public System.Windows.Forms.Label txtSomaAbrasivos;
        public System.Windows.Forms.Label txtMediaPeca;
        public System.Windows.Forms.Label lblTicket;
        public System.Windows.Forms.Label txtSomaPolidores;
        public System.Windows.Forms.Label lblN_Pecas;
        public System.Windows.Forms.Label txtSomaTinta;
        public System.Windows.Forms.Label lblPolidores;
        public System.Windows.Forms.Label txtN_Pecas;
        public System.Windows.Forms.Label lblDIversos;
        public System.Windows.Forms.Label lblTinta;
        public System.Windows.Forms.Label txtSomaCatalises;
        public System.Windows.Forms.Label lblMediaPecas;
        public System.Windows.Forms.Label txtTicket;
        public System.Windows.Forms.Label lblCatalise;
        public System.Windows.Forms.Label lblAbrasivos;
        public System.Windows.Forms.DataVisualization.Charting.Chart Grafico_Dados;
        public System.Windows.Forms.Panel pnItensOS;
    }
}