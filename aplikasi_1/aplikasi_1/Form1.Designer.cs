
namespace aplikasi_1
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtFavColor = new System.Windows.Forms.TextBox();
            this.lblFavColor = new System.Windows.Forms.Label();
            this.txtFavFood = new System.Windows.Forms.TextBox();
            this.lblFavFood = new System.Windows.Forms.Label();
            this.lblKesimpulan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(18, 26);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(108, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Masukan nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(257, 23);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(335, 27);
            this.txtNama.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.txtFavColor);
            this.groupBox1.Controls.Add(this.lblFavColor);
            this.groupBox1.Controls.Add(this.txtFavFood);
            this.groupBox1.Controls.Add(this.lblFavFood);
            this.groupBox1.Controls.Add(this.lblNama);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Linen;
            this.btnExit.Location = new System.Drawing.Point(605, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Linen;
            this.btnClear.Location = new System.Drawing.Point(605, 56);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Linen;
            this.btnApply.Location = new System.Drawing.Point(605, 17);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 33);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtFavColor
            // 
            this.txtFavColor.Location = new System.Drawing.Point(257, 99);
            this.txtFavColor.Name = "txtFavColor";
            this.txtFavColor.Size = new System.Drawing.Size(335, 27);
            this.txtFavColor.TabIndex = 5;
            // 
            // lblFavColor
            // 
            this.lblFavColor.AutoSize = true;
            this.lblFavColor.Location = new System.Drawing.Point(18, 102);
            this.lblFavColor.Name = "lblFavColor";
            this.lblFavColor.Size = new System.Drawing.Size(158, 20);
            this.lblFavColor.TabIndex = 4;
            this.lblFavColor.Text = "Masukan warna favorit";
            // 
            // txtFavFood
            // 
            this.txtFavFood.Location = new System.Drawing.Point(257, 60);
            this.txtFavFood.Name = "txtFavFood";
            this.txtFavFood.Size = new System.Drawing.Size(335, 27);
            this.txtFavFood.TabIndex = 3;
            // 
            // lblFavFood
            // 
            this.lblFavFood.AutoSize = true;
            this.lblFavFood.Location = new System.Drawing.Point(18, 63);
            this.lblFavFood.Name = "lblFavFood";
            this.lblFavFood.Size = new System.Drawing.Size(178, 20);
            this.lblFavFood.TabIndex = 2;
            this.lblFavFood.Text = "Masukan makanan favorit";
            // 
            // lblKesimpulan
            // 
            this.lblKesimpulan.AutoSize = true;
            this.lblKesimpulan.Location = new System.Drawing.Point(27, 34);
            this.lblKesimpulan.Name = "lblKesimpulan";
            this.lblKesimpulan.Size = new System.Drawing.Size(86, 20);
            this.lblKesimpulan.TabIndex = 3;
            this.lblKesimpulan.Text = "Kesimpulan";
            this.lblKesimpulan.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKesimpulan);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(729, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Menampilkan Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtFavColor;
        private System.Windows.Forms.Label lblFavColor;
        private System.Windows.Forms.TextBox txtFavFood;
        private System.Windows.Forms.Label lblFavFood;
        private System.Windows.Forms.Label lblKesimpulan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

