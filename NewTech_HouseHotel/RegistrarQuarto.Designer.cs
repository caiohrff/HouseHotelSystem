namespace NewTech_HouseHotel
{
    partial class RegistrarQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarQuarto));
            this.grpMsg12 = new System.Windows.Forms.GroupBox();
            this.lblMsg12 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacaoQuarto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lblDescQuarto = new System.Windows.Forms.Label();
            this.txtNomeQuarto = new System.Windows.Forms.TextBox();
            this.lblNomeQuarto = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.grpMsg12.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMsg12
            // 
            this.grpMsg12.BackColor = System.Drawing.Color.Transparent;
            this.grpMsg12.Controls.Add(this.lblMsg12);
            this.grpMsg12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMsg12.ForeColor = System.Drawing.Color.White;
            this.grpMsg12.Location = new System.Drawing.Point(106, 25);
            this.grpMsg12.Name = "grpMsg12";
            this.grpMsg12.Size = new System.Drawing.Size(265, 61);
            this.grpMsg12.TabIndex = 34;
            this.grpMsg12.TabStop = false;
            this.grpMsg12.Text = "House Hotel";
            this.grpMsg12.Visible = false;
            // 
            // lblMsg12
            // 
            this.lblMsg12.AutoSize = true;
            this.lblMsg12.Location = new System.Drawing.Point(29, 33);
            this.lblMsg12.Name = "lblMsg12";
            this.lblMsg12.Size = new System.Drawing.Size(0, 18);
            this.lblMsg12.TabIndex = 0;
            this.lblMsg12.Visible = false;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(188, 216);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(103, 24);
            this.txtSituacao.TabIndex = 33;
            this.txtSituacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSituacao_KeyPress);
            // 
            // lblSituacaoQuarto
            // 
            this.lblSituacaoQuarto.AutoSize = true;
            this.lblSituacaoQuarto.BackColor = System.Drawing.Color.Transparent;
            this.lblSituacaoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoQuarto.ForeColor = System.Drawing.Color.White;
            this.lblSituacaoQuarto.Location = new System.Drawing.Point(62, 218);
            this.lblSituacaoQuarto.Name = "lblSituacaoQuarto";
            this.lblSituacaoQuarto.Size = new System.Drawing.Size(70, 18);
            this.lblSituacaoQuarto.TabIndex = 31;
            this.lblSituacaoQuarto.Text = "Situação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Categoria:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(249, 398);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 39);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(188, 259);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(218, 133);
            this.txtDesc.TabIndex = 27;
            this.txtDesc.Text = "";
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // lblDescQuarto
            // 
            this.lblDescQuarto.AutoSize = true;
            this.lblDescQuarto.BackColor = System.Drawing.Color.Transparent;
            this.lblDescQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescQuarto.ForeColor = System.Drawing.Color.White;
            this.lblDescQuarto.Location = new System.Drawing.Point(62, 258);
            this.lblDescQuarto.Name = "lblDescQuarto";
            this.lblDescQuarto.Size = new System.Drawing.Size(80, 18);
            this.lblDescQuarto.TabIndex = 26;
            this.lblDescQuarto.Text = "Descrição:";
            // 
            // txtNomeQuarto
            // 
            this.txtNomeQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeQuarto.Location = new System.Drawing.Point(188, 131);
            this.txtNomeQuarto.Name = "txtNomeQuarto";
            this.txtNomeQuarto.Size = new System.Drawing.Size(168, 24);
            this.txtNomeQuarto.TabIndex = 25;
            this.txtNomeQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeQuarto_KeyPress);
            // 
            // lblNomeQuarto
            // 
            this.lblNomeQuarto.AutoSize = true;
            this.lblNomeQuarto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeQuarto.ForeColor = System.Drawing.Color.White;
            this.lblNomeQuarto.Location = new System.Drawing.Point(62, 130);
            this.lblNomeQuarto.Name = "lblNomeQuarto";
            this.lblNomeQuarto.Size = new System.Drawing.Size(120, 18);
            this.lblNomeQuarto.TabIndex = 24;
            this.lblNomeQuarto.Text = "Nome do quarto:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "quarto solteiro",
            "quarto duplo solteiro",
            "quarto casal",
            "Padrão",
            "Quarto para família"});
            this.cmbCategoria.Location = new System.Drawing.Point(188, 174);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(136, 26);
            this.cmbCategoria.TabIndex = 38;
            this.cmbCategoria.Text = "Selecione...";
            this.cmbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategoria_KeyPress);
            // 
            // RegistrarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 519);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.grpMsg12);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.lblSituacaoQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescQuarto);
            this.Controls.Add(this.txtNomeQuarto);
            this.Controls.Add(this.lblNomeQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistrarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Hotel";
            this.Load += new System.EventHandler(this.RegistrarQuarto_Load);
            this.MouseLeave += new System.EventHandler(this.RegistrarQuarto_MouseLeave);
            this.grpMsg12.ResumeLayout(false);
            this.grpMsg12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMsg12;
        private System.Windows.Forms.Label lblMsg12;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label lblSituacaoQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label lblDescQuarto;
        private System.Windows.Forms.TextBox txtNomeQuarto;
        private System.Windows.Forms.Label lblNomeQuarto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}