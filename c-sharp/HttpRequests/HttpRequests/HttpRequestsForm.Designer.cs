namespace HttpRequests
{
    partial class HttpRequestsForm
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.headersDataGridView = new System.Windows.Forms.DataGridView();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.headersDataGridView)).BeginInit();
            this.addressPanel.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 9);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "A&ddress: ";
            this.addressLabel.UseWaitCursor = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(69, 6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(255, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(330, 6);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(36, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // headersDataGridView
            // 
            this.headersDataGridView.AllowUserToAddRows = false;
            this.headersDataGridView.AllowUserToDeleteRows = false;
            this.headersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.headersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headersDataGridView.Location = new System.Drawing.Point(3, 41);
            this.headersDataGridView.Name = "headersDataGridView";
            this.headersDataGridView.Size = new System.Drawing.Size(378, 418);
            this.headersDataGridView.TabIndex = 0;
            // 
            // addressPanel
            // 
            this.addressPanel.AutoSize = true;
            this.addressPanel.Controls.Add(this.addressLabel);
            this.addressPanel.Controls.Add(this.addressTextBox);
            this.addressPanel.Controls.Add(this.goButton);
            this.addressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressPanel.Location = new System.Drawing.Point(3, 3);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(378, 32);
            this.addressPanel.TabIndex = 4;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.headersDataGridView, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.addressPanel, 0, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(384, 462);
            this.mainTableLayoutPanel.TabIndex = 5;
            // 
            // HttpRequestsForm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "HttpRequestsForm";
            this.Text = "HTTP Requests";
            this.Shown += new System.EventHandler(this.HttpRequestsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.headersDataGridView)).EndInit();
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataGridView headersDataGridView;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
    }
}

