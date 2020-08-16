namespace Lojistik_Projesi__11Nisan2019
{
    partial class FirmaSeç
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(232, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Tipini Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ÜreticiFirma",
            "AlıcıFirma",
            "TaşıyıcıFirma"});
            this.comboBox1.Location = new System.Drawing.Point(424, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Lojistik_Projesi__11Nisan2019.Properties.Resources.geri;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(21, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 54);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FirmaSeç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lojistik_Projesi__11Nisan2019.Properties.Resources.circuit_fond_dans_tons_bleus_23_2147507443;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 415);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FirmaSeç";
            this.Text = "FirmaSeç";
            this.Load += new System.EventHandler(this.FirmaSeç_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
    }
}