namespace Temazaro
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_update = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerkesztToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újAdatHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.könyvTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(183, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Könyvtár kezelő rendszer";
            // 
            // listBox1_update
            // 
            this.listBox1_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1_update.FormattingEnabled = true;
            this.listBox1_update.ItemHeight = 20;
            this.listBox1_update.Location = new System.Drawing.Point(0, 306);
            this.listBox1_update.Name = "listBox1_update";
            this.listBox1_update.Size = new System.Drawing.Size(800, 144);
            this.listBox1_update.TabIndex = 1;
            this.listBox1_update.SelectedIndexChanged += new System.EventHandler(this.listBox1_update_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztToolStripMenuItem,
            this.újAdatHozzáadásaToolStripMenuItem,
            this.könyvTörléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerkesztToolStripMenuItem
            // 
            this.szerkesztToolStripMenuItem.Name = "szerkesztToolStripMenuItem";
            this.szerkesztToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.szerkesztToolStripMenuItem.Text = "Könyvek adatainak szerkesztése";
            this.szerkesztToolStripMenuItem.Click += new System.EventHandler(this.szerkesztToolStripMenuItem_Click);
            // 
            // újAdatHozzáadásaToolStripMenuItem
            // 
            this.újAdatHozzáadásaToolStripMenuItem.Name = "újAdatHozzáadásaToolStripMenuItem";
            this.újAdatHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.újAdatHozzáadásaToolStripMenuItem.Text = "Új könyv hozzáadása";
            this.újAdatHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.újAdatHozzáadásaToolStripMenuItem_Click);
            // 
            // könyvTörléseToolStripMenuItem
            // 
            this.könyvTörléseToolStripMenuItem.Name = "könyvTörléseToolStripMenuItem";
            this.könyvTörléseToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.könyvTörléseToolStripMenuItem.Text = "Könyv törlése";
            this.könyvTörléseToolStripMenuItem.Click += new System.EventHandler(this.könyvTörléseToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-4, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meglévő könyvek adatai:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Könyvtár kezelő rendszer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újAdatHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem könyvTörléseToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox1_update;
    }
}

