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
        CType(Me.dgv_crotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio"
        '
        'btn_crear_numeracion
        '
        Me.btn_crear_numeracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_numeracion.FlatAppearance.BorderSize = 2
        Me.btn_crear_numeracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear_numeracion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_crear_numeracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_crear_numeracion.Image = CType(resources.GetObject("btn_crear_numeracion.Image"), System.Drawing.Image)
        Me.btn_crear_numeracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_crear_numeracion.Location = New System.Drawing.Point(398, 227)
        Me.btn_crear_numeracion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_crear_numeracion.Name = "btn_crear_numeracion"
        Me.btn_crear_numeracion.Size = New System.Drawing.Size(253, 59)
        Me.btn_crear_numeracion.TabIndex = 1
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
        Me.txt_inicio.Size = New System.Drawing.Size(228, 26)
        Me.txt_inicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(101, 71)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cantidad.MaxLength = 4
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(228, 26)
        Me.txt_cantidad.TabIndex = 4
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
        Me.dgv_crotales.Size = New System.Drawing.Size(376, 401)
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
        Me.Label7.Location = New System.Drawing.Point(220, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Cartillas a imprimir"
        '
        'chk_Todo
        '
        Me.chk_Todo.AutoSize = True
        Me.chk_Todo.Location = New System.Drawing.Point(16, 530)
        Me.chk_Todo.Name = "chk_Todo"
        Me.chk_Todo.Size = New System.Drawing.Size(198, 23)
        Me.chk_Todo.TabIndex = 22
        Me.chk_Todo.Text = "Imprimir todo el pedido"
        Me.chk_Todo.UseVisualStyleBackColor = True
        '
        'lbl_cartillas
        '
        Me.lbl_cartillas.AutoSize = True
        Me.lbl_cartillas.Location = New System.Drawing.Point(374, 531)
        Me.lbl_cartillas.Name = "lbl_cartillas"
        Me.lbl_cartillas.Size = New System.Drawing.Size(18, 19)
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
        Me.btn_imprimir.Location = New System.Drawing.Point(398, 463)
        Me.btn_imprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(253, 59)
        Me.btn_imprimir.TabIndex = 25
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
        Me.btn_crear_archivos.Location = New System.Drawing.Point(398, 345)
        Me.btn_crear_archivos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_crear_archivos.Name = "btn_crear_archivos"
        Me.btn_crear_archivos.Size = New System.Drawing.Size(253, 59)
        Me.btn_crear_archivos.TabIndex = 27
        Me.btn_crear_archivos.Text = "CREAR ARCHIVOS"
        Me.btn_crear_archivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_crear_archivos.UseVisualStyleBackColor = True
        '
        'Pasaportes_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 568)
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
End Class
