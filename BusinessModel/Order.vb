Public Class Order
    Private m_ID As Integer
    Private m_ServerName, m_CustName As String
    Private m_Date As Date
    Private m_SalesTaxRate = 0.09
    Private m_OrderLines As New ArrayList

    'adds a line.
    Public Sub AddLine(ByVal line As Orderline)
        m_OrderLines.Add(line)
    End Sub

    'Return the orderline at this index
    Public Function GetLine(ByVal index As Integer) As Orderline
        Return m_OrderLines(index)
    End Function

    'getting all the lines yo.
    Public Function Lines() 
        Dim oL As New ArrayList
        oL.Clear()

        Dim count As Integer = m_OrderLines.Count - 1
        Dim index As Integer
        For index = 0 to count Step 1
            oL.Add(GetLine(index))
        Next

        Return oL
    End Function

    'This should return the linecount
    Public ReadOnly Property LineCount() As Integer
        Get
            Return m_OrderLines.Count
        End Get
    End Property

    'This the function for finding the order line count. 
    Public Function OLCount()
        Dim cnt As Integer
        For Each line In m_OrderLines
            cnt =+ 1 
        Next
            cnt = cnt - 1
        Return cnt
    End Function

    'This the get set for the order ID
    Public Property ID As Integer
        Get
            Return m_ID
        End Get
        Set(ByVal value As Integer)
            m_ID = value
        End Set
    End Property

    'This the get set for the server name 
    Public Property ServerName As String
        Get
            Return m_ServerName
        End Get
        Set(ByVal value As String)
            m_ServerName = value
        End Set
    End Property

    'This the get set for the Customer Name
    Public Property CustomerName As String
        Get
            Return m_CustName
        End Get
        Set(value As String)
            m_CustName = value
        End Set
    End Property

    'This the get set for the order date
    Public Property OrderDate As Date
        Get
            Return m_Date
        End Get
        Set(value As Date)
            m_Date = value
        End Set
    End Property

    'These three properties only return the totals and sales tax for the order, from the orderlines. 
    Public ReadOnly Property SubTotal As Double
        Get
            Dim total As Double
            For Each sT As Orderline In m_OrderLines
                total += sT.LineTotal
            Next
            Return total
        End Get
    End Property

    Public ReadOnly Property SalesTax As Double
        Get
            Return SubTotal * m_SalesTaxRate
        End Get
    End Property

    Public ReadOnly Property Total As Double
        Get
            Return SubTotal + SalesTax
        End Get
    End Property

End Class
