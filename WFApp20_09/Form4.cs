using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp20_09
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

    

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "printer09DataSet.Potrebitel". При необходимости она может быть перемещена или удалена.
            this.potrebitelTableAdapter.Fill(this.printer09DataSet.Potrebitel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "printer09DataSet.Printer". При необходимости она может быть перемещена или удалена.
            this.printerTableAdapter.Fill(this.printer09DataSet.Printer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "printer09DataSet.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.printer09DataSet.Proizvoditel);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.EndEdit();
            proizvoditelTableAdapter.Update(printer09DataSet);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            proizvoditelPrinterBindingSource.EndEdit();
            printerTableAdapter.Update(printer09DataSet);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
