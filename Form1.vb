Public Class formMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim a As Integer
        a = MsgBox("Exit?", vbOKCancel)
        If a = vbOK Then
            Application.Exit()
        Else
            'Do nothing
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInfoWelcome.Click

        AboutBox1.Show()
    End Sub

    Private Sub lblPublisher_Click(sender As Object, e As EventArgs) Handles lblPublisher.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblSearchInfo_Click(sender As Object, e As EventArgs) Handles lblSearchInfo.Click

    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        If chkBoxAut.Checked = False And chkBoxTitle.Checked = False And chkBoxPublisher.Checked = False And chkBoxPubDate.Checked = False And chkBoxLoc.Checked = False Then
            MsgBox("Error: no search category selected. Please select one or more category to search in and try again.")
        End If
    End Sub
End Class
