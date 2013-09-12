<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.encryptButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputLabel
        '
        Me.inputLabel.AutoSize = True
        Me.inputLabel.Location = New System.Drawing.Point(13, 13)
        Me.inputLabel.Name = "inputLabel"
        Me.inputLabel.Size = New System.Drawing.Size(31, 13)
        Me.inputLabel.TabIndex = 0
        Me.inputLabel.Text = "Input"
        '
        'outputLabel
        '
        Me.outputLabel.AutoSize = True
        Me.outputLabel.Location = New System.Drawing.Point(13, 52)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(39, 13)
        Me.outputLabel.TabIndex = 1
        Me.outputLabel.Text = "Output"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(59, 13)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.inputTextBox.TabIndex = 2
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(59, 52)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.outputTextBox.TabIndex = 3
        '
        'encryptButton
        '
        Me.encryptButton.Location = New System.Drawing.Point(83, 79)
        Me.encryptButton.Name = "encryptButton"
        Me.encryptButton.Size = New System.Drawing.Size(75, 23)
        Me.encryptButton.TabIndex = 4
        Me.encryptButton.Text = "Encrypt"
        Me.encryptButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 132)
        Me.Controls.Add(Me.encryptButton)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.inputLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputLabel As System.Windows.Forms.Label
    Friend WithEvents outputLabel As System.Windows.Forms.Label
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents encryptButton As System.Windows.Forms.Button

End Class
