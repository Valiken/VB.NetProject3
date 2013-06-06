Imports System.Windows.Forms
Imports BusinessModel

Public Class frmMain
    Public ctrl As New Controller

    Private Sub ShowNewOrderForm(ByVal sender As Object, ByVal e As EventArgs) Handles mnuOrderFormItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New orderFrm
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        
        ChildForm.Text = "Order Number: " & ctrl.orderNumber

        ChildForm.Show()
    End Sub
    
    Private Sub ShowNewSummaryForm(sender As Object, e As EventArgs) Handles mnuSummaryFormItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New OrderSummary
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        
        ChildForm.Text = "Order Summary"

        ChildForm.Show()
    End Sub

    Private Sub DropDownHandler( sender As Object,  e As EventArgs) Handles FileMenu.DropDownOpening
        Dim activeChild As form = Me.ActiveMdiChild
        Try
            if Me.ActiveMdiChild Is Nothing then
                mnuFileClose.Enabled = False
                mnuFileDelete.Enabled = False
                mnuFileSave.Enabled = False
            ElseIf TypeOf ActiveMdiChild is orderFrm then     
                mnuFileClose.Enabled = True
                mnuFileDelete.Enabled = True
                mnuFileSave.Enabled = True
            ElseIf TypeOf ActiveMdiChild is orderSummary then
                mnuFileClose.Enabled = True
                mnuFileDelete.Enabled = False
                mnuFileSave.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProgramExit(ByVal sender As Object, ByVal e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub Cut(ByVal sender As Object, ByVal e As EventArgs) Handles mnuEditCut.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        CheckEditMenu()
        If mnuEditCut.Enabled = True Then
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                Clipboard.SetText(CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText())
                CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText = ""
            End If
        End If
    End Sub

    Private Sub Copy(ByVal sender As Object, ByVal e As EventArgs) Handles mnuEditCopy.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        CheckEditMenu()
        If mnuEditCopy.Enabled = True Then
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                Clipboard.SetText(CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText())
            End If
        End If
    End Sub

    Private Sub Paste(ByVal sender As Object, ByVal e As EventArgs) Handles mnuEditPaste.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        CheckEditMenu()
        If mnuEditPaste.Enabled Then
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText = Clipboard.GetText()
            End If
        End If
    End Sub

    Private Sub Cascade(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVert(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontal(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIcons(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsArrangeIcons.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAll(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsCloseAll.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CloseActiveChild( sender As Object,  e As EventArgs) Handles mnuFileClose.Click
        
        Try
            If TypeOf ActiveMdiChild is orderFrm then     
                Dim activeChild As orderfrm = Me.ActiveMdiChild
                activeChild.btnClose.PerformClick()
            ElseIf TypeOf ActiveMdiChild is orderSummary then
                Dim activeChild2 As ordersummary = Me.ActiveMdiChild
                activeChild2.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckEditMenu()
        ' Only allow menu choices as appropriate
        mnuEditCut.Enabled = False
        mnuEditCopy.Enabled = False
        mnuEditPaste.Enabled = False

        If Not Me.ActiveMdiChild Is Nothing Then
            If Not Me.ActiveMdiChild.ActiveControl Is Nothing Then
                If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                    If CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText <> "" Then
                        mnuEditCut.Enabled = True
                        mnuEditCopy.Enabled = True
                    End If
                    If Clipboard.ContainsText Then
                        mnuEditPaste.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Save( sender As Object,  e As EventArgs) Handles mnuFileSave.Click
        Dim activeChild As orderFrm = Me.ActiveMdiChild
        CType(activeChild.btnSave, Button).PerformClick
    End Sub

    Private Sub Delete(sender As Object, e As EventArgs) Handles mnuFileDelete.Click
        Dim activeChild As orderFrm = Me.ActiveMdiChild
        CType(activeChild.btnDelete, Button).PerformClick
    End Sub

    Public Sub updateForms()
        For Each child In MdiChildren
            If TypeOf child Is OrderSummary Then
                Dim activeChild As OrderSummary = child
                CType(activeChild.lbxSummary, ListBox).Items.Clear
                CType(activeChild.lbxSummary, ListBox).Refresh
                activeChild.updateLBX()
            End If
        Next
    End Sub
End Class
