Imports System.IO
Public Class GPACalculator
    Public list As List(Of Course) = New List(Of Course)()
    Public c As Course

    'submit button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_submit.Click

        'declare variables
        Dim sem As String = cb_semester.SelectedItem
        Dim yr As String = cb_year.SelectedItem
        Dim dept As String = cb_dept.SelectedItem
        Dim num As Integer = Val(tb_num.Text)
        Dim cname As String = tb_name.Text
        Dim shr As Integer = cb_hrs.SelectedItem
        Dim gr As String = cb_grade.SelectedItem
        Dim maj As String = CStr(cb_major.SelectedItem)
        Dim ret As String = CStr(cb_retake.SelectedItem)


        lb_errorMessage.Text = ""

        Me.c = New Course(gr, sem, yr, dept, num, shr, cname, maj, ret)

       

        'validate inputs

        If cb_semester.SelectedIndex > -1 And cb_year.SelectedIndex > -1 And cb_year.SelectedIndex > -1 And cb_dept.SelectedIndex > -1 And _
            cb_hrs.SelectedIndex > -1 And cb_grade.SelectedIndex > -1 And cb_major.SelectedIndex > -1 And cb_retake.SelectedIndex > -1 And _
            tb_name.Text <> "" And tb_num.Text <> "" And num < 100000 And num > 1000 Then

            'use stream writer 
            Dim output As StreamWriter = New StreamWriter("course.txt", True)

            'write line to course.txt
            output.WriteLine(c.gr & ControlChars.Tab & c.sem & ControlChars.Tab & c.yr & ControlChars.Tab & c.dept & ControlChars.Tab & c.num & ControlChars.Tab & c.shr & ControlChars.Tab & c.cname & ControlChars.Tab & c.maj & ControlChars.Tab & c.ret)
            list.Add(c)

            output.Close()

            listtile()

            'oreder by years and semester
            orderbychron()

            'calculate Overall GPA and display in the label
            gpa()

            'calculate Major GPA and display in the label
            mgpa()



        Else
            lb_errorMessage.Text = "Please select an input from the dropdown list and make sure you have a right"
            Exit Sub

        End If




    End Sub


    'End Function
    Private Sub reset()
        'reset
        cb_semester.SelectedIndex = -1
        cb_year.SelectedIndex = -1
        cb_dept.SelectedIndex = -1
        cb_hrs.SelectedIndex = -1
        cb_grade.SelectedIndex = -1
        cb_major.SelectedIndex = -1
        cb_retake.SelectedIndex = -1
        tb_num.Text = ""
        tb_name.Text = ""


    End Sub

    'calculate Overall GPA
    Private Sub gpa()
        'declare variables
        Dim gpa As Decimal = 0
        Dim hr As Decimal = 0


        'read the list
        For Each c As Course In list 'make sure not divde by 0
          
                gpa = (gpa * hr + convertgrade(c.gr) * c.shr) / (hr + c.shr)
                hr += CInt(c.shr)


                'display Overall GPA
                lb_gparesult.Text = String.Format("{0:F}", gpa)


        Next
    End Sub

    'calculate major GPA
    Private Sub mgpa()

        ''declare variables 
        Dim mgpa As Decimal = 0
        Dim hr As Integer = 0
        'select Major course by linq
        Dim majorquery = From c In list
                         Where c.maj = "Yes"
                         Select c


        For Each c As Course In majorquery

            'calculate major GPA
            mgpa = (mgpa * hr + convertgrade(c.gr) * c.shr) / (hr + c.shr)
            hr += c.shr


            'dispaly major GPA
            lb_mgparesult.Text = String.Format("{0:F}", mgpa)

        Next
    End Sub
  
    'convert major letter Grade to score
    Function convertgrade(ByVal c As String) As Decimal
        Dim grade As Decimal = 0
        Select Case c
            Case "A+"
                grade = 4.33
            Case "A"
                grade = 4
            Case "A-"
                grade = 3.67
            Case "B+"
                grade = 3.33
            Case "B"
                grade = 3
            Case "B-"
                grade = 2.67
            Case "C+"
                grade = 2.33
            Case "C"
                grade = 2
            Case "C-"
                grade = 1.67
            Case "D+"
                grade = 1.33
            Case "D"
                grade = 1
            Case "D-"
                grade = 0.67
            Case Else
                grade = 0
        End Select

        Return grade
    End Function

    'add list title
    Private Sub listtile()
        ListBox1.Items.Clear() 'clean list box
        'add list title
        ListBox1.Items.Add("Grade" & ControlChars.Tab &
                           "Sem" & ControlChars.Tab &
                           "Year" & ControlChars.Tab &
                           "Dept" & ControlChars.Tab &
                           "Num" & ControlChars.Tab &
                           "Sem Hrs" & ControlChars.Tab &
                           "Name")
    End Sub

    'when the page load, display the data which is stored in the text file.
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        listtile() 'add header in the list box



        'read all lines in course.txt
        Dim coursequery = From line In File.ReadAllLines("course.txt")
        Let response As String() = line.Split(ControlChars.Tab)
        Select response



        For Each item In coursequery


            Dim c As Course = New Course(item(0), item(1), item(2), item(3), item(4), item(5), item(6), item(7), item(8))


            list.Add(c) 'show the data in the text file.

        Next

        orderbychron() 'display by chronology

        gpa() 'calculate and show the overall gpa based on the data in text file
        mgpa()  'calculate and show the major gpa based on the data in text file



    End Sub



    Private Sub orderbychron()
        Dim orderchron = From c In list
        Order By c.yr Descending

        For Each Me.c In orderchron
            displaycourse()
        Next


    End Sub

    'display the inputs in the list box
    Private Sub displaycourse()


        ListBox1.Items.Add(c.gr & ControlChars.Tab & c.sem & ControlChars.Tab & c.yr & ControlChars.Tab & c.dept & ControlChars.Tab & c.num & ControlChars.Tab & c.shr & ControlChars.Tab & c.cname)

    End Sub

    'only show the major courses
    Private Sub bt_major_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_major.Click

        ListBox1.Items.Clear()
        listtile()
        Dim majorquery = From c In list
                   Where c.maj = "Yes"
                   Select c

        For Each Me.c In majorquery
            displaycourse()

        Next

    End Sub

    'display the output by the order of department names
    Private Sub bt_dept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_dept.Click

        ListBox1.Items.Clear()
        listtile()
        Dim deptquery = From c In list
                         Order By c.dept
        For Each Me.c In deptquery
            displaycourse()

        Next


        '  For Each Me.c In majorquery
        'displaycourse()

        '   Next
    End Sub

    'display the output by chronology 
    Private Sub bt_ch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ch.Click

        listtile() 'add header
        orderbychron() 'call the procedure

    End Sub

    'show the retaken courses
    Private Sub bt_retake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_retake.Click

        listtile() 'add header

        Dim retakequery = From c In list
                          Where c.ret = "Yes" '?????????????????????????????

        For Each Me.c In retakequery
            displaycourse() 'display output in the list box
        Next
    End Sub

   

  
End Class
