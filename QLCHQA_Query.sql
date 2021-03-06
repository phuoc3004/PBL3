USE [QLCHQA]
GO
/****** Object:  StoredProcedure [dbo].[XoaSanPhamKhoiCTHD]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[XoaSanPhamKhoiCTHD]
GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[XoaHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProfile]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[UpdateProfile]
GO
/****** Object:  StoredProcedure [dbo].[UpdateChiTietHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[UpdateChiTietHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[TongTienHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[TongTienHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[ThemSanPhamVaoCTHD]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[ThemSanPhamVaoCTHD]
GO
/****** Object:  StoredProcedure [dbo].[TaoMoiHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[TaoMoiHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[Profile]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[Profile]
GO
/****** Object:  StoredProcedure [dbo].[Loginn]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[Loginn]
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoTenSanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[LayToanBoTenSanPham]
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoHoaDonXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[LayToanBoHoaDonXuat]
GO
/****** Object:  StoredProcedure [dbo].[HienThiToanBoTenNhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiToanBoTenNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[HienThiToanBoTenKhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiToanBoTenKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietSanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiChiTietSanPham]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietNhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiChiTietNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietKhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiChiTietKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietHoaDonDaChon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiChiTietHoaDonDaChon]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiThongTinCoBanHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[HienThiChiThongTinCoBanHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[GetOldPass]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[GetOldPass]
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP PROCEDURE [dbo].[ChangePassword]
GO
ALTER TABLE [dbo].[SanPham] DROP CONSTRAINT [fk_hsx]
GO
ALTER TABLE [dbo].[HoaDonXuat] DROP CONSTRAINT [fk_mnv]
GO
ALTER TABLE [dbo].[HoaDonXuat] DROP CONSTRAINT [fk_mkh]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [fk_msp]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] DROP CONSTRAINT [fk_hdx]
GO
ALTER TABLE [dbo].[HoaDonXuat] DROP CONSTRAINT [DF_HoaDonXuat_TongTien]
GO
/****** Object:  Index [UQ__NhanVien__7ED88CAE919B5CFE]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [UQ__NhanVien__7ED88CAE919B5CFE]
GO
/****** Object:  Index [UQ__NhanVien__78A4A133218BC4D3]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[NhanVien] DROP CONSTRAINT [UQ__NhanVien__78A4A133218BC4D3]
GO
/****** Object:  Index [UQ__KhachHan__7ED9643F76AB4C3F]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [UQ__KhachHan__7ED9643F76AB4C3F]
GO
/****** Object:  Index [UQ__KhachHan__78A486A5F4D27F61]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[KhachHang] DROP CONSTRAINT [UQ__KhachHan__78A486A5F4D27F61]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SanPham]') AND type in (N'U'))
DROP TABLE [dbo].[SanPham]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KhachHang]') AND type in (N'U'))
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HoaDonXuat]') AND type in (N'U'))
DROP TABLE [dbo].[HoaDonXuat]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HangSanXuat]') AND type in (N'U'))
DROP TABLE [dbo].[HangSanXuat]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHoaDon]') AND type in (N'U'))
DROP TABLE [dbo].[ChiTietHoaDon]
GO
USE [master]
GO
/****** Object:  Database [QLCHQA]    Script Date: 6/26/2022 12:28:00 AM ******/
DROP DATABASE [QLCHQA]
GO
/****** Object:  Database [QLCHQA]    Script Date: 6/26/2022 12:28:00 AM ******/
CREATE DATABASE [QLCHQA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCHQA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLCHQA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLCHQA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLCHQA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLCHQA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCHQA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCHQA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCHQA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCHQA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCHQA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCHQA] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCHQA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCHQA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCHQA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCHQA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCHQA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCHQA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCHQA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCHQA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCHQA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCHQA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCHQA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCHQA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCHQA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCHQA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCHQA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCHQA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCHQA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCHQA] SET RECOVERY FULL 
GO
ALTER DATABASE [QLCHQA] SET  MULTI_USER 
GO
ALTER DATABASE [QLCHQA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCHQA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCHQA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCHQA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCHQA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLCHQA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLCHQA', N'ON'
GO
ALTER DATABASE [QLCHQA] SET QUERY_STORE = OFF
GO
USE [QLCHQA]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHDX] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[SoLuongMua] [int] NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHSX] [int] IDENTITY(1,1) NOT NULL,
	[TenHSX] [varchar](50) NOT NULL,
	[DiaChi] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[MaHDX] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTenKH] [varchar](50) NOT NULL,
	[GioiTinhKH] [varchar](5) NOT NULL,
	[NgaySinhKH] [datetime] NOT NULL,
	[SĐTKH] [varchar](10) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[EmailKH] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTenNV] [varchar](50) NOT NULL,
	[GioiTinhNV] [varchar](5) NOT NULL,
	[NgaySinhNV] [datetime] NOT NULL,
	[ChucVuNV] [varchar](20) NOT NULL,
	[NgayBatDauLamNV] [datetime] NOT NULL,
	[LuongNV] [float] NOT NULL,
	[SĐTNV] [varchar](10) NOT NULL,
	[EmailNV] [varchar](50) NOT NULL,
	[QueQuanNV] [varchar](100) NOT NULL,
	[Pass] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [varchar](50) NOT NULL,
	[MaHSX] [int] NULL,
	[DonGia] [float] NULL,
	[MoTa] [varchar](200) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (1, 1, 2, 780, 1, 780)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (2, 1, 1, 560, 2, 1120)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (3, 3, 1, 560, 1, 560)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (4, 4, 1, 560, 1, 560)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (5, 6, 4, 400, 1, 400)
INSERT [dbo].[ChiTietHoaDon] ([MaCTHD], [MaHDX], [MaSP], [DonGia], [SoLuongMua], [ThanhTien]) VALUES (6, 6, 1, 560, 1, 560)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[HangSanXuat] ON 

INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX], [DiaChi]) VALUES (1, N'Luon Vuituoi', N'Vietnam')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHSX], [DiaChi]) VALUES (2, N'Dolce', N'Vietnam')
SET IDENTITY_INSERT [dbo].[HangSanXuat] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonXuat] ON 

INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (1, 2, 1, CAST(N'2022-05-15T00:00:00.000' AS DateTime), 1900)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (2, 2, 2, CAST(N'2022-03-10T00:00:00.000' AS DateTime), 289)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (3, 1, 1, CAST(N'2022-05-15T00:00:00.000' AS DateTime), 560)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (4, 2, 3, CAST(N'2022-06-24T00:00:00.000' AS DateTime), 560)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (5, 2, 1, CAST(N'2022-06-24T00:00:00.000' AS DateTime), 2999)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (6, 2, 1, CAST(N'2022-06-25T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[HoaDonXuat] ([MaHDX], [MaNV], [MaKH], [NgayLap], [TongTien]) VALUES (7, 2, 1, CAST(N'2022-06-25T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[HoaDonXuat] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [HoVaTenKH], [GioiTinhKH], [NgaySinhKH], [SĐTKH], [DiaChi], [EmailKH]) VALUES (1, N'Vu Thi Khanh Huyen', N'Nu', CAST(N'2000-12-05T00:00:00.000' AS DateTime), N'0115111111', N'VietNam', N'Vuthikhanhhuyen@123gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTenKH], [GioiTinhKH], [NgaySinhKH], [SĐTKH], [DiaChi], [EmailKH]) VALUES (2, N'Tran Van Hung', N'Nam', CAST(N'1999-10-08T00:00:00.000' AS DateTime), N'0115111123', N'VietNam', N'Tranvanhung@123gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTenKH], [GioiTinhKH], [NgaySinhKH], [SĐTKH], [DiaChi], [EmailKH]) VALUES (3, N'Tran Minh', N'Nam', CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'0872569421', N'VietNam', N'minh@gmail.com')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [HoVaTenNV], [GioiTinhNV], [NgaySinhNV], [ChucVuNV], [NgayBatDauLamNV], [LuongNV], [SĐTNV], [EmailNV], [QueQuanNV], [Pass]) VALUES (1, N'Le Van Do', N'Nam', CAST(N'1990-07-05T00:00:00.000' AS DateTime), N'Manager', CAST(N'2020-10-01T00:00:00.000' AS DateTime), 1500, N'0987123456', N'Levando@123gmail.com', N'VietNam', N'do123')
INSERT [dbo].[NhanVien] ([MaNV], [HoVaTenNV], [GioiTinhNV], [NgaySinhNV], [ChucVuNV], [NgayBatDauLamNV], [LuongNV], [SĐTNV], [EmailNV], [QueQuanNV], [Pass]) VALUES (2, N'Tran Thi Quynh', N'', CAST(N'1999-11-01T00:00:00.000' AS DateTime), N'Saler', CAST(N'2022-02-01T00:00:00.000' AS DateTime), 500, N'0987123756', N'Tranthiquynh@123gmail.com', N'VietNam', N'quynh')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaHSX], [DonGia], [MoTa], [SoLuong]) VALUES (1, N'Luon Vuituoi T-Shirt Size XL', 1, 560, N'Thiet ke dep gia re', 10)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaHSX], [DonGia], [MoTa], [SoLuong]) VALUES (2, N'Dolce T-shirt Size M', 2, 780, N'Thiet ke dep gia re', 16)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaHSX], [DonGia], [MoTa], [SoLuong]) VALUES (3, N'Dolce Long Tee', 2, 250, N'Thiet Ke Thoai Mai', 100)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaHSX], [DonGia], [MoTa], [SoLuong]) VALUES (4, N'Luon Vuituoi Hand Bag Gold Edition', 1, 400, N'Tui xach thoi trang', 50)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__78A486A5F4D27F61]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[SĐTKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KhachHan__7ED9643F76AB4C3F]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[KhachHang] ADD UNIQUE NONCLUSTERED 
(
	[EmailKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__78A4A133218BC4D3]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[SĐTNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NhanVien__7ED88CAE919B5CFE]    Script Date: 6/26/2022 12:28:00 AM ******/
ALTER TABLE [dbo].[NhanVien] ADD UNIQUE NONCLUSTERED 
(
	[EmailNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HoaDonXuat] ADD  CONSTRAINT [DF_HoaDonXuat_TongTien]  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_hdx] FOREIGN KEY([MaHDX])
REFERENCES [dbo].[HoaDonXuat] ([MaHDX])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_hdx]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [fk_msp] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [fk_msp]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [fk_mkh] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [fk_mkh]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [fk_mnv] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [fk_mnv]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_hsx] FOREIGN KEY([MaHSX])
REFERENCES [dbo].[HangSanXuat] ([MaHSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_hsx]
GO
/****** Object:  StoredProcedure [dbo].[ChangePassword]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChangePassword]
@id int,
@moi varchar(10)
as
update NhanVien
set Pass = @moi
where MaNV = @id;
GO
/****** Object:  StoredProcedure [dbo].[GetOldPass]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetOldPass]
@id int
as
select Pass from NhanVien where MaNV = @id;
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiThongTinCoBanHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiChiThongTinCoBanHoaDon]
@maHD int
as
select hd.MaHDX,hd.NgayLap,hd.MaNV,nv.HoVaTenNV,hd.MaKH,kh.HoVaTenKH,kh.DiaChi,kh.SĐTKH from HoaDonXuat hd inner join NhanVien nv on hd.MaNV = nv.MaNV 
inner join KhachHang kh on hd.MaKH = kh.MaKH
where hd.MaHDX = @maHD;
select * from ChiTietHoaDon; 
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietHoaDonDaChon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiChiTietHoaDonDaChon]
@maHDX int
as
select hd.MaCTHD,hd.MaHDX,hd.MaSP,sp.TenSP,sp.DonGia,hd.SoLuongMua,hd.ThanhTien from ChiTietHoaDon hd inner join SanPham sp on hd.MaSP = sp.MaSP
where hd.MaHDX = @maHDX;
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietKhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiChiTietKhachHang]
@maKH int
as
select MaKH,HoVaTenKH,DiaChi,SĐTKH from KhachHang
where MaKH = @maKH;
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietNhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiChiTietNhanVien]
@maNV int
as
select MaNV,HoVaTenNV from NhanVien
where MaNV = @maNV;
GO
/****** Object:  StoredProcedure [dbo].[HienThiChiTietSanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiChiTietSanPham]
@maSP int
as
select MaSP,TenSP,TenHSX,SoLuong,DonGia from SanPham sp inner join HangSanXuat hsx on sp.MaHSX = hsx.MaHSX
where sp.MaSP = @maSP;
GO
/****** Object:  StoredProcedure [dbo].[HienThiToanBoTenKhachHang]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiToanBoTenKhachHang]
as
select MaKH,HoVaTenKH from KhachHang;
GO
/****** Object:  StoredProcedure [dbo].[HienThiToanBoTenNhanVien]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HienThiToanBoTenNhanVien]
as
select MaNV,HoVaTenNV from NhanVien;
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoHoaDonXuat]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoHoaDonXuat]
as
select MaHDX from HoaDonXuat;
GO
/****** Object:  StoredProcedure [dbo].[LayToanBoTenSanPham]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayToanBoTenSanPham]
as
select MaSP,TenSP from SanPham;
GO
/****** Object:  StoredProcedure [dbo].[Loginn]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Loginn]
@email varchar(50),
@passs varchar(10),
@position varchar(20)
as
select * from NhanVien where EmailNV = @email and Pass = @passs and ChucVuNV = @position;
GO
/****** Object:  StoredProcedure [dbo].[Profile]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Profile]
@id int
as
select * from NhanVien where MaNV = @id;
GO
/****** Object:  StoredProcedure [dbo].[TaoMoiHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TaoMoiHoaDon]
@ngayLap datetime,
@maNV int,
@maKH int
as
insert into HoaDonXuat(MaKH,MaNV,NgayLap) values (@maKH,@maNV,@ngayLap);
GO
/****** Object:  StoredProcedure [dbo].[ThemSanPhamVaoCTHD]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemSanPhamVaoCTHD]
@maHD int,
@maSP int,
@donGia float,
@soLuong int,
@thanhTien float
as
insert into ChiTietHoaDon(MaHDX,MaSP,DonGia,SoLuongMua,ThanhTien) values (@maHD,@maSP,@donGia,@soLuong,@thanhTien);
select * from ChiTietHoaDon;
GO
/****** Object:  StoredProcedure [dbo].[TongTienHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TongTienHoaDon]
@maHD int
as
select Sum(ThanhTien) as 'tong' from ChiTietHoaDon where MaHDX = @maHD;
GO
/****** Object:  StoredProcedure [dbo].[UpdateChiTietHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateChiTietHoaDon]
@maCT int,
@maSP int,
@donGia float,
@soLuong int,
@thanhTien float
as
update ChiTietHoaDon
set MaSP = @maSP, DonGia = @donGia, SoLuongMua = @soLuong, ThanhTien = @thanhTien
where MaCTHD = @maCT;
GO
/****** Object:  StoredProcedure [dbo].[UpdateProfile]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateProfile]
@id int,
@name varchar(50),
@sex varchar(5),
@phone varchar(10),
@email varchar(50),
@homeTown varchar(100)
as
update NhanVien
set HoVaTenNV = @name,GioiTinhNV = @sex , SĐTNV = @phone , EmailNV = @email, QueQuanNV =@homeTown
where MaNV = @id;
GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaHoaDon]
@maHD int
as
delete HoaDonXuat where MaHDX = @maHD;
GO
/****** Object:  StoredProcedure [dbo].[XoaSanPhamKhoiCTHD]    Script Date: 6/26/2022 12:28:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaSanPhamKhoiCTHD]
@maCTHD int
as
delete ChiTietHoaDon where MaCTHD = @maCTHD;
GO
USE [master]
GO
ALTER DATABASE [QLCHQA] SET  READ_WRITE 
GO
