using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace NewTech_HouseHotel
{
    public partial class Login : Form
    {
        int X = 0;
        int Y = 0;
        public Login()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Login_MouseDown);
            this.MouseMove += new MouseEventHandler(Login_MouseMove);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            String usuarioBanco = "";
            String senhaBanco = "";
            MySqlCommand comando = new MySqlCommand("SELECT nm_login, ds_senha FROM tb_funcionario WHERE nm_login='" + txt_usuario.Text + "' and ds_senha='" + txt_password.Text + "'", conexao);
            comando.Parameters.Add(new MySqlParameter("@Usuario", SqlDbType.VarChar)).Value = txt_usuario.Text;
            comando.Parameters.Add(new MySqlParameter("@Senha", SqlDbType.VarChar)).Value = txt_password.Text;
            MySqlDataReader dr;
            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {

                usuarioBanco = dr.GetString(0);
                senhaBanco = dr.GetString(1);
            }
            conexao.Close();

            if (usuarioBanco.Trim() == txt_usuario.Text.Trim() && senhaBanco.Trim() == txt_password.Text.Trim() && txt_usuario.Text.Trim() != "" && txt_password.Text.Trim() != "")
            {

                if (Application.OpenForms.OfType<frmMenu>().Count() > 0)
                {
                    Form principal = Application.OpenForms["frmMenu"];
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    frmMenu principal = new frmMenu();
                    principal.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Verfique se o usuario ou senha estão corretos", "Atenção");
                txt_password.Clear();
            }
            txt_password.Clear();
            MessageBox.Show("Bem vindo ao House Hotel", "House Hotel");
        }

        private void lnk_new_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<frmRegistroFunc>().Count() > 0)
            {
                Form registro = Application.OpenForms["frmRegistroFunc"];
                registro.Show();
                this.Hide();
            }
            else
            {
                frmRegistroFunc registro = new frmRegistroFunc();
                registro.Show();
                this.Hide();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
