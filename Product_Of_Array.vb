Public Class Product_Of_Array
    Shared Function ProductOfArrayExceptSelf()
        Dim array As Integer() = Input.InputIntegerArray()
        Dim product(array.Length - 1), temporary() As Integer

        ' array = array.Where(Function(item, index) index <> 2).ToArray

        For i = 0 To array.Length - 1
            product(i) = 1
            temporary = array
            temporary = temporary.Where(Function(item, index) index <> i).ToArray
            For j = 0 To temporary.Length - 1
                product(i) *= temporary(j)
            Next
        Next

        Console.WriteLine(String.Format("[{0}]", String.Join(",", product)))

        Return 0
    End Function
End Class
