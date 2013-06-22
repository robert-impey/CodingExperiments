<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.inputLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'inputLabel
        '
        Me.inputLabel.AutoSize = True
        Me.inputLabel.Location = New System.Drawing.Point(13, 13)
        Me.inputLabel.Name = "inputLabel"
        Me.inputLabel.Size = New System.Drawing.Size(79, 13)
        Me.inputLabel.TabIndex = 0
        Me.inputLabel.Text = "Enter text here:"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(99, 13)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.inputTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(206, 9)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(75, 23)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Location = New System.Drawing.Point(16, 43)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(69, 13)
        Me.outputLabel.TabIndex = 3
        Me.outputLabel.Text = "In Wingdings"
        '
        'outputTextBox
        '
        Me.outputTextBox.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.outputTextBox.Location = New System.Drawing.Point(99, 43)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.outputTextBox.TabIndex = 4
        '
        'MainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 262)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.inputLabel)
        Me.Name = "MainForm"
        Me.Text = "Font Preview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputLabel As System.Windows.Forms.Label
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents outputLabel As System.Windows.Forms.Label
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox

End Class
