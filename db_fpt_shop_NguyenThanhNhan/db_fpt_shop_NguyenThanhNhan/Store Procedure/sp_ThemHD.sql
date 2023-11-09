CREATE PROCEDURE sp_ThemHoaDon
    @MaHD CHAR(10),
    @MaKH CHAR(10),
    @MaNV CHAR(10),
    @NgayTao DATETIME,
    @MaCH CHAR(10),
    @PTThanhToan NVARCHAR(50),
    @SoTienTT INT
AS
BEGIN
    INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
    VALUES (@MaHD, @MaKH, @MaNV, @NgayTao, @MaCH, @PTThanhToan, @SoTienTT);
END
