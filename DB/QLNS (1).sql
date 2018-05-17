CREATE DATABASE QLNS
GO

USE QLNS

CREATE TABLE NXB(
	MaNXB INT  PRIMARY KEY,
	TenNXB NVARCHAR(70) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT CHAR(15) NOT NULL

)
GO
CREATE TABLE SACH
(
	MaSach INT  PRIMARY KEY,
	MaNXB int NOT NULL,
	TenSach NVARCHAR(70) NOT NULL,
	TacGia NVARCHAR(70) NOT NULL,
	TheLoai NVARCHAR(100),
	DonGia MONEY NOT NULL,
	SoLuong INT NOT NULL,

	FOREIGN KEY (MaNXB) REFERENCES NXB(MaNXB)
)
GO
CREATE PROC SP_THEMSACH
	@TenSach nvarchar(70),
	@TacGia nvarchar(70),
	@TheLoai nvarchar(100),
	@DonGia money,
	@SoLuong int
	AS
	BEGIN
	INSERT INTO SACH(TenSach,TacGia,TenSach,DonGia,SoLuong)
	VALUES (@TenSach,@TacGia,@TenSach,@DonGia,@SoLuong)
	END
GO
CREATE PROC SP_BANSACH
	@MaSach int,
	@n int
	AS
	BEGIN
		IF EXISTS (SELECT *FROM SACH WHERE MaSach=@MaSach and SoLuong -@n > 0)
		BEGIN
			UPDATE SACH SET SoLuong = SoLuong -@n WHERE MaSach =@MaSach
		END
		ELSE
		BEGIN
			RETURN
		END
	END
GO
CREATE PROC SP_XOASACH
	@MaSach int,
	@n int
	AS
	BEGIN
		DELETE FROM SACH WHERE MaSach=@MaSach
	END
GO
CREATE PROC SP_LOADSACH
	AS
	BEGIN
		SELECT * FROM SACH
	END
GO
CREATE PROC SP_TIMSACHMASACH
@MaSach int
	AS
	BEGIN
		SELECT *FROM SACH WHERE SACH.MaSach=@MaSach
	END
GO
CREATE PROC SP_TIMSACHTENSACH
@TenSach nvarchar(70)
	AS
	BEGIN
		SELECT *FROM SACH WHERE SACH.TenSach=@TenSach
	END
GO
CREATE PROC SP_TIMSACHTACGIA
@TacGia nvarchar(70)
	AS
	BEGIN 
		SELECT *FROM SACH WHERE SACH.TacGia=@TacGia
	END
GO
CREATE PROC SP_TIMSACHTHELOAI
@TheLoai nvarchar(100)
	AS
	BEGIN
		SELECT * FROM SACH WHERE SACH.TheLoai=@TheLoai
	END
GO
CREATE TABLE NHANVIEN
(
	MaNV INT  PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT CHAR(15) NOT NULL,
	CMND CHAR(20) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL
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
	MaPN INT  PRIMARY KEY,
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
	MaKH INT  PRIMARY KEY,
	HoTen NVARCHAR(50) NOT NULL,
	SDT CHAR(12) NOT NULL,
	SoTienNo MONEY DEFAULT 0,
	Email NVARCHAR(50) NOT NULL,
	CMND CHAR(15) NOT NULL,
	NgaySinh DATE NOT NULL
)
GO



CREATE TABLE HOADON(
	MaHD INT  PRIMARY KEY,
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
	MaPT INT  PRIMARY KEY NOT NULL,
	MaKH INT NOT NULL,
	NgayThu DATE DEFAULT GETDATE() NOT NULL,
	MaNV INT NOT NULL,

	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
)
GO

CREATE TABLE THONGTINNO
(
	ID INT  PRIMARY KEY,
	NgayNo DATE DEFAULT GETDATE() NOT NULL,
	NoDau MONEY NOT NULL,
	NoCuoi MONEY NOT NULL,
	PhatSinh MONEY NOT NULL,
	MaKH INT NOT NULL,

	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH) 
)

CREATE TABLE THONGTINTONKHO
(
	ID INT  PRIMARY KEY,
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
                         (MaNXB,TenNXB, DiaChi, SDT)
VALUES        (1,N'Nhà Xuất Bản Trẻ',N'ABC','012346789')

INSERT INTO SACH
                         (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        (1,'1',N'Forever 20','VA',N'Văn học phương Tây','100','100')

INSERT INTO SACH
                         (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        (2,'1',N'City of stars','VB',N'Văn học phương Tây','200','50')

INSERT INTO SACH
                         (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        (3,'1',N'Paper Cities','VC',N'Văn học phương Tây','150','150')

INSERT INTO SACH
                         (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        (4,'1',N'SGK Toán','VC',N'Sách giáo khoa','10','150')

INSERT INTO SACH
                         (MaSach,MaNXB, TenSach, TacGia, TheLoai, DonGia,SoLuong)
VALUES        (5,'1',N'SGK Lý 10','VC',N'Sách giáo khoa','15','150')

INSERT INTO NHANVIEN
                         (MaNV,HoTen, SDT, CMND,NgaySinh, DiaChi)
VALUES        (1,N'Ngyễn Văn A','012345678','123546465','15/6/1999','TP HCM')

INSERT INTO KHACHHANG
                         (MaKH,HoTen, SDT, Email, SoTienNo, NgaySinh,CMND)
VALUES        (1,N'KH mua lẻ','123546','Tkobietboi@something.com','0','11/2/1998','131213')

 INSERT INTO QUYDINH
                         (TonToiThieuTruocNhap, SoLuongNhapItNhat, NoToiDa, TonToiThieuSauBan, QDThuTien)
VALUES        (300,150,20,20,'TRUE')


INSERT INTO ACCOUNT
                         (TenTaiKhoan, MatKhau, ChucVu, MaNV)
VALUES        ('admin','admin','admin',1)