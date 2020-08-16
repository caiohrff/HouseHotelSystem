using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Runtime.InteropServices;

namespace NewTech_HouseHotel
{
    public partial class frmAdicionarProduto : Form
    {

        public frmAdicionarProduto()
        {
            InitializeComponent();

        }

        private void btnAddRegistroProduto_Click(object sender, EventArgs e)
        {
            if (txtAddPreco1.Text == "0,00" || txtAddPreco1.Text == "" || txtAddProduto.Text == "")
            {
                MessageBox.Show("Verifique os campos digitados! O campo preço deve ser maior que '0'");
            }
            else
            {
                txtAddPreco1.Text.Replace(".", ",");
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_insere_produto", conexao);
                cmd.CommandType = CommandType.StoredProcedure; ;
                cmd.Parameters.AddWithValue("cod_produto", null);
                cmd.Parameters.AddWithValue("nome", txtAddProduto.Text);
                cmd.Parameters.AddWithValue("valor", txtAddPreco1.Text.Replace(",", "."));
                string retorno = cmd.ExecuteScalar().ToString();
                MessageBox.Show(retorno);
                txtAddProduto.Clear();
                txtAddPreco1.Clear();
                conexao.Close();
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        private void frmAdicionarProduto_Load(object sender, EventArgs e)
        {

        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))

                    n = "";
                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "")

                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch (Exception)
            {

            }
        }


        private void btnRetornarAddProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCardapio>().Count() > 0)
            {
                Form cardapio = Application.OpenForms["frmCardapio"];
                cardapio.Show();
                this.Hide();
            }

        }


        private void txtAddProduto_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtAddProduto_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtAddPreco1_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtAddPreco1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAddPreco1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddProduto_KeyPress(object sender, KeyPressEventArgs e)
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
    }

}
