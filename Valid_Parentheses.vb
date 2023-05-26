Public Class Valid_Parentheses
    Shared Function Parentheses()
        Dim str As String = Input.InputString("Please input brackets string")
        Dim bracketMap = New Dictionary(Of Char, Char) From {{"(", ")"}, {"{", "}"}, {"[", "]"}}
        Dim bracketStack As New Stack(Of Char)
        Dim result As Boolean = True

        ' Loop through string to verify
        For Each bracket In str
            If bracketMap.ContainsKey(bracket) Then
                bracketStack.Push(bracket)
            Else
                If bracketMap.Count = 0 Then
                    result = False
                    Exit For
                End If

                If bracketMap(bracketStack.Pop()) = bracket Then Continue For

                result = False
                Exit For
            End If
        Next

        ' Console result
        Console.WriteLine("{0}", result)

        Return 0
    End Function
End Class
