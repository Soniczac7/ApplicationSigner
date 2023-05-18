namespace Application_Signer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            openExe = new OpenFileDialog();
            openPFX = new OpenFileDialog();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            textBox5 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Path to Executable";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Path to PFX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(387, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 23);
            textBox3.TabIndex = 5;
            textBox3.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 215);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 6;
            button1.Text = "Sign Application";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 115);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 7;
            button2.Text = "Show / Hide";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(405, 27);
            button3.Name = "button3";
            button3.Size = new Size(24, 23);
            button3.TabIndex = 8;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(405, 71);
            button4.Name = "button4";
            button4.Size = new Size(24, 23);
            button4.TabIndex = 9;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openExe
            // 
            openExe.DefaultExt = "exe";
            openExe.Filter = "Executable files|*.exe|Dynamic-link Library files|*.dll";
            // 
            // openPFX
            // 
            openPFX.DefaultExt = "pfx";
            openPFX.Filter = "Personal Information Exchange files|*.pfx";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(435, 12);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(325, 226);
            textBox4.TabIndex = 10;
            textBox4.WordWrap = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(12, 144);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Do Timestamping";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(417, 23);
            textBox5.TabIndex = 12;
            textBox5.Text = "http://timestamp.sectigo.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 13;
            label4.Text = "Timestamping URL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 250);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Application Signer";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private OpenFileDialog openExe;
        private OpenFileDialog openPFX;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private TextBox textBox5;
        private Label label4;
    }
}