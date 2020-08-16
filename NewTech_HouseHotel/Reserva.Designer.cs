namespace NewTech_HouseHotel
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.lblNacionalidade = new System.Windows.Forms.Label();
            this.txtPassaporte = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefoneReserva = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNascimentoReserva = new System.Windows.Forms.MaskedTextBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidadeReserva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeReserva = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.mskCheckOutHora = new System.Windows.Forms.MaskedTextBox();
            this.mskCheckInHora = new System.Windows.Forms.MaskedTextBox();
            this.mskDataReserva = new System.Windows.Forms.MaskedTextBox();
            this.mskDataCheckOut = new System.Windows.Forms.MaskedTextBox();
            this.mskDataCheckIn = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirmarReserva1 = new System.Windows.Forms.Button();
            this.cmbQtdHospede = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUF = new System.Windows.Forms.ComboBox();
            this.cmbQuarto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(123, 368);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 22);
            this.txtNumero.TabIndex = 343;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(15, 370);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 18);
            this.lblNumero.TabIndex = 342;
            this.lblNumero.Text = "Número:";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(336, 149);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(32, 18);
            this.lblUf.TabIndex = 340;
            this.lblUf.Text = "UF:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(443, 113);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(161, 22);
            this.txtPais.TabIndex = 339;
            this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPais_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(336, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 338;
            this.label15.Text = "País:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(123, 401);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(130, 22);
            this.txtBairro.TabIndex = 337;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(13, 404);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 18);
            this.lblBairro.TabIndex = 336;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(123, 335);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(155, 22);
            this.txtEndereco.TabIndex = 335;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(13, 338);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 18);
            this.lblEndereco.TabIndex = 334;
            this.lblEndereco.Text = "Endereço:";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(123, 306);
            this.mskCel.Mask = " (00) 0000-00000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(161, 22);
            this.mskCel.TabIndex = 333;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(12, 309);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 18);
            this.lblCelular.TabIndex = 332;
            this.lblCelular.Text = "Celular:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(123, 240);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(115, 22);
            this.txtNacionalidade.TabIndex = 331;
            this.txtNacionalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacionalidade_KeyPress);
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.Location = new System.Drawing.Point(12, 243);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(105, 18);
            this.lblNacionalidade.TabIndex = 330;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtPassaporte
            // 
            this.txtPassaporte.Location = new System.Drawing.Point(123, 206);
            this.txtPassaporte.Mask = "LL0000000";
            this.txtPassaporte.Name = "txtPassaporte";
            this.txtPassaporte.Size = new System.Drawing.Size(84, 22);
            this.txtPassaporte.TabIndex = 329;
            this.txtPassaporte.Click += new System.EventHandler(this.txtPassaporte_Click);
            // 
            // mskTelefoneReserva
            // 
            this.mskTelefoneReserva.Location = new System.Drawing.Point(123, 273);
            this.mskTelefoneReserva.Mask = "(00) 0000-0000";
            this.mskTelefoneReserva.Name = "mskTelefoneReserva";
            this.mskTelefoneReserva.Size = new System.Drawing.Size(161, 22);
            this.mskTelefoneReserva.TabIndex = 328;
            // 
            // mskDataNascimentoReserva
            // 
            this.mskDataNascimentoReserva.Location = new System.Drawing.Point(162, 173);
            this.mskDataNascimentoReserva.Mask = "00/00/0000";
            this.mskDataNascimentoReserva.Name = "mskDataNascimentoReserva";
            this.mskDataNascimentoReserva.Size = new System.Drawing.Size(100, 22);
            this.mskDataNascimentoReserva.TabIndex = 327;
            this.mskDataNascimentoReserva.ValidatingType = typeof(System.DateTime);
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(443, 184);
            this.msk_cep.Mask = "00000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(76, 24);
            this.msk_cep.TabIndex = 326;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(72, 109);
            this.mskCPF.Mask = "000-000-000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(122, 24);
            this.mskCPF.TabIndex = 325;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 18);
            this.label11.TabIndex = 324;
            this.label11.Text = "CEP:";
            // 
            // txtCidadeReserva
            // 
            this.txtCidadeReserva.Location = new System.Drawing.Point(443, 73);
            this.txtCidadeReserva.Name = "txtCidadeReserva";
            this.txtCidadeReserva.Size = new System.Drawing.Size(161, 22);
            this.txtCidadeReserva.TabIndex = 323;
            this.txtCidadeReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidadeReserva_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(335, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 322;
            this.label10.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 314;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 315;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 316;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 317;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 318;
            this.label6.Text = "Passaporte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 319;
            this.label7.Text = "Data de Nascimento:";
            // 
            // txtNomeReserva
            // 
            this.txtNomeReserva.Location = new System.Drawing.Point(72, 75);
            this.txtNomeReserva.Name = "txtNomeReserva";
            this.txtNomeReserva.Size = new System.Drawing.Size(231, 22);
            this.txtNomeReserva.TabIndex = 320;
            this.txtNomeReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeReserva_KeyPress_1);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(72, 141);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(166, 22);
            this.txt_email.TabIndex = 321;
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(450, 387);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(69, 22);
            this.txtDiaria.TabIndex = 358;
            this.txtDiaria.TextChanged += new System.EventHandler(this.txtDiaria_TextChanged);
            this.txtDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaria_KeyPress);
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaria.Location = new System.Drawing.Point(335, 390);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(108, 18);
            this.lblDiaria.TabIndex = 357;
            this.lblDiaria.Text = "Valor da Diária:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(525, 393);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 18);
            this.label16.TabIndex = 356;
            this.label16.Text = "Qtd. Hóspedes:";
            // 
            // mskCheckOutHora
            // 
            this.mskCheckOutHora.Location = new System.Drawing.Point(492, 349);
            this.mskCheckOutHora.Mask = "00:00";
            this.mskCheckOutHora.Name = "mskCheckOutHora";
            this.mskCheckOutHora.Size = new System.Drawing.Size(50, 22);
            this.mskCheckOutHora.TabIndex = 355;
            this.mskCheckOutHora.ValidatingType = typeof(System.DateTime);
            // 
            // mskCheckInHora
            // 
            this.mskCheckInHora.Location = new System.Drawing.Point(492, 316);
            this.mskCheckInHora.Mask = "00:00";
            this.mskCheckInHora.Name = "mskCheckInHora";
            this.mskCheckInHora.Size = new System.Drawing.Size(50, 22);
            this.mskCheckInHora.TabIndex = 354;
            this.mskCheckInHora.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataReserva
            // 
            this.mskDataReserva.Location = new System.Drawing.Point(480, 284);
            this.mskDataReserva.Mask = "00/00/0000";
            this.mskDataReserva.Name = "mskDataReserva";
            this.mskDataReserva.Size = new System.Drawing.Size(82, 22);
            this.mskDataReserva.TabIndex = 353;
            this.mskDataReserva.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataCheckOut
            // 
            this.mskDataCheckOut.Location = new System.Drawing.Point(480, 253);
            this.mskDataCheckOut.Mask = "00/00/0000";
            this.mskDataCheckOut.Name = "mskDataCheckOut";
            this.mskDataCheckOut.Size = new System.Drawing.Size(82, 22);
            this.mskDataCheckOut.TabIndex = 352;
            this.mskDataCheckOut.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataCheckIn
            // 
            this.mskDataCheckIn.Location = new System.Drawing.Point(480, 220);
            this.mskDataCheckIn.Mask = "00/00/0000";
            this.mskDataCheckIn.Name = "mskDataCheckIn";
            this.mskDataCheckIn.Size = new System.Drawing.Size(82, 22);
            this.mskDataCheckIn.TabIndex = 351;
            this.mskDataCheckIn.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(336, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 350;
            this.label14.Text = "Data da reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 346;
            this.label2.Text = "Observação:";
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(443, 430);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtObs.Size = new System.Drawing.Size(211, 82);
            this.txtObs.TabIndex = 347;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(336, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 18);
            this.label13.TabIndex = 349;
            this.label13.Text = "Horário do check-out:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 348;
            this.label12.Text = "Horário do check-in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(336, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 344;
            this.label8.Text = "Data do Check-In:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(336, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 18);
            this.label9.TabIndex = 345;
            this.label9.Text = "Data do Check-Out:";
            // 
            // btnConfirmarReserva1
            // 
            this.btnConfirmarReserva1.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarReserva1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirmarReserva1.FlatAppearance.BorderSize = 0;
            this.btnConfirmarReserva1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarReserva1.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva1.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarReserva1.Image")));
            this.btnConfirmarReserva1.Location = new System.Drawing.Point(283, 493);
            this.btnConfirmarReserva1.Name = "btnConfirmarReserva1";
            this.btnConfirmarReserva1.Size = new System.Drawing.Size(49, 29);
            this.btnConfirmarReserva1.TabIndex = 360;
            this.btnConfirmarReserva1.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva1.Click += new System.EventHandler(this.btnConfirmarReserva1_Click);
            // 
            // cmbQtdHospede
            // 
            this.cmbQtdHospede.FormattingEnabled = true;
            this.cmbQtdHospede.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbQtdHospede.Location = new System.Drawing.Point(633, 390);
            this.cmbQtdHospede.Name = "cmbQtdHospede";
            this.cmbQtdHospede.Size = new System.Drawing.Size(94, 24);
            this.cmbQtdHospede.TabIndex = 361;
            this.cmbQtdHospede.Text = "Selecione...";
            this.cmbQtdHospede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(548, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 18);
            this.label17.TabIndex = 363;
            this.label17.Text = "Quarto:";
            // 
            // cmbUF
            // 
            this.cmbUF.FormattingEnabled = true;
            this.cmbUF.Items.AddRange(new object[] {
            "AC\t ",
            "AL\t ",
            "AP\t ",
            "AM\t ",
            "BA\t ",
            "CE\t ",
            "DF\t ",
            "ES\t ",
            "GO\t ",
            "MA\t ",
            "MT\t ",
            "MS\t ",
            "MG\t ",
            "PA\t ",
            "PB\t ",
            "PR\t ",
            "PE\t ",
            "PI\t ",
            "RJ\t ",
            "RN\t ",
            "RS\t ",
            "RO\t ",
            "RR\t ",
            "SC\t ",
            "SP\t ",
            "SE\t ",
            "TO"});
            this.cmbUF.Location = new System.Drawing.Point(443, 146);
            this.cmbUF.Name = "cmbUF";
            this.cmbUF.Size = new System.Drawing.Size(95, 24);
            this.cmbUF.TabIndex = 365;
            this.cmbUF.Text = "Selecione...";
            this.cmbUF.SelectedIndexChanged += new System.EventHandler(this.cmbUF_SelectedIndexChanged);
            this.cmbUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUF_KeyPress);
            // 
            // cmbQuarto
            // 
            this.cmbQuarto.FormattingEnabled = true;
            this.cmbQuarto.Location = new System.Drawing.Point(605, 352);
            this.cmbQuarto.Name = "cmbQuarto";
            this.cmbQuarto.Size = new System.Drawing.Size(58, 24);
            this.cmbQuarto.TabIndex = 366;
            this.cmbQuarto.Text = "Selecione...";
            this.cmbQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbQuarto_KeyPress_1);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(769, 562);
            this.Controls.Add(this.cmbQuarto);
            this.Controls.Add(this.cmbUF);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbQtdHospede);
            this.Controls.Add(this.btnConfirmarReserva1);
            this.Controls.Add(this.txtDiaria);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mskCheckOutHora);
            this.Controls.Add(this.mskCheckInHora);
            this.Controls.Add(this.mskDataReserva);
            this.Controls.Add(this.mskDataCheckOut);
            this.Controls.Add(this.mskDataCheckIn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtNacionalidade);
            this.Controls.Add(this.lblNacionalidade);
            this.Controls.Add(this.txtPassaporte);
            this.Controls.Add(this.mskTelefoneReserva);
            this.Controls.Add(this.mskDataNascimentoReserva);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCidadeReserva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeReserva);
            this.Controls.Add(this.txt_email);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.Label lblNacionalidade;
        private System.Windows.Forms.MaskedTextBox txtPassaporte;
        private System.Windows.Forms.MaskedTextBox mskTelefoneReserva;
        private System.Windows.Forms.MaskedTextBox mskDataNascimentoReserva;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidadeReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeReserva;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txtDiaria;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskCheckOutHora;
        private System.Windows.Forms.MaskedTextBox mskCheckInHora;
        private System.Windows.Forms.MaskedTextBox mskDataReserva;
        private System.Windows.Forms.MaskedTextBox mskDataCheckOut;
        private System.Windows.Forms.MaskedTextBox mskDataCheckIn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirmarReserva1;
        private System.Windows.Forms.ComboBox cmbQtdHospede;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbUF;
        private System.Windows.Forms.ComboBox cmbQuarto;
    }
}