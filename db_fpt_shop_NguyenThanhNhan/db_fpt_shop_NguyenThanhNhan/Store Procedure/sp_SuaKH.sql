CREATE PROCEDURE sp_SuaKhachHang
    @MaKH CHAR(10),
    @HoTenKH NVARCHAR(50),
    @CCCD CHAR(10),
    @SDT CHAR(10),
    @DiaChi NVARCHAR(255),
    @Email NVARCHAR(50)
AS
BEGIN
    UPDATE KhachHang
    SET HoTenKH = @HoTenKH, CCCD = @CCCD, SDT = @SDT, DiaChi = @DiaChi, Email = @Email
    WHERE MaKH = @MaKH;
END
