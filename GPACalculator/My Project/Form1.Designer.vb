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
        Me.bt_submit = New System.Windows.Forms.Button()
        Me.cb_semester = New System.Windows.Forms.ComboBox()
        Me.tb_num = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.cb_year = New System.Windows.Forms.ComboBox()
        Me.cb_dept = New System.Windows.Forms.ComboBox()
        Me.cb_hrs = New System.Windows.Forms.ComboBox()
        Me.cb_grade = New System.Windows.Forms.ComboBox()
        Me.cb_major = New System.Windows.Forms.ComboBox()
        Me.cb_retake = New System.Windows.Forms.ComboBox()
        Me.lb_semester = New System.Windows.Forms.Label()
        Me.lbyear = New System.Windows.Forms.Label()
        Me.lb_dept = New System.Windows.Forms.Label()
        Me.lb_num = New System.Windows.Forms.Label()
        Me.lb_Name = New System.Windows.Forms.Label()
        Me.lb_hrs = New System.Windows.Forms.Label()
        Me.lb_grade = New System.Windows.Forms.Label()
        Me.lb_major = New System.Windows.Forms.Label()
        Me.lb_retake = New System.Windows.Forms.Label()
        Me.lb_gpa = New System.Windows.Forms.Label()
        Me.lb_mgpa = New System.Windows.Forms.Label()
        Me.lb_gparesult = New System.Windows.Forms.Label()
        Me.lb_mgparesult = New System.Windows.Forms.Label()
        Me.bt_major = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_submit
        '
        Me.bt_submit.Location = New System.Drawing.Point(575, 40)
        Me.bt_submit.Name = "bt_submit"
        Me.bt_submit.Size = New System.Drawing.Size(75, 23)
        Me.bt_submit.TabIndex = 0
        Me.bt_submit.Text = "Submit"
        Me.bt_submit.UseVisualStyleBackColor = True
        '
        'cb_semester
        '
        Me.cb_semester.FormattingEnabled = True
        Me.cb_semester.Items.AddRange(New Object() {"Spring", "Summer", "Fall", "Winter"})
        Me.cb_semester.Location = New System.Drawing.Point(48, 39)
        Me.cb_semester.Name = "cb_semester"
        Me.cb_semester.Size = New System.Drawing.Size(41, 21)
        Me.cb_semester.TabIndex = 1
        '
        'tb_num
        '
        Me.tb_num.Location = New System.Drawing.Point(216, 40)
        Me.tb_num.Name = "tb_num"
        Me.tb_num.Size = New System.Drawing.Size(59, 20)
        Me.tb_num.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(49, 120)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(479, 173)
        Me.ListBox1.TabIndex = 3
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(281, 40)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(59, 20)
        Me.tb_name.TabIndex = 4
        '
        'cb_year
        '
        Me.cb_year.FormattingEnabled = True
        Me.cb_year.Items.AddRange(New Object() {"2013", "2014", "2015"})
        Me.cb_year.Location = New System.Drawing.Point(110, 40)
        Me.cb_year.Name = "cb_year"
        Me.cb_year.Size = New System.Drawing.Size(41, 21)
        Me.cb_year.TabIndex = 5
        '
        'cb_dept
        '
        Me.cb_dept.FormattingEnabled = True
        Me.cb_dept.Items.AddRange(New Object() {"ACCT", "MSCI", "ECON", "FIN", "MKTG", "MGMT"})
        Me.cb_dept.Location = New System.Drawing.Point(169, 39)
        Me.cb_dept.Name = "cb_dept"
        Me.cb_dept.Size = New System.Drawing.Size(41, 21)
        Me.cb_dept.TabIndex = 6
        '
        'cb_hrs
        '
        Me.cb_hrs.FormattingEnabled = True
        Me.cb_hrs.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cb_hrs.Location = New System.Drawing.Point(346, 39)
        Me.cb_hrs.Name = "cb_hrs"
        Me.cb_hrs.Size = New System.Drawing.Size(41, 21)
        Me.cb_hrs.TabIndex = 7
        '
        'cb_grade
        '
        Me.cb_grade.FormattingEnabled = True
        Me.cb_grade.Items.AddRange(New Object() {"A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F", "S", "P"})
        Me.cb_grade.Location = New System.Drawing.Point(393, 40)
        Me.cb_grade.Name = "cb_grade"
        Me.cb_grade.Size = New System.Drawing.Size(41, 21)
        Me.cb_grade.TabIndex = 8
        '
        'cb_major
        '
        Me.cb_major.FormattingEnabled = True
        Me.cb_major.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_major.Location = New System.Drawing.Point(440, 39)
        Me.cb_major.Name = "cb_major"
        Me.cb_major.Size = New System.Drawing.Size(41, 21)
        Me.cb_major.TabIndex = 9
        '
        'cb_retake
        '
        Me.cb_retake.FormattingEnabled = True
        Me.cb_retake.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_retake.Location = New System.Drawing.Point(487, 40)
        Me.cb_retake.Name = "cb_retake"
        Me.cb_retake.Size = New System.Drawing.Size(41, 21)
        Me.cb_retake.TabIndex = 10
        '
        'lb_semester
        '
        Me.lb_semester.AutoSize = True
        Me.lb_semester.Location = New System.Drawing.Point(45, 23)
        Me.lb_semester.Name = "lb_semester"
        Me.lb_semester.Size = New System.Drawing.Size(51, 13)
        Me.lb_semester.TabIndex = 11
        Me.lb_semester.Text = "Semester"
        '
        'lbyear
        '
        Me.lbyear.AutoSize = True
        Me.lbyear.Location = New System.Drawing.Point(107, 23)
        Me.lbyear.Name = "lbyear"
        Me.lbyear.Size = New System.Drawing.Size(29, 13)
        Me.lbyear.TabIndex = 12
        Me.lbyear.Text = "Year"
        '
        'lb_dept
        '
        Me.lb_dept.AutoSize = True
        Me.lb_dept.Location = New System.Drawing.Point(166, 23)
        Me.lb_dept.Name = "lb_dept"
        Me.lb_dept.Size = New System.Drawing.Size(30, 13)
        Me.lb_dept.TabIndex = 13
        Me.lb_dept.Text = "Dept"
        '
        'lb_num
        '
        Me.lb_num.AutoSize = True
        Me.lb_num.Location = New System.Drawing.Point(216, 24)
        Me.lb_num.Name = "lb_num"
        Me.lb_num.Size = New System.Drawing.Size(80, 13)
        Me.lb_num.TabIndex = 14
        Me.lb_num.Text = "Course Number"
        '
        'lb_Name
        '
        Me.lb_Name.AutoSize = True
        Me.lb_Name.Location = New System.Drawing.Point(278, 23)
        Me.lb_Name.Name = "lb_Name"
        Me.lb_Name.Size = New System.Drawing.Size(71, 13)
        Me.lb_Name.TabIndex = 15
        Me.lb_Name.Text = "Course Name"
        '
        'lb_hrs
        '
        Me.lb_hrs.AutoSize = True
        Me.lb_hrs.Location = New System.Drawing.Point(343, 23)
        Me.lb_hrs.Name = "lb_hrs"
        Me.lb_hrs.Size = New System.Drawing.Size(47, 13)
        Me.lb_hrs.TabIndex = 16
        Me.lb_hrs.Text = "Sem Hrs"
        '
        'lb_grade
        '
        Me.lb_grade.AutoSize = True
        Me.lb_grade.Location = New System.Drawing.Point(390, 23)
        Me.lb_grade.Name = "lb_grade"
        Me.lb_grade.Size = New System.Drawing.Size(36, 13)
        Me.lb_grade.TabIndex = 17
        Me.lb_grade.Text = "Grade"
        '
        'lb_major
        '
        Me.lb_major.AutoSize = True
        Me.lb_major.Location = New System.Drawing.Point(437, 23)
        Me.lb_major.Name = "lb_major"
        Me.lb_major.Size = New System.Drawing.Size(69, 13)
        Me.lb_major.TabIndex = 18
        Me.lb_major.Text = "Major Course"
        '
        'lb_retake
        '
        Me.lb_retake.AutoSize = True
        Me.lb_retake.Location = New System.Drawing.Point(484, 23)
        Me.lb_retake.Name = "lb_retake"
        Me.lb_retake.Size = New System.Drawing.Size(78, 13)
        Me.lb_retake.TabIndex = 19
        Me.lb_retake.Text = "Course Retake"
        '
        'lb_gpa
        '
        Me.lb_gpa.AutoSize = True
        Me.lb_gpa.Location = New System.Drawing.Point(575, 132)
        Me.lb_gpa.Name = "lb_gpa"
        Me.lb_gpa.Size = New System.Drawing.Size(65, 13)
        Me.lb_gpa.TabIndex = 20
        Me.lb_gpa.Text = "Overall GPA"
        '
        'lb_mgpa
        '
        Me.lb_mgpa.AutoSize = True
        Me.lb_mgpa.Location = New System.Drawing.Point(575, 212)
        Me.lb_mgpa.Name = "lb_mgpa"
        Me.lb_mgpa.Size = New System.Drawing.Size(58, 13)
        Me.lb_mgpa.TabIndex = 21
        Me.lb_mgpa.Text = "Major GPA"
        '
        'lb_gparesult
        '
        Me.lb_gparesult.AutoSize = True
        Me.lb_gparesult.Location = New System.Drawing.Point(578, 164)
        Me.lb_gparesult.Name = "lb_gparesult"
        Me.lb_gparesult.Size = New System.Drawing.Size(0, 13)
        Me.lb_gparesult.TabIndex = 22
        '
        'lb_mgparesult
        '
        Me.lb_mgparesult.AutoSize = True
        Me.lb_mgparesult.Location = New System.Drawing.Point(575, 241)
        Me.lb_mgparesult.Name = "lb_mgparesult"
        Me.lb_mgparesult.Size = New System.Drawing.Size(0, 13)
        Me.lb_mgparesult.TabIndex = 23
        '
        'bt_major
        '
        Me.bt_major.Location = New System.Drawing.Point(350, 88)
        Me.bt_major.Name = "bt_major"
        Me.bt_major.Size = New System.Drawing.Size(75, 23)
        Me.bt_major.TabIndex = 24
        Me.bt_major.Text = "Major Course"
        Me.bt_major.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 317)
        Me.Controls.Add(Me.bt_major)
        Me.Controls.Add(Me.lb_mgparesult)
        Me.Controls.Add(Me.lb_gparesult)
        Me.Controls.Add(Me.lb_mgpa)
        Me.Controls.Add(Me.lb_gpa)
        Me.Controls.Add(Me.lb_retake)
        Me.Controls.Add(Me.lb_major)
        Me.Controls.Add(Me.lb_grade)
        Me.Controls.Add(Me.lb_hrs)
        Me.Controls.Add(Me.lb_Name)
        Me.Controls.Add(Me.lb_num)
        Me.Controls.Add(Me.lb_dept)
        Me.Controls.Add(Me.lbyear)
        Me.Controls.Add(Me.lb_semester)
        Me.Controls.Add(Me.cb_retake)
        Me.Controls.Add(Me.cb_major)
        Me.Controls.Add(Me.cb_grade)
        Me.Controls.Add(Me.cb_hrs)
        Me.Controls.Add(Me.cb_dept)
        Me.Controls.Add(Me.cb_year)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tb_num)
        Me.Controls.Add(Me.cb_semester)
        Me.Controls.Add(Me.bt_submit)
        Me.Name = "Form1"
        Me.Text = "GPACalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_submit As System.Windows.Forms.Button
    Friend WithEvents cb_semester As System.Windows.Forms.ComboBox
    Friend WithEvents tb_num As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents tb_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_year As System.Windows.Forms.ComboBox
    Friend WithEvents cb_dept As System.Windows.Forms.ComboBox
    Friend WithEvents cb_hrs As System.Windows.Forms.ComboBox
    Friend WithEvents cb_grade As System.Windows.Forms.ComboBox
    Friend WithEvents cb_major As System.Windows.Forms.ComboBox
    Friend WithEvents cb_retake As System.Windows.Forms.ComboBox
    Friend WithEvents lb_semester As System.Windows.Forms.Label
    Friend WithEvents lbyear As System.Windows.Forms.Label
    Friend WithEvents lb_dept As System.Windows.Forms.Label
    Friend WithEvents lb_num As System.Windows.Forms.Label
    Friend WithEvents lb_Name As System.Windows.Forms.Label
    Friend WithEvents lb_hrs As System.Windows.Forms.Label
    Friend WithEvents lb_grade As System.Windows.Forms.Label
    Friend WithEvents lb_major As System.Windows.Forms.Label
    Friend WithEvents lb_retake As System.Windows.Forms.Label
    Friend WithEvents lb_gpa As System.Windows.Forms.Label
    Friend WithEvents lb_mgpa As System.Windows.Forms.Label
    Friend WithEvents lb_gparesult As System.Windows.Forms.Label
    Friend WithEvents lb_mgparesult As System.Windows.Forms.Label
    Friend WithEvents bt_major As System.Windows.Forms.Button

End Class
