Public Class frmApp
    Dim US_Dollar As Double = 0.0098
    Dim Euro As Double = 0.0086
    Dim British_Pound As Double = 0.0077
    Dim Australian_Dollar As Double = 0.014
    Dim Canadian_Dollar As Double = 0.013

    Function CConverter(ByVal money As Double) As Double
        If cmbCurrency.Text = "USA" Then
            Return Math.Round(US_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "Britain" Then
            Return Math.Round(British_Pound * money, 2)
        ElseIf cmbCurrency.Text = "Australia" Then
            Return Math.Round(Australian_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "Canada" Then
            Return Math.Round(Canadian_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "Euro" Then
            Return Math.Round(Euro * money, 2)
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim Kenya_Shilling As Double = CDbl(txtAmount.Text)
        lblConvert.Text = CStr(CConverter(Kenya_Shilling))

        If cmbCurrency.Text = "USA" Then
            lblConvert.Text = "USD" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Britain" Then
            lblConvert.Text = "BR" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Australia" Then
            lblConvert.Text = "AUD" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Canada" Then
            lblConvert.Text = "CAN" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Euro" Then
            lblConvert.Text = "EU" & " " & Val(lblConvert.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmWelcome.Show()
        Me.Hide()
        lblConvert.Text = ""
        txtAmount.Text = ""
        cmbCurrency.Text = "Choose country"
    End Sub

    Private Sub frmApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCurrency.Text = "Choose country"
        cmbCurrency.Items.Add("USA")
        cmbCurrency.Items.Add("Britain")
        cmbCurrency.Items.Add("Canada")
        cmbCurrency.Items.Add("Australia")
        cmbCurrency.Items.Add("Euro")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblConvert.Text = ""
        txtAmount.Text = ""
        cmbCurrency.Text = "Choose country"
    End Sub

    Private Sub lblConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConvert.Click

    End Sub
End Class
