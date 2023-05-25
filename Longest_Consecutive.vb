Public Class Longest_Consecutive
    Shared Function InputArray()
        Console.WriteLine("Please input how many integers you would like to add")
        Dim count = CInt(Console.ReadLine())
        Dim array(count - 1) As Integer

        For i = 0 To count - 1
            Console.WriteLine("Please enter " + i.ToString() + " integer")
            array(i) = CInt(Console.ReadLine())
        Next

        Return array
    End Function

    Shared Function Consecutive()
        ' Initialize
        Dim array() As Integer = InputArray()
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
