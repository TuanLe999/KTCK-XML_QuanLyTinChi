Public Class ThoiKhoaBieu
    Private _dbAccess As New DataBaseAccess
    Private Sub ThoiKhoaBieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataOnGridView()
    End Sub

    Private Sub loadDataOnGridView()
        Dim sqlQuery As String = String.Format("SELECT  MaHP, TenHP,GiaoVien,SoTC,Thu,TietBatDau,TietKetThuc  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" & msv_label.Text & "' ) ORDER BY Thu ")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.TKB_dgv.DataSource = dTable
        With Me.TKB_dgv
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
        Dim sql2 = "SELECT COUNT(DISTINCT MaHP)  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" & msv_label.Text & "' )"
        sl_label.Text = _dbAccess.GetScalar(sql2).ToString


        Dim sql3 = "SELECT SUM(SoTC)  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='" & msv_label.Text & "' )"
        Tc_label.Text = _dbAccess.GetScalar(sql3).ToString
    End Sub

    Private Sub dkHP_btn_Click(sender As Object, e As EventArgs) Handles dkHP_btn.Click
        Dim hpForm As New LopHocPhan
        hpForm.msv = Me.msv_label.Text
        hpForm.ten = Me.tenSV_label.Text
        hpForm.loadDataOnGridView()
        Me.Dispose()
        hpForm.ShowDialog()

    End Sub

    Private Sub quayLai_btn_Click(sender As Object, e As EventArgs) Handles quayLai_btn.Click
        Me.Close()

    End Sub

    Private Sub huyHP_btn_Click(sender As Object, e As EventArgs) Handles huyHP_btn.Click
        If checkSoLuong() = False Then
            MsgBox("Chưa đăng ký học phần nào !")
        ElseIf MsgBox("Bạn có muốn hủy học phần này không !", vbYesNo, "Xác nhận") = 6 Then
            huyHP()
        End If
    End Sub

    Private Function checkSoLuong() As Boolean
        Dim sql As String = "SELECT count(MaHP) FROM dbo.LopHP WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '" & msv_label.Text & "')"
        Dim a As Integer = _dbAccess.GetScalar(sql)
        If a = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub huyHP()
        Dim MaHP As String = Me.TKB_dgv.Rows(Me.TKB_dgv.CurrentCell.RowIndex).Cells("MaHP").Value
        Dim sql As String = " DELETE FROM dbo.ThoiKhoaBieu WHERE ( MSV='" & msv_label.Text & "' AND MaHP='" & MaHP & "')"
        If _dbAccess.ExecuteNoneQuery(sql) Then
            MessageBox.Show("Hủy học phần thành công!”)
            loadDataOnGridView()
        Else
            MessageBox.Show("Hủy học phần thất bại!")
        End If

    End Sub
End Class