namespace WinFormsApp1
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(163, 58);
            button1.Name = "button1";
            button1.Size = new Size(305, 221);
            button1.TabIndex = 0;
            button1.Text = "sorgu yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 285);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(565, 120);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(669, 30);
            button2.Name = "button2";
            button2.Size = new Size(163, 375);
            button2.TabIndex = 2;
            button2.Text = "Ürünleri Getir Token ile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(877, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(414, 364);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(349, 479);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "email";
            textBox1.Size = new Size(512, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 535);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "pass";
            textBox2.Size = new Size(512, 27);
            textBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(516, 591);
            button3.Name = "button3";
            button3.Size = new Size(190, 45);
            button3.TabIndex = 6;
            button3.Text = "login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 694);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
    }
}