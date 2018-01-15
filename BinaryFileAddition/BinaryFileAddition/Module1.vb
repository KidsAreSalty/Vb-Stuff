Module Module1
    Dim THEFILE As String = "H:\Computer Sci\VbMadeMeBinary.txt"
    Structure datest
        Dim name As String
        Dim age As Short
    End Structure
    Sub Main()
        Dim peps(10) As datest
        For i = 0 To 10 ' this loop just creates 11 records  2 characters and 2 byte integer check it with HxD
            peps(i).name = Chr(i + 97) & Chr(i + 97)
            peps(i).age = i + 16
        Next
        FileOpen(1, THEFILE, OpenMode.Binary, OpenAccess.Write, OpenShare.Default)
        FilePut(1, peps) ' note that the array name is used
        FileClose(1)
    End Sub

End Module
