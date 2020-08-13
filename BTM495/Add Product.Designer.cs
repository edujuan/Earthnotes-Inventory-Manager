using System;

namespace BTM495
{
    partial class AddProduct
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.ProductTypeTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(113, 242);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(80, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Add Product";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Black;
            this.quantityLabel.Location = new System.Drawing.Point(56, 180);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(78, 24);
            this.quantityLabel.TabIndex = 12;
            this.quantityLabel.Text = "Quantity";
            // 
            // productIDLabel
            // 
            this.productIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.ForeColor = System.Drawing.Color.Black;
            this.productIDLabel.Location = new System.Drawing.Point(56, 123);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(97, 24);
            this.productIDLabel.TabIndex = 11;
            this.productIDLabel.Text = "Product ID";
            // 
            // ProductTypeTextBox
            // 
            this.ProductTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTypeTextBox.Location = new System.Drawing.Point(160, 123);
            this.ProductTypeTextBox.Name = "ProductTypeTextBox";
            this.ProductTypeTextBox.Size = new System.Drawing.Size(112, 24);
            this.ProductTypeTextBox.TabIndex = 10;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(160, 180);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(112, 24);
            this.QuantityTextBox.TabIndex = 13;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(341, 399);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productIDLabel);
            this.Controls.Add(this.ProductTypeTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Name = "AddProduct";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.TextBox ProductTypeTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
    }
}