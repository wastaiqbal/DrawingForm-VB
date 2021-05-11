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
        Me.PicDrawing = New System.Windows.Forms.PictureBox()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ComboFont = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialogDrawing = New System.Windows.Forms.ColorDialog()
        CType(Me.PicDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicDrawing
        '
        Me.PicDrawing.BackColor = System.Drawing.SystemColors.Control
        Me.PicDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicDrawing.Location = New System.Drawing.Point(21, 77)
        Me.PicDrawing.Name = "PicDrawing"
        Me.PicDrawing.Size = New System.Drawing.Size(553, 280)
        Me.PicDrawing.TabIndex = 0
        Me.PicDrawing.TabStop = False
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(185, 383)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(116, 59)
        Me.BtnColor.TabIndex = 1
        Me.BtnColor.Text = "Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(321, 383)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(116, 59)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(458, 383)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(116, 59)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ComboFont
        '
        Me.ComboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFont.FormattingEnabled = True
        Me.ComboFont.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12"})
        Me.ComboFont.Location = New System.Drawing.Point(46, 394)
        Me.ComboFont.Name = "ComboFont"
        Me.ComboFont.Size = New System.Drawing.Size(119, 28)
        Me.ComboFont.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Let's Drawing"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboFont)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.PicDrawing)
        Me.Name = "Form1"
        Me.Text = "DrawingFormVB"
        CType(Me.PicDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicDrawing As System.Windows.Forms.PictureBox
    Friend WithEvents BtnColor As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ComboFont As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDialogDrawing As System.Windows.Forms.ColorDialog

End Class
