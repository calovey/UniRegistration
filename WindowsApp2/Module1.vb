Imports System.Data.OleDb
Module Module1
    Public cn As New OleDb.OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String

    Public Sub conn()

        cn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"


    End Sub
End Module
