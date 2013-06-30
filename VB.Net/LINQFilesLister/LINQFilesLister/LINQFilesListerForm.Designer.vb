<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINQFilesListerForm
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
        Me.filesDataGridView = New System.Windows.Forms.DataGridView()
        Me.mainFormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.filesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainFormMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'filesDataGridView
        '
        Me.filesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.filesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filesDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.filesDataGridView.Name = "filesDataGridView"
        Me.filesDataGridView.RowTemplate.Height = 33
        Me.filesDataGridView.Size = New System.Drawing.Size(284, 238)
        Me.filesDataGridView.TabIndex = 0
        '
        'mainFormMenuStrip
        '
        Me.mainFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mainFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainFormMenuStrip.Name = "mainFormMenuStrip"
        Me.mainFormMenuStrip.Size = New System.Drawing.Size(284, 24)
        Me.mainFormMenuStrip.TabIndex = 1
        Me.mainFormMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectoryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DirectoryToolStripMenuItem
        '
        Me.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem"
        Me.DirectoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DirectoryToolStripMenuItem.Text = "Directory"
        '
        'LINQFilesListerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.filesDataGridView)
        Me.Controls.Add(Me.mainFormMenuStrip)
        Me.Name = "LINQFilesListerForm"
        Me.Text = "LINQ Files Lister"
        CType(Me.filesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainFormMenuStrip.ResumeLayout(False)
        Me.mainFormMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents filesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents mainFormMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
