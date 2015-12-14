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
            this.goFetchButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlContentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // goFetchButton
            // 
            this.goFetchButton.Location = new System.Drawing.Point(197, 10);
            this.goFetchButton.Name = "goFetchButton";
            this.goFetchButton.Size = new System.Drawing.Size(75, 23);
            this.goFetchButton.TabIndex = 1;
            this.goFetchButton.Text = "Go Fetch";
            this.goFetchButton.UseVisualStyleBackColor = true;
            this.goFetchButton.Click += new System.EventHandler(this.goFetchButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 10);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(179, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "http://www.bing.com/";
            // 
            // urlContentTextBox
            // 
            this.urlContentTextBox.Location = new System.Drawing.Point(12, 39);
            this.urlContentTextBox.Multiline = true;
            this.urlContentTextBox.Name = "urlContentTextBox";
            this.urlContentTextBox.ReadOnly = true;
            this.urlContentTextBox.Size = new System.Drawing.Size(260, 210);
            this.urlContentTextBox.TabIndex = 3;
            // 
            // UrlFetcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.urlContentTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.goFetchButton);
            this.Name = "UrlFetcher";
            this.Text = "Async Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goFetchButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox urlContentTextBox;
    }
}

