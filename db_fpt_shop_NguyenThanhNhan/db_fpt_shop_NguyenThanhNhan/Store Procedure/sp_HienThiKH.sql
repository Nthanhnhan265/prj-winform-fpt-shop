CREATE PROCEDURE sp_HienThiKhachHang
AS
BEGIN
    SELECT MaKH, HoTenKH, CCCD, SDT, DiaChi, Email
    FROM KhachHang;
END
