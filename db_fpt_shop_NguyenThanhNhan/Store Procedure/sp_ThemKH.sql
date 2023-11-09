CREATE PROCEDURE sp_ThemKhachHang
    @MaKH CHAR(10),
    @HoTenKH NVARCHAR(50),
    @CCCD CHAR(10),
    @SDT CHAR(10),
    @DiaChi NVARCHAR(255),
    @Email NVARCHAR(50)
AS
BEGIN
    INSERT INTO KhachHang (MaKH, HoTenKH, CCCD, SDT, DiaChi, Email)
    VALUES (@MaKH, @HoTenKH, @CCCD, @SDT, @DiaChi, @Email);
END
