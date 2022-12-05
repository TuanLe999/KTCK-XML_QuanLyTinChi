Public Class LopHocPhan
    Private _dbAccess As New DataBaseAccess
    Public msv As String
    Public ten As String
    Private Sub LopHocPhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check()
    End Sub

    Public Sub back()
        Dim tkb = New ThoiKhoaBieu
        tkb.msv_label.Text = msv
        tkb.tenSV_label.Text = ten
        Me.Dispose()
        tkb.ShowDialog()
    End Sub

    Public Sub loadDataOnGridView()
        Dim sqlQuery As String = String.Format("SELECT * FROM dbo.LopHP WHERE MaHP NOT IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" & msv & "') ORDER BY Thu ")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.HP_dgv.DataSource = dTable
        With Me.HP_dgv
            .Columns(0).HeaderText = "Mã học phần"
            .Columns(1).HeaderText = "Tên học phần"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Giáo viên"
            .Columns(2).Width = 150
            .Columns(3).HeaderText = "Số tín chỉ"
            .Columns(4).HeaderText = "Thứ"
            .Columns(4).Width = 30
            .Columns(5).HeaderText = "Tiết bắt đầu"
            .Columns(6).HeaderText = "Tiết kết thúc"

        End With

    End Sub

    Private Sub check()
        Dim sql As String = " SELECT COUNT(DISTINCT MaHP) FROM dbo.LopHP WHERE MaHP NOT IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" & msv & "')"
        Dim a As Integer = _dbAccess.GetScalar(sql).ToString
        If (a = 0) Then
            MsgBox("Không còn học phần nào để đăng ký! ")
            back()
        End If
    End Sub

    Private Sub dangKy_btn_Click(sender As Object, e As EventArgs) Handles dangKy_btn.Click
        If MsgBox("Bạn có muốn đăng ký học phần này không !", vbYesNo, "Xác nhận") = 6 Then
            dangKy()
        End If
        back()
    End Sub
    Private Sub dangKy()

        'Khai bao bien lay StudentID ma dong can xoa da duoc chon tren gridview
        Dim MaHP As String = Me.HP_dgv.Rows(Me.HP_dgv.CurrentCell.RowIndex).Cells("MaHP").Value
        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("Insert into ThoiKhoaBieu values ('" & msv & "','" & MaHP & "') ")
        'Thuc hien xoa
        If _dbAccess.ExecuteNoneQuery(sqlQuery) Then '
            MessageBox.Show("Đăng ký  thành công!”)
            'Load lai du lieu tren Gridview
            loadDataOnGridView()
        Else
            MessageBox.Show("Đăng ký thất bại!")
        End If
    End Sub

    Private Sub quayLai_btn_Click(sender As Object, e As EventArgs) Handles quayLai_btn.Click
        back()
    End Sub
End Class