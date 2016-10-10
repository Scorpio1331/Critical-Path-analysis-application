Public Class FrmListForm

    Public WriteOnly Property Testing() As String
        Set(ByVal value As String)
            RowCount = value
        End Set
    End Property

    Private RowCount As Integer

    Private Sub FrmListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If RowCount > 23 Then
            Me.Size = MaximumSize
            DGVActivityList.Size = DGVActivityList.MaximumSize
        Else
            Me.Width = Me.MinimumSize.Width
            DGVActivityList.Height = 44 + ((RowCount - 1) * 27)
            Me.Height = 44 + ((RowCount - 1) * 27)
        End If

        DGVActivityList.Rows.Add(RowCount - 1)

        For x = 0 To RowCount - 1
            If RowCount - 1 < 26 Then
                DGVActivityList.Item(0, x).Value = Chr(65 + x)
            Else
                Select Case x
                    Case 26 To 51
                        DGVActivityList.Item(0, x).Value = Chr(65 + (x - 26)) & "2"
                    Case 52 To 77
                        DGVActivityList.Item(0, x).Value = Chr(65 + (x - 52)) & "3"
                    Case Is > 76
                        DGVActivityList.Item(0, x).Value = Chr(65 + (x - 78)) & "4"
                    Case Else
                        DGVActivityList.Item(0, x).Value = Chr(65 + x)
                End Select

            End If

        Next

    End Sub

    Private Sub DGVActivityList_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVActivityList.CellEndEdit
        If e.ColumnIndex = 2 And Not IsNumeric(DGVActivityList.Item(2, e.RowIndex).Value) Then
            DGVActivityList.Item(2, e.RowIndex).Value = 0
        ElseIf e.ColumnIndex = 3 And Len(DGVActivityList.Item(3, e.RowIndex).Value.ToString) > 2 Then
            DGVActivityList.Item(3, e.RowIndex).Value = "--"
        End If
    End Sub



End Class
