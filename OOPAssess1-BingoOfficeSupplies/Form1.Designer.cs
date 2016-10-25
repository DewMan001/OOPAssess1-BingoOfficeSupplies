namespace OOPAssess1_BingoOfficeSupplies
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
            this.lBox_ProductsDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgBox_Display = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SalePrice = new System.Windows.Forms.Label();
            this.oFileDLG_GetFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.txt_AmountOrdered = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // lBox_ProductsDisplay
            // 
            this.lBox_ProductsDisplay.FormattingEnabled = true;
            this.lBox_ProductsDisplay.ItemHeight = 20;
            this.lBox_ProductsDisplay.Location = new System.Drawing.Point(12, 34);
            this.lBox_ProductsDisplay.Name = "lBox_ProductsDisplay";
            this.lBox_ProductsDisplay.Size = new System.Drawing.Size(182, 284);
            this.lBox_ProductsDisplay.TabIndex = 0;
            this.lBox_ProductsDisplay.SelectedIndexChanged += new System.EventHandler(this.lBox_ProductsDisplay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Product";
            // 
            // imgBox_Display
            // 
            this.imgBox_Display.Location = new System.Drawing.Point(356, 34);
            this.imgBox_Display.Name = "imgBox_Display";
            this.imgBox_Display.Size = new System.Drawing.Size(280, 195);
            this.imgBox_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox_Display.TabIndex = 2;
            this.imgBox_Display.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // lbl_SalePrice
            // 
            this.lbl_SalePrice.AutoSize = true;
            this.lbl_SalePrice.Location = new System.Drawing.Point(497, 232);
            this.lbl_SalePrice.Name = "lbl_SalePrice";
            this.lbl_SalePrice.Size = new System.Drawing.Size(139, 20);
            this.lbl_SalePrice.TabIndex = 4;
            this.lbl_SalePrice.Text = "<PRICE_VALUE>";
            // 
            // oFileDLG_GetFile
            // 
            this.oFileDLG_GetFile.FileName = "openFileDialog1";
            // 
            // btn_Sale
            // 
            this.btn_Sale.Location = new System.Drawing.Point(356, 283);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(280, 35);
            this.btn_Sale.TabIndex = 5;
            this.btn_Sale.Text = "Sell Product";
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // txt_AmountOrdered
            // 
            this.txt_AmountOrdered.Location = new System.Drawing.Point(486, 255);
            this.txt_AmountOrdered.Name = "txt_AmountOrdered";
            this.txt_AmountOrdered.Size = new System.Drawing.Size(150, 26);
            this.txt_AmountOrdered.TabIndex = 6;
            this.txt_AmountOrdered.Text = "1";
            this.txt_AmountOrdered.TextChanged += new System.EventHandler(this.txt_AmountOrdered_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount Ordered:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_AmountOrdered);
            this.Controls.Add(this.btn_Sale);
            this.Controls.Add(this.lbl_SalePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgBox_Display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox_ProductsDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox_ProductsDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBox_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SalePrice;
        private System.Windows.Forms.OpenFileDialog oFileDLG_GetFile;
        private System.Windows.Forms.Button btn_Sale;
        private System.Windows.Forms.TextBox txt_AmountOrdered;
        private System.Windows.Forms.Label label3;
    }
}

