using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace NewTech_HouseHotel
{
    public partial class frmRegistroFunc : Form
    {

        public frmRegistroFunc()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void btnRegFunc_Click(object sender, EventArgs e)
        {
            if (Validacoes.ValidaCep(msk_cep.Text) && Validacoes.ValidaCPF(msk_cpf.Text) && Validacoes.ValidaEmail(txt_email.Text))
            {
                MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                String usuarioBanco = "";
                String senhaBanco = "";
                String MySql = "";
                MySql = "SELECT nm_funcionario, ds_senha FROM tb_funcionario WHERE nm_funcionario=@Usuario";
                MySqlCommand comandoSelect = new MySqlCommand(MySql, conexao);
                comandoSelect.Parameters.Add(new MySqlParameter("@Usuario", MySqlDbType.VarChar)).Value = txt_nome.Text;
                comandoSelect.Parameters.Add(new MySqlParameter("@Senha", MySqlDbType.VarChar)).Value = txt_senha.Text;
                MySqlDataReader dr;
                conexao.Open();
                dr = comandoSelect.ExecuteReader();
                while (dr.Read())
                {
                    usuarioBanco = dr.GetString(0);
                    senhaBanco = dr.GetString(1);
                }
                if (usuarioBanco == txt_nome.Text)
                {
                    grpMsg.Visible = true;
                    lblMsg.Visible = true;
                    lblMsg.Text = "Este funcionário já foi cadastrado.";
                    lblMsg.ForeColor = Color.Orange;
                }
                conexao.Close();


                if (txt_nome.Text != "" && txt_senha.Text != "" && txt_senha2.Text != "" && txt_email.Text != "" && txt_endereco.Text != "" && txt_cidade.Text != "" && txt_bairro.Text != "" && txt_pais.Text != "")
                {

                    if (txt_senha.Text == txt_senha2.Text)
                    {

                        if (usuarioBanco.Trim() != txt_nome.Text.Trim() && senhaBanco.Trim() != txt_senha.Text.Trim() && txt_nome.Text.Trim() != "" && txt_senha.Text.Trim() != "")
                        {
                            string strCon = "Server=localhost;Database=db_hotel_att2;" + "Uid=root;Pwd=root;" + "Use Procedure Bodies=false;";
                            MySqlConnection con = new MySqlConnection(strCon);
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand("sp_insere_funcionario", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("cpf", msk_cpf.Text);
                            cmd.Parameters.AddWithValue("nome", txt_nome.Text);
                            cmd.Parameters.AddWithValue("login", txtLogin.Text);
                            cmd.Parameters.AddWithValue("senha", txt_senha.Text);
                            cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                            cmd.Parameters.AddWithValue("endereco", txt_endereco.Text);
                            cmd.Parameters.AddWithValue("cep", msk_cep.Text);
                            cmd.Parameters.AddWithValue("cidade", txt_cidade.Text);
                            cmd.Parameters.AddWithValue("uf", txt_uf.Text);
                            cmd.Parameters.AddWithValue("bairro", txt_bairro.Text);
                            cmd.Parameters.AddWithValue("cod_func", msk_cpf.Text);
                            cmd.Parameters.AddWithValue("pais", txt_pais.Text);
                            cmd.Parameters.AddWithValue("cel", msk_tel_outro.Text);
                            cmd.Parameters.AddWithValue("tel", msk_tel_res.Text);
                            cmd.Parameters.AddWithValue("email", txt_email.Text);
                            cmd.Parameters.AddWithValue("obs", txtObs.Text);
                            cmd.Parameters.AddWithValue("cod_func2", msk_cpf.Text);
                            int linhasAfetadas = 0;
                            linhasAfetadas = cmd.ExecuteNonQuery();
                            conexao.Close();


                            if (linhasAfetadas != 0)
                            {

                                grpMsg.Visible = true;
                                lblMsg.Visible = true;
                                lblMsg.Text = "Funcionário registrado com sucesso.";
                                lblMsg.ForeColor = Color.Orange;

                            }

                        }
                    }
                    else
                    {
                        grpMsg.Visible = true;
                        lblMsg.Visible = true;
                        lblMsg.Text = "As senhas devem ser iguais.";
                        lblMsg.ForeColor = Color.Orange;
                    }
                }

                else
                {
                    grpMsg.Visible = true;
                    lblMsg.Visible = true;
                    lblMsg.Text = "Preencha todos os campos.";
                    lblMsg.ForeColor = Color.Orange;
                }

            }
            else
            {
                    grpMsg.Visible = true;
                    lblMsg.Visible = true;
                    lblMsg.Text = "Verifique seus dados!";
                    lblMsg.ForeColor = Color.Orange;
                }

            }

        private void btnRetornarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarQ_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Login>().Count() > 0)
            {
                Form login = Application.OpenForms["Login"];
                login.Show();
                this.Hide();
            }
            else
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void frmRegistroFunc_Load(object sender, EventArgs e)
        {

        }

        private void txt_nome_Click(object sender, EventArgs e)
        {
            grpMsg.Visible = false;
        }

        private void msk_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_endereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_bairro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_pais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_senha2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void msk_cep_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_uf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void msk_tel_res_KeyPress(object sender, KeyPressEventArgs e)
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

        private void msk_tel_outro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
