namespace BTM495
{
    partial class MissingProducts
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
            this.MissingDataGridView = new System.Windows.Forms.DataGridView();
            this.missingProductsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MissingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MissingDataGridView
            // 
            this.MissingDataGridView.AllowUserToAddRows = false;
            this.MissingDataGridView.AllowUserToDeleteRows = false;
            this.MissingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MissingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(232)))));
            this.MissingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MissingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MissingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MissingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MissingDataGridView.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.MissingDataGridView.Location = new System.Drawing.Point(0, 43);
            this.MissingDataGridView.Name = "MissingDataGridView";
            this.MissingDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.MissingDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.MissingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MissingDataGridView.Size = new System.Drawing.Size(696, 427);
            this.MissingDataGridView.TabIndex = 2;
            // 
            // missingProductsLabel
            // 
            this.missingProductsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            this.missingProductsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.missingProductsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.missingProductsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingProductsLabel.ForeColor = System.Drawing.Color.White;
            this.missingProductsLabel.Location = new System.Drawing.Point(0, 0);
            this.missingProductsLabel.Name = "missingProductsLabel";
            this.missingProductsLabel.Size = new System.Drawing.Size(696, 43);
            this.missingProductsLabel.TabIndex = 4;
            this.missingProductsLabel.Text = "MISSING PRODUCTS";
            this.missingProductsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MissingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 470);
            this.Controls.Add(this.MissingDataGridView);
            this.Controls.Add(this.missingProductsLabel);
            this.Name = "MissingProducts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MissingProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MissingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MissingDataGridView;
        private System.Windows.Forms.Label missingProductsLabel;
    }
}