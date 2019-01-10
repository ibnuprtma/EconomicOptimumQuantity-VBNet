<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnadmin
        '
        Me.btnadmin.Location = New System.Drawing.Point(193, 262)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(122, 39)
        Me.btnadmin.TabIndex = 0
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.Location = New System.Drawing.Point(459, 262)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(122, 39)
        Me.btnuser.TabIndex = 1
        Me.btnuser.Text = "User"
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Suatu metode untuk menentukan jumlah pesanan yang optimal "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "dengan biaya yang paling ekonomis.  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EOQ (Economic Order Quantity)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(391, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Untuk mengetahui kebutuhan Produksi dan Operasi silahkan masuk sebagai user"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "*"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Daftar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(753, 339)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btnadmin)
        Me.Name = "Dashboard"
        Me.Text = "Penghitungan Kebutuhan dengan Metode EOQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
