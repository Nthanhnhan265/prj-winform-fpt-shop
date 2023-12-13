USE [QuanLyCuaHang]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaChiTiet] [char](10) NOT NULL,
	[MaHD] [char](10) NULL,
	[MaSP] [char](10) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuaHang]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuaHang](
	[MaCH] [char](10) NOT NULL,
	[TenCH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SoDienThoai] [char](10) NOT NULL,
	[QuanLy] [char](10) NULL,
	[NgayKhaiTruong] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDM] [char](10) NOT NULL,
	[TenDM] [nvarchar](50) NULL,
	[ThuocTinhDanhMuc] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [char](10) NOT NULL,
	[MaKH] [char](10) NULL,
	[MaNV] [char](10) NULL,
	[NgayTao] [datetime] NOT NULL,
	[MaCH] [char](10) NULL,
	[PTThanhToan] [nvarchar](50) NOT NULL,
	[SoTienTT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[CCCD] [char](10) NOT NULL,
	[SDT] [char](10) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[CCCD] [char](10) NOT NULL,
	[SDT] [char](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[MaCH] [char](10) NULL,
	[QuanLy] [char](10) NULL,
	[MatKhau] [char](30) NOT NULL,
	[QuyenHan] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSX]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSX](
	[MaNSX] [char](10) NOT NULL,
	[TenNSX] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [char](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[ThongTinSP] [nvarchar](max) NULL,
	[MaDM] [char](10) NULL,
	[MaNSX] [char](10) NULL,
	[GiaBan] [int] NULL,
	[Image] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TonKho]    Script Date: 12/12/2023 21:26:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonKho](
	[MaCH] [char](10) NOT NULL,
	[MaSP] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHD] ([MaChiTiet], [MaHD], [MaSP], [SoLuong]) VALUES (N'1         ', N'2345      ', NULL, 1)
INSERT [dbo].[ChiTietHD] ([MaChiTiet], [MaHD], [MaSP], [SoLuong]) VALUES (N'2         ', N'0507      ', NULL, 2)
INSERT [dbo].[ChiTietHD] ([MaChiTiet], [MaHD], [MaSP], [SoLuong]) VALUES (N'3         ', N'1234      ', NULL, 1)
INSERT [dbo].[ChiTietHD] ([MaChiTiet], [MaHD], [MaSP], [SoLuong]) VALUES (N'4         ', N'6789      ', NULL, 1)
INSERT [dbo].[ChiTietHD] ([MaChiTiet], [MaHD], [MaSP], [SoLuong]) VALUES (N'5         ', N'3456      ', NULL, 3)
GO
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi], [SoDienThoai], [QuanLy], [NgayKhaiTruong]) VALUES (N'4         ', N'FPTShop Quận 1', N'Quận 1', N'0839144983', N'NVFPT115  ', CAST(N'2004-02-12T00:00:00.000' AS DateTime))
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi], [SoDienThoai], [QuanLy], [NgayKhaiTruong]) VALUES (N'5         ', N'FPTShop Quận 10', N'Quận 10', N'0839798220', N'NVFPT309  ', CAST(N'2000-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi], [SoDienThoai], [QuanLy], [NgayKhaiTruong]) VALUES (N'CHFPT336  ', N'FPT Quận 3', N'Quận 3, TP Hồ Chí Minh', N'0856539971', N'NVFPT118  ', CAST(N'2023-12-05T00:00:00.000' AS DateTime))
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi], [SoDienThoai], [QuanLy], [NgayKhaiTruong]) VALUES (N'CHFPT779  ', N'FPT Shop Thủ Đức', N'Võ Văn Ngân,Thủ Đức', N'0863439981', N'NVFPT165  ', CAST(N'2023-12-11T00:00:00.000' AS DateTime))
INSERT [dbo].[CuaHang] ([MaCH], [TenCH], [DiaChi], [SoDienThoai], [QuanLy], [NgayKhaiTruong]) VALUES (N'CHFPT910  ', N'FPT Bình Dương', N'Bình Dương', N'0856539971', N'NVFPT634  ', CAST(N'2023-12-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM], [ThuocTinhDanhMuc]) VALUES (N'DM01      ', N'Điện thoại', N'Xuất xứ,Trọng lượng,Kích thước,Ram,Rom')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM], [ThuocTinhDanhMuc]) VALUES (N'DMFPT206  ', N'Tai nghe', N'Model,Thương hiệu,Xuất xứ,Thời gian bảo hành,Trọng lượng,Màu sắc,Loại tai nghe,Tính năng,Phụ kiện')
INSERT [dbo].[DanhMuc] ([MaDM], [TenDM], [ThuocTinhDanhMuc]) VALUES (N'DMFPT872  ', N'Laptop', N'CPU,Ram,SSD,VGA,Màn Hình,Chất liệu vỏ,Màu sắc,Trọng lượng,Thời gian bảo hành')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayTao], [MaCH], [PTThanhToan], [SoTienTT]) VALUES (N'0507      ', N'11        ', NULL, CAST(N'2023-10-05T00:00:00.000' AS DateTime), N'4         ', N'Tiền Mặt', 7580000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayTao], [MaCH], [PTThanhToan], [SoTienTT]) VALUES (N'1234      ', N'12        ', NULL, CAST(N'2023-01-05T00:00:00.000' AS DateTime), NULL, N'Tiền Mặt', 2990000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayTao], [MaCH], [PTThanhToan], [SoTienTT]) VALUES (N'2345      ', N'10        ', NULL, CAST(N'2023-11-01T00:00:00.000' AS DateTime), NULL, N'Chuyển Khoản', 27090000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayTao], [MaCH], [PTThanhToan], [SoTienTT]) VALUES (N'3456      ', N'14        ', NULL, CAST(N'2023-01-01T00:00:00.000' AS DateTime), NULL, N'Chuyển Khoản', 103470000)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayTao], [MaCH], [PTThanhToan], [SoTienTT]) VALUES (N'6789      ', N'13        ', NULL, CAST(N'2023-01-06T00:00:00.000' AS DateTime), N'5         ', N'Tiền Mặt', 3690000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CCCD], [SDT], [DiaChi], [Email]) VALUES (N'10        ', N'Lê Thị Xuân', N'0722040001', N'0137943792', N'TPHồ Chí Minh', N'Xuan10@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CCCD], [SDT], [DiaChi], [Email]) VALUES (N'11        ', N'Lê Văn Việt', N'0722040002', N'0137943793', N'TPHồ Chí Minh', N'Viet11@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CCCD], [SDT], [DiaChi], [Email]) VALUES (N'12        ', N'Nguyễn Anh Tú', N'0722040003', N'0268913684', N'TPHồ Chí Minh', N'Tu12@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CCCD], [SDT], [DiaChi], [Email]) VALUES (N'13        ', N'Thu Thắm', N'0722040004', N'0137943358', N'TPHồ Chí Minh', N'Tham13@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoTenKH], [CCCD], [SDT], [DiaChi], [Email]) VALUES (N'14        ', N'Trần Anh Tuấn', N'0722040005', N'0567943792', N'TPHồ Chí Minh', N'Tuan14@gmail.com')
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT115  ', N'Trần  Văn  Tí', CAST(N'2002-06-28' AS Date), N'Quận 4, TP HCM', N'Nam', N'0722042092', N'0856531105', N'nhanvienfpt3306@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT651                    ', N'Quản lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT118  ', N'Trần  Văn  Tủn', CAST(N'2001-08-13' AS Date), N'Bình Dương', N'Nam', N'0722049925', N'0856532715', N'nhanvienfpt3358@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT619                    ', N'Quản lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT165  ', N'Võ  Văn  Tủn', CAST(N'2002-09-18' AS Date), N'Bình Thạnh, TP Hồ Chí Minh', N'Nữ', N'0722047017', N'0856532601', N'nhanvienfpt3591@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT919                    ', N'Quản lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT293  ', N'Trần  Văn  Tí', CAST(N'2002-06-19' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722041265', N'0856538045', N'nhanvienfpt7215@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT390                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT309  ', N'Nguyễn  Văn  Tèo', CAST(N'2003-07-15' AS Date), N'Quận 3, TP Hồ Chí Minh', N'Nữ', N'0722046213', N'0856538241', N'nhanvienfpt6015@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT900                    ', N'Quản lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT341  ', N'Huỳnh  Văn  Tí', CAST(N'2000-09-13' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722049734', N'0856533113', N'nhanvienfpt4635@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT212                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT372  ', N'Võ  Văn  Tủn', CAST(N'2000-10-06' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722045139', N'0856532841', N'nhanvienfpt3353@gmail.com', N'CHFPT910  ', N'NVFPT634  ', N'MKNVFPT524                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT388  ', N'Nguyễn  Văn  Tèo', CAST(N'2002-04-24' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722049288', N'0856535631', N'nhanvienfpt8114@gmail.com', N'4         ', N'NVFPT115  ', N'MKNVFPT849                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT391  ', N'Nguyễn  Văn  Tèo', CAST(N'2003-06-28' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722043936', N'0856535134', N'nhanvienfpt7731@gmail.com', N'4         ', N'NVFPT115  ', N'MKNVFPT893                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT438  ', N'Trần  Văn  Tủn', CAST(N'2001-09-24' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722047285', N'0856534695', N'nhanvienfpt3930@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT856                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT485  ', N'Huỳnh  Văn  Tèo', CAST(N'2002-10-08' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722041358', N'0856538310', N'nhanvienfpt7259@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT376                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT516  ', N'Huỳnh  Văn  Tèo', CAST(N'2003-05-15' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722042983', N'0856535832', N'nhanvienfpt2158@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT687                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT535  ', N'Huỳnh  Văn  Tí', CAST(N'2003-11-15' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722046285', N'0856537653', N'nhanvienfpt4228@gmail.com', N'CHFPT779  ', N'NVFPT165  ', N'MKNVFPT407                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT563  ', N'Huỳnh  Văn  Tí', CAST(N'2002-10-14' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722043616', N'0856539046', N'nhanvienfpt4208@gmail.com', N'CHFPT336  ', N'NVFPT118  ', N'MKNVFPT847                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT566  ', N'Huỳnh  Văn  Tèo', CAST(N'2001-05-12' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722042334', N'0856534939', N'nhanvienfpt8723@gmail.com', N'CHFPT779  ', N'NVFPT165  ', N'MKNVFPT339                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT613  ', N'Võ  Văn  Tí', CAST(N'2002-04-19' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722047838', N'0856539741', N'nhanvienfpt8585@gmail.com', N'CHFPT779  ', N'NVFPT165  ', N'MKNVFPT809                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT616  ', N'Nguyễn  Văn  Tủn', CAST(N'2002-09-12' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722043533', N'0856537088', N'nhanvienfpt7668@gmail.com', N'CHFPT779  ', N'NVFPT165  ', N'MKNVFPT883                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT634  ', N'Nguyễn Thành Nhân', CAST(N'2004-11-01' AS Date), N'Tây Ninh', N'Nam', N'0722040052', N'0856529971', N'nguyenchihai1965@gmail.com', N'CHFPT910  ', N'NVFPT634  ', N'MKNVFPT984                    ', N'Quản lý')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT660  ', N'Trần  Văn  Tèo', CAST(N'2003-11-16' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722046951', N'0856538965', N'nhanvienfpt7714@gmail.com', N'4         ', N'NVFPT115  ', N'MKNVFPT108                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT789  ', N'Huỳnh  Văn  Tèo', CAST(N'2003-06-23' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722048824', N'0856534735', N'nhanvienfpt1705@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT710                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT792  ', N'Võ  Văn  Tí', CAST(N'2000-10-19' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722047807', N'0856538451', N'nhanvienfpt3935@gmail.com', N'4         ', N'NVFPT115  ', N'MKNVFPT742                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT810  ', N'Nguyễn Văn Tủn', CAST(N'2013-03-14' AS Date), N'TP Hồ Chí Minh', N'Nam', N'0722040053', N'0836339971', N'nguyenvantun1900@gmail.com', N'CHFPT910  ', N'NVFPT634  ', N'MKNVFPT327                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT839  ', N'Huỳnh  Văn  Tèo', CAST(N'2003-08-04' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722044638', N'0856538725', N'nhanvienfpt6720@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT667                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT886  ', N'Võ  Văn  Tí', CAST(N'2000-03-19' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722048657', N'0856535800', N'nhanvienfpt7398@gmail.com', N'5         ', N'NVFPT309  ', N'MKNVFPT363                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT889  ', N'Huỳnh  Văn  Tèo', CAST(N'2002-10-29' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722042122', N'0856531643', N'nhanvienfpt9300@gmail.com', N'4         ', N'NVFPT115  ', N'MKNVFPT675                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT967  ', N'Trần  Văn  Tèo', CAST(N'2000-07-20' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722045112', N'0856532985', N'nhanvienfpt7891@gmail.com', N'CHFPT910  ', N'NVFPT634  ', N'MKNVFPT234                    ', N'Nhân viên')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [DiaChi], [GioiTinh], [CCCD], [SDT], [Email], [MaCH], [QuanLy], [MatKhau], [QuyenHan]) VALUES (N'NVFPT983  ', N'Trần  Văn  Tủn', CAST(N'2003-10-15' AS Date), N'TP Hồ Chí Minh', N'Nữ', N'0722045835', N'0856537009', N'nhanvienfpt9229@gmail.com', N'CHFPT910  ', N'NVFPT634  ', N'MKNVFPT118                    ', N'Nhân viên')
GO
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'01        ', N'Apple')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'02        ', N'Samsung')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'03        ', N'Xiaomi')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'04        ', N'Vivo')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'05        ', N'Realme')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'NSXFPT122 ', N'Oppo')
INSERT [dbo].[NhaSX] ([MaNSX], [TenNSX]) VALUES (N'NSXFPT476 ', N'Acer')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT323  ', N'Samsung galaxy z-flip 5', N'Xuất xứ:Hàn Quốc|Trọng lượng:187 g|Kích thước:6.7 inch, 3.4 inch, Dynamic AMOLED, FHD+, 1080 x 2636 Pixels|Ram:8Gb|Rom:256Gb', N'DM01      ', N'02        ', 17999000, N'zflip5.jpg')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT418  ', N'Iphone 15 pro max', N'Xuất xứ:Mỹ|Trọng lượng:0,4Kg|Kích thước:700x700|Ram:3Gb|Rom:128Gb', N'DM01      ', N'01        ', 60000000, N'iphon15.jpg')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT655  ', N'MacBook Air 13 inch M1 2020 8CPU 7GPU 8GB,256GB ', N'CPU:Apple, M1|Ram:8Gb|SSD:256Gb|VGA:không|Màn Hình:13.3 inch, 2560 x 1600 Pixels, IPS, IPS LCD LED Backlit, True Tone|Chất liệu vỏ:Hợp kim nhôm|Màu sắc:Vàng kim|Trọng lượng:1.29 kg|Thời gian bảo hành:12 tháng', N'DMFPT872  ', N'01        ', 20000000, N'mbair13.jpg')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT763  ', N'Tai nghe AirPods Pro 2022 ', N'Model:AirPords Pro 2|Thương hiệu:Apple|Xuất xứ:Trung Quốc|Thời gian bảo hành:12 tháng|Trọng lượng:50.8g|Màu sắc:Trắng|Loại tai nghe:Không dây|Tính năng:Chống ồn, sạc không dây|Phụ kiện:Dây sạc', N'DMFPT206  ', N'01        ', 5290000, N'airpord22.jpg')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT838  ', N'realme C30s 3GB-64GB', N'Xuất xứ:Trung Quốc|Trọng lượng:0,2kg|Kích thước:6.5 inch, LCD, HD, 720 x 1600 Pixels|Ram:3Gb|Rom:64Gb', N'DM01      ', N'05        ', 2290000, N'realmeC30s.jpg')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [ThongTinSP], [MaDM], [MaNSX], [GiaBan], [Image]) VALUES (N'SPFPT904  ', N'ACER ASPIRE 5 A515-56-36UT, i3 1115G4, 4GB, SSD 12', N'CPU:Intel® Core ™ i3 1115G4 (upto 4.10GHz, 6MB, 2 lõi, 4 luồng)|Ram:4GB DDR4|SSD:128GB NVMe SSD|VGA:Intel® UHD Graphics|Màn Hình:15.6 FHD (1920x1080), ComfyView|Chất liệu vỏ: Mặt lưng nhôm|Màu sắc:Silver|Trọng lượng:1.4 kg|Thời gian bảo hành:12 tháng', N'DMFPT872  ', N'NSXFPT476 ', 20000000, N'acer.jpg')
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [HD_CTHD_MaHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [HD_CTHD_MaHD]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [SP_CTHD_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [SP_CTHD_MaSP]
GO
ALTER TABLE [dbo].[CuaHang]  WITH CHECK ADD  CONSTRAINT [NV_CH_QuanLy] FOREIGN KEY([QuanLy])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[CuaHang] CHECK CONSTRAINT [NV_CH_QuanLy]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [CH_HD_MaCH] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CuaHang] ([MaCH])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [CH_HD_MaCH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [KH_HD_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [KH_HD_MaKH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [NV_HD_MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [NV_HD_MaNV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CH_NV_MaCH] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CuaHang] ([MaCH])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CH_NV_MaCH]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [DM_SP_MaDM] FOREIGN KEY([MaDM])
REFERENCES [dbo].[DanhMuc] ([MaDM])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [DM_SP_MaDM]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [MSX_SP_MaNSX] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[NhaSX] ([MaNSX])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [MSX_SP_MaNSX]
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD  CONSTRAINT [CH_TK_MaCH] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CuaHang] ([MaCH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TonKho] CHECK CONSTRAINT [CH_TK_MaCH]
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD  CONSTRAINT [SP_TK_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TonKho] CHECK CONSTRAINT [SP_TK_MaSP]
GO
ALTER TABLE [dbo].[CuaHang]  WITH CHECK ADD  CONSTRAINT [CK_SDT_CH] CHECK  ((len([SoDienThoai])=(10)))
GO
ALTER TABLE [dbo].[CuaHang] CHECK CONSTRAINT [CK_SDT_CH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [CK_PPThanhToan] CHECK  (([PTThanhToan]=N'Chuyển khoản' OR [PTThanhToan]=N'Tiền mặt'))
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [CK_PPThanhToan]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [CK_CCCD_KH] CHECK  ((len([CCCD])=(10)))
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [CK_CCCD_KH]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [CK_SDT_KH] CHECK  ((len([SDT])=(10)))
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [CK_SDT_KH]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD CHECK  (([QuyenHan]=N'nhân viên' OR [QuyenHan]=N'quản lý'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_CCCD_NV] CHECK  ((len([CCCD])=(10)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_CCCD_NV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_GioiTinh] CHECK  (([GioiTinh]=N'Nữ' OR [GioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_SDT_NV] CHECK  ((len([SDT])=(10)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_SDT_NV]
GO
