using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;


namespace NewTech_HouseHotel
{
    public partial class frmMenu : Form
    {
        int X = 0;
        int Y = 0;
        public frmMenu()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmMenu_MouseDown);
            this.MouseMove += new MouseEventHandler(frmMenu_MouseMove);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void Menu_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblData.Text = dt.ToShortDateString();
            string[] textos = { "Faça reservas de maneira rapida e eficiente!", "Simplifique seu atendimento!", "Evite espera!" };
            var t = new System.Windows.Forms.Timer();
            int i = 0;
            t.Tick += delegate
            {
                label2.Text = textos[i]; 
                if (label2.Text == "Faça reservas de maneira rapida e eficiente!")
                {
                    label2.Location = new Point(341, 626);
                }
                if (label2.Text == "Simplifique seu atendimento!")
                {
                    label2.Location = new Point(385, 626);
                }
                if (label2.Text == "Evite espera!")
                {
                    label2.Location = new Point(428, 626);
                }
                Application.DoEvents();
                i = (i < textos.Length - 1) ? (i + 1) : 0;
            };
            t.Interval = 2000;
            t.Start();
            // -------------------------------------------------|


            //  PEGANDO HORA DO CHECK OUT
            //MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
            //DateTime checkout = DateTime.Now;
            //String MySql = "";
            //String dt2 = "";
            //DateTime datahoje = DateTime.Now;
            //dt2 = dt.ToShortDateString();
            //dt2 = DateTime.Now.ToString("dd/MM/yyyy");
            //MySql = "select dt_check_out from tb_reserva where dt_check_out = " + dt2;
            //MySqlCommand comandoSelect = new MySqlCommand(MySql, conexao);
            //MySqlDataReader dr;
            //conexao.Open();
            //dr = comandoSelect.ExecuteReader();
            //while (dr.Read())
            //{
            //    checkout = dr.GetDateTime("dt_check_out");
            //}
            //conexao.Close();

            //dr.Close();
            String dt2 = "";
            String dia2 = "";
            dt2 = dt.ToShortDateString();
            DateTime hora = DateTime.Now;
            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("select dt_check_out from tb_reserva", conecta);
            // MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            //DataTable dt = new DataTable();
            conecta.Open();
            MySqlDataReader leitor = comanda.ExecuteReader();
            while (leitor.Read())
            {
                hora = leitor.GetDateTime("dt_check_out");
            }
            conecta.Close();
            dia2 = hora.ToShortDateString();
            if (dia2 == dt2)
            {
                
                btnNotificacao.Visible = true;
                lblNotifi.Visible = true;
                btnNotificacao.Image = Image.FromFile(@"C:\Users\caio henrique\Pictures\imagens\notiverde.png");
            }
            //----------------------------------------------------------------------------------------------------|+
            string[] textos1 = { "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "", "Existe reserva pendente", "Existe reserva pendente", "", "Existe reserva pendente", "" };
            var d = new System.Windows.Forms.Timer();
            int c = 0;
            d.Tick += delegate
            {
                lblNotifi.Text = textos1[c];
                Application.DoEvents();
                c = (c < textos.Length - 1) ? (c + 1) : 0;
            };
            d.Interval = 400;
            d.Start();
        }

        private void btnReserva_MouseHover(object sender, EventArgs e)
        {

            lblReserva.Visible = true;
        }

        private void btnReserva_MouseLeave(object sender, EventArgs e)
        {

            lblReserva.Visible = false;
        }

        private void btnQuartos_MouseHover(object sender, EventArgs e)
        {

            lblQuartos.Visible = true;
        }

        private void btnQuartos_MouseLeave(object sender, EventArgs e)
        {
            lblQuartos.Visible = false;
        }

        private void btnCardapio_MouseHover(object sender, EventArgs e)
        {
            lblCardapio.Visible = true;
        }

        private void btnCardapio_MouseLeave(object sender, EventArgs e)
        {
            lblCardapio.Visible = false;
        }

        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            lblCliente.Visible = true;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            lblCliente.Visible = false;
        }

        private void btnFuncionarios_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnReserva_Click_1(object sender, EventArgs e)
        {
            frmReserva res = new frmReserva();
            res.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(res);
            res.Show();
            btnReserva.BackColor = Color.Crimson;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblReserva.Visible = true;
            lblV.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuartos_Click(object sender, EventArgs e)
        {

        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            frmVisualizarQuarto quart = new frmVisualizarQuarto();
            quart.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(quart);
            quart.Show();
            btnQuartos.BackColor = Color.Crimson;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblQuartos.Visible = true;
            lblReserva.Visible = false;

        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            frmCardapio card = new frmCardapio();
            card.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(card);
            card.Show();
            btnCardapio.BackColor = Color.Crimson;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblCardapio.Visible = true;
            lblQuartos.Visible = false;
        }

        private void lblReserva_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmRegistroFunc func = new frmRegistroFunc();
            func.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(func);
            func.Show();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            frmEscolha esc = new frmEscolha();
            esc.TopLevel = false;

            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(esc);
            esc.Show();
            btnClientes.BackColor = Color.Crimson;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblCliente.Visible = true;
            lblCardapio.Visible = false;
        }

        private void btnClientes_MouseHover_1(object sender, EventArgs e)
        {
            lblCliente.Visible = true;
        }

        private void btnClientes_MouseLeave_1(object sender, EventArgs e)
        {
            lblCliente.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarFunc_Click(object sender, EventArgs e)
        {
            frmRegistroFunc func = new frmRegistroFunc();
            func.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(func);
            func.Show();
            btnRegistrarFunc.BackColor = Color.Crimson;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblR.Visible = true;
        }

        private void btnRegistrarFunc_MouseHover(object sender, EventArgs e)
        {
            lblR.Visible = true;
        }

        private void btnRegistrarFunc_MouseLeave(object sender, EventArgs e)
        {
            lblR.Visible = false;
        }

        private void btnVisualizarFunc_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(func);
            func.Show();
            btnVisualizarFunc.BackColor = Color.Crimson;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblV.Visible = true;
            lblR.Visible = false;
        }

        private void lblV_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente fechar o House Hotel?","House Hotel", MessageBoxButtons.OKCancel,MessageBoxIcon.Information );
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblLogin.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnVisualizarFunc_MouseHover(object sender, EventArgs e)
        {
            lblV.Visible = true;
        }

        private void btnVisualizarFunc_MouseLeave(object sender, EventArgs e)
        {
            lblV.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharConta_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnFecharConta_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnRegistrarFunc_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void lblV_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            
            btnNotificacao.Image = Image.FromFile(@"C:\Users\caio henrique\Pictures\imagens\notif.png");
            lblNotifi.Visible = false;
            Finalizar_Conta fim = new Finalizar_Conta();
            fim.TopLevel = false;
            this.pnlMenu.Controls.Clear();
            this.pnlMenu.Controls.Add(fim);
            fim.Show();
            btnClientes.BackColor = Color.Transparent;
            btnVisualizarFunc.BackColor = Color.Transparent;
            btnRegistrarFunc.BackColor = Color.Transparent;
            btnReserva.BackColor = Color.Transparent;
            btnQuartos.BackColor = Color.Transparent;
            btnCardapio.BackColor = Color.Transparent;
            btnSair.BackColor = Color.Transparent;
            lblCliente.Visible = false;
            lblCardapio.Visible = false;
        }

        private void trmNot_Tick(object sender, EventArgs e)
        {

        }
    }
}
