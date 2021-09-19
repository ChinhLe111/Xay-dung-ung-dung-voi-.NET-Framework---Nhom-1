namespace WindowsFormsApp1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tru = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.chia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(280, 85);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(305, 26);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(280, 140);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(305, 26);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cộng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tru
            // 
            this.tru.Location = new System.Drawing.Point(385, 228);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(105, 47);
            this.tru.TabIndex = 3;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.Click += new System.EventHandler(this.button2_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(496, 228);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(105, 47);
            this.nhan.TabIndex = 4;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // chia
            // 
            this.chia.Location = new System.Drawing.Point(607, 229);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(105, 46);
            this.chia.TabIndex = 5;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số thứ hai";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(238, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Các phép tính cơ bản";
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Location = new System.Drawing.Point(181, 335);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(68, 20);
            this.txtkq.TabIndex = 9;
            this.txtkq.Text = "Kết quả:";
            // 
            // kq
            // 
            this.kq.AutoSize = true;
            this.kq.Location = new System.Drawing.Point(276, 335);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(18, 20);
            this.kq.TabIndex = 10;
            this.kq.Text = "0";
            this.kq.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 409);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chia);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tru;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button chia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.Label kq;
    }
}

