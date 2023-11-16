use QuanLyCuaHang 
Go 
--chèn vào bảng danh mục 
insert into DanhMuc(MaDM,TenDM,ThuocTinhDanhMuc) 
values('DM01',N'Điện thoại',null) 
Go 
-- Chèn dữ liệu vào bảng NhaSX
insert into NhaSX(MaNSX, TenNSX)
values('01', 'Apple')

insert into NhaSX(MaNSX, TenNSX)
values('02', 'Samsung')

insert into NhaSX(MaNSX, TenNSX)
values('03', 'Xiaomi')

insert into NhaSX(MaNSX, TenNSX)
values('04', 'Vivo')

insert into NhaSX(MaNSX, TenNSX)
values('05', 'Realme')

Go 
-- Chèn dữ liệu vào bảng SanPham
insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('014' ,'iPhone 14',N'Điện Thoại', 'DM01','01',27090000, 'iphone14.jpg')

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('015' ,'iPhone 15',N'Điện Thoại', 'DM01','01',34490000, 'iphone15.jpg')

-- Chèn dữ liệu vào bảng SanPham
insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('016' ,'Xiaomi Redmi 12',N'Điện Thoại', 'DM01','03', 3790000, 'xiaomi-redmi-12.jpg');

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('017' ,'Samsung Galaxy A14',N'Điện Thoại', 'DM01','02', 3690000, 'samsung-galaxy-a14.jpg');

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('018' ,'Xiaomi Redmi 10',N'Điện Thoại', 'DM01','03', 2990000, 'xiaomi-redmi-10.jpg');


insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('019' ,'Xiaomi Redmi 9','Điện Thoại', 'DM01','03', 2990000, 'xiaomi-redmi-10.jpg');
Go 
-- Chèn dữ liệu vào bảng KhachHang
insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('10', N'Lê Thị Xuân','0722040001','0137943792',N'TPHồ Chí Minh','Xuan10@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('11', N'Lê Văn Việt','0722040002','0137943793',N'TPHồ Chí Minh','Viet11@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('12', N'Nguyễn Anh Tú','0722040003','0268913684',N'TPHồ Chí Minh','Tu12@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('13', N'Thu Thắm','0722040004','0137943358',N'TPHồ Chí Minh','Tham13@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('14', N'Trần Anh Tuấn','0722040005','0567943792',N'TPHồ Chí Minh','Tuan14@gmail.com')
go 
-- Chèn dữ liệu vào bảng CuaHang
insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('1', 'FPTShop', N'C12 Bách Hóa Thanh Xuân Bắc' ,'0438544888',null,'11/10/2021')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('2', 'FPTShop', N'Quận 4' ,'0873026666',null,'01/11/2021')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('3', 'FPTShop', N'Quận 11' ,'0839756962',null,'10/11/2020')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('4', 'FPTShop', N'Quận 1' ,'0839144983',null,'12/02/2004')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('5', 'FPTShop', N'Quận 10' ,'0839798220',null,'02/01/2000')
Go 
-- Chèn dữ liệu vào bảng NhanVien

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('001', N'Nguyễn Văn An', '02/01/1999', N'TP Hồ Chí Minh', N'Nam', '0722040006','0852471474','An02@gmail.com', '1', null, 'An02011999',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('002', N'Nguyễn Thị Lan', '09/01/1998', N'TP Hồ Chí Minh', N'Nữ', '0722040007','0232714774','Lan09@gmail.com', '4', '001', 'Lan0901199',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('003', N'Võ Thanh Tuấn', '10/10/1997', N'TP Hồ Chí Minh', 'Nam', '0722040009','0852121374','Anh10@gmail.com', '2', '001', 'Tuan101997',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('004', N'Nguyễn Thị Anh Thư', '07/03/1999', N'TP Hồ Chí Minh', N'Nữ', '0722040010','0852434224','Thu07@gmail.com', '1', '001', 'Thu0703199',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy,MatKhau, QuyenHan)
values('005', N'Lê Thị Kim Anh', '11/10/1999', N'TP Hồ Chí Minh', N'Nữ', '0722040011','0852471234','Anh11@gmail.com', '3', '005', 'Anh011199',N'Nhân Viên')
go 
-- Chèn dữ liệu vào bảng HoaDon
insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('2345','10','001','11/01/2023','1',N'Chuyển Khoản', 27090000);

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('0507','11','004','10/05/2023','4',N'Tiền Mặt', 7580000);

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('1234','12','003','01/05/2023','2',N'Tiền Mặt', 2990000);

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('6789','13','001','01/06/2023','5',N'Tiền Mặt', 3690000);

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('3456','14','002','01/01/2023','2',N'Chuyển Khoản', 103470000);


Go 
-- Chèn dữ liệu vào bảng ChiTietHD
insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('1','2345' ,'014',1)

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('2','0507' ,'016',2)

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('3','1234' ,'018',1)

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('4','6789' ,'017',1)

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('5','3456' ,'015',3)


Go 

-- Chèn dữ liệu vào bảng TonKho
insert into TonKho(MaCH, MaSP,SoLuong)
values('1','014',12)

insert into TonKho(MaCH, MaSP,SoLuong)
values('5','015',10)

insert into TonKho(MaCH, MaSP,SoLuong)
values('4','016',5)

insert into TonKho(MaCH, MaSP,SoLuong)
values('2','017',18)

insert into TonKho(MaCH, MaSP,SoLuong)
values('3','015',2)

