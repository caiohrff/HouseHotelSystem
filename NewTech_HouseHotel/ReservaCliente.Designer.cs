namespace NewTech_HouseHotel
{
    partial class ReservaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservaCliente));
            this.mskCheckOutHora = new System.Windows.Forms.MaskedTextBox();
            this.mskCheckInHora = new System.Windows.Forms.MaskedTextBox();
            this.mskDataReserva = new System.Windows.Forms.MaskedTextBox();
            this.mskDataCheckOut = new System.Windows.Forms.MaskedTextBox();
            this.mskDataCheckIn = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiaria = new System.Windows.Forms.TextBox();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeReserva = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbQuarto = new System.Windows.Forms.ComboBox();
            this.gprAtencao = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmbtdHospede = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.gprAtencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCheckOutHora
            // 
            this.mskCheckOutHora.Location = new System.Drawing.Point(577, 502);
            this.mskCheckOutHora.Mask = "00:00";
            this.mskCheckOutHora.Name = "mskCheckOutHora";
            this.mskCheckOutHora.Size = new System.Drawing.Size(50, 20);
            this.mskCheckOutHora.TabIndex = 418;
            this.mskCheckOutHora.ValidatingType = typeof(System.DateTime);
            // 
            // mskCheckInHora
            // 
            this.mskCheckInHora.Location = new System.Drawing.Point(577, 469);
            this.mskCheckInHora.Mask = "00:00";
            this.mskCheckInHora.Name = "mskCheckInHora";
            this.mskCheckInHora.Size = new System.Drawing.Size(50, 20);
            this.mskCheckInHora.TabIndex = 417;
            this.mskCheckInHora.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataReserva
            // 
            this.mskDataReserva.Location = new System.Drawing.Point(565, 437);
            this.mskDataReserva.Mask = "00/00/0000";
            this.mskDataReserva.Name = "mskDataReserva";
            this.mskDataReserva.Size = new System.Drawing.Size(82, 20);
            this.mskDataReserva.TabIndex = 416;
            this.mskDataReserva.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataCheckOut
            // 
            this.mskDataCheckOut.Location = new System.Drawing.Point(565, 406);
            this.mskDataCheckOut.Mask = "00/00/0000";
            this.mskDataCheckOut.Name = "mskDataCheckOut";
            this.mskDataCheckOut.Size = new System.Drawing.Size(82, 20);
            this.mskDataCheckOut.TabIndex = 415;
            this.mskDataCheckOut.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataCheckIn
            // 
            this.mskDataCheckIn.Location = new System.Drawing.Point(565, 373);
            this.mskDataCheckIn.Mask = "00/00/0000";
            this.mskDataCheckIn.Name = "mskDataCheckIn";
            this.mskDataCheckIn.Size = new System.Drawing.Size(82, 20);
            this.mskDataCheckIn.TabIndex = 414;
            this.mskDataCheckIn.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(421, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 18);
            this.label14.TabIndex = 413;
            this.label14.Text = "Data da reserva:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(421, 508);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 18);
            this.label13.TabIndex = 412;
            this.label13.Text = "Horário do check-out:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 411;
            this.label12.Text = "Horário do check-in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(421, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 409;
            this.label8.Text = "Data do Check-In:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(421, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 18);
            this.label17.TabIndex = 410;
            this.label17.Text = "Data do Check-Out:";
            // 
            // txtDiaria
            // 
            this.txtDiaria.Location = new System.Drawing.Point(786, 177);
            this.txtDiaria.Name = "txtDiaria";
            this.txtDiaria.Size = new System.Drawing.Size(84, 20);
            this.txtDiaria.TabIndex = 408;
            // 
            // lblDiaria
            // 
            this.lblDiaria.AutoSize = true;
            this.lblDiaria.Location = new System.Drawing.Point(671, 180);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(79, 13);
            this.lblDiaria.TabIndex = 407;
            this.lblDiaria.Text = "Valor da Diária:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(671, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 405;
            this.label9.Text = "Observação:";
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(765, 210);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtObs.Size = new System.Drawing.Size(112, 94);
            this.txtObs.TabIndex = 406;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(206, 469);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 404;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(126, 472);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(66, 18);
            this.lblNumero.TabIndex = 403;
            this.lblNumero.Text = "Número:";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(504, 243);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(76, 20);
            this.txtUF.TabIndex = 402;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(422, 246);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(24, 13);
            this.lblUf.TabIndex = 401;
            this.lblUf.Text = "UF:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(504, 211);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(161, 20);
            this.txtPais.TabIndex = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 399;
            this.label1.Text = "País:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(208, 504);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(130, 20);
            this.txtBairro.TabIndex = 398;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(126, 507);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 18);
            this.lblBairro.TabIndex = 397;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(206, 437);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(155, 20);
            this.txtEndereco.TabIndex = 396;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(124, 440);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 18);
            this.lblEndereco.TabIndex = 395;
            this.lblEndereco.Text = "Endereço:";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(236, 408);
            this.mskCel.Mask = " (00) 0000-00000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(161, 20);
            this.mskCel.TabIndex = 394;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(125, 411);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 18);
            this.lblCelular.TabIndex = 393;
            this.lblCelular.Text = "Celular:";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(236, 342);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(115, 20);
            this.txtNacionalidade.TabIndex = 392;
            // 
            // lblNacionalidade
            // 
            this.lblNacionalidade.AutoSize = true;
            this.lblNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidade.Location = new System.Drawing.Point(125, 345);
            this.lblNacionalidade.Name = "lblNacionalidade";
            this.lblNacionalidade.Size = new System.Drawing.Size(105, 18);
            this.lblNacionalidade.TabIndex = 391;
            this.lblNacionalidade.Text = "Nacionalidade:";
            // 
            // txtPassaporte
            // 
            this.txtPassaporte.Location = new System.Drawing.Point(236, 308);
            this.txtPassaporte.Mask = "LL0000000";
            this.txtPassaporte.Name = "txtPassaporte";
            this.txtPassaporte.Size = new System.Drawing.Size(84, 20);
            this.txtPassaporte.TabIndex = 390;
            // 
            // mskTelefoneReserva
            // 
            this.mskTelefoneReserva.Location = new System.Drawing.Point(236, 375);
            this.mskTelefoneReserva.Mask = "(00) 0000-0000";
            this.mskTelefoneReserva.Name = "mskTelefoneReserva";
            this.mskTelefoneReserva.Size = new System.Drawing.Size(161, 20);
            this.mskTelefoneReserva.TabIndex = 389;
            // 
            // mskDataNascimentoReserva
            // 
            this.mskDataNascimentoReserva.Location = new System.Drawing.Point(275, 275);
            this.mskDataNascimentoReserva.Mask = "00/00/0000";
            this.mskDataNascimentoReserva.Name = "mskDataNascimentoReserva";
            this.mskDataNascimentoReserva.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimentoReserva.TabIndex = 388;
            this.mskDataNascimentoReserva.ValidatingType = typeof(System.DateTime);
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(504, 275);
            this.msk_cep.Mask = "00000-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(111, 24);
            this.msk_cep.TabIndex = 387;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(185, 212);
            this.mskCPF.Mask = "000-000-000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(122, 24);
            this.mskCPF.TabIndex = 386;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 385;
            this.label11.Text = "CEP:";
            // 
            // txtCidadeReserva
            // 
            this.txtCidadeReserva.Location = new System.Drawing.Point(504, 177);
            this.txtCidadeReserva.Name = "txtCidadeReserva";
            this.txtCidadeReserva.Size = new System.Drawing.Size(161, 20);
            this.txtCidadeReserva.TabIndex = 384;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 383;
            this.label10.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 375;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 376;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(124, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 377;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(125, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 378;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(125, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 379;
            this.label6.Text = "Passaporte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 380;
            this.label7.Text = "Data de Nascimento:";
            // 
            // txtNomeReserva
            // 
            this.txtNomeReserva.Location = new System.Drawing.Point(185, 178);
            this.txtNomeReserva.Name = "txtNomeReserva";
            this.txtNomeReserva.Size = new System.Drawing.Size(231, 20);
            this.txtNomeReserva.TabIndex = 381;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(185, 244);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(166, 20);
            this.txt_email.TabIndex = 382;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(423, 341);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 374;
            this.label15.Text = "Quartos:";
            // 
            // cmbQuarto
            // 
            this.cmbQuarto.FormattingEnabled = true;
            this.cmbQuarto.Location = new System.Drawing.Point(501, 340);
            this.cmbQuarto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuarto.Name = "cmbQuarto";
            this.cmbQuarto.Size = new System.Drawing.Size(98, 21);
            this.cmbQuarto.TabIndex = 373;
            this.cmbQuarto.Text = "Selecione...";
            // 
            // gprAtencao
            // 
            this.gprAtencao.BackColor = System.Drawing.Color.Transparent;
            this.gprAtencao.Controls.Add(this.lblMsg);
            this.gprAtencao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gprAtencao.Location = new System.Drawing.Point(229, 70);
            this.gprAtencao.Margin = new System.Windows.Forms.Padding(4);
            this.gprAtencao.Name = "gprAtencao";
            this.gprAtencao.Padding = new System.Windows.Forms.Padding(4);
            this.gprAtencao.Size = new System.Drawing.Size(370, 68);
            this.gprAtencao.TabIndex = 370;
            this.gprAtencao.TabStop = false;
            this.gprAtencao.Text = "House Hotel";
            this.gprAtencao.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(91, 33);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Visible = false;
            // 
            // cmbtdHospede
            // 
            this.cmbtdHospede.FormattingEnabled = true;
            this.cmbtdHospede.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbtdHospede.Location = new System.Drawing.Point(556, 308);
            this.cmbtdHospede.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtdHospede.Name = "cmbtdHospede";
            this.cmbtdHospede.Size = new System.Drawing.Size(92, 21);
            this.cmbtdHospede.TabIndex = 372;
            this.cmbtdHospede.Text = "Selecione...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(423, 309);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 18);
            this.label16.TabIndex = 371;
            this.label16.Text = "Qtd de hospedes:";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarReserva.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            this.btnConfirmarReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarReserva.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmarReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarReserva.Image")));
            this.btnConfirmarReserva.Location = new System.Drawing.Point(350, 525);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(66, 36);
            this.btnConfirmarReserva.TabIndex = 419;
            this.btnConfirmarReserva.UseVisualStyleBackColor = false;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // ReservaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1001, 631);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.mskCheckOutHora);
            this.Controls.Add(this.mskCheckInHora);
            this.Controls.Add(this.mskDataReserva);
            this.Controls.Add(this.mskDataCheckOut);
            this.Controls.Add(this.mskDataCheckIn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDiaria);
            this.Controls.Add(this.lblDiaria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeReserva);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbQuarto);
            this.Controls.Add(this.gprAtencao);
            this.Controls.Add(this.cmbtdHospede);
            this.Controls.Add(this.label16);
            this.Name = "ReservaCliente";
            this.Text = "ReservaCliente";
            this.gprAtencao.ResumeLayout(false);
            this.gprAtencao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.MaskedTextBox mskCheckOutHora;
        private System.Windows.Forms.MaskedTextBox mskCheckInHora;
        private System.Windows.Forms.MaskedTextBox mskDataReserva;
        private System.Windows.Forms.MaskedTextBox mskDataCheckOut;
        private System.Windows.Forms.MaskedTextBox mskDataCheckIn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiaria;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeReserva;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbQuarto;
        private System.Windows.Forms.GroupBox gprAtencao;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox cmbtdHospede;
        private System.Windows.Forms.Label label16;
    }
}