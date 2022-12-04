namespace DuAn1_Winform
{
    partial class QL_SanPham
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhảmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuộcTínhXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Ql_SanPham = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhảmToolStripMenuItem,
            this.thuộcTínhXeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2596, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhảmToolStripMenuItem
            // 
            this.sảnPhảmToolStripMenuItem.Name = "sảnPhảmToolStripMenuItem";
            this.sảnPhảmToolStripMenuItem.Size = new System.Drawing.Size(140, 36);
            this.sảnPhảmToolStripMenuItem.Text = "Sản Phẩm";
            this.sảnPhảmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhảmToolStripMenuItem_Click);
            // 
            // thuộcTínhXeToolStripMenuItem
            // 
            this.thuộcTínhXeToolStripMenuItem.Name = "thuộcTínhXeToolStripMenuItem";
            this.thuộcTínhXeToolStripMenuItem.Size = new System.Drawing.Size(188, 36);
            this.thuộcTínhXeToolStripMenuItem.Text = "Thuộc Tính Xe";
            this.thuộcTínhXeToolStripMenuItem.Click += new System.EventHandler(this.thuộcTínhXeToolStripMenuItem_Click);
            // 
            // panel_Ql_SanPham
            // 
            this.panel_Ql_SanPham.Location = new System.Drawing.Point(3, 42);
            this.panel_Ql_SanPham.Name = "panel_Ql_SanPham";
            this.panel_Ql_SanPham.Size = new System.Drawing.Size(2593, 1592);
            this.panel_Ql_SanPham.TabIndex = 11;
            // 
            // QL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2596, 1646);
            this.Controls.Add(this.panel_Ql_SanPham);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "QL_SanPham";
            this.Text = "QL_SanPham";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhảmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuộcTínhXeToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Ql_SanPham;
    }
}