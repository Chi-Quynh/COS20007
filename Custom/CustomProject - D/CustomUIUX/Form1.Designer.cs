namespace CustomUIUX
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
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            DescriptionLabel = new Label();
            DesccriptionTextbox = new TextBox();
            comboBox1 = new ComboBox();
            post = new Button();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            RelatedidTextbox = new TextBox();
            ItemnameTextbox = new TextBox();
            label1 = new Label();
            label6 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(532, 170);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1243, 132);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(0, 591);
            panel2.Name = "panel2";
            panel2.Size = new Size(1243, 77);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(DescriptionLabel);
            panel3.Controls.Add(DesccriptionTextbox);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(post);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(RelatedidTextbox);
            panel3.Controls.Add(ItemnameTextbox);
            panel3.Location = new Point(690, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 380);
            panel3.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(23, 154);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(96, 23);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description";
            // 
            // DesccriptionTextbox
            // 
            DesccriptionTextbox.Location = new Point(135, 151);
            DesccriptionTextbox.Name = "DesccriptionTextbox";
            DesccriptionTextbox.Size = new Size(255, 27);
            DesccriptionTextbox.TabIndex = 10;
            DesccriptionTextbox.TextChanged += DesccriptionTextbox_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Library", "Innovative concept room" });
            comboBox1.Location = new Point(239, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // post
            // 
            post.Location = new Point(287, 314);
            post.Name = "post";
            post.Size = new Size(94, 29);
            post.TabIndex = 6;
            post.Text = "Post";
            post.UseVisualStyleBackColor = true;
            post.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 208);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 8;
            label5.Text = "Location (select)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 106);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 6;
            label3.Text = "Item name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 265);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 7;
            label4.Text = "Related ids";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(230, 41);
            label2.TabIndex = 6;
            label2.Text = "Found an item?";
            // 
            // RelatedidTextbox
            // 
            RelatedidTextbox.Location = new Point(135, 261);
            RelatedidTextbox.Name = "RelatedidTextbox";
            RelatedidTextbox.Size = new Size(255, 27);
            RelatedidTextbox.TabIndex = 7;
            RelatedidTextbox.TextChanged += RelatedidTextbox_TextChanged;
            // 
            // ItemnameTextbox
            // 
            ItemnameTextbox.Location = new Point(135, 103);
            ItemnameTextbox.Name = "ItemnameTextbox";
            ItemnameTextbox.Size = new Size(255, 27);
            ItemnameTextbox.TabIndex = 5;
            ItemnameTextbox.TextChanged += ItemnameTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 174);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter your query:";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 250);
            label6.Name = "label6";
            label6.Size = new Size(18, 20);
            label6.TabIndex = 6;
            label6.Text = "...";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1232, 618);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox RelatedidTextbox;
        private TextBox ItemnameTextbox;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button post;
        private ComboBox comboBox1;
        private Label label6;
        private Label DescriptionLabel;
        private TextBox DesccriptionTextbox;
    }
}