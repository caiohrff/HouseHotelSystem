namespace NewTech_HouseHotel
{
    partial class frmEscolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNomeEndC = new System.Windows.Forms.Label();
            this.lblNumeroEnderecoC = new System.Windows.Forms.Label();
            this.lblNacionalidadeC = new System.Windows.Forms.Label();
            this.lblDataC = new System.Windows.Forms.Label();
            this.lblPassaporteC = new System.Windows.Forms.Label();
            this.lblCEPC = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAddConsumo = new System.Windows.Forms.Button();
            this.lblCPf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gprMessaCod = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPergunta = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodigoConsumo = new System.Windows.Forms.MaskedTextBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.gprMessaCod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(104, 151);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(109, 24);
            this.txtPesquisar.TabIndex = 17;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor gasto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1154, 695);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Deseja consumir algo? ";
            // 
            // lblNomeEndC
            // 
            this.lblNomeEndC.AutoSize = true;
            this.lblNomeEndC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEndC.Location = new System.Drawing.Point(225, 619);
            this.lblNomeEndC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEndC.Name = "lblNomeEndC";
            this.lblNomeEndC.Size = new System.Drawing.Size(119, 18);
            this.lblNomeEndC.TabIndex = 44;
            this.lblNomeEndC.Text = "Nome endereço:";
            // 
            // lblNumeroEnderecoC
            // 
            this.lblNumeroEnderecoC.AutoSize = true;
            this.lblNumeroEnderecoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEnderecoC.Location = new System.Drawing.Point(225, 580);
            this.lblNumeroEnderecoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEnderecoC.Name = "lblNumeroEnderecoC";
            this.lblNumeroEnderecoC.Size = new System.Drawing.Size(119, 18);
            this.lblNumeroEnderecoC.TabIndex = 43;
            this.lblNumeroEnderecoC.Text = "Nome endereço:";
            // 
            // lblNacionalidadeC
            // 
            this.lblNacionalidadeC.AutoSize = true;
            this.lblNacionalidadeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidadeC.Location = new System.Drawing.Point(225, 537);
            this.lblNacionalidadeC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidadeC.Name = "lblNacionalidadeC";
            this.lblNacionalidadeC.Size = new System.Drawing.Size(119, 18);
            this.lblNacionalidadeC.TabIndex = 42;
            this.lblNacionalidadeC.Text = "Nome endereço:";
            // 
            // lblDataC
            // 
            this.lblDataC.AutoSize = true;
            this.lblDataC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataC.Location = new System.Drawing.Point(225, 498);
            this.lblDataC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataC.Name = "lblDataC";
            this.lblDataC.Size = new System.Drawing.Size(119, 18);
            this.lblDataC.TabIndex = 41;
            this.lblDataC.Text = "Nome endereço:";
            // 
            // lblPassaporteC
            // 
            this.lblPassaporteC.AutoSize = true;
            this.lblPassaporteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassaporteC.Location = new System.Drawing.Point(113, 348);
            this.lblPassaporteC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassaporteC.Name = "lblPassaporteC";
            this.lblPassaporteC.Size = new System.Drawing.Size(0, 18);
            this.lblPassaporteC.TabIndex = 40;
            // 
            // lblCEPC
            // 
            this.lblCEPC.AutoSize = true;
            this.lblCEPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEPC.Location = new System.Drawing.Point(69, 315);
            this.lblCEPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEPC.Name = "lblCEPC";
            this.lblCEPC.Size = new System.Drawing.Size(0, 18);
            this.lblCEPC.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 619);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nome endereço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 537);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Nacionalidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "CEP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Passaporte:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 580);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Numero endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 498);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nome:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(484, 309);
            this.lblConsumo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(69, 18);
            this.lblConsumo.TabIndex = 5;
            this.lblConsumo.Text = "Adicionar";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Lime;
            this.lblValor.Location = new System.Drawing.Point(113, 276);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(0, 18);
            this.lblValor.TabIndex = 28;
            // 
            // btnAddConsumo
            // 
            this.btnAddConsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddConsumo.FlatAppearance.BorderSize = 0;
            this.btnAddConsumo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddConsumo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddConsumo.Image")));
            this.btnAddConsumo.Location = new System.Drawing.Point(487, 265);
            this.btnAddConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddConsumo.Name = "btnAddConsumo";
            this.btnAddConsumo.Size = new System.Drawing.Size(59, 40);
            this.btnAddConsumo.TabIndex = 4;
            this.btnAddConsumo.UseVisualStyleBackColor = true;
            this.btnAddConsumo.Click += new System.EventHandler(this.btnAddConsumo_Click);
            this.btnAddConsumo.MouseLeave += new System.EventHandler(this.btnAddConsumo_MouseLeave);
            this.btnAddConsumo.MouseHover += new System.EventHandler(this.btnAddConsumo_MouseHover);
            // 
            // lblCPf
            // 
            this.lblCPf.AutoSize = true;
            this.lblCPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPf.Location = new System.Drawing.Point(85, 233);
            this.lblCPf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPf.Name = "lblCPf";
            this.lblCPf.Size = new System.Drawing.Size(0, 18);
            this.lblCPf.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código do cliente:";
            // 
            // gprMessaCod
            // 
            this.gprMessaCod.Controls.Add(this.label2);
            this.gprMessaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprMessaCod.ForeColor = System.Drawing.Color.White;
            this.gprMessaCod.Location = new System.Drawing.Point(217, 13);
            this.gprMessaCod.Margin = new System.Windows.Forms.Padding(4);
            this.gprMessaCod.Name = "gprMessaCod";
            this.gprMessaCod.Padding = new System.Windows.Forms.Padding(4);
            this.gprMessaCod.Size = new System.Drawing.Size(300, 80);
            this.gprMessaCod.TabIndex = 30;
            this.gprMessaCod.TabStop = false;
            this.gprMessaCod.Text = "HouseHotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(50, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Verifique o codigo digitado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(85, 197);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 18);
            this.lblNome.TabIndex = 46;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPergunta.Location = new System.Drawing.Point(481, 149);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(0, 18);
            this.lblPergunta.TabIndex = 47;
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AllowUserToResizeColumns = false;
            this.dtgCliente.AllowUserToResizeRows = false;
            this.dtgCliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(258, 111);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.Size = new System.Drawing.Size(219, 291);
            this.dtgCliente.TabIndex = 49;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(214, 147);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(44, 37);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCodigoConsumo
            // 
            this.txtCodigoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoConsumo.Location = new System.Drawing.Point(615, 180);
            this.txtCodigoConsumo.Mask = "000-000-000-00";
            this.txtCodigoConsumo.Name = "txtCodigoConsumo";
            this.txtCodigoConsumo.Size = new System.Drawing.Size(122, 24);
            this.txtCodigoConsumo.TabIndex = 326;
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(616, 215);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(121, 26);
            this.cmbProdutos.TabIndex = 327;
            this.cmbProdutos.Text = "Selecione...";
            this.cmbProdutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProdutos_KeyPress);
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.txtCodigoConsumo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.gprMessaCod);
            this.Controls.Add(this.btnAddConsumo);
            this.Controls.Add(this.lblNomeEndC);
            this.Controls.Add(this.lblNumeroEnderecoC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNacionalidadeC);
            this.Controls.Add(this.lblDataC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPassaporteC);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCEPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCPf);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Hotel";
            this.Load += new System.EventHandler(this.frmEscolha_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEscolha_MouseMove);
            this.gprMessaCod.ResumeLayout(false);
            this.gprMessaCod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddConsumo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCPf;
        private System.Windows.Forms.GroupBox gprMessaCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomeEndC;
        private System.Windows.Forms.Label lblNumeroEnderecoC;
        private System.Windows.Forms.Label lblNacionalidadeC;
        private System.Windows.Forms.Label lblDataC;
        private System.Windows.Forms.Label lblPassaporteC;
        private System.Windows.Forms.Label lblCEPC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtCodigoConsumo;
        private System.Windows.Forms.ComboBox cmbProdutos;
    }
}