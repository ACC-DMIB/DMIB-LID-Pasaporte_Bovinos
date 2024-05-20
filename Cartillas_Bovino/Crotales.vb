Imports System.IO

Public Class Crotales

    Public Sub Crear_dt_crotales(ByVal dt_crotales As DataTable)

        If dt_crotales Is Nothing Then dt_crotales = New DataTable

        If Not dt_crotales.Columns.Contains("Crotal") Then dt_crotales.Columns.Add("Crotal")
        If Not dt_crotales.Columns.Contains("Cod_barras") Then dt_crotales.Columns.Add("Cod_barras")

    End Sub
    ''' <summary>
    ''' Generamos el digito de crotal para el crotal del bovino a partir de los 10 últimos dígitos
    ''' </summary>
    ''' <param name="numero">Últimos 10 dígitos del crotal de bovino</param>
    ''' <returns></returns>
    Public Function DigitoDeControlParaBovino(ByVal numero As String) As String

        Dim suma As Integer
        Dim resto, digito1, digito2, digito3, digito4, digito5, digito6, digito7, digito8, digito9, digito10 As Integer

        Try
            If numero.Length >= 10 Then numero = numero.Substring(numero.Length - 10, 10)

            digito1 = Mid(numero, 1, 1)
            digito2 = Mid(numero, 2, 1)

            digito3 = Mid(numero, 3, 1)
            digito4 = Mid(numero, 4, 1)
            digito5 = Mid(numero, 5, 1)
            digito6 = Mid(numero, 6, 1)

            digito7 = Mid(numero, 7, 1)
            digito8 = Mid(numero, 8, 1)
            digito9 = Mid(numero, 9, 1)
            digito10 = Mid(numero, 10, 1)

            Dim parte1 As String = digito3 & digito4 & digito5 & digito6
            Dim parte2 As String = digito7 & digito8 & digito9 & digito10


            If (parte1 >= 150) And (parte1 < 200) Then
                suma = 18 + (digito1 + 2) + (digito2 + 4)
                suma = suma + (digito3 + 2) + (digito4 + 4)
                suma = suma + (digito5 + 2) + (digito6 + 4)
                suma = suma + (digito7 + 2) + (digito8 + 4)
                suma = suma + (digito9 + 2) + (digito10 + 4)
                resto = suma Mod 10
            Else
                suma = digito1 + (digito2 * 2)
                suma = suma + (digito3 * 3) + (digito4 * 4)
                suma = suma + (digito5 * 5) + (digito6 * 6)
                suma = suma + (digito7 * 7) + (digito8 * 8)
                suma = suma + (digito9 * 9) + (digito10)
                resto = Microsoft.VisualBasic.Right(CStr(suma), 1)
            End If

        Catch ex As Exception
            MsgBox("Error al calcular el digito de control para bovino. Avise a los técnicos. Gracias", MsgBoxStyle.Critical)
        End Try

        Return resto.ToString()

    End Function

    Public Sub Crear_Parser(ByVal dgv_crotales As DataGridView, ByVal pedido_PS As String, ByVal pedido As String, ByVal cliente As String, ByVal ganadero As String, ByVal cantidad As String)

        Try
            Dim txt_Parser As String = My.Application.Info.DirectoryPath & "\Parser\" & pedido_PS & "_" & pedido & "_" & cliente.Trim & "_" & ganadero.Trim & "_" & cantidad & ".csv"
            Dim sw_Parser As New StreamWriter(txt_Parser)

            sw_Parser.WriteLine("Var01,Var02,Var03,Var04,Var05,Var06")
            For i = 0 To dgv_crotales.Rows.Count - 1
                If dgv_crotales.Rows(i).Cells(0).Value Then
                    sw_Parser.WriteLine("ES," &                                                                 'Var01
                                        dgv_crotales.Rows(i).Cells(1).Value.ToString.Substring(2, 2) & "," &    'Var02
                                        dgv_crotales.Rows(i).Cells(1).Value.ToString.Substring(4, 2) & "," &    'Var03
                                        dgv_crotales.Rows(i).Cells(1).Value.ToString.Substring(6, 4) & "," &    'Var04
                                        dgv_crotales.Rows(i).Cells(1).Value.ToString.Substring(10, 4) & "," &   'Var05
                                        dgv_crotales.Rows(i).Cells(2).Value)                                    'Var06
                End If
            Next
            sw_Parser.Flush()
            sw_Parser.Close()
        Catch ex As Exception
            MessageBox.Show("Error al crear el archivo para el PARSER " & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Crear_Archivo_Pegatinas(ByVal dgv_crotales As DataGridView, ByVal cantidad As String, ByVal pedido_PS As String, ByVal pedido As String, ByVal cliente As String, ByVal ganadero As String)

        Try
            Dim oXls As Object
            Dim oLibro As Object
            Dim oHoja As Object

            oXls = CreateObject("Excel.Application")

            oLibro = oXls.WorkBooks.Add()
            oHoja = oLibro.Worksheets(1)

            Dim aux_cantidad As Integer = 1
            Dim fila As Integer = 1
            Dim lineas As Integer
            If cantidad Mod 10 = 0 Then
                lineas = cantidad / 10
            Else
                lineas = (cantidad / 10) + 1
            End If
            Dim arTable(lineas + 1, 10) As String
            arTable(0, 0) = "dato1"
            arTable(0, 1) = "dato2"
            arTable(0, 2) = "dato3"
            arTable(0, 3) = "dato4"
            arTable(0, 4) = "dato5"
            arTable(0, 5) = "dato6"
            arTable(0, 6) = "dato7"
            arTable(0, 7) = "dato8"
            arTable(0, 8) = "dato9"
            arTable(0, 9) = "dato10"
            For i = 0 To dgv_crotales.Rows.Count - 1
                If dgv_crotales.Rows(i).Cells(0).Value Then
                    arTable(fila, aux_cantidad - 1) = dgv_crotales.Rows(i).Cells(1).Value
                End If
                If aux_cantidad = 10 Then
                    aux_cantidad = 1
                    fila += 1
                Else
                    aux_cantidad += 1
                End If
            Next
            Dim objxlRange As Object
            objxlRange = oHoja.Range("A" & 1 & ":J" & lineas + 1)
            objxlRange.Value = arTable

            oLibro.saveas(My.Application.Info.DirectoryPath & "\Pegatinas\" & pedido_PS & "_" & pedido & "_" & cliente.Trim & "_" & ganadero.Trim & "_" & cantidad & ".xls")

            oLibro.Close()
            oLibro = Nothing
            oXls.Quit()
            oXls = Nothing
            oHoja = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al crear el archivo para las PEGATINAS " & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
