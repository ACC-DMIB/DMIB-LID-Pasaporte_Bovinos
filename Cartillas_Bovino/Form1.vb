Imports System.IO
Imports BaiqiSoft.LabelControl
Imports ClosedXML.Excel
Imports Microsoft.Office.Interop

Public Class Form1

    Dim dt_crotales As DataTable
    Dim dt_excel As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ImpDefecto As New System.Drawing.Printing.PrinterSettings
        Crear_dt_crotales()
        lbl_impresora.Text = INIRead(My.Application.Info.DirectoryPath & "\settings.ini",
                                    "Impresora",
                                    "Impresora",
                                    ImpDefecto.PrinterName)

    End Sub

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
        Crear_Parser()
        Crear_Archivo_Pegatinas()

    End Sub

#Region "DATAMARS LABEL"
    'IMPRESION CON DATAMARS LABEL
    Private Sub Imprimir_Pasaporte(ByVal crotal As String, ByVal cod_barras As String)

        Dim pasaporte As New LabelPrinting()

        pasaporte.OpenLabel(My.Application.Info.DirectoryPath & "\DMESP_Pasaporte_Bovino.blf")
        pasaporte.PageSetup.PrinterName = lbl_impresora.Text
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
            pasaporte.PageSetup.PrinterName = lbl_impresora.Text
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
#End Region


#Region "BARTENDER"
    'IMPRESION CON BARTENDER
    Private Sub Imprimir_Pedido()

        'Declaring a BarTender application variable 
        Dim btApp As BarTender.Application
        'Declaring a format variable 
        Dim btFormat As New BarTender.Format
        'btFormat = New BarTender.Format

        Try
            btApp = New BarTender.Application
            btApp.Visible = False
            btApp.Window.WindowState = BarTender.BtWindowState.btMinimize
            btApp.Window.Height = 400
            btApp.Window.Width = 650

            'Setting the BarTender format to open 
            btFormat = btApp.Formats.Open(My.Application.Info.DirectoryPath & "\bovinoOficial.btw", True, "")

            btFormat.IdenticalCopiesOfLabel = 1
            btFormat.NumberSerializedLabels = 1

            For i = 0 To dgv_crotales.Rows.Count - 1
                btFormat.SetNamedSubStringValue("code", dgv_crotales.Rows(i).Cells(1).Value)
                btFormat.SetNamedSubStringValue("barcode", dgv_crotales.Rows(i).Cells(2).Value)
                btFormat.PrintOut()
                btFormat.Save()
            Next

        Catch ex As Exception
        Finally
            ' cerramos el bartender
            ' Ending the BarTender process 
            If Not btApp Is Nothing Then
                btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
            End If
            btApp = Nothing
            btFormat = Nothing
        End Try
        'Instantiating the BarTender object 

    End Sub

    'IMPRESION CON BARTENDER
    Private Sub Imprimir_Cartilla_Suelta(ByVal crotal As String, ByVal cod_barras As String)

        'Declaring a BarTender application variable 
        Dim btApp As BarTender.Application
        'Declaring a format variable 
        Dim btFormat As New BarTender.Format

        Try
            btApp = New BarTender.Application
            btApp.Visible = False
            btApp.Window.WindowState = BarTender.BtWindowState.btMinimize
            btApp.Window.Height = 400
            btApp.Window.Width = 650

            'Setting the BarTender format to open 
            btFormat = btApp.Formats.Open(My.Application.Info.DirectoryPath & "\bovinoOficial.btw", True, "")

            btFormat.IdenticalCopiesOfLabel = 1
            btFormat.NumberSerializedLabels = 1

            btFormat.SetNamedSubStringValue("code", crotal)
            btFormat.SetNamedSubStringValue("barcode", cod_barras)
            btFormat.PrintOut()
            btFormat.Save()

        Catch ex As Exception
        Finally
            ' cerramos el bartender
            ' Ending the BarTender process 
            If Not btApp Is Nothing Then
                btApp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)
            End If
            btApp = Nothing
            btFormat = Nothing
        End Try
        'Instantiating the BarTender object 

    End Sub
#End Region

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim pedido As New Pedidos_OSDataSetTableAdapters.uspGetPedidoBovinoTableAdapter
        dgv_pedidos.DataSource = pedido.GetData(txt_pedido_PS.Text)

        If dgv_pedidos.Rows.Count > 0 Then
            gb_datos_pedido.Enabled = True
            If dgv_pedidos.Rows.Count = 1 Then
                Cargar_Datos_Pedido(0)
            End If
        Else
            MessageBox.Show("No existe ningún pedido de bovino para fabricar en DMES con el pedido " & txt_pedido_PS.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_inicio.Text = ""
            txt_final.Text = ""
            txt_cliente.Text = ""
            txt_ganadero.Text = ""
            txt_pedido.Text = ""
            txt_cantidad.Text = ""
            lbl_PedidoPS.Text = ""
            gb_datos_pedido.Enabled = False
        End If

    End Sub

    Private Sub dgv_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellClick

        Cargar_Datos_Pedido(e.RowIndex)

    End Sub

    Private Sub Cargar_Datos_Pedido(ByVal fila As Integer)

        txt_pedido.Text = dgv_pedidos.Rows(fila).Cells(0).Value
        txt_cliente.Text = dgv_pedidos.Rows(fila).Cells(1).Value
        txt_ganadero.Text = dgv_pedidos.Rows(fila).Cells(2).Value
        If dgv_pedidos.Rows(fila).Cells(3).Value <> "" Then
            txt_inicio.Text = dgv_pedidos.Rows(fila).Cells(3).Value
            txt_final.Text = dgv_pedidos.Rows(fila).Cells(4).Value
            btn_imprimir.Enabled = True
        Else
            MessageBox.Show("El pedido no tiene rango asociado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_imprimir.Enabled = False
            Exit Sub
        End If
        txt_cantidad.Text = dgv_pedidos.Rows(fila).Cells(5).Value
        lbl_PedidoPS.Text = txt_pedido_PS.Text
        Cargar_Listado_Crotales()
        chk_Todo.Checked = True

    End Sub

    Private Sub Cargar_Listado_Crotales()

        dgv_crotales.Enabled = False
        dt_crotales.Rows.Clear()
        Dim inicio As Long = txt_inicio.Text.Substring(4, 10)
        Dim final As Long = txt_final.Text.Substring(4, 10)
        Dim crotal As String = ""
        Dim cod_barras As String = ""
        Dim digito As String
        For i = inicio To final
            If inicio.ToString.Length = 10 Then
                digito = DigitoDeControlParaBovino(i)
                crotal = "ES0" & digito & i
                cod_barras = "084" & i & digito
                Dim fila As DataRow = dt_crotales.NewRow
                fila.Item("Crotal") = crotal
                fila.Item("Cod_barras") = cod_barras
                dt_crotales.Rows.Add(fila)
            Else
                digito = DigitoDeControlParaBovino("0" & i)
                crotal = "ES0" & digito & "0" & i
                cod_barras = "084" & "0" & i & digito
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

    End Sub

    Private Sub Crear_dt_crotales()

        If dt_crotales Is Nothing Then dt_crotales = New DataTable

        If Not dt_crotales.Columns.Contains("Crotal") Then dt_crotales.Columns.Add("Crotal")
        If Not dt_crotales.Columns.Contains("Cod_barras") Then dt_crotales.Columns.Add("Cod_barras")

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

    Private Function Get_Cantidad_Crotales() As Integer

        Dim cantidad As Integer = 0
        For i = 0 To dgv_crotales.Rows.Count - 1
            If dgv_crotales.Rows(i).Cells(0).Value Then
                cantidad += 1
            End If
        Next
        Return cantidad

    End Function

    Private Sub dgv_crotales_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_crotales.CurrentCellDirtyStateChanged

        If dgv_crotales.IsCurrentCellDirty Then
            dgv_crotales.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub dgv_crotales_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_crotales.CellValueChanged

        If e.RowIndex = -1 Then
            Exit Sub
        End If
        lbl_cartillas.Text = Get_Cantidad_Crotales()

    End Sub

    Private Sub lbl_impresora_DropDownOpening(sender As Object, e As EventArgs) Handles lbl_impresora.DropDownOpening

        Dim pkInstalledPrinters As String

        For i As Integer = lbl_impresora.DropDownItems.Count - 1 To 0 Step -1
            RemoveHandler lbl_impresora.DropDownItems(i).Click, AddressOf ImpresorasMenuItem_Click
            lbl_impresora.DropDownItems.RemoveAt(i)
        Next

        lbl_impresora.DropDownItems.Clear()

        'Find all printers installed
        For Each pkInstalledPrinters In Drawing.Printing.PrinterSettings.InstalledPrinters
            lbl_impresora.DropDownItems.Add(pkInstalledPrinters)
            AddHandler lbl_impresora.DropDownItems(lbl_impresora.DropDownItems.Count - 1).Click, AddressOf ImpresorasMenuItem_Click
        Next pkInstalledPrinters

    End Sub

    Private Sub ImpresorasMenuItem_Click(sender As Object, e As EventArgs)

        Dim obj As ToolStripDropDownItem = sender
        lbl_impresora.Text = obj.Text
        INIWrite(My.Application.Info.DirectoryPath & "\Settings.ini", "Impresora", "Impresora", lbl_impresora.Text)

    End Sub

    Private Sub Crear_Parser()

        Try
            Dim txt_Parser As String = My.Application.Info.DirectoryPath & "\Parser\" & txt_pedido_PS.Text & "_" & txt_pedido.Text & "_" & txt_cliente.Text.Trim & "_" & txt_ganadero.Text.Trim & "_" & txt_cantidad.Text & ".csv"
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

            oLibro.saveas(My.Application.Info.DirectoryPath & "\Pegatinas\" & txt_pedido_PS.Text & "_" & txt_pedido.Text & "_" & txt_cliente.Text.Trim & "_" & txt_ganadero.Text.Trim & "_" & txt_cantidad.Text & ".xls")

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
