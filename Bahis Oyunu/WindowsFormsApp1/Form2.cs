using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //burada da default bir constructor bırakıyoruz
        public Form2()
        {
            InitializeComponent();
        }
        //form1den alınacak değerler parametre olarak veriliyor
        public Form2(string namelbl, string chiplbl)
        {
            InitializeComponent();
            this.Namelbl = namelbl;
            this.Chiplbl = chiplbl;
        }
        //parametrelerin örnekleri çıkarılıyor
        public string Namelbl { get; set; }
        public string Chiplbl { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            //lblNumber.Visible = false;
            Random random = new Random();
            int value = random.Next(0, 101);
            lblNumber.Text = value.ToString();
            //parametreler değer olarak atanıyor
            lblUserName.Text = Namelbl;
            lblChipAmount.Text = Chiplbl;
            this.MinimumSize = new Size(500, 350);
            this.MaximumSize = new Size(500, 350);
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
             this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtGuessTheNumber.Text) == Convert.ToInt32(lblNumber.Text))
            {
                lblHint.Text = "You Win The Game..!";
            }
            else if (Convert.ToInt32(txtGuessTheNumber.Text) < Convert.ToInt32(lblNumber.Text))
            {
                lblHint.Text = "Guess a bigger number";
            }
            else if (Convert.ToInt32(txtGuessTheNumber.Text) > Convert.ToInt32(lblNumber.Text))
            {
                lblHint.Text = "Guess a lower number";
            }
            else
            {
                lblHint.Text = "You typed something wrong";

            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Enabled = false;
            form1.Show();
        }

        
    }
}
