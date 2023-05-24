Public Class Two_Sum
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

    Shared Function Input()
        Console.WriteLine("Please input the target integer")
        Dim target = CInt(Console.ReadLine())

        Return target
    End Function

    Shared Function Sum()
        ' Input variables
        Dim array() As Integer = InputArray()
        Dim target As Integer = Input()
        Dim i = 0, j As Integer

        ' Find 2 number add up to target
        While i < array.Length
            j = i + 1
            While j < array.Length
                If (array(i) + array(j)) = target Then
                    Exit While
                End If
                j += 1
            End While
            If (array(i) + array(j)) = target Then
                Exit While
            End If
            i += 1
        End While

        ' Console log result
        Console.WriteLine(String.Format("nums = [{0}]", String.Join(", ", array)))
        Console.WriteLine("target = " + target.ToString())
        Console.WriteLine("[" + i.ToString() + "," + j.ToString() + "]")

        Return 0
    End Function
End Class
