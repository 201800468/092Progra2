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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbsAzucar = New System.Windows.Forms.TextBox()
        Me.lbsFrijol = New System.Windows.Forms.TextBox()
        Me.lbsArroz = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.Descuento = New System.Windows.Forms.Label()
        Me.PceIVA = New System.Windows.Forms.Label()
        Me.vdIVA = New System.Windows.Forms.Label()
        Me.PadIVA = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arroz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Frijol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Azúcar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbsAzucar)
        Me.GroupBox1.Controls.Add(Me.lbsFrijol)
        Me.GroupBox1.Controls.Add(Me.lbsArroz)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 229)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Libras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Libras"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Libras"
        '
        'lbsAzucar
        '
        Me.lbsAzucar.Location = New System.Drawing.Point(85, 147)
        Me.lbsAzucar.Name = "lbsAzucar"
        Me.lbsAzucar.Size = New System.Drawing.Size(41, 27)
        Me.lbsAzucar.TabIndex = 5
        '
        'lbsFrijol
        '
        Me.lbsFrijol.Location = New System.Drawing.Point(84, 92)
        Me.lbsFrijol.Name = "lbsFrijol"
        Me.lbsFrijol.Size = New System.Drawing.Size(42, 27)
        Me.lbsFrijol.TabIndex = 4
        '
        'lbsArroz
        '
        Me.lbsArroz.Location = New System.Drawing.Point(85, 39)
        Me.lbsArroz.Name = "lbsArroz"
        Me.lbsArroz.Size = New System.Drawing.Size(41, 27)
        Me.lbsArroz.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento)
        Me.GroupBox2.Controls.Add(Me.PceIVA)
        Me.GroupBox2.Controls.Add(Me.vdIVA)
        Me.GroupBox2.Controls.Add(Me.PadIVA)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 229)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        Me.GroupBox2.Visible = False
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(178, 174)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(36, 20)
        Me.Total.TabIndex = 9
        Me.Total.Text = "0.00"
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Location = New System.Drawing.Point(178, 132)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(36, 20)
        Me.Descuento.TabIndex = 8
        Me.Descuento.Text = "0.00"
        '
        'PceIVA
        '
        Me.PceIVA.AutoSize = True
        Me.PceIVA.Location = New System.Drawing.Point(178, 102)
        Me.PceIVA.Name = "PceIVA"
        Me.PceIVA.Size = New System.Drawing.Size(36, 20)
        Me.PceIVA.TabIndex = 7
        Me.PceIVA.Text = "0.00"
        '
        'vdIVA
        '
        Me.vdIVA.AutoSize = True
        Me.vdIVA.Location = New System.Drawing.Point(178, 68)
        Me.vdIVA.Name = "vdIVA"
        Me.vdIVA.Size = New System.Drawing.Size(36, 20)
        Me.vdIVA.TabIndex = 6
        Me.vdIVA.Text = "0.00"
        '
        'PadIVA
        '
        Me.PadIVA.AutoSize = True
        Me.PadIVA.Location = New System.Drawing.Point(178, 37)
        Me.PadIVA.Name = "PadIVA"
        Me.PadIVA.Size = New System.Drawing.Size(36, 20)
        Me.PadIVA.TabIndex = 5
        Me.PadIVA.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Descuento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Pago con el IVA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Valor deL IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Pago antes del IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(264, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 229)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(759, 353)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbsAzucar As TextBox
    Friend WithEvents lbsFrijol As TextBox
    Friend WithEvents lbsArroz As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As Label
    Friend WithEvents Descuento As Label
    Friend WithEvents PceIVA As Label
    Friend WithEvents vdIVA As Label
    Friend WithEvents PadIVA As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
