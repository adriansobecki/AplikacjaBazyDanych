
namespace AplikacjaBazyDanychv2
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.group = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textHaslo = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.button1);
            this.group.Controls.Add(this.textHaslo);
            this.group.Controls.Add(this.textLogin);
            this.group.Controls.Add(this.label1);
            this.group.Controls.Add(this.label2);
            this.group.Location = new System.Drawing.Point(265, 97);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(644, 588);
            this.group.TabIndex = 8;
            this.group.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(190, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logowanie";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(222, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zaloguj się";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textHaslo
            // 
            this.textHaslo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textHaslo.Location = new System.Drawing.Point(289, 365);
            this.textHaslo.Name = "textHaslo";
            this.textHaslo.Size = new System.Drawing.Size(338, 55);
            this.textHaslo.TabIndex = 5;
            this.textHaslo.UseSystemPasswordChar = true;
            // 
            // textLogin
            // 
            this.textLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLogin.Location = new System.Drawing.Point(289, 266);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(338, 55);
            this.textLogin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 783);
            this.Controls.Add(this.group);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textHaslo;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

