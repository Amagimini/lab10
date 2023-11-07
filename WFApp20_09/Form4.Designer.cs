using WFApp18_09;

namespace WFApp20_09
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proizvoditelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvoditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printer09DataSet = new WFApp18_09.Printer09DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.potrebitelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvoditelPrinterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.proizvoditelTableAdapter = new WFApp18_09.Printer09DataSetTableAdapters.ProizvoditelTableAdapter();
            this.proizvoditelPrinterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerTableAdapter = new WFApp18_09.Printer09DataSetTableAdapters.PrinterTableAdapter();
            this.potrebitelTableAdapter = new WFApp18_09.Printer09DataSetTableAdapters.PotrebitelTableAdapter();
            this.Proizvoditel_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гарантияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrebitelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printer09DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebitelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelPrinterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelPrinterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proizvoditelIDDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proizvoditelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // proizvoditelIDDataGridViewTextBoxColumn
            // 
            this.proizvoditelIDDataGridViewTextBoxColumn.DataPropertyName = "Proizvoditel_ID";
            this.proizvoditelIDDataGridViewTextBoxColumn.HeaderText = "Proizvoditel_ID";
            this.proizvoditelIDDataGridViewTextBoxColumn.Name = "proizvoditelIDDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // proizvoditelBindingSource
            // 
            this.proizvoditelBindingSource.DataMember = "Proizvoditel";
            this.proizvoditelBindingSource.DataSource = this.printer09DataSet;
            // 
            // printer09DataSet
            // 
            this.printer09DataSet.DataSetName = "Printer09DataSet";
            this.printer09DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proizvoditel_ID,
            this.printerIDDataGridViewTextBoxColumn,
            this.артикулDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.гарантияDataGridViewTextBoxColumn,
            this.potrebitelIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.proizvoditelPrinterBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(547, 146);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // potrebitelBindingSource
            // 
            this.potrebitelBindingSource.DataMember = "Potrebitel";
            this.potrebitelBindingSource.DataSource = this.printer09DataSet;
            // 
            // proizvoditelPrinterBindingSource1
            // 
            this.proizvoditelPrinterBindingSource1.DataMember = "ProizvoditelPrinter";
            this.proizvoditelPrinterBindingSource1.DataSource = this.proizvoditelBindingSource;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(569, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(565, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proizvoditelTableAdapter
            // 
            this.proizvoditelTableAdapter.ClearBeforeFill = true;
            // 
            // proizvoditelPrinterBindingSource
            // 
            this.proizvoditelPrinterBindingSource.DataMember = "ProizvoditelPrinter";
            this.proizvoditelPrinterBindingSource.DataSource = this.proizvoditelBindingSource;
            // 
            // printerTableAdapter
            // 
            this.printerTableAdapter.ClearBeforeFill = true;
            // 
            // potrebitelTableAdapter
            // 
            this.potrebitelTableAdapter.ClearBeforeFill = true;
            // 
            // Proizvoditel_ID
            // 
            this.Proizvoditel_ID.DataPropertyName = "Proizvoditel_ID";
            this.Proizvoditel_ID.HeaderText = "Proizvoditel_ID";
            this.Proizvoditel_ID.Name = "Proizvoditel_ID";
            this.Proizvoditel_ID.Visible = false;
            // 
            // printerIDDataGridViewTextBoxColumn
            // 
            this.printerIDDataGridViewTextBoxColumn.DataPropertyName = "Printer_ID";
            this.printerIDDataGridViewTextBoxColumn.HeaderText = "Printer_ID";
            this.printerIDDataGridViewTextBoxColumn.Name = "printerIDDataGridViewTextBoxColumn";
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // гарантияDataGridViewTextBoxColumn
            // 
            this.гарантияDataGridViewTextBoxColumn.DataPropertyName = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.HeaderText = "Гарантия";
            this.гарантияDataGridViewTextBoxColumn.Name = "гарантияDataGridViewTextBoxColumn";
            // 
            // potrebitelIDDataGridViewTextBoxColumn
            // 
            this.potrebitelIDDataGridViewTextBoxColumn.DataPropertyName = "Potrebitel_ID";
            this.potrebitelIDDataGridViewTextBoxColumn.DataSource = this.potrebitelBindingSource;
            this.potrebitelIDDataGridViewTextBoxColumn.DisplayMember = "Компания";
            this.potrebitelIDDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.potrebitelIDDataGridViewTextBoxColumn.Name = "potrebitelIDDataGridViewTextBoxColumn";
            this.potrebitelIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.potrebitelIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.potrebitelIDDataGridViewTextBoxColumn.ValueMember = "Potrebitel ID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "БД принтер";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printer09DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebitelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelPrinterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelPrinterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Printer09DataSet printer09DataSet;
        private System.Windows.Forms.BindingSource proizvoditelBindingSource;
        private WFApp18_09.Printer09DataSetTableAdapters.ProizvoditelTableAdapter proizvoditelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvoditelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvoditelPrinterBindingSource;
        private WFApp18_09.Printer09DataSetTableAdapters.PrinterTableAdapter printerTableAdapter;
        private System.Windows.Forms.BindingSource potrebitelBindingSource;
        private WFApp18_09.Printer09DataSetTableAdapters.PotrebitelTableAdapter potrebitelTableAdapter;
        private System.Windows.Forms.BindingSource proizvoditelPrinterBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvoditel_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гарантияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn potrebitelIDDataGridViewTextBoxColumn;
    }
}