Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BtnClear.PerformClick()
        txtPoints.Focus()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Dim DecCost As Decimal
        Dim DecFinal As Decimal
        Dim cDecDiscont As Decimal = 5D
        Dim DecPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."
            MsgBox(intPoints & " total points being used")

            If RdoBtnGourmetCheese.Checked Then
                DecCost = 49.99D
                strOrder = "Cheese"
            ElseIf RBtnPinwheelWrap.Checked Then
                DecCost = 59.99D
                strOrder = "Pinwheel Wrap"
            ElseIf RBtnVeggie.Checked Then
                DecCost = 29.99D
                strOrder = "Veggie"
            ElseIf RBtnSausageAndCheese.Checked Then
                DecCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf RBtnFruit.Checked Then
                DecCost = 29.99D
                strOrder = "Fruit"
            End If
            If RBtnPrePay.Checked Then
                strPay = "Using Pre-Pay"
            ElseIf RBtnPayOnPickup.Checked Then
                strPay = "with Pay upon Pickup."
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)

            DecPoints = (intPoints * cDecDiscont) / 100
            If DecPoints >= 1 Then
                MsgBox("Thats some good savings!!! Its free!!!")
            ElseIf DecPoints < 1 Then
                MsgBox("Thats " & Convert.ToInt32(DecPoints * 100) & " percent off")
            End If

            If DecPoints > 1 Then
                DecPoints = 1
            End If

            DecFinal = DecCost * (1 - DecPoints)
            MsgBox(DecFinal & " is the final.")
            LblShow.Text = "Your order " & strOrder & " platter cost " & DecFinal.ToString("C") & vbCrLf & " " & strPay & strPoints
        Else
                MsgBox("Please enter a valid number of points.", , "Input Error")
        Me.BtnClear.PerformClick()

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtPoints.Text = ""
        txtPoints.Focus()
        LblShow.Text = " "
        RdoBtnGourmetCheese.Checked = True
        RBtnPinwheelWrap.Checked = False
        RBtnVeggie.Checked = False
        RBtnSausageAndCheese.Checked = False
        RBtnFruit.Checked = False
        RBtnPrePay.Checked = True
        RBtnPayOnPickup.Checked = False

    End Sub

    Private Sub RBtnPrePay_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnPrePay.CheckedChanged

    End Sub
End Class
