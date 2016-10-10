<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNumOfActivities
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
        Me.LblInstructions = New System.Windows.Forms.Label()
        Me.NumUDActivityCounter = New System.Windows.Forms.NumericUpDown()
        Me.BtnDone = New System.Windows.Forms.Button()
        CType(Me.NumUDActivityCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblInstructions
        '
        Me.LblInstructions.AutoSize = True
        Me.LblInstructions.Location = New System.Drawing.Point(20, 22)
        Me.LblInstructions.Name = "LblInstructions"
        Me.LblInstructions.Size = New System.Drawing.Size(225, 13)
        Me.LblInstructions.TabIndex = 0
        Me.LblInstructions.Text = "Please enter the number of activities their are: "
        '
        'NumUDActivityCounter
        '
        Me.NumUDActivityCounter.AutoSize = True
        Me.NumUDActivityCounter.Location = New System.Drawing.Point(261, 20)
        Me.NumUDActivityCounter.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumUDActivityCounter.Name = "NumUDActivityCounter"
        Me.NumUDActivityCounter.Size = New System.Drawing.Size(84, 20)
        Me.NumUDActivityCounter.TabIndex = 1
        Me.NumUDActivityCounter.ThousandsSeparator = True
        Me.NumUDActivityCounter.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'BtnDone
        '
        Me.BtnDone.Location = New System.Drawing.Point(107, 59)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(162, 29)
        Me.BtnDone.TabIndex = 2
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'FrmNumOfActivities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 101)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.NumUDActivityCounter)
        Me.Controls.Add(Me.LblInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmNumOfActivities"
        Me.Text = "Enter the number of Activities"
        CType(Me.NumUDActivityCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblInstructions As System.Windows.Forms.Label
    Friend WithEvents NumUDActivityCounter As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnDone As System.Windows.Forms.Button
End Class
