namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.vuong = new System.Windows.Forms.Button();
            this.tron = new System.Windows.Forms.Button();
            this.tamgiac = new System.Windows.Forms.Button();
            this.chunhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuong Trinh Tinh Chu Vi Hinh Hoc";
            // 
            // vuong
            // 
            this.vuong.Location = new System.Drawing.Point(34, 109);
            this.vuong.Name = "vuong";
            this.vuong.Size = new System.Drawing.Size(75, 23);
            this.vuong.TabIndex = 1;
            this.vuong.Text = "Vuông";
            this.vuong.UseVisualStyleBackColor = true;
            this.vuong.Click += new System.EventHandler(this.vuong_Click);
            // 
            // tron
            // 
            this.tron.Location = new System.Drawing.Point(114, 147);
            this.tron.Name = "tron";
            this.tron.Size = new System.Drawing.Size(75, 23);
            this.tron.TabIndex = 2;
            this.tron.Text = "Tròn";
            this.tron.UseVisualStyleBackColor = true;
            this.tron.Click += new System.EventHandler(this.tron_Click);
            // 
            // tamgiac
            // 
            this.tamgiac.Location = new System.Drawing.Point(200, 185);
            this.tamgiac.Name = "tamgiac";
            this.tamgiac.Size = new System.Drawing.Size(75, 23);
            this.tamgiac.TabIndex = 3;
            this.tamgiac.Text = "Tam Giác";
            this.tamgiac.UseVisualStyleBackColor = true;
            this.tamgiac.Click += new System.EventHandler(this.tamgiac_Click);
            // 
            // chunhat
            // 
            this.chunhat.Location = new System.Drawing.Point(305, 223);
            this.chunhat.Name = "chunhat";
            this.chunhat.Size = new System.Drawing.Size(75, 23);
            this.chunhat.TabIndex = 4;
            this.chunhat.Text = "Chữ Nhật";
            this.chunhat.UseVisualStyleBackColor = true;
            this.chunhat.Click += new System.EventHandler(this.chunhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 350);
            this.Controls.Add(this.chunhat);
            this.Controls.Add(this.tamgiac);
            this.Controls.Add(this.tron);
            this.Controls.Add(this.vuong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vuong;
        private System.Windows.Forms.Button tron;
        private System.Windows.Forms.Button tamgiac;
        private System.Windows.Forms.Button chunhat;
    }
}

