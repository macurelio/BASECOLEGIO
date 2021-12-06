Imports System.Data.SqlClient
Public Class usuarioOk




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub usuarioOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = False
        mostrar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Visible = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Nombre", txtNombre1.Text)
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario1.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword1.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            mostrar()
            Panel3.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Sub mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_usuario", conexion)
            da.Fill(dt)
            dataListado.DataSource = dt
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)


        End Try

    End Sub



    Private Sub dataListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentDoubleClick
        Try

            Panel3.Visible = True
            GuardarToolStripMenuItem.Visible = False
            GuardarCambiosToolStripMenuItem.Visible = True


            txtNombre1.Text = dataListado.SelectedCells.Item(2).Value
            txtUsuario1.Text = dataListado.SelectedCells.Item(3).Value
            txtPassword1.Text = dataListado.SelectedCells.Item(4).Value
            lblId.Text = dataListado.SelectedCells.Item(1).Value

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("editar_usuario", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id", lblId.Text)
            cmd.Parameters.AddWithValue("@Nombre", txtNombre1.Text)
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario1.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword1.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            mostrar()
            Panel3.Visible = False


        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub dataListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListado.CellContentClick
        If e.ColumnIndex = Me.dataListado.Columns.Item("Eli").Index Then
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar ese usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then


                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("eliminar_usuario", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@id", dataListado.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    cerrar()
                    mostrar()
                    Panel3.Visible = False


                Catch ex As Exception : MsgBox(ex.Message)
                End Try

            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
    Sub buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_usuario", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@letra", txtBuscar.Text)
            da.Fill(dt)
            dataListado.DataSource = dt
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
End Class