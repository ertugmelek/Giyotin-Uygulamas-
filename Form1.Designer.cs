namespace _20170412_giyotin
{
    partial class FormGiyotin
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.tmrYaz = new System.Windows.Forms.Timer(this.components);
            this.tmrSil = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(164, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // tmrYaz
            // 
            this.tmrYaz.Interval = 500;
            this.tmrYaz.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // tmrSil
            // 
            this.tmrSil.Interval = 500;
            this.tmrSil.Tick += new System.EventHandler(this.tmrSil_Tick);
            // 
            // FormGiyotin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 443);
            this.Controls.Add(this.btnBaslat);
            this.Name = "FormGiyotin";
            this.Text = " Giyotin";
            this.Load += new System.EventHandler(this.FormGiyotin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Timer tmrYaz;
        private System.Windows.Forms.Timer tmrSil;
    }
}

