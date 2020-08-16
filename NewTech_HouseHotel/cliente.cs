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
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            gprMessaCod.Visible = false;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            //conexao.Open();
            //String sqlUsuario = "SELECT cd_cpf, nm_cliente FROM tb_cliente WHERE nm_cliente LIKE '%" + txtPesquisar.Text + "%'";
            //MySqlCommand comando = new MySqlCommand(sqlUsuario, conexao);
            //MySqlDataAdapter adptAtualiza = new MySqlDataAdapter(comando);
            //DataTable dt = new DataTable();
            //adptAtualiza.Fill(dt);
            //lstNome.DataSource = dt.DefaultView;
            //lstNome.DisplayMember = "nm_cliente";
            //lstNome.ValueMember = "cd_cpf";
            //conexao.Close();
        }


        private void lstNome_Click(object sender, EventArgs e)
        {

           // String nome = "";
           // String cpf = "";
           // String valor = "";
           // String cep = "";
           // String cidade = "";
           // String passaporte = "";
           // String data = "";
           // String nacionalidade = "";
           // String numeroend = "";
           // String nomeend = "";
           // MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
           // MySqlDataReader dr;
           // conexao.Open();
           //// String sqlUsuario = ("ht_dados_cliente()");
           //// String sqlUsuario = "ht_dados_cliente =" + lstNome.SelectedValue;
           // MySqlCommand comandoSelect = new MySqlCommand(sqlUsuario, conexao);
           // dr = comandoSelect.ExecuteReader();
           // while (dr.Read())
           // {
           //     nome = dr.GetString("nm_cliente");
           //     cpf = dr.GetString("cd_cpf");
           //     valor = dr.GetString("vl_gastos");
           //     cep = dr.GetString("cd_cep");
           //     cidade = dr.GetString("nm_cidade");
           //     passaporte = dr.GetString("cd_passaporte");
           //     data = dr.GetString("dt_nascimento");
           //     nacionalidade = dr.GetString("nm_nacionalidade");
           //     numeroend = dr.GetString("cd_endereco");
           //     nomeend = dr.GetString("nm_endereco");
           // }



           // lblCPf.Text = cpf;
           // lblNome.Text = nome;
           // lblPassaporteC.Text = passaporte;
           // lblDataC.Text = data;
           // lblCEPC.Text = cep;
           // lblCidadeC.Text = cidade;
           // lblNumeroEnderecoC.Text = numeroend;
           // lblNomeEndC.Text = nomeend;
           // conexao.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmEscolha_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda2 = new MySqlCommand("select nm_produto from tb_menu", conexao);
            conexao.Open();
            MySqlDataReader leitor = comanda2.ExecuteReader();
            while (leitor.Read())
            {
                cmbProdutos.Items.Add(leitor[0]);
            }
            //adptAtualizar.Fill(dt);
            //cmbQuarto.DataSource = dt.DefaultView;
            //cmbQuarto.DisplayMember = "cd_quarto";
            conexao.Close();
            //txtCodigoConsumo.GotFocus += new EventHandler(this.TextGotFocus);
            //txtCodigoConsumo.LostFocus += new EventHandler(this.TextLostFocus);
            string[] textos = { "Deseja adicionar um produto?", "Deseja adicionar um produto? Digite abaixo",""};
            var t = new System.Windows.Forms.Timer();
            int i = 0;
            t.Tick += delegate
            {
                lblPergunta.Text = textos[i];
                Application.DoEvents();
                i = (i < textos.Length - 1) ? (i + 1) : 0;
            };
            t.Interval = 2500;
            t.Start();
            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("sp_mostraNomeCliente", conecta);
            MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            DataTable dt = new DataTable();
            conecta.Open();
            adptAtualizar.Fill(dt);
            dtgCliente.DataSource = dt.DefaultView;
            conecta.Close();
            dtgCliente.Columns[0].HeaderText = "Clientes";
            dtgCliente.Columns[0].MinimumWidth = 215;
            dtgCliente.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtgCliente.DefaultCellStyle.ForeColor = Color.Black;
            this.dtgCliente.DefaultCellStyle.BackColor = Color.Beige;
            this.dtgCliente.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }
        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o cpf aqui...")
            {
                tb.Text = "";
                tb.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o cpf aqui...")
            {
                tb.Text = "Digite o cpf aqui...";
                tb.ForeColor = Color.Gray;
            }
        }

        private void btnAddConsumo_MouseHover(object sender, EventArgs e)
        {
            lblConsumo.Visible = true;
        }

        private void btnAddConsumo_MouseLeave(object sender, EventArgs e)
        {
            lblConsumo.Visible = false;
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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

        private void btnAddConsumo_Click(object sender, EventArgs e)
        {
            if (Validacoes.ValidaCPF(txtCodigoConsumo.Text))
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("adc_produto_conta", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("produto", cmbProdutos.SelectedItem);
                cmd.Parameters.AddWithValue("cpf", txtCodigoConsumo.Text);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                MessageBox.Show("Adicionado com sucesso");
                conexao.Close();
            }
            else
            {
                MessageBox.Show("Verifique o codigo digitado", "House Hotel");
            }
        }

        private void frmEscolha_MouseMove(object sender, MouseEventArgs e)
        {
            gprMessaCod.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                MessageBox.Show("Por favor, não deixe campos vazios!");
            }
            else
            {
                String nome = "";
                String cpf = "";
                String gastos = "";
                String passaporte = "";
                String cep = "";
                //String cidade = "";

                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                MySqlCommand cmd = new MySqlCommand("call sp_dados_cliente(@nome)", conexao);
                cmd.Parameters.Add(new MySqlParameter("@nome", MySqlDbType.VarChar)).Value = txtPesquisar.Text;
                MySqlDataReader dr;
                conexao.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nome = dr.GetString("nm_cliente");
                    cpf = dr.GetString("cd_cpf");
                    gastos = dr.GetString("vl_gastos");
                    passaporte = dr.GetString("cd_passaporte");
                    cep = dr.GetString("cd_cep");
                    //cidade = dr.GetString("nm_cidade");
                }



                lblCPf.Text = cpf;
                lblNome.Text = nome;
                lblValor.Text = gastos;
                //lblCidadeC.Text = cidade;
                lblCEPC.Text = cep;
                lblPassaporteC.Text = passaporte;
                conexao.Close();
            }
        }

        private void txtCodigoConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomeConsumoProduto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
