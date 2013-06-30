namespace ProgrammingNamingConventions
{
    partial class ProgrammingNamingConventions
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.camelCaseOutputLabel = new System.Windows.Forms.Label();
            this.camelCaseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // camelCaseOutputLabel
            // 
            this.camelCaseOutputLabel.AutoSize = true;
            this.camelCaseOutputLabel.Location = new System.Drawing.Point(112, 39);
            this.camelCaseOutputLabel.Name = "camelCaseOutputLabel";
            this.camelCaseOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.camelCaseOutputLabel.TabIndex = 1;
            // 
            // camelCaseLabel
            // 
            this.camelCaseLabel.AutoSize = true;
            this.camelCaseLabel.Location = new System.Drawing.Point(12, 39);
            this.camelCaseLabel.Name = "camelCaseLabel";
            this.camelCaseLabel.Size = new System.Drawing.Size(59, 13);
            this.camelCaseLabel.TabIndex = 2;
            this.camelCaseLabel.Text = "camelCase";
            // 
            // ProgrammingNamingConventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.camelCaseLabel);
            this.Controls.Add(this.camelCaseOutputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "ProgrammingNamingConventions";
            this.Text = "Programming Naming Conventions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label camelCaseOutputLabel;
        private System.Windows.Forms.Label camelCaseLabel;
    }
}

