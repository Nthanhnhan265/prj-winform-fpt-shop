CREATE PROCEDURE sp_SuaNhaSX
    @MaNSX CHAR(10),
    @TenNSX NVARCHAR(50)
AS
BEGIN
    UPDATE NhaSX
    SET TenNSX = @TenNSX
    WHERE MaNSX = @MaNSX;
END