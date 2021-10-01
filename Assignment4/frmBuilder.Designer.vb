<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuilder
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstDegrees = New System.Windows.Forms.ListBox()
        Me.lstDegreeCourses = New System.Windows.Forms.ListBox()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.ErrorProviderBuilder = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProviderBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(42, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(900, 44)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back to Degree and Course Maintenance"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstDegrees
        '
        Me.lstDegrees.FormattingEnabled = True
        Me.lstDegrees.Location = New System.Drawing.Point(42, 79)
        Me.lstDegrees.Name = "lstDegrees"
        Me.lstDegrees.Size = New System.Drawing.Size(900, 108)
        Me.lstDegrees.TabIndex = 1
        '
        'lstDegreeCourses
        '
        Me.lstDegreeCourses.FormattingEnabled = True
        Me.lstDegreeCourses.Location = New System.Drawing.Point(42, 211)
        Me.lstDegreeCourses.Name = "lstDegreeCourses"
        Me.lstDegreeCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstDegreeCourses.Size = New System.Drawing.Size(350, 329)
        Me.lstDegreeCourses.TabIndex = 2
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(592, 211)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCourses.Size = New System.Drawing.Size(350, 329)
        Me.lstCourses.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(419, 250)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(146, 81)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "<--"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(419, 418)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(146, 81)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "-->"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'ErrorProviderBuilder
        '
        Me.ErrorProviderBuilder.ContainerControl = Me
        '
        'frmBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.lstDegreeCourses)
        Me.Controls.Add(Me.lstDegrees)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmBuilder"
        Me.Text = "frmBuilder"
        CType(Me.ErrorProviderBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lstDegrees As ListBox
    Friend WithEvents lstDegreeCourses As ListBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents ErrorProviderBuilder As ErrorProvider
End Class
