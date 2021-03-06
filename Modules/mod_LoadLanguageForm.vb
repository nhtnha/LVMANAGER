Module mod_LoadLanguageForm
    Dim mvCls_LoadLanguage as New cls_LoadLanguage
    '#-----------------------------------------------------------------------
    '# ModuleName       :       mod_LoadLanguageForm
    '# Description      :       Load language into form
    '# Author           :       love@ngel Nguyen Hoang
    '# CreateDate       :       2011-07-15
    '# LastUpdate       :       2011-07-15
    '#-----------------------------------------------------------------------
#Region "Form login"
    Public Sub SubG_LoginForm()
        Try
            frm_Login.lblUserName.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 1)
            frm_Login.lblPassword.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Login", 1)
            frm_Login.lblTitle.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Login", 1)
            frm_Login.cmdDangNhap.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Login", 1)

            frm_Login.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Alert", 1)

            frm_Login.rgpLanguage.Properties.Items(0).Description = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Login", 1)
            frm_Login.rgpLanguage.Properties.Items(1).Description = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Login", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form MainMenu"
    Public Sub SubG_MainMenuForm()
        Try
            'frm_MainMenu.cmdSales.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_MainMenu", 1)
            'frm_MainMenu.cmdStore.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_MainMenu", 1)
            'frm_MainMenu.cmdReport.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_MainMenu", 1)
            'frm_MainMenu.cmdSetup.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_MainMenu", 1)
            'frm_MainMenu.lblProductName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_MainMenu", 1)
            'frm_MainMenu.cmdLicense.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_MainMenu", 1)
            'frm_MainMenu.cmdContact.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_MainMenu", 1)
            'frm_MainMenu.cmdQuantitative.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_MainMenu", 1)
            'frm_MainMenu.lblTrial.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_MainMenu", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Report"
    Public Sub SubG_ReportForm()
        Try
            'frm_Reports.lblProductName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_MainMenu", 1)

            'frm_Reports.cmdFinance.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Reports", 1)
            'frm_Reports.cmdBills.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Reports", 1)
            'frm_Reports.cmdReportBill.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Reports", 1)
            'frm_Reports.cmdDebts.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Reports", 1)
            'frm_Reports.cmdVipCard.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Reports", 1)
            'frm_Reports.cmdReturn.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Reports", 1)
            'frm_Reports.cmdPayment.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Reports", 1)
            'frm_Reports.cmdStock.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Reports", 1)
            'frm_Reports.cmdCheckBill.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Reports", 1)
            'frm_Reports.cmdVat.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Reports", 1)
            'frm_Reports.cmdReceiptPayment.Text = mvCls_LoadLanguage.FuncG_GetData(11, "frm_Reports", 1)
            'frm_Reports.cmdBalance.Text = mvCls_LoadLanguage.FuncG_GetData(12, "frm_Reports", 1)
            'frm_Reports.cmdUpdateDB.Text = mvCls_LoadLanguage.FuncG_GetData(13, "frm_Reports", 1)
            'frm_Reports.cmdWorking.Text = mvCls_LoadLanguage.FuncG_GetData(14, "frm_Reports", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Alert"
    Public Sub SubG_AlertForm()
        Try
            'frm_Alert.cmdYes.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Alert", 1)
            'frm_Alert.cmdNo.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Alert", 1)
            'frm_Alert.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Alert", 1)
            If gvByte_Language = 1 Then
                frm_Alert.cmdYes.Text = "Yes"
                frm_Alert.cmdNo.Text = "No"
                frm_Alert.cmdExit.Text = "Exit"
            Else
                frm_Alert.cmdYes.Text = "Yes"
                frm_Alert.cmdNo.Text = "No"
                frm_Alert.cmdExit.Text = "Exit"
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "User Control Full Screen Keyboard"
    Public Sub SubG_FullScreenKeyboard(ByVal iBtn_Del As DevExpress.XtraEditors.SimpleButton)
        Try
            iBtn_Del.Text = mvCls_LoadLanguage.FuncG_GetData(1, "urc_FullScreenKeyboard", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Change Password"
    Public Sub SubG_ChangePasswordForm()
        Try
            frm_ChangePassword.lblOldPass.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_ChangPassword", 1)
            frm_ChangePassword.lblNewPass.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_ChangPassword", 1)
            frm_ChangePassword.lblRePass.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_ChangPassword", 1)
            frm_ChangePassword.gpcChangePass.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_ChangPassword", 1)
            frm_ChangePassword.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_ChangPassword", 1)
            frm_ChangePassword.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_ChangPassword", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Shutdown"
    Public Sub SubG_ShutdownForm()
        Try
            'frm_Shutdown.cmdTurnOff.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Shutdown", 1)
            'frm_Shutdown.cmdRestart.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Shutdown", 1)
            'frm_Shutdown.cmdClose.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Shutdown", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Area"
    Public Sub SubG_AreaForm()
        Try
            frm_Area.gpcArea.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Area", 1)
            frm_Area.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Area.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_Area.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Area", 1)
            frm_Area.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Area", 1)
            frm_Area.cmdUp.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Area", 1)
            frm_Area.cmdDown.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Area", 1)
            frm_Area.cmdOn.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Area", 1)
            frm_Area.cmdOff.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Area", 1)

            frm_SetMenu.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_SetMenu.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_SetMenu.SimpleButton3.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Customer", 1)

            ' frm_Promat.cmdEdit.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Promat.cmdEdit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Location", 1)
            frm_Promat.cmdSearch.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Customer", 1)
            frm_Promat.cmdAddNew.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Customer", 1)
            frm_Promat.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Customer", 1)

            frm_DeptCollection.cmdConfirm.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_DeptCollection.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)


            frm_CompanyInfo.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_CompanyInfo.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)



        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form GroupItem"
    Public Sub SubG_GroupItemForm()
        Try
            frm_GroupItem.gpcArea.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_GroupItem", 1)
            frm_GroupItem.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_GroupItem.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_GroupItem.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Area", 1)
            frm_GroupItem.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Area", 1)
            'frm_GroupItem.cmdUp.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Area", 1)
            'frm_GroupItem.cmdDown.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Area", 1)
            frm_GroupItem.RadioGroup1.Properties.Items(0).Description = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Area", 1)
            frm_GroupItem.RadioGroup1.Properties.Items(1).Description = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Printer"
    Public Sub SubG_PrinterForm()
        Try
            'frm_Printer.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Printer", 1)
            'frm_Printer.cmdCapNhat.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            'frm_Printer.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            'frm_Printer.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Area", 1)
            'frm_Printer.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Area", 1)
            'frm_Printer.cmdUp.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Area", 1)
            'frm_Printer.cmdDown.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Area", 1)
            'frm_Printer.cmdOn.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Area", 1)
            'frm_Printer.cmdOff.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Sale"
    Public Sub SubG_SaleForm()
        Try
            'frm_Sale.lblOrderNo.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Sale", 1)
            'frm_Sale.lblTable.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Sale", 1)
            'frm_Sale.lblEmployee.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Sale", 1)
            'frm_Sale.lblCustomer.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Sale", 1)
            'frm_Sale.lblTotalText.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Sale", 1)
            'frm_Sale.lblDiscountText.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Sale", 1)
            'frm_Sale.lblServiceText.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Sale", 1)
            'frm_Sale.lblFinalCostText.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Sale", 1)
            'frm_Sale.cmdProvisional.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Sale", 1)
            'frm_Sale.cmdPrice1.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Sale", 1)
            'frm_Sale.cmdPrice2.Text = mvCls_LoadLanguage.FuncG_GetData(11, "frm_Sale", 1)
            'frm_Sale.cmdEmployee.Text = mvCls_LoadLanguage.FuncG_GetData(12, "frm_Sale", 1)
            'frm_Sale.cmdCustomers.Text = mvCls_LoadLanguage.FuncG_GetData(13, "frm_Sale", 1)
            'frm_Sale.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(14, "frm_Sale", 1)
            'frm_Sale.cmdReturn.Text = mvCls_LoadLanguage.FuncG_GetData(15, "frm_Sale", 1)
            'frm_Sale.cmdOpenItem.Text = mvCls_LoadLanguage.FuncG_GetData(16, "frm_Sale", 1)
            'frm_Sale.cmdPreview.Text = mvCls_LoadLanguage.FuncG_GetData(17, "frm_Sale", 1)
            'frm_Sale.cmdOrder.Text = mvCls_LoadLanguage.FuncG_GetData(18, "frm_Sale", 1)
            'frm_Sale.cmdOpenPrice.Text = mvCls_LoadLanguage.FuncG_GetData(19, "frm_Sale", 1)
            'If gvByte_Language = 1 Then
            '    frm_Sale.cmdShift.Text = "Tầng 2"
            'Else
            '    frm_Sale.cmdShift.Text = "Shift 2"
            'End If

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "frm_StockInHand"
    Public Sub SubG_StockInHand()
        Try

            frm_StockInHand.cmdSave.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_StockInHand.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_StockInHand.cmdAdd.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Customer", 1)
            frm_StockInHand.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Customer", 1)


        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "frm_ImportExport"
    Public Sub SubG_ImportExport()
        Try

            frm_ImportExport.cmdEdit.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_ImportExport.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_ImportExport.cmdAdd.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Customer", 1)
            frm_ImportExport.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Customer", 1)



        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Form Table"
    Public Sub SubG_TableForm()
        Try
            'frm_Table.lblCashier.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Table", 1)
            'frm_Table.cmdOpen.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Table", 1)
            'frm_Table.cmdSplit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Table", 1)
            'frm_Table.cmdEnter.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Table", 1)
            'frm_Table.cmdTransfer.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Table", 1)
            'frm_Table.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Table", 1)
            'frm_Table.cmdRePrint.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Table", 1)
            'frm_Table.cmdChangePass.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Table", 1)
            'frm_Table.cmdPay.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Table", 1)
            'frm_Table.cmdReceiptPayment.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Table", 1)
            'frm_Table.cmdReport.Text = mvCls_LoadLanguage.FuncG_GetData(11, "frm_Table", 1)

            'frm_Table.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Account"
    Public Sub SubG_AccountForm()
        Try
            frm_Account.gpcAccount.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Account", 1)
            frm_Account.gpcRight.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Account", 1)
            frm_Account.cheSale.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Account", 1)
            frm_Account.cheSetting.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Account", 1)
            frm_Account.cheReport.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Account", 1)
            frm_Account.cheInventory.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Account", 1)
            frm_Account.cheReturn.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Account", 1)
            frm_Account.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Account", 1)
            frm_Account.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Account", 1)
            frm_Account.cheChangePass.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Account", 1)
            frm_Account.lblRePass.Text = mvCls_LoadLanguage.FuncG_GetData(11, "frm_Account", 1)
            frm_Account.rgpStatus.Properties.Items(0).Description = mvCls_LoadLanguage.FuncG_GetData(12, "frm_Account", 1)
            frm_Account.rgpStatus.Properties.Items(1).Description = mvCls_LoadLanguage.FuncG_GetData(13, "frm_Account", 1)
            Try
                frm_Account.DxValidationProvider1.GetValidationRule(frm_Account.txtID).ErrorText = mvCls_LoadLanguage.FuncG_GetData(14, "frm_Account", 1)
                frm_Account.DxValidationProvider1.GetValidationRule(frm_Account.txtRePassword).ErrorText = mvCls_LoadLanguage.FuncG_GetData(15, "frm_Account", 1)
            Catch ex As Exception

            End Try

            frm_Account.cheDelete.Text = mvCls_LoadLanguage.FuncG_GetData(16, "frm_Account", 1)
            frm_Account.cmdUpdate.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Account.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#Region "Employee"

#End Region
#End Region
#Region "Form Setup"
    Public Sub SubG_SetupForm()
        Try
            'frm_Setup.cmdItem.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Setup", 1)
            'frm_Setup.cmdGroupItem.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Setup", 1)
            'frm_Setup.cmdDiscount.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Setup", 1)
            'frm_Setup.cmdEmployee.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Setup", 1)
            'frm_Setup.cmdPrinter.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Setup", 1)
            'frm_Setup.cmdArea.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Setup", 1)
            'frm_Setup.cmdTable.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Setup", 1)
            'frm_Setup.cmdCustomer.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Setup", 1)
            'frm_Setup.cmdRate.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_Setup", 1)
            'frm_Setup.cmdUser.Text = mvCls_LoadLanguage.FuncG_GetData(10, "frm_Setup", 1)
            'frm_Setup.cmdCard.Text = mvCls_LoadLanguage.FuncG_GetData(11, "frm_Setup", 1)
            'frm_Setup.cmdClose.Text = mvCls_LoadLanguage.FuncG_GetData(12, "frm_Setup", 1)
            'frm_Setup.lblProductName.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_MainMenu", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Customer"
    Public Sub SubG_CustomerForm()
        Try
            frm_Customer.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Customer", 1)
            frm_Customer.cmdSearch.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Customer", 1)
            frm_Customer.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Customer", 1)
            frm_Customer.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Customer", 1)
            frm_Customer.lblAddress.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Customer", 1)
            frm_Customer.lblPhone.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Customer", 1)
            frm_Customer.lblError.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Customer", 1)
            frm_Customer.cmdRemove.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Customer", 1)
            frm_Customer.cmdUpdate.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Customer.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form frm_Supplier"
    Public Sub SubG_Supplier()
        Try
            frm_Supplier.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(13, "frm_Customer", 1)
            frm_Supplier.cmdSearch.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Customer", 1)
            frm_Supplier.lblID.Text = "Providers ID" 'mvCls_LoadLanguage.FuncG_GetData(3, "frm_Customer", 1)
            frm_Supplier.lblName.Text = "Providers Name" 'mvCls_LoadLanguage.FuncG_GetData(4, "frm_Customer", 1)
            frm_Supplier.lblAddress.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Customer", 1)
            frm_Supplier.lblPhone.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Customer", 1)
            frm_Supplier.lblError.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Customer", 1)
            frm_Supplier.cmdRemove.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Customer", 1)
            frm_Supplier.cmdUpdate.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Supplier.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Employee"
    Public Sub SubG_EmployeeForm()
        Try
            frm_Employee.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Employee", 1)
            frm_Employee.lblID.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Employee", 1)
            frm_Employee.lblName.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Employee", 1)

            frm_Employee.cmdSearch.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Customer", 1)
            frm_Employee.lblAddress.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Customer", 1)
            frm_Employee.lblPhone.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Customer", 1)
            frm_Employee.lblError.Text = mvCls_LoadLanguage.FuncG_GetData(7, "frm_Customer", 1)
            frm_Employee.cmdRemove.Text = mvCls_LoadLanguage.FuncG_GetData(8, "frm_Customer", 1)
            frm_Employee.cmdUpdate.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_Employee.cmdAdd.Text = mvCls_LoadLanguage.FuncG_GetData(9, "frm_SaleOff", 1)
            frm_Employee.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
            frm_Employee.cmdDelete.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_KaraokeCharge", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Receipt-Payment"
    Public Sub SubG_ReceiptPaymentForm()
        Try
            frm_ReceiptPayment.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_ReceiptPayment", 1)
            frm_ReceiptPayment.lblUser.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_ReceiptPayment", 1)
            frm_ReceiptPayment.lblMoney.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_ReceiptPayment", 1)
            frm_ReceiptPayment.lblDescription.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_ReceiptPayment", 1)
            frm_ReceiptPayment.cmdReceipt.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_ReceiptPayment", 1)
            frm_ReceiptPayment.cmdPayment.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_ReceiptPayment", 1)

            ' frm_ReceiptPayment.DxValidationProvider1.GetValidationRule(frm_ReceiptPayment.txtUser).ErrorText = mvCls_LoadLanguage.FuncG_GetData(14, "frm_Account", 1)
            frm_ReceiptPayment.cmdUpdate.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Area", 1)
            frm_ReceiptPayment.cmdExit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Area", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form Contact"
    Public Sub SubG_ContactForm()
        Try
            frm_Contact.lblHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Contact", 1)
            frm_Contact.lblDesignBy.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Contact", 1)
            frm_Contact.lblPhone.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Contact", 1)
            frm_Contact.lblEmail.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Contact", 1)
            frm_Contact.lblThanks.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Contact", 1)
            frm_Contact.cmdThoat.Text = mvCls_LoadLanguage.FuncG_GetData(6, "frm_Contact", 1)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Form frm_Location"
    Public Sub SubG_frm_Location()
        Try

            frm_Location.cmdEdit.Text = mvCls_LoadLanguage.FuncG_GetData(3, "frm_Location", 1)
            frm_Location.cmdClose.Text = mvCls_LoadLanguage.FuncG_GetData(5, "frm_Location", 1)
            frm_Location.cmdAddNew.Text = mvCls_LoadLanguage.FuncG_GetData(2, "frm_Location", 1)
            frm_Location.cmdConfirm.Text = mvCls_LoadLanguage.FuncG_GetData(4, "frm_Location", 1)
            frm_Location.gpcHeader.Text = mvCls_LoadLanguage.FuncG_GetData(1, "frm_Location", 1)



        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Bắt lỗi"
    Public Sub SubG_Alert(ByVal iInt_Flag As Integer)
        Try
            Select Case iInt_Flag
                Case 1
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(2, "frm_Login", 2), frm_Alert.WTYPE.ERROR)
                Case 2
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(3, "frm_Login", 2), frm_Alert.WTYPE.ERROR)
                Case 3
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(4, "frm_Login", 2), frm_Alert.WTYPE.ERROR)
                Case 4
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(5, "frm_Customer", 2), frm_Alert.WTYPE.ERROR)
                Case 5
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(6, "frm_Employee", 2), frm_Alert.WTYPE.ERROR)
                Case 6
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(9, "frm_GroupItem", 2), frm_Alert.WTYPE.ERROR)
                Case 7
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(16, "frm_NewPrice", 2), frm_Alert.WTYPE.ERROR)
                Case 8
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(17, "frm_Printer", 2), frm_Alert.WTYPE.ERROR)
                Case 9
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(18, "frm_Rate", 2), frm_Alert.WTYPE.ERROR)
                Case 10
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(19, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 11
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(20, "frm_RePrintBill", 2), frm_Alert.WTYPE.ERROR)
                Case 12
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(21, "frm_RePrintBill", 2), frm_Alert.WTYPE.ERROR)
                Case 13
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(22, "frm_Return", 2), frm_Alert.WTYPE.ERROR)
                Case 14
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(23, "frm_Return", 2), frm_Alert.WTYPE.ERROR)
                Case 15
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(24, "frm_Sale", 2), frm_Alert.WTYPE.ERROR)
                Case 16
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(25, "frm_Sale", 2), frm_Alert.WTYPE.ERROR)
                Case 17
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(26, "frm_SetArea", 2), frm_Alert.WTYPE.ERROR)
                Case 18
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(27, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 19
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(28, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 20
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(29, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 21
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(30, "frm_SpilitQty", 2), frm_Alert.WTYPE.ERROR)
                Case 22
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(31, "frm_SpilitQty", 2), frm_Alert.WTYPE.ERROR)
                Case 23
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(36, "frm_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 24
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(34, "frm_Table", 2), mvCls_LoadLanguage.FuncG_GetData(35, "frm_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 25
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(32, "frm_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 26
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(33, "frm_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 27
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(37, "frm_DiscountServiceVat", 2), frm_Alert.WTYPE.ERROR)
                Case 28
                    'FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(38, "frm_ReceiptPayment", 2), mvCls_LoadLanguage.FuncG_GetData(38, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 29
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(14, "frm_LoadReport", 2), frm_Alert.WTYPE.ERROR)
                Case 30
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(13, "frm_License", 2), mvCls_LoadLanguage.FuncG_GetData(11, "frm_License", 2), frm_Alert.WTYPE.ERROR)
                Case 31
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(13, "frm_License", 2), mvCls_LoadLanguage.FuncG_GetData(12, "frm_License", 2), frm_Alert.WTYPE.ERROR)
                Case 32
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(13, "frm_License", 2), mvCls_LoadLanguage.FuncG_GetData(10, "frm_License", 2), frm_Alert.WTYPE.ERROR)
                Case 33
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(7, "frm_ChangePassword", 2), frm_Alert.WTYPE.ERROR)
                Case 34
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(8, "frm_ChangePassword", 2), frm_Alert.WTYPE.ERROR)
                Case 35
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(38, "frm_ReceiptPayment", 2), mvCls_LoadLanguage.FuncG_GetData(41, "frm_Cash", 2), frm_Alert.WTYPE.ERROR)
                Case 36
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(42, "frm_Area", 2), frm_Alert.WTYPE.ERROR)
                Case 37
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(48, "frm_NewItem", 2), frm_Alert.WTYPE.ERROR)
                Case 38
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(49, "frm_NewItem", 2), frm_Alert.WTYPE.ERROR)
                Case 39
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(50, "frm_DiscountVoucher", 2), frm_Alert.WTYPE.ERROR)
                Case 40
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(51, "frm_DiscountVoucher", 2), frm_Alert.WTYPE.ERROR)
                Case 41
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(52, "urc_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 42
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(53, "urc_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 43
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(54, "urc_Table", 2), frm_Alert.WTYPE.ERROR)
                Case 44
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(55, "frm_Dept", 2), frm_Alert.WTYPE.ERROR)
                Case 45
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(56, "frm_Dept", 2), frm_Alert.WTYPE.ERROR)
                Case 46
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(57, "frm_Sales", 2), frm_Alert.WTYPE.ERROR)
                Case 47
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(58, "frm_Table ", 2), frm_Alert.WTYPE.ERROR)
                Case 48
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(59, "frm_Table ", 2), frm_Alert.WTYPE.ERROR)
                Case 49
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(60, "frm_Table ", 2), frm_Alert.WTYPE.ERROR)
                Case 50
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(61, "frm_Table ", 2), frm_Alert.WTYPE.ERROR)
                Case 51
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(1, "frm_Login", 2), mvCls_LoadLanguage.FuncG_GetData(62, "frm_Table ", 2), frm_Alert.WTYPE.ERROR)
                Case 52
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(63, "frm_Return", 2), frm_Alert.WTYPE.ERROR)
                Case 53
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(64, "frm_Return", 2), frm_Alert.WTYPE.ERROR)
                Case 54
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(65, "frm_TotalCash", 2), frm_Alert.WTYPE.ERROR)
                Case 55
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(66, "frm_TotalCash", 2), frm_Alert.WTYPE.ERROR)
                Case 56
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(67, "frm_ReportsFromTo", 2), frm_Alert.WTYPE.ERROR)
                Case 57
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(15, "frm_LoadReport", 2), mvCls_LoadLanguage.FuncG_GetData(68, "frm_ReportsFromTo", 2), frm_Alert.WTYPE.ERROR)

                Case 58
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(69, "frm_ReportsFromTo", 2), frm_Alert.WTYPE.STOP)

                Case 59
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(70, "frm_ReportsFromTo", 2), frm_Alert.WTYPE.CHECK)

                Case 60
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(71, "frm_ImportExport", 2), frm_Alert.WTYPE.CHECK)

                Case 61
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(72, "frm_ImportExport", 2), frm_Alert.WTYPE.ERROR)
                Case 62
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(73, "frm_ImportExport", 2), frm_Alert.WTYPE.STOP)
                Case 63
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(74, "cls_Config", 2), frm_Alert.WTYPE.ERROR)
                Case 64
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(75, "frm_Account", 2), frm_Alert.WTYPE.ERROR)
                Case 65
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(76, "frm_AddEditLocation", 2), frm_Alert.WTYPE.ERROR)
                Case 66
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(77, "frm_AddEditLocation", 2), frm_Alert.WTYPE.ERROR)
                Case 67
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(78, "frm_AddEditLocation", 2), frm_Alert.WTYPE.ERROR)
                Case 68
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(79, "frm_AddEditLocation", 2), frm_Alert.WTYPE.ERROR)
                Case 69
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(80, "frm_AddNewMaterial", 2), frm_Alert.WTYPE.ERROR)
                Case 70
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(81, "frm_AddNewMaterial", 2), frm_Alert.WTYPE.ERROR)
                Case 71
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(82, "frm_Area", 2), frm_Alert.WTYPE.ERROR)
                Case 72
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(83, "frm_ChangePassword", 2), frm_Alert.WTYPE.CHECK)
                Case 73
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(84, "frm_ChangePassword", 2), frm_Alert.WTYPE.CHECK)
                Case 74
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(85, "frm_CompanyInfo", 2), frm_Alert.WTYPE.CHECK)
                Case 75
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(86, "frm_Customer", 2), frm_Alert.WTYPE.ERROR)
                Case 76
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(87, "frm_DeptCollection", 2), frm_Alert.WTYPE.ERROR)
                Case 77
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(88, "frm_DeptCollection", 2), frm_Alert.WTYPE.ERROR)
                Case 78
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(89, "frm_DeptCollection", 2), frm_Alert.WTYPE.ERROR)
                Case 79
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(90, "frm_DeptCollection", 2), frm_Alert.WTYPE.ERROR)
                Case 80
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(131, "Message", 2), mvCls_LoadLanguage.FuncG_GetData(91, "frm_DeptCollection", 2), frm_Alert.WTYPE.CHECK)
                Case 81
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(92, "frm_EditItem", 2), frm_Alert.WTYPE.ERROR)
                Case 82
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(93, "frm_EditItem", 2), frm_Alert.WTYPE.ERROR)
                Case 83
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(94, "frm_EditItem", 2), frm_Alert.WTYPE.ERROR)
                Case 84
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(95, "frm_ExportInvoice", 2), frm_Alert.WTYPE.STOP)
                Case 85
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(96, "frm_ExportInvoice", 2), frm_Alert.WTYPE.STOP)
                Case 86
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(97, "frm_ExportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 87
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(98, "frm_ExportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 88
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(99, "frm_ExportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 89
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(100, "frm_ExportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 90
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(101, "frm_GroupItem", 2), frm_Alert.WTYPE.ERROR)
                Case 91
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(102, "frm_ImportInvoice", 2), frm_Alert.WTYPE.STOP)
                Case 92
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(103, "frm_ImportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 93
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(104, "frm_ImportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 94
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(105, "frm_ImportInvoice", 2), frm_Alert.WTYPE.ERROR)
                Case 95
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(106, "frm_License", 2), frm_Alert.WTYPE.ERROR)
                Case 96
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(107, "frm_License", 2), frm_Alert.WTYPE.ERROR)
                Case 97
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(108, "frm_Location", 2), frm_Alert.WTYPE.STOP)
                Case 98
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(109, "frm_Location", 2), frm_Alert.WTYPE.ERROR)
                Case 99
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(110, "frm_Login", 2), frm_Alert.WTYPE.ERROR)
                Case 100
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(111, "frm_Login", 2), frm_Alert.WTYPE.ERROR)
                Case 101
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(112, "frm_MainMenu", 2), frm_Alert.WTYPE.STOP)
                Case 102
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(113, "frm_Printer", 2), frm_Alert.WTYPE.STOP)
                Case 103
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(130, "Warning", 2), mvCls_LoadLanguage.FuncG_GetData(114, "frm_Promat", 2), frm_Alert.WTYPE.STOP)
                Case 104
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(115, "frm_Promat", 2), frm_Alert.WTYPE.ERROR)
                Case 105
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(116, "frm_Rate", 2), frm_Alert.WTYPE.ERROR)
                Case 106
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(117, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 107
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(118, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 108
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(119, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 109
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(120, "frm_ReceiptPayment", 2), frm_Alert.WTYPE.ERROR)
                Case 110
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(121, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 111
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(122, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 112
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(123, "frm_SetMenu", 2), frm_Alert.WTYPE.ERROR)
                Case 113
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(124, "frm_StockInHand", 2), frm_Alert.WTYPE.ERROR)
                Case 114
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(125, "frm_StockInHand", 2), frm_Alert.WTYPE.ERROR)
                Case 115
                    FunG_Alert(mvCls_LoadLanguage.FuncG_GetData(129, "Error", 2), mvCls_LoadLanguage.FuncG_GetData(126, "frm_Supplier", 2), frm_Alert.WTYPE.ERROR)

            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Module
