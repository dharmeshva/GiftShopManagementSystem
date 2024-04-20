namespace GiftShopManagementSystem
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Save_button = new Button();
            Edit_button = new Button();
            Delete_button = new Button();
            Reset_button = new Button();
            dataGridView1 = new DataGridView();
            Price = new TextBox();
            Quantity = new TextBox();
            Productname = new TextBox();
            label6 = new Label();
            PCatCbSearch = new ComboBox();
            Refresh_button = new Button();
            BCatCb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(448, 12);
            button4.Name = "button4";
            button4.Size = new Size(119, 37);
            button4.TabIndex = 7;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(302, 12);
            button3.Name = "button3";
            button3.Size = new Size(119, 37);
            button3.TabIndex = 6;
            button3.Text = "Sell";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(119, 37);
            button2.TabIndex = 5;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(151, 12);
            button1.Name = "button1";
            button1.Size = new Size(125, 37);
            button1.TabIndex = 4;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1050, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(530, 59);
            label1.Name = "label1";
            label1.Size = new Size(247, 42);
            label1.TabIndex = 9;
            label1.Text = "Add New Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 125);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 10;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(402, 125);
            label3.Name = "label3";
            label3.Size = new Size(109, 26);
            label3.TabIndex = 11;
            label3.Text = "Categories";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(671, 125);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(991, 125);
            label5.Name = "label5";
            label5.Size = new Size(59, 26);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // Save_button
            // 
            Save_button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_button.Location = new Point(283, 226);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(119, 37);
            Save_button.TabIndex = 18;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // Edit_button
            // 
            Edit_button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_button.Location = new Point(473, 226);
            Edit_button.Name = "Edit_button";
            Edit_button.Size = new Size(119, 37);
            Edit_button.TabIndex = 19;
            Edit_button.Text = "Edit";
            Edit_button.UseVisualStyleBackColor = true;
            Edit_button.Click += Edit_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_button.Location = new Point(682, 226);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(119, 37);
            Delete_button.TabIndex = 20;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            // 
            // Reset_button
            // 
            Reset_button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reset_button.Location = new Point(857, 226);
            Reset_button.Name = "Reset_button";
            Reset_button.Size = new Size(119, 37);
            Reset_button.TabIndex = 21;
            Reset_button.Text = "Reset";
            Reset_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1236, 373);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Price
            // 
            Price.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.Location = new Point(901, 165);
            Price.Name = "Price";
            Price.Size = new Size(216, 30);
            Price.TabIndex = 23;
            // 
            // Quantity
            // 
            Quantity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(607, 165);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(216, 30);
            Quantity.TabIndex = 24;
            // 
            // Productname
            // 
            Productname.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Productname.Location = new Point(64, 165);
            Productname.Name = "Productname";
            Productname.Size = new Size(216, 30);
            Productname.TabIndex = 25;
            Productname.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 315);
            label6.Name = "label6";
            label6.Size = new Size(160, 34);
            label6.TabIndex = 26;
            label6.Text = "Product List";
            // 
            // PCatCbSearch
            // 
            PCatCbSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PCatCbSearch.FormattingEnabled = true;
            PCatCbSearch.Location = new Point(302, 322);
            PCatCbSearch.Name = "PCatCbSearch";
            PCatCbSearch.Size = new Size(251, 30);
            PCatCbSearch.TabIndex = 27;
            PCatCbSearch.Text = "Filter By Product";
            // 
            // Refresh_button
            // 
            Refresh_button.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refresh_button.Location = new Point(658, 322);
            Refresh_button.Name = "Refresh_button";
            Refresh_button.Size = new Size(119, 37);
            Refresh_button.TabIndex = 28;
            Refresh_button.Text = "Refresh";
            Refresh_button.UseVisualStyleBackColor = true;
            Refresh_button.Click += button9_Click;
            // 
            // BCatCb
            // 
            BCatCb.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BCatCb.FormattingEnabled = true;
            BCatCb.Location = new Point(341, 165);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(251, 30);
            BCatCb.TabIndex = 29;
            BCatCb.Text = "Select Category";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 769);
            Controls.Add(BCatCb);
            Controls.Add(Refresh_button);
            Controls.Add(PCatCbSearch);
            Controls.Add(label6);
            Controls.Add(Productname);
            Controls.Add(Quantity);
            Controls.Add(Price);
            Controls.Add(dataGridView1);
            Controls.Add(Reset_button);
            Controls.Add(Delete_button);
            Controls.Add(Edit_button);
            Controls.Add(Save_button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Products";
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Categoriesname;
        private Button Save_button;
        private Button Edit_button;
        private Button Delete_button;
        private Button Reset_button;
        private DataGridView dataGridView1;
        private TextBox Price;
        private TextBox Quantity;
        private TextBox Productname;
        private Label label6;
        private ComboBox PCatCbSearch;
        private Button Refresh_button;
        private ComboBox BCatCb;
    }
}