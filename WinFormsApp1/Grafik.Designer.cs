namespace WinFormsApp1
{
    partial class DtMaster
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
            tombolKesling = new Button();
            tombolWarga = new Button();
            tombolKembali = new Button();
            SuspendLayout();
            // 
            // tombolKesling
            // 
            tombolKesling.Location = new Point(203, 179);
            tombolKesling.Name = "tombolKesling";
            tombolKesling.Size = new Size(170, 170);
            tombolKesling.TabIndex = 1;
            tombolKesling.Text = "Kesling";
            tombolKesling.UseVisualStyleBackColor = true;
            // 
            // tombolWarga
            // 
            tombolWarga.Location = new Point(446, 179);
            tombolWarga.Name = "tombolWarga";
            tombolWarga.Size = new Size(170, 170);
            tombolWarga.TabIndex = 2;
            tombolWarga.Text = "Warga";
            tombolWarga.UseVisualStyleBackColor = true;
            // 
            // tombolKembali
            // 
            tombolKembali.Location = new Point(12, 12);
            tombolKembali.Name = "tombolKembali";
            tombolKembali.Size = new Size(75, 23);
            tombolKembali.TabIndex = 3;
            tombolKembali.Text = "Kembali";
            tombolKembali.UseVisualStyleBackColor = true;
            // 
            // DataMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tombolKembali);
            Controls.Add(tombolWarga);
            Controls.Add(tombolKesling);
            Name = "DataMaster";
            Text = "Grafik";
            ResumeLayout(false);
        }

        #endregion

        private Button tombolKesling;
        private Button tombolWarga;
        private Button tombolKembali;
    }
}