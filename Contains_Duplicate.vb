Imports System
Imports System.Threading

Module Contains_Duplicate
    Dim j As Integer
    Function IfDuplicate(array)
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

    Function InputArray()
        Console.WriteLine("Please input how many integers you would like to add")
        Dim count = CInt(Console.ReadLine())
        Dim array(count - 1) As Integer

        For i = 0 To count - 1
            Console.WriteLine("Please enter an integer")
            array(i) = CInt(Console.ReadLine())
        Next

        Dim isDuplicate As Boolean = Contains_Duplicate.IfDuplicate(array)
        Console.WriteLine(String.Format("nums = [{0}]", String.Join(", ", array)))
        Console.WriteLine(isDuplicate)

        Return array
    End Function

    Sub Main()
        Contains_Duplicate.InputArray()

        Console.ReadKey()
        Environment.Exit(exitCode:=0)
    End Sub
End Module
