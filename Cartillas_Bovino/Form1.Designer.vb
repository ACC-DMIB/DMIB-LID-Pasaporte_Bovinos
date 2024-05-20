<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.txt_inicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_final = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_pedidos = New System.Windows.Forms.DataGridView()
        Me.PedidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GanaderoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetPedidoBovinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pedidos_OSDataSet = New Cartillas_Bovino.Pedidos_OSDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_pedido_PS = New System.Windows.Forms.TextBox()
        Me.gb_datos_pedido = New System.Windows.Forms.GroupBox()
        Me.lbl_PedidoPS = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_cartillas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_Todo = New System.Windows.Forms.CheckBox()
        Me.dgv_crotales = New System.Windows.Forms.DataGridView()
        Me.Imprimir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txt_pedido = New System.Windows.Forms.TextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.txt_ganadero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UspGetPedidoBovinoTableAdapter = New Cartillas_Bovino.Pedidos_OSDataSetTableAdapters.uspGetPedidoBovinoTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetPedidoBovinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pedidos_OSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_datos_pedido.SuspendLayout()
        CType(Me.dgv_crotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.White
        Me.btn_imprimir.Enabled = False
        Me.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_imprimir.FlatAppearance.BorderSize = 2
        Me.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_imprimir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(17, 277)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(162, 48)
        Me.btn_imprimir.TabIndex = 3
        Me.btn_imprimir.Text = "    IMPRIMIR"
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(105, 173)
        Me.txt_inicio.MaxLength = 14
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.ReadOnly = True
        Me.txt_inicio.Size = New System.Drawing.Size(172, 26)
        Me.txt_inicio.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DESDE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "HASTA"
        '
        'txt_final
        '
        Me.txt_final.Location = New System.Drawing.Point(105, 217)
        Me.txt_final.MaxLength = 14
        Me.txt_final.Name = "txt_final"
        Me.txt_final.ReadOnly = True
        Me.txt_final.Size = New System.Drawing.Size(172, 26)
        Me.txt_final.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.dgv_pedidos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_buscar)
        Me.GroupBox2.Controls.Add(Me.txt_pedido_PS)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(859, 196)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CARGAR PEDIDO"
        '
        'dgv_pedidos
        '
        Me.dgv_pedidos.AllowUserToAddRows = False
        Me.dgv_pedidos.AllowUserToDeleteRows = False
        Me.dgv_pedidos.AutoGenerateColumns = False
        Me.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PedidoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.GanaderoDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.HastaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.dgv_pedidos.DataSource = Me.UspGetPedidoBovinoBindingSource
        Me.dgv_pedidos.Location = New System.Drawing.Point(6, 72)
        Me.dgv_pedidos.Name = "dgv_pedidos"
        Me.dgv_pedidos.ReadOnly = True
        Me.dgv_pedidos.RowHeadersWidth = 51
        Me.dgv_pedidos.Size = New System.Drawing.Size(847, 118)
        Me.dgv_pedidos.TabIndex = 9
        '
        'PedidoDataGridViewTextBoxColumn
        '
        Me.PedidoDataGridViewTextBoxColumn.DataPropertyName = "Pedido"
        Me.PedidoDataGridViewTextBoxColumn.HeaderText = "Pedido"
        Me.PedidoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PedidoDataGridViewTextBoxColumn.Name = "PedidoDataGridViewTextBoxColumn"
        Me.PedidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PedidoDataGridViewTextBoxColumn.Width = 125
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 200
        '
        'GanaderoDataGridViewTextBoxColumn
        '
        Me.GanaderoDataGridViewTextBoxColumn.DataPropertyName = "Ganadero"
        Me.GanaderoDataGridViewTextBoxColumn.HeaderText = "Ganadero"
        Me.GanaderoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GanaderoDataGridViewTextBoxColumn.Name = "GanaderoDataGridViewTextBoxColumn"
        Me.GanaderoDataGridViewTextBoxColumn.ReadOnly = True
        Me.GanaderoDataGridViewTextBoxColumn.Width = 200
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesdeDataGridViewTextBoxColumn.Width = 115
        '
        'HastaDataGridViewTextBoxColumn
        '
        Me.HastaDataGridViewTextBoxColumn.DataPropertyName = "Hasta"
        Me.HastaDataGridViewTextBoxColumn.HeaderText = "Hasta"
        Me.HastaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HastaDataGridViewTextBoxColumn.Name = "HastaDataGridViewTextBoxColumn"
        Me.HastaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HastaDataGridViewTextBoxColumn.Width = 115
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 70
        '
        'UspGetPedidoBovinoBindingSource
        '
        Me.UspGetPedidoBovinoBindingSource.DataMember = "uspGetPedidoBovino"
        Me.UspGetPedidoBovinoBindingSource.DataSource = Me.Pedidos_OSDataSet
        '
        'Pedidos_OSDataSet
        '
        Me.Pedidos_OSDataSet.DataSetName = "Pedidos_OSDataSet"
        Me.Pedidos_OSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PEDIDO PS"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.White
        Me.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_buscar.FlatAppearance.BorderSize = 3
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(346, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(187, 48)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "     BUSCAR PEDIDO"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_pedido_PS
        '
        Me.txt_pedido_PS.Location = New System.Drawing.Point(104, 34)
        Me.txt_pedido_PS.Name = "txt_pedido_PS"
        Me.txt_pedido_PS.Size = New System.Drawing.Size(236, 26)
        Me.txt_pedido_PS.TabIndex = 0
        '
        'gb_datos_pedido
        '
        Me.gb_datos_pedido.Controls.Add(Me.lbl_PedidoPS)
        Me.gb_datos_pedido.Controls.Add(Me.txt_cantidad)
        Me.gb_datos_pedido.Controls.Add(Me.Label8)
        Me.gb_datos_pedido.Controls.Add(Me.lbl_cartillas)
        Me.gb_datos_pedido.Controls.Add(Me.Label7)
        Me.gb_datos_pedido.Controls.Add(Me.chk_Todo)
        Me.gb_datos_pedido.Controls.Add(Me.dgv_crotales)
        Me.gb_datos_pedido.Controls.Add(Me.txt_pedido)
        Me.gb_datos_pedido.Controls.Add(Me.txt_cliente)
        Me.gb_datos_pedido.Controls.Add(Me.txt_ganadero)
        Me.gb_datos_pedido.Controls.Add(Me.Label6)
        Me.gb_datos_pedido.Controls.Add(Me.Label5)
        Me.gb_datos_pedido.Controls.Add(Me.Label4)
        Me.gb_datos_pedido.Controls.Add(Me.btn_imprimir)
        Me.gb_datos_pedido.Controls.Add(Me.txt_inicio)
        Me.gb_datos_pedido.Controls.Add(Me.Label1)
        Me.gb_datos_pedido.Controls.Add(Me.txt_final)
        Me.gb_datos_pedido.Controls.Add(Me.Label2)
        Me.gb_datos_pedido.Enabled = False
        Me.gb_datos_pedido.Location = New System.Drawing.Point(12, 214)
        Me.gb_datos_pedido.Name = "gb_datos_pedido"
        Me.gb_datos_pedido.Size = New System.Drawing.Size(860, 335)
        Me.gb_datos_pedido.TabIndex = 9
        Me.gb_datos_pedido.TabStop = False
        Me.gb_datos_pedido.Text = "DATOS PEDIDO"
        '
        'lbl_PedidoPS
        '
        Me.lbl_PedidoPS.AutoSize = True
        Me.lbl_PedidoPS.Location = New System.Drawing.Point(284, 44)
        Me.lbl_PedidoPS.Name = "lbl_PedidoPS"
        Me.lbl_PedidoPS.Size = New System.Drawing.Size(0, 19)
        Me.lbl_PedidoPS.TabIndex = 25
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(361, 196)
        Me.txt_cantidad.MaxLength = 14
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.ReadOnly = True
        Me.txt_cantidad.Size = New System.Drawing.Size(111, 26)
        Me.txt_cantidad.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "CANTIDAD"
        '
        'lbl_cartillas
        '
        Me.lbl_cartillas.AutoSize = True
        Me.lbl_cartillas.Location = New System.Drawing.Point(816, 306)
        Me.lbl_cartillas.Name = "lbl_cartillas"
        Me.lbl_cartillas.Size = New System.Drawing.Size(18, 19)
        Me.lbl_cartillas.TabIndex = 22
        Me.lbl_cartillas.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(694, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cartillas a imprimir"
        '
        'chk_Todo
        '
        Me.chk_Todo.AutoSize = True
        Me.chk_Todo.Location = New System.Drawing.Point(478, 305)
        Me.chk_Todo.Name = "chk_Todo"
        Me.chk_Todo.Size = New System.Drawing.Size(198, 23)
        Me.chk_Todo.TabIndex = 20
        Me.chk_Todo.Text = "Imprimir todo el pedido"
        Me.chk_Todo.UseVisualStyleBackColor = True
        '
        'dgv_crotales
        '
        Me.dgv_crotales.AllowUserToAddRows = False
        Me.dgv_crotales.AllowUserToDeleteRows = False
        Me.dgv_crotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_crotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Imprimir})
        Me.dgv_crotales.Location = New System.Drawing.Point(478, 21)
        Me.dgv_crotales.Name = "dgv_crotales"
        Me.dgv_crotales.RowHeadersWidth = 51
        Me.dgv_crotales.Size = New System.Drawing.Size(376, 278)
        Me.dgv_crotales.TabIndex = 19
        '
        'Imprimir
        '
        Me.Imprimir.HeaderText = "Imprimir"
        Me.Imprimir.MinimumWidth = 6
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Width = 125
        '
        'txt_pedido
        '
        Me.txt_pedido.Location = New System.Drawing.Point(105, 41)
        Me.txt_pedido.MaxLength = 14
        Me.txt_pedido.Name = "txt_pedido"
        Me.txt_pedido.ReadOnly = True
        Me.txt_pedido.Size = New System.Drawing.Size(172, 26)
        Me.txt_pedido.TabIndex = 18
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(105, 85)
        Me.txt_cliente.MaxLength = 14
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.ReadOnly = True
        Me.txt_cliente.Size = New System.Drawing.Size(367, 26)
        Me.txt_cliente.TabIndex = 17
        '
        'txt_ganadero
        '
        Me.txt_ganadero.Location = New System.Drawing.Point(105, 129)
        Me.txt_ganadero.MaxLength = 14
        Me.txt_ganadero.Name = "txt_ganadero"
        Me.txt_ganadero.ReadOnly = True
        Me.txt_ganadero.Size = New System.Drawing.Size(367, 26)
        Me.txt_ganadero.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PEDIDO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CLIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "GANADERO"
        '
        'UspGetPedidoBovinoTableAdapter
        '
        Me.UspGetPedidoBovinoTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 553)
        Me.Controls.Add(Me.gb_datos_pedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARTILLAS BOVINO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetPedidoBovinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pedidos_OSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_datos_pedido.ResumeLayout(False)
        Me.gb_datos_pedido.PerformLayout()
        CType(Me.dgv_crotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents txt_inicio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_final As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_pedido_PS As System.Windows.Forms.TextBox
    Friend WithEvents gb_datos_pedido As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_pedidos As DataGridView
    Friend WithEvents UspGetPedidoBovinoBindingSource As BindingSource
    Friend WithEvents Pedidos_OSDataSet As Pedidos_OSDataSet
    Friend WithEvents txt_pedido As TextBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents txt_ganadero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UspGetPedidoBovinoTableAdapter As Pedidos_OSDataSetTableAdapters.uspGetPedidoBovinoTableAdapter
    Friend WithEvents dgv_crotales As DataGridView
    Friend WithEvents PedidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GanaderoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HastaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Imprimir As DataGridViewCheckBoxColumn
    Friend WithEvents chk_Todo As CheckBox
    Friend WithEvents lbl_cartillas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_PedidoPS As Label
End Class
