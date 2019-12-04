Imports System

Module Program
    Sub Main(args As String())
        If GetArgs(args) Is Nothing Then
            Throw New ArgumentNullException(NameOf(args))
        End If

        Console.WriteLine("Hello World!")
    End Sub

    Private Function GetArgs(args() As String) As String()
        Return args
    End Function
End Module
