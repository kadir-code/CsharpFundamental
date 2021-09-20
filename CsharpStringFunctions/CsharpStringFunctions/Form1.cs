using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStringFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //upper all latters
            string value = txtDataEnter.Text;
            MessageBox.Show(value.ToUpper());
            txtDataEnter.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //lower all letters
            string value = txtDataEnter.Text;
            MessageBox.Show(value.ToLower());
            txtDataEnter.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            //hello=-1
            //hello world=0
            //hello worldxxx=1
            string value = txtDataEnter.Text;

            var result1 = string.Compare(value, "hello world");
            MessageBox.Show(result1.ToString());
            txtDataEnter.Clear();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //if value is before f=1
            //if value is equal to f=0
            //if value is after f=-1

            string value = txtDataEnter.Text;

            var result1 = string.Compare(value, "f");
            MessageBox.Show(result1.ToString());
            txtDataEnter.Clear();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //string concatinating
            string value = txtDataEnter.Text;
            string value2 = "lor4m ip5um";

            string result = string.Concat(value, value2);
            MessageBox.Show(result);
            txtDataEnter.Clear();


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //check if the entered string contains or not
            string lorem = "lorem ipsum dolor sit amet";
            string value = txtDataEnter.Text;

            bool result = lorem.Contains(value);
            MessageBox.Show(result.ToString());
            txtDataEnter.Clear();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string value = "hello world";
            string value2 = txtDataEnter.Text;

            bool result = value.EndsWith(value2);
            MessageBox.Show(result.ToString());
            txtDataEnter.Clear();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string value = "hello world";
            string value2 = txtDataEnter.Text;

            bool result = value.StartsWith(value2);
            MessageBox.Show(result.ToString());
            txtDataEnter.Clear();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string value = "hello world";
            string value2 = txtDataEnter.Text;

            bool result = string.Equals(value,value2);
            MessageBox.Show(result.ToString());
            txtDataEnter.Clear();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //used with while loop
            string value = txtDataEnter.Text;
            CharEnumerator charEnumerator = value.GetEnumerator();
            while (charEnumerator.MoveNext())
            {
                listBox1.Items.Add(charEnumerator.Current.ToString());
            }
        }
    }
}
