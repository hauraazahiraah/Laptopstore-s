namespace AsusStore
{
    partial class register
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
            this.txtblogin = new System.Windows.Forms.Button();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtblogin
            // 
            this.txtblogin.Location = new System.Drawing.Point(390, 263);
            this.txtblogin.Name = "txtblogin";
            this.txtblogin.Size = new System.Drawing.Size(128, 36);
            this.txtblogin.TabIndex = 12;
            this.txtblogin.Text = "Daftar";
            this.txtblogin.UseVisualStyleBackColor = true;
            this.txtblogin.Click += new System.EventHandler(this.txtblogin_Click);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(271, 208);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(402, 26);
            this.txtb2.TabIndex = 11;
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(271, 153);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(402, 26);
            this.txtb1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtblogin);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtblogin;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}