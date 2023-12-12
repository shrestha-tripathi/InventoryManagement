namespace InventoryManagement
{
    partial class MDIParent1
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
            userToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            unitsToolStripMenuItem = new ToolStripMenuItem();
            addUnitsToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addProductNameToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            dealerToolStripMenuItem = new ToolStripMenuItem();
            dealerInfoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, unitsToolStripMenuItem, productToolStripMenuItem, dealerToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(13, 5, 0, 5);
            menuStrip.Size = new Size(1807, 48);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewUserToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(81, 38);
            userToolStripMenuItem.Text = "User";
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(299, 44);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // unitsToolStripMenuItem
            // 
            unitsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUnitsToolStripMenuItem });
            unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            unitsToolStripMenuItem.Size = new Size(88, 38);
            unitsToolStripMenuItem.Text = "Units";
            // 
            // addUnitsToolStripMenuItem
            // 
            addUnitsToolStripMenuItem.Name = "addUnitsToolStripMenuItem";
            addUnitsToolStripMenuItem.Size = new Size(251, 44);
            addUnitsToolStripMenuItem.Text = "Add Units";
            addUnitsToolStripMenuItem.Click += addUnitsToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductNameToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(116, 38);
            productToolStripMenuItem.Text = "Product";
            // 
            // addProductNameToolStripMenuItem
            // 
            addProductNameToolStripMenuItem.Name = "addProductNameToolStripMenuItem";
            addProductNameToolStripMenuItem.Size = new Size(350, 44);
            addProductNameToolStripMenuItem.Text = "Add Product Name";
            addProductNameToolStripMenuItem.Click += addProductNameToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 1063);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 30, 0);
            statusStrip.Size = new Size(1807, 42);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(78, 32);
            toolStripStatusLabel.Text = "Status";
            // 
            // dealerToolStripMenuItem
            // 
            dealerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dealerInfoToolStripMenuItem });
            dealerToolStripMenuItem.Name = "dealerToolStripMenuItem";
            dealerToolStripMenuItem.Size = new Size(103, 38);
            dealerToolStripMenuItem.Text = "Dealer";
            // 
            // dealerInfoToolStripMenuItem
            // 
            dealerInfoToolStripMenuItem.Name = "dealerInfoToolStripMenuItem";
            dealerInfoToolStripMenuItem.Size = new Size(359, 44);
            dealerInfoToolStripMenuItem.Text = "Dealer Info";
            dealerInfoToolStripMenuItem.Click += dealerInfoToolStripMenuItem_Click;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1807, 1105);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MDIParent1";
            Text = "MDIParent1";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private ToolStripMenuItem unitsToolStripMenuItem;
        private ToolStripMenuItem addUnitsToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addProductNameToolStripMenuItem;
        private ToolStripMenuItem dealerToolStripMenuItem;
        private ToolStripMenuItem dealerInfoToolStripMenuItem;
    }
}



