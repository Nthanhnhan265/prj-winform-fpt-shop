CREATE PROCEDURE sp_SuaTonKho
    @MaCH CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    UPDATE TonKho
    SET SoLuong = @SoLuong
    WHERE MaCH = @MaCH AND MaSP = @MaSP;
END