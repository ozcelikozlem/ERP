namespace ERP
{
    partial class FisFatura
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Kaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaCalisanlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet8 = new ERP.ERPDataSet8();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duzenlenmeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vadeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaAcilamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturafirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet9 = new ERP.ERPDataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Açıklama = new System.Windows.Forms.Label();
            this.firmaCalisanlariTableAdapter = new ERP.ERPDataSet8TableAdapters.FirmaCalisanlariTableAdapter();
            this.faturalarTableAdapter = new ERP.ERPDataSet9TableAdapters.FaturalarTableAdapter();
            this.eRPDataSet19 = new ERP.ERPDataSet19();
            this.fisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fisTableAdapter = new ERP.ERPDataSet19TableAdapters.FisTableAdapter();
            this.fisNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisToplamFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sil = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaCalisanlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet8)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.sil);
            this.tabPage1.Controls.Add(this.Kaydet);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fiş";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(64, 226);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(176, 23);
            this.Kaydet.TabIndex = 5;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fisNoDataGridViewTextBoxColumn,
            this.fisAciklamaDataGridViewTextBoxColumn,
            this.fisToplamFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(395, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // firmaCalisanlariBindingSource
            // 
            this.firmaCalisanlariBindingSource.DataMember = "FirmaCalisanlari";
            this.firmaCalisanlariBindingSource.DataSource = this.eRPDataSet8;
            // 
            // eRPDataSet8
            // 
            this.eRPDataSet8.DataSetName = "ERPDataSet8";
            this.eRPDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Fiyat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açıklama :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Açıklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fatura";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaNoDataGridViewTextBoxColumn,
            this.duzenlenmeTarihiDataGridViewTextBoxColumn,
            this.vadeTarihiDataGridViewTextBoxColumn,
            this.faturaAcilamaDataGridViewTextBoxColumn,
            this.faturaTuruDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.faturafirmaDataGridViewTextBoxColumn,
            this.musteriFirmaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.faturalarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(358, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(420, 204);
            this.dataGridView2.TabIndex = 7;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            this.faturaNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duzenlenmeTarihiDataGridViewTextBoxColumn
            // 
            this.duzenlenmeTarihiDataGridViewTextBoxColumn.DataPropertyName = "DuzenlenmeTarihi";
            this.duzenlenmeTarihiDataGridViewTextBoxColumn.HeaderText = "DuzenlenmeTarihi";
            this.duzenlenmeTarihiDataGridViewTextBoxColumn.Name = "duzenlenmeTarihiDataGridViewTextBoxColumn";
            // 
            // vadeTarihiDataGridViewTextBoxColumn
            // 
            this.vadeTarihiDataGridViewTextBoxColumn.DataPropertyName = "VadeTarihi";
            this.vadeTarihiDataGridViewTextBoxColumn.HeaderText = "VadeTarihi";
            this.vadeTarihiDataGridViewTextBoxColumn.Name = "vadeTarihiDataGridViewTextBoxColumn";
            // 
            // faturaAcilamaDataGridViewTextBoxColumn
            // 
            this.faturaAcilamaDataGridViewTextBoxColumn.DataPropertyName = "FaturaAcilama";
            this.faturaAcilamaDataGridViewTextBoxColumn.HeaderText = "FaturaAcilama";
            this.faturaAcilamaDataGridViewTextBoxColumn.Name = "faturaAcilamaDataGridViewTextBoxColumn";
            // 
            // faturaTuruDataGridViewTextBoxColumn
            // 
            this.faturaTuruDataGridViewTextBoxColumn.DataPropertyName = "FaturaTuru";
            this.faturaTuruDataGridViewTextBoxColumn.HeaderText = "FaturaTuru";
            this.faturaTuruDataGridViewTextBoxColumn.Name = "faturaTuruDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // faturafirmaDataGridViewTextBoxColumn
            // 
            this.faturafirmaDataGridViewTextBoxColumn.DataPropertyName = "faturafirma";
            this.faturafirmaDataGridViewTextBoxColumn.HeaderText = "faturafirma";
            this.faturafirmaDataGridViewTextBoxColumn.Name = "faturafirmaDataGridViewTextBoxColumn";
            // 
            // musteriFirmaDataGridViewTextBoxColumn
            // 
            this.musteriFirmaDataGridViewTextBoxColumn.DataPropertyName = "MusteriFirma";
            this.musteriFirmaDataGridViewTextBoxColumn.HeaderText = "MusteriFirma";
            this.musteriFirmaDataGridViewTextBoxColumn.Name = "musteriFirmaDataGridViewTextBoxColumn";
            // 
            // faturalarBindingSource
            // 
            this.faturalarBindingSource.DataMember = "Faturalar";
            this.faturalarBindingSource.DataSource = this.eRPDataSet9;
            // 
            // eRPDataSet9
            // 
            this.eRPDataSet9.DataSetName = "ERPDataSet9";
            this.eRPDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 160);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fatura Türü :";
            // 
            // Açıklama
            // 
            this.Açıklama.AutoSize = true;
            this.Açıklama.Location = new System.Drawing.Point(64, 64);
            this.Açıklama.Name = "Açıklama";
            this.Açıklama.Size = new System.Drawing.Size(56, 13);
            this.Açıklama.TabIndex = 0;
            this.Açıklama.Text = "Açıklama :";
            // 
            // firmaCalisanlariTableAdapter
            // 
            this.firmaCalisanlariTableAdapter.ClearBeforeFill = true;
            // 
            // faturalarTableAdapter
            // 
            this.faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // eRPDataSet19
            // 
            this.eRPDataSet19.DataSetName = "ERPDataSet19";
            this.eRPDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fisBindingSource
            // 
            this.fisBindingSource.DataMember = "Fis";
            this.fisBindingSource.DataSource = this.eRPDataSet19;
            // 
            // fisTableAdapter
            // 
            this.fisTableAdapter.ClearBeforeFill = true;
            // 
            // fisNoDataGridViewTextBoxColumn
            // 
            this.fisNoDataGridViewTextBoxColumn.DataPropertyName = "FisNo";
            this.fisNoDataGridViewTextBoxColumn.HeaderText = "FisNo";
            this.fisNoDataGridViewTextBoxColumn.Name = "fisNoDataGridViewTextBoxColumn";
            this.fisNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fisAciklamaDataGridViewTextBoxColumn
            // 
            this.fisAciklamaDataGridViewTextBoxColumn.DataPropertyName = "FisAciklama";
            this.fisAciklamaDataGridViewTextBoxColumn.HeaderText = "FisAciklama";
            this.fisAciklamaDataGridViewTextBoxColumn.Name = "fisAciklamaDataGridViewTextBoxColumn";
            // 
            // fisToplamFiyatDataGridViewTextBoxColumn
            // 
            this.fisToplamFiyatDataGridViewTextBoxColumn.DataPropertyName = "FisToplamFiyat";
            this.fisToplamFiyatDataGridViewTextBoxColumn.HeaderText = "FisToplamFiyat";
            this.fisToplamFiyatDataGridViewTextBoxColumn.Name = "fisToplamFiyatDataGridViewTextBoxColumn";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(686, 287);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 6;
            this.sil.Text = "sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(553, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(443, 294);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FisFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "FisFatura";
            this.Text = "FisFatura";
            this.Load += new System.EventHandler(this.FisFatura_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaCalisanlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet8)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Açıklama;
        private ERPDataSet8 eRPDataSet8;
        private System.Windows.Forms.BindingSource firmaCalisanlariBindingSource;
        private ERPDataSet8TableAdapters.FirmaCalisanlariTableAdapter firmaCalisanlariTableAdapter;
        private ERPDataSet9 eRPDataSet9;
        private System.Windows.Forms.BindingSource faturalarBindingSource;
        private ERPDataSet9TableAdapters.FaturalarTableAdapter faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duzenlenmeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vadeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaAcilamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturafirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriFirmaDataGridViewTextBoxColumn;
        private ERPDataSet19 eRPDataSet19;
        private System.Windows.Forms.BindingSource fisBindingSource;
        private ERPDataSet19TableAdapters.FisTableAdapter fisTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisToplamFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
    }
}