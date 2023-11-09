CREATE PROCEDURE sp_ThemChiTietHD
    @MaChiTiet CHAR(10),
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHD (MaChiTiet, MaHD, MaSP, SoLuong)
    VALUES (@MaChiTiet, @MaHD, @MaSP, @SoLuong);
END
