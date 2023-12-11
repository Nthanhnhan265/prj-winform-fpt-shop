use QuanLyCuaHang
GO
--Tim kiếm sản phẩm
Create procedure sp_TimKiemSanPhamTheoMa
	@ChuoiCanTim char(10)
AS 
	SELECT * FROM SanPham Where MaSP=@ChuoiCanTim 
Go 
create procedure sp_TimKiemSanPhamTheoTen 
	@ChuoiCanTim nvarchar(50)
AS 
	SELECT * FROM SanPham WHERE TenSP LIKE '%'+@ChuoiCanTim+'%'

Go 
	
Go 
Create procedure sp_TimKiemSanPhamTheoThongTin
	@ChuoiCanTim nvarchar(max) 
AS 
	SELECT * FROM SanPham WHERE ThongTinSP LIKE '%'+@ChuoiCanTim+'%'
	
GO 
-- STORE CHI TIET HOA DON
-- Hien thi chi tiet hoa don
CREATE PROCEDURE sp_HienThiChiTietHD
AS
BEGIN
    SELECT MaChiTiet, MaHD, MaSP, SoLuong
    FROM ChiTietHD;
END

GO

-- Them chi tiet hoa don
CREATE PROCEDURE sp_ThemChiTietHD
    @MaChiTiet CHAR(10),
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHD (MaChiTiet, MaHD, MaSP, SoLuong)
    VALUES (@MaChiTiet, @MaHD, @MaSP, @SoLuong);
END

GO

-- Xoa chi tiet hoa don
CREATE PROCEDURE sp_XoaChiTietHD
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM ChiTietHD
    WHERE MaChiTiet = @MaCanXoa;
END

GO

-- Sua chi tiet hoa don
CREATE PROCEDURE sp_SuaChiTietHD
    @MaChiTiet CHAR(10),
    @MaHD CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT
AS
BEGIN
    UPDATE ChiTietHD
    SET MaHD = @MaHD, MaSP = @MaSP, SoLuong = @SoLuong
    WHERE MaChiTiet = @MaChiTiet;
END

GO

-- STORE CUA HANG
Create procedure sp_TimCuaHangQuaMaCH
@chuoiCanTim char(10)
as 
	select * from CuaHang where MaCH=@chuoiCanTim
Go 
-- Hien thi cua hang
CREATE PROCEDURE sp_HienThiCuaHang
AS 
BEGIN 
	select * from CuaHang 
END
GO 
-- Hien thi cua hang và quan ly
CREATE PROCEDURE sp_HienThiCuaHangJoinQuanLy
AS 
BEGIN 
	select * from CuaHang 
	left join NhanVien 
	on CuaHang.QuanLy=NhanVien.MaNV 

END
GO

-- Them cua hang
CREATE PROCEDURE sp_ThemCuaHang
    @MaCH CHAR(10),
    @TenCH NVARCHAR(50),
    @DiaChi NVARCHAR(255),
    @SoDienThoai CHAR(10),
    @QuanLy CHAR(10),
    @NgayKhaiTruong DATETIME
AS
BEGIN
    INSERT INTO CuaHang (MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
    VALUES (@MaCH, @TenCH, @DiaChi, @SoDienThoai, @QuanLy, @NgayKhaiTruong);
END

GO

-- Xoa cua hang
CREATE PROCEDURE sp_XoaCuaHang
@MaCanXoa char(10)
AS
BEGIN 
	DELETE FROM CuaHang WHERE MaCH =@MaCanXoa 
END 

GO

-- Sua cua hang
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

GO

-- STORE DANH MUC

-- Hien thi danh muc
CREATE PROCEDURE sp_HienThiDanhMuc
AS
BEGIN
    SELECT MaDM, TenDM, ThuocTinhDanhMuc
    FROM DanhMuc;
END

GO

-- Them danh muc
CREATE PROCEDURE sp_ThemDanhMuc
    @MaDM CHAR(10),
    @TenDM NVARCHAR(50),
    @ThuocTinhDanhMuc  nvarchar(MAX)
AS
BEGIN
    INSERT INTO DanhMuc (MaDM, TenDM, ThuocTinhDanhMuc)
    VALUES (@MaDM, @TenDM, @ThuocTinhDanhMuc);
END

GO

-- Xoa danh muc
CREATE PROCEDURE sp_XoaDanhMuc
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM DanhMuc
    WHERE MaDM = @MaCanXoa;
END

GO

-- Sua danh muc
CREATE PROCEDURE sp_SuaDanhMuc
    @MaDM CHAR(10),
    @TenDM NVARCHAR(50),
    @ThuocTinhDanhMuc nvarchar(MAX)
AS
BEGIN
    UPDATE DanhMuc
    SET TenDM = @TenDM, ThuocTinhDanhMuc = @ThuocTinhDanhMuc
    WHERE MaDM = @MaDM;
END

GO

-- STORE HOA DON
-- Hien thi hoa don
CREATE PROCEDURE sp_HienThiHoaDon
AS
BEGIN
    SELECT MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT
    FROM HoaDon;
END

GO

-- Them hoa don
CREATE PROCEDURE sp_ThemHoaDon
    @MaHD CHAR(10),
    @MaKH CHAR(10),
    @MaNV CHAR(10),
    @NgayTao DATETIME,
    @MaCH CHAR(10),
    @PTThanhToan NVARCHAR(50),
    @SoTienTT INT
AS
BEGIN
    INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
    VALUES (@MaHD, @MaKH, @MaNV, @NgayTao, @MaCH, @PTThanhToan, @SoTienTT);
END

GO

-- Xoa hoa don
CREATE PROCEDURE sp_XoaHoaDon
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM HoaDon
    WHERE MaHD = @MaCanXoa;
END

GO

-- Sua hoa don
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

GO

-- STORE KHACH HANG
-- Hien thi khach hang
CREATE PROCEDURE sp_HienThiKhachHang
AS
BEGIN
    SELECT MaKH, HoTenKH, CCCD, SDT, DiaChi, Email
    FROM KhachHang;
END

GO

-- Them khach hang
CREATE PROCEDURE sp_ThemKhachHang
    @MaKH CHAR(10),
    @HoTenKH NVARCHAR(50),
    @CCCD CHAR(10),
    @SDT CHAR(10),
    @DiaChi NVARCHAR(255),
    @Email NVARCHAR(50)
AS
BEGIN
    INSERT INTO KhachHang (MaKH, HoTenKH, CCCD, SDT, DiaChi, Email)
    VALUES (@MaKH, @HoTenKH, @CCCD, @SDT, @DiaChi, @Email);
END

GO

-- Xoa khach hang
CREATE PROCEDURE sp_XoaKhachHang
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM KhachHang
    WHERE MaKH = @MaCanXoa;
END

GO

-- Sua khach hang
CREATE PROCEDURE sp_SuaKhachHang
    @MaKH CHAR(10),
    @HoTenKH NVARCHAR(50),
    @CCCD CHAR(10),
    @SDT CHAR(10),
    @DiaChi NVARCHAR(255),
    @Email NVARCHAR(50)
AS
BEGIN
    UPDATE KhachHang
    SET HoTenKH = @HoTenKH, CCCD = @CCCD, SDT = @SDT, DiaChi = @DiaChi, Email = @Email
    WHERE MaKH = @MaKH;
END

GO

-- Tra cuu khach hang theo ma
CREATE PROCEDURE sp_TraCuuKhachHangTheoMa
@MaKH char(10)
AS
BEGIN
	SELECT * FROM KhachHang
	WHERE MaKH = @MaKH;
END

GO

-- Tra cuu khach hang theo ten
CREATE PROCEDURE sp_TraCuuKhachHangTheoTen
@HoTenKH NVARCHAR(50)
AS
BEGIN
	SELECT * FROM KhachHang
	WHERE HoTenKH LIKE @HoTenKH;
END

GO

-- STORE NHA SAN XUAT
-- Hien thi nha san xuat
CREATE PROCEDURE sp_HienThiNhaSX
AS
BEGIN
    SELECT MaNSX, TenNSX
    FROM NhaSX;
END

GO

-- Them nha san xuat
CREATE PROCEDURE sp_ThemNhaSX
    @MaNSX CHAR(10),
    @TenNSX NVARCHAR(50)
AS
BEGIN
    INSERT INTO NhaSX (MaNSX, TenNSX)
    VALUES (@MaNSX, @TenNSX);
END

GO

-- Xoa nha san xuat
CREATE PROCEDURE sp_XoaNhaSX
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM NhaSX
    WHERE MaNSX = @MaCanXoa;
END

GO

-- Sua nha san xuat
CREATE PROCEDURE sp_SuaNhaSX
    @MaNSX CHAR(10),
    @TenNSX NVARCHAR(50)
AS
BEGIN
    UPDATE NhaSX
    SET TenNSX = @TenNSX
    WHERE MaNSX = @MaNSX;
END

GO

-- STORE SAN PHAM
--Hiển thị sản phẩm cùng khóa ngoại 
go 
Create proc sp_HienThiThongTinSanPham 
as  
	select 
	SanPham.MaSP,SanPham.TenSP,ThongTinSP,DanhMuc.TenDM,NhaSX.TenNSX
	,SanPham.GiaBan,SanPham.Image
	from SanPham, NhaSX, DanhMuc
	Where SanPham.MaNSX=NhaSX.MaNSX And SanPham.MaDM=DanhMuc.MaDM



Go 
-- Hien thi san pham
CREATE PROCEDURE sp_HienThiSanPham 
AS 
BEGIN 
	select * from SanPham
END
GO

-- Them san pham
CREATE PROCEDURE sp_ThemSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(50),
    @ThongTinSP nvarchar(MAX),
    @MaDM CHAR(10),
    @MaNSX CHAR(10),
    @GiaBan INT,
    @Image NVARCHAR(50)
AS
BEGIN
    INSERT INTO SanPham (MaSP, TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
    VALUES (@MaSP, @TenSP, @ThongTinSP, @MaDM, @MaNSX, @GiaBan, @Image);
END

GO

-- Xoa san pham
CREATE PROCEDURE sp_XoaSanPham
    @MaCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM SanPham
    WHERE MaSP = @MaCanXoa;
END

GO

-- Sua san pham
CREATE PROCEDURE sp_SuaSanPham
    @MaSP CHAR(10),
    @TenSP NVARCHAR(50),
    @ThongTinSP nvarchar(MAX),
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

GO

-- STORE TON KHO
-- Hien thi ton kho
CREATE PROCEDURE sp_HienThiTonKho 
AS 
BEGIN 
	Select * from TonKho 
END

GO
--Hien thi ton kho có các thông tin của khóa ngoại 
Create procedure sp_CuaHangJoinSanPham 
AS 
SELECT 
 
   SanPhamTonKho.MaCH, CuaHang.TenCH, CuaHang.DiaChi,SanPhamTonKho.MaSP,SanPhamTonKho.TenSP,SanPhamTonKho.SoLuong
FROM 
    CuaHang 
JOIN (
    SELECT 
        TonKho.MaCH,
        SanPham.MaSP,
		SanPham.TenSP,
		TonKho.SoLuong
    FROM 
        TonKho 
    JOIN 
        SanPham ON TonKho.MaSP = SanPham.MaSP
) AS SanPhamTonKho ON CuaHang.MaCH = SanPhamTonKho.MaCH;

 
Go 
-- Them ton kho
CREATE PROCEDURE sp_ThemTonKho
    @MaCH CHAR(10),
    @MaSP CHAR(10),
	@MaSP_Cu char(10), 
	@MaCH_Cu char(10),
    @SoLuong INT
AS
BEGIN
    INSERT INTO TonKho (MaCH, MaSP, SoLuong)
    VALUES (@MaCH, @MaSP, @SoLuong);
END

GO

-- Xoa ton kho
CREATE PROCEDURE sp_XoaTonKho
    @MaCHCanXoa CHAR(10),
    @MaSPCanXoa CHAR(10)
AS
BEGIN
    DELETE FROM TonKho
    WHERE MaCH = @MaCHCanXoa AND MaSP = @MaSPCanXoa;
END

GO

-- Sua ton kho
CREATE PROCEDURE sp_SuaTonKho
    @MaCH CHAR(10),
    @MaSP CHAR(10),
    @SoLuong INT, 
	@MaCH_Cu CHAR(10),
	@MaSP_Cu Char(10)
AS
BEGIN
    UPDATE TonKho
    SET 
		MaCH=@MaCH,
		MaSP=@MaSP, 
		SoLuong = @SoLuong
    WHERE MaCH = @MaCH_Cu AND MaSP = @MaSP_Cu
END