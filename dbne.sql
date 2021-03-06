USE [QuanLySinhVien]
GO
/****** Object:  Table [dbo].[AdminDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminDb](
	[MaAdmin] [nvarchar](5) NOT NULL,
	[TenAdmin] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [float] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AdminDb] PRIMARY KEY CLUSTERED 
(
	[MaAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemDb](
	[MaMH] [int] NOT NULL,
	[MaHS] [nvarchar](5) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_DiemDb] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVienDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVienDb](
	[MaGV] [nvarchar](5) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [float] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[ChuyenNganh] [nvarchar](50) NOT NULL,
	[TrinhDoChuyenMon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GiaoVienDb] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoc]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoc](
	[MaKH] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
 CONSTRAINT [PK_Hoc] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinhDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinhDb](
	[MaHS] [nvarchar](5) NOT NULL,
	[TenHS] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[SDT] [float] NULL,
	[Email] [nvarchar](50) NULL,
	[MaLop] [int] NOT NULL,
 CONSTRAINT [PK_HocSinhDb] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHocDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHocDb](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
 CONSTRAINT [PK_KhoaHocDb] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopDb](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[PhongHoc] [nvarchar](10) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LopDb] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHocDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHocDb](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MonHocDb] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanAdDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanAdDb](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[MaAdmin] [nvarchar](5) NOT NULL,
	[TenDangNhap] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoanAd] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanGVDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanGVDb](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[MaGV] [nvarchar](5) NOT NULL,
	[TenDangNhap] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoanGV] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanHSDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanHSDb](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[MaHS] [nvarchar](5) NULL,
	[TenDangNhap] [nvarchar](10) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TaiKhoanDb_1] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKBCTDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKBCTDb](
	[MaTKB] [int] NOT NULL,
	[Malop] [int] NOT NULL,
	[Thu] [int] NOT NULL,
	[Tiet] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[MaGV] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_TKBCTDb_1] PRIMARY KEY CLUSTERED 
(
	[Thu] ASC,
	[Tiet] ASC,
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TKBDb]    Script Date: 12/29/2021 3:07:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TKBDb](
	[MaTKB] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[TenTKB] [nvarchar](50) NULL,
 CONSTRAINT [PK_TKBDb] PRIMARY KEY CLUSTERED 
(
	[MaTKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AdminDb] ([MaAdmin], [TenAdmin], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (N'ad1', N'Nguyễn Thành Hưng', N'Nam', CAST(N'2001-03-03T00:00:00.000' AS DateTime), N'Tân Bình, Tp Hồ Chí Minh', 321254342, N'hung@gmail.com')
INSERT [dbo].[AdminDb] ([MaAdmin], [TenAdmin], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email]) VALUES (N'ad2', N'Thành Hiệp 3', N'Nam', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'Tân bình, tp. Hồ Chí Minh', 132312, N'fds1f@gmail.com')
GO
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs1', 10)
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs2', 9)
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs3', 9)
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs4', 9)
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs5', 4)
INSERT [dbo].[DiemDb] ([MaMH], [MaHS], [Diem]) VALUES (1, N'hs6', 3)
GO
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv1', N'Lê Ngọc Hiếu', N'Nam', CAST(N'1987-01-01T00:00:00.000' AS DateTime), N'Tân Bình, tp Hồ Chí Minh', 124365321, N'hieu@gmail.com', N'Toán', N'thạc sĩ ')
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv121', N'Thành hưng', N'Nam', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'sdfasd', 132312, N'fdsf@gmail.com', N'toán', N'Tiến sĩ')
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv2', N'Võ Thị Hồng Tuyết', N'Nữ', CAST(N'1987-01-04T00:00:00.000' AS DateTime), N'Quận 3, Tp hồ Chí Minh', 1278453, N'tuyet@gmail.com', N'Văn', N'Thạc sĩ')
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv3', N'Nguyễn Thị Mai Trang', N'Nữ ', CAST(N'1986-03-04T00:00:00.000' AS DateTime), N'Tân Bình, Tp Hồ Chí Minh', 2138742, N'trang@gmail.com', N'Sinh', N'Thạc sĩ')
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv4', N'Lê Văn Hùng', N'Nam', CAST(N'1980-12-03T00:00:00.000' AS DateTime), N'Tân Bình', 318912, N'hung@gmail.com', N'Lịch sử', N'thạc sĩ')
INSERT [dbo].[GiaoVienDb] ([MaGV], [TenGV], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [ChuyenNganh], [TrinhDoChuyenMon]) VALUES (N'gv5', N'Trần Quốc Hưng', N'Nam', CAST(N'1985-03-03T00:00:00.000' AS DateTime), N'Tân Phú, Tp Hồ Chí Minh', 37912857, N'quochung@gmail.com', N'Toán', N'Thạc sĩ')
GO
INSERT [dbo].[Hoc] ([MaKH], [MaLop]) VALUES (2, 1)
INSERT [dbo].[Hoc] ([MaKH], [MaLop]) VALUES (2, 2)
INSERT [dbo].[Hoc] ([MaKH], [MaLop]) VALUES (2, 3)
INSERT [dbo].[Hoc] ([MaKH], [MaLop]) VALUES (2, 4)
GO
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs1', N'Vương Thái Tường', N'Nam', CAST(N'2005-01-06T00:00:00.000' AS DateTime), N'Bình Thạnh, Tp. Hồ Chí Minh', 1231245, N'tuong@gmail.com', 1)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs123', N'Lê Văn Học', N'Nam', CAST(N'2021-12-11T00:00:00.000' AS DateTime), N'Tân bình, tp. Hồ Chí Minh', 11111111, N'fds1f@gmail.com', 1)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs2', N'Nguyễn Thành Hưng', N'Nam', CAST(N'2005-03-03T00:00:00.000' AS DateTime), N'Tân Bình, Tp Hồ Chí Minh', 12379832, N'hung@gmail.com', 1)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs23', N'Lê Văn Học', N'Nam', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'Tân Bình, Tp Hồ Chí Minh', 132312, N'fds1f@gmail.com', 2)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs24', N'Hồ Văn Tri', N'Nam', CAST(N'2000-01-01T00:00:00.000' AS DateTime), N'Tân Bình, Tp Hồ Chí Minh', 132312, N'hung@gmail.com', 1)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs3', N'Nguyễn Thị Út Thương', N'Nữ', CAST(N'2006-01-01T00:00:00.000' AS DateTime), N'Tân Bình', 4835932, N'thuong@gmail.com', 2)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs4', N'Lan Anh', N'Nữ', CAST(N'2006-01-02T00:00:00.000' AS DateTime), N'Bình Tân, Tp Hồ Chí Minh', 3127895, N'Lan@gmail.com', 2)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs5', N'Thanh Thảo', N'Nữ', CAST(N'2006-01-04T00:00:00.000' AS DateTime), N'Quận 3, Tp Hồ Chí Minh', 12390432, N'thao@gmail.com', 3)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs6', N'Hà Yến ', N'Nữ', CAST(N'2006-03-06T00:00:00.000' AS DateTime), N'Quận 3, Tp Hồ Chí Minh', 42378921, N'yen@gmail.com', 3)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs7', N'Nguyễn Văn Thiện', N'Nam', CAST(N'2007-02-06T00:00:00.000' AS DateTime), N'Quận 3, Tp Hồ Chí Minh', 132871, N'thien@gmail.com', 4)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs8', N'Trần Quang Nhật', N'Nam', CAST(N'2007-12-04T00:00:00.000' AS DateTime), N'Quận 2, Tp Hồ Chí Minh', 3127891, N'nhat@gmail.com', 4)
INSERT [dbo].[HocSinhDb] ([MaHS], [TenHS], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [Email], [MaLop]) VALUES (N'hs91', N'Lê Văn Học', N'Nữ', CAST(N'2021-12-16T00:00:00.000' AS DateTime), N'Tân bình, tp. Hồ Chí Minh', 12222, N'hung@gmail.com', 1)
GO
SET IDENTITY_INSERT [dbo].[KhoaHocDb] ON 

INSERT [dbo].[KhoaHocDb] ([MaKH], [TenKH], [NgayBatDau], [NgayKetThuc]) VALUES (2, N'2020-2021 kỳ 1', CAST(N'2020-01-04T00:00:00.000' AS DateTime), CAST(N'2021-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[KhoaHocDb] ([MaKH], [TenKH], [NgayBatDau], [NgayKetThuc]) VALUES (7, N'2020-2021 kỳ 2', CAST(N'2021-12-31T00:00:00.000' AS DateTime), CAST(N'2022-01-09T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[KhoaHocDb] OFF
GO
SET IDENTITY_INSERT [dbo].[LopDb] ON 

INSERT [dbo].[LopDb] ([MaLop], [TenLop], [MoTa], [PhongHoc], [TrangThai]) VALUES (1, N'12A1', N'Khối A', N'201', N'Đang học')
INSERT [dbo].[LopDb] ([MaLop], [TenLop], [MoTa], [PhongHoc], [TrangThai]) VALUES (2, N'12A3', N'Khối C', N'203', N'Đang học')
INSERT [dbo].[LopDb] ([MaLop], [TenLop], [MoTa], [PhongHoc], [TrangThai]) VALUES (3, N'11A9', N'Lớp thường', N'109', N'Đang học')
INSERT [dbo].[LopDb] ([MaLop], [TenLop], [MoTa], [PhongHoc], [TrangThai]) VALUES (4, N'10A2', N'Lớp chọn', N'002', N'Chưa học')
SET IDENTITY_INSERT [dbo].[LopDb] OFF
GO
SET IDENTITY_INSERT [dbo].[MonHocDb] ON 

INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (1, N'Toán 12')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (3, N'Toán 11')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (4, N'Toán 101')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (5, N'Văn 12')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (7, N'Văn 11')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (8, N'Văn 10')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (9, N'Sinh 11')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (10, N'Sinh 10')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (12, N'Lịch sử 11')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (13, N'Lịch sử 10')
INSERT [dbo].[MonHocDb] ([MaMH], [TenMH]) VALUES (15, N'Lý 12')
SET IDENTITY_INSERT [dbo].[MonHocDb] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanAdDb] ON 

INSERT [dbo].[TaiKhoanAdDb] ([MaTK], [MaAdmin], [TenDangNhap], [MatKhau]) VALUES (1, N'ad1', N'ad1', N'1232')
SET IDENTITY_INSERT [dbo].[TaiKhoanAdDb] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanGVDb] ON 

INSERT [dbo].[TaiKhoanGVDb] ([MaTK], [MaGV], [TenDangNhap], [MatKhau]) VALUES (1, N'gv1', N'gv1', N'123')
INSERT [dbo].[TaiKhoanGVDb] ([MaTK], [MaGV], [TenDangNhap], [MatKhau]) VALUES (2, N'gv2', N'gv2', N'123')
INSERT [dbo].[TaiKhoanGVDb] ([MaTK], [MaGV], [TenDangNhap], [MatKhau]) VALUES (3, N'gv3', N'gv3', N'123')
INSERT [dbo].[TaiKhoanGVDb] ([MaTK], [MaGV], [TenDangNhap], [MatKhau]) VALUES (4, N'gv4', N'gv4', N'1234')
SET IDENTITY_INSERT [dbo].[TaiKhoanGVDb] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanHSDb] ON 

INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (1, N'hs1', N'hs1', N'1234')
INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (2, N'hs2', N'hs2', N'123')
INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (3, N'hs3', N'hs3', N'123')
INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (5, N'hs5', N'hs5', N'123')
INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (6, N'hs6', N'hs6', N'123')
INSERT [dbo].[TaiKhoanHSDb] ([MaTK], [MaHS], [TenDangNhap], [MatKhau]) VALUES (7, N'hs7', N'hs7', N'123')
SET IDENTITY_INSERT [dbo].[TaiKhoanHSDb] OFF
GO
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 1, 2, 2, 1, N'gv1')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 2, 2, 2, 5, N'gv2')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 3, 2, 2, 9, N'gv3')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 4, 2, 2, 13, N'gv4')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 1, 2, 3, 1, N'gv1')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 2, 2, 3, 5, N'gv2')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 4, 2, 3, 10, N'gv3')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 3, 2, 3, 12, N'gv4')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 2, 2, 4, 1, N'gv1')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 1, 2, 4, 5, N'gv2')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 4, 2, 4, 10, N'gv3')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 3, 2, 4, 3, N'gv5')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 2, 2, 5, 1, N'gv1')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 1, 2, 5, 5, N'gv2')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 4, 2, 5, 13, N'gv4')
INSERT [dbo].[TKBCTDb] ([MaTKB], [Malop], [Thu], [Tiet], [MaMH], [MaGV]) VALUES (3, 3, 2, 5, 3, N'gv5')
GO
SET IDENTITY_INSERT [dbo].[TKBDb] ON 

INSERT [dbo].[TKBDb] ([MaTKB], [MaKH], [TenTKB]) VALUES (3, 2, NULL)
INSERT [dbo].[TKBDb] ([MaTKB], [MaKH], [TenTKB]) VALUES (7, 2, NULL)
INSERT [dbo].[TKBDb] ([MaTKB], [MaKH], [TenTKB]) VALUES (10, 7, NULL)
SET IDENTITY_INSERT [dbo].[TKBDb] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_MaAd]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanAdDb] ADD  CONSTRAINT [Unique_MaAd] UNIQUE NONCLUSTERED 
(
	[MaAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_tdn]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanAdDb] ADD  CONSTRAINT [unique_tdn] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_Ten]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanAdDb] ADD  CONSTRAINT [unique_Ten] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_MaGV]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanGVDb] ADD  CONSTRAINT [Unique_MaGV] UNIQUE NONCLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_tdngv]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanGVDb] ADD  CONSTRAINT [unique_tdngv] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_HS]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanHSDb] ADD  CONSTRAINT [Unique_HS] UNIQUE NONCLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [unique_tdnhs]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TaiKhoanHSDb] ADD  CONSTRAINT [unique_tdnhs] UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TKBCTDb]    Script Date: 12/29/2021 3:07:03 PM ******/
ALTER TABLE [dbo].[TKBCTDb] ADD  CONSTRAINT [IX_TKBCTDb] UNIQUE NONCLUSTERED 
(
	[Thu] ASC,
	[Tiet] ASC,
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DiemDb]  WITH CHECK ADD  CONSTRAINT [FK_DiemDb_HocSinhDb] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinhDb] ([MaHS])
GO
ALTER TABLE [dbo].[DiemDb] CHECK CONSTRAINT [FK_DiemDb_HocSinhDb]
GO
ALTER TABLE [dbo].[DiemDb]  WITH CHECK ADD  CONSTRAINT [FK_DiemDb_MonHocDb] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHocDb] ([MaMH])
GO
ALTER TABLE [dbo].[DiemDb] CHECK CONSTRAINT [FK_DiemDb_MonHocDb]
GO
ALTER TABLE [dbo].[Hoc]  WITH CHECK ADD  CONSTRAINT [FK_Hoc_KhoaHocDb] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhoaHocDb] ([MaKH])
GO
ALTER TABLE [dbo].[Hoc] CHECK CONSTRAINT [FK_Hoc_KhoaHocDb]
GO
ALTER TABLE [dbo].[Hoc]  WITH CHECK ADD  CONSTRAINT [FK_Hoc_LopDb] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopDb] ([MaLop])
GO
ALTER TABLE [dbo].[Hoc] CHECK CONSTRAINT [FK_Hoc_LopDb]
GO
ALTER TABLE [dbo].[HocSinhDb]  WITH CHECK ADD  CONSTRAINT [FK_HocSinhDb_LopDb] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopDb] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinhDb] CHECK CONSTRAINT [FK_HocSinhDb_LopDb]
GO
ALTER TABLE [dbo].[TaiKhoanAdDb]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanAdDb_AdminDb] FOREIGN KEY([MaAdmin])
REFERENCES [dbo].[AdminDb] ([MaAdmin])
GO
ALTER TABLE [dbo].[TaiKhoanAdDb] CHECK CONSTRAINT [FK_TaiKhoanAdDb_AdminDb]
GO
ALTER TABLE [dbo].[TaiKhoanGVDb]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanGVDb_GiaoVienDb] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVienDb] ([MaGV])
GO
ALTER TABLE [dbo].[TaiKhoanGVDb] CHECK CONSTRAINT [FK_TaiKhoanGVDb_GiaoVienDb]
GO
ALTER TABLE [dbo].[TaiKhoanHSDb]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanDb_HocSinhDb] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinhDb] ([MaHS])
GO
ALTER TABLE [dbo].[TaiKhoanHSDb] CHECK CONSTRAINT [FK_TaiKhoanDb_HocSinhDb]
GO
ALTER TABLE [dbo].[TKBCTDb]  WITH CHECK ADD  CONSTRAINT [FK_TKBCTDb_GiaoVienDb] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVienDb] ([MaGV])
GO
ALTER TABLE [dbo].[TKBCTDb] CHECK CONSTRAINT [FK_TKBCTDb_GiaoVienDb]
GO
ALTER TABLE [dbo].[TKBCTDb]  WITH CHECK ADD  CONSTRAINT [FK_TKBCTDb_LopDb] FOREIGN KEY([Malop])
REFERENCES [dbo].[LopDb] ([MaLop])
GO
ALTER TABLE [dbo].[TKBCTDb] CHECK CONSTRAINT [FK_TKBCTDb_LopDb]
GO
ALTER TABLE [dbo].[TKBCTDb]  WITH CHECK ADD  CONSTRAINT [FK_TKBCTDb_MonHocDb] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHocDb] ([MaMH])
GO
ALTER TABLE [dbo].[TKBCTDb] CHECK CONSTRAINT [FK_TKBCTDb_MonHocDb]
GO
ALTER TABLE [dbo].[TKBCTDb]  WITH CHECK ADD  CONSTRAINT [FK_TKBCTDb_TKBDb] FOREIGN KEY([MaTKB])
REFERENCES [dbo].[TKBDb] ([MaTKB])
GO
ALTER TABLE [dbo].[TKBCTDb] CHECK CONSTRAINT [FK_TKBCTDb_TKBDb]
GO
ALTER TABLE [dbo].[TKBDb]  WITH CHECK ADD  CONSTRAINT [FK_TKBDb_KhoaHocDb] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhoaHocDb] ([MaKH])
GO
ALTER TABLE [dbo].[TKBDb] CHECK CONSTRAINT [FK_TKBDb_KhoaHocDb]
GO
