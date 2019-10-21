Public Class design

    Const vinteeum As Integer = 21

    Public Counter As Integer = 0
    Private Sub BtnDrawCard_Click(sender As Object, e As EventArgs) Handles btnDrawCard.Click
        Randomize()
        Counter = Counter + 1
        Dim Card1 As Integer
        Dim Card2 As Integer
        Dim Card3 As Integer

        If Counter >= 1 Then
            btnCheckScore.Enabled = True
        End If

        If Counter = 1 Then
            Card1 = (10 * Rnd() + 1)
            lblCard1.Text = Card1
            lblCard1.Visible = True
        End If
        If Counter = 2 Then
            Card2 = (10 * Rnd() + 1)
            lblcard2.Text = Card2
            lblcard2.Visible = True
        End If
        If Counter = 3 Then
            Card3 = (10 * Rnd() + 1)
            lblcard3.Text = Card3
            lblcard3.Visible = True
            If Counter >= 3 Then
                MsgBox("Não podes retirar mais cartas do baralho ")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ComputerCard1 As Integer
        Dim ComputerCard2 As Integer
        Dim ComputerCard3 As Integer

        ComputerCard1 = (10 * Rnd() + 1)
        ComputerCard2 = (10 * Rnd() + 1)
        ComputerCard3 = (10 * Rnd() + 1)

        lblComputercard1.Text = ComputerCard1
        lblComputercard2.Text = ComputerCard2
        lblComputercard3.Text = ComputerCard3

        btnCheckScore.Enabled = False

    End Sub

    Private Sub btnCheckScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckScore.Click
        Dim PlayerSum As Integer
        Dim ComputerSum As Integer

        lblComputercard1.Visible = True
        lblComputercard2.Visible = True
        lblComputercard3.Visible = True

        btnDrawCard.Enabled = False

        If Counter < 1 Then
            PlayerSum = Val(lblCard1.Text) + Val(lblcard2.Text)
            lblPlayersTotal.Text = PlayerSum
            lblPlayersTotal.Visible = True
        End If
        If Counter > 2 Then
            PlayerSum = Val(lblCard1.Text) + Val(lblcard2.Text) + Val(lblcard3.Text)
            lblPlayersTotal.Text = PlayerSum
            lblPlayersTotal.Visible = True
        End If

        If Counter > 3 Then
            PlayerSum = Val(lblCard1.Text) + Val(lblcard2.Text) + Val(lblcard3.Text)
            lblPlayersTotal.Text = PlayerSum
            lblPlayersTotal.Visible = True
        End If


        If Counter < 1 Then
            ComputerSum = Val(lblComputercard1.Text) + Val(lblComputercard2.Text)
            lblComputerTotal.Text = ComputerSum
            lblComputerTotal.Visible = True
        End If
        If Counter > 2 Then
            ComputerSum = Val(lblComputercard1.Text) + Val(lblComputercard2.Text) + Val(lblComputercard3.Text)
            lblComputerTotal.Text = ComputerSum
            lblComputerTotal.Visible = True
        End If

        If Counter > 3 Then
            ComputerSum = Val(lblComputercard1.Text) + Val(lblComputercard2.Text) + Val(lblComputercard3.Text)
            lblComputerTotal.Text = ComputerSum
            lblComputerTotal.Visible = True
        End If



        If lblPlayersTotal.Text = 21 And lblComputerTotal.Text < 21 Then
            MsgBox("Ganhaste")
        End If
        If lblPlayersTotal.Text = 21 And lblComputerTotal.Text > 21 Then
            MsgBox("Ganhaste")
        End If

        If lblPlayersTotal.Text = 21 And lblComputerTotal.Text = 21 Then
            MsgBox("Empate")
        End If

        If lblPlayersTotal.Text < 21 And lblComputerTotal.Text > 21 Then
            MsgBox("Ganhaste")
        End If

        If lblPlayersTotal.Text < 21 And lblComputerTotal.Text < 21 Then
            If lblPlayersTotal.Text = lblComputerTotal.Text Then
                MsgBox("Empate")
            End If

        Else
            If lblPlayersTotal.Text < lblComputerTotal.Text Then
                MsgBox("Perdeste")
            End If
        End If
    End Sub

    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Dim ComputerCard1 As Integer
        Dim ComputerCard2 As Integer
        Dim ComputerCard3 As Integer

        lblComputercard1.Visible = False
        lblComputercard2.Visible = False
        lblComputercard3.Visible = False
        lblComputercard1.Text = ""
        lblComputercard2.Text = ""
        lblComputercard3.Text = ""
        lblCard1.Text = ""
        lblcard2.Text = ""
        lblcard3.Text = ""
        Counter = 0

        ComputerCard1 = (10 * Rnd() + 1)
        ComputerCard2 = (10 * Rnd() + 1)
        ComputerCard3 = (10 * Rnd() + 1)

        lblComputercard1.Text = ComputerCard1
        lblComputercard2.Text = ComputerCard1
        lblComputercard3.Text = ComputerCard1

        btnDrawCard.Enabled = True
        btnCheckScore.Enabled = True

        lblCard1.Visible = False
        lblcard2.Visible = False
        lblcard3.Visible = False

    End Sub
End Class