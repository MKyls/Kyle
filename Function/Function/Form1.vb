Public Class Form1

    Function FunctionName() As String
        Return "Hello World!"
    End Function

    Function FunctName()
        Return 1000
    End Function
    Function Add(ByVal numOne As Integer, ByVal numTwo As Integer) As Integer
        Dim total As Integer
        total = numOne + numTwo

        Return total
    End Function

    Function HelloUser(ByVal name As String) As String
        Return "Good Evening, " + name + "!"
    End Function

    Function factorial(ByVal num As Integer) As Integer
        Dim result As Integer

        If (num = 1) Then
            Return 1
        Else
            Return result = factorial(num - 1) * num

        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(FunctionName)
        'MsgBox("number: " + FunctName.ToString())

        'MsgBox("10 + 30=" + Add(10, 30).ToString)
        'MsgBox(Add(1, 1).ToString)

        'MsgBox(HelloUser("Kyle Jaunty"))

        MsgBox(factorial(2).ToString())

    End Sub
End Class
