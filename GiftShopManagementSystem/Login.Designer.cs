
namespace GiftShopManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernamebox = new TextBox();
            passwordbox = new TextBox();
            loginbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 637);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(584, 62);
            label1.Name = "label1";
            label1.Size = new Size(653, 55);
            label1.TabIndex = 1;
            label1.Text = "Gift Shop Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(612, 268);
            label2.Name = "label2";
            label2.Size = new Size(135, 34);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(612, 342);
            label3.Name = "label3";
            label3.Size = new Size(128, 34);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // usernamebox
            // 
            usernamebox.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamebox.Location = new Point(796, 268);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(303, 39);
            usernamebox.TabIndex = 4;
            usernamebox.TextChanged += usernamebox_TextChanged;
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbox.Location = new Point(796, 342);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(303, 39);
            passwordbox.TabIndex = 5;
            passwordbox.TextChanged += passwordbox_TextChanged;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(871, 475);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(152, 52);
            loginbutton.TabIndex = 6;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 632);
            Controls.Add(loginbutton);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernamebox;
        private TextBox passwordbox;
        private Button loginbutton;
    }
}
