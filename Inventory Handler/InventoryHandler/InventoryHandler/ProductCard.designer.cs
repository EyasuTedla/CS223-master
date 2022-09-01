namespace InventoryHandler
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_invNumber = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(14, 22);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(89, 23);
            this.lbl_productName.TabIndex = 0;
            this.lbl_productName.Text = "Product";
            // 
            // lbl_invNumber
            // 
            this.lbl_invNumber.AutoSize = true;
            this.lbl_invNumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invNumber.Location = new System.Drawing.Point(13, 67);
            this.lbl_invNumber.Name = "lbl_invNumber";
            this.lbl_invNumber.Size = new System.Drawing.Size(100, 18);
            this.lbl_invNumber.TabIndex = 1;
            this.lbl_invNumber.Text = "Inv. Number";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(13, 104);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(45, 18);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_invNumber);
            this.Controls.Add(this.lbl_productName);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(124, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_invNumber;
        private System.Windows.Forms.Label lbl_price;
    }
}
