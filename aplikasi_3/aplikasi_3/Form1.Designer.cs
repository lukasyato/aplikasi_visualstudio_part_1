
namespace aplikasi_3
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
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblTerambil = new System.Windows.Forms.Label();
            this.txtTerambil = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTerambil);
            this.groupBox1.Controls.Add(this.lblTerambil);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.lblMax);
            this.groupBox1.Controls.Add(this.lblMin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(28, 37);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(63, 20);
            this.lblMin.TabIndex = 0;
            this.lblMin.Text = "Minimal";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(28, 72);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(72, 20);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Maksimal";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(161, 34);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(285, 27);
            this.txtMin.TabIndex = 2;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(161, 69);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(285, 27);
            this.txtMax.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(463, 26);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 115);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblTerambil
            // 
            this.lblTerambil.AutoSize = true;
            this.lblTerambil.Location = new System.Drawing.Point(28, 110);
            this.lblTerambil.Name = "lblTerambil";
            this.lblTerambil.Size = new System.Drawing.Size(101, 20);
            this.lblTerambil.TabIndex = 5;
            this.lblTerambil.Text = "Yang terambil";
            // 
            // txtTerambil
            // 
            this.txtTerambil.Location = new System.Drawing.Point(161, 107);
            this.txtTerambil.Name = "txtTerambil";
            this.txtTerambil.ReadOnly = true;
            this.txtTerambil.Size = new System.Drawing.Size(285, 27);
            this.txtTerambil.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 179);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Random Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTerambil;
        private System.Windows.Forms.Label lblTerambil;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
    }
}

