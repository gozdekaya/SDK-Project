namespace WindowsFormsApp16
{
    partial class yeni_kayit_ekle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtEvTelefonu = new System.Windows.Forms.TextBox();
            this.txtCepTelefonu = new System.Windows.Forms.TextBox();
            this.txtMeslegi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ev Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cep Telefonu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(94, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesleği:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(174, 58);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(250, 20);
            this.txtIsim.TabIndex = 7;
            // 
            // txtEvTelefonu
            // 
            this.txtEvTelefonu.Location = new System.Drawing.Point(174, 96);
            this.txtEvTelefonu.Name = "txtEvTelefonu";
            this.txtEvTelefonu.Size = new System.Drawing.Size(250, 20);
            this.txtEvTelefonu.TabIndex = 8;
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(174, 134);
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(250, 20);
            this.txtCepTelefonu.TabIndex = 9;
            // 
            // txtMeslegi
            // 
            this.txtMeslegi.Location = new System.Drawing.Point(174, 171);
            this.txtMeslegi.Name = "txtMeslegi";
            this.txtMeslegi.Size = new System.Drawing.Size(250, 20);
            this.txtMeslegi.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(174, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(349, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yeni_kayit_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(605, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMeslegi);
            this.Controls.Add(this.txtCepTelefonu);
            this.Controls.Add(this.txtEvTelefonu);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yeni_kayit_ekle";
            this.Text = "yeni_kayıt_ekle";
            this.Load += new System.EventHandler(this.yeni_kayit_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtIsim;
        public System.Windows.Forms.TextBox txtEvTelefonu;
        public System.Windows.Forms.TextBox txtCepTelefonu;
        public System.Windows.Forms.TextBox txtMeslegi;
    }
}