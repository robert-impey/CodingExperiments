namespace AsyncForms
{
    partial class UrlFetcher
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
            this.fetchAsyncButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlContentTextBox = new System.Windows.Forms.TextBox();
            this.fetchButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fetchAsyncButton
            // 
            this.fetchAsyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fetchAsyncButton.Location = new System.Drawing.Point(197, 36);
            this.fetchAsyncButton.Name = "fetchAsyncButton";
            this.fetchAsyncButton.Size = new System.Drawing.Size(75, 23);
            this.fetchAsyncButton.TabIndex = 2;
            this.fetchAsyncButton.Text = "Fetch Async";
            this.fetchAsyncButton.UseVisualStyleBackColor = true;
            this.fetchAsyncButton.Click += new System.EventHandler(this.fetchAsyncButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 10);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(260, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "http://www.gutenberg.org/ebooks/10.txt.utf-8";
            // 
            // urlContentTextBox
            // 
            this.urlContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlContentTextBox.Location = new System.Drawing.Point(12, 66);
            this.urlContentTextBox.Multiline = true;
            this.urlContentTextBox.Name = "urlContentTextBox";
            this.urlContentTextBox.ReadOnly = true;
            this.urlContentTextBox.Size = new System.Drawing.Size(260, 158);
            this.urlContentTextBox.TabIndex = 3;
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(12, 37);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(75, 23);
            this.fetchButton.TabIndex = 1;
            this.fetchButton.Text = "Fetch";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.Location = new System.Drawing.Point(12, 229);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(260, 20);
            this.statusTextBox.TabIndex = 4;
            // 
            // UrlFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.urlContentTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.fetchAsyncButton);
            this.Name = "UrlFetcher";
            this.Text = "Async Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchAsyncButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox urlContentTextBox;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

