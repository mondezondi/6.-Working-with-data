Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim yourmessage As String

        Dim birthyear As Integer
        yourmessage = "Happy bday! How old are you now?"

        MsgBox(yourmessage)
        birthyear = Val(InputBox("2000"))
        MsgBox("YOU ARE NOW" & 2023 - birthyear & "YEARS OLD")
    End Sub
End Class
