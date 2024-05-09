namespace MachineLearn
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
            label1 = new Label();
            button1 = new Button();
            Review = new TextBox();
            ReviewsBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 38);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "My first ML Program";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(80, 187);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Review
            // 
            Review.Location = new Point(234, 187);
            Review.Name = "Review";
            Review.Size = new Size(252, 27);
            Review.TabIndex = 3;
            // 
            // ReviewsBox
            // 
            ReviewsBox.Location = new Point(234, 237);
            ReviewsBox.Name = "ReviewsBox";
            ReviewsBox.Size = new Size(252, 120);
            ReviewsBox.TabIndex = 4;
            ReviewsBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReviewsBox);
            Controls.Add(Review);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MachineLearning";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox Review;
        private RichTextBox ReviewsBox;
    }
}