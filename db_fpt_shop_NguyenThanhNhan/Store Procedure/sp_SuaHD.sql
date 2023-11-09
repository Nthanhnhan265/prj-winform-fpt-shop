CREATE PROCEDURE sp_SuaHoaDon
    @MaHD CHAR(10),
    @MaKH CHAR(10),
    @MaNV CHAR(10),
    @NgayTao DATETIME,
    @MaCH CHAR(10),
    @PTThanhToan NVARCHAR(50),
    @SoTienTT INT
AS
BEGIN
    UPDATE HoaDon
    SET MaKH = @MaKH, MaNV = @MaNV, NgayTao = @NgayTao, MaCH = @MaCH, PTThanhToan = @PTThanhToan, SoTienTT = @SoTienTT
    WHERE MaHD = @MaHD;
END
