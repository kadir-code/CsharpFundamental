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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnSecondForm_Click(object sender, EventArgs e)
        {
            //form2ye gönderilecek değerler parametreye yazılıyor
            Form2 form2 = new Form2(txtUserName.Text,lblEarnedChips.Text);
            this.Enabled = false;
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btnSecondForm.Enabled = false;
            btnSave.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = txtUserName.Text.Length > 0;
        }
        //m1
        public void RandomChips(Label label)
        {
            Random random = new Random();
            string value=label.Text = $"{(random.Next(1000, 2000))}";
        }
        private void btnChips_Click(object sender, EventArgs e)
        {
            RandomChips(lblEarnedChips);
            btnSecondForm.Enabled = true;
        }

    }
}
