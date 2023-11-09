CREATE PROCEDURE sp_HienThiDanhMuc
AS
BEGIN
    SELECT MaDM, TenDM, ThuocTinhDanhMuc
    FROM DanhMuc;
END
