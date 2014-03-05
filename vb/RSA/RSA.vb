Public Class RSA
    Dim BLOCKSIZE As Integer = 3

    Private Function gcd(ByVal n As Long, ByVal m As Long) As Long
        Dim p As Long = If(n > m, n, m)
        Dim q As Long = If(n < m, n, m)
        Dim r As Long = p Mod q

        While r > 0
            p = q
            q = r
            r = p Mod q
        End While

        Return q
    End Function

    Private Function splitMessage(ByVal msg As String) As ArrayList
        Dim blocks As ArrayList = New ArrayList
        For i As Integer = 0 To msg.Length Step BLOCKSIZE
            Dim block As String = ""
            For j As Integer = 0 To BLOCKSIZE - 1
                If i + j < msg.Length Then
                    block = block + msg(i + j)
                End If
            Next
            blocks.Add(block)
        Next
        Return blocks
    End Function

    Private Function splitCipher(ByVal msg As String) As ArrayList
        Dim blocks As ArrayList = New ArrayList
        Dim block As String
        For i As Integer = 0 To msg.Length - 1
            block = ""
            Dim blocksize As Integer = CInt(Mid(msg, i + 1, 1))
            For j As Integer = 0 To blocksize - 1
                block = block + Mid(msg, i + 2 + j, 1)
            Next
            i = i + blocksize
            blocks.Add(block)
        Next
        Return blocks
    End Function


    Private Function encrypt(ByVal msg As String, ByVal e As Long, ByVal n As Long) As String
        Dim blocks As ArrayList = splitMessage(msg)
        Dim msg1 As String = ""
        Dim val As String
        For i As Integer = 0 To blocks.Count - 2
            val = CStr(exp(Convert.ToInt32(blocks.Item(i)), e, n))
            msg1 = msg1 + CStr(val.Length) + val
        Next
        Return msg1
    End Function

    Private Function decrypt(ByVal blocks1 As String, ByVal d As Long, ByVal n As Long) As String
        Dim msg As String = ""
        Dim decoded As String
        Dim blocks As ArrayList = splitCipher(blocks1)

        For i As Integer = 0 To blocks.Count - 1
            decoded = exp(Convert.ToInt32(blocks.Item(i)), d, n)
            If CLng(decoded) < Math.Pow(10, BLOCKSIZE - 1) Then
                decoded = "0" + decoded
            End If

            msg += decoded
        Next
        Return msg
    End Function

    Private Function findD(ByVal n As Long, ByVal e As Long) As Long

        Dim i As Integer = 0
        While i < n
            If ((i * e) Mod n = 1) Then
                Return i
            End If
            i = i + 1
        End While

        Return -1
    End Function


    Private Function findE(ByVal n As Long, ByVal phin As Long) As Long
        Dim i As Integer = 0
        While Math.Pow(2, i) < n
            i = i + 1
        End While

        While i < phin
            If gcd(i, phin) = 1 Then
                Return i
            End If
            i = i + 1
        End While

        Return -1
    End Function

    Private Function exp(ByVal x As Integer, ByVal y As Integer, ByVal n As Integer) As Long
        Dim result As Long = x
        For i As Integer = 0 To y - 2
            result = (result * x) Mod n
        Next
        Return result
    End Function

    Private Function isPrime(ByVal n As Long) As Boolean
        If n < 2 Then
            Return False
        End If
        If n = 2 Then
            Return True
        End If
        If n Mod 2 = 0 Or n Mod 3 = 0 Then
            Return False
        End If

        Dim largestDivisor As Integer = Math.Floor(Math.Sqrt(n))
        For i As Integer = 5 To largestDivisor Step 6
            If n Mod i = 0 Or n Mod (i + 2) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function generatePrime(ByVal length As Integer) As Integer
        Dim x As Integer = randomRange(Math.Pow(10, length - 1), Math.Pow(10, length))
        While x < Math.Pow(10, length)
            If (isPrime(x)) Then
                Return x
            End If

            x = x + 1
        End While
        Return 107
    End Function

    Private Function randomRange(ByVal min As Integer, ByVal max As Integer) As Integer
        Return min + Math.Round((Rnd() * (max - min)))
    End Function

    Private Function encode(ByVal msg As String) As String
        Dim encoded As String = ""
        Dim block As String

        For i As Integer = 1 To msg.Length
            block = Asc(msg.Chars(i - 1))
            If block < Math.Pow(10, BLOCKSIZE - 1) Then
                block = "0" + block
            End If
            encoded += block
        Next
        Return encoded
    End Function

    Private Function decode(ByVal msg As String) As String
        Dim encoded As String = ""
        Dim block As String

        For i As Integer = 0 To msg.Length - 1 Step BLOCKSIZE
            block = ""
            For j As Integer = 0 To BLOCKSIZE - 1
                block += Mid(msg, i + j + 1, 1)
            Next
            encoded += Chr(block)
        Next
        Return encoded
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Long = nval.Text
        Dim e1 As Long = eval.Text

        inputmsg.Text = encrypted.Text

        decrypted.Text = encrypt(encode(encrypted.Text), e1, n)
        encrypted.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Long = nval1.Text
        Dim d As Long = dval.Text

        encrypted.Text = decode(decrypt(decrypted.Text, d, n))
        decrypted.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prime1.Text = generatePrime(3)
        prime2.Text = generatePrime(3)
        nvalue.Text = CLng(prime1.Text) * CLng(prime2.Text)
        Dim phin As Long = (CLng(prime1.Text) - 1) * (CLng(prime2.Text) - 1)
        evalue.Text = findE(CLng(nvalue.Text), phin)
        dvalue.Text = findD(phin, CLng(evalue.Text))
        nval.Text = nvalue.Text
        nval1.Text = nvalue.Text
        eval.Text = evalue.Text
        dval.Text = dvalue.Text
    End Sub
End Class
