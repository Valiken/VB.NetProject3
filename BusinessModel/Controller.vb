Imports Database
Imports System.Data   
Imports System.Data.SqlServerCe

Public Class Controller

    Public orderNumber As String = 1

    'Retrieves the order IDs fro all orders in the database.
    Public Shared Function RetrieveOrders() 
        DBController.Open()
        
        Dim orders As New ArrayList
        Dim reader As SqlCeDataReader = DBController.RetrieveAll()
        While reader.Read()
            Dim order As New Order 
            order.ID = reader("ID")
            orders.Add(order)
        End While
            
        Return orders
        DBController.Close()
    End Function

    'Retrieves the Coffee IDs for all of the coffee in the database
    Public Shared Function RetireveCoffees()
        DBController.Open()

        Dim coffees As New ArrayList
        Dim reader As SqlCeDataReader = DBController.RetrieveCoffees()
        While reader.Read()
            Dim coffee As New Coffee
            coffee.name = reader("Name")
            coffee.price = reader("Price")
            coffees.Add(coffee)
        End While
        
        Return coffees
        DBController.Close()
    End Function

    Public Shared Function RetrieveLastOrder()
        DBController.Open()

        Dim lastOrder As Integer
        Dim reader As SqlCeDataReader = DBController.RetrieveLast()
        While reader.Read()
            lastOrder = reader("id")
        End While
        Return lastOrder
        DBController.Close()
    End Function

    'adds a new order if that order ID doesn't exist in the database already, otherwise prompts to ask about replacing the existing order.
    Public Function AddOrder(ByVal order As Order, Optional ByVal replace As Boolean = False) As String
        Dim msg As String = ""
        DBController.Open()
        If Not containsKey(order.ID) then
            DBController.AddOrder(order.ID, order.CustomerName, order.ServerName, order.SubTotal, order.SalesTax, order.Total, order.OrderDate)
            Dim line1 As OrderLine
            For LineNo As Integer = 0 To order.LineCount - 1
                line1 = order.GetLine(LineNo)
                DBController.AddLine(order.ID, LineNo, line1.Name, line1.Price, line1.Qty, line1.LineTotal)
            Next          
        Else
            If replace = True then
                DBController.DeleteOrder(order.ID)
                DBController.AddOrder(order.ID, order.CustomerName, order.ServerName, order.SubTotal, order.SalesTax, order.Total, order.OrderDate)
                Dim line1 As OrderLine
                For LineNo As Integer = 0 To order.LineCount - 1
                    line1 = order.GetLine(LineNo)
                    DBController.AddLine(order.ID, LineNo, line1.Name, line1.Price, line1.Qty, line1.LineTotal)
                Next
                replace = false
            Else
                msg = "Duplicate record found.  Replace (y/n)?"
            End If
        End If
        DBController.Close()
        Return msg
    End Function

    'checks to see if the order is present in the database.
    Public Function containsKey(ByVal ID As String) As Boolean
        DBController.Open()
        Dim result As Boolean = DBController.isPresent(ID)
        Return result
        DBController.Close()
    End Function    

    'Gets a single order from the database based on the key.
    Public Shared Function GetOrder(ByVal key As String) As Order
        DBController.Open()
        Dim order As New Order
        Dim reader As SQlCeDataReader = DBController.getOrder(key)
        Dim hasMoreRows As Boolean = False

        hasMoreRows = reader.Read()
        If hasMoreRows Then
            order.ID = reader("id")
            order.CustomerName = reader("CustomerName")
            order.ServerName = reader("ServerName")
            order.OrderDate = reader("OrderDate")
            While hasMoreRows
                Dim line As New OrderLine
                With line
                    .Name = reader("Coffee")
                    .Price = reader("ItemPrice")
                    .Qty = reader("ItemQuantity")
                End With
                order.AddLine(line)
                hasMoreRows = reader.Read()
            End While
        End If

        Return order
        DBController.Close()
    End Function

    'prompts to ask if you want to delete an existing order. If no order with that ID is present, prompt that nothing exists.
    Public Function deleteOrder(ByVal order As Order,Optional ByVal del As Boolean = False) As String
        Dim msg As String = ""
            DBController.Open()
            If Not containsKey(order.ID) then
                msg = "This order does not exist."     
            Else
                If del = True then
                    DBController.DeleteOrder(order.ID)
                Else
                    msg = "Delete this order?"
                End If
            End If
            DBController.Close()
            Return msg       
    End Function

    'controls the order number in  the form. Always starts at order number 1.
    Public Function orderNo()
        orderNumber += 1
        Return orderNumber
    End Function

    Public Function currentOrder()
        Dim current as Integer = RetrieveLastOrder()
        current = current + 1
        Return current
    End Function
End Class
