<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuarioOk
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuarioOk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dataListado = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtUsuario1 = New System.Windows.Forms.TextBox()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 55)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(770, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(1, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 50)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuarios"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 55)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(86, 24)
        Me.ToolStripMenuItem1.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(95, 61)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(411, 22)
        Me.txtBuscar.TabIndex = 3
        '
        'dataListado
        '
        Me.dataListado.AllowUserToAddRows = False
        Me.dataListado.AllowUserToDeleteRows = False
        Me.dataListado.AllowUserToResizeRows = False
        Me.dataListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.dataListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataListado.Location = New System.Drawing.Point(0, 83)
        Me.dataListado.Name = "dataListado"
        Me.dataListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataListado.RowHeadersVisible = False
        Me.dataListado.RowHeadersWidth = 51
        Me.dataListado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.dataListado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataListado.RowTemplate.Height = 24
        Me.dataListado.RowTemplate.ReadOnly = True
        Me.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListado.Size = New System.Drawing.Size(665, 367)
        Me.dataListado.TabIndex = 4
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.MinimumWidth = 6
        Me.Eli.Name = "Eli"
        Me.Eli.Width = 125
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblId)
        Me.Panel3.Controls.Add(Me.txtUsuario1)
        Me.Panel3.Controls.Add(Me.txtPassword1)
        Me.Panel3.Controls.Add(Me.txtNombre1)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.txtUsuario)
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Location = New System.Drawing.Point(157, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 302)
        Me.Panel3.TabIndex = 5
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(427, 25)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(20, 16)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "ID"
        '
        'txtUsuario1
        '
        Me.txtUsuario1.Location = New System.Drawing.Point(169, 85)
        Me.txtUsuario1.Name = "txtUsuario1"
        Me.txtUsuario1.Size = New System.Drawing.Size(233, 22)
        Me.txtUsuario1.TabIndex = 5
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(169, 133)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(233, 22)
        Me.txtPassword1.TabIndex = 4
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(169, 37)
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(233, 22)
        Me.txtNombre1.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(52, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(81, 25)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.Text = "Nombre"
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(52, 130)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(98, 25)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = True
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtUsuario.Location = New System.Drawing.Point(52, 85)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(79, 25)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = "Usuario"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 269)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(472, 33)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(100, 29)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GuardarCambiosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(181, 29)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(665, 83)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 367)
        Me.Panel4.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'usuarioOk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dataListado)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "usuarioOk"
        Me.Text = "usuarioOk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dataListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dataListado As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUsuario1 As TextBox
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtNombre As Label
    Friend WithEvents txtPassword As Label
    Friend WithEvents txtUsuario As Label
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblId As Label
    Friend WithEvents Eli As DataGridViewImageColumn
End Class
