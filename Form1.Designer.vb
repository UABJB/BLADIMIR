<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnregistro = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtAPM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAPP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'btnregistro
        '
        Me.btnregistro.Location = New System.Drawing.Point(106, 143)
        Me.btnregistro.Name = "btnregistro"
        Me.btnregistro.Size = New System.Drawing.Size(75, 23)
        Me.btnregistro.TabIndex = 1
        Me.btnregistro.Text = "Registro"
        Me.btnregistro.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtAPM
        '
        Me.txtAPM.Location = New System.Drawing.Point(106, 55)
        Me.txtAPM.Name = "txtAPM"
        Me.txtAPM.Size = New System.Drawing.Size(100, 20)
        Me.txtAPM.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "APM"
        '
        'txtAPP
        '
        Me.txtAPP.Location = New System.Drawing.Point(106, 81)
        Me.txtAPP.Name = "txtAPP"
        Me.txtAPP.Size = New System.Drawing.Size(100, 20)
        Me.txtAPP.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APP"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(106, 107)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Edad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 196)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAPP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAPM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnregistro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnregistro As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtAPM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAPP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
