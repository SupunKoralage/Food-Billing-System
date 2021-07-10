Public Class Form1

    Const bread = 50
    Const rice = 100
    Const hoppers = 10
    Const beans = 40
    Const sandwich = 40

    Dim items(9)
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iQuit As DialogResult

        iQuit = MessageBox.Show("Confirm if you want to quit", "Billing_System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iQuit = DialogResult.Yes Then
            Application.Exit()
        End If



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblBread.Click

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumBread.ValueChanged
        lblBread.Text = FormatCurrency(NumBread.Value * bread)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblIHoppers.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub NumericUpDown1_ValueChanged_1(sender As Object, e As EventArgs) Handles NumRice.ValueChanged
        lblRice.Text = FormatCurrency(NumRice.Value * rice)
    End Sub

    Private Sub NumHoppers_ValueChanged(sender As Object, e As EventArgs) Handles NumHoppers.ValueChanged
        lblHoppers.Text = FormatCurrency(NumHoppers.Value * hoppers)
    End Sub

    Private Sub NumBeans_ValueChanged(sender As Object, e As EventArgs) Handles NumBeans.ValueChanged
        lblBeans.Text = FormatCurrency(NumBeans.Value * beans)
    End Sub

    Private Sub NumSandwich_ValueChanged(sender As Object, e As EventArgs) Handles NumSandwich.ValueChanged
        lblSandwich.Text = FormatCurrency(NumSandwich.Value * sandwich)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        NumSandwich.Value = 0
        NumBread.Value = 0
        NumRice.Value = 0
        NumBeans.Value = 0
        NumHoppers.Value = 0

        lblBread.Text = "Rs0.00"
        lblRice.Text = "Rs0.00"
        lblBeans.Text = "Rs0.00"
        lblHoppers.Text = "Rs0.00"
        lblSandwich.Text = "Rs0.00"
        lblTotal.Text = "Rs0.00"
        lblNumItem.Text = 0
        rtReceipt.Clear()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        items(0) = NumBread.Value * bread
        items(1) = NumRice.Value * rice
        items(2) = NumHoppers.Value * hoppers
        items(3) = NumBeans.Value * beans
        items(4) = NumSandwich.Value * sandwich

        items(5) = items(0) + items(1) + items(2) + items(3) + items(4)
        lblTotal.Text = FormatCurrency(items(5))

        Dim q(9)

        q(0) = NumBread.Value
        q(1) = NumRice.Value
        q(2) = NumHoppers.Value
        q(3) = NumBeans.Value
        q(4) = NumSandwich.Value
        q(5) = q(0) + q(1) + q(2) + q(3) + q(4)

        lblNumItem.Text = q(5)
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        rtReceipt.Clear()
        rtReceipt.AppendText(Label9.Text & vbTab & Label11.Text & vbTab & Label10.Text & vbNewLine)

        rtReceipt.AppendText(lblIBread.Text & vbTab & vbTab & NumBread.Value & vbTab & vbTab & vbTab & lblBread.Text & vbNewLine & vbNewLine)
        rtReceipt.AppendText(lblIRice.Text & vbTab & vbTab & vbTab & NumRice.Value & vbTab & vbTab & vbTab & lblRice.Text & vbNewLine & vbNewLine)
        rtReceipt.AppendText(lblIHoppers.Text & vbTab & vbTab & NumHoppers.Value & vbTab & vbTab & vbTab & lblHoppers.Text & vbNewLine & vbNewLine)
        rtReceipt.AppendText(lblIBeans.Text & vbTab & vbTab & NumBeans.Value & vbTab & vbTab & vbTab & lblBeans.Text & vbNewLine & vbNewLine)
        rtReceipt.AppendText(lblISandwich.Text & vbTab & NumSandwich.Value & vbTab & vbTab & vbTab & lblSandwich.Text & vbNewLine & vbNewLine)

        rtReceipt.AppendText(lblCost.Text & vbTab & lblNumItem.Text & vbTab & vbTab & vbTab & lblTotal.Text & vbNewLine)
    End Sub
End Class
