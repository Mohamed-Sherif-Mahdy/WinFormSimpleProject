namespace WinFormsApp4
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
            connect = new Button();
            textBox_id = new TextBox();
            textBox_productname = new TextBox();
            textBox_location = new TextBox();
            textBox_description = new TextBox();
            textBox_price = new TextBox();
            textBox_quantity = new TextBox();
            submit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Delete = new Button();
            button1 = new Button();
            Update = new Button();
            SuspendLayout();
            // 
            // connect
            // 
            connect.Location = new Point(326, 70);
            connect.Name = "connect";
            connect.Size = new Size(94, 29);
            connect.TabIndex = 0;
            connect.Text = "connect";
            connect.UseVisualStyleBackColor = true;
            connect.Click += connect_Click;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(124, 170);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(125, 27);
            textBox_id.TabIndex = 1;
            textBox_id.TextChanged += textBox1_TextChanged;
            // 
            // textBox_productname
            // 
            textBox_productname.Location = new Point(124, 206);
            textBox_productname.Name = "textBox_productname";
            textBox_productname.Size = new Size(125, 27);
            textBox_productname.TabIndex = 2;
            textBox_productname.TextChanged += textBox2_TextChanged;
            // 
            // textBox_location
            // 
            textBox_location.Location = new Point(124, 239);
            textBox_location.Name = "textBox_location";
            textBox_location.Size = new Size(125, 27);
            textBox_location.TabIndex = 3;
            textBox_location.TextChanged += textBox3_TextChanged;
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(124, 272);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(125, 27);
            textBox_description.TabIndex = 4;
            textBox_description.TextChanged += textBox4_TextChanged;
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(124, 305);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(125, 27);
            textBox_price.TabIndex = 5;
            textBox_price.TextChanged += textBox5_TextChanged;
            // 
            // textBox_quantity
            // 
            textBox_quantity.Location = new Point(124, 338);
            textBox_quantity.Name = "textBox_quantity";
            textBox_quantity.Size = new Size(125, 27);
            textBox_quantity.TabIndex = 6;
            textBox_quantity.TextChanged += textBox6_TextChanged;
            // 
            // submit
            // 
            submit.Location = new Point(453, 233);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 7;
            submit.Text = "ADD";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 170);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 8;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 209);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 9;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 239);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 10;
            label3.Text = "locationID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 11;
            label4.Text = "Describtion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 305);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 12;
            label5.Text = "price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 338);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Quantity ";
            // 
            // Delete
            // 
            Delete.Location = new Point(453, 268);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 14;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(453, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Update
            // 
            Update.Location = new Point(453, 305);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 16;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Update);
            Controls.Add(button1);
            Controls.Add(Delete);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submit);
            Controls.Add(textBox_quantity);
            Controls.Add(textBox_price);
            Controls.Add(textBox_description);
            Controls.Add(textBox_location);
            Controls.Add(textBox_productname);
            Controls.Add(textBox_id);
            Controls.Add(connect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connect;
        private TextBox textBox_id;
        private TextBox textBox_productname;
        private TextBox textBox_location;
        private TextBox textBox_description;
        private TextBox textBox_price;
        private TextBox textBox_quantity;
        private Button submit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Delete;
        private Button button1;
        private Button Update;
    }
}
