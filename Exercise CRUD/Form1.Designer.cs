
namespace Exercise_CRUD
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBaru = new System.Windows.Forms.DataGridView();
            this.idSapiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMasukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet = new Exercise_CRUD.HRDataSet();
            this.dgvLaku = new System.Windows.Forms.DataGridView();
            this.idSapiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobotDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKeluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRDataSet1 = new Exercise_CRUD.HRDataSet1();
            this.tbMasukTableAdapter = new Exercise_CRUD.HRDataSetTableAdapters.tbMasukTableAdapter();
            this.tbKeluarTableAdapter = new Exercise_CRUD.HRDataSet1TableAdapters.tbKeluarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKeluarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(143, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(530, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Click";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Sapi Baru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(512, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Sapi Laku :";
            // 
            // dgvBaru
            // 
            this.dgvBaru.AutoGenerateColumns = false;
            this.dgvBaru.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvBaru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSapiDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.bobotDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn});
            this.dgvBaru.DataSource = this.tbMasukBindingSource;
            this.dgvBaru.Location = new System.Drawing.Point(15, 240);
            this.dgvBaru.Name = "dgvBaru";
            this.dgvBaru.Size = new System.Drawing.Size(375, 184);
            this.dgvBaru.TabIndex = 5;
            // 
            // idSapiDataGridViewTextBoxColumn
            // 
            this.idSapiDataGridViewTextBoxColumn.DataPropertyName = "Id_Sapi";
            this.idSapiDataGridViewTextBoxColumn.HeaderText = "Id_Sapi";
            this.idSapiDataGridViewTextBoxColumn.Name = "idSapiDataGridViewTextBoxColumn";
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            // 
            // bobotDataGridViewTextBoxColumn
            // 
            this.bobotDataGridViewTextBoxColumn.DataPropertyName = "Bobot";
            this.bobotDataGridViewTextBoxColumn.HeaderText = "Bobot";
            this.bobotDataGridViewTextBoxColumn.Name = "bobotDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            // 
            // tbMasukBindingSource
            // 
            this.tbMasukBindingSource.DataMember = "tbMasuk";
            this.tbMasukBindingSource.DataSource = this.hRDataSet;
            // 
            // hRDataSet
            // 
            this.hRDataSet.DataSetName = "HRDataSet";
            this.hRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLaku
            // 
            this.dgvLaku.AutoGenerateColumns = false;
            this.dgvLaku.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvLaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSapiDataGridViewTextBoxColumn1,
            this.jenisDataGridViewTextBoxColumn1,
            this.bobotDataGridViewTextBoxColumn1,
            this.hargaDataGridViewTextBoxColumn1});
            this.dgvLaku.DataSource = this.tbKeluarBindingSource;
            this.dgvLaku.Location = new System.Drawing.Point(396, 240);
            this.dgvLaku.Name = "dgvLaku";
            this.dgvLaku.Size = new System.Drawing.Size(375, 184);
            this.dgvLaku.TabIndex = 6;
            // 
            // idSapiDataGridViewTextBoxColumn1
            // 
            this.idSapiDataGridViewTextBoxColumn1.DataPropertyName = "Id_Sapi";
            this.idSapiDataGridViewTextBoxColumn1.HeaderText = "Id_Sapi";
            this.idSapiDataGridViewTextBoxColumn1.Name = "idSapiDataGridViewTextBoxColumn1";
            // 
            // jenisDataGridViewTextBoxColumn1
            // 
            this.jenisDataGridViewTextBoxColumn1.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn1.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn1.Name = "jenisDataGridViewTextBoxColumn1";
            // 
            // bobotDataGridViewTextBoxColumn1
            // 
            this.bobotDataGridViewTextBoxColumn1.DataPropertyName = "Bobot";
            this.bobotDataGridViewTextBoxColumn1.HeaderText = "Bobot";
            this.bobotDataGridViewTextBoxColumn1.Name = "bobotDataGridViewTextBoxColumn1";
            // 
            // hargaDataGridViewTextBoxColumn1
            // 
            this.hargaDataGridViewTextBoxColumn1.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn1.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn1.Name = "hargaDataGridViewTextBoxColumn1";
            // 
            // tbKeluarBindingSource
            // 
            this.tbKeluarBindingSource.DataMember = "tbKeluar";
            this.tbKeluarBindingSource.DataSource = this.hRDataSet1;
            // 
            // hRDataSet1
            // 
            this.hRDataSet1.DataSetName = "HRDataSet1";
            this.hRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMasukTableAdapter
            // 
            this.tbMasukTableAdapter.ClearBeforeFill = true;
            // 
            // tbKeluarTableAdapter
            // 
            this.tbKeluarTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLaku);
            this.Controls.Add(this.dgvBaru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Kandang";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMasukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKeluarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBaru;
        private System.Windows.Forms.DataGridView dgvLaku;
        private HRDataSet hRDataSet;
        private System.Windows.Forms.BindingSource tbMasukBindingSource;
        private HRDataSetTableAdapters.tbMasukTableAdapter tbMasukTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSapiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSapiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobotDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn1;
        private HRDataSet1 hRDataSet1;
        private System.Windows.Forms.BindingSource tbKeluarBindingSource;
        private HRDataSet1TableAdapters.tbKeluarTableAdapter tbKeluarTableAdapter;
    }
}

