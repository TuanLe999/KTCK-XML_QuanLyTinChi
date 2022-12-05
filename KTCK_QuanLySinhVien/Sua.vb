Public Class Sua
    Private _dbAccess As New DataBaseAccess
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Luu_btn_Click(sender As Object, e As EventArgs) Handles Luu_btn.Click
        If MsgBox("Bạn có muốn lưu không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            sua()
            MsgBox("Lưu thành công! ")
            Me.Close()

        End If
    End Sub
    Private Function sua() As Boolean
        Dim sqlQuery As String = "update SinhVien set Ten = N'" + name_TextBox.Text + "',Lop = '" + class_cbb.Text + "',GioiTinh=N'" + GenderComboBox.Text + "',SDT='" + phone_TextBox.Text + "'
                    ,Email=N'" + email_TextBox.Text + "' where MSV = '" + msv_txt.Text + "'"
        Return _dbAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Sub class_cbb_MouseClick(sender As Object, e As MouseEventArgs) Handles class_cbb.MouseClick
        loadDataOnCombobox()
    End Sub
    Private Sub loadDataOnCombobox()
        Dim sql As String = "Select * from dbo.Lop"
        Dim dTable As DataTable = _dbAccess.GetDataTable(sql)
        Me.class_cbb.DataSource = dTable
        Me.class_cbb.ValueMember = "TenLop"
        Me.class_cbb.DisplayMember = "TenLop"
    End Sub
End Class