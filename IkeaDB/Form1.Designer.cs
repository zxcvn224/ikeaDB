namespace IkeaDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listSeries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            // 
            // listRoom
            // 
            this.listRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listRoom.FormattingEnabled = true;
            this.listRoom.Location = new System.Drawing.Point(64, 190);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(155, 225);
            this.listRoom.TabIndex = 1;
            this.listRoom.SelectedIndexChanged += new System.EventHandler(this.listRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Series";
            // 
            // listSeries
            // 
            this.listSeries.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listSeries.FormattingEnabled = true;
            this.listSeries.Location = new System.Drawing.Point(337, 190);
            this.listSeries.Name = "listSeries";
            this.listSeries.Size = new System.Drawing.Size(193, 225);
            this.listSeries.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 518);
            this.Controls.Add(this.listSeries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listSeries;
    }
}

