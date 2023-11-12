CREATE PROCEDURE sp_ThemDanhMuc
    @MaDM CHAR(10),
    @TenDM NVARCHAR(50),
    @ThuocTinhDanhMuc TEXT
AS
BEGIN
    INSERT INTO DanhMuc (MaDM, TenDM, ThuocTinhDanhMuc)
    VALUES (@MaDM, @TenDM, @ThuocTinhDanhMuc);
END
