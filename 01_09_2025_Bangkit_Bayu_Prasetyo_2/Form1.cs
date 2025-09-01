using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_09_2025_Bangkit_Bayu_Prasetyo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat Datang di Aplikasi Konversi Suhu", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numCelcius;
            double numFarenheit;
            double numKelvin;
            double numReamur;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error: Masukkan Nilai Celcius Terlebih Dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!double.TryParse(textBox1.Text , out numCelcius))
            {
                MessageBox.Show("Error: Mohon Masukkan Input yang Valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

            numCelcius = Convert.ToDouble(textBox1.Text);
             if (numCelcius == 0)
            {
                MessageBox.Show("Error: Nilai Celcius Tidak Boleh Sama dengan 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            numFarenheit = (numCelcius * (9 / 5) + 32);
            numKelvin = numCelcius + 273.15;
            numReamur = numCelcius * 4 / 5;

            textBox2.Text = numFarenheit.ToString();
            textBox3.Text = numKelvin.ToString();
            textBox4.Text = numReamur.ToString();

            
        }
    }
}
