Imports System.IO
Imports BaiqiSoft.LabelControl

Public Class Pasaportes_Manual

    Dim dt_crotales As DataTable
    Dim aux_crotales As New Crotales

    Private Sub Pasaportes_Manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Crear_dt_crotales()

    End Sub

    Public Sub Crear_dt_crotales()

        If dt_crotales Is Nothing Then dt_crotales = New DataTable

        If Not dt_crotales.Columns.Contains("Crotal") Then dt_crotales.Columns.Add("Crotal")
        If Not dt_crotales.Columns.Contains("Cod_barras") Then dt_crotales.Columns.Add("Cod_barras")

    End Sub

    Private Sub btn_crear_numeracion_Click(sender As Object, e As EventArgs) Handles btn_crear_numeracion.Click

        If txt_inicio.Text.Length = 0 Or txt_cantidad.Text.Length = 0 Then
            MessageBox.Show("No se puede dejar en blanco el inicio o la cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_crear_archivos.Enabled = False
            btn_imprimir.Enabled = False
            Exit Sub
        End If

        Dim crotal As String = ""
        Dim aux_crotal As Long = txt_inicio.Text.Substring(4, 10)
        Dim aux_crotal2 As Long
        Dim cod_barras As String = ""
        Dim digito As String
        Dim aux_cant As Integer = txt_cantidad.Text
        For i = 0 To aux_cant - 1
            aux_crotal2 = aux_crotal + i
            If aux_crotal2.ToString.Length = 10 Then
                digito = aux_crotales.DigitoDeControlParaBovino(aux_crotal2)
                crotal = "ES0" & digito & aux_crotal2
                cod_barras = "084" & aux_crotal2 & digito
                Dim fila As DataRow = dt_crotales.NewRow
                fila.Item("Crotal") = crotal
                fila.Item("Cod_barras") = cod_barras
                dt_crotales.Rows.Add(fila)
            Else
                digito = aux_crotales.DigitoDeControlParaBovino("0" & aux_crotal2)
                crotal = "ES0" & digito & "0" & aux_crotal2
                cod_barras = "084" & "0" & aux_crotal2 & digito
                Dim fila As DataRow = dt_crotales.NewRow
                fila.Item("Crotal") = crotal
                fila.Item("Cod_barras") = cod_barras
                dt_crotales.Rows.Add(fila)
            End If
        Next

        dgv_crotales.DataSource = dt_crotales
        dgv_crotales.Columns(0).Width = 70
        dgv_crotales.Columns(1).Width = 120
        dgv_crotales.Columns(2).Width = 120
        For j = 0 To dgv_crotales.Rows.Count - 1
            dgv_crotales.Rows(j).Cells(0).Value = True
        Next
        lbl_cartillas.Text = dgv_crotales.Rows.Count
        btn_crear_archivos.Enabled = True
        btn_imprimir.Enabled = True
        chk_Todo.Checked = True

    End Sub

    Private Sub Crear_Parser()

        Try
            Dim txt_Parser As String = My.Application.Info.DirectoryPath & "\Parser\STOCK_AND_" & txt_cantidad.Text & ".csv"
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

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click

        If chk_Todo.Checked Then
            Imprimir_Pedido_Completo()
        Else
            For i = 0 To dgv_crotales.Rows.Count - 1
                If dgv_crotales.Rows(i).Cells(0).Value Then
                    Imprimir_Pasaporte(dgv_crotales.Rows(i).Cells(1).Value, dgv_crotales.Rows(i).Cells(2).Value)
                End If
            Next
        End If
        dt_crotales.Clear()
        dgv_crotales.DataSource = Nothing

    End Sub

    Private Sub Crear_Archivo_Pegatinas()

        Try
            Dim oXls As Object
            Dim oLibro As Object
            Dim oHoja As Object

            oXls = CreateObject("Excel.Application")

            oLibro = oXls.WorkBooks.Add()
            oHoja = oLibro.Worksheets(1)

            Dim cantidad As Integer = 1
            Dim fila As Integer = 1
            Dim lineas As Integer
            If txt_cantidad.Text Mod 10 = 0 Then
                lineas = txt_cantidad.Text / 10
            Else
                lineas = (txt_cantidad.Text / 10) + 1
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
                    arTable(fila, cantidad - 1) = dgv_crotales.Rows(i).Cells(1).Value
                End If
                If cantidad = 10 Then
                    cantidad = 1
                    fila += 1
                Else
                    cantidad += 1
                End If
            Next
            Dim objxlRange As Object
            objxlRange = oHoja.Range("A" & 1 & ":J" & lineas + 1)
            objxlRange.Value = arTable

            oLibro.saveas(My.Application.Info.DirectoryPath & "\Pegatinas\STOCK_AND_" & txt_cantidad.Text & ".xls")

            oLibro.Close()
            oLibro = Nothing
            oXls.Quit()
            oXls = Nothing
            oHoja = Nothing
        Catch ex As Exception
            MessageBox.Show("Error al crear el archivo para las PEGATINAS " & vbCrLf & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_crear_archivos_Click(sender As Object, e As EventArgs) Handles btn_crear_archivos.Click

        Crear_Parser()
        Crear_Archivo_Pegatinas()

    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown

        If e.KeyCode = Keys.Enter Then
            btn_crear_numeracion.PerformClick()
        End If

    End Sub

#Region "DATAMARS LABEL"
    'IMPRESION CON DATAMARS LABEL
    Private Sub Imprimir_Pasaporte(ByVal crotal As String, ByVal cod_barras As String)

        Dim pasaporte As New LabelPrinting()

        pasaporte.OpenLabel(My.Application.Info.DirectoryPath & "\DMESP_Pasaporte_Bovino.blf")
        pasaporte.PageSetup.PrinterName = Form_Inicio.lbl_impresora.Text
        pasaporte.LicenseKey = "71P49Q8100W26Q168Y60"
        Dim printerVarNames(1) As String
        Dim printerVars(1) As String
        printerVarNames(0) = "Var01"
        printerVarNames(1) = "Var02"
        printerVars(0) = crotal
        printerVars(1) = cod_barras

        Dim m_DataTable As New DataTable
        For i = 0 To printerVarNames.Length - 1
            m_DataTable.Columns.Add(printerVarNames(i))
        Next
        pasaporte.DataSource = m_DataTable

        Dim row As DataRow = m_DataTable.NewRow
        For i = 0 To 1
            row(printerVarNames(i)) = printerVars(i)
        Next
        m_DataTable.Rows.Add(row)
        pasaporte.PrintOut(False)

    End Sub

    'IMPRESION CON DATAMARS LABEL
    Private Sub Imprimir_Pedido_Completo()

        Dim m_DataTable As New DataTable
        Dim printerVarNames(1) As String
        Dim printerVars(1) As String
        printerVarNames(0) = "Var01"
        printerVarNames(1) = "Var02"

        For i = 0 To printerVarNames.Length - 1
            m_DataTable.Columns.Add(printerVarNames(i))
        Next

        For i = 0 To dgv_crotales.Rows.Count - 1
            Dim pasaporte As New LabelPrinting()
            pasaporte.OpenLabel(My.Application.Info.DirectoryPath & "\DMESP_Pasaporte_Bovino.blf")
            pasaporte.PageSetup.PrinterName = Form_Inicio.lbl_impresora.Text
            pasaporte.LicenseKey = "71P49Q8100W26Q168Y60"

            pasaporte.DataSource = m_DataTable
            printerVars(0) = dgv_crotales.Rows(i).Cells(1).Value
            printerVars(1) = dgv_crotales.Rows(i).Cells(2).Value
            Dim row As DataRow = m_DataTable.NewRow
            For j = 0 To 1
                row(printerVarNames(j)) = printerVars(j)
            Next
            m_DataTable.Rows.Add(row)
            pasaporte.PrintOut(False)
            m_DataTable.Clear()
        Next

    End Sub

    Private Sub chk_Todo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Todo.CheckedChanged

        dgv_crotales.Enabled = Not chk_Todo.Checked
        If chk_Todo.Checked Then
            For i = 0 To dgv_crotales.Rows.Count - 1
                dgv_crotales.Rows(i).Cells(0).Value = True
            Next
        Else
            For i = 0 To dgv_crotales.Rows.Count - 1
                dgv_crotales.Rows(i).Cells(0).Value = False
            Next
            dgv_crotales.Columns(1).ReadOnly = True
            dgv_crotales.Columns(2).ReadOnly = True
        End If

    End Sub

#End Region
End Class