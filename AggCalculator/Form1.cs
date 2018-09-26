using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Filter supaya progran tidak error apabila di input ""
            int a = 0;
            var b = 0;
            if (txtNilaiA.Text == "")
            {
                a = 0;
            }
            else {
                a = int.Parse(txtNilaiA.Text);
            }
            if (txtNilaiB.Text == "")
            {
                b = 0;
            }
            else
            {
                b = Convert.ToInt32(txtNilaiB.Text);
            }
            //

            // filter supaya apabila belum di set operasi maka muncul pilih operasi.
            txtHasil.Clear();
            if (comboOperation.Text == "Penambahan")
            {
                txtHasil.Text = Convert.ToString(Penambahan(a, b));
            }
            else if (comboOperation.Text == "Pengurangan")
            {
                txtHasil.Text = Convert.ToString(Pengurangan(a, b));
            }
            else if (comboOperation.Text == "Perkalian")
            {
                txtHasil.Text = Convert.ToString(Perkalian(a, b));
            }
            else if (comboOperation.Text == "Pembagian")
            {
                txtHasil.Text = Convert.ToString(Pembagian(a, b));
            }
            else {
                txtHasil.Text = "maaf belum pilih operasi...";
            }
        }
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
