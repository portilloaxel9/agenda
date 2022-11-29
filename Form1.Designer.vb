<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.listResultado = New System.Windows.Forms.ListBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.listNombre = New System.Windows.Forms.ListBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.titulo = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(883, 328)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(77, 77)
        Me.btnGuardar.TabIndex = 139
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'listResultado
        '
        Me.listResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listResultado.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.listResultado.FormattingEnabled = True
        Me.listResultado.ItemHeight = 18
        Me.listResultado.Location = New System.Drawing.Point(141, 468)
        Me.listResultado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listResultado.Name = "listResultado"
        Me.listResultado.Size = New System.Drawing.Size(822, 92)
        Me.listResultado.TabIndex = 138
        Me.listResultado.Visible = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.Transparent
        Me.btnFiltrar.BackgroundImage = CType(resources.GetObject("btnFiltrar.BackgroundImage"), System.Drawing.Image)
        Me.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFiltrar.FlatAppearance.BorderSize = 0
        Me.btnFiltrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(441, 328)
        Me.btnFiltrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(57, 57)
        Me.btnFiltrar.TabIndex = 135
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), System.Drawing.Image)
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(241, 328)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 57)
        Me.btnEditar.TabIndex = 134
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.Transparent
        Me.btnCrear.BackgroundImage = CType(resources.GetObject("btnCrear.BackgroundImage"), System.Drawing.Image)
        Me.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Location = New System.Drawing.Point(697, 328)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(8)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(77, 77)
        Me.btnCrear.TabIndex = 133
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnLeer
        '
        Me.btnLeer.BackColor = System.Drawing.Color.Transparent
        Me.btnLeer.BackgroundImage = CType(resources.GetObject("btnLeer.BackgroundImage"), System.Drawing.Image)
        Me.btnLeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLeer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLeer.FlatAppearance.BorderSize = 0
        Me.btnLeer.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeer.Font = New System.Drawing.Font("MV Boli", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeer.Location = New System.Drawing.Point(790, 328)
        Me.btnLeer.Margin = New System.Windows.Forms.Padding(8)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(77, 77)
        Me.btnLeer.TabIndex = 132
        Me.btnLeer.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(341, 328)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(57, 57)
        Me.btnEliminar.TabIndex = 131
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(141, 328)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(57, 57)
        Me.btnAgregar.TabIndex = 130
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'listNombre
        '
        Me.listNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listNombre.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listNombre.FormattingEnabled = True
        Me.listNombre.ItemHeight = 18
        Me.listNombre.Location = New System.Drawing.Point(141, 210)
        Me.listNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listNombre.Name = "listNombre"
        Me.listNombre.Size = New System.Drawing.Size(822, 92)
        Me.listNombre.TabIndex = 129
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Location = New System.Drawing.Point(241, 147)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(374, 26)
        Me.txtTelefono.TabIndex = 128
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(241, 99)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(374, 26)
        Me.txtDireccion.TabIndex = 127
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(241, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(374, 26)
        Me.txtNombre.TabIndex = 126
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(136, 146)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(98, 26)
        Me.lblTelefono.TabIndex = 125
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(136, 96)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(102, 26)
        Me.lblDireccion.TabIndex = 124
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("MV Boli", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(136, 44)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 26)
        Me.lblNombre.TabIndex = 123
        Me.lblNombre.Text = "Nombre:"
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.BackColor = System.Drawing.Color.Transparent
        Me.titulo.Font = New System.Drawing.Font("MV Boli", 28.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titulo.ForeColor = System.Drawing.Color.Black
        Me.titulo.Location = New System.Drawing.Point(667, 115)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(296, 73)
        Me.titulo.TabIndex = 122
        Me.titulo.Text = "Mi agenda"
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Location = New System.Drawing.Point(141, 420)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(374, 26)
        Me.txtFiltro.TabIndex = 140
        Me.txtFiltro.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1099, 640)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.listResultado)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.listNombre)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.titulo)
        Me.Name = "Form1"
        Me.Text = "MiAgenda22"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents listResultado As ListBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnLeer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents listNombre As ListBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents titulo As Label
    Friend WithEvents txtFiltro As TextBox
End Class
