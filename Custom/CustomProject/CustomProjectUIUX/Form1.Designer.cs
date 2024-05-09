namespace CustomProjectUIUX
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(694, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 130);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(564, 162);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter query:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1039, 157);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 3;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(-2, 628);
            panel2.Name = "panel2";
            panel2.Size = new Size(1243, 98);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(40, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 408);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(195, 35);
            label2.TabIndex = 4;
            label2.Text = "Found an item?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(383, 27);
            textBox4.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(49, 331);
            button2.Name = "button2";
            button2.Size = new Size(145, 43);
            button2.TabIndex = 4;
            button2.Text = "Post";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(564, 222);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 4;
            label3.Text = "Campus recent item";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(68, 27);
            label4.Name = "label4";
            label4.Size = new Size(345, 60);
            label4.TabIndex = 5;
            label4.Text = "Dang Quynh Chi";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 71);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "Item name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 158);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 6;
            label6.Text = "Location";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 234);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 7;
            label7.Text = "Identifiable hashtags";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 27);
            textBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(68, 87);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 5;
            label8.Text = "<<student id>>";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1238, 653);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button button2;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}