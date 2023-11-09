CREATE PROCEDURE sp_ThemCuaHang
    @MaCH CHAR(10),
    @TenCH NVARCHAR(50),
    @DiaChi NVARCHAR(255),
    @SoDienThoai CHAR(10),
    @QuanLy CHAR(10),
    @NgayKhaiTruong DATETIME
AS
BEGIN
    INSERT INTO CuaHang (MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
    VALUES (@MaCH, @TenCH, @DiaChi, @SoDienThoai, @QuanLy, @NgayKhaiTruong);
END




 