use QuanLyCuaHang
--chèn nhân viên 
--chưa xử lý khóa ngoại giữa nhân viên và người quản lý 
insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('001', N'Nguyễn Văn An', '02/01/1999', N'TP Hồ Chí Minh', 'Nam', '025437537','0852471474','An02@gmail.com', '1', 'Anh', 'An02011999',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('002', N'Nguyễn Thị Lan', '09/01/1998', N'TP Hồ Chí Minh', N'Nữ', '02532244537','023271474','Lan09@gmail.com', '4', N'Lâm', 'Lan09011998',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('003', N'Võ Thanh Tuấn', '10/10/1997', N'TP Hồ Chí Minh', 'Nam', '024345437','0852121374','Anh10@gmail.com', '2', 'Anh', 'Tuan10101997',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy, MatKhau, QuyenHan)
values('004', N'Nguyễn Thị Anh Thư', '07/03/1999', N'TP Hồ Chí Minh', N'Nữ', '025433437','0852434224','Thu07@gmail.com', '1', 'Anh', 'Thu07031999',N'Nhân Viên')

insert into NhanVien(MaNV, HoTen, NgaySinh, DiaChi, GioiTinh, CCCD, SDT, Email, MaCH, QuanLy,MatKhau, QuyenHan)
values('005', N'Lê Thị Kim Anh', '11/10/1999', N'TP Hồ Chí Minh', N'Nữ', '025437457','0852471234','Anh11@gmail.com', '3', N'Tú', 'Anh11101999',N'Nhân Viên')
--chèn bảng nhà sản xuất 
insert into NhaSX(MaNSX, TenNSX)
values('01', 'Apple')

insert into NhaSX(MaNSX, TenNSX)
values('02', 'samsung')

insert into NhaSX(MaNSX, TenNSX)
values('03', 'xiaomi')

insert into NhaSX(MaNSX, TenNSX)
values('04', 'vivo')

insert into NhaSX(MaNSX, TenNSX)
values('05', 'Realme')

--chèn bảng sản phẩm 
--trường ThongTinSP gồm nhiều thông tin chi tiết của mỗi sản phẩm 
insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('014' ,'iphone14',N'Điện Thoại', '10','01','27.090.000', ' iphone14.jpg')

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('015' ,'iphone15',N'Điện Thoại', '11','01','34.490.000', ' iphone15.jpg')

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('016' ,'xiaomi redmi 12',N'Điện Thoại', '12','03','3.790.000', 'xiaomi redmi 12.jpg')

insert into SanPham(MaSP,  TenSP,  ThongTinSP,MaDM, MaNSX, GiaBan, Image)
values('017' ,'samsung galaxy A14',N'Điện Thoại', '13','02','3.690.000', 'samsung galaxy A14.jpg')

insert into SanPham(MaSP,  TenSP, ThongTinSP, MaDM, MaNSX, GiaBan, Image)
values('018' ,'xiaomi redmi 10',N'Điện Thoại', '14','03','2.990.000', 'xiaomi redmi 10.jpg')

--chèn bảng cửa hàng 
--quản lý cửa hàng là khóa ngoại đến bảng nhân viên 
insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('1', 'FPTShop', N'C12 Bách Hóa Thanh Xuân Bắc' ,' 0438544888','Anh','11/10/')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('2', 'FPTShop', N'Quận 4' ,'0873026666','Anh','01/11/2021')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('3', 'FPTShop', N'Quận 11' ,' 0839756962',N'Tú','10/11/2020')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('4', 'FPTShop', N'Quận 1' ,'0839144983',N'Lâm','12/02/2004')

insert into CuaHang(MaCH, TenCH, DiaChi, SoDienThoai, QuanLy, NgayKhaiTruong)
values('5', 'FPTShop', N'Quận 10' ,'0839798220','Anh','02/01/2000')


--chèn bảng chi tiết hóa đơn 
insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('1','2345' ,'014','1')

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('2','0507' ,'016','2')

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('3','1234' ,'018','1')

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('4','6789' ,'017','1')

insert into ChiTietHD(MaChiTiet, MaHD, MaSP, SoLuong)
values('5','3456' ,'015','3')

--chèn bảng hóa đơn 
insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('2345','10','001','11/01/2023','1',N'Chuyển Khoản','27.090.000')

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('0507','11','004','10/05/2023','4',N'Tiền Mặt','7.580.000')

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('1234','12','003','01/05/2023','2',N'Tiền Mặt','2.990.000')

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('6789','13','001','01/06/2023','5',N'Tiền Mặt','3.690.000')

insert into HoaDon(MaHD, MaKH, MaNV, NgayTao, MaCH, PTThanhToan, SoTienTT)
values('3456','14','002','01/01/2023','2',N'Chuyển Khoản','103.470.000')

--chèn bảng khách hàng 
insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('10', N'Lê Thị Xuân','158380258','0137943792',N'TPHồ Chí Minh','Xuan10@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('11', N'Lê Văn Việt','138370258','014943792',N'TPHồ Chí Minh','Viet11@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('12', N'Nguyễn Anh Tú','152470258','0268913684',N'TPHồ Chí Minh','Tu12@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('13', N'Thu Thắm','582368958','0137943358',N'TPHồ Chí Minh','Tham13@gmail.com')

insert into KhachHang(MaKH, HoTenKH, CCCD,SDT, DiaChi, Email)
values('14', N'Trần Anh Tuấn','147980258','0567943792',N'TPHồ Chí Minh','Tuan14@gmail.com')

--chèn bảng tồn kho 
insert into TonKho(MaCH, MaSP,SoLuong)
values('1','014','12')

insert into TonKho(MaCH, MaSP,SoLuong)
values('5','015','10')

insert into TonKho(MaCH, MaSP,SoLuong)
values('4','016','5')

insert into TonKho(MaCH, MaSP,SoLuong)
values('2','017','18')

insert into TonKho(MaCH, MaSP,SoLuong)
values('3','015','2')

--chèn bảng danh mục 
--chưa có 