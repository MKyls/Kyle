Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim intData() As Integer = {1, 5, 7, 6, 8}
        'Dim StrArray() As String = {"Jay", "Blue", "Russel"}
        ''For Each value As String In StrArray
        ''    MsgBox(value.ToString())
        'Next
        'MsgBox(StrArray(0).ToString())
        'MsgBox(StrArray(1).ToString())
        'MsgBox(StrArray(2).ToString())
        'MsgBox(StrArray(3).ToString())

        'StrArray(0) = "Kyle"
        'MsgBox(StrArray(0).ToString())

        Dim ColorArray() As String = {"Red", "Orange", "Green", "Blue", "Violet"}
        Array.Sort(ColorArray)

        For Each value As String In ColorArray
            MsgBox(value.ToString())
        Next
        'Array.Reverse(ColorArray)
        'For Each value As String In ColorArray
        'MsgBox(value.ToString())


    End Sub
End Class
