<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxMin = New System.Windows.Forms.TextBox()
        Me.TextBoxMax = New System.Windows.Forms.TextBox()
        Me.ButtonSorteo = New System.Windows.Forms.Button()
        Me.ComboBoxHistorial = New System.Windows.Forms.ComboBox()
        Me.LabelHistorial = New System.Windows.Forms.Label()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.LabelMin = New System.Windows.Forms.Label()
        Me.LabelMax = New System.Windows.Forms.Label()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxMin
        '
        Me.TextBoxMin.Location = New System.Drawing.Point(96, 70)
        Me.TextBoxMin.Name = "TextBoxMin"
        Me.TextBoxMin.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxMin.TabIndex = 0
        '
        'TextBoxMax
        '
        Me.TextBoxMax.Location = New System.Drawing.Point(241, 70)
        Me.TextBoxMax.Name = "TextBoxMax"
        Me.TextBoxMax.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxMax.TabIndex = 1
        '
        'ButtonSorteo
        '
        Me.ButtonSorteo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonSorteo.Location = New System.Drawing.Point(168, 186)
        Me.ButtonSorteo.Name = "ButtonSorteo"
        Me.ButtonSorteo.Size = New System.Drawing.Size(119, 40)
        Me.ButtonSorteo.TabIndex = 2
        Me.ButtonSorteo.Text = "Sortear!"
        Me.ButtonSorteo.UseVisualStyleBackColor = False
        '
        'ComboBoxHistorial
        '
        Me.ComboBoxHistorial.FormattingEnabled = True
        Me.ComboBoxHistorial.Location = New System.Drawing.Point(461, 94)
        Me.ComboBoxHistorial.Name = "ComboBoxHistorial"
        Me.ComboBoxHistorial.Size = New System.Drawing.Size(140, 28)
        Me.ComboBoxHistorial.TabIndex = 3
        '
        'LabelHistorial
        '
        Me.LabelHistorial.AutoSize = True
        Me.LabelHistorial.Location = New System.Drawing.Point(457, 69)
        Me.LabelHistorial.Name = "LabelHistorial"
        Me.LabelHistorial.Size = New System.Drawing.Size(144, 20)
        Me.LabelHistorial.TabIndex = 4
        Me.LabelHistorial.Text = "Historial del sorteo:"
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResultado.Location = New System.Drawing.Point(204, 139)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(0, 29)
        Me.LabelResultado.TabIndex = 5
        '
        'LabelMin
        '
        Me.LabelMin.AutoSize = True
        Me.LabelMin.Location = New System.Drawing.Point(114, 41)
        Me.LabelMin.Name = "LabelMin"
        Me.LabelMin.Size = New System.Drawing.Size(59, 20)
        Me.LabelMin.TabIndex = 6
        Me.LabelMin.Text = "Minimo"
        '
        'LabelMax
        '
        Me.LabelMax.AutoSize = True
        Me.LabelMax.Location = New System.Drawing.Point(258, 41)
        Me.LabelMax.Name = "LabelMax"
        Me.LabelMax.Size = New System.Drawing.Size(63, 20)
        Me.LabelMax.TabIndex = 7
        Me.LabelMax.Text = "Máximo"
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonSiguiente.Location = New System.Drawing.Point(478, 128)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(109, 47)
        Me.ButtonSiguiente.TabIndex = 8
        Me.ButtonSiguiente.Text = "Siguiente >"
        Me.ButtonSiguiente.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 267)
        Me.Controls.Add(Me.ButtonSiguiente)
        Me.Controls.Add(Me.LabelMax)
        Me.Controls.Add(Me.LabelMin)
        Me.Controls.Add(Me.LabelResultado)
        Me.Controls.Add(Me.LabelHistorial)
        Me.Controls.Add(Me.ComboBoxHistorial)
        Me.Controls.Add(Me.ButtonSorteo)
        Me.Controls.Add(Me.TextBoxMax)
        Me.Controls.Add(Me.TextBoxMin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Sorteo - Heladeria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxMin As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMax As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSorteo As System.Windows.Forms.Button
    Friend WithEvents ComboBoxHistorial As System.Windows.Forms.ComboBox
    Friend WithEvents LabelHistorial As System.Windows.Forms.Label
    Friend WithEvents LabelResultado As System.Windows.Forms.Label
    Friend WithEvents LabelMin As System.Windows.Forms.Label
    Friend WithEvents LabelMax As System.Windows.Forms.Label
    Friend WithEvents ButtonSiguiente As System.Windows.Forms.Button

End Class
