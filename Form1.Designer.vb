<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class design
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(design))
        Me.btnDrawCard = New System.Windows.Forms.Button()
        Me.lblCard1 = New System.Windows.Forms.Label()
        Me.lblcard2 = New System.Windows.Forms.Label()
        Me.lblcard3 = New System.Windows.Forms.Label()
        Me.lblComputercard1 = New System.Windows.Forms.Label()
        Me.lblComputercard2 = New System.Windows.Forms.Label()
        Me.lblComputercard3 = New System.Windows.Forms.Label()
        Me.btnCheckScore = New System.Windows.Forms.Button()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPlayersTotal = New System.Windows.Forms.Label()
        Me.lblComputerTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrawCard
        '
        Me.btnDrawCard.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawCard.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnDrawCard.Location = New System.Drawing.Point(14, 410)
        Me.btnDrawCard.Name = "btnDrawCard"
        Me.btnDrawCard.Size = New System.Drawing.Size(112, 63)
        Me.btnDrawCard.TabIndex = 0
        Me.btnDrawCard.Text = "Draw Card"
        Me.btnDrawCard.UseVisualStyleBackColor = True
        '
        'lblCard1
        '
        Me.lblCard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCard1.Location = New System.Drawing.Point(14, 70)
        Me.lblCard1.Name = "lblCard1"
        Me.lblCard1.Size = New System.Drawing.Size(55, 80)
        Me.lblCard1.TabIndex = 1
        Me.lblCard1.Visible = False
        '
        'lblcard2
        '
        Me.lblcard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcard2.Location = New System.Drawing.Point(86, 70)
        Me.lblcard2.Name = "lblcard2"
        Me.lblcard2.Size = New System.Drawing.Size(55, 80)
        Me.lblcard2.TabIndex = 2
        Me.lblcard2.Visible = False
        '
        'lblcard3
        '
        Me.lblcard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcard3.Location = New System.Drawing.Point(158, 70)
        Me.lblcard3.Name = "lblcard3"
        Me.lblcard3.Size = New System.Drawing.Size(55, 80)
        Me.lblcard3.TabIndex = 3
        Me.lblcard3.Visible = False
        '
        'lblComputercard1
        '
        Me.lblComputercard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputercard1.Location = New System.Drawing.Point(545, 70)
        Me.lblComputercard1.Name = "lblComputercard1"
        Me.lblComputercard1.Size = New System.Drawing.Size(55, 80)
        Me.lblComputercard1.TabIndex = 6
        Me.lblComputercard1.Visible = False
        '
        'lblComputercard2
        '
        Me.lblComputercard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputercard2.Location = New System.Drawing.Point(626, 70)
        Me.lblComputercard2.Name = "lblComputercard2"
        Me.lblComputercard2.Size = New System.Drawing.Size(55, 80)
        Me.lblComputercard2.TabIndex = 7
        Me.lblComputercard2.Visible = False
        '
        'lblComputercard3
        '
        Me.lblComputercard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputercard3.Location = New System.Drawing.Point(707, 70)
        Me.lblComputercard3.Name = "lblComputercard3"
        Me.lblComputercard3.Size = New System.Drawing.Size(55, 80)
        Me.lblComputercard3.TabIndex = 8
        Me.lblComputercard3.Visible = False
        '
        'btnCheckScore
        '
        Me.btnCheckScore.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckScore.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnCheckScore.Location = New System.Drawing.Point(139, 410)
        Me.btnCheckScore.Name = "btnCheckScore"
        Me.btnCheckScore.Size = New System.Drawing.Size(112, 63)
        Me.btnCheckScore.TabIndex = 9
        Me.btnCheckScore.Text = "Check Score"
        Me.btnCheckScore.UseVisualStyleBackColor = True
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.ForeColor = System.Drawing.SystemColors.MenuText
        Me.btnPlayAgain.Location = New System.Drawing.Point(264, 410)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(112, 63)
        Me.btnPlayAgain.TabIndex = 10
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Pontos do Jogador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkCyan
        Me.Label2.Font = New System.Drawing.Font("Old English Text MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(560, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pontos do Computador"
        '
        'lblPlayersTotal
        '
        Me.lblPlayersTotal.AutoSize = True
        Me.lblPlayersTotal.Location = New System.Drawing.Point(115, 45)
        Me.lblPlayersTotal.Name = "lblPlayersTotal"
        Me.lblPlayersTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayersTotal.TabIndex = 13
        '
        'lblComputerTotal
        '
        Me.lblComputerTotal.AutoSize = True
        Me.lblComputerTotal.Location = New System.Drawing.Point(652, 45)
        Me.lblComputerTotal.Name = "lblComputerTotal"
        Me.lblComputerTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblComputerTotal.TabIndex = 14
        '
        'design
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.BlackJack_Experimental.My.Resources.Resources.bckgrnd_blckjck
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.lblComputerTotal)
        Me.Controls.Add(Me.lblPlayersTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.btnCheckScore)
        Me.Controls.Add(Me.lblComputercard3)
        Me.Controls.Add(Me.lblComputercard2)
        Me.Controls.Add(Me.lblComputercard1)
        Me.Controls.Add(Me.lblcard3)
        Me.Controls.Add(Me.lblcard2)
        Me.Controls.Add(Me.lblCard1)
        Me.Controls.Add(Me.btnDrawCard)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "design"
        Me.Text = "BlackJack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDrawCard As Button
    Friend WithEvents lblCard1 As Label
    Friend WithEvents lblcard2 As Label
    Friend WithEvents lblcard3 As Label
    Friend WithEvents lblComputercard1 As Label
    Friend WithEvents lblComputercard2 As Label
    Friend WithEvents lblComputercard3 As Label
    Friend WithEvents btnCheckScore As Button
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPlayersTotal As Label
    Friend WithEvents lblComputerTotal As Label
End Class
