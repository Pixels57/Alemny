namespace DBapplication
{
    partial class Student
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.em = new System.Windows.Forms.TextBox();
            this.pn = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(85, 131);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(193, 20);
            this.em.TabIndex = 2;
            this.em.TextChanged += new System.EventHandler(this.em_TextChanged);
            // 
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(666, 114);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(193, 20);
            this.pn.TabIndex = 3;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(406, 50);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(193, 20);
            this.fn.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(406, 246);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(193, 20);
            this.city.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(406, 178);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(193, 20);
            this.email.TabIndex = 7;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(666, 178);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(193, 20);
            this.pass.TabIndex = 8;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(406, 114);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(193, 20);
            this.age.TabIndex = 9;
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(666, 50);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(193, 20);
            this.ln.TabIndex = 10;
            this.ln.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(666, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(406, 303);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(549, 303);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(82, 213);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(53, 13);
            this.pw.TabIndex = 15;
            this.pw.Text = "Password";
            this.pw.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Firsat name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(663, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Area";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 490);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.age);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.city);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.em);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}