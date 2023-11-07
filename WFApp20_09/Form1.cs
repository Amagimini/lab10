using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WFApp18_09;
using WFApp20_09;
namespace WFApp20_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            f2.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
          
            f3.textBox1.AppendText("Название:" + textBox1.Text);
            f3.textBox1.AppendText("\r\nСерийный номер:" + textBox2.Text);
            f3.textBox1.AppendText("\r\nНаличие цветной печати:" + checkBox1.Text);
            f3.textBox1.AppendText("\r\nКатридж:" + comboBox1.Text); 
            f3.textBox1.AppendText("\r\nДата:" + dateTimePicker1.Text);
            f3.textBox1.AppendText("\r\nКоличество:" + numericUpDown1.Text);

            f3.ShowDialog();
            f3.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
           
            ab.ShowDialog();
            ab.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();

            F4.ShowDialog();
            
        }
    }
}
