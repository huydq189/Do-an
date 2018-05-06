USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLHS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNS]
GO

USE [QLNS]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[TenTaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[ChucVu] [varchar](50) NOT NULL,
	[MaNV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPHIEUNHAP]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUNHAP](
	[MaPN] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgHD] [date] NOT NULL,
	[TriGia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[SDT] [char](12) NOT NULL,
	[SoTienNo] [money] NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[SDT] [char](15) NOT NULL,
	[CMND] [char](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [int] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](70) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SDT] [char](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[TongChi] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaPT] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayThu] [date] NOT NULL,
	[MaNV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[TonToiThieuTruocNhap] [int] NOT NULL,
	[SoLuongNhapItNhat] [int] NOT NULL,
	[NoToiDa] [money] NOT NULL,
	[TonToiThieuSauBan] [int] NOT NULL,
	[QDThuTien] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 5/6/2018 5:22:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[MaNXB] [int] NOT NULL,
	[TenSach] [nvarchar](70) NOT NULL,
	[TacGia] [nvarchar](70) NOT NULL,
	[TheLoai] [nvarchar](100) NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINNO]    Script Date: 5/6/2018 5:22:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINNO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayNo] [date] NOT NULL,
	[NoDau] [money] NOT NULL,
	[NoCuoi] [money] NOT NULL,
	[PhatSinh] [money] NOT NULL,
	[MaKH] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGTINTONKHO]    Script Date: 5/6/2018 5:22:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINTONKHO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[TonDau] [int] NOT NULL,
	[TonPhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([MaHD], [MaSach], [SoLuong]) VALUES (1, 2, 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSach], [SoLuong]) VALUES (1, 5, 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSach], [SoLuong]) VALUES (2, 1, 1)
INSERT [dbo].[CTHD] ([MaHD], [MaSach], [SoLuong]) VALUES (3, 1, 2)
INSERT [dbo].[CTHD] ([MaHD], [MaSach], [SoLuong]) VALUES (3, 2, 1)
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [NgHD], [TriGia]) VALUES (1, 1, 1, CAST(N'2018-06-05' AS Date), 435.7500)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [NgHD], [TriGia]) VALUES (2, 1, 1, CAST(N'2018-06-05' AS Date), 105.0000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [NgHD], [TriGia]) VALUES (3, 1, 1, CAST(N'2018-06-05' AS Date), 420.0000)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [HoTen], [SDT], [SoTienNo], [Email]) VALUES (1, N'KH mua lẻ', N'123546      ', 0.0000, N'Tkobietboi@something.com')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [SDT], [CMND]) VALUES (1, N'Ngyễn Văn A', N'012345678      ', N'123546465           ')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (1, N'Nhà Xuất Bản Trẻ', N'ABC', N'012346789      ')
SET IDENTITY_INSERT [dbo].[NXB] OFF
SET IDENTITY_INSERT [dbo].[SACH] ON 

INSERT [dbo].[SACH] ([MaSach], [MaNXB], [TenSach], [TacGia], [TheLoai], [DonGia], [SoLuong]) VALUES (1, 1, N'Forever 20', N'VA', N'Văn học phương Tây', 100.0000, 198)
INSERT [dbo].[SACH] ([MaSach], [MaNXB], [TenSach], [TacGia], [TheLoai], [DonGia], [SoLuong]) VALUES (2, 1, N'City of stars', N'VB', N'Văn học phương Tây', 200.0000, 200)
INSERT [dbo].[SACH] ([MaSach], [MaNXB], [TenSach], [TacGia], [TheLoai], [DonGia], [SoLuong]) VALUES (3, 1, N'Paper Cities', N'VC', N'Văn học phương Tây', 150.0000, 150)
INSERT [dbo].[SACH] ([MaSach], [MaNXB], [TenSach], [TacGia], [TheLoai], [DonGia], [SoLuong]) VALUES (4, 1, N'SGK Toán', N'VC', N'Sách giáo khoa', 10.0000, 150)
INSERT [dbo].[SACH] ([MaSach], [MaNXB], [TenSach], [TacGia], [TheLoai], [DonGia], [SoLuong]) VALUES (5, 1, N'SGK Lý 10', N'VC', N'Sách giáo khoa', 15.0000, 150)
SET IDENTITY_INSERT [dbo].[SACH] OFF
ALTER TABLE [dbo].[HOADON] ADD  DEFAULT (getdate()) FOR [NgHD]
GO
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
ALTER TABLE [dbo].[PHIEUTHU] ADD  DEFAULT (getdate()) FOR [NgayThu]
GO
ALTER TABLE [dbo].[THONGTINNO] ADD  DEFAULT (getdate()) FOR [NgayNo]
GO
ALTER TABLE [dbo].[THONGTINTONKHO] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CTPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPN])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHU]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[THONGTINNO]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[THONGTINTONKHO]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
