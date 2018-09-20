namespace bloodbank
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONORREGISTRATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEQUESTBLOODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOODINVENTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 28);
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.form1ToolStripMenuItem.Text = "form1";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.aBOUTUSToolStripMenuItem,
            this.dONORREGISTRATIONToolStripMenuItem,
            this.rEQUESTBLOODToolStripMenuItem,
            this.bLOODINVENTORYToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(216, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(833, 62);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(64, 58);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // aBOUTUSToolStripMenuItem
            // 
            this.aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            this.aBOUTUSToolStripMenuItem.Size = new System.Drawing.Size(91, 58);
            this.aBOUTUSToolStripMenuItem.Text = "ABOUT US";
            // 
            // dONORREGISTRATIONToolStripMenuItem
            // 
            this.dONORREGISTRATIONToolStripMenuItem.Name = "dONORREGISTRATIONToolStripMenuItem";
            this.dONORREGISTRATIONToolStripMenuItem.Size = new System.Drawing.Size(177, 58);
            this.dONORREGISTRATIONToolStripMenuItem.Text = "DONOR REGISTRATION";
            this.dONORREGISTRATIONToolStripMenuItem.Click += new System.EventHandler(this.dONORREGISTRATIONToolStripMenuItem_Click);
            // 
            // rEQUESTBLOODToolStripMenuItem
            // 
            this.rEQUESTBLOODToolStripMenuItem.Name = "rEQUESTBLOODToolStripMenuItem";
            this.rEQUESTBLOODToolStripMenuItem.Size = new System.Drawing.Size(135, 58);
            this.rEQUESTBLOODToolStripMenuItem.Text = "REQUEST BLOOD";
            this.rEQUESTBLOODToolStripMenuItem.Click += new System.EventHandler(this.rEQUESTBLOODToolStripMenuItem_Click);
            // 
            // bLOODINVENTORYToolStripMenuItem
            // 
            this.bLOODINVENTORYToolStripMenuItem.Name = "bLOODINVENTORYToolStripMenuItem";
            this.bLOODINVENTORYToolStripMenuItem.Size = new System.Drawing.Size(151, 58);
            this.bLOODINVENTORYToolStripMenuItem.Text = "BLOOD INVENTORY";
            this.bLOODINVENTORYToolStripMenuItem.Click += new System.EventHandler(this.bLOODINVENTORYToolStripMenuItem_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::bloodbank.Properties.Resources.khaki;
            this.ClientSize = new System.Drawing.Size(1605, 697);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONORREGISTRATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEQUESTBLOODToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOODINVENTORYToolStripMenuItem;


    }
}