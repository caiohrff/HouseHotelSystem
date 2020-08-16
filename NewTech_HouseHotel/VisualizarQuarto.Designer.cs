namespace NewTech_HouseHotel
{
    partial class frmVisualizarQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarQuarto));
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.grpInfoQuarto = new System.Windows.Forms.GroupBox();
            this.lblDisponibilidade = new System.Windows.Forms.Label();
            this.lblNomeQuarto = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblSit = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblQuarto = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAddQuarto = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeletQuarto = new System.Windows.Forms.Button();
            this.txtDeleteQuarto = new System.Windows.Forms.TextBox();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHospede = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpInfoQuarto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(6, 145);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(70, 18);
            this.lblSituacao.TabIndex = 3;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(6, 115);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // grpInfoQuarto
            // 
            this.grpInfoQuarto.BackColor = System.Drawing.Color.Transparent;
            this.grpInfoQuarto.Controls.Add(this.lblQtd);
            this.grpInfoQuarto.Controls.Add(this.label4);
            this.grpInfoQuarto.Controls.Add(this.lblDisponibilidade);
            this.grpInfoQuarto.Controls.Add(this.lblDisp);
            this.grpInfoQuarto.Controls.Add(this.lblHospede);
            this.grpInfoQuarto.Controls.Add(this.label2);
            this.grpInfoQuarto.Controls.Add(this.lblNomeQuarto);
            this.grpInfoQuarto.Controls.Add(this.lblDesc);
            this.grpInfoQuarto.Controls.Add(this.lblSit);
            this.grpInfoQuarto.Controls.Add(this.lblCat);
            this.grpInfoQuarto.Controls.Add(this.lblQuarto);
            this.grpInfoQuarto.Controls.Add(this.lblDescricao);
            this.grpInfoQuarto.Controls.Add(this.lblSituacao);
            this.grpInfoQuarto.Controls.Add(this.lblCategoria);
            this.grpInfoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoQuarto.ForeColor = System.Drawing.Color.White;
            this.grpInfoQuarto.Location = new System.Drawing.Point(478, 71);
            this.grpInfoQuarto.Name = "grpInfoQuarto";
            this.grpInfoQuarto.Size = new System.Drawing.Size(287, 235);
            this.grpInfoQuarto.TabIndex = 21;
            this.grpInfoQuarto.TabStop = false;
            this.grpInfoQuarto.Text = "Informações do quarto";
            this.grpInfoQuarto.Enter += new System.EventHandler(this.grpInfoQuarto_Enter);
            // 
            // lblDisponibilidade
            // 
            this.lblDisponibilidade.AutoSize = true;
            this.lblDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidade.Location = new System.Drawing.Point(6, 89);
            this.lblDisponibilidade.Name = "lblDisponibilidade";
            this.lblDisponibilidade.Size = new System.Drawing.Size(111, 18);
            this.lblDisponibilidade.TabIndex = 11;
            this.lblDisponibilidade.Text = "Disponibilidade:";
            // 
            // lblNomeQuarto
            // 
            this.lblNomeQuarto.AutoSize = true;
            this.lblNomeQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeQuarto.Location = new System.Drawing.Point(6, 35);
            this.lblNomeQuarto.Name = "lblNomeQuarto";
            this.lblNomeQuarto.Size = new System.Drawing.Size(120, 18);
            this.lblNomeQuarto.TabIndex = 10;
            this.lblNomeQuarto.Text = "Nome do quarto:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(92, 174);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 18);
            this.lblDesc.TabIndex = 9;
            // 
            // lblSit
            // 
            this.lblSit.AutoSize = true;
            this.lblSit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSit.Location = new System.Drawing.Point(92, 145);
            this.lblSit.Name = "lblSit";
            this.lblSit.Size = new System.Drawing.Size(0, 18);
            this.lblSit.TabIndex = 8;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(92, 115);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(0, 18);
            this.lblCat.TabIndex = 7;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(123, 89);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 18);
            this.lblDisp.TabIndex = 6;
            // 
            // lblQuarto
            // 
            this.lblQuarto.AutoSize = true;
            this.lblQuarto.Location = new System.Drawing.Point(124, 35);
            this.lblQuarto.Name = "lblQuarto";
            this.lblQuarto.Size = new System.Drawing.Size(0, 18);
            this.lblQuarto.TabIndex = 5;
            this.lblQuarto.Click += new System.EventHandler(this.lblQuarto_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 174);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 18);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnAddQuarto
            // 
            this.btnAddQuarto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuarto.FlatAppearance.BorderSize = 0;
            this.btnAddQuarto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuarto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddQuarto.Image")));
            this.btnAddQuarto.Location = new System.Drawing.Point(505, 360);
            this.btnAddQuarto.Name = "btnAddQuarto";
            this.btnAddQuarto.Size = new System.Drawing.Size(44, 44);
            this.btnAddQuarto.TabIndex = 348;
            this.btnAddQuarto.UseVisualStyleBackColor = false;
            this.btnAddQuarto.Click += new System.EventHandler(this.btnAddQuarto_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 389);
            this.flowLayoutPanel1.TabIndex = 350;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(495, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 18);
            this.label5.TabIndex = 389;
            this.label5.Text = "Adicione ou remova um quarto";
            // 
            // btnDeletQuarto
            // 
            this.btnDeletQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletQuarto.FlatAppearance.BorderSize = 0;
            this.btnDeletQuarto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeletQuarto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeletQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletQuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletQuarto.Image")));
            this.btnDeletQuarto.Location = new System.Drawing.Point(712, 404);
            this.btnDeletQuarto.Name = "btnDeletQuarto";
            this.btnDeletQuarto.Size = new System.Drawing.Size(53, 41);
            this.btnDeletQuarto.TabIndex = 390;
            this.btnDeletQuarto.UseVisualStyleBackColor = true;
            this.btnDeletQuarto.Click += new System.EventHandler(this.btnDeletQuarto_Click);
            // 
            // txtDeleteQuarto
            // 
            this.txtDeleteQuarto.ForeColor = System.Drawing.Color.Black;
            this.txtDeleteQuarto.Location = new System.Drawing.Point(557, 425);
            this.txtDeleteQuarto.Name = "txtDeleteQuarto";
            this.txtDeleteQuarto.Size = new System.Drawing.Size(157, 20);
            this.txtDeleteQuarto.TabIndex = 391;
            this.txtDeleteQuarto.TextChanged += new System.EventHandler(this.txtDeleteQuarto_TextChanged);
            this.txtDeleteQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeleteQuarto_KeyPress);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualiza.FlatAppearance.BorderSize = 0;
            this.btnAtualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualiza.Image")));
            this.btnAtualiza.Location = new System.Drawing.Point(691, 333);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(44, 33);
            this.btnAtualiza.TabIndex = 392;
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 393;
            this.label1.Text = "Depois atualize a tela aqui:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hospede:";
            // 
            // lblHospede
            // 
            this.lblHospede.AutoSize = true;
            this.lblHospede.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospede.Location = new System.Drawing.Point(84, 62);
            this.lblHospede.Name = "lblHospede";
            this.lblHospede.Size = new System.Drawing.Size(0, 18);
            this.lblHospede.TabIndex = 13;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(101, 204);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(0, 18);
            this.lblQtd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Qtd hospede:";
            // 
            // frmVisualizarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.txtDeleteQuarto);
            this.Controls.Add(this.btnDeletQuarto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddQuarto);
            this.Controls.Add(this.grpInfoQuarto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualizarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Hotel";
            this.Load += new System.EventHandler(this.frmVisualizarQuarto_Load);
            this.grpInfoQuarto.ResumeLayout(false);
            this.grpInfoQuarto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox grpInfoQuarto;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSit;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblQuarto;
        private System.Windows.Forms.Button btnAddQuarto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDisponibilidade;
        private System.Windows.Forms.Label lblNomeQuarto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeletQuarto;
        private System.Windows.Forms.TextBox txtDeleteQuarto;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblHospede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label4;
    }
}