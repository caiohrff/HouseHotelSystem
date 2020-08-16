using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NewTech_HouseHotel
{
    public partial class frmCardapio : Form

    {
        
        public frmCardapio()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            lblProduto.Visible = false;
            lblAddPro.Visible = false;

        }


        private void cardapio_Load(object sender, EventArgs e)
        {
        }


        private void btnCardapio_Click(object sender, EventArgs e)
        {
            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("ht_cardapio", conecta);
            MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            conecta.Open();
            adptAtualizar.Fill(dt);
            dtgmenu.DataSource = dt.DefaultView;
            conecta.Close();
            dtgmenu.Columns[0].HeaderText = "Código";
            dtgmenu.Columns[0].MinimumWidth = 215;
            dtgmenu.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmenu.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmenu.Columns[1].HeaderText = "Produto";
            dtgmenu.Columns[1].MinimumWidth = 215;
            dtgmenu.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmenu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmenu.Columns[2].HeaderText = "Valor";
            dtgmenu.Columns[2].MinimumWidth = 215;
            dtgmenu.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgmenu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgmenu.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgmenu.DefaultCellStyle.BackColor = Color.Beige;
        }

        private void txtPesquisaCardapio_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("SELECT cd_produto as Codigo, nm_produto as Produto, vl_produto as Preco FROM tb_menu where nm_produto like '" + txtPesquisaCardapio.Text + "%'", conecta);
            MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            conecta.Open();
            adptAtualizar.Fill(dt);
            dtgmenu.DataSource = dt.DefaultView;
            this.dtgmenu.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgmenu.DefaultCellStyle.BackColor = Color.Beige;
            conecta.Close();
        }

        private void btnRetornarCardapio_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAdicionarProduto addpro = new frmAdicionarProduto();
            addpro.Show();
            txtPesquisaCardapio.Clear();
                         
        }

        private void txtPesquisaCardapio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            
        }

        private void dtgmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCardapio_MouseHover(object sender, EventArgs e)
        {
            lblProduto.Visible = true;
        }

        private void btnCardapio_MouseLeave(object sender, EventArgs e)
        {
            lblProduto.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblAddPro.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblAddPro.Visible = false;
        }
    }
}
