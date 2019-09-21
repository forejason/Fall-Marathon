<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picMarathon = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetail
        '
        Me.btnDetail.Location = New System.Drawing.Point(355, 630)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(196, 67)
        Me.btnDetail.TabIndex = 0
        Me.btnDetail.Text = "View Details"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(355, 885)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(196, 67)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picMarathon
        '
        Me.picMarathon.BackgroundImage = Global.Fall_Marathon.My.Resources.Resources.Marathon
        Me.picMarathon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMarathon.Image = Global.Fall_Marathon.My.Resources.Resources.Marathon
        Me.picMarathon.Location = New System.Drawing.Point(128, 107)
        Me.picMarathon.Name = "picMarathon"
        Me.picMarathon.Size = New System.Drawing.Size(662, 444)
        Me.picMarathon.TabIndex = 2
        Me.picMarathon.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(348, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(259, 42)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Fall Marathon"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(165, 572)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(588, 33)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "full- and half-marathon runners are welcome"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Location = New System.Drawing.Point(411, 783)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(30, 25)
        Me.lblDetails.TabIndex = 5
        Me.lblDetails.Text = "..."
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 1008)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picMarathon)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDetail)
        Me.Name = "Main"
        Me.Text = "Fall Marathon"
        CType(Me.picMarathon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picMarathon As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblDetails As Label
End Class
