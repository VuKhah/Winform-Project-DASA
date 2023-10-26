namespace Winform_Project_DASA
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.cbb_Sort = new System.Windows.Forms.ComboBox();
            this.lb_Search = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.view_Table_Data = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.view_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.view_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_NNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Table_Data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.cbb_Sort);
            this.panel1.Controls.Add(this.lb_Search);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 127);
            this.panel1.TabIndex = 0;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(118, 19);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(364, 30);
            this.tb_Search.TabIndex = 6;
            // 
            // cbb_Sort
            // 
            this.cbb_Sort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Sort.FormattingEnabled = true;
            this.cbb_Sort.Location = new System.Drawing.Point(765, 24);
            this.cbb_Sort.Name = "cbb_Sort";
            this.cbb_Sort.Size = new System.Drawing.Size(176, 30);
            this.cbb_Sort.TabIndex = 5;
            this.cbb_Sort.Text = "SORT";
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.Location = new System.Drawing.Point(31, 24);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(81, 25);
            this.lb_Search.TabIndex = 4;
            this.lb_Search.Text = "Search:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.view_Table_Data);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(968, 334);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // view_Table_Data
            // 
            this.view_Table_Data.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.view_Table_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Table_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.view_image,
            this.view_Name,
            this.view_NSX,
            this.view_hsd,
            this.view_NNK,
            this.view_quantity,
            this.view_price,
            this.view_info});
            this.view_Table_Data.Location = new System.Drawing.Point(3, 3);
            this.view_Table_Data.Name = "view_Table_Data";
            this.view_Table_Data.RowHeadersWidth = 51;
            this.view_Table_Data.RowTemplate.Height = 24;
            this.view_Table_Data.Size = new System.Drawing.Size(965, 331);
            this.view_Table_Data.TabIndex = 0;
            this.view_Table_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_Table_Data_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_Add);
            this.panel2.Controls.Add(this.bt_Delete);
            this.panel2.Controls.Add(this.bt_Save);
            this.panel2.Location = new System.Drawing.Point(25, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 73);
            this.panel2.TabIndex = 1;
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(620, 20);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(92, 36);
            this.bt_Add.TabIndex = 2;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(735, 20);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(92, 36);
            this.bt_Delete.TabIndex = 1;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(849, 20);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(92, 36);
            this.bt_Save.TabIndex = 0;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            // 
            // view_image
            // 
            this.view_image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view_image.DataPropertyName = "image_Item";
            this.view_image.DividerWidth = 2;
            this.view_image.FillWeight = 72F;
            this.view_image.HeaderText = "Image";
            this.view_image.MinimumWidth = 52;
            this.view_image.Name = "view_image";
            this.view_image.Width = 53;
            // 
            // view_Name
            // 
            this.view_Name.DataPropertyName = "name_Item";
            this.view_Name.HeaderText = "Name";
            this.view_Name.MinimumWidth = 6;
            this.view_Name.Name = "view_Name";
            this.view_Name.Width = 125;
            // 
            // view_NSX
            // 
            this.view_NSX.DataPropertyName = "nsx";
            this.view_NSX.HeaderText = "NSX";
            this.view_NSX.MinimumWidth = 6;
            this.view_NSX.Name = "view_NSX";
            this.view_NSX.Width = 102;
            // 
            // view_hsd
            // 
            this.view_hsd.DataPropertyName = "hsd";
            this.view_hsd.HeaderText = "HSD";
            this.view_hsd.MinimumWidth = 6;
            this.view_hsd.Name = "view_hsd";
            this.view_hsd.Width = 102;
            // 
            // view_NNK
            // 
            this.view_NNK.DataPropertyName = "nnk";
            this.view_NNK.HeaderText = "NNK";
            this.view_NNK.MinimumWidth = 6;
            this.view_NNK.Name = "view_NNK";
            this.view_NNK.Width = 102;
            // 
            // view_quantity
            // 
            this.view_quantity.DataPropertyName = "quantity";
            this.view_quantity.HeaderText = "Quantity";
            this.view_quantity.MinimumWidth = 6;
            this.view_quantity.Name = "view_quantity";
            // 
            // view_price
            // 
            this.view_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view_price.DataPropertyName = "price";
            this.view_price.HeaderText = "Price";
            this.view_price.MinimumWidth = 6;
            this.view_price.Name = "view_price";
            this.view_price.Width = 67;
            // 
            // view_info
            // 
            this.view_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view_info.DataPropertyName = "info";
            this.view_info.HeaderText = "Info";
            this.view_info.MinimumWidth = 6;
            this.view_info.Name = "view_info";
            this.view_info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.view_info.Text = "Moves";
            this.view_info.UseColumnTextForButtonValue = true;
            this.view_info.Width = 34;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1023, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Main";
            this.Text = "Project DASA ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_Table_Data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView view_Table_Data;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ComboBox cbb_Sort;
        private System.Windows.Forms.DataGridViewImageColumn view_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_NNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn view_price;
        private System.Windows.Forms.DataGridViewButtonColumn view_info;
    }
}

