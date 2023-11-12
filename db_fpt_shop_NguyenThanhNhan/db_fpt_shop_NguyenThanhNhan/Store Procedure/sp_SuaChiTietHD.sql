CREATE PROCEDURE sp_SuaChiTietHD
    @MaChiTiet CHAR(10),
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    UPDATE ChiTietHD
    SET MaHD = @MaHD, MaSP = @MaSP, SoLuong = @SoLuong
    WHERE MaChiTiet = @MaChiTiet;
END
