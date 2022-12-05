Public Class Them

    Private _dbAccess As New DataBaseAccess
    Private Sub them_btn_Click(sender As Object, e As EventArgs) Handles them_btn.Click
        If name_TextBox.Text = "" Or class_cbb.Text = "" Or GenderComboBox.Text = "" Or
                phone_TextBox.Text = "" Or email_TextBox.Text = "" Then
            MsgBox("Vui lòng nhập đầy đủ thông tin!!!")
        Else
            Try

                Dim sql As String = "INSERT INTO [SinhVien] VALUES ('" & msv_txt.Text & "',N'" & name_TextBox.Text & "','" & class_cbb.Text & "',N'" & GenderComboBox.Text & "','" & phone_TextBox.Text & "','" & email_TextBox.Text & "')"
                Dim result As Boolean = _dbAccess.ExecuteNoneQuery(sql)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            MsgBox("Thêm thành công !")
            Me.Close()

        End If
    End Sub

    Private Sub Them_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataOnCombobox()
    End Sub
    Private Sub loadDataOnCombobox()
        Dim sql As String = "Select * from dbo.Lop"
        Dim dTable As DataTable = _dbAccess.GetDataTable(sql)
        Me.class_cbb.DataSource = dTable
        Me.class_cbb.ValueMember = "TenLop"
        Me.class_cbb.DisplayMember = "TenLop"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class