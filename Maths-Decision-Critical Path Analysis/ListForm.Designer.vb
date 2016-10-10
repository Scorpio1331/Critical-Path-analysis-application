<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVActivityList = New System.Windows.Forms.DataGridView()
        Me.Activity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityPredecessor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVActivityList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVActivityList
        '
        Me.DGVActivityList.AllowUserToResizeColumns = False
        Me.DGVActivityList.BackgroundColor = System.Drawing.Color.White
        Me.DGVActivityList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVActivityList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVActivityList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Activity, Me.ActivityDescription, Me.ActivityTime, Me.ActivityPredecessor})
        Me.DGVActivityList.Location = New System.Drawing.Point(-39, 0)
        Me.DGVActivityList.MaximumSize = New System.Drawing.Size(796, 528)
        Me.DGVActivityList.MinimumSize = New System.Drawing.Size(796, 17)
        Me.DGVActivityList.Name = "DGVActivityList"
        Me.DGVActivityList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVActivityList.Size = New System.Drawing.Size(796, 44)
        Me.DGVActivityList.TabIndex = 0
        '
        'Activity
        '
        Me.Activity.Frozen = True
        Me.Activity.HeaderText = "Activity"
        Me.Activity.Name = "Activity"
        Me.Activity.ReadOnly = True
        Me.Activity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Activity.Width = 60
        '
        'ActivityDescription
        '
        Me.ActivityDescription.Frozen = True
        Me.ActivityDescription.HeaderText = "Activity Description"
        Me.ActivityDescription.Name = "ActivityDescription"
        Me.ActivityDescription.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ActivityDescription.Width = 390
        '
        'ActivityTime
        '
        DataGridViewCellStyle2.Format = "N6"
        DataGridViewCellStyle2.NullValue = "0"
        Me.ActivityTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.ActivityTime.Frozen = True
        Me.ActivityTime.HeaderText = "Activity Time"
        Me.ActivityTime.Name = "ActivityTime"
        Me.ActivityTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ActivityTime.Width = 154
        '
        'ActivityPredecessor
        '
        Me.ActivityPredecessor.Frozen = True
        Me.ActivityPredecessor.HeaderText = "Activity Predecessor"
        Me.ActivityPredecessor.Name = "ActivityPredecessor"
        Me.ActivityPredecessor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ActivityPredecessor.Width = 131
        '
        'FrmListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 89)
        Me.Controls.Add(Me.DGVActivityList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(772, 565)
        Me.MinimumSize = New System.Drawing.Size(754, 127)
        Me.Name = "FrmListForm"
        Me.Text = "Activity List"
        CType(Me.DGVActivityList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVActivityList As System.Windows.Forms.DataGridView
    Friend WithEvents Activity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivityPredecessor As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
