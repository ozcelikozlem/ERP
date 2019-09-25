namespace ERP
{
    partial class Calisanlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanIbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanfirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaCalisanlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet5 = new ERP.ERPDataSet5();
            this.firmaCalisanlariTableAdapter = new ERP.ERPDataSet5TableAdapters.FirmaCalisanlariTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaCalisanlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Iban :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(199, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisanSoyadDataGridViewTextBoxColumn,
            this.calisanAdDataGridViewTextBoxColumn,
            this.calisanMailDataGridViewTextBoxColumn,
            this.calisanIbanDataGridViewTextBoxColumn,
            this.calisanfirmaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmaCalisanlariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(438, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 208);
            this.dataGridView1.TabIndex = 9;
            // 
            // calisanSoyadDataGridViewTextBoxColumn
            // 
            this.calisanSoyadDataGridViewTextBoxColumn.DataPropertyName = "CalisanSoyad";
            this.calisanSoyadDataGridViewTextBoxColumn.HeaderText = "CalisanSoyad";
            this.calisanSoyadDataGridViewTextBoxColumn.Name = "calisanSoyadDataGridViewTextBoxColumn";
            // 
            // calisanAdDataGridViewTextBoxColumn
            // 
            this.calisanAdDataGridViewTextBoxColumn.DataPropertyName = "CalisanAd";
            this.calisanAdDataGridViewTextBoxColumn.HeaderText = "CalisanAd";
            this.calisanAdDataGridViewTextBoxColumn.Name = "calisanAdDataGridViewTextBoxColumn";
            // 
            // calisanMailDataGridViewTextBoxColumn
            // 
            this.calisanMailDataGridViewTextBoxColumn.DataPropertyName = "CalisanMail";
            this.calisanMailDataGridViewTextBoxColumn.HeaderText = "CalisanMail";
            this.calisanMailDataGridViewTextBoxColumn.Name = "calisanMailDataGridViewTextBoxColumn";
            // 
            // calisanIbanDataGridViewTextBoxColumn
            // 
            this.calisanIbanDataGridViewTextBoxColumn.DataPropertyName = "CalisanIban";
            this.calisanIbanDataGridViewTextBoxColumn.HeaderText = "CalisanIban";
            this.calisanIbanDataGridViewTextBoxColumn.Name = "calisanIbanDataGridViewTextBoxColumn";
            // 
            // calisanfirmaDataGridViewTextBoxColumn
            // 
            this.calisanfirmaDataGridViewTextBoxColumn.DataPropertyName = "calisanfirma";
            this.calisanfirmaDataGridViewTextBoxColumn.HeaderText = "calisanfirma";
            this.calisanfirmaDataGridViewTextBoxColumn.Name = "calisanfirmaDataGridViewTextBoxColumn";
            // 
            // firmaCalisanlariBindingSource
            // 
            this.firmaCalisanlariBindingSource.DataMember = "FirmaCalisanlari";
            this.firmaCalisanlariBindingSource.DataSource = this.eRPDataSet5;
            // 
            // eRPDataSet5
            // 
            this.eRPDataSet5.DataSetName = "ERPDataSet5";
            this.eRPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaCalisanlariTableAdapter
            // 
            this.firmaCalisanlariTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(503, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 11;
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 470);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calisanlar";
            this.Text = "Calisanlar";
            this.Load += new System.EventHandler(this.Calisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaCalisanlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ERPDataSet5 eRPDataSet5;
        private System.Windows.Forms.BindingSource firmaCalisanlariBindingSource;
        private ERPDataSet5TableAdapters.FirmaCalisanlariTableAdapter firmaCalisanlariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanIbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanfirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
    }
}