
namespace AplikacjaBazyDanychv2
{
    partial class Sprzet
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
            this.idSprzetuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostepnoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rozmiarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sprzetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet5 = new AplikacjaBazyDanychv2.projekt2DataSet5();
            this.sprzetviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet2 = new AplikacjaBazyDanychv2.projekt2DataSet2();
            this.sprzetviewTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSet2TableAdapters.sprzetviewTableAdapter();
            this.sprzetTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSet5TableAdapters.sprzetTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet2)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1278, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.user.Location = new System.Drawing.Point(955, 28);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(173, 30);
            this.user.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(825, 31);
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
            this.btnCennik.Click += new System.EventHandler(this.btnCennik_Click);
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
            this.bntWyloguj.Location = new System.Drawing.Point(1134, 21);
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
            this.idSprzetuDataGridViewTextBoxColumn,
            this.dostepnoscDataGridViewTextBoxColumn,
            this.rozmiarDataGridViewTextBoxColumn,
            this.uwagiDataGridViewTextBoxColumn,
            this.rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sprzetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 590);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idSprzetuDataGridViewTextBoxColumn
            // 
            this.idSprzetuDataGridViewTextBoxColumn.DataPropertyName = "IdSprzetu";
            this.idSprzetuDataGridViewTextBoxColumn.HeaderText = "IdSprzetu";
            this.idSprzetuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSprzetuDataGridViewTextBoxColumn.Name = "idSprzetuDataGridViewTextBoxColumn";
            this.idSprzetuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dostepnoscDataGridViewTextBoxColumn
            // 
            this.dostepnoscDataGridViewTextBoxColumn.DataPropertyName = "Dostepnosc";
            this.dostepnoscDataGridViewTextBoxColumn.HeaderText = "Dostepnosc";
            this.dostepnoscDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dostepnoscDataGridViewTextBoxColumn.Name = "dostepnoscDataGridViewTextBoxColumn";
            this.dostepnoscDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dostepnoscDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rozmiarDataGridViewTextBoxColumn
            // 
            this.rozmiarDataGridViewTextBoxColumn.DataPropertyName = "Rozmiar";
            this.rozmiarDataGridViewTextBoxColumn.HeaderText = "Rozmiar";
            this.rozmiarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rozmiarDataGridViewTextBoxColumn.Name = "rozmiarDataGridViewTextBoxColumn";
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
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
            // sprzetBindingSource
            // 
            this.sprzetBindingSource.DataMember = "sprzet";
            this.sprzetBindingSource.DataSource = this.projekt2DataSet5;
            // 
            // projekt2DataSet5
            // 
            this.projekt2DataSet5.DataSetName = "projekt2DataSet5";
            this.projekt2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprzetviewBindingSource
            // 
            this.sprzetviewBindingSource.DataMember = "sprzetview";
            this.sprzetviewBindingSource.DataSource = this.projekt2DataSet2;
            // 
            // projekt2DataSet2
            // 
            this.projekt2DataSet2.DataSetName = "projekt2DataSet2";
            this.projekt2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprzetviewTableAdapter
            // 
            this.sprzetviewTableAdapter.ClearBeforeFill = true;
            // 
            // sprzetTableAdapter
            // 
            this.sprzetTableAdapter.ClearBeforeFill = true;
            // 
            // Sprzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 783);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sprzet";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sprzet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprzetviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet2)).EndInit();
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
        private projekt2DataSet2 projekt2DataSet2;
        private System.Windows.Forms.BindingSource sprzetviewBindingSource;
        private projekt2DataSet2TableAdapters.sprzetviewTableAdapter sprzetviewTableAdapter;
        private projekt2DataSet5 projekt2DataSet5;
        private System.Windows.Forms.BindingSource sprzetBindingSource;
        private projekt2DataSet5TableAdapters.sprzetTableAdapter sprzetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSprzetuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dostepnoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rozmiarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rodzajSprzetuIdRodzajuSprzetuDataGridViewTextBoxColumn;
    }
}