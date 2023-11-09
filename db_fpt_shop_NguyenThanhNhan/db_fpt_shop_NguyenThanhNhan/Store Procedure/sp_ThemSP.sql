CREATE PROCEDURE sp_ThemSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(50),
    @ThongTinSP TEXT,
    @MaDM CHAR(10),
    @MaNSX CHAR(10),
    @GiaBan INT,
    @Image NVARCHAR(50)
AS
BEGIN
    INSERT INTO SanPham (MaSP, TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
    VALUES (@MaSP, @TenSP, @ThongTinSP, @MaDM, @MaNSX, @GiaBan, @Image);
END
