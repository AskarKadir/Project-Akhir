namespace WinFormsApp1
{
    partial class HalamanUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tombolDataMaster = new Button();
            tombolGrafik = new Button();
            tombolKeluar = new Button();
            SuspendLayout();
            // 
            // tombolDataMaster
            // 
            tombolDataMaster.Location = new Point(228, 218);
            tombolDataMaster.Name = "tombolDataMaster";
            tombolDataMaster.Size = new Size(170, 170);
            tombolDataMaster.TabIndex = 0;
            tombolDataMaster.Text = "Data Master";
            tombolDataMaster.UseVisualStyleBackColor = true;
            // 
            // tombolGrafik
            // 
            tombolGrafik.Location = new Point(463, 218);
            tombolGrafik.Name = "tombolGrafik";
            tombolGrafik.Size = new Size(170, 170);
            tombolGrafik.TabIndex = 1;
            tombolGrafik.Text = "Grafik";
            tombolGrafik.UseVisualStyleBackColor = true;
            // 
            // tombolKeluar
            // 
            tombolKeluar.Location = new Point(797, 12);
            tombolKeluar.Name = "tombolKeluar";
            tombolKeluar.Size = new Size(75, 23);
            tombolKeluar.TabIndex = 2;
            tombolKeluar.Text = "Keluar";
            tombolKeluar.UseVisualStyleBackColor = true;
            // 
            // HalamanUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tombolKeluar);
            Controls.Add(tombolGrafik);
            Controls.Add(tombolDataMaster);
            Name = "HalamanUtama";
            Text = "Halaman Utama";
            ResumeLayout(false);
        }

        #endregion

        private Button tombolDataMaster;
        private Button tombolGrafik;
        private Button tombolKeluar;
    }
}