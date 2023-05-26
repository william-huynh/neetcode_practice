Public Class Input
    ' Input an integers array
    Shared Function InputIntegerArray()
        Console.WriteLine("Please input how many integers you would like to add")
        Dim count = CInt(Console.ReadLine())
        Dim array(count - 1) As Integer

        For i = 0 To count - 1
            Console.WriteLine("Please enter an integer")
            array(i) = CInt(Console.ReadLine())
        Next

        Return array
    End Function

    ' Input a integer
    Shared Function InputInteger(message As String)
        Console.WriteLine("{0}", message)
        Dim int = CInt(Console.ReadLine())

        Return int
    End Function

    ' Input a string
    Shared Function InputString(message As String)
        Console.WriteLine("{0}", message)
        Dim str As String = Console.ReadLine()

        Return str
    End Function
End Class
