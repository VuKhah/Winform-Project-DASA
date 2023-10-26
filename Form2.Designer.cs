namespace Winform_Project_DASA
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_NSX = new System.Windows.Forms.Label();
            this.lb_NNK = new System.Windows.Forms.Label();
            this.lb_HSD = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_quantity = new System.Windows.Forms.Label();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.txb_quantity = new System.Windows.Forms.TextBox();
            this.txb_time_NSX = new System.Windows.Forms.DateTimePicker();
            this.txb_time_HSD = new System.Windows.Forms.DateTimePicker();
            this.txb_time_NNK = new System.Windows.Forms.DateTimePicker();
            this.lb_info = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.panel_image = new System.Windows.Forms.Panel();
            this.txb_info = new System.Windows.Forms.TextBox();
            this.bt_Save_f2 = new System.Windows.Forms.Button();
            this.bt_Edit_f2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txb_info);
            this.panel1.Location = new System.Drawing.Point(26, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 79);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txb_time_NNK);
            this.panel2.Controls.Add(this.txb_time_HSD);
            this.panel2.Controls.Add(this.txb_time_NSX);
            this.panel2.Controls.Add(this.txb_quantity);
            this.panel2.Controls.Add(this.txb_price);
            this.panel2.Controls.Add(this.lb_quantity);
            this.panel2.Controls.Add(this.lb_price);
            this.panel2.Controls.Add(this.lb_HSD);
            this.panel2.Controls.Add(this.lb_NNK);
            this.panel2.Controls.Add(this.lb_NSX);
            this.panel2.Location = new System.Drawing.Point(244, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 206);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_image);
            this.panel3.Controls.Add(this.lb_info);
            this.panel3.Location = new System.Drawing.Point(26, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 206);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(12, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 22);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name:";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_NSX
            // 
            this.lb_NSX.AutoSize = true;
            this.lb_NSX.Location = new System.Drawing.Point(21, 17);
            this.lb_NSX.Name = "lb_NSX";
            this.lb_NSX.Size = new System.Drawing.Size(47, 19);
            this.lb_NSX.TabIndex = 4;
            this.lb_NSX.Text = "NSX:";
            // 
            // lb_NNK
            // 
            this.lb_NNK.AutoSize = true;
            this.lb_NNK.Location = new System.Drawing.Point(21, 90);
            this.lb_NNK.Name = "lb_NNK";
            this.lb_NNK.Size = new System.Drawing.Size(50, 19);
            this.lb_NNK.TabIndex = 5;
            this.lb_NNK.Text = "NNK:";
            this.lb_NNK.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_HSD
            // 
            this.lb_HSD.AutoSize = true;
            this.lb_HSD.Location = new System.Drawing.Point(21, 53);
            this.lb_HSD.Name = "lb_HSD";
            this.lb_HSD.Size = new System.Drawing.Size(47, 19);
            this.lb_HSD.TabIndex = 6;
            this.lb_HSD.Text = "HSD:";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(21, 123);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(51, 19);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "Price:";
            this.lb_price.Click += new System.EventHandler(this.lb_price_Click);
            // 
            // lb_quantity
            // 
            this.lb_quantity.AutoSize = true;
            this.lb_quantity.Location = new System.Drawing.Point(21, 157);
            this.lb_quantity.Name = "lb_quantity";
            this.lb_quantity.Size = new System.Drawing.Size(72, 19);
            this.lb_quantity.TabIndex = 8;
            this.lb_quantity.Text = "Quantity:";
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(100, 120);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(153, 27);
            this.txb_price.TabIndex = 9;
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(100, 154);
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(153, 27);
            this.txb_quantity.TabIndex = 10;
            // 
            // txb_time_NSX
            // 
            this.txb_time_NSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txb_time_NSX.Location = new System.Drawing.Point(100, 9);
            this.txb_time_NSX.Name = "txb_time_NSX";
            this.txb_time_NSX.Size = new System.Drawing.Size(153, 27);
            this.txb_time_NSX.TabIndex = 11;
            // 
            // txb_time_HSD
            // 
            this.txb_time_HSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txb_time_HSD.Location = new System.Drawing.Point(100, 45);
            this.txb_time_HSD.Name = "txb_time_HSD";
            this.txb_time_HSD.Size = new System.Drawing.Size(153, 27);
            this.txb_time_HSD.TabIndex = 12;
            // 
            // txb_time_NNK
            // 
            this.txb_time_NNK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txb_time_NNK.Location = new System.Drawing.Point(100, 82);
            this.txb_time_NNK.Name = "txb_time_NNK";
            this.txb_time_NNK.Size = new System.Drawing.Size(153, 27);
            this.txb_time_NNK.TabIndex = 13;
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(6, 187);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(42, 19);
            this.lb_info.TabIndex = 9;
            this.lb_info.Text = "Info:";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(80, 4);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(153, 27);
            this.txb_name.TabIndex = 10;
            // 
            // panel_image
            // 
            this.panel_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_image.Location = new System.Drawing.Point(22, 17);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(165, 164);
            this.panel_image.TabIndex = 3;
            // 
            // txb_info
            // 
            this.txb_info.Location = new System.Drawing.Point(9, 4);
            this.txb_info.Multiline = true;
            this.txb_info.Name = "txb_info";
            this.txb_info.Size = new System.Drawing.Size(507, 69);
            this.txb_info.TabIndex = 11;
            // 
            // bt_Save_f2
            // 
            this.bt_Save_f2.Location = new System.Drawing.Point(418, 332);
            this.bt_Save_f2.Name = "bt_Save_f2";
            this.bt_Save_f2.Size = new System.Drawing.Size(140, 31);
            this.bt_Save_f2.TabIndex = 11;
            this.bt_Save_f2.Text = "Save";
            this.bt_Save_f2.UseVisualStyleBackColor = true;
            // 
            // bt_Edit_f2
            // 
            this.bt_Edit_f2.Location = new System.Drawing.Point(270, 331);
            this.bt_Edit_f2.Name = "bt_Edit_f2";
            this.bt_Edit_f2.Size = new System.Drawing.Size(140, 31);
            this.bt_Edit_f2.TabIndex = 12;
            this.bt_Edit_f2.Text = "Edit";
            this.bt_Edit_f2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 375);
            this.Controls.Add(this.bt_Edit_f2);
            this.Controls.Add(this.bt_Save_f2);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_HSD;
        private System.Windows.Forms.Label lb_NNK;
        private System.Windows.Forms.Label lb_NSX;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_quantity;
        private System.Windows.Forms.TextBox txb_quantity;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.DateTimePicker txb_time_NNK;
        private System.Windows.Forms.DateTimePicker txb_time_HSD;
        private System.Windows.Forms.DateTimePicker txb_time_NSX;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_info;
        private System.Windows.Forms.Button bt_Save_f2;
        private System.Windows.Forms.Button bt_Edit_f2;
    }
}