namespace EncodeDecode
{
    partial class EncodeDecode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncodeDecode));
            this.txbEncode = new System.Windows.Forms.TextBox();
            this.txbDecode = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.cbAlgorithms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbEncode
            // 
            this.txbEncode.Location = new System.Drawing.Point(12, 12);
            this.txbEncode.Multiline = true;
            this.txbEncode.Name = "txbEncode";
            this.txbEncode.Size = new System.Drawing.Size(405, 130);
            this.txbEncode.TabIndex = 0;
            // 
            // txbDecode
            // 
            this.txbDecode.Location = new System.Drawing.Point(12, 177);
            this.txbDecode.Multiline = true;
            this.txbDecode.Name = "txbDecode";
            this.txbDecode.Size = new System.Drawing.Size(405, 138);
            this.txbDecode.TabIndex = 1;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(12, 148);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "↓ encode ↓";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(342, 148);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "↑ decode ↑";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // cbAlgorithms
            // 
            this.cbAlgorithms.FormattingEnabled = true;
            this.cbAlgorithms.Location = new System.Drawing.Point(93, 149);
            this.cbAlgorithms.Name = "cbAlgorithms";
            this.cbAlgorithms.Size = new System.Drawing.Size(243, 21);
            this.cbAlgorithms.TabIndex = 4;
            // 
            // EncodeDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 327);
            this.Controls.Add(this.cbAlgorithms);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txbDecode);
            this.Controls.Add(this.txbEncode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncodeDecode";
            this.Text = "EncodeDecode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbEncode;
        private System.Windows.Forms.TextBox txbDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.ComboBox cbAlgorithms;
    }
}

