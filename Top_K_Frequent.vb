Public Class Top_K_Frequent
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
        Console.WriteLine("Please input the frequent target integer")
        Dim target = CInt(Console.ReadLine())

        Return target
    End Function

    Shared Function Frequent()
        Dim array As Integer() = InputArray()
        Dim target As Integer = Input()
        Dim final As Integer() = {}

        ' Group items and count
        Dim query = From item In array
                    Group By item Into Count()

        ' Add result to array
        For Each result In query
            If result.Count >= target Then
                System.Array.Resize(Of Integer)(final, final.Length + 1)
                final(final.Length - 1) = result.item
            End If
        Next

        ' Console result
        Console.WriteLine("[{0}]", String.Join(",", final))

        Return 0
    End Function
End Class
