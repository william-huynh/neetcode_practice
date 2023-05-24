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
        Console.WriteLine("Please input how many integers you would like to add")
        Dim count = CInt(Console.ReadLine())
        Dim array(count - 1) As Integer

        For i = 0 To count - 1
            Console.WriteLine("Please enter an integer")
            array(i) = CInt(Console.ReadLine())
        Next

        Dim isDuplicate As Boolean = IfDuplicate(array)
        Console.WriteLine(String.Format("nums = [{0}]", String.Join(", ", array)))
        Console.WriteLine(isDuplicate)

        Return 0
    End Function
End Class
