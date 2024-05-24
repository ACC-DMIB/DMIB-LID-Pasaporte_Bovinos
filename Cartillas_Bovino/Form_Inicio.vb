Public Class Form_Inicio
    Private Sub PEDIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEDIDOSToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        For Each c As Control In MdiChildren
            If TypeOf c Is Form1 Then
                c.BringToFront()
                c.Focus()
                Exit Sub
            End If
        Next

        Dim fc As New Form1

        With fc
            .MdiParent = Me
            .BringToFront()
            .Show()
        End With
        Cursor = Cursors.Default

    End Sub

    Private Sub MANUALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANUALESToolStripMenuItem.Click

        Cursor = Cursors.WaitCursor
        For Each c As Control In MdiChildren
            If TypeOf c Is Pasaportes_Manual Then
                c.BringToFront()
                c.Focus()
                Exit Sub
            End If
        Next

        Dim fc As New Pasaportes_Manual

        With fc
            .MdiParent = Me
            .BringToFront()
            .Show()
        End With
        Cursor = Cursors.Default

    End Sub

    Private Sub lbl_impresora_DropDownOpening(sender As Object, e As EventArgs)

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

    Private Sub Form_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ImpDefecto As New System.Drawing.Printing.PrinterSettings
        lbl_impresora.Text = INIRead(My.Application.Info.DirectoryPath & "\settings.ini",
                                   "Impresora",
                                   "Impresora",
                                   ImpDefecto.PrinterName)

    End Sub

    Private Sub lbl_impresora_DropDownOpening_1(sender As Object, e As EventArgs) Handles lbl_impresora.DropDownOpening

        Dim pkInstalledPrinters As String

        For i As Integer = lbl_impresora.DropDownItems.Count - 1 To 0 Step -1
            RemoveHandler lbl_impresora.DropDownItems(i).Click, AddressOf ImpresorasMenuItem_Click2
            lbl_impresora.DropDownItems.RemoveAt(i)
        Next

        lbl_impresora.DropDownItems.Clear()

        'Find all printers installed
        For Each pkInstalledPrinters In Drawing.Printing.PrinterSettings.InstalledPrinters
            lbl_impresora.DropDownItems.Add(pkInstalledPrinters)
            AddHandler lbl_impresora.DropDownItems(lbl_impresora.DropDownItems.Count - 1).Click, AddressOf ImpresorasMenuItem_Click2
        Next pkInstalledPrinters

    End Sub

    Private Sub ImpresorasMenuItem_Click2(sender As Object, e As EventArgs)

        Dim obj As ToolStripDropDownItem = sender
        lbl_impresora.Text = obj.Text
        INIWrite(My.Application.Info.DirectoryPath & "\Impresora.ini", My.Computer.Name, "Impresora", lbl_impresora.Text)

    End Sub
End Class