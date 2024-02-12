
namespace SOAP_TcKimlikDogrulama
{
    partial class FrmTcDorulamaSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTcDorulamaSistemi));
            this.lblDogumYili = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtDogumYili = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnTcDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDogumYili
            // 
            this.lblDogumYili.AutoSize = true;
            this.lblDogumYili.Location = new System.Drawing.Point(107, 111);
            this.lblDogumYili.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDogumYili.Name = "lblDogumYili";
            this.lblDogumYili.Size = new System.Drawing.Size(63, 13);
            this.lblDogumYili.TabIndex = 23;
            this.lblDogumYili.Text = "Doğum Yılı=";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(122, 86);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(49, 13);
            this.lblSoyad.TabIndex = 22;
            this.lblSoyad.Text = "Soyad = ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(139, 55);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 13);
            this.lblAd.TabIndex = 21;
            this.lblAd.Text = "Ad = ";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(65, 27);
            this.lblTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(107, 13);
            this.lblTc.TabIndex = 20;
            this.lblTc.Text = "TC Kimlik Numarası =";
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(189, 111);
            this.txtDogumYili.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDogumYili.MaxLength = 4;
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(191, 20);
            this.txtDogumYili.TabIndex = 19;
            this.txtDogumYili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDogumYili_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(189, 86);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(191, 20);
            this.txtSoyad.TabIndex = 18;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(189, 55);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(191, 20);
            this.txtAd.TabIndex = 17;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(189, 27);
            this.txtTc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(191, 20);
            this.txtTc.TabIndex = 16;
            this.txtTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTc_KeyPress);
            // 
            // btnTcDogrula
            // 
            this.btnTcDogrula.Location = new System.Drawing.Point(189, 151);
            this.btnTcDogrula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTcDogrula.Name = "btnTcDogrula";
            this.btnTcDogrula.Size = new System.Drawing.Size(189, 37);
            this.btnTcDogrula.TabIndex = 15;
            this.btnTcDogrula.Text = "TC Kimlik Numarası Doğrula";
            this.btnTcDogrula.UseVisualStyleBackColor = true;
            this.btnTcDogrula.Click += new System.EventHandler(this.btnTcDogrula_Click);
            // 
            // FrmTcDorulamaSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 201);
            this.Controls.Add(this.lblDogumYili);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.txtDogumYili);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.btnTcDogrula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTcDorulamaSistemi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTcDorulamaSistemi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDogumYili;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtDogumYili;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnTcDogrula;
    }
}

