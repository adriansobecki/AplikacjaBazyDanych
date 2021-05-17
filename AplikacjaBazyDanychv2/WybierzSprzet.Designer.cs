
namespace AplikacjaBazyDanychv2
{
    partial class WybierzSprzet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projekt2DataSet = new AplikacjaBazyDanychv2.projekt2DataSet();
            this.sprzetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprzetTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSetTableAdapters.sprzetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // projekt2DataSet
            // 
            this.projekt2DataSet.DataSetName = "projekt2DataSet";
            this.projekt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprzetBindingSource
            // 
            this.sprzetBindingSource.DataMember = "sprzet";
            this.sprzetBindingSource.DataSource = this.projekt2DataSet;
            // 
            // sprzetTableAdapter
            // 
            this.sprzetTableAdapter.ClearBeforeFill = true;
            // 
            // WybierzSprzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "WybierzSprzet";
            this.Text = "WybierzSprzet";
            this.Load += new System.EventHandler(this.WybierzSprzet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projekt2DataSet projekt2DataSet;
        private System.Windows.Forms.BindingSource sprzetBindingSource;
        private projekt2DataSetTableAdapters.sprzetTableAdapter sprzetTableAdapter;
    }
}