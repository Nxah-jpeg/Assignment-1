<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        lblMessage = New Label()
        picBFF = New PictureBox()
        picBRB = New PictureBox()
        picIDK = New PictureBox()
        picLOL = New PictureBox()
        picSRY = New PictureBox()
        picXO = New PictureBox()
        btnExit = New Button()
        CType(picBFF, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBRB, ComponentModel.ISupportInitialize).BeginInit()
        CType(picIDK, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLOL, ComponentModel.ISupportInitialize).BeginInit()
        CType(picSRY, ComponentModel.ISupportInitialize).BeginInit()
        CType(picXO, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMessage
        ' 
        lblMessage.BorderStyle = BorderStyle.FixedSingle
        lblMessage.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblMessage.Location = New Point(43, 287)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(956, 107)
        lblMessage.TabIndex = 0
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picBFF
        ' 
        picBFF.BorderStyle = BorderStyle.FixedSingle
        picBFF.Image = CType(resources.GetObject("picBFF.Image"), Image)
        picBFF.Location = New Point(33, 70)
        picBFF.Name = "picBFF"
        picBFF.Size = New Size(180, 101)
        picBFF.SizeMode = PictureBoxSizeMode.StretchImage
        picBFF.TabIndex = 1
        picBFF.TabStop = False
        ' 
        ' picBRB
        ' 
        picBRB.BorderStyle = BorderStyle.FixedSingle
        picBRB.Image = CType(resources.GetObject("picBRB.Image"), Image)
        picBRB.Location = New Point(254, 70)
        picBRB.Name = "picBRB"
        picBRB.Size = New Size(184, 102)
        picBRB.SizeMode = PictureBoxSizeMode.StretchImage
        picBRB.TabIndex = 2
        picBRB.TabStop = False
        ' 
        ' picIDK
        ' 
        picIDK.BorderStyle = BorderStyle.FixedSingle
        picIDK.Image = CType(resources.GetObject("picIDK.Image"), Image)
        picIDK.Location = New Point(466, 70)
        picIDK.Name = "picIDK"
        picIDK.Size = New Size(158, 101)
        picIDK.SizeMode = PictureBoxSizeMode.StretchImage
        picIDK.TabIndex = 3
        picIDK.TabStop = False
        ' 
        ' picLOL
        ' 
        picLOL.BorderStyle = BorderStyle.FixedSingle
        picLOL.Image = CType(resources.GetObject("picLOL.Image"), Image)
        picLOL.Location = New Point(671, 70)
        picLOL.Name = "picLOL"
        picLOL.Size = New Size(163, 101)
        picLOL.SizeMode = PictureBoxSizeMode.StretchImage
        picLOL.TabIndex = 4
        picLOL.TabStop = False
        ' 
        ' picSRY
        ' 
        picSRY.BorderStyle = BorderStyle.FixedSingle
        picSRY.Image = CType(resources.GetObject("picSRY.Image"), Image)
        picSRY.Location = New Point(854, 70)
        picSRY.Name = "picSRY"
        picSRY.Size = New Size(209, 102)
        picSRY.SizeMode = PictureBoxSizeMode.StretchImage
        picSRY.TabIndex = 5
        picSRY.TabStop = False
        ' 
        ' picXO
        ' 
        picXO.BorderStyle = BorderStyle.FixedSingle
        picXO.Image = CType(resources.GetObject("picXO.Image"), Image)
        picXO.Location = New Point(1081, 70)
        picXO.Name = "picXO"
        picXO.Size = New Size(151, 102)
        picXO.SizeMode = PictureBoxSizeMode.StretchImage
        picXO.TabIndex = 6
        picXO.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(1039, 351)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(134, 35)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1303, 664)
        Controls.Add(btnExit)
        Controls.Add(picXO)
        Controls.Add(picSRY)
        Controls.Add(picLOL)
        Controls.Add(picIDK)
        Controls.Add(picBRB)
        Controls.Add(picBFF)
        Controls.Add(lblMessage)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Text Message Symbols"
        CType(picBFF, ComponentModel.ISupportInitialize).EndInit()
        CType(picBRB, ComponentModel.ISupportInitialize).EndInit()
        CType(picIDK, ComponentModel.ISupportInitialize).EndInit()
        CType(picLOL, ComponentModel.ISupportInitialize).EndInit()
        CType(picSRY, ComponentModel.ISupportInitialize).EndInit()
        CType(picXO, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents picBFF As PictureBox
    Friend WithEvents picBRB As PictureBox
    Friend WithEvents picIDK As PictureBox
    Friend WithEvents picLOL As PictureBox
    Friend WithEvents picSRY As PictureBox
    Friend WithEvents picXO As PictureBox
    Friend WithEvents btnExit As Button
End Class
