--DROP DATABASE QuanLySinhVien_TLTTQ
GO 
CREATE DATABASE QuanLySinhVien_TLTTQ
GO
USE QuanLySinhVien_TLTTQ
 CREATE TABLE Lop(
	TenLop VARCHAR(50) NOT NULL PRIMARY KEY
 
 )

 CREATE TABLE SinhVien(
	MSV VARCHAR(50) NOT NULL PRIMARY KEY,
	Ten NVARCHAR(50) NOT NULL,
    Lop VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Lop(TenLop)
	ON UPDATE CASCADE ON DELETE CASCADE,
	GioiTinh  NVARCHAR(50) NOT NULL,
	SDT NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL
 )

 CREATE TABLE LopHP(
	MaHP NVARCHAR(50) NOT NULL PRIMARY KEY,
	TenHP NVARCHAR(50) NOT NULL,
	GiaoVien NVARCHAR(50) NOT NULL,
	SoTC INT NOT NULL,
	Thu NVARCHAR(50) NOT NULL,
	TietBatDau NVARCHAR(50) NOT NULL,
	TietKetThuc NVARCHAR(50) NOT NULL

 )

 CREATE TABLE ThoiKhoaBieu(
	MSV VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES SinhVien(MSV) 
	ON UPDATE CASCADE ON DELETE CASCADE,
	MaHP NVARCHAR(50) NOT NULL FOREIGN KEY REFERENCES dbo.LopHP(MaHP)
	ON UPDATE CASCADE ON DELETE CASCADE,
 )

 INSERT INTO dbo.Lop
 (
     TenLop
 )
 VALUES
 (N'20T3'),
 (N'20T2'),
 (N'20T1'),
 (N'19T1')

 INSERT INTO dbo.SinhVien
 VALUES
 ('2050531200317',N'Trần Anh Tuấn', N'20T3', N'Nam', N'0918880604', N'2050531200317@sv.ute.udn.vn'),
 ('2050531200311',N'Lê Hoàng ', N'20T3', N'Nam', N'0917480604', N'20505312003211@sv.ute.udn.vn'),
 ('2050531200328',N'Hồng Ánh', N'20T1', N'Nữ', N'0839680604', N'2050531200328@sv.ute.udn.vn')

 INSERT INTO dbo.LopHP
 (
     MaHP,
     TenHP,
     GiaoVien,
	 SoTC,
     Thu,
     TietBatDau,
     TietKetThuc
 )
 VALUES
 (N'221GDTCI01', N'Giáo dục thể chất 1', N'Trần Lực',2, N'2', N'1', '2'),
 (N'221NNCNC01', N'Ngoại ngữ chuyên ngành CNTT', N'Võ Trung Hùng',3, N'5', N'9', '11'),
 (N'221HDH02', N'Hệ điều hành', N'Đoàn Duy Bình',3, N'6', N'10', '11'),
 (N'221LTC02', N'Lập trình C#', N'Đỗ Phú Huy',3, N'3', N'1', '2'),
 (N'221LTDT01', N'Lý thuyết đồ thị', N'Phan Huy Khánh',2, N'5', N'1', '2')

 INSERT INTO dbo.LopHP
 (
     MaHP,
     TenHP,
     GiaoVien,
	 SoTC,
     Thu,
     TietBatDau,
     TietKetThuc
 )
 VALUES
 (N'221TLTTQ01', N'Thực hành lập trình trực quan', N'Nguyễn Thị Thùy Trang',1, N'2', N'7', '8'),
 (N'221BTMTQ01', N'Bảo trì máy tính', N'Lê Vũ',3, N'3', N'7', '8'),
 (N'221CDPM01', N'Chuyên đề phần mềm', N'Phạm Tuấn',3, N'6', N'9', '11'),
 (N'221LJNC01', N'Lập trình Java nâng cao', N'Đỗ Phú Huy',3, N'6', N'1', '2'),
 (N'221TLJNC01', N'Thực hành lập trình Java nâng cao', N'Lê Nhật Thiện Quang',1, N'6', N'7', '8')

 INSERT INTO dbo.ThoiKhoaBieu
 (
     MSV,
     MaHP
 )
 VALUES
 ('2050531200317', N'221TLTTQ01'),
 ('2050531200317', N'221BTMTQ01'),
 ('2050531200317', N'221LJNC01'),
 ('2050531200317', N'221TLJNC01'),
 ('2050531200311', N'221TLTTQ01'),
 ('2050531200311', N'221BTMTQ01'),
 ('2050531200311', N'221CDPM01'),
 ('2050531200317', N'221TLJNC01')

 SELECT SUM(SoTC)  FROM dbo.LopHP
 WHERE MaHP IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV ='2050531200317' )


 SELECT * from SinhVien where MSV like N'%2050%' AND Lop ='19T1'

 SELECT COUNT(DISTINCT MaHP) FROM dbo.LopHP WHERE MaHP NOT IN (SELECT MaHP FROM dbo.ThoiKhoaBieu WHERE dbo.ThoiKhoaBieu.MSV = '2050531200311')

 DELETE FROM dbo.ThoiKhoaBieu WHERE 
 ( MSV='2050531200311' AND MaHP='221TLJNC01')