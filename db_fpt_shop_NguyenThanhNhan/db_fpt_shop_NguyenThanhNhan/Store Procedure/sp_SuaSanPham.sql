CREATE PROCEDURE sp_SuaSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(50),
    @ThongTinSP TEXT,
    @MaDM CHAR(10),
    @MaNSX CHAR(10),
    @GiaBan INT,
    @Image NVARCHAR(50)
AS
BEGIN
    UPDATE SanPham
    SET TenSP = @TenSP, ThongTinSP = @ThongTinSP, MaDM = @MaDM, MaNSX = @MaNSX, GiaBan = @GiaBan, Image = @Image
    WHERE MaSP = @MaSP;
END
