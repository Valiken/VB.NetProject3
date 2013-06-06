Imports BusinessModel

Public Class OrderSummary

    Private Sub OrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Order In Controller.RetrieveOrders
            lbxSummary.Items.Add(Order.id)
        Next
    End Sub

    Public Sub updateLBX()
        For Each Order In Controller.RetrieveOrders
            lbxSummary.Items.Add(Order.id)
        Next

        lblServerPH.Text = ""
        lblCustPH.Text = "" 
        lblDatePH.Text = "" 
        lblOrderTotalPH.Text = ""
    End Sub

    Private Sub lbxSummary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSummary.SelectedIndexChanged
        'this populates the order information on the summary page. 
        Dim order As Order
        'retrieves the order from the controller from the DBController... ControllerCeption.
        If lbxSummary.SelectedItem isNot Nothing then 
            order = Controller.GetOrder(CStr(lbxSummary.SelectedItem))

            'Sets the values for the order summary in the Summary window.
            lblServerPH.Text = order.ServerName
            lblCustPH.Text = order.CustomerName
            lblDatePH.Text = order.OrderDate.ToShortDateString
            lblOrderTotalPH.Text = FormatCurrency(order.Total)
        End If
    End Sub

    Private Sub lbxSummary_doubleClick(sender As Object, e As EventArgs) Handles lbxSummary.DoubleClick, btnRetrieve.Click
        'this handles both a double click on the lbx and a button click on the retrieve button. 
        If lbxSummary.SelectedItem isNot Nothing then
            'sets up the variables for a new orderform and the two counts.
            Dim order As Order
            order = Controller.GetOrder(CStr(lbxSummary.SelectedItem))
            Dim ChildForm As New orderFrm
            Dim count As Integer = 0
            Dim lc As Integer

            'creates a count of the orderlines in the order
            For Each ol As Orderline In order.Lines
                lc += 1
            Next
            lc = lc - 1 'Corrects so that you do not have an extra blank orderline in the new form.

            'creates a new orderform to display the order that is being called and links it to the MDI parent
            ChildForm.MdiParent = frmMain
            ChildForm.Text = "Order Number" + order.ID.ToString
            ChildForm.Show()

            'for each loop to populate the orderform 
            For Each oL As Orderline In order.Lines

                ChildForm.cboCoffees(count).SelectedItem = oL.Name
                ChildForm.txtPrices(count).text = FormatCurrency(oL.Price)
                ChildForm.nudQtys(count).Value = oL.Qty
                ChildForm.txtTotals(count).text = FormatCurrency(oL.LineTotal)

                'checks to see if the number of orderlines has been reached. 
                If count < lc Then
                    ChildForm.btnAdd.PerformClick()
                    count += 1
                End If
            Next

            'populates all of the order once the orderlines have been populated.
            ChildForm.nudOrderNumber.Value = order.ID
            ChildForm.dtpDate.Value = order.OrderDate
            ChildForm.txtTotalB4Tax.Text = FormatCurrency(order.SubTotal)
            ChildForm.txtSalesTax.Text = FormatCurrency(order.SalesTax)
            ChildForm.txtGrandTotal.Text = FormatCurrency(order.Total)
            ChildForm.txtCust.Text = order.CustomerName
            ChildForm.txtServer.Text = order.ServerName
        End If
    End Sub
End Class