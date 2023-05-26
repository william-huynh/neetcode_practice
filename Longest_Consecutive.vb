Public Class Longest_Consecutive
    Shared Function Consecutive()
        ' Initialize
        Dim array() As Integer = Input.InputIntegerArray()
        Dim hash As HashSet(Of Integer) = New HashSet(Of Integer)(array)
        Dim maxLength As Integer

        ' Find consecutive sequence
        For i = 0 To array.Length - 1
            If hash.Contains(array(i) - 1) Then
                Continue For
            End If

            Dim length As Integer
            While hash.Contains(array(i) + length)
                length += 1
            End While

            maxLength = Math.Max(maxLength, length)
        Next

        ' Console result
        Console.WriteLine("consecutive = " + maxLength.ToString())

        Return 0
    End Function
End Class
