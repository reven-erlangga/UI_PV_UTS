Public Class Generate
    Public Function InvoiceNumber(ByVal lastNumber As String) As String

        If lastNumber.Length <> 7 Then
            Throw New ArgumentException("Incorrect length", "lastNumber")
        End If

        If lastNumber.StartsWith("G") = False Then
            Throw New ArgumentException("Incorrect start character", "lastNumber")
        End If

        Dim letterPortion As Char = lastNumber.Chars(1)

        If letterPortion < "A"c Or letterPortion > "Z"c Then
            Throw New ArgumentException("Non-letter second character", "lastNumber")
        End If

        If letterPortion = "I"c Or letterPortion = "O"c Then
            Throw New ArgumentException("Invalid second character", "lastNumber")
        End If

        Dim numericPortionString As String = lastNumber.Substring(2)
        Dim numericPortion As Integer

        If Integer.TryParse(numericPortionString, numericPortion) = False Then
            Throw New ArgumentException("Invalid numeric portion", "lastNumber")
        End If

        If numericPortion = 99999 Then
            If letterPortion = "Z"c Then
                Throw New ArgumentException("No more receipt numbers possible", "lastNumber")
            End If

            numericPortion = 0
            letterPortion = letterPortion + Chr(1)

            If letterPortion = "I"c Or letterPortion = "O"c Then
                letterPortion = letterPortion + Chr(1)
            End If
        Else
            numericPortion = numericPortion + 1
        End If

        Return String.Format("G{0}{1:00000}", letterPortion, numericPortion)
    End Function
End Class
