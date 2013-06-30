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
        Me.components = New System.ComponentModel.Container()
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.teachersLabel = New System.Windows.Forms.Label()
        Me.schoolClassesLabel = New System.Windows.Forms.Label()
        Me.teachersDataGridView = New System.Windows.Forms.DataGridView()
        Me.schoolClassesDataGridView = New System.Windows.Forms.DataGridView()
        Me.teachersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.schoolClassesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mainTableLayoutPanel.SuspendLayout()
        CType(Me.teachersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schoolClassesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teachersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schoolClassesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.teachersLabel, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.schoolClassesLabel, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.teachersDataGridView, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.schoolClassesDataGridView, 0, 3)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 4
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.84849!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(705, 511)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'teachersLabel
        '
        Me.teachersLabel.AutoSize = True
        Me.teachersLabel.Location = New System.Drawing.Point(3, 0)
        Me.teachersLabel.Name = "teachersLabel"
        Me.teachersLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.teachersLabel.Size = New System.Drawing.Size(62, 23)
        Me.teachersLabel.TabIndex = 0
        Me.teachersLabel.Text = "Teachers"
        '
        'schoolClassesLabel
        '
        Me.schoolClassesLabel.AutoSize = True
        Me.schoolClassesLabel.Location = New System.Drawing.Point(3, 198)
        Me.schoolClassesLabel.Name = "schoolClassesLabel"
        Me.schoolClassesLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.schoolClassesLabel.Size = New System.Drawing.Size(100, 23)
        Me.schoolClassesLabel.TabIndex = 1
        Me.schoolClassesLabel.Text = "Classes in School"
        '
        'teachersDataGridView
        '
        Me.teachersDataGridView.AutoGenerateColumns = False
        Me.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teachersDataGridView.DataSource = Me.teachersBindingSource
        Me.teachersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teachersDataGridView.Location = New System.Drawing.Point(3, 33)
        Me.teachersDataGridView.Name = "teachersDataGridView"
        Me.teachersDataGridView.Size = New System.Drawing.Size(699, 162)
        Me.teachersDataGridView.TabIndex = 2
        '
        'schoolClassesDataGridView
        '
        Me.schoolClassesDataGridView.AutoGenerateColumns = False
        Me.schoolClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.schoolClassesDataGridView.DataSource = Me.schoolClassesBindingSource
        Me.schoolClassesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schoolClassesDataGridView.Location = New System.Drawing.Point(3, 238)
        Me.schoolClassesDataGridView.Name = "schoolClassesDataGridView"
        Me.schoolClassesDataGridView.Size = New System.Drawing.Size(699, 270)
        Me.schoolClassesDataGridView.TabIndex = 3
        '
        'teachersBindingSource
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 511)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "MainForm"
        Me.Text = "School Organisation"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        CType(Me.teachersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schoolClassesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teachersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schoolClassesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents teachersLabel As System.Windows.Forms.Label
    Friend WithEvents schoolClassesLabel As System.Windows.Forms.Label
    Friend WithEvents teachersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents schoolClassesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents teachersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents schoolClassesBindingSource As System.Windows.Forms.BindingSource

End Class
