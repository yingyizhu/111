Public Class Course

    Private SemesterValue As String
    Private yearValue As String
    Private departmentValue As String
    Private coursenumValue As Integer
    Private coursenameValue As String
    Private semesterhourValue As Integer
    Private gradeValue As String
    Private majorValue As String
    Private courseretakenValue As String



    Public Sub New(ByVal grade As String, ByVal Semester As String, ByVal year As String, ByVal Department As String, ByVal number As Integer,
                          ByVal semhrs As Integer, ByVal coursename As String, ByVal major As String,
                          ByVal retake As String)

        yr = year
        sem = Semester
        dept = Department
        num = number
        cname = coursename
        shr = semhrs
        gr = grade
        maj = major
        ret = retake

    End Sub


    Public Property yr() As String
        Get
            Return yearValue
        End Get
        Set(ByVal value As String)
            yearValue = value
        End Set
    End Property

    Public Property sem() As String
        Get
            Return SemesterValue
        End Get
        Set(ByVal value As String)
            SemesterValue = value
        End Set
    End Property
    Public Property dept() As String
        Get
            Return departmentValue
        End Get
        Set(ByVal value As String)
            departmentValue = value
        End Set
    End Property
    Public Property num() As Integer
        Get
            Return coursenumValue
        End Get
        Set(ByVal value As Integer)
            coursenumValue = value
        End Set
    End Property
    Public Property cname() As String
        Get
            Return coursenameValue
        End Get
        Set(ByVal value As String)
            coursenameValue = value
        End Set
    End Property
    Public Property shr() As Integer
        Get
            Return semesterhourValue
        End Get
        Set(ByVal value As Integer)
     
                semesterhourValue = value


        End Set
    End Property
    Public Property gr() As String
        Get
            Return gradeValue
        End Get
        Set(ByVal value As String)
            gradeValue = value
        End Set
    End Property
    Public Property maj() As String
        Get
            Return majorValue
        End Get
        Set(ByVal value As String)
            majorValue = value
        End Set
    End Property
    Public Property ret() As String
        Get
            Return courseretakenValue
        End Get
        Set(ByVal value As String)
            courseretakenValue = value
        End Set
    End Property



End Class
