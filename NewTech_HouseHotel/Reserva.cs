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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }


        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomeReserva_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCPFReserva_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDataCheckIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDataCheckOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDataReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornarReserva_Click(object sender, EventArgs e)
        {

        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            MySqlConnection conecta = new MySqlConnection("server=localhost;user id=root;password=root;database=db_hotel_att2");
            MySqlCommand comanda = new MySqlCommand("select cd_quarto from tb_quarto where cd_cpf_cliente is null order by cd_quarto asc", conecta);
           // MySqlDataAdapter adptAtualizar = new MySqlDataAdapter(comanda);
            //DataTable dt = new DataTable();
            conecta.Open();
            MySqlDataReader leitor = comanda.ExecuteReader();
            while (leitor.Read())
            {
                cmbQuarto.Items.Add(leitor[0]);
            }
            //adptAtualizar.Fill(dt);
            //cmbQuarto.DataSource = dt.DefaultView;
            //cmbQuarto.DisplayMember = "cd_quarto";
            conecta.Close();
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



        private void txtPassaporte_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnConfirmarReserva_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmarReserva1_Click(object sender, EventArgs e)
        {
            if (txtNomeReserva.Text == "" || mskCPF.Text == "" || txt_email.Text == "" || mskDataNascimentoReserva.Text == "" || txtPassaporte.Text == "" || mskTelefoneReserva.Text == "" || txtCidadeReserva.Text == "" || msk_cep.Text == "" || mskDataCheckIn.Text == "" || mskDataCheckOut.Text == "" || mskDataReserva.Text == "" || mskCheckInHora.Text == "" || mskCheckOutHora.Text == "" || txtDiaria.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "House Hotel");
            }
            else
            {
                if (mskDataNascimentoReserva.Text != "" && (mskDataNascimentoReserva.Text.Length < 10))
                {
                    MessageBox.Show("Data de nascimento inválida!", "House Hotel");
                    mskDataNascimentoReserva.Clear();
                    return;
                }
                string dia, mes, ano;
                string aux;
                aux = mskDataNascimentoReserva.Text;
                string[] dias = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" };
                string[] meses = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };

                dia = aux.Substring(0, 2);
                mes = aux.Substring(3, 2);
                ano = aux.Substring(6, 4);

                if (!dias.Contains(dia))
                {
                    MessageBox.Show("Data de nascimento inválida!", "House Hotel");
                    mskDataNascimentoReserva.Clear();
                    return;
                }
                if (!meses.Contains(mes))
                {
                    MessageBox.Show("Data de nascimento inválida!", "House Hotel");
                    mskDataNascimentoReserva.Clear();
                    return;
                }
                if ((dia == "29") && (mes == "02"))
                {
                    if (!(Convert.ToInt32(ano) % 4 == 0) && (Convert.ToInt32(ano) % 100 != 0))
                    {
                        MessageBox.Show("Data de nascimento inválida!", "House Hotel");
                        mskDataNascimentoReserva.Clear();
                        return;
                    }
                }



                string strB = mskCheckOutHora.Text; //Valor para separar
                char[] strSep = { ':' }; //Caracter usado para separar o texto
                string[] strArray = strB.Split(strSep);//Onde ficará o resultado da separação

                this.Text = "";


                if (int.Parse(strArray[0]) > 0 && int.Parse(strArray[0]) < 24)
                {
                    if (int.Parse(strArray[1]) > -1 && int.Parse(strArray[1]) < 60)
                    {
                        Console.WriteLine(strB + "\n");
                        for (int count = 0; count <= strArray.Length - 1; count++)//Mostra os valores existentes no array]
                        {
                            this.Text = this.Text + strArray[count];
                        }

                        string strA = mskCheckInHora.Text; //Valor para separar
                        char[] strSep1 = { ':' }; //Caracter usado para separar o texto
                        string[] strArray1 = strA.Split(strSep1);//Onde ficará o resultado da separação

                        this.Text = "";

                        if (int.Parse(strArray1[0]) > 0 && int.Parse(strArray1[0]) < 24)
                        {
                            if (int.Parse(strArray1[1]) > -1 && int.Parse(strArray1[1]) < 60)
                            {
                                Console.WriteLine(strA + "\n");
                                for (int count = 0; count <= strArray1.Length - 1; count++)//Mostra os valores existentes no array]
                                {
                                    this.Text = this.Text + strArray1[count];
                                }

                                if (Validacoes.ValidaCep(msk_cep.Text) && Validacoes.ValidaCPF(mskCPF.Text) && Validacoes.ValidaEmail(txt_email.Text))
                                {
                                    DateTime dt = DateTime.Now;
                                    MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                                    String usuarioBanco = "";
                                    String MySql = "";
                                    MySql = "SELECT cd_cpf FROM tb_cliente WHERE cd_cpf=@Cpf";
                                    MySqlCommand comandoSelect = new MySqlCommand(MySql, conexao);
                                    comandoSelect.Parameters.Add(new MySqlParameter("@Cpf", MySqlDbType.VarChar)).Value = mskCPF.Text;
                                    MySqlDataReader dr;
                                    conexao.Open();
                                    dr = comandoSelect.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        usuarioBanco = dr.GetString(0);
                                    }
                                    conexao.Close();
                                    dr.Close();
                                    if (usuarioBanco != mskCPF.Text)
                                    {

                                        MySqlConnection cone = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                                        String cep = "";
                                        String MySql2 = "";
                                        MySql2 = "SELECT cd_cep FROM tb_endereco WHERE cd_cep=@Cep";
                                        MySqlCommand comandoSelectCep = new MySqlCommand(MySql2, cone);
                                        comandoSelectCep.Parameters.Add(new MySqlParameter("@Cep", MySqlDbType.VarChar)).Value = msk_cep.Text;
                                        MySqlDataReader derader;
                                        cone.Open();
                                        derader = comandoSelectCep.ExecuteReader();
                                        while (derader.Read())
                                        {
                                            cep = derader.GetString("cd_cep");
                                        }
                                        cone.Close();
                                        derader.Close();
                                        if (cep != msk_cep.Text)
                                        {





                                            // --------------------------------------------------|
                                            MySqlConnection conex = new MySqlConnection(@"server=localhost;user id=root;password=root;persistsecurityinfo=True;database=db_hotel_att2");
                                            String celular = "";
                                            String mysl = "";
                                            mysl = "SELECT cd_cel FROM tb_contato WHERE cd_cel=@Cel";
                                            MySqlCommand comandoSelect4 = new MySqlCommand(mysl, conex);
                                            comandoSelect4.Parameters.Add(new MySqlParameter("@Cel", MySqlDbType.VarChar)).Value = mskCel.Text;
                                            MySqlDataReader der;
                                            conex.Open();
                                            der = comandoSelect4.ExecuteReader();
                                            while (der.Read())
                                            {

                                                celular = der.GetString("cd_cel");
                                            }
                                            conex.Close();
                                            der.Close();
                                            if (celular != mskCel.Text)
                                            {






                                                if (txtNomeReserva.Text != "" || mskCPF.Text != "" || txt_email.Text != "" || mskDataNascimentoReserva.Text != "" || txtPassaporte.Text != "" || mskTelefoneReserva.Text != "" || txtCidadeReserva.Text != "" || msk_cep.Text != "" || mskDataCheckIn.Text != "" || mskDataCheckOut.Text != "" || mskDataReserva.Text != "" || mskCheckInHora.Text != "" || mskCheckOutHora.Text != "" || txtDiaria.Text != "")
                                                {
                                                    if (Validacoes.ValidaCep(msk_cep.Text) && Validacoes.ValidaCPF(mskCPF.Text) && Validacoes.ValidaEmail(txt_email.Text))
                                                    {
                                                        //if (usuarioBanco.Trim() != txtNomeReserva.Text.Trim() && txtNomeReserva.Text.Trim() != "" && mskCPF.Text.Trim() != "" && txt_email.Text.Trim() != "" && mskDataNascimentoReserva.Text.Trim() != "" && txtPassaporte.Text.Trim() != "" && mskTelefoneReserva.Text.Trim() != "" && txtCidadeReserva.Text.Trim() != "" && msk_cep.Text.Trim() != "" && mskDataCheckIn.Text.Trim() != "" && mskDataCheckOut.Text.Trim() != "" && mskDataReserva.Text.Trim() != "" && mskCheckInHora.Text.Trim() != "" && mskCheckOutHora.Text.Trim() != "" && txtDiaria.Text.Trim() != "")
                                                        //{
                                                        string strCon = "Server=localhost;Database=db_hotel_att2;" + "Uid=root;Pwd=root;" + "Use Procedure Bodies=false;";
                                                        MySqlConnection con = new MySqlConnection(strCon);
                                                        con.Open();
                                                        MySqlCommand b = new MySqlCommand("call sp_reserva3 (@cpf,@nome,@nascimento,@passaporte,@nacionalidade,@gastos,@cel,@tel,@email,@cliente,@numero,@endereco,@cep,@cidade,@uf,@bairro,@cod_cliente,@pais,@codigo,@dt_checkin,@dt_checkout,@hr_checkin,@hr_checkout,@hospedes,@obs,@valor,@cpf_cliente, @CodQuarto)", con);
                                                        //MySqlCommand cmd = new MySqlCommand("sp_reserva2", con);
                                                        //cmd.CommandType = CommandType.StoredProcedure;
                                                        //String cres2 = mskCPF.Text;
                                                        DateTime nascimento = DateTime.ParseExact(mskDataNascimentoReserva.Text, "dd/MM/yyyy", null);
                                                        DateTime data_checkin = DateTime.ParseExact(mskDataCheckIn.Text, "dd/MM/yyyy", null);
                                                        DateTime data_checkout = DateTime.ParseExact(mskDataCheckOut.Text, "dd/MM/yyyy", null);
                                                        int resultado = DateTime.Compare(data_checkin, data_checkout);
                                                        int qt = int.Parse(cmbQuarto.SelectedItem.ToString());

                                                        if (resultado < 0)
                                                        {
                                                            if (cmbQuarto.Text == "")
                                                            {
                                                                MessageBox.Show("Não deixe o campo vazio asno");
                                                            }
                                                            else
                                                            {
                                                                DateTime cres1 = DateTime.Now;
                                                                int dia1 = cres1.Day;
                                                                int mes1 = cres1.Month;
                                                                int ano1 = cres1.Year;
                                                                int dia2 = data_checkin.Day;
                                                                int mes2 = data_checkin.Month;
                                                                int ano2 = data_checkin.Year;
                                                                int dia3 = data_checkout.Day;
                                                                int mes3 = data_checkout.Month;
                                                                int ano3 = data_checkout.Year;
                                                                int hin = data_checkin.Hour;
                                                                int min = data_checkin.Minute;
                                                                int hout = data_checkout.Hour;
                                                                int mout = data_checkout.Minute;
                                                                String cres3 = Convert.ToString(cres1);
                                                                cres3 = cres3.Replace("/", "").Replace(":", "").Replace(" ", "");
                                                                String Resv = String.Concat(cres3);
                                                                b.Parameters.AddWithValue("@cpf", mskCPF.Text);
                                                                b.Parameters.AddWithValue("@nome", txtNomeReserva.Text);
                                                                b.Parameters.AddWithValue("@nascimento", nascimento.ToString("yyyy-MM-dd"));
                                                                b.Parameters.AddWithValue("@passaporte", txtPassaporte.Text);
                                                                b.Parameters.AddWithValue("@nacionalidade", txtNacionalidade.Text);
                                                                b.Parameters.AddWithValue("@gastos", txtDiaria.Text);
                                                                b.Parameters.AddWithValue("@cel", mskCel.Text);
                                                                b.Parameters.AddWithValue("@tel", mskTelefoneReserva.Text);
                                                                b.Parameters.AddWithValue("@email", txt_email.Text);
                                                                b.Parameters.AddWithValue("@cliente", mskCPF.Text);
                                                                b.Parameters.AddWithValue("@numero", txtNumero.Text);
                                                                b.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                                                                b.Parameters.AddWithValue("@cep", msk_cep.Text);
                                                                b.Parameters.AddWithValue("@cidade", txtCidadeReserva.Text);
                                                                b.Parameters.AddWithValue("@uf", cmbUF.SelectedItem);
                                                                b.Parameters.AddWithValue("@bairro", txtBairro.Text);
                                                                b.Parameters.AddWithValue("@cod_cliente", mskCPF.Text);
                                                                b.Parameters.AddWithValue("@pais", txtPais.Text);
                                                                b.Parameters.AddWithValue("@codigo", Resv);
                                                                b.Parameters.AddWithValue("@dt_checkin", data_checkin.ToString("yyyy-MM-dd"));
                                                                b.Parameters.AddWithValue("@dt_checkout", data_checkout.ToString("yyyy-MM-dd"));
                                                                b.Parameters.AddWithValue("@hr_checkin", mskCheckInHora.Text);
                                                                b.Parameters.AddWithValue("@hr_checkout", mskCheckOutHora.Text);
                                                                b.Parameters.AddWithValue("@hospedes", cmbQtdHospede.SelectedItem);
                                                                b.Parameters.AddWithValue("@obs", txtObs.Text);
                                                                b.Parameters.AddWithValue("@valor", txtDiaria.Text);
                                                                b.Parameters.AddWithValue("@cpf_cliente", mskCPF.Text);
                                                                b.Parameters.AddWithValue("@CodQuarto", qt);
                                                                int linhasAfetadas = 0;
                                                                linhasAfetadas = b.ExecuteNonQuery();




                                                                if (linhasAfetadas != 0)
                                                                {

                                                                    MessageBox.Show("Reserva efetuada com sucesso!", "House Hotel");
                                                                    txtNomeReserva.Clear();
                                                                    mskCPF.Clear();
                                                                    txt_email.Clear();
                                                                    mskDataNascimentoReserva.Clear();
                                                                    txtPassaporte.Clear();
                                                                    mskTelefoneReserva.Clear();
                                                                    txtCidadeReserva.Clear();
                                                                    msk_cep.Clear();
                                                                    mskDataCheckIn.Clear();
                                                                    mskDataCheckOut.Clear();
                                                                    mskDataReserva.Clear();
                                                                    mskCheckInHora.Clear();
                                                                    mskCheckOutHora.Clear();
                                                                    txtDiaria.Clear();

                                                                }


                                                                con.Close();

                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("As datas do check-in ou check-out são inválidas!", "House Hotel");
                                                        }


                                                    }
                                                    else
                                                    {

                                                        MessageBox.Show("Verifique seus dados!", "House Hotel");
                                                    }

                                                }
                                                else
                                                {

                                                    MessageBox.Show("Preencha todos os campos!", "House Hotel");

                                                }



                                            }
                                            else if (celular == mskCel.Text)
                                            {
                                                MessageBox.Show("Esse celular já está em uso!");
                                            }
                                        }
                                        else //if (cep != msk_cep.Text)
                                        {
                                            MessageBox.Show("Este CEP já está em uso!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Este cliente já foi cadastrado.");
                                    }
                                }

                            }
                            else
                            {

                                MessageBox.Show("Os minutos do check-in são inválidos!", "House Hotel");
                            }
                        }
                        else
                        {
                            MessageBox.Show("As horas do check-in são inválidas!", "House Hotel");
                        }
                        mskCheckInHora.Clear();

                    }
                    else
                    {

                        MessageBox.Show("Os minutos do check-out são inválidos!", "House Hotel");
                    }
                }


                else
                {
                    MessageBox.Show("As horas do check-out são inválidas!", "House Hotel");
                }
                mskCheckOutHora.Clear();

            }




        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNomeReserva_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCidadeReserva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiaria_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbQuarto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qt = int.Parse(cmbQuarto.SelectedItem.ToString());
        }

        private void txtPassaporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso o cliente não tenha passaporte deixe no seguinte formato: AA0000000","House Hotel");
        }
    }
  }
