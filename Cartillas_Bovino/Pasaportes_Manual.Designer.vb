<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasaportes_Manual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pasaportes_Manual))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_crear_numeracion = New System.Windows.Forms.Button()
        Me.txt_inicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.dgv_crotales = New System.Windows.Forms.DataGridView()
        Me.Imprimir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_Todo = New System.Windows.Forms.CheckBox()
        Me.lbl_cartillas = New System.Windows.Forms.Label()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_crear_archivos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gb_tipo = New System.Windows.Forms.GroupBox()
        Me.chk_sindig = New System.Windows.Forms.CheckBox()
        Me.chk_condig = New System.Windows.Forms.CheckBox()
        Me.gb_longitud = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_14 = New System.Windows.Forms.CheckBox()
        Me.chk_12 = New System.Windows.Forms.CheckBox()
        Me.chk_10 = New System.Windows.Forms.CheckBox()
        Me.lb_formato = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgv_crotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gb_tipo.SuspendLayout()
        Me.gb_longitud.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio"
        '
        'btn_crear_numeracion
        '
        Me.btn_crear_numeracion.Enabled = False
        Me.btn_crear_numeracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_numeracion.FlatAppearance.BorderSize = 2
        Me.btn_crear_numeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear_numeracion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_crear_numeracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_numeracion.Image = CType(resources.GetObject("btn_crear_numeracion.Image"), System.Drawing.Image)
        Me.btn_crear_numeracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_crear_numeracion.Location = New System.Drawing.Point(398, 416)
        Me.btn_crear_numeracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_crear_numeracion.Name = "btn_crear_numeracion"
        Me.btn_crear_numeracion.Size = New System.Drawing.Size(253, 59)
        Me.btn_crear_numeracion.TabIndex = 2
        Me.btn_crear_numeracion.Text = "GENERAR NUMERACIÓN"
        Me.btn_crear_numeracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_crear_numeracion.UseVisualStyleBackColor = True
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(101, 16)
        Me.txt_inicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_inicio.MaxLength = 14
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(228, 22)
        Me.txt_inicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Location = New System.Drawing.Point(101, 71)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cantidad.MaxLength = 4
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(228, 22)
        Me.txt_cantidad.TabIndex = 1
        '
        'dgv_crotales
        '
        Me.dgv_crotales.AllowUserToAddRows = False
        Me.dgv_crotales.AllowUserToDeleteRows = False
        Me.dgv_crotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_crotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imprimir})
        Me.dgv_crotales.Location = New System.Drawing.Point(16, 121)
        Me.dgv_crotales.Name = "dgv_crotales"
        Me.dgv_crotales.RowHeadersWidth = 51
        Me.dgv_crotales.Size = New System.Drawing.Size(376, 480)
        Me.dgv_crotales.TabIndex = 20
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.MinimumWidth = 6
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 608)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Pasaportes a imprimir"
        '
        'chk_Todo
        '
        Me.chk_Todo.AutoSize = True
        Me.chk_Todo.Location = New System.Drawing.Point(15, 607)
        Me.chk_Todo.Name = "chk_Todo"
        Me.chk_Todo.Size = New System.Drawing.Size(158, 20)
        Me.chk_Todo.TabIndex = 22
        Me.chk_Todo.Text = "Imprimir todo el pedido"
        Me.chk_Todo.UseVisualStyleBackColor = True
        '
        'lbl_cartillas
        '
        Me.lbl_cartillas.AutoSize = True
        Me.lbl_cartillas.Location = New System.Drawing.Point(373, 608)
        Me.lbl_cartillas.Name = "lbl_cartillas"
        Me.lbl_cartillas.Size = New System.Drawing.Size(15, 16)
        Me.lbl_cartillas.TabIndex = 24
        Me.lbl_cartillas.Text = "0"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Enabled = False
        Me.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_imprimir.FlatAppearance.BorderSize = 2
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_imprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_imprimir.Location = New System.Drawing.Point(398, 542)
        Me.btn_imprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(253, 59)
        Me.btn_imprimir.TabIndex = 4
        Me.btn_imprimir.Text = "IMPRIMIR PASAPORTES"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_crear_archivos
        '
        Me.btn_crear_archivos.Enabled = False
        Me.btn_crear_archivos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_archivos.FlatAppearance.BorderSize = 2
        Me.btn_crear_archivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear_archivos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_crear_archivos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_archivos.Image = CType(resources.GetObject("btn_crear_archivos.Image"), System.Drawing.Image)
        Me.btn_crear_archivos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_crear_archivos.Location = New System.Drawing.Point(398, 479)
        Me.btn_crear_archivos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_crear_archivos.Name = "btn_crear_archivos"
        Me.btn_crear_archivos.Size = New System.Drawing.Size(253, 59)
        Me.btn_crear_archivos.TabIndex = 3
        Me.btn_crear_archivos.Text = "CREAR ARCHIVOS"
        Me.btn_crear_archivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_crear_archivos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gb_tipo)
        Me.GroupBox1.Controls.Add(Me.gb_longitud)
        Me.GroupBox1.Location = New System.Drawing.Point(398, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 395)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FORMATOS VÁLIDOS"
        '
        'gb_tipo
        '
        Me.gb_tipo.Controls.Add(Me.chk_sindig)
        Me.gb_tipo.Controls.Add(Me.chk_condig)
        Me.gb_tipo.Enabled = False
        Me.gb_tipo.Location = New System.Drawing.Point(6, 308)
        Me.gb_tipo.Name = "gb_tipo"
        Me.gb_tipo.Size = New System.Drawing.Size(255, 81)
        Me.gb_tipo.TabIndex = 1
        Me.gb_tipo.TabStop = False
        Me.gb_tipo.Text = "Tipo de numeración"
        '
        'chk_sindig
        '
        Me.chk_sindig.AutoSize = True
        Me.chk_sindig.Location = New System.Drawing.Point(6, 47)
        Me.chk_sindig.Name = "chk_sindig"
        Me.chk_sindig.Size = New System.Drawing.Size(181, 20)
        Me.chk_sindig.TabIndex = 2
        Me.chk_sindig.Text = "SIN DÍGITO DE CONTROL"
        Me.chk_sindig.UseVisualStyleBackColor = True
        '
        'chk_condig
        '
        Me.chk_condig.AutoSize = True
        Me.chk_condig.Location = New System.Drawing.Point(6, 21)
        Me.chk_condig.Name = "chk_condig"
        Me.chk_condig.Size = New System.Drawing.Size(188, 20)
        Me.chk_condig.TabIndex = 1
        Me.chk_condig.Text = "CON DÍGITO DE CONTROL"
        Me.chk_condig.UseVisualStyleBackColor = True
        '
        'gb_longitud
        '
        Me.gb_longitud.Controls.Add(Me.Label12)
        Me.gb_longitud.Controls.Add(Me.Label11)
        Me.gb_longitud.Controls.Add(Me.Label9)
        Me.gb_longitud.Controls.Add(Me.Label10)
        Me.gb_longitud.Controls.Add(Me.Label8)
        Me.gb_longitud.Controls.Add(Me.Label6)
        Me.gb_longitud.Controls.Add(Me.Label5)
        Me.gb_longitud.Controls.Add(Me.Label4)
        Me.gb_longitud.Controls.Add(Me.Label3)
        Me.gb_longitud.Controls.Add(Me.chk_14)
        Me.gb_longitud.Controls.Add(Me.chk_12)
        Me.gb_longitud.Controls.Add(Me.chk_10)
        Me.gb_longitud.Enabled = False
        Me.gb_longitud.Location = New System.Drawing.Point(6, 21)
        Me.gb_longitud.Name = "gb_longitud"
        Me.gb_longitud.Size = New System.Drawing.Size(256, 281)
        Me.gb_longitud.TabIndex = 0
        Me.gb_longitud.TabStop = False
        Me.gb_longitud.Text = "Longitud"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(11, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "ES + 27 + CA + 00000000(8 dig)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(11, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "ES + 22 + CA + 00000000(8 dig)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(11, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "ES +DC + CA + 00000000(8 dig)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(11, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "27 + CA + 00000000(8 dig)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(11, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "22 + CA + 00000000(8 dig)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(11, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "DC + CA + 00000000(8 dig)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(11, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "CA + 00000000(8 dig)"
        '
        'chk_14
        '
        Me.chk_14.AutoSize = True
        Me.chk_14.Location = New System.Drawing.Point(6, 145)
        Me.chk_14.Name = "chk_14"
        Me.chk_14.Size = New System.Drawing.Size(133, 20)
        Me.chk_14.TabIndex = 2
        Me.chk_14.Text = "14 CARACTERES"
        Me.chk_14.UseVisualStyleBackColor = True
        '
        'chk_12
        '
        Me.chk_12.AutoSize = True
        Me.chk_12.Location = New System.Drawing.Point(6, 65)
        Me.chk_12.Name = "chk_12"
        Me.chk_12.Size = New System.Drawing.Size(133, 20)
        Me.chk_12.TabIndex = 1
        Me.chk_12.Text = "12 CARACTERES"
        Me.chk_12.UseVisualStyleBackColor = True
        '
        'chk_10
        '
        Me.chk_10.AutoSize = True
        Me.chk_10.Location = New System.Drawing.Point(6, 21)
        Me.chk_10.Name = "chk_10"
        Me.chk_10.Size = New System.Drawing.Size(133, 20)
        Me.chk_10.TabIndex = 0
        Me.chk_10.Text = "10 CARACTERES"
        Me.chk_10.UseVisualStyleBackColor = True
        '
        'lb_formato
        '
        Me.lb_formato.AutoSize = True
        Me.lb_formato.BackColor = System.Drawing.Color.Transparent
        Me.lb_formato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lb_formato.ForeColor = System.Drawing.Color.Red
        Me.lb_formato.Location = New System.Drawing.Point(98, 46)
        Me.lb_formato.Name = "lb_formato"
        Me.lb_formato.Size = New System.Drawing.Size(161, 16)
        Me.lb_formato.TabIndex = 26
        Me.lb_formato.Text = "FORMATO INCORRECTO"
        Me.lb_formato.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(11, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "DC=Digito Control (00 a 09)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(10, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "CA=Com. Autónoma (01 a 17)"
        '
        'Pasaportes_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(671, 639)
        Me.Controls.Add(Me.lb_formato)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_crear_archivos)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.lbl_cartillas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chk_Todo)
        Me.Controls.Add(Me.dgv_crotales)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_inicio)
        Me.Controls.Add(Me.btn_crear_numeracion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pasaportes_Manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PASAPORTES MANUAL"
        CType(Me.dgv_crotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gb_tipo.ResumeLayout(False)
        Me.gb_tipo.PerformLayout()
        Me.gb_longitud.ResumeLayout(False)
        Me.gb_longitud.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_crear_numeracion As Button
    Friend WithEvents txt_inicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents dgv_crotales As DataGridView
    Friend WithEvents Imprimir As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents chk_Todo As CheckBox
    Friend WithEvents lbl_cartillas As Label
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents btn_crear_archivos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb_tipo As GroupBox
    Friend WithEvents chk_sindig As CheckBox
    Friend WithEvents chk_condig As CheckBox
    Friend WithEvents gb_longitud As GroupBox
    Friend WithEvents chk_14 As CheckBox
    Friend WithEvents chk_12 As CheckBox
    Friend WithEvents chk_10 As CheckBox
    Friend WithEvents lb_formato As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
