CREATE PROCEDURE sp_XoaChiTietHD
    @MaChiTiet CHAR(10)
AS
BEGIN
    DELETE FROM ChiTietHD
    WHERE MaChiTiet = @MaChiTiet;
END
