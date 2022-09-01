namespace InventoryHandler
{
    partial class Search
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.txt_SearchQuery = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_ItemNumber = new System.Windows.Forms.TextBox();
            this.txt_InvNumber = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_ItemNumber = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_InventoryNumber = new System.Windows.Forms.Label();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(21, 24);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_SearchQuery
            // 
            this.txt_SearchQuery.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchQuery.Location = new System.Drawing.Point(376, 24);
            this.txt_SearchQuery.Name = "txt_SearchQuery";
            this.txt_SearchQuery.Size = new System.Drawing.Size(297, 26);
            this.txt_SearchQuery.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(679, 26);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_Date, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_Price, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Count, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_ItemNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_InvNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Price, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ItemNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Count, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_InventoryNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ItemName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 333);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Date.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Location = new System.Drawing.Point(293, 291);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(218, 25);
            this.txt_Date.TabIndex = 11;
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Price.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(293, 235);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(218, 25);
            this.txt_Price.TabIndex = 10;
            // 
            // txt_Count
            // 
            this.txt_Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Count.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Count.Location = new System.Drawing.Point(293, 180);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(218, 25);
            this.txt_Count.TabIndex = 9;
            // 
            // txt_ItemNumber
            // 
            this.txt_ItemNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ItemNumber.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemNumber.Location = new System.Drawing.Point(293, 125);
            this.txt_ItemNumber.Name = "txt_ItemNumber";
            this.txt_ItemNumber.Size = new System.Drawing.Size(218, 25);
            this.txt_ItemNumber.TabIndex = 8;
            // 
            // txt_InvNumber
            // 
            this.txt_InvNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_InvNumber.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvNumber.Location = new System.Drawing.Point(293, 70);
            this.txt_InvNumber.Name = "txt_InvNumber";
            this.txt_InvNumber.Size = new System.Drawing.Size(218, 25);
            this.txt_InvNumber.TabIndex = 7;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(107, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(53, 18);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(110, 238);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(48, 18);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_ItemNumber
            // 
            this.lbl_ItemNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ItemNumber.AutoSize = true;
            this.lbl_ItemNumber.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemNumber.Location = new System.Drawing.Point(77, 128);
            this.lbl_ItemNumber.Name = "lbl_ItemNumber";
            this.lbl_ItemNumber.Size = new System.Drawing.Size(113, 18);
            this.lbl_ItemNumber.TabIndex = 2;
            this.lbl_ItemNumber.Text = "Item Number";
            // 
            // lbl_Count
            // 
            this.lbl_Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(107, 183);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(54, 18);
            this.lbl_Count.TabIndex = 3;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(112, 295);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(43, 18);
            this.lbl_Date.TabIndex = 5;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_InventoryNumber
            // 
            this.lbl_InventoryNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_InventoryNumber.AutoSize = true;
            this.lbl_InventoryNumber.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InventoryNumber.Location = new System.Drawing.Point(57, 73);
            this.lbl_InventoryNumber.Name = "lbl_InventoryNumber";
            this.lbl_InventoryNumber.Size = new System.Drawing.Size(153, 18);
            this.lbl_InventoryNumber.TabIndex = 1;
            this.lbl_InventoryNumber.Text = "Inventory Number";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ItemName.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(293, 15);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(218, 25);
            this.txt_ItemName.TabIndex = 6;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchQuery);
            this.Controls.Add(this.btn_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_SearchQuery;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_ItemNumber;
        private System.Windows.Forms.TextBox txt_InvNumber;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_ItemNumber;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_InventoryNumber;
        private System.Windows.Forms.TextBox txt_ItemName;
    }
}