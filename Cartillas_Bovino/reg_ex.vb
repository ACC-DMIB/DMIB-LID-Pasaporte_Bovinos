Imports System.Text.RegularExpressions
Imports System.IO

Public Class reg_ex

    ' Regex Match code for VB
    Function MatchRegex(ByVal cadena As String, ByVal regular As String) As Boolean
        ' Regex match
        Dim options As RegexOptions = RegexOptions.None
        Dim regex As Regex = New Regex(regular, options)
        Dim input As String = cadena

        ' Check for match
        Dim isMatch As Boolean = regex.IsMatch(input)
        If isMatch Then
            ' TODO: Do something with result
            Return True
        End If

        Return False

    End Function


    Function PrimeraLineaTexto(ByVal nombreFichero As String, ByVal ConCabeceras As Boolean) As String
        Dim sr As StreamReader
        Dim sLine As String

        Try
            sr = New StreamReader(nombreFichero)
            sLine = sr.ReadLine()
            'Si tiene cabeceras hago otra lectura para que lo que leo sea la 2ª línea.
            If ConCabeceras Then sLine = sr.ReadLine
            sr.Close()
            If Not IsNothing(sLine) Then Return sLine

        Catch ex As Exception

        End Try

        Return ""

    End Function



End Class