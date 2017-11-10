namespace MailYakala
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lbxAdresler = new System.Windows.Forms.ListBox();
            this.btnTara = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hedef URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Adresleri :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(93, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(236, 20);
            this.txtUrl.TabIndex = 3;
            // 
            // lbxAdresler
            // 
            this.lbxAdresler.FormattingEnabled = true;
            this.lbxAdresler.Location = new System.Drawing.Point(93, 32);
            this.lbxAdresler.Name = "lbxAdresler";
            this.lbxAdresler.Size = new System.Drawing.Size(236, 264);
            this.lbxAdresler.TabIndex = 4;
            // 
            // btnTara
            // 
            this.btnTara.Location = new System.Drawing.Point(335, 5);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(75, 23);
            this.btnTara.TabIndex = 5;
            this.btnTara.Text = "URL Tara";
            this.btnTara.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(335, 273);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Red;
            this.btnDurdur.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDurdur.Location = new System.Drawing.Point(416, 5);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur.TabIndex = 7;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(667, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTara);
            this.Controls.Add(this.lbxAdresler);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MailYakala | Tembel Tenekeler Beta Versiyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ListBox lbxAdresler;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

