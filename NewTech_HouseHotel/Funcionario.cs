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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void txtPesquisar2_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void lstNome_Click(object sender, EventArgs e)
        {
            
        }


        private void lstNome2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            txtPesquisar2.GotFocus += new EventHandler(this.TextGotFocus);
            txtPesquisar2.LostFocus += new EventHandler(this.TextLostFocus);
            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("sp_mostraNome", conecta);
            MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            conecta.Open();
            adptAtualizar.Fill(dt);
            dtgNome.DataSource = dt.DefaultView;
            conecta.Close();
            dtgNome.Columns[0].HeaderText = "Funcionários";
            dtgNome.Columns[0].MinimumWidth = 215;
            dtgNome.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgNome.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgNome.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgNome.DefaultCellStyle.BackColor = Color.Beige;
            this.dtgNome.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o nome aqui ...")
            {
                tb.Text = "";
                tb.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o nome aqui ...")
            {
                tb.Text = "Digite o nome aqui ...";
                tb.ForeColor = Color.Gray;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lstNomeFunc2_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar2.Text == "")
            {
                MessageBox.Show("Por favor, não deixe campos vazios!");
            }
            else
            {
                String nome = "";
                String cpf = "";
                String login = "";
                String senha = "";
                String cep = "";
                String cidade = "";
                String numeroend = "";
                String nomeend = "";
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                MySqlCommand cmd = new MySqlCommand("call ht_dados_funcionario(@nome)", conexao);
                cmd.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = txtPesquisar2.Text;
                MySqlDataReader dr;
                conexao.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nome = dr.GetString("nm_funcionario");
                    cpf = dr.GetString("cd_cpf");
                    login = dr.GetString("nm_login");
                    senha = dr.GetString("ds_senha");
                    cep = dr.GetString("cd_cep");
                    cidade = dr.GetString("nm_cidade");
                    numeroend = dr.GetString("cd_endereco");
                    nomeend = dr.GetString("nm_endereco");
                }



                lblCPF.Text = cpf;
                lblNome.Text = nome;
                lblLogin.Text = login;
                lblSenha.Text = senha;
                lblCEP.Text = cep;
                lblCidade.Text = cidade;
                lblNumeroEndereco.Text = numeroend;
                lblNomeEndereco.Text = nomeend;
                conexao.Close();
            }
        }

        private void dtgNome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar2_KeyPress(object sender, KeyPressEventArgs e)
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

