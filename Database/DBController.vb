Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe

Public Class DBController
    
    Private Shared cn As SqlCeConnection
    ' This database is stored in the project solution folder, 
    ' so navigate from exe folder to project folder
    Private Shared cnString As String ="Data Source=..\..\..\Database\OrderDB.sdf"
    Private Shared insertCommand As SqlCeCommand
    Private Shared deleteCommand As SqlCeCommand

    'opens the database connection
    Public Shared Sub Open()
        ' Step 1: Instantiate the connection to the database
        cn = New SqlCeConnection()
        ' Step 2: Assign the connection string
        cn.ConnectionString = cnString
        ' Step 3: Open the connection
        cn.Open()
    End Sub

    'closes the database connection
    Public Shared Sub Close()
        cn.Close()
    End Sub

    'adds an order into the database.
    Public Shared Sub AddOrder(ByVal anID As String, ByVal aCustName As String, ByVal aServerName As String, ByVal aSubTotal As Double, ByVal aSalesTax As Double, ByVal aGrandTotal As Double, ByVal aOrderDate As Date)
        Dim sql As String = ""
        sql = "Insert into Orders values ('" & anID & "','" & aCustName & "','" & aServerName & "','" & aSubTotal & "','" & aSalesTax & "','" & aGrandTotal & "','" & aOrderDate & "')"
        insertCommand = New SqlCeCommand(sql, cn)
        insertCommand.ExecuteNonQuery()
    End Sub

    'adds a line with both orderID, and LineNumber acting as its primary key.
    Public Shared Sub AddLine(ByVal ID As String, ByVal LineNo As String, ByVal Coffee As String, ByVal Price As Double, ByVal Qty As Integer, ByVal LineTotal As double)
        Dim sql As String = ""

        sql += "Insert into OrderLine values('"
        sql += ID & "','"
        sql += LineNo & "','"
        sql += Coffee & "','"
        sql += Price & "','"
        sql += Qty & "','"
        sql += LineTotal & "')"

        insertCommand = New SqlCeCommand(sql, cn)
        insertCommand.ExecuteNonQuery()
    End Sub

    'delets the order. Orderlines are deleted first, and then the order is deleted.
    Public Shared Sub DeleteOrder(ByVal ID As String)
        Dim sql As String = ""

        sql = ""
        sql += "Delete "
        sql += "From OrderLine "
        sql += "Where ID = '" & ID & "'"

        deleteCommand = New SqlCeCommand(sql, cn)
        deleteCommand.ExecuteNonQuery()

        sql = ""
        sql += "Delete "
        sql += "From Orders "
        sql += "Where ID = '" & ID & "'"

        deleteCommand = New SqlCeCommand(sql, cn)
        deleteCommand.ExecuteNonQuery()

    End Sub
    
    'gets an order based on the provided order ID from the database.
    Public Shared Function getOrder(ByVal anID As String) As SqlCeDataReader
        'Open the connection and retrieve the information
        Open()
        Dim sql = "Select * From Orders, OrderLine where Orders.id = OrderLine.Id And Orders.id = '" & anID & "' "
        Dim selectCommand As New SqlCeCommand(sql, cn)
        Dim reader As SqlCeDataReader = selectCommand.ExecuteReader()
        Return reader
    End Function

    'Checks to see if an order is present, if it exists it will return a true boolean value.
    Public Shared Function isPresent(ByVal ID As String) As Boolean
        Dim command As SqlCeCommand
        Dim exists As Boolean = False
        Dim sql As String = ""

        sql += "Select count(*) "
        sql += "From Orders "
        sql += "Where ID = '" & ID & "'"

        command = New SqlCeCommand(sql, cn)

        Dim recordCount As Integer = command.ExecuteScalar()
        If recordCount >= 1 Then
            exists = True
        End If

        Return exists
    End Function

    'retrieves all of the orders from the database. Used for the summary form.
    Public Shared Function RetrieveAll()
        Dim command As SqlCeCommand
        Dim sql As String = ""

        sql = ""
        sql += "Select id "
        sql += "From Orders "

        command = New SqlCeCommand(sql, cn)
        Dim reader As SqlCeDataReader = command.ExecuteReader()

        Return reader
    End Function

    'retrieves all of the coffees
    Public Shared Function RetrieveCoffees()
        Dim command As SqlCeCommand
        Dim sql As String = ""

        sql = ""
        sql += "Select * "
        sql += "From Coffee"
        
        command = New SqlCeCommand(sql, cn)
        Dim reader As SqlCeDataReader = command.ExecuteReader()

        Return reader
    End Function

    Public Shared Function RetrieveLast()
        Dim command As SqlCeCommand
        Dim sql As String = ""

        sql = ""
        sql += "Select id "
        sql += "From Orders "
        sql += "Order By id Asc"

        command = New SqlCeCommand(sql, cn)
        Dim reader As SqlCeDataReader = command.ExecuteReader()

        Return reader
    End Function
End Class
