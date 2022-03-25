
namespace Hangman
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EingabeLbl = new System.Windows.Forms.Label();
            this.EingabeTxt = new System.Windows.Forms.TextBox();
            this.AnweisungLbl = new System.Windows.Forms.Label();
            this.WortEingabeBtn = new System.Windows.Forms.Button();
            this.BuchstabenBtn = new System.Windows.Forms.Button();
            this.schonVerwendeteBuchstaben = new System.Windows.Forms.Label();
            this.WortAusgabe = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.hangmanPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EingabeLbl
            // 
            this.EingabeLbl.AutoSize = true;
            this.EingabeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeLbl.Location = new System.Drawing.Point(495, 91);
            this.EingabeLbl.Name = "EingabeLbl";
            this.EingabeLbl.Size = new System.Drawing.Size(195, 32);
            this.EingabeLbl.TabIndex = 1;
            this.EingabeLbl.Text = "Eingabe Wort:";
            // 
            // EingabeTxt
            // 
            this.EingabeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EingabeTxt.Location = new System.Drawing.Point(709, 84);
            this.EingabeTxt.Name = "EingabeTxt";
            this.EingabeTxt.Size = new System.Drawing.Size(624, 39);
            this.EingabeTxt.TabIndex = 2;
            // 
            // AnweisungLbl
            // 
            this.AnweisungLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnweisungLbl.Location = new System.Drawing.Point(12, 607);
            this.AnweisungLbl.Name = "AnweisungLbl";
            this.AnweisungLbl.Size = new System.Drawing.Size(905, 62);
            this.AnweisungLbl.TabIndex = 3;
            this.AnweisungLbl.Text = "Bitte geben Sie ein Wort ein und bestätigen Sie mit \'ok\'!";
            // 
            // WortEingabeBtn
            // 
            this.WortEingabeBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.WortEingabeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WortEingabeBtn.Location = new System.Drawing.Point(709, 162);
            this.WortEingabeBtn.Name = "WortEingabeBtn";
            this.WortEingabeBtn.Size = new System.Drawing.Size(213, 89);
            this.WortEingabeBtn.TabIndex = 4;
            this.WortEingabeBtn.Text = "ok";
            this.WortEingabeBtn.UseVisualStyleBackColor = false;
            this.WortEingabeBtn.Click += new System.EventHandler(this.WortEingabeBtn_Click);
            // 
            // BuchstabenBtn
            // 
            this.BuchstabenBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BuchstabenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuchstabenBtn.Location = new System.Drawing.Point(947, 162);
            this.BuchstabenBtn.Name = "BuchstabenBtn";
            this.BuchstabenBtn.Size = new System.Drawing.Size(216, 89);
            this.BuchstabenBtn.TabIndex = 5;
            this.BuchstabenBtn.Text = "ok";
            this.BuchstabenBtn.UseVisualStyleBackColor = false;
            this.BuchstabenBtn.Click += new System.EventHandler(this.BuchstabenBtn_Click);
            // 
            // schonVerwendeteBuchstaben
            // 
            this.schonVerwendeteBuchstaben.AutoSize = true;
            this.schonVerwendeteBuchstaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schonVerwendeteBuchstaben.Location = new System.Drawing.Point(34, 475);
            this.schonVerwendeteBuchstaben.Name = "schonVerwendeteBuchstaben";
            this.schonVerwendeteBuchstaben.Size = new System.Drawing.Size(0, 46);
            this.schonVerwendeteBuchstaben.TabIndex = 7;
            // 
            // WortAusgabe
            // 
            this.WortAusgabe.AutoSize = true;
            this.WortAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WortAusgabe.Location = new System.Drawing.Point(34, 347);
            this.WortAusgabe.Name = "WortAusgabe";
            this.WortAusgabe.Size = new System.Drawing.Size(0, 46);
            this.WortAusgabe.TabIndex = 8;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(12, 693);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(210, 61);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "beenden";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // hangmanPicture
            // 
            this.hangmanPicture.Location = new System.Drawing.Point(925, 288);
            this.hangmanPicture.Name = "hangmanPicture";
            this.hangmanPicture.Size = new System.Drawing.Size(515, 500);
            this.hangmanPicture.TabIndex = 11;
            this.hangmanPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 91);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1457, 804);
            this.Controls.Add(this.hangmanPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.WortAusgabe);
            this.Controls.Add(this.schonVerwendeteBuchstaben);
            this.Controls.Add(this.BuchstabenBtn);
            this.Controls.Add(this.WortEingabeBtn);
            this.Controls.Add(this.AnweisungLbl);
            this.Controls.Add(this.EingabeTxt);
            this.Controls.Add(this.EingabeLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EingabeLbl;
        private System.Windows.Forms.TextBox EingabeTxt;
        private System.Windows.Forms.Label AnweisungLbl;
        private System.Windows.Forms.Button WortEingabeBtn;
        private System.Windows.Forms.Button BuchstabenBtn;
        private System.Windows.Forms.Label schonVerwendeteBuchstaben;
        private System.Windows.Forms.Label WortAusgabe;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hangmanPicture;
    }
}

