Public Class Form1
    Private list As List(Of course)
    Private courseobject As Course
    Private position As Integer
    Private courseid As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_submit.Click
        position += 1
        courseid += 1

        courseobject = New Course(position)
        Setcourse()
        list.Add(courseobject)

        showchorn()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        position = 0 ' set initial position to zero
        courseid = 0
        list = New List(Of Course)()
    End Sub

    Private Sub setcourse()
        courseobject.semester = cb_semester.SelectedItem.ToString 'cb_semester.SelectedItem.ToString
        ' courseobject.chornsort = cb_semester.SelectedItem.ToString
        courseobject.retake = cb_retake.SelectedItem.ToString

        courseobject.dept = cb_dept.SelectedItem.ToString 'cb_dept.SelectedItem.ToString
        courseobject.grade = cb_grade.SelectedItem.ToString 'cb_grade.SelectedText
        courseobject.major = cb_major.SelectedItem.ToString ' cb_majorCourse.SelectedItem.ToString

        courseobject.semhrs = cb_hrs.SelectedItem.ToString 'cb_semHrs.SelectedItem.ToString
        courseobject.year = CInt(cb_year.SelectedItem) 'cb_year.SelectedItem.ToString

        courseobject.coursename = tb_name.Text 'tb_CourseName.Text
        courseobject.num = tb_num.Text ' tb_Num.Text
        ' courseobject.index = position
    End Sub


    Private Sub loadlisttitle()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Grade" & ControlChars.Tab & ControlChars.Tab &
                                    "Sem" & ControlChars.Tab & ControlChars.Tab &
                                    "Year" & ControlChars.Tab & ControlChars.Tab &
                                    "Dept" & ControlChars.Tab & ControlChars.Tab &
                                    "Num" & ControlChars.Tab & ControlChars.Tab &
                                    "Dem Hrs" & ControlChars.Tab & ControlChars.Tab &
                                    "Name")
    End Sub

    Private Sub showchorn()
        loadlisttitle()

        For index As Integer = 1 To position
            courseobject = list(index - 1)
            displaycourse()
        Next


    End Sub

    Private Sub showmajor()

        loadlisttitle()
        Dim majorquery = From c In list
        Where c.major Like "Yes"


        For Each courseobject As Course In majorquery
            displaycourse()
         

        Next
    End Sub
    Private Sub displaycourse()


        ListBox1.Items.Add(courseobject.grade & ControlChars.Tab & ControlChars.Tab &
          courseobject.semester & ControlChars.Tab & ControlChars.Tab &
          courseobject.year & ControlChars.Tab & ControlChars.Tab &
           courseobject.dept & ControlChars.Tab & ControlChars.Tab &
         courseobject.num & ControlChars.Tab & ControlChars.Tab &
       courseobject.semhrs & ControlChars.Tab & ControlChars.Tab &
           courseobject.coursename)


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_semester.Click

    End Sub

    Private Sub bt_major_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_major.Click
        showmajor()
    End Sub
End Class
