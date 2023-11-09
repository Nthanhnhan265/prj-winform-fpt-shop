CREATE PROCEDURE sp_HienThiChiTietHD
AS
BEGIN
    SELECT MaChiTiet, MaHD, MaSP, SoLuong
    FROM ChiTietHD;
END
