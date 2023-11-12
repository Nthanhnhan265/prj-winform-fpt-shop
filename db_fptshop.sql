use master
drop database QuanLyCuaHang
-- Tạo Database QuanLy
create database QuanLyCuaHang
go
use QuanLyCuaHang
-- Tạo Nhân Viên
create table NhanVien(
MaNV char(10) not null,
HoTen nvarchar(50) not null,
NgaySinh date,
DiaChi nvarchar(255) not null,
GioiTinh NVARCHAR(5) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
CCCD char(10) not null,
SDT char(10) not null,
Email nvarchar(50) not null,
MaCH char(10),
QuanLy char(10),
MatKhau char(10) not null,
QuyenHan nvarchar(50) CHECK (QuyenHan IN(N'quản lý',N'nhân viên')),
primary key(MaNV))

-- Tạo Nhà Sản Xuất
create table NhaSX(
MaNSX char(10) not null,
TenNSX nvarchar(50) not null ,
primary key(MaNSX))

-- Tạo Sản Phẩm
create table SanPham(
MaSP char(10) not null,
TenSP nvarchar(50) not null,
ThongTinSP Text,
MaDM char(10),
MaNSX char(10),
GiaBan int,
Image nvarchar(50),
primary key(MaSP))

-- Tạo Chi Tiết Hóa Đơn
create table ChiTietHD(
MaChiTiet char(10) not null,
MaHD char(10),
MaSP char(10),
SoLuong int,
primary key(MaChiTiet))

-- Tạo Danh Mục
create table DanhMuc(
MaDM char(10) not null,
TenDM nvarchar(50),
ThuocTinhDanhMuc Text,
primary key(MaDM))

-- Tạo Cửa Hàng
create table CuaHang(
MaCH char(10) not null,
TenCH nvarchar(50),
DiaChi nvarchar(255) not null,
SoDienThoai char(10) not null,
QuanLy char(10) not null,
NgayKhaiTruong datetime,
primary key(MaCH))

-- Tạo Hóa Đơn
create table HoaDon(
	MaHD CHAR(10) NOT NULL,
    MaKH CHAR(10) NOT NULL,
    MaNV CHAR(10) NOT NULL,
    NgayTao DATETIME NOT NULL,
    MaCH CHAR(10) NOT NULL,
    PTThanhToan NVARCHAR(50) NOT NULL,
    SoTienTT INT NOT NULL,
primary key(MaHD))

-- Tạo Khách Hàng
CREATE TABLE KhachHang (
    MaKH CHAR(10) NOT NULL,
    HoTenKH NVARCHAR(50) NOT NULL,
    CCCD CHAR(10) NOT NULL,
    SDT CHAR(10) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    Email NVARCHAR(50),
    PRIMARY KEY (MaKH)
);

-- Tạo Tồn Kho
create table TonKho(
MaCH char(10) not null,
MaSP char(10) not null,
SoLuong int,
primary key(MaCH,MaSP))
go
--Tạo liên kết của hàng - nhân viên
alter table CuaHang 
add constraint NV_CH_QuanLy
foreign key(QuanLy)
references NhanVien(MaNV)

-- Tạo liên kết NhânViên - CửaHàng
alter table NhanVien
add constraint CH_NV_MaCH
foreign key(MaCH)
references CuaHang(MaCH)

-- Tạo liên kết HóaĐơn - CửaHàng
alter table HoaDon
add constraint CH_HD_MaCH
foreign key(MaCH)
references CuaHang(MaCH)

-- Tạo liên kết HóaĐơn - NhânViên
alter table HoaDon
add constraint NV_HD_MaNV
foreign key(MaNV)
references NhanVien(MaNV)

-- Tạo liên kết sampham - nhasx
alter table SanPham
add constraint MSX_SP_MaNSX
foreign key(MaNSX)
references NhaSX(MaNSX)

-- Tạo liên kết chitiethoadon - sanpham
alter table ChiTietHD
add constraint SP_CTHD_MaSP
foreign key(MaSP)
references SanPham(MaSP)

-- Tạo lên kết sanpham - danhmuc
alter table SanPham
add constraint DM_SP_MaDM
foreign key(MaDM)
references DanhMuc(MaDM)

-- Tạo liên kết chitiethoandon - hoadon
alter table ChiTietHD
add constraint HD_CTHD_MaHD
foreign key(MaHD)
references HoaDon(MaHD)

-- Tạo liên kết hoadon - khachhang
alter table HoaDon
add constraint KH_HD_MaKH
foreign key(MaKH)
references KhachHang(MaKH)

-- Tạo liên kết tonkho - sanpham
alter table TonKho
add constraint SP_TK_MaSP
foreign key(MaSP)
references SanPham(MaSP)

-- Tạo liên kết tonkho - cuahang
alter table TonKho
add constraint CH_TK_MaCH
foreign key(MaCH)
references CuaHang(MaCH)

-- Thêm ràng buộc NOT NULL cho trường GioiTinh trong bảng NhanVien
ALTER TABLE NhanVien
ALTER COLUMN GioiTinh NVARCHAR(50) NOT NULL;

-- Thêm ràng buộc CHECK cho trường GioiTinh trong bảng NhanVien
ALTER TABLE NhanVien
ADD CONSTRAINT CK_GioiTinh
CHECK (GioiTinh IN ('Nam', 'Nữ'));

--ràng buộc CHECK cho phương thức thanh toán 
ALTER TABLE HoaDon
ADD CONSTRAINT CK_PPThanhToan
CHECK (PTThanhToan IN ('Tiền mặt','Chuyển khoản'))

-- Thêm ràng buộc CHECK cho trường SDT trong bảng NhanVien
ALTER TABLE NhanVien
ADD CONSTRAINT CK_SDT_NV
CHECK (LEN(SDT) = 10);

-- Thêm ràng buộc CHECK cho trường SDT trong bảng KhachHang
ALTER TABLE KhachHang
ADD CONSTRAINT CK_SDT_KH
CHECK (LEN(SDT) = 10);

-- Thêm ràng buộc CHECK cho trường SDT trong bảng CuaHang
ALTER TABLE CuaHang
ADD CONSTRAINT CK_SDT_CH
CHECK (LEN(SoDienThoai) = 10);

-- Thêm ràng buộc CHECK cho trường CCCD trong bảng NhanVien
ALTER TABLE NhanVien
ADD CONSTRAINT CK_CCCD_NV
CHECK (LEN(CCCD) = 10);

-- Thêm ràng buộc CHECK cho trường CCCD trong bảng KhachHang
ALTER TABLE KhachHang
ADD CONSTRAINT CK_CCCD_KH
CHECK (LEN(CCCD) = 10);
