<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManager
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
        Me.components = New System.ComponentModel.Container()
        Me.lstDegrees = New System.Windows.Forms.ListBox()
        Me.txtDegreeDesignator = New System.Windows.Forms.TextBox()
        Me.txtDegreeName = New System.Windows.Forms.TextBox()
        Me.btnAddDegree = New System.Windows.Forms.Button()
        Me.btnDeleteDegree = New System.Windows.Forms.Button()
        Me.grpDegree = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpCourse = New System.Windows.Forms.GroupBox()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.txtCourseDesignator = New System.Windows.Forms.TextBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.btnBuildDegree = New System.Windows.Forms.Button()
        Me.ErrorProviderManager = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDegree.SuspendLayout()
        Me.grpCourse.SuspendLayout()
        CType(Me.ErrorProviderManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstDegrees
        '
        Me.lstDegrees.FormattingEnabled = True
        Me.lstDegrees.Location = New System.Drawing.Point(40, 36)
        Me.lstDegrees.Name = "lstDegrees"
        Me.lstDegrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstDegrees.Size = New System.Drawing.Size(700, 108)
        Me.lstDegrees.TabIndex = 0
        '
        'txtDegreeDesignator
        '
        Me.txtDegreeDesignator.Location = New System.Drawing.Point(40, 180)
        Me.txtDegreeDesignator.Name = "txtDegreeDesignator"
        Me.txtDegreeDesignator.Size = New System.Drawing.Size(100, 20)
        Me.txtDegreeDesignator.TabIndex = 1
        '
        'txtDegreeName
        '
        Me.txtDegreeName.Location = New System.Drawing.Point(181, 180)
        Me.txtDegreeName.Name = "txtDegreeName"
        Me.txtDegreeName.Size = New System.Drawing.Size(559, 20)
        Me.txtDegreeName.TabIndex = 2
        '
        'btnAddDegree
        '
        Me.btnAddDegree.Location = New System.Drawing.Point(28, 208)
        Me.btnAddDegree.Name = "btnAddDegree"
        Me.btnAddDegree.Size = New System.Drawing.Size(327, 44)
        Me.btnAddDegree.TabIndex = 3
        Me.btnAddDegree.Text = "Add Degree"
        Me.btnAddDegree.UseVisualStyleBackColor = True
        '
        'btnDeleteDegree
        '
        Me.btnDeleteDegree.Location = New System.Drawing.Point(413, 220)
        Me.btnDeleteDegree.Name = "btnDeleteDegree"
        Me.btnDeleteDegree.Size = New System.Drawing.Size(327, 44)
        Me.btnDeleteDegree.TabIndex = 4
        Me.btnDeleteDegree.Text = "Delete Degree"
        Me.btnDeleteDegree.UseVisualStyleBackColor = True
        '
        'grpDegree
        '
        Me.grpDegree.Controls.Add(Me.Label1)
        Me.grpDegree.Controls.Add(Me.btnAddDegree)
        Me.grpDegree.Location = New System.Drawing.Point(12, 12)
        Me.grpDegree.Name = "grpDegree"
        Me.grpDegree.Size = New System.Drawing.Size(760, 268)
        Me.grpDegree.TabIndex = 5
        Me.grpDegree.TabStop = False
        Me.grpDegree.Text = "Degree Maintenance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter New Degree Designator and Name in TextBoxes and Press Add Degree Button"
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(28, 208)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(327, 44)
        Me.btnAddCourse.TabIndex = 3
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter New Course Designator and Name in TextBoxes and Press Add Course Button"
        '
        'grpCourse
        '
        Me.grpCourse.Controls.Add(Me.Label2)
        Me.grpCourse.Controls.Add(Me.btnAddCourse)
        Me.grpCourse.Location = New System.Drawing.Point(12, 286)
        Me.grpCourse.Name = "grpCourse"
        Me.grpCourse.Size = New System.Drawing.Size(760, 268)
        Me.grpCourse.TabIndex = 10
        Me.grpCourse.TabStop = False
        Me.grpCourse.Text = "Course Maintenance"
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.Location = New System.Drawing.Point(40, 310)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCourses.Size = New System.Drawing.Size(700, 108)
        Me.lstCourses.TabIndex = 6
        '
        'txtCourseDesignator
        '
        Me.txtCourseDesignator.Location = New System.Drawing.Point(40, 454)
        Me.txtCourseDesignator.Name = "txtCourseDesignator"
        Me.txtCourseDesignator.Size = New System.Drawing.Size(100, 20)
        Me.txtCourseDesignator.TabIndex = 7
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(181, 454)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(559, 20)
        Me.txtCourseName.TabIndex = 8
        '
        'btnDeleteCourse
        '
        Me.btnDeleteCourse.Location = New System.Drawing.Point(413, 494)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(327, 44)
        Me.btnDeleteCourse.TabIndex = 9
        Me.btnDeleteCourse.Text = "Delete Course"
        Me.btnDeleteCourse.UseVisualStyleBackColor = True
        '
        'btnBuildDegree
        '
        Me.btnBuildDegree.Location = New System.Drawing.Point(225, 560)
        Me.btnBuildDegree.Name = "btnBuildDegree"
        Me.btnBuildDegree.Size = New System.Drawing.Size(327, 44)
        Me.btnBuildDegree.TabIndex = 7
        Me.btnBuildDegree.Text = "Build Degree"
        Me.btnBuildDegree.UseVisualStyleBackColor = True
        '
        'ErrorProviderManager
        '
        Me.ErrorProviderManager.ContainerControl = Me
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.btnBuildDegree)
        Me.Controls.Add(Me.btnDeleteCourse)
        Me.Controls.Add(Me.txtCourseName)
        Me.Controls.Add(Me.txtCourseDesignator)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.grpCourse)
        Me.Controls.Add(Me.btnDeleteDegree)
        Me.Controls.Add(Me.txtDegreeName)
        Me.Controls.Add(Me.txtDegreeDesignator)
        Me.Controls.Add(Me.lstDegrees)
        Me.Controls.Add(Me.grpDegree)
        Me.Name = "frmManager"
        Me.Text = " "
        Me.grpDegree.ResumeLayout(False)
        Me.grpDegree.PerformLayout()
        Me.grpCourse.ResumeLayout(False)
        Me.grpCourse.PerformLayout()
        CType(Me.ErrorProviderManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDegrees As ListBox
    Friend WithEvents txtDegreeDesignator As TextBox
    Friend WithEvents txtDegreeName As TextBox
    Friend WithEvents btnAddDegree As Button
    Friend WithEvents btnDeleteDegree As Button
    Friend WithEvents grpDegree As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents grpCourse As GroupBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents txtCourseDesignator As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents btnBuildDegree As Button
    Friend WithEvents ErrorProviderManager As ErrorProvider
End Class
