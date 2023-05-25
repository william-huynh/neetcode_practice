Public Class Product_Of_Array
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

    Shared Function ProductOfArrayExceptSelf()
        Dim array As Integer() = InputArray()
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
