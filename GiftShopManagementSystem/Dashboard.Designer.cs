namespace GiftShopManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Bouquet = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(36, 35);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 0;
            button1.Text = "Products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(185, 35);
            button2.Name = "button2";
            button2.Size = new Size(119, 37);
            button2.TabIndex = 1;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(326, 35);
            button3.Name = "button3";
            button3.Size = new Size(119, 37);
            button3.TabIndex = 2;
            button3.Text = "Sell";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(472, 35);
            button4.Name = "button4";
            button4.Size = new Size(119, 37);
            button4.TabIndex = 3;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 117);
            label1.Name = "label1";
            label1.Size = new Size(651, 53);
            label1.TabIndex = 4;
            label1.Text = "Gift Shop Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1015, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Bouquet);
            panel1.Location = new Point(118, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 437);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(315, 317);
            label5.Name = "label5";
            label5.Size = new Size(37, 42);
            label5.TabIndex = 7;
            label5.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(315, 186);
            label8.Name = "label8";
            label8.Size = new Size(37, 42);
            label8.TabIndex = 6;
            label8.Text = "0";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(315, 58);
            label4.Name = "label4";
            label4.Size = new Size(37, 42);
            label4.TabIndex = 3;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(49, 317);
            label3.Name = "label3";
            label3.Size = new Size(144, 39);
            label3.TabIndex = 2;
            label3.Text = "Perfumes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(49, 186);
            label2.Name = "label2";
            label2.Size = new Size(158, 39);
            label2.TabIndex = 1;
            label2.Text = "Gift Cards";
            // 
            // Bouquet
            // 
            Bouquet.AutoSize = true;
            Bouquet.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bouquet.ForeColor = SystemColors.ButtonFace;
            Bouquet.Location = new Point(49, 58);
            Bouquet.Name = "Bouquet";
            Bouquet.Size = new Size(131, 39);
            Bouquet.TabIndex = 0;
            Bouquet.Text = "Bouquet";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(812, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 202);
            panel2.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(51, 49);
            label7.Name = "label7";
            label7.Size = new Size(171, 39);
            label7.TabIndex = 9;
            label7.Text = "Total Users";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(125, 112);
            label6.Name = "label6";
            label6.Size = new Size(37, 42);
            label6.TabIndex = 8;
            label6.Text = "0";
            label6.Click += label6_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 707);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label Bouquet;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}