
CREATE PROCEDURE sp_ThemNhanVien
    @MaNV CHAR(10),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(255),
    @GioiTinh NVARCHAR(5),
    @CCCD CHAR(10),
    @SDT CHAR(10),
    @Email NVARCHAR(50),
    @MaCH CHAR(10),
    @QuanLy CHAR(10),
    @MatKhau CHAR(10),
    @QuyenHan NVARCHAR(50)
	AS
BEGIN
    INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
    VALUES (@MaNV, @HoTen, @NgaySinh, @DiaChi, @GioiTinh, @CCCD, @SDT, @Email, @MaCH, @QuanLy, @MatKhau, @QuyenHan);
END
GO 
CREATE PROCEDURE sp_XoaNhanVIen 
	@MaNV char(10)
	AS
BEGIN
    DELETE FROM NhanVien WHERE MaNV = @MaNV;
END
GO 

CREATE PROCEDURE sp_CapNhatNhanVien 
     @MaNV CHAR(10),
     @HoTen NVARCHAR(50),
     @NgaySinh DATE,
     @DiaChi NVARCHAR(255),
     @GioiTinh NVARCHAR(5),
     @CCCD CHAR(10),
     @SDT CHAR(10),
     @Email NVARCHAR(50),
     @MaCH CHAR(10),
     @QuanLy CHAR(10),
     @MatKhau CHAR(10),
     @QuyenHan NVARCHAR(50)
AS
BEGIN
    UPDATE NhanVien
    SET HoTen = @HoTen, NgaySinh = @NgaySinh, DiaChi = @DiaChi, GioiTinh = @GioiTinh, CCCD = @CCCD, 
        SDT = @SDT, Email = @Email, MaCH = @MaCH, QuanLy = @QuanLy, MatKhau = @MatKhau, QuyenHan = @QuyenHan
    WHERE MaNV = @MaNV;
END
GO 
CREATE PROCEDURE sp_HienThiNhanVien 
AS 
BEGIN
    SELECT * FROM NhanVien;
END
Go 
