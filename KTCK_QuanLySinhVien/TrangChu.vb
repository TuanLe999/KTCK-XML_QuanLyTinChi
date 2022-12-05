Public Class TrangChu

    Private _dbAccess As New DataBaseAccess
    Private _isLoading As Boolean = False
    Public Sub loadData()
        loadDataOnGridView()
        loadDataOnCombobox()
    End Sub

    Public Sub loadDataOnCombobox()
        Dim sql As String = "Select * from dbo.Lop"
        Dim dTable As DataTable = _dbAccess.GetDataTable(sql)
        Me.Class_cbb.DataSource = dTable
        Me.Class_cbb.ValueMember = "TenLop"
        Me.Class_cbb.DisplayMember = "TenLop"
    End Sub

    Private Sub loadDataOnGridView(tenLop As String)
        Dim sqlQuery As String = String.Format("Select * from SinhVien where Lop = '" & tenLop & "'")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.dgvStudents.DataSource = dTable
        With Me.dgvStudents
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Số điện thoại"
            .Columns(5).HeaderText = "Email"
            .Columns(5).Width = 200
        End With
    End Sub
    Public Sub loadDataOnGridView()
        Dim sqlQuery As String = String.Format("Select * from SinhVien ")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.dgvStudents.DataSource = dTable
        With Me.dgvStudents
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Số điện thoại"
            .Columns(5).HeaderText = "Email"
            .Columns(5).Width = 200
        End With
    End Sub

    Private Sub TrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoading = True
        loadDataOnCombobox()
        loadDataOnGridView()
        Class_cbb.Text = ""
        txt_timKiem.Enabled = False
        _isLoading = False
    End Sub



    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        If MsgBox("Bạn có muốn xóa không !", vbYesNo, "Xác nhận") = 6 Then
            Xoa()

        End If
    End Sub
    Private Sub Xoa()

        'Khai bao bien lay StudentID ma dong can xoa da duoc chon tren gridview
        Dim MSV As String = Me.dgvStudents.Rows(Me.dgvStudents.CurrentCell.RowIndex).Cells("MSV").Value
        'Khai bao cau lenh Query de xoa
        Dim sqlQuery As String = String.Format("DELETE from SinhVien WHERE MSV='{0}'", MSV)
        'Thuc hien xoa
        If _dbAccess.ExecuteNoneQuery(sqlQuery) Then 'Xoa thanh cong thi thong bao
            MessageBox.Show("Xóa thành công!”)
            'Load lai du lieu tren Gridview
            loadDataOnGridView()
        Else
            MessageBox.Show("Xóa thất bại!")
        End If
    End Sub

    Private Sub them_btn_Click(sender As Object, e As EventArgs) Handles them_btn.Click
        Them.ShowDialog()


    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim editForm As New Sua
        editForm.msv_txt.Text = Me.dgvStudents.Rows(Me.dgvStudents.CurrentCell.RowIndex).Cells("MSV").Value
        With Me.dgvStudents
            editForm.name_TextBox.Text = .Rows(.CurrentCell.RowIndex).Cells("MSV").Value
            editForm.name_TextBox.Text = .Rows(.CurrentCell.RowIndex).Cells("Ten").Value
            editForm.class_cbb.Text = .Rows(.CurrentCell.RowIndex).Cells("Lop").Value
            editForm.GenderComboBox.Text = .Rows(.CurrentCell.RowIndex).Cells("GioiTinh").Value
            editForm.phone_TextBox.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
            editForm.email_TextBox.Text = .Rows(.CurrentCell.RowIndex).Cells("Email").Value
        End With
        editForm.ShowDialog()
    End Sub



    Private Sub Class_cbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Class_cbb.SelectedIndexChanged
        If Not _isLoading Then
            If txt_timKiem.Text = "" Then
                loadDataOnGridView(Me.Class_cbb.SelectedValue)
            Else
                timKiem(Me.cbb_timKiem.Text, txt_timKiem.Text, Class_cbb.Text)
            End If

        End If
    End Sub

    Private Sub lamMoi_btn_Click(sender As Object, e As EventArgs) Handles lamMoi_btn.Click
        _isLoading = True
        loadDataOnCombobox()
        loadDataOnGridView()
        Class_cbb.Text = ""
        txt_timKiem.Text = ""
        cbb_timKiem.Text = ""
        txt_timKiem.Enabled = False
        _isLoading = False
    End Sub

    Private Sub txt_timKiem_TextChanged(sender As Object, e As EventArgs) Handles txt_timKiem.TextChanged
        If Class_cbb.Text = "" Then
            timKiem(Me.cbb_timKiem.Text, txt_timKiem.Text)
        Else
            timKiem(Me.cbb_timKiem.Text, txt_timKiem.Text, Class_cbb.Text)
        End If
    End Sub

    Private Sub timKiem(column As String, value As String)
        Dim sqlQuery As String = String.Format("Select * from SinhVien where " & column & " like N'%" & value & "%'")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.dgvStudents.DataSource = dTable
        With Me.dgvStudents
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Số điện thoại"
            .Columns(5).HeaderText = "Email"
            .Columns(5).Width = 200
        End With
    End Sub

    Private Sub timKiem(column As String, value As String, lop As String)
        Dim sqlQuery As String = String.Format("Select * from SinhVien where " & column & " like N'%" & value & "%' and Lop = '" & lop & "'")
        Dim dTable As DataTable = _dbAccess.GetDataTable(sqlQuery)
        Me.dgvStudents.DataSource = dTable
        With Me.dgvStudents
            .Columns(0).HeaderText = "Mã sinh viên"
            .Columns(1).HeaderText = "Tên"
            .Columns(1).Width = 200
            .Columns(2).HeaderText = "Lớp"
            .Columns(3).HeaderText = "Giới tính"
            .Columns(4).HeaderText = "Số điện thoại"
            .Columns(5).HeaderText = "Email"
            .Columns(5).Width = 200
        End With
    End Sub

    Private Sub cbb_timKiem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timKiem.SelectedIndexChanged
        txt_timKiem.Enabled = True
    End Sub

    Private Sub tkb_btn_Click(sender As Object, e As EventArgs) Handles tkb_btn.Click
        Dim tkbForm As New ThoiKhoaBieu
        tkbForm.msv_label.Text = Me.dgvStudents.Rows(Me.dgvStudents.CurrentCell.RowIndex).Cells("MSV").Value
        tkbForm.tenSV_label.Text = Me.dgvStudents.Rows(Me.dgvStudents.CurrentCell.RowIndex).Cells("Ten").Value
        tkbForm.ShowDialog()
    End Sub
End Class