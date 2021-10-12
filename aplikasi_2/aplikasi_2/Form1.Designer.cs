
namespace aplikasi_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.btnJumlah = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHasil);
            this.groupBox1.Controls.Add(this.lblHasil);
            this.groupBox1.Controls.Add(this.btnJumlah);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.lblB);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(198, 98);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(263, 27);
            this.txtHasil.TabIndex = 6;
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(20, 101);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(132, 20);
            this.lblHasil.TabIndex = 5;
            this.lblHasil.Text = "Hasil A + B adalah";
            // 
            // btnJumlah
            // 
            this.btnJumlah.Location = new System.Drawing.Point(477, 23);
            this.btnJumlah.Name = "btnJumlah";
            this.btnJumlah.Size = new System.Drawing.Size(142, 104);
            this.btnJumlah.TabIndex = 4;
            this.btnJumlah.Text = "Jumlahkan";
            this.btnJumlah.UseVisualStyleBackColor = true;
            this.btnJumlah.Click += new System.EventHandler(this.btnJumlah_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(198, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(263, 27);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(198, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(263, 27);
            this.txtA.TabIndex = 2;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(21, 68);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(112, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Masukan nilai B";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(20, 32);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(113, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Masukan nilai A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 167);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Button btnJumlah;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
    }
}

