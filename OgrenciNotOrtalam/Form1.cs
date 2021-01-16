using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotOrtalam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yazili1, yazili2, sozlu1;
            int ortalama;
            int but;
            yazili1 = Convert.ToInt32(textBox5.Text);
            yazili2 = Convert.ToInt32(textBox6.Text);
            sozlu1 = Convert.ToInt32(textBox7.Text);
            ortalama = (yazili1 + yazili2 + sozlu1) / 3;
            label8.Text = Convert.ToString(ortalama);
            but = 240 - (yazili1 + yazili2 + sozlu1);
            label10.Text = Convert.ToString(but);
            
            if (ortalama >= 60)
            {
                label9.Text = "Geçti.";
            }
            else
            {
                label9.Text = "Kaldı.";
            }

            listBox1.Items.Add (textBox1.Text+" "+textBox2.Text+" - "+comboBox2.Text+" - "+comboBox1.Text+" - "+yazili1+" - "+yazili2+" - "+sozlu1+" - "+ortalama+" - "+label9.Text+" "+"Büt Sınavı Min Puan:"+" "+label10.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
