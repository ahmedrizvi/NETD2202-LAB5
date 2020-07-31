<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblAbout1 = New System.Windows.Forms.Label()
        Me.lblAbout2 = New System.Windows.Forms.Label()
        Me.lblAbout3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAbout1
        '
        Me.lblAbout1.AutoSize = True
        Me.lblAbout1.Location = New System.Drawing.Point(100, 36)
        Me.lblAbout1.MaximumSize = New System.Drawing.Size(64, 13)
        Me.lblAbout1.MinimumSize = New System.Drawing.Size(64, 13)
        Me.lblAbout1.Name = "lblAbout1"
        Me.lblAbout1.Size = New System.Drawing.Size(64, 13)
        Me.lblAbout1.TabIndex = 0
        Me.lblAbout1.Text = "NETD-2202"
        '
        'lblAbout2
        '
        Me.lblAbout2.AutoSize = True
        Me.lblAbout2.Location = New System.Drawing.Point(110, 62)
        Me.lblAbout2.Name = "lblAbout2"
        Me.lblAbout2.Size = New System.Drawing.Size(41, 13)
        Me.lblAbout2.TabIndex = 1
        Me.lblAbout2.Text = "Lab #5"
        '
        'lblAbout3
        '
        Me.lblAbout3.AutoSize = True
        Me.lblAbout3.Location = New System.Drawing.Point(77, 90)
        Me.lblAbout3.Name = "lblAbout3"
        Me.lblAbout3.Size = New System.Drawing.Size(111, 13)
        Me.lblAbout3.TabIndex = 2
        Me.lblAbout3.Text = "Made By Ahmed Rizvi"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 163)
        Me.Controls.Add(Me.lblAbout3)
        Me.Controls.Add(Me.lblAbout2)
        Me.Controls.Add(Me.lblAbout1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(276, 202)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(276, 202)
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAbout1 As Label
    Friend WithEvents lblAbout2 As Label
    Friend WithEvents lblAbout3 As Label
End Class
