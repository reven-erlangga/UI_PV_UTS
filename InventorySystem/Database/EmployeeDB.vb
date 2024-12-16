Imports MySql.Data.MySqlClient

Public Class EmployeeModel
    Public Property ID As Integer
    Public Property Name As String
    Public Property Gender As String
    Public Property NIK As String
    Public Property Image As String

    Public Property Department As DepartmentModel
    Public Property Division As Division
End Class

Module EmployeeDB
    Function Fetch() As List(Of EmployeeModel)
        Connection.Connect()

        Dim employees As New List(Of EmployeeModel)
        Dim cmd As New MySqlCommand("SELECT * FROM `employees`", Connection.conn)

        Dim reader = cmd.ExecuteReader()
        While reader.Read
            Dim employee As New EmployeeModel

            employee.ID = reader.Item("id")
            employee.Name = reader.Item("name")
            employee.NIK = reader.Item("nik")

            employees.Add(employee)
        End While
        reader.Dispose()

        Connection.Disconnect()

        If employees Is Nothing Then
            Return Nothing
        End If

        If employees.Count() > 0 Then
            Return employees
        End If

        Return Nothing
    End Function
    Function Insert(NIK As String, Name As String, RFID As String, Gender As String, DepartmentID As Integer, DivisionID As Integer, Image As String) As Boolean
        Connection.Connect()
        Dim cmd As New MySqlCommand("INSERT INTO `employees` (`nik`, `name`, `rfid`, `gender`, `department_id`, `division_id`, `image`) VALUES (@nik, @name, @rfid, @gender, @department_id, @division_id, @image)", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@nik", NIK)
        cmd.Parameters.AddWithValue("@name", Name)
        cmd.Parameters.AddWithValue("@rfid", RFID)
        cmd.Parameters.AddWithValue("@gender", Gender)
        cmd.Parameters.AddWithValue("@department_id", DepartmentID)
        cmd.Parameters.AddWithValue("@division_id", DivisionID)
        cmd.Parameters.AddWithValue("@image", Image)

        Dim i = cmd.ExecuteNonQuery
        Connection.Disconnect()
        If i > 0 Then
            Return True
        End If

        Return False
    End Function

    Function FindByRFID(RFID As String) As EmployeeModel
        Connection.Connect()

        Dim employee As New EmployeeModel
        Dim cmd As New MySqlCommand("SELECT employees.id as id, employees.name as name, employees.gender as gender, employees.nik as nik, employees.image as image, departments.name as department_name, divisions.name as division_name FROM `employees` JOIN departments JOIN divisions WHERE `rfid` = @rfid LIMIT 1", Connection.conn)

        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@rfid", RFID)

        Dim reader = cmd.ExecuteReader()

        If (reader.Read()) Then

            employee.ID = reader("id")
            employee.Name = reader("name")
            employee.Gender = reader("gender")
            employee.NIK = reader("nik")

            If reader("image") IsNot DBNull.Value Then
                employee.Image = reader("image")
            End If

            Dim Department As New DepartmentModel

            Department.Name = reader("department_name")
            employee.Department = Department

            Dim Division As New Division

            Division.Name = reader("division_name")
            employee.Division = Division

            Connection.Disconnect()

            Return employee
        End If

        Connection.Disconnect()

        Return Nothing

    End Function
End Module
