namespace BTM495
{
    partial class AvailableInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.inventoryMgmtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsDataGridView.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.ProductsDataGridView.Location = new System.Drawing.Point(0, 43);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ProductsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(696, 427);
            this.ProductsDataGridView.TabIndex = 1;
            // 
            // inventoryMgmtLabel
            // 
            this.inventoryMgmtLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            this.inventoryMgmtLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryMgmtLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryMgmtLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryMgmtLabel.ForeColor = System.Drawing.Color.White;
            this.inventoryMgmtLabel.Location = new System.Drawing.Point(0, 0);
            this.inventoryMgmtLabel.Name = "inventoryMgmtLabel";
            this.inventoryMgmtLabel.Size = new System.Drawing.Size(696, 43);
            this.inventoryMgmtLabel.TabIndex = 2;
            this.inventoryMgmtLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.inventoryMgmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(696, 470);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.inventoryMgmtLabel);
            this.Name = "AvailableInventory";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AvailableInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Label inventoryMgmtLabel;
    }
}