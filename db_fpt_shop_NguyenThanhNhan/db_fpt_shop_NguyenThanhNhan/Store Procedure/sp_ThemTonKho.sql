CREATE PROCEDURE sp_ThemTonKho
    @MaCH CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO TonKho (MaCH, MaSP, SoLuong)
    VALUES (@MaCH, @MaSP, @SoLuong);
END
