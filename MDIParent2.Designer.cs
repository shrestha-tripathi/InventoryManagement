namespace InventoryManagement
{
    partial class MDIParent2
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            productToolStripMenuItem = new ToolStripMenuItem();
            saleProductToolStripMenuItem = new ToolStripMenuItem();
            purchaseProductToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { productToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(13, 5, 0, 5);
            menuStrip.Size = new Size(1369, 48);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 1073);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 30, 0);
            statusStrip.Size = new Size(1369, 42);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(78, 32);
            toolStripStatusLabel.Text = "Status";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saleProductToolStripMenuItem, purchaseProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(116, 38);
            productToolStripMenuItem.Text = "Product";
            // 
            // saleProductToolStripMenuItem
            // 
            saleProductToolStripMenuItem.Name = "saleProductToolStripMenuItem";
            saleProductToolStripMenuItem.Size = new Size(359, 44);
            saleProductToolStripMenuItem.Text = "Sale Product";
            saleProductToolStripMenuItem.Click += saleProductToolStripMenuItem_Click;
            // 
            // purchaseProductToolStripMenuItem
            // 
            purchaseProductToolStripMenuItem.Name = "purchaseProductToolStripMenuItem";
            purchaseProductToolStripMenuItem.Size = new Size(359, 44);
            purchaseProductToolStripMenuItem.Text = "Purchase Product";
            purchaseProductToolStripMenuItem.Click += purchaseProductToolStripMenuItem_Click;
            // 
            // MDIParent2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 1115);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MDIParent2";
            Text = "MDIParent2";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private MenuStrip menuStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolTip toolTip;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem saleProductToolStripMenuItem;
        private ToolStripMenuItem purchaseProductToolStripMenuItem;
    }
}



