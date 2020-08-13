namespace BTM495
{
    partial class Notifications
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
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.youlayOut = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(13)))));
            this.notificationsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.notificationsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsLabel.ForeColor = System.Drawing.Color.White;
            this.notificationsLabel.Location = new System.Drawing.Point(0, 0);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(696, 43);
            this.notificationsLabel.TabIndex = 2;
            this.notificationsLabel.Text = "NOTIFICATIONS";
            this.notificationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // youlayOut
            // 
            this.youlayOut.AutoSize = true;
            this.youlayOut.ColumnCount = 1;
            this.youlayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.53755F));
            this.youlayOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.46245F));
            this.youlayOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.youlayOut.Location = new System.Drawing.Point(0, 43);
            this.youlayOut.Name = "youlayOut";
            this.youlayOut.RowCount = 2;
            this.youlayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.youlayOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.youlayOut.Size = new System.Drawing.Size(696, 0);
            this.youlayOut.TabIndex = 3;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(696, 470);
            this.Controls.Add(this.youlayOut);
            this.Controls.Add(this.notificationsLabel);
            this.Name = "Notifications";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AvailableInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.TableLayoutPanel youlayOut;
    }
}