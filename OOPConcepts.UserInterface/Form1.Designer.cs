namespace OOPConcepts.UserInterface
{
    partial class frmDate
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
            label2 = new Label();
            label3 = new Label();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            pictureBox1 = new PictureBox();
            btnValidate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(264, 231);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(264, 309);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Month:";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(264, 389);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "Day:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(392, 228);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Enter the Year.....";
            txtYear.Size = new Size(166, 23);
            txtYear.TabIndex = 3;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(392, 309);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Enter the Month.....";
            txtMonth.Size = new Size(166, 23);
            txtMonth.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(392, 398);
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "Enter the Day.....";
            txtDay.Size = new Size(166, 23);
            txtDay.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.oop;
            pictureBox1.Location = new Point(251, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnValidate
            // 
            btnValidate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnValidate.Location = new Point(264, 439);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(294, 28);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // frmDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnValidate);
            Controls.Add(pictureBox1);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDate";
            Text = "Date";
           
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtDay;
        private PictureBox pictureBox1;
        private Button btnValidate;
    }
}