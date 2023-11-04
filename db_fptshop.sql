-- Tạo Database QuanLy
create database QuanLyCuaHang

-- Tạo Nhân Viên
create table NhanVien(
MaNV char(10) not null,
HoTen nvarchar(50),
NgaySinh date,
DiaChi nvarchar(50),
GioiTinh nvarchar(50),
CCCD char(10),
SDT char(10),
Email nvarchar(50),
MaCH char(10),
QuanLy char(10),
MatKhau char(10),
QuyenHan nvarchar(50),
primary key(MaNV))

-- Tạo Nhà Sản Xuất
create table NhaSX(
MaNSX char(10) not null,
TenNSX nvarchar(50),
primary key(MaNSX))

-- Tạo Sản Phẩm
create table SanPham(
MaSP char(10) not null,
TenSP nvarchar(50),
ThongTinSP Text,
MaDM char(10),
MaNSX char(10),
GiaBan char(10),
Image nvarchar(50),
primary key(MaSP))

-- Tạo Chi Tiết Hóa Đơn
create table ChiTietHD(
MaChiTiet char(10) not null,
MaHD char(10),
MaSP char(10),
SoLuong char(10),
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
DiaChi nvarchar(50),
SoDienThoai char(10),
QuanLy nvarchar(50),
NgayKhaiTruong datetime,
primary key(MaCH))

-- Tạo Hóa Đơn
create table HoaDon(
MaHD char(10) not null,
MaKH char(10),
MaNV char(10),
NgayTao datetime,
MaCH char(10),
PTThanhToan nvarchar(50),
SoTienTT char(10),
primary key(MaHD))

-- Tạo Khách Hàng
create table KhachHang(
MaKH char(10) not null,
HoTenKH nvarchar(50),
CCCD char(10),
SDT char(10),
DiaChi nvarchar(50),
Email nvarchar(50),
primary key(MaKH))

-- Tạo Tồn Kho
create table TonKho(
MaCH char(10) not null,
MaSP char(10) not null,
SoLuong char(10),
primary key(MaCH,MaSP))

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

-- Tạo lên kết sanpham - doanhmuc
alter table SanPham
add constraint DM_SP_MaDM
foreign key(MaDM)
references DoanhMuc(MaDM)

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

