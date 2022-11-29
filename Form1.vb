Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit

Public Class Form1
    Dim Dato As String
    Dim I As Integer
    Dim Existe As Integer
    Dim NomArchivo As String
    Dim Ubicacion As String
    Dim HayCambios As Boolean

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or txtDireccion.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("Ingrese datos primero.", vbCritical)
            txtNombre.Focus()
            Exit Sub
        End If
        txtNombre.Text = Mid(txtNombre.Text, 1, 20)
        txtDireccion.Text = Mid(txtDireccion.Text, 1, 20)
        txtTelefono.Text = Mid(txtTelefono.Text, 1, 20)
        Me.listNombre.Items.Add(
            txtNombre.Text & Space(20 - Len(txtNombre.Text)) & "-" & Space(10) &
            txtDireccion.Text & Space(20 - Len(txtDireccion.Text)) & "-" & Space(10) &
            txtTelefono.Text & Space(20 - Len(txtTelefono.Text))
        )
        HayCambios = True
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.txtNombre.Text = Mid(listNombre.SelectedItem.ToString, 1, 20)
        Me.txtDireccion.Text = Mid(Me.listNombre.SelectedItem.ToString, 32, 20)
        Me.txtTelefono.Text = Mid(Me.listNombre.SelectedItem.ToString, 63, 20)
        Me.listNombre.Items.Remove(Me.listNombre.SelectedItem.ToString())
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If listNombre.SelectedIndex = -1 Then
            MsgBox("Seleccione un item primero.", vbCritical)
            listNombre.Focus()
            Exit Sub
        End If
        listNombre.Items.Remove(listNombre.SelectedItem.ToString)
        txtNombre.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Guardar(Ubicacion & NomArchivo)
    End Sub

    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Dim Opc As Integer

        If HayCambios Then
            Opc = MsgBox("No se han guardado los últimos cambios ¿Desea guardarlos?", vbYesNo + vbCritical)
            If Opc = vbYes Then
                Me.Guardar(Ubicacion & NomArchivo)
            End If
        End If
        Me.Leer(Ubicacion & NomArchivo)
    End Sub

    Private Sub FrmForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomArchivo = "test.txt" ' Nombre físico del archivo
        Ubicacion = "c:\intel\" ' Ubicación donde será almacenado
        listNombre.Items.Clear()
        Leer(Ubicacion & NomArchivo)
    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim Opc As Integer
        If File.Exists(Ubicacion & NomArchivo) Then
            Opc = MsgBox("Hay un archivo con este nombre ¿Desea leer su contenido?", vbYesNo + vbInformation)
            If Opc = vbYes Then
                Me.Leer(Ubicacion & NomArchivo)
                Opc = 0
            Else
                Opc = 1
            End If
        End If
        Me.Crear(Ubicacion & NomArchivo, Opc)
    End Sub

    Sub Guardar(Archivo As String)
        Dim GrabarArchivo As New StreamWriter(Archivo)
        For Each Item In listNombre.Items
            GrabarArchivo.WriteLine(Item)
        Next
        GrabarArchivo.Close()
        MsgBox("Archivo grabado correctamente", vbInformation)
        HayCambios = False
        txtNombre.Focus()
    End Sub

    Sub Leer(Archivo As String)
        Dim leerArchivo As New StreamReader(Archivo)
        Me.listNombre.Items.Clear()
        Do While Not leerArchivo.EndOfStream
            Me.listNombre.Items.Add(leerArchivo.ReadLine)
        Loop

        leerArchivo.Close()
    End Sub

    Sub Crear(Archivo As String, Tipo As Integer)
        Dim CrearArchivo As FileStream = File.Create(Archivo)
        CrearArchivo.Close()
        Select Case Tipo
            Case 0
            Case Else
                MsgBox("Archivo creado correctamente", vbInformation)
        End Select
    End Sub

    Sub Buscar()
        listResultado.Items.Clear()
        listResultado.Visible = True
        For I = 0 To (listNombre.Items.Count() - 1)
            Existe = listNombre.Items(I).IndexOf(txtFiltro.Text)
            If Existe <> -1 Then
                listNombre.SelectedIndex() = I
                Me.listResultado.Items.Add(listNombre.Items(I))
            ElseIf txtFiltro.Text = "" Then
                listResultado.Items.Add(listNombre.Items(I))
            End If
        Next
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        txtFiltro.Visible = True
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Buscar()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Opc As Integer
        If HayCambios Then
            Opc = MsgBox("¿Desea guardar su contenido antes de cerrar?", vbYesNo + vbInformation)
            If Opc = vbYes Then
                Me.Guardar(Ubicacion & NomArchivo)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If Len(Me.txtNombre.Text) > 20 Then
            MsgBox("¡El nombre no puede ser superior a 20 caracteres!", vbCritical)
            txtNombre.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        If Len(Me.txtDireccion.Text) > 20 Then
            MsgBox("¡La dirección no puede ser superior a 20 caracteres!", vbCritical)
            txtDireccion.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If Len(Me.txtTelefono.Text) > 20 Then
            MsgBox("¡El teléfono no puede ser superior a 20 caracteres!", vbCritical)
            txtTelefono.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo acepta números.")
        End If
    End Sub
End Class
