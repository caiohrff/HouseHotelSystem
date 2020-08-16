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
    public partial class frmVisualizarQuarto : Form
    {
        int i = 0;
        int f = 0;
        string quarto = "";
        int numeroquarto = 0;
        public frmVisualizarQuarto()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }


        private void btnRetornarQuarto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_quarto, nm_categoria, ds_situacao, ds_quarto, ds_disponibilidade FROM tb_quarto WHERE nm_quarto='Tiamate'", conexao);

            MySqlDataReader dr;

            conexao.Open();

            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                Disponibilidade = dr.GetString(4);
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            if (Disponibilidade == "Disponivel")
            {
                lblDisp.ForeColor = Color.Green;
                lblDisp.Text = Disponibilidade;
            }
            else if (Disponibilidade == "Ocupado")
            {
                lblDisp.ForeColor = Color.Red;
                lblDisp.Text = Disponibilidade;
            }

            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_quarto, nm_categoria, ds_situacao, ds_quarto, ds_disponibilidade FROM tb_quarto WHERE nm_quarto='Quarto 02'", conexao);

            MySqlDataReader dr;

            conexao.Open();

            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                Disponibilidade = dr.GetString(4);
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            if (Disponibilidade == "Disponivel")
            {
                lblDisp.ForeColor = Color.Green;
                lblDisp.Text = Disponibilidade;
            }
            else if (Disponibilidade == "Ocupado")
            {
                lblDisp.ForeColor = Color.Red;
                lblDisp.Text = Disponibilidade;
            }

            conexao.Close();
        }

        private void btnQuarto3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_quarto, nm_categoria, ds_situacao, ds_quarto, ds_disponibilidade FROM tb_quarto WHERE nm_quarto='Quarto 03'", conexao);

            MySqlDataReader dr;

            conexao.Open();

            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                Disponibilidade = dr.GetString(4);
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            if (Disponibilidade == "Disponivel")
            {
                lblDisp.ForeColor = Color.Green;
                lblDisp.Text = Disponibilidade;
            }
            else if (Disponibilidade == "Ocupado")
            {
                lblDisp.ForeColor = Color.Red;
                lblDisp.Text = Disponibilidade;
            }

            conexao.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_quarto, nm_categoria, ds_situacao, ds_quarto, ds_disponibilidade FROM tb_quarto WHERE nm_quarto='Quarto 04'", conexao);

            MySqlDataReader dr;

            conexao.Open();

            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                Disponibilidade = dr.GetString(4);
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            if (Disponibilidade == "Disponivel")
            {
                lblDisp.ForeColor = Color.Green;
                lblDisp.Text = Disponibilidade;
            }
            else if (Disponibilidade == "Ocupado")
            {
                lblDisp.ForeColor = Color.Red;
                lblDisp.Text = Disponibilidade;
            }

            conexao.Close();
        }

        private void btnQuarto5_Click(object sender, EventArgs e)
        {
            lblQuarto.Text = "";
            lblCat.Text = "";
            lblSit.Text = "";
            lblDesc.Text = "";
            lblDisp.Text = "";
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_quarto, nm_categoria, ds_situacao, ds_quarto, ds_disponibilidade FROM tb_quarto WHERE nm_quarto='Quarto 05'", conexao);

            MySqlDataReader dr;

            conexao.Open();

            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                Disponibilidade = dr.GetString(4);
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            if (Disponibilidade == "Disponivel")
            {
                lblDisp.ForeColor = Color.Green;
                lblDisp.Text = Disponibilidade;
            }
            else if (Disponibilidade == "Ocupado")
            {
                lblDisp.ForeColor = Color.Red;
                lblDisp.Text = Disponibilidade;
            }

            conexao.Close();
        }

        private void frmVisualizarQuarto_Load(object sender, EventArgs e)
        {
            txtDeleteQuarto.GotFocus += new EventHandler(this.TextGotFocus);
            txtDeleteQuarto.LostFocus += new EventHandler(this.TextLostFocus);

            int linha = 0;

            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            MySqlCommand comando = new MySqlCommand("call pp_quarto()", conexao);
            MySqlDataReader reader;
            conexao.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                linha = reader.GetInt32(0);
            }
            conexao.Close();
            for (int i = 0; i < linha; i++)
            {
                var botao = new Button();
                botao.Name = "Quarto" + ++f;
                botao.FlatAppearance.BorderSize = 0;
                botao.FlatAppearance.MouseDownBackColor = Color.Transparent;
                botao.FlatAppearance.MouseOverBackColor = Color.Transparent;
                botao.Cursor = System.Windows.Forms.Cursors.Hand;
                botao.BackColor = Color.Transparent;
                botao.FlatStyle = FlatStyle.Flat;
                botao.Size = new System.Drawing.Size(75, 48);
                quarto = botao.Name.ToString();
                quarto = quarto.ToLower();
                quarto = quarto.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "").Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "").Replace(",", "").Replace(".", "").Replace(" ", "").Replace(":", "");
                numeroquarto = int.Parse(quarto);
                botao.Click += new EventHandler(selectquarto);
                botao.Text = botao.Name.ToString();
                botao.ForeColor = Color.Black;
                quarto = botao.Name;
                botao.Image = Image.FromFile(@"C:\Users\caio henrique\Pictures\imagens\porta.png");
                flowLayoutPanel1.Controls.Add(botao);
            }
        }

        

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o nome do quarto aqui...")
            {
                tb.Text = "";
                tb.ForeColor = Color.Gray;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Digite o nome do quarto aqui...")
            {
                tb.Text = "Digite o nome do quarto aqui...";
                tb.ForeColor = Color.Gray;
            }

        }
        private void selectquarto(object sender, EventArgs e)
        {
            quarto = sender.ToString();
            quarto = quarto.ToLower();
            quarto = quarto.Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "").Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("u", "").Replace("v", "").Replace("w", "").Replace("x", "").Replace("y", "").Replace("z", "").Replace(",", "").Replace(".", "").Replace(" ", "").Replace(":", "");
            numeroquarto = int.Parse(quarto);
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String Quarto = "";
            String Categoria = "";
            String Situacao = "";
            String Descricao = "";
            String Disponibilidade = "";
            String nome = "";
            String qtd = "";
            MySqlCommand comando = new MySqlCommand("select tb_quarto.nm_quarto, tb_quarto.nm_categoria, tb_quarto.ds_situacao, tb_quarto.ds_quarto, tb_quarto.ds_disponibilidade, tb_cliente.nm_cliente, tb_reserva.qt_hospede from tb_quarto inner join tb_cliente on tb_quarto.cd_cpf_cliente = tb_cliente.cd_cpf inner join tb_reserva  on tb_quarto.cd_reserva = tb_reserva.cd_reserva where cd_quarto = " + numeroquarto, conexao);
            MySqlDataReader dr;
            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                Quarto = dr.GetString(0);
                Categoria = dr.GetString(1);
                Situacao = dr.GetString(2);
                Descricao = dr.GetString(3);
                nome = dr.GetString("nm_cliente");
                Disponibilidade = dr.GetString("ds_disponibilidade");
                qtd = dr.GetString("qt_hospede");
            }

            lblQuarto.Text = Quarto;
            lblCat.Text = Categoria;
            lblSit.Text = Situacao;
            lblDesc.Text = Descricao;
            lblHospede.Text = nome;
            lblQtd.Text = qtd + " pessoas";
            lblDisp.Text = Disponibilidade;

           if(lblDisp.Text == "Ocupado")
            {
                lblDisp.ForeColor = Color.OrangeRed;
            }

            //if (Disponibilidade != "Disponibilidade" )
            //{
            //    lblDisp.ForeColor = Color.Green;
            //    lblDisp.Text = Disponibilidade;
            //}
            //else if (Disponibilidade == "Disponibilidade")
            //{
            //    lblDisp.ForeColor = Color.Red;
            //    lblDisp.Text = "Ocupado";
            //}

            conexao.Close();
        }

        private void grpInfoQuarto_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeQuarto_Click(object sender, EventArgs e)
        {

        }

        private void lblQuarto_Click(object sender, EventArgs e)
        {

        }
        
        private void lblDisponibilidade_Click(object sender, EventArgs e)
        {

        }


        private void btnAddQuarto_Click(object sender, EventArgs e)
        {
            RegistrarQuarto reg = new RegistrarQuarto();
            reg.Show();
            var botao = new Button();
            botao.Name = "Quarto" + ++f;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botao.Cursor = System.Windows.Forms.Cursors.Hand;
            botao.BackColor = Color.Transparent;
            botao.FlatStyle = FlatStyle.Flat;
            botao.Size = new System.Drawing.Size(75, 48);
            botao.Image = Image.FromFile(@"C:\Users\caio henrique\Pictures\imagens\porta.png");
            flowLayoutPanel1.Controls.Add(botao);
        }

        private void btnDeletQuarto_Click(object sender, EventArgs e)
        {
            if (txtDeleteQuarto.Text == "")
            {
                MessageBox.Show("Por favor, digite um nome antes.");
            }
            else
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                conexao.Open();
                MySqlCommand pag = new MySqlCommand("call  ht_deleta_quarto(@nomequarto)", conexao);
                pag.Parameters.Add(new MySqlParameter("@nomequarto", MySqlDbType.VarChar)).Value = txtDeleteQuarto.Text;
                MySqlDataReader reader;
                reader = pag.ExecuteReader();
                MessageBox.Show("Quarto excluido com sucesso!");
                txtDeleteQuarto.Clear();
                conexao.Close();
            }
            
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ops, estamos trabalhando nisso!   :(");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtDeleteQuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeleteQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
