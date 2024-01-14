namespace DBapplication
{
    partial class AdminLgIn
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
            this.pw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(287, 163);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(53, 13);
            this.pw.TabIndex = 20;
            this.pw.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(290, 81);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(193, 20);
            this.em.TabIndex = 17;
            this.em.TextChanged += new System.EventHandler(this.em_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLgIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.em);
            this.Controls.Add(this.button1);
            this.Name = "AdminLgIn";
            this.Text = "AdminLgIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Button button1;
    }
}