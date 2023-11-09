CREATE PROCEDURE sp_SuaDanhMuc
    @MaDM CHAR(10),
    @TenDM NVARCHAR(50),
    @ThuocTinhDanhMuc TEXT
AS
BEGIN
    UPDATE DanhMuc
    SET TenDM = @TenDM, ThuocTinhDanhMuc = @ThuocTinhDanhMuc
    WHERE MaDM = @MaDM;
END
