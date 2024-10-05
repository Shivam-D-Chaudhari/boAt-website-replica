namespace ADT_project
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1. boAt Rockerz 255",
            "1200"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2. boAt Airdopes 131",
            "900"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3. boAt Rockerz 450",
            "1800"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4. boAt 10000 mAh Power Bank",
            "1350"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5. boAt Stone 190 Bluetooth Speaker",
            "800"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "6. boAt Stone 350 Bluetooth Speaker",
            "1300"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "7. boAt Wave Neo Smart Watch",
            "2000"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Accessories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total_print = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cnsl_btn = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.view_1 = new System.Windows.Forms.Button();
            this.view_2 = new System.Windows.Forms.Button();
            this.view_3 = new System.Windows.Forms.Button();
            this.view_4 = new System.Windows.Forms.Button();
            this.view_5 = new System.Windows.Forms.Button();
            this.view_6 = new System.Windows.Forms.Button();
            this.view_7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Accessories,
            this.price});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listView1.Location = new System.Drawing.Point(88, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 202);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Accessories
            // 
            this.Accessories.Text = "Accessories";
            this.Accessories.Width = 201;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 89;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.price_1,
            this.quantity_1});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(472, 133);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(311, 202);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 130;
            // 
            // price_1
            // 
            this.price_1.DisplayIndex = 2;
            this.price_1.Text = "Price";
            this.price_1.Width = 100;
            // 
            // quantity_1
            // 
            this.quantity_1.DisplayIndex = 1;
            this.quantity_1.Text = "Quantity";
            this.quantity_1.Width = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(474, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Amount";
            // 
            // total_print
            // 
            this.total_print.Location = new System.Drawing.Point(583, 356);
            this.total_print.Name = "total_print";
            this.total_print.Size = new System.Drawing.Size(128, 22);
            this.total_print.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(583, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cnsl_btn
            // 
            this.cnsl_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cnsl_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnsl_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cnsl_btn.Location = new System.Drawing.Point(156, 398);
            this.cnsl_btn.Name = "cnsl_btn";
            this.cnsl_btn.Size = new System.Drawing.Size(120, 38);
            this.cnsl_btn.TabIndex = 6;
            this.cnsl_btn.Text = "Cancel";
            this.cnsl_btn.UseVisualStyleBackColor = false;
            this.cnsl_btn.Click += new System.EventHandler(this.cnsl_btn_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(156, 357);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(120, 22);
            this.txt_quantity.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(409, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 64);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // view_1
            // 
            this.view_1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_1.Location = new System.Drawing.Point(21, 138);
            this.view_1.Name = "view_1";
            this.view_1.Size = new System.Drawing.Size(46, 23);
            this.view_1.TabIndex = 11;
            this.view_1.Text = "1.";
            this.view_1.UseVisualStyleBackColor = false;
            this.view_1.Click += new System.EventHandler(this.view_1_Click);
            // 
            // view_2
            // 
            this.view_2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_2.Location = new System.Drawing.Point(21, 167);
            this.view_2.Name = "view_2";
            this.view_2.Size = new System.Drawing.Size(46, 23);
            this.view_2.TabIndex = 12;
            this.view_2.Text = "2.";
            this.view_2.UseVisualStyleBackColor = false;
            this.view_2.Click += new System.EventHandler(this.view_2_Click);
            // 
            // view_3
            // 
            this.view_3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_3.Location = new System.Drawing.Point(21, 196);
            this.view_3.Name = "view_3";
            this.view_3.Size = new System.Drawing.Size(46, 23);
            this.view_3.TabIndex = 13;
            this.view_3.Text = "3.";
            this.view_3.UseVisualStyleBackColor = false;
            this.view_3.Click += new System.EventHandler(this.view_3_Click);
            // 
            // view_4
            // 
            this.view_4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_4.Location = new System.Drawing.Point(21, 225);
            this.view_4.Name = "view_4";
            this.view_4.Size = new System.Drawing.Size(46, 23);
            this.view_4.TabIndex = 14;
            this.view_4.Text = "4.";
            this.view_4.UseVisualStyleBackColor = false;
            this.view_4.Click += new System.EventHandler(this.view_4_Click);
            // 
            // view_5
            // 
            this.view_5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_5.Location = new System.Drawing.Point(21, 254);
            this.view_5.Name = "view_5";
            this.view_5.Size = new System.Drawing.Size(46, 23);
            this.view_5.TabIndex = 15;
            this.view_5.Text = "5.";
            this.view_5.UseVisualStyleBackColor = false;
            this.view_5.Click += new System.EventHandler(this.view_5_Click);
            // 
            // view_6
            // 
            this.view_6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_6.Location = new System.Drawing.Point(21, 283);
            this.view_6.Name = "view_6";
            this.view_6.Size = new System.Drawing.Size(46, 23);
            this.view_6.TabIndex = 16;
            this.view_6.Text = "6.";
            this.view_6.UseVisualStyleBackColor = false;
            this.view_6.Click += new System.EventHandler(this.view_6_Click);
            // 
            // view_7
            // 
            this.view_7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.view_7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view_7.Location = new System.Drawing.Point(21, 312);
            this.view_7.Name = "view_7";
            this.view_7.Size = new System.Drawing.Size(46, 23);
            this.view_7.TabIndex = 17;
            this.view_7.Text = "7.";
            this.view_7.UseVisualStyleBackColor = false;
            this.view_7.Click += new System.EventHandler(this.view_7_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(17, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 44);
            this.label5.TabIndex = 18;
            this.label5.Text = "view items";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(533, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Done Shopping";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ADT_project.Properties.Resources._2_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(88, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 88);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ADT_project.Properties.Resources.Screenshot_2023_05_09_1356371;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(583, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 42);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ADT_project.Properties.Resources.QjVKLn5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.view_7);
            this.Controls.Add(this.view_6);
            this.Controls.Add(this.view_5);
            this.Controls.Add(this.view_4);
            this.Controls.Add(this.view_3);
            this.Controls.Add(this.view_2);
            this.Controls.Add(this.view_1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.cnsl_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total_print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total_print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cnsl_btn;
        private System.Windows.Forms.NumericUpDown txt_quantity;
        private System.Windows.Forms.ColumnHeader Accessories;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader quantity_1;
        private System.Windows.Forms.ColumnHeader price_1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button view_1;
        private System.Windows.Forms.Button view_2;
        private System.Windows.Forms.Button view_3;
        private System.Windows.Forms.Button view_4;
        private System.Windows.Forms.Button view_5;
        private System.Windows.Forms.Button view_6;
        private System.Windows.Forms.Button view_7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

