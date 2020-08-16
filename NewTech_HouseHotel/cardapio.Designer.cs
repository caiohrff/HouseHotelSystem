namespace NewTech_HouseHotel
{
    partial class frmCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardapio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCardapio = new System.Windows.Forms.Button();
            this.dtgmenu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesquisaCardapio = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblAddPro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCardapio
            // 
            this.btnCardapio.BackColor = System.Drawing.Color.Transparent;
            this.btnCardapio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCardapio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCardapio.FlatAppearance.BorderSize = 0;
            this.btnCardapio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCardapio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("btnCardapio.Image")));
            this.btnCardapio.Location = new System.Drawing.Point(142, 103);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(75, 72);
            this.btnCardapio.TabIndex = 0;
            this.btnCardapio.UseVisualStyleBackColor = false;
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click);
            this.btnCardapio.MouseLeave += new System.EventHandler(this.btnCardapio_MouseLeave);
            this.btnCardapio.MouseHover += new System.EventHandler(this.btnCardapio_MouseHover);
            // 
            // dtgmenu
            // 
            this.dtgmenu.AllowUserToAddRows = false;
            this.dtgmenu.AllowUserToDeleteRows = false;
            this.dtgmenu.AllowUserToResizeColumns = false;
            this.dtgmenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgmenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgmenu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgmenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgmenu.EnableHeadersVisualStyles = false;
            this.dtgmenu.Location = new System.Drawing.Point(30, 239);
            this.dtgmenu.Name = "dtgmenu";
            this.dtgmenu.ReadOnly = true;
            this.dtgmenu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgmenu.RowHeadersVisible = false;
            this.dtgmenu.Size = new System.Drawing.Size(707, 150);
            this.dtgmenu.TabIndex = 42;
            this.dtgmenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgmenu_CellClick);
            this.dtgmenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgmenu_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(544, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // txtPesquisaCardapio
            // 
            this.txtPesquisaCardapio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCardapio.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisaCardapio.Location = new System.Drawing.Point(223, 155);
            this.txtPesquisaCardapio.Name = "txtPesquisaCardapio";
            this.txtPesquisaCardapio.Size = new System.Drawing.Size(288, 24);
            this.txtPesquisaCardapio.TabIndex = 1;
            this.txtPesquisaCardapio.TextChanged += new System.EventHandler(this.txtPesquisaCardapio_TextChanged);
            this.txtPesquisaCardapio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaCardapio_KeyPress);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(139, 178);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(71, 13);
            this.lblProduto.TabIndex = 45;
            this.lblProduto.Text = "Mostrar todos";
            // 
            // lblAddPro
            // 
            this.lblAddPro.AutoSize = true;
            this.lblAddPro.Location = new System.Drawing.Point(541, 178);
            this.lblAddPro.Name = "lblAddPro";
            this.lblAddPro.Size = new System.Drawing.Size(104, 13);
            this.lblAddPro.TabIndex = 46;
            this.lblAddPro.Text = "Adicione um produto";
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(769, 502);
            this.Controls.Add(this.lblAddPro);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgmenu);
            this.Controls.Add(this.txtPesquisaCardapio);
            this.Controls.Add(this.btnCardapio);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Hotel";
            this.Load += new System.EventHandler(this.cardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgmenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCardapio;
        private System.Windows.Forms.DataGridView dtgmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesquisaCardapio;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblAddPro;
    }
}

