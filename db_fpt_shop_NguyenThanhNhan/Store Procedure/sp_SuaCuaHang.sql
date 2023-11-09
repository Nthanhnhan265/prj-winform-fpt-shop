CREATE PROCEDURE sp_SuaCuaHang 
@MaCh char(10), 
@TenCH nvarchar(50), 
@DiaChi nvarchar(255), 
@SoDienThoai char(10), 
@QuanLy char(10),
@NgayKhaiTruong datetime 
AS 
BEGIN 
	UPDATE CuaHang 
	SET TenCH=@TenCH, DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,QuanLy=@QuanLy, NgayKhaiTruong=@NgayKhaiTruong
	WHERE MaCH=@MaCh
END


