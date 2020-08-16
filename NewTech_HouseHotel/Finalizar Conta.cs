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
    public partial class Finalizar_Conta : Form
    {
        public Finalizar_Conta()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void Finalizar_Conta_Load(object sender, EventArgs e)
        {

            //  PEGANDO HORA DO CHECK OUT
            DateTime dt = DateTime.Now;
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            DateTime checkout = DateTime.Now;
            String saida = "";
            String MySql = "";
            String datagar = "";
            MySql = "SELECT dt_check_out FROM tb_reserva where dt_check_out = (select curdate())";
            MySqlCommand comandoSelect = new MySqlCommand(MySql, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            while (dr.Read())
            {
                checkout = dr.GetDateTime("dt_check_out");
            }
            saida = checkout.ToShortDateString();
            conexao.Close();
            dr.Close();
            datagar = dt.ToShortDateString();
            // fim conversão

            if (saida == datagar)
            {
                MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
                MySqlCommand comanda = new MySqlCommand("call ht_exibe_saida()", conecta);
                MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
                DataTable data = new DataTable();
                conecta.Open();
                adptAtualizar.Fill(data);
                dtgPagCliente.DataSource = data.DefaultView;
                conecta.Close();
                dtgPagCliente.Columns[0].HeaderText = "Clientes";
                dtgPagCliente.Columns[0].MinimumWidth = 215;
                dtgPagCliente.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[1].HeaderText = "Valor";
                dtgPagCliente.Columns[1].MinimumWidth = 215;
                dtgPagCliente.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[2].HeaderText = "Check out";
                dtgPagCliente.Columns[2].MinimumWidth = 215;
                dtgPagCliente.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[3].HeaderText = "CPF";
                dtgPagCliente.Columns[3].MinimumWidth = 215;
                dtgPagCliente.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgPagCliente.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dtgPagCliente.DefaultCellStyle.ForeColor = Color.Black;
                this.dtgPagCliente.DefaultCellStyle.BackColor = Color.Beige;
                this.dtgPagCliente.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            }
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

        private void btnConfirmaPag_Click(object sender, EventArgs e)
        {
            if (txtNomePag.Text == "" || txtValorPag.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "House Hotel");
            }
            else
            {

                txtValorPag.Text.Replace(".", ",");
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                conexao.Open();
                MySqlCommand pag = new MySqlCommand("call ht_pagamento_cliente (@nome, @pag)", conexao);
                pag.Parameters.AddWithValue("@nome", txtNomePag.Text);
                pag.Parameters.AddWithValue("@pag", txtValorPag.Text.Replace(",", "."));
                int linhasAfetadas = 0;
                linhasAfetadas = pag.ExecuteNonQuery();


                if (linhasAfetadas != 0)
                {

                    MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                    Decimal valor = 0;
                    String MySql = "";
                    //MySql = ;
                    MySqlCommand comandoSelect = new MySqlCommand("SELECT vl_gastos FROM tb_cliente WHERE nm_cliente = @Cliente", con);
                    comandoSelect.Parameters.Add(new MySqlParameter("@Cliente", MySqlDbType.VarChar)).Value = txtNomePag.Text;
                    MySqlDataReader reader;
                    con.Open();
                    reader = comandoSelect.ExecuteReader();
                    while (reader.Read())
                    {
                        valor = reader.GetDecimal("vl_gastos");
                    }
                    if (valor == 0)
                    {
                        MessageBox.Show("Pagamento efetuado com sucesso!", "House Hotel");
                        MySqlCommand pag2 = new MySqlCommand("call ht_deleta_cliente (@cpf)", conexao);
                        pag2.Parameters.AddWithValue("@cpf", mskCPF.Text);
                        int linhasAfetadas2 = 0;
                        linhasAfetadas2 = pag2.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("Ainda há debitos existente nesta conta!", "House Hotel");
                    }
                    con.Close();
                    reader.Close();



                }

                conexao.Close();
            }
        }

        private void txtValorPag_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtValorPag);
        }

        private void dtgPagCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
