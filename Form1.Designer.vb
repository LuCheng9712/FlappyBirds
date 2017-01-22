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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbxBird = New System.Windows.Forms.PictureBox()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbxBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxBird
        '
        Me.pbxBird.Image = CType(resources.GetObject("pbxBird.Image"), System.Drawing.Image)
        Me.pbxBird.Location = New System.Drawing.Point(12, 12)
        Me.pbxBird.Name = "pbxBird"
        Me.pbxBird.Size = New System.Drawing.Size(34, 30)
        Me.pbxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBird.TabIndex = 4
        Me.pbxBird.TabStop = False
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.pbxBird)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbxBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbxBird As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer

End Class
