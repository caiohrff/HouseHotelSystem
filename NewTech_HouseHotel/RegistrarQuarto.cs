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
    public partial class RegistrarQuarto : Form
    {
        public RegistrarQuarto()
        {
            InitializeComponent();
            lblMsg12.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hhbeta");
            String quartoBanco = "";
            String MySql = "";
            MySql = "SELECT nm_quarto FROM tb_quarto WHERE nm_quarto=@Quarto";
            MySqlCommand comandoSelect = new MySqlCommand(MySql, conexao);
            comandoSelect.Parameters.Add(new MySqlParameter("@Quarto", MySqlDbType.VarChar)).Value = txtNomeQuarto.Text;
            MySqlDataReader dr;
            conexao.Open();
            dr = comandoSelect.ExecuteReader();
            while (dr.Read())
            {
                quartoBanco = dr.GetString(0);
            }
            if (quartoBanco == txtNomeQuarto.Text)
            {
                grpMsg12.Visible = true;
                lblMsg12.Visible = true;
                lblMsg12.Text = "Este funcionário já foi cadastrado.";
                lblMsg12.ForeColor = Color.Orange;
            }
            conexao.Close();
        }

        private void btnRetornarRegistroQuarto_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarQuarto_Load(object sender, EventArgs e)
        {
            
    }



        private void btnCancelarQ_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVisualizarQuarto>().Count() > 0)
            {
                Form quarto = Application.OpenForms["frmVisualizarQuarto"];
                quarto.Show();
                this.Hide();

            }
            else
            {
                frmVisualizarQuarto quarto = new frmVisualizarQuarto();
                quarto.Show();
                this.Hide();
            }
        }

        private void RegistrarQuarto_MouseLeave(object sender, EventArgs e)
        {
            grpMsg12.Visible = false;
            lblMsg12.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            int numero;
            MySqlConnection con = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            MySqlCommand comando = new MySqlCommand("call pp_quarto()", con);
            MySqlDataReader reader;
            con.Open();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                linha = reader.GetInt32(0);
            }
            con.Close();
            numero = linha + 1;
            if (txtDesc.Text == "" && txtNomeQuarto.Text == "" && txtSituacao.Text == "" && cmbCategoria.SelectedItem == null)
            {
                grpMsg12.Visible = true;
                lblMsg12.Visible = true;
                lblMsg12.Text = "Verifique os campos";
                lblMsg12.ForeColor = Color.Orange;
            }
            else
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("ht_cria_quarto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codquarto",null);
                cmd.Parameters.AddWithValue("nomequarto", txtNomeQuarto.Text);
                cmd.Parameters.AddWithValue("descricaoQuarto", txtDesc.Text);
                cmd.Parameters.AddWithValue("situacao", txtSituacao.Text);
                cmd.Parameters.AddWithValue("categoria", cmbCategoria.SelectedItem);
                cmd.Parameters.AddWithValue("disponibilidade", "Disponivel");
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                    {
                        if (dr.GetString(0) == "funfo")
                        {
                            MessageBox.Show("Quarto inserido com sucesso!", "House Hotel",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Verifique se o nome não existe", "House Hotel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtNomeQuarto.Clear();
                            txtDesc.Clear();
                            txtSituacao.Clear();
                            cmbCategoria.ResetText();
                        }
                    }
                }
                conexao.Close();
            }
        }

        private void cmbDispo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNomeQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
        }

        private void txtSituacao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
