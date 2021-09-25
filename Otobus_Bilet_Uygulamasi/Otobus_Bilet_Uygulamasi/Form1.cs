using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Bilet_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SeatButtonCreater()
        {

            int sayac = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(40 * j, 40 * (i + 1));
                    button.Text = sayac.ToString();
                    button.BackColor = Color.LightGreen;

                    if (j == 2)
                    {
                        button.Left += 40;
                        sayac--;
                    }
                    sayac++;

                    grpSeats.Controls.Add(button);
                    button.Click += new EventHandler(button_click);


                }

            }
        }

        private void EnableButtons(TextBox textBox)
        {

            btnAvailableSeat.Enabled = textBox.Text.Length > 10;

        }

        private void PNumberMasking(TextBox textBox)
        {

            string value = textBox.Text;
            txtPhoneNumber.MaxLength = 10;
            if (value.Length == 10)
            {
                double newValue = double.Parse(value);
                textBox.Text = string.Format("{0:0(###)-###-##-##}", newValue);
            }

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

            string tboxTC = txtTC.Text;
            txtTC.MaxLength = 11;
            EnableButtons(txtTC);

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            PNumberMasking(txtPhoneNumber);

        }


        private void btnAvailableSeat_Click(object sender, EventArgs e)
        {

            grpSeats.Visible = true;
            btnCreateTicket.Visible = true;
            SeatButtonCreater();

        }

        private void button_click(object sender, EventArgs e)
        {
            Button newButton = (Button)sender;

            if (radioButton1.Checked)
            {
                newButton.BackColor = Color.LightPink;
            }
            else
            {
                newButton.BackColor = Color.Aqua;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpPayment.Visible = false;
            grpSeats.Visible = false;
            btnCreateTicket.Visible = false;
            btnAvailableSeat.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpPayment.Visible = true;
            lblPerson.Text = txtFullName.Text;
            lblPhoneNumber.Text = txtPhoneNumber.Text;
            //lblSeatNo.Text = button.Text;
        }


        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"
                                Full Name :     {txtFullName.Text}
                                Phone Number :  {txtPhoneNumber.Text}
                                Seat No :       - -
                                ");
        }

        private void grpSeats_Enter(object sender, EventArgs e)
        {

        }
    }
}
