Public Class Top_K_Frequent
    Shared Function Frequent()
        Dim array As Integer() = Input.InputIntegerArray()
        Dim target As Integer = Input.InputInteger("Please input the frequent target integer")
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
