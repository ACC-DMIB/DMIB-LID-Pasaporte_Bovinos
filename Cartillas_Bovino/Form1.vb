Public Class Form1

    Dim dt_crotales As DataTable

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
            Imprimir_Pedido()
        Else
            For i = 0 To dgv_crotales.Rows.Count - 1
                If dgv_crotales.Rows(i).Cells(0).Value Then
                    Imprimir_Cartilla_Suelta(dgv_crotales.Rows(i).Cells(1).Value, dgv_crotales.Rows(i).Cells(2).Value)
                End If
            Next
        End If

    End Sub

    Private Sub Imprimir_Pedido()

        'Declaring a BarTender application variable 
        Dim btApp As BarTender.Application
        'Declaring a format variable 
        Dim btFormat As BarTender.Format
        btFormat = New BarTender.Format

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

    Private Sub Imprimir_Cartilla_Suelta(ByVal crotal As String, ByVal cod_barras As String)

        'Declaring a BarTender application variable 
        Dim btApp As BarTender.Application
        'Declaring a format variable 
        Dim btFormat As BarTender.Format

        btFormat = New BarTender.Format

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

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim pedido As New Pedidos_OSDataSetTableAdapters.uspGetPedidoBovinoTableAdapter
        dgv_pedidos.DataSource = pedido.GetData(txt_pedido_PS.Text)

        If dgv_pedidos.Rows.Count > 0 Then
            gb_datos_pedido.Enabled = True
            If dgv_pedidos.Rows.Count = 1 Then
                Cargar_Datos_Pedido(0)
            End If
        Else
            MsgBox("No existe ningún pedido de bovino con ese pedido PS")
            txt_inicio.Text = ""
            txt_final.Text = ""
            txt_cliente.Text = ""
            txt_ganadero.Text = ""
            txt_pedido.Text = ""
            gb_datos_pedido.Enabled = False
        End If

    End Sub

    Private Sub dgv_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pedidos.CellClick

        Cargar_Datos_Pedido(e.RowIndex)

    End Sub

    Private Sub Cargar_Datos_Pedido(ByVal fila As Integer)

        btn_imprimir.Enabled = True
        txt_pedido.Text = dgv_pedidos.Rows(fila).Cells(0).Value
        txt_cliente.Text = dgv_pedidos.Rows(fila).Cells(1).Value
        txt_ganadero.Text = dgv_pedidos.Rows(fila).Cells(2).Value
        txt_inicio.Text = dgv_pedidos.Rows(fila).Cells(3).Value
        txt_final.Text = dgv_pedidos.Rows(fila).Cells(4).Value
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
End Class
