using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileStream = System.FileStream;

namespace WFApp20_09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.textDescription.AppendText("Дополнительно:" + textBox1.Text);

            ab.ShowDialog();
            ab.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();

            ab.ShowDialog();
            ab.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;

        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
               
                StreamWriter sw = new StreamWriter(fs);
             
                sw.WriteLine(textBox1.Text);
                
                sw.Close();
                fs.Close();
            }

        }

        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
             
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open,
                FileAccess.Read);
                
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = sr.ReadToEnd();
            
                sr.Close();
                fs.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // обработчик события печати
            printDocument1.PrintPage += PrintPageHandler;
            printPreviewDialog1.Document = printDocument1;
            // если в диалоге было нажато ОК
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printPreviewDialog1.Document.Print(); // печатаем
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, Font, Brushes.Black, 20, 20);
        }


    }
}
