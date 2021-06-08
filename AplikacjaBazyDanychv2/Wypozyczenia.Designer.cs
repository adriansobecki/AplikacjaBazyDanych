
namespace AplikacjaBazyDanychv2
{
    partial class Wypozyczenia
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.NewWypozyczenie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCennik = new System.Windows.Forms.Button();
            this.btnRodzaje = new System.Windows.Forms.Button();
            this.btnSprzęt = new System.Windows.Forms.Button();
            this.btnWypozyczenia = new System.Windows.Forms.Button();
            this.bntWyloguj = new System.Windows.Forms.Button();
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet = new AplikacjaBazyDanychv2.projekt2DataSet();
            this.wypozyczeniaTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSetTableAdapters.wypozyczeniaTableAdapter();
            this.logowanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logowanieTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSetTableAdapters.LogowanieTableAdapter();
            this.projekt2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projekt2DataSet1 = new AplikacjaBazyDanychv2.projekt2DataSet1();
            this.wypozyczeniaviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaviewTableAdapter = new AplikacjaBazyDanychv2.projekt2DataSet1TableAdapters.wypozyczeniaviewTableAdapter();
            this.projekt2DataSet2 = new AplikacjaBazyDanychv2.projekt2DataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZwrotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klienciIdKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Szczegoly = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.NewWypozyczenie);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1469, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Location = new System.Drawing.Point(1241, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Restore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(845, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.Location = new System.Drawing.Point(449, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 52);
            this.button7.TabIndex = 8;
            this.button7.Text = "Zwrot sprzętu";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // NewWypozyczenie
            // 
            this.NewWypozyczenie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewWypozyczenie.Location = new System.Drawing.Point(71, 46);
            this.NewWypozyczenie.Name = "NewWypozyczenie";
            this.NewWypozyczenie.Size = new System.Drawing.Size(171, 52);
            this.NewWypozyczenie.TabIndex = 7;
            this.NewWypozyczenie.Text = "Nowe wypożyczenie";
            this.NewWypozyczenie.UseVisualStyleBackColor = true;
            this.NewWypozyczenie.Click += new System.EventHandler(this.NewWypozyczenie_Click);
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
            this.groupBox1.TabIndex = 9;
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
            // wypozyczeniaBindingSource
            // 
            this.wypozyczeniaBindingSource.DataMember = "wypozyczenia";
            this.wypozyczeniaBindingSource.DataSource = this.projekt2DataSetBindingSource;
            // 
            // projekt2DataSetBindingSource
            // 
            this.projekt2DataSetBindingSource.DataSource = this.projekt2DataSet;
            this.projekt2DataSetBindingSource.Position = 0;
            // 
            // projekt2DataSet
            // 
            this.projekt2DataSet.DataSetName = "projekt2DataSet";
            this.projekt2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypozyczeniaTableAdapter
            // 
            this.wypozyczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // logowanieBindingSource
            // 
            this.logowanieBindingSource.DataMember = "Logowanie";
            this.logowanieBindingSource.DataSource = this.projekt2DataSet;
            // 
            // logowanieTableAdapter
            // 
            this.logowanieTableAdapter.ClearBeforeFill = true;
            // 
            // projekt2DataSetBindingSource1
            // 
            this.projekt2DataSetBindingSource1.DataSource = this.projekt2DataSet;
            this.projekt2DataSetBindingSource1.Position = 0;
            // 
            // projekt2DataSet1
            // 
            this.projekt2DataSet1.DataSetName = "projekt2DataSet1";
            this.projekt2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypozyczeniaviewBindingSource
            // 
            this.wypozyczeniaviewBindingSource.DataMember = "wypozyczeniaview";
            this.wypozyczeniaviewBindingSource.DataSource = this.projekt2DataSet1;
            // 
            // wypozyczeniaviewTableAdapter
            // 
            this.wypozyczeniaviewTableAdapter.ClearBeforeFill = true;
            // 
            // projekt2DataSet2
            // 
            this.projekt2DataSet2.DataSetName = "projekt2DataSet2";
            this.projekt2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idWypozyczeniaDataGridViewTextBoxColumn,
            this.dataWypozyczeniaDataGridViewTextBoxColumn,
            this.dataZwrotuDataGridViewTextBoxColumn,
            this.czasWypozyczeniaDataGridViewTextBoxColumn,
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn,
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn,
            this.klienciIdKlientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.Szczegoly});
            this.dataGridView1.DataSource = this.wypozyczeniaviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1469, 482);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // idWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.idWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "IdWypozyczenia";
            this.idWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "IdWypozyczenia";
            this.idWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idWypozyczeniaDataGridViewTextBoxColumn.Name = "idWypozyczeniaDataGridViewTextBoxColumn";
            this.idWypozyczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.dataWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "DataWypozyczenia";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "DataWypozyczenia";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataWypozyczeniaDataGridViewTextBoxColumn.Name = "dataWypozyczeniaDataGridViewTextBoxColumn";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataZwrotuDataGridViewTextBoxColumn
            // 
            this.dataZwrotuDataGridViewTextBoxColumn.DataPropertyName = "DataZwrotu";
            this.dataZwrotuDataGridViewTextBoxColumn.HeaderText = "DataZwrotu";
            this.dataZwrotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataZwrotuDataGridViewTextBoxColumn.Name = "dataZwrotuDataGridViewTextBoxColumn";
            this.dataZwrotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czasWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.czasWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "CzasWypozyczenia";
            this.czasWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "CzasWypozyczenia";
            this.czasWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czasWypozyczeniaDataGridViewTextBoxColumn.Name = "czasWypozyczeniaDataGridViewTextBoxColumn";
            // 
            // kwotaWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "KwotaWypozyczenia";
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "KwotaWypozyczenia";
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn.Name = "kwotaWypozyczeniaDataGridViewTextBoxColumn";
            this.kwotaWypozyczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn
            // 
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn.DataPropertyName = "UzytkownicySystemu_IdUzytkownika";
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn.HeaderText = "UzytkownicySystemu_IdUzytkownika";
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn.Name = "uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn";
            this.uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klienciIdKlientaDataGridViewTextBoxColumn
            // 
            this.klienciIdKlientaDataGridViewTextBoxColumn.DataPropertyName = "Klienci_IdKlienta";
            this.klienciIdKlientaDataGridViewTextBoxColumn.HeaderText = "Klienci_IdKlienta";
            this.klienciIdKlientaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.klienciIdKlientaDataGridViewTextBoxColumn.Name = "klienciIdKlientaDataGridViewTextBoxColumn";
            this.klienciIdKlientaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Szczegoly
            // 
            this.Szczegoly.FillWeight = 80F;
            this.Szczegoly.HeaderText = "Szczegoly";
            this.Szczegoly.MinimumWidth = 6;
            this.Szczegoly.Name = "Szczegoly";
            this.Szczegoly.ReadOnly = true;
            this.Szczegoly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Szczegoly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Szczegoly.Text = "Szczegoly";
            this.Szczegoly.UseColumnTextForButtonValue = true;
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 783);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Wypozyczenia";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logowanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button NewWypozyczenie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCennik;
        private System.Windows.Forms.Button btnRodzaje;
        private System.Windows.Forms.Button btnSprzęt;
        private System.Windows.Forms.Button btnWypozyczenia;
        private System.Windows.Forms.Button bntWyloguj;
        private System.Windows.Forms.BindingSource projekt2DataSetBindingSource;
        private projekt2DataSet projekt2DataSet;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private projekt2DataSetTableAdapters.wypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private System.Windows.Forms.BindingSource projekt2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource logowanieBindingSource;
        private projekt2DataSetTableAdapters.LogowanieTableAdapter logowanieTableAdapter;
        private projekt2DataSet1 projekt2DataSet1;
        private System.Windows.Forms.BindingSource wypozyczeniaviewBindingSource;
        private projekt2DataSet1TableAdapters.wypozyczeniaviewTableAdapter wypozyczeniaviewTableAdapter;
        private projekt2DataSet2 projekt2DataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZwrotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kwotaWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytkownicySystemuIdUzytkownikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klienciIdKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Szczegoly;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}