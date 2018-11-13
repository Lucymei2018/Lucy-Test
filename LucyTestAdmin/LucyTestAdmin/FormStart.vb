Public Class FormStart

    Private Sub bntVersion1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntVersion1.Click
        Try
            
            msgbox ("This is version 11")
            
            Dim frm As New FormVersion1()
            Me.AddOwnedForm(frm)
            frm.Show()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class
