CREATE PROCEDURE sp_HienThiHoaDon
AS
BEGIN
    SELECT MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT
    FROM HoaDon;
END
