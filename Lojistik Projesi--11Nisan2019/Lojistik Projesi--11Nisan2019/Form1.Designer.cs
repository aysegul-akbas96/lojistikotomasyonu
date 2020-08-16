namespace Lojistik_Projesi__11Nisan2019
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevkiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deprtmanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.sevkiyatToolStripMenuItem,
            this.deprtmanlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.firmaToolStripMenuItem.Text = "Firmalar";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // sevkiyatToolStripMenuItem
            // 
            this.sevkiyatToolStripMenuItem.Name = "sevkiyatToolStripMenuItem";
            this.sevkiyatToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.sevkiyatToolStripMenuItem.Text = "Sevkiyat";
            this.sevkiyatToolStripMenuItem.Click += new System.EventHandler(this.sevkiyatToolStripMenuItem_Click);
            // 
            // deprtmanlarToolStripMenuItem
            // 
            this.deprtmanlarToolStripMenuItem.Name = "deprtmanlarToolStripMenuItem";
            this.deprtmanlarToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.deprtmanlarToolStripMenuItem.Text = "Departmanlar";
            this.deprtmanlarToolStripMenuItem.Click += new System.EventHandler(this.deprtmanlarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojistik_Projesi__11Nisan2019.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 416);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sevkiyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deprtmanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
    }
}

