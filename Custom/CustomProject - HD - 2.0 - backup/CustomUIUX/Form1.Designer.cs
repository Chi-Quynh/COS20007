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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            Form = new GroupBox();
            RelatedidTextbox = new TextBox();
            DescriptionLabel = new Label();
            ItemnameTextbox = new TextBox();
            DesccriptionTextbox = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            post = new Button();
            label3 = new Label();
            label5 = new Label();
            getListBindingSource = new BindingSource(components);
            locationListBindingSource = new BindingSource(components);
            locationListBindingSource1 = new BindingSource(components);
            iDsBindingSource = new BindingSource(components);
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            button4 = new Button();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)getListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationListBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iDsBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(472, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // Form
            // 
            Form.BackColor = Color.White;
            Form.Controls.Add(RelatedidTextbox);
            Form.Controls.Add(DescriptionLabel);
            Form.Controls.Add(ItemnameTextbox);
            Form.Controls.Add(DesccriptionTextbox);
            Form.Controls.Add(label2);
            Form.Controls.Add(comboBox1);
            Form.Controls.Add(label4);
            Form.Controls.Add(post);
            Form.Controls.Add(label3);
            Form.Controls.Add(label5);
            Form.Location = new Point(309, 66);
            Form.Name = "Form";
            Form.Size = new Size(523, 461);
            Form.TabIndex = 7;
            Form.TabStop = false;
            Form.Text = " ";
            Form.Enter += Form_Enter;
            // 
            // RelatedidTextbox
            // 
            RelatedidTextbox.Location = new Point(158, 267);
            RelatedidTextbox.Name = "RelatedidTextbox";
            RelatedidTextbox.Size = new Size(255, 27);
            RelatedidTextbox.TabIndex = 7;
            RelatedidTextbox.TextChanged += RelatedidTextbox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(46, 160);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(96, 23);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description";
            // 
            // ItemnameTextbox
            // 
            ItemnameTextbox.Location = new Point(158, 109);
            ItemnameTextbox.Name = "ItemnameTextbox";
            ItemnameTextbox.Size = new Size(255, 27);
            ItemnameTextbox.TabIndex = 5;
            ItemnameTextbox.TextChanged += ItemnameTextbox_TextChanged;
            // 
            // DesccriptionTextbox
            // 
            DesccriptionTextbox.Location = new Point(158, 157);
            DesccriptionTextbox.Name = "DesccriptionTextbox";
            DesccriptionTextbox.Size = new Size(255, 27);
            DesccriptionTextbox.TabIndex = 10;
            DesccriptionTextbox.TextChanged += DesccriptionTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 48);
            label2.Name = "label2";
            label2.Size = new Size(230, 41);
            label2.TabIndex = 6;
            label2.Text = "Found an item?";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(262, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 271);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 7;
            label4.Text = "Related ids";
            // 
            // post
            // 
            post.Location = new Point(310, 320);
            post.Name = "post";
            post.Size = new Size(94, 29);
            post.TabIndex = 6;
            post.Text = "Post";
            post.UseVisualStyleBackColor = true;
            post.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 112);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 6;
            label3.Text = "Item name*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 213);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 8;
            label5.Text = "Location (select)*";
            // 
            // getListBindingSource
            // 
            getListBindingSource.DataMember = "GetList";
            getListBindingSource.DataSource = locationListBindingSource;
            // 
            // locationListBindingSource
            // 
            locationListBindingSource.DataSource = typeof(CustomProject.LocationList);
            // 
            // locationListBindingSource1
            // 
            locationListBindingSource1.DataSource = typeof(CustomProject.LocationList);
            // 
            // iDsBindingSource
            // 
            iDsBindingSource.DataMember = "IDs";
            iDsBindingSource.DataSource = getListBindingSource;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Form);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 89);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(203, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1243, 627);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(29, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 461);
            panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(121, 38);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 21);
            label6.Name = "label6";
            label6.Size = new Size(21, 20);
            label6.TabIndex = 7;
            label6.Text = "....";
            label6.Click += label6_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(665, 517);
            button2.Name = "button2";
            button2.Size = new Size(523, 85);
            button2.TabIndex = 7;
            button2.Text = "Click to change form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(665, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 461);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form2";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 160);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 11;
            label7.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(158, 48);
            label8.Name = "label8";
            label8.Size = new Size(200, 41);
            label8.TabIndex = 6;
            label8.Text = "Lost an item?";
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(262, 213);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(43, 271);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 7;
            label9.Text = "Related id";
            label9.Click += label9_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(310, 320);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Retrieve";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(46, 112);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 6;
            label10.Text = "Item name*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(43, 213);
            label11.Name = "label11";
            label11.Size = new Size(140, 23);
            label11.TabIndex = 8;
            label11.Text = "Location (select)*";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged_2;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1232, 619);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            Form.ResumeLayout(false);
            Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)getListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationListBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iDsBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private GroupBox Form;
        private TextBox RelatedidTextbox;
        private Label DescriptionLabel;
        private TextBox ItemnameTextbox;
        private TextBox DesccriptionTextbox;
        private Label label2;
        private ComboBox comboBox1;
        private Label label4;
        private Button post;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label6;
        private GroupBox groupBox1;
        private Button button2;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private Button button4;
        private Label label10;
        private Label label11;
        private BindingSource locationListBindingSource;
        private BindingSource getListBindingSource;
        private BindingSource iDsBindingSource;
        private BindingSource locationListBindingSource1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
    }
}