namespace InventoryHandler
{
    partial class Inventory
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_inventoryNumber = new System.Windows.Forms.Label();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_itemCount = new System.Windows.Forms.Label();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_batch = new System.Windows.Forms.RadioButton();
            this.rad_single = new System.Windows.Forms.RadioButton();
            this.clbox_deliveryDate = new System.Windows.Forms.CheckedListBox();
            this.cbox_checked = new System.Windows.Forms.CheckBox();
            this.cbox_approved = new System.Windows.Forms.CheckBox();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_itemNumber = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.dtp_dateReg = new System.Windows.Forms.DateTimePicker();
            this.txt_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_itemCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(789, 38);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(71, 29);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "User";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.Location = new System.Drawing.Point(51, 64);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(126, 23);
            this.lbl_number.TabIndex = 1;
            this.lbl_number.Text = "Item Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(290, 64);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 23);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date";
            // 
            // lbl_inventoryNumber
            // 
            this.lbl_inventoryNumber.AutoSize = true;
            this.lbl_inventoryNumber.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventoryNumber.Location = new System.Drawing.Point(531, 64);
            this.lbl_inventoryNumber.Name = "lbl_inventoryNumber";
            this.lbl_inventoryNumber.Size = new System.Drawing.Size(167, 23);
            this.lbl_inventoryNumber.TabIndex = 3;
            this.lbl_inventoryNumber.Text = "Inventory Number";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(48, 147);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(106, 23);
            this.lbl_itemName.TabIndex = 4;
            this.lbl_itemName.Text = "Item Name";
            // 
            // lbl_itemCount
            // 
            this.lbl_itemCount.AutoSize = true;
            this.lbl_itemCount.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCount.Location = new System.Drawing.Point(290, 147);
            this.lbl_itemCount.Name = "lbl_itemCount";
            this.lbl_itemCount.Size = new System.Drawing.Size(106, 23);
            this.lbl_itemCount.TabIndex = 5;
            this.lbl_itemCount.Text = "Item Count";
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(531, 147);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(99, 23);
            this.lbl_itemPrice.TabIndex = 6;
            this.lbl_itemPrice.Text = "Item Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_batch);
            this.groupBox1.Controls.Add(this.rad_single);
            this.groupBox1.Location = new System.Drawing.Point(52, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rad_batch
            // 
            this.rad_batch.AutoSize = true;
            this.rad_batch.Location = new System.Drawing.Point(107, 26);
            this.rad_batch.Name = "rad_batch";
            this.rad_batch.Size = new System.Drawing.Size(53, 17);
            this.rad_batch.TabIndex = 1;
            this.rad_batch.TabStop = true;
            this.rad_batch.Text = "Batch";
            this.rad_batch.UseVisualStyleBackColor = true;
            this.rad_batch.CheckedChanged += new System.EventHandler(this.rad_batch_CheckedChanged);
            // 
            // rad_single
            // 
            this.rad_single.AutoSize = true;
            this.rad_single.Location = new System.Drawing.Point(26, 26);
            this.rad_single.Name = "rad_single";
            this.rad_single.Size = new System.Drawing.Size(54, 17);
            this.rad_single.TabIndex = 0;
            this.rad_single.TabStop = true;
            this.rad_single.Text = "Single";
            this.rad_single.UseVisualStyleBackColor = true;
            this.rad_single.CheckedChanged += new System.EventHandler(this.rad_single_CheckedChanged);
            // 
            // clbox_deliveryDate
            // 
            this.clbox_deliveryDate.FormattingEnabled = true;
            this.clbox_deliveryDate.Items.AddRange(new object[] {
            "Today - Express ",
            "In a Day - Best Offer",
            "Within 72 Hours - Popular",
            "This Week - Base Offer",
            "Custom (BETA)"});
            this.clbox_deliveryDate.Location = new System.Drawing.Point(52, 298);
            this.clbox_deliveryDate.Name = "clbox_deliveryDate";
            this.clbox_deliveryDate.Size = new System.Drawing.Size(186, 79);
            this.clbox_deliveryDate.TabIndex = 8;
            // 
            // cbox_checked
            // 
            this.cbox_checked.AutoSize = true;
            this.cbox_checked.Location = new System.Drawing.Point(294, 360);
            this.cbox_checked.Name = "cbox_checked";
            this.cbox_checked.Size = new System.Drawing.Size(69, 17);
            this.cbox_checked.TabIndex = 9;
            this.cbox_checked.Text = "Checked";
            this.cbox_checked.UseVisualStyleBackColor = true;
            // 
            // cbox_approved
            // 
            this.cbox_approved.AutoSize = true;
            this.cbox_approved.Location = new System.Drawing.Point(390, 360);
            this.cbox_approved.Name = "cbox_approved";
            this.cbox_approved.Size = new System.Drawing.Size(72, 17);
            this.cbox_approved.TabIndex = 10;
            this.cbox_approved.Text = "Approved";
            this.cbox_approved.UseVisualStyleBackColor = true;
            // 
            // dgv_output
            // 
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Location = new System.Drawing.Point(289, 225);
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.Size = new System.Drawing.Size(571, 101);
            this.dgv_output.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(491, 356);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(623, 356);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(752, 356);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_itemNumber
            // 
            this.txt_itemNumber.Location = new System.Drawing.Point(55, 103);
            this.txt_itemNumber.Name = "txt_itemNumber";
            this.txt_itemNumber.Size = new System.Drawing.Size(210, 20);
            this.txt_itemNumber.TabIndex = 16;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(52, 182);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(213, 20);
            this.txt_itemName.TabIndex = 17;
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Location = new System.Drawing.Point(535, 182);
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(123, 20);
            this.txt_itemPrice.TabIndex = 19;
            // 
            // dtp_dateReg
            // 
            this.dtp_dateReg.Location = new System.Drawing.Point(294, 103);
            this.dtp_dateReg.Name = "dtp_dateReg";
            this.dtp_dateReg.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateReg.TabIndex = 21;
            // 
            // txt_inventoryNumber
            // 
            this.txt_inventoryNumber.Location = new System.Drawing.Point(535, 103);
            this.txt_inventoryNumber.Name = "txt_inventoryNumber";
            this.txt_inventoryNumber.Size = new System.Drawing.Size(210, 20);
            this.txt_inventoryNumber.TabIndex = 22;
            // 
            // txt_itemCount
            // 
            this.txt_itemCount.Location = new System.Drawing.Point(294, 182);
            this.txt_itemCount.Name = "txt_itemCount";
            this.txt_itemCount.Size = new System.Drawing.Size(123, 20);
            this.txt_itemCount.TabIndex = 23;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(894, 462);
            this.Controls.Add(this.txt_itemCount);
            this.Controls.Add(this.txt_inventoryNumber);
            this.Controls.Add(this.dtp_dateReg);
            this.Controls.Add(this.txt_itemPrice);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_itemNumber);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_output);
            this.Controls.Add(this.cbox_approved);
            this.Controls.Add(this.cbox_checked);
            this.Controls.Add(this.clbox_deliveryDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_itemPrice);
            this.Controls.Add(this.lbl_itemCount);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_inventoryNumber);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.lbl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_inventoryNumber;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_itemCount;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbox_deliveryDate;
        private System.Windows.Forms.CheckBox cbox_checked;
        private System.Windows.Forms.CheckBox cbox_approved;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RadioButton rad_batch;
        private System.Windows.Forms.RadioButton rad_single;
        private System.Windows.Forms.TextBox txt_itemNumber;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_itemPrice;
        private System.Windows.Forms.DateTimePicker dtp_dateReg;
        private System.Windows.Forms.TextBox txt_inventoryNumber;
        private System.Windows.Forms.TextBox txt_itemCount;
    }
}