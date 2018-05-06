﻿CREATE DATABASE QLNS
GO

USE QLNS

CREATE TABLE NXB(
	MaNXB INT IDENTITY(1,1) PRIMARY KEY,
	TenNXB NVARCHAR(70) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT CHAR(15) NOT NULL

)
GO
CREATE TABLE SACH
(
	MaSach INT IDENTITY(1,1) PRIMARY KEY,
	MaNXB int NOT NULL,
	TenSach NVARCHAR(70) NOT NULL,
	TacGia NVARCHAR(70) NOT NULL,
	TheLoai NVARCHAR(100),
	DonGia MONEY NOT NULL,
	SoLuong INT NOT NULL,

	FOREIGN KEY (MaNXB) REFERENCES NXB(MaNXB)
)
GO

CREATE TABLE NHANVIEN
(
	MaNV INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT CHAR(15) NOT NULL,
	CMND CHAR(20) NOT NULL,
)
GO

CREATE TABLE ACCOUNT
(
	TenTaiKhoan VARCHAR(50) PRIMARY KEY,
	MatKhau VARCHAR(50) NOT NULL,
	ChucVu VARCHAR(50) NOT NULL,
	MaNV INT NOT NULL,
	
	FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV) 

)
GO

CREATE TABLE PHIEUNHAP
(
	MaPN INT IDENTITY(1,1) PRIMARY KEY,
	MaNV INT NOT NULL,
	NgayNhap DATE DEFAULT GETDATE(),
	TongChi MONEY NOT NULL,

	FOREIGN KEY (MaPN) REFERENCES NHANVIEN(MaNV)
)
GO

CREATE TABLE CTPHIEUNHAP
(
	MaPN INT NOT NULL,
	MaSach INT NOT NULL,
	SoLuongNhap INT NOT NULL,
	DonGia MONEY NOT NULL,
	
	PRIMARY KEY (MaPN,MaSach),
	FOREIGN KEY (MaPN) REFERENCES PHIEUNHAP(MaPN),
	FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
)
GO

CREATE TABLE KHACHHANG(
	MaKH INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT CHAR(12) NOT NULL,
	SoTienNo MONEY,
	Email NVARCHAR(50) NOT NULL
)
GO



CREATE TABLE HOADON(
	MaHD  INT IDENTITY(1,1) PRIMARY KEY,
	MaNV int NOT NULL,
	MaKH INT NOT NULL,
	NgHD DATE DEFAULT GETDATE() NOT NULL,
	TriGia MONEY NOT NULL,

	FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

)
GO

CREATE TABLE CTHD
(
	MaHD INT  NOT NULL,
	MaSach INT  NOT NULL,
	SoLuong INT NOT NULL,
	PRIMARY KEY(MaHD,MaSach),

	FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),
	FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
	
)
GO

CREATE TABLE PHIEUTHU
(
	MaPT INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MaKH INT NOT NULL,
	NgayThu DATE DEFAULT GETDATE() NOT NULL,
	MaNV INT NOT NULL,

	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
)
GO

CREATE TABLE THONGTINNO
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NgayNo DATE DEFAULT GETDATE() NOT NULL,
	NoDau MONEY NOT NULL,
	NoCuoi MONEY NOT NULL,
	PhatSinh MONEY NOT NULL,
	MaKH INT NOT NULL,

	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH) 
)

CREATE TABLE THONGTINTONKHO
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	ThoiGian DATE DEFAULT GETDATE() NOT NULL,
	TonDau INT NOT NULL,
	TonPhatSinh INT NOT NULL,
	TonCuoi INT NOT NULL,
	MaSach INT NOT NULL,

	FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
)
GO

CREATE TABLE QUYDINH
(
	TonToiThieuTruocNhap INT NOT NULL,
	SoLuongNhapItNhat INT NOT NULL,
	NoToiDa MONEY NOT NULL,
	TonToiThieuSauBan INT NOT NULL,
	QDThuTien BIT NOT NULL
)
GO

SET DATEFORMAT DMY;
GO  


INSERT INTO NXB
                         (TenNXB, DiaChi, SDT)
VALUES        (N'Nhà Xuất Bản Trẻ',N'ABC','012346789')

INSERT INTO SACH
                         (MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        ('1',N'Forever 20','VA',N'Văn học phương Tây','100','100')

INSERT INTO SACH
                         (MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        ('1',N'City of stars','VB',N'Văn học phương Tây','200','50')

INSERT INTO SACH
                         (MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        ('1',N'Paper Cities','VC',N'Văn học phương Tây','150','150')

INSERT INTO SACH
                         (MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        ('1',N'SGK Toán','VC',N'Sách giáo khoa','10','150')

INSERT INTO SACH
                         (MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        ('1',N'SGK Lý 10','VC',N'Sách giáo khoa','15','150')

INSERT INTO NHANVIEN
                         (HoTen, SDT, CMND)
VALUES        (N'Ngyễn Văn A','012345678','123546465')

INSERT INTO KHACHHANG
                         (HoTen, SDT, Email, SoTienNo)
VALUES        (N'KH mua lẻ','123546','Tkobietboi@something.com','0')