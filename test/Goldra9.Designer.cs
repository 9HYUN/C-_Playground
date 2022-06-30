namespace test
{
    partial class Goldra9
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
            this.로또ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로또ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.로또ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.웹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로또ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 로또ToolStripMenuItem
            // 
            this.로또ToolStripMenuItem.Name = "로또ToolStripMenuItem";
            this.로또ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.로또ToolStripMenuItem.Text = "로또";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로또ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로또ToolStripMenuItem1
            // 
            this.로또ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로또ToolStripMenuItem2,
            this.웹ToolStripMenuItem});
            this.로또ToolStripMenuItem1.Name = "로또ToolStripMenuItem1";
            this.로또ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.로또ToolStripMenuItem1.Text = "메뉴";
            // 
            // 로또ToolStripMenuItem2
            // 
            this.로또ToolStripMenuItem2.Name = "로또ToolStripMenuItem2";
            this.로또ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.로또ToolStripMenuItem2.Text = "로또";
            this.로또ToolStripMenuItem2.Click += new System.EventHandler(this.로또ToolStripMenuItem2_Click);
            // 
            // 웹ToolStripMenuItem
            // 
            this.웹ToolStripMenuItem.Name = "웹ToolStripMenuItem";
            this.웹ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.웹ToolStripMenuItem.Text = "웹";
            this.웹ToolStripMenuItem.Click += new System.EventHandler(this.웹ToolStripMenuItem_Click);
            // 
            // Goldra9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Goldra9";
            this.Text = "Goldra9놀이터";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 로또ToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 로또ToolStripMenuItem1;
        private ToolStripMenuItem 로또ToolStripMenuItem2;
        private ToolStripMenuItem 웹ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}