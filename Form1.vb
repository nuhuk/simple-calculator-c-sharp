Public Class Form1
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        Dim numValueOne As Integer = Integer.Parse(firstValueBox.Text)
        Dim numValueTwo As Integer = Integer.Parse(secondValueBox.Text)
        Dim finalValue As Integer
        Select Case operatorBox.SelectedItem
            Case "*"
                finalValue = numValueOne * numValueTwo
            Case "/"
                finalValue = numValueOne / numValueTwo
            Case "+"
                finalValue = numValueOne + numValueTwo
            Case "-"
                finalValue = numValueOne - numValueTwo
            Case Else
                MessageBox.Show("Kindly enter a vaild number")
        End Select
        resultDisplayBox.Text = finalValue.ToString()
    End Sub
End Class
