
namespace AplikacjaBazyDanychv2
{
    partial class Cennik
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCennik = new System.Windows.Forms.Button();
            this.btnRodzaje = new System.Windows.Forms.Button();
            this.btnSprzęt = new System.Windows.Forms.Button();
            this.btnWypozyczenia = new System.Windows.Forms.Button();
            this.bntWyloguj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cennikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet5 = new AplikacjaBazyDanychv2.projekt2DataSet5();
            this.cennikviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet3 = new AplikacjaBazyDanychv2.projekt2DataSet3();
            this.cennikviewTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSet3TableAdapters.cennikviewTableAdapter();
            this.projekt2DataSet4 = new AplikacjaBazyDanychv2.projekt2DataSet4();
            this.cennikviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cennikviewTableAdapter1 = new AplikacjaBazyDanychv2.projekt2DataSet4TableAdapters.cennikviewTableAdapter();
            this.cennikviewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cennikviewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cennikTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSet5TableAdapters.cennikTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCennik);
            this.groupBox1.Controls.Add(this.btnRodzaje);
            this.groupBox1.Controls.Add(this.btnSprzęt);
            this.groupBox1.Controls.Add(this.btnWypozyczenia);
            this.groupBox1.Controls.Add(this.bntWyloguj);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1469, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user.Location = new System.Drawing.Point(1022, 28);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(286, 30);
            this.user.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(880, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zalogowany:";
            // 
            // btnCennik
            // 
            this.btnCennik.Location = new System.Drawing.Point(628, 21);
            this.btnCennik.Name = "btnCennik";
            this.btnCennik.Size = new System.Drawing.Size(174, 43);
            this.btnCennik.TabIndex = 6;
            this.btnCennik.Text = "Cennik";
            this.btnCennik.UseVisualStyleBackColor = true;
            // 
            // btnRodzaje
            // 
            this.btnRodzaje.Location = new System.Drawing.Point(422, 21);
            this.btnRodzaje.Name = "btnRodzaje";
            this.btnRodzaje.Size = new System.Drawing.Size(174, 43);
            this.btnRodzaje.TabIndex = 6;
            this.btnRodzaje.Text = "Rodzaje sprzętu";
            this.btnRodzaje.UseVisualStyleBackColor = true;
            this.btnRodzaje.Click += new System.EventHandler(this.btnRodzaje_Click);
            // 
            // btnSprzęt
            // 
            this.btnSprzęt.Location = new System.Drawing.Point(211, 21);
            this.btnSprzęt.Name = "btnSprzęt";
            this.btnSprzęt.Size = new System.Drawing.Size(174, 43);
            this.btnSprzęt.TabIndex = 5;
            this.btnSprzęt.Text = "Sprzęt";
            this.btnSprzęt.UseVisualStyleBackColor = true;
            this.btnSprzęt.Click += new System.EventHandler(this.btnSprzęt_Click);
            // 
            // btnWypozyczenia
            // 
            this.btnWypozyczenia.Location = new System.Drawing.Point(6, 21);
            this.btnWypozyczenia.Name = "btnWypozyczenia";
            this.btnWypozyczenia.Size = new System.Drawing.Size(174, 43);
            this.btnWypozyczenia.TabIndex = 0;
            this.btnWypozyczenia.Text = "Wypożyczenia";
            this.btnWypozyczenia.UseVisualStyleBackColor = true;
            this.btnWypozyczenia.Click += new System.EventHandler(this.btnWypozyczenia_Click);
            // 
            // bntWyloguj
            // 
            this.bntWyloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntWyloguj.Location = new System.Drawing.Point(1325, 21);
            this.bntWyloguj.Name = "bntWyloguj";
            this.bntWyloguj.Size = new System.Drawing.Size(138, 43);
            this.bntWyloguj.TabIndex = 4;
            this.bntWyloguj.Text = "Wyloguj";
            this.bntWyloguj.UseVisualStyleBackColor = true;
            this.bntWyloguj.Click += new System.EventHandler(this.bntWyloguj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.czasWypozyczeniaDataGridViewTextBoxColumn,
            this.kosztWypozyczeniaDataGridViewTextBoxColumn,
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cennikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1469, 587);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czasWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.czasWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "CzasWypozyczenia";
            this.czasWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "CzasWypozyczenia";
            this.czasWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czasWypozyczeniaDataGridViewTextBoxColumn.Name = "czasWypozyczeniaDataGridViewTextBoxColumn";
            // 
            // kosztWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.kosztWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "KosztWypozyczenia";
            this.kosztWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "KosztWypozyczenia";
            this.kosztWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kosztWypozyczeniaDataGridViewTextBoxColumn.Name = "kosztWypozyczeniaDataGridViewTextBoxColumn";
            // 
            // rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn
            // 
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.DataPropertyName = "RodzajSprzetu_IdRodzajuSprzetu";
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.HeaderText = "RodzajSprzetu_IdRodzajuSprzetu";
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.Name = "rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn";
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cennikBindingSource
            // 
            this.cennikBindingSource.DataMember = "cennik";
            this.cennikBindingSource.DataSource = this.projekt2DataSet5;
            // 
            // projekt2DataSet5
            // 
            this.projekt2DataSet5.DataSetName = "projekt2DataSet5";
            this.projekt2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cennikviewBindingSource
            // 
            this.cennikviewBindingSource.DataMember = "cennikview";
            this.cennikviewBindingSource.DataSource = this.projekt2DataSet3;
            // 
            // projekt2DataSet3
            // 
            this.projekt2DataSet3.DataSetName = "projekt2DataSet3";
            this.projekt2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cennikviewTableAdapter
            // 
            this.cennikviewTableAdapter.ClearBeforeFill = true;
            // 
            // projekt2DataSet4
            // 
            this.projekt2DataSet4.DataSetName = "projekt2DataSet4";
            this.projekt2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cennikviewBindingSource1
            // 
            this.cennikviewBindingSource1.DataMember = "cennikview";
            this.cennikviewBindingSource1.DataSource = this.projekt2DataSet4;
            // 
            // cennikviewTableAdapter1
            // 
            this.cennikviewTableAdapter1.ClearBeforeFill = true;
            // 
            // cennikviewBindingSource2
            // 
            this.cennikviewBindingSource2.DataMember = "cennikview";
            this.cennikviewBindingSource2.DataSource = this.projekt2DataSet4;
            // 
            // cennikviewBindingSource3
            // 
            this.cennikviewBindingSource3.DataMember = "cennikview";
            this.cennikviewBindingSource3.DataSource = this.projekt2DataSet4;
            // 
            // cennikTableAdapter
            // 
            this.cennikTableAdapter.ClearBeforeFill = true;
            // 
            // Cennik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 783);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cennik";
            this.Text = "Cennik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cennik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cennikviewBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCennik;
        private System.Windows.Forms.Button btnRodzaje;
        private System.Windows.Forms.Button btnSprzęt;
        private System.Windows.Forms.Button btnWypozyczenia;
        private System.Windows.Forms.Button bntWyloguj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private projekt2DataSet3 projekt2DataSet3;
        private System.Windows.Forms.BindingSource cennikviewBindingSource;
        private projekt2DataSet3TableAdapters.cennikviewTableAdapter cennikviewTableAdapter;
        private projekt2DataSet4 projekt2DataSet4;
        private System.Windows.Forms.BindingSource cennikviewBindingSource1;
        private projekt2DataSet4TableAdapters.cennikviewTableAdapter cennikviewTableAdapter1;
        private System.Windows.Forms.BindingSource cennikviewBindingSource3;
        private System.Windows.Forms.BindingSource cennikviewBindingSource2;
        private projekt2DataSet5 projekt2DataSet5;
        private System.Windows.Forms.BindingSource cennikBindingSource;
        private projekt2DataSet5TableAdapters.cennikTableAdapter cennikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn;
    }
}