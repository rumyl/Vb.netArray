Imports System.Data
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myArray(,) As Object = {
            {"Jasmine", 20, "Female"},
            {"Jocelyn", 20, "Female"},
            {"Jessa", 20, "Female"},
            {"Mitch", 20, "Female"},
            {"Abet", 30, "Male"},
            {"Angelo", 40, "Male"}
        }
        DisplayArrayInDataGridView(myArray)
    End Sub

    Private Function ConvertArrayToDataTable(ByVal dataArray As Object(,)) As DataTable
        Dim dataTable As New DataTable()

        ' Set the column headers
        dataTable.Columns.Add("Name")
        dataTable.Columns.Add("Age")
        dataTable.Columns.Add("Gender")

        ' ma add raun kita it Rows sa Data Table
        Dim rowsCount As Integer = dataArray.GetLength(0)
        Dim columnsCount As Integer = dataArray.GetLength(1)

        For i As Integer = 0 To rowsCount - 1
            Dim rowValues(columnsCount - 1) As Object
            For j As Integer = 0 To columnsCount - 1
                rowValues(j) = dataArray(i, j)
            Next
            dataTable.Rows.Add(rowValues)
        Next

        Return dataTable
    End Function

    Private Sub DisplayArrayInDataGridView(ByVal dataArray As Object(,))

        Dim dataTable As DataTable = ConvertArrayToDataTable(dataArray)

        DataGridView1.DataSource = dataTable
    End Sub

End Class
