Public Class Contains_Duplicate
    Shared Function IfDuplicate(array)
        Dim j As Integer
        For i = 0 To array.Length - 1
            j = i + 1
            While j < array.Length
                If array(i) = array(j) Then
                    Return True
                End If
                j += 1
            End While
        Next
        Return False
    End Function

    Shared Function Duplicate()
        Dim arr() As Integer = Input.InputIntegerArray()

        Dim isDuplicate As Boolean = IfDuplicate(arr)

        Console.WriteLine(String.Format("nums = [{0}]", String.Join(", ", arr)))
        Console.WriteLine(isDuplicate)

        Return 0
    End Function
End Class
