CREATE DATABASE QLKS
USE QLKS
 
CREATE TABLE PHONG(
	MaPhong VARCHAR(5) PRIMARY KEY NOT NULL,
	TenPhong NVARCHAR(50) NOT NULL, 
	MaLoaiP CHAR(2),
	TinhTrang NVARCHAR(100) NOT NULL,
	GhiChu NVARCHAR(100)
)


CREATE TABLE LOAIPHONG(
	MaLoaiP CHAR(2) PRIMARY KEY NOT NULL,
	TenLoaiP NVARCHAR(50),
	GiaGioDau MONEY,
	GiaQuaDem MONEY NOT NULL

)

CREATE TABLE KHACHHANG(
	MaKH INT IDENTITY(1,1) primary key not null,
	TenKH NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(20),
	CMND VARCHAR(12),
	DiaChi NVARCHAR(100)
)



CREATE TABLE NHANVIEN(
	MaNV CHAR(4) PRIMARY KEY NOT NULL,
	TenNV NVARCHAR(100),
	NamSinh int,
	GioiTinh NVARCHAR(20),
	ChucVu NVARCHAR(50),
	SDT int,
	DiaChi NVARCHAR(100),
	GhiChu NVARCHAR(100),
	MatKhau varchar(50)
)


CREATE TABLE DICHVU(
	MaDV NVARCHAR(5) PRIMARY KEY NOT NULL,
	TenDV NVARCHAR(100),
	DonGia MONEY NOT NULL,
	TinhTrang NVARCHAR(100)
)

CREATE TABLE PHIEUTHUEPHONG(
	MaPhieuThue int identity(1,1) primary key not null,
	MaPhong VARCHAR(5) NOT NULL,
	MaKH int,
	NgayBDThue SMALLDATETIME NOT NULL,
	NgayKTThue SMALLDATETIME,
	KhachNuocNgoai int,
	SoLuongKH tinyint NOT NULL,  
	MaNV CHAR(4),
	TinhTrangPhieu int

)



CREATE TABLE HOADON(
	MaHD int identity(1,1) primary key not null,
	MaPhieuThue int,
	TienDichVu money, 
	TienThuePhong money,
	NgayHD smalldatetime,
	TriGia MONEY,
	MaNV char(4) references NhanVien(MaNV)
)




CREATE TABLE PHIEUDICHVU(
	MaPhieuDV int identity(1,1) primary key,
	MaHD int,
	TriGia money,
	NgayLap smalldatetime
)


CREATE TABLE CT_PHIEUDICHVU(
	MaPhieuDV int,
	MaDV Nvarchar(5),
	SoLuong int,
	ThanhTien money,
	primary key(MaPhieuDV,MaDV)
)	





CREATE TABLE BCDOANHTHU(
	MaBC int identity(1,1),
	MaHD int,
	DoanhThu MONEY,
 )





 ALTER TABLE PHONG			ADD CONSTRAINT FK_PHONG_LOAIPHONG	FOREIGN KEY(MaLoaiP)	REFERENCES LOAIPHONG(MaLoaiP)
 
 ALTER TABLE PHIEUTHUEPHONG	ADD CONSTRAINT FK_PTHUEP_PHONG		FOREIGN KEY(MaPhong)	REFERENCES PHONG(MaPhong)

 ALTER TABLE PHIEUTHUEPHONG	ADD CONSTRAINT FK_PTHUEP_KHACHHANG	FOREIGN KEY(MAKH)		REFERENCES KHACHHANG(MAKH)
 
 ALTER TABLE PHIEUTHUEPHONG	ADD CONSTRAINT FK_PTHUEP_NHANVIEN	FOREIGN KEY(MaNV)		REFERENCES NHANVIEN(MaNV)
	
 ALTER TABLE HOADON			ADD CONSTRAINT FK_HOADON_PTHUEP		FOREIGN KEY(MaPhieuThue)REFERENCES PHIEUTHUEPHONG(MaPhieuThue)

 ALTER TABLE PHIEUDICHVU		ADD CONSTRAINT FK_HDDV_HOADON		FOREIGN KEY(MaHD)		REFERENCES HOADON(MaHD)

 ALTER TABLE CT_PHIEUDICHVU		ADD CONSTRAINT FK_CTDV_PDV			FOREIGN KEY(MaPhieuDV)		REFERENCES PHIEUDICHVU(MaPhieuDV)

 ALTER TABLE CT_PHIEUDICHVU ADD CONSTRAINT FK_CTDV_DV		FOREIGN KEY(MaDV)   REFERENCES DICHVU(MaDV)

 ALTER TABLE BCDOANHTHU		ADD CONSTRAINT FK_BCDOANHTHU_HOADON FOREIGN KEY(MaHD)		REFERENCES HOADON(MaHD)


 ALTER TABLE NHANVIEN ADD CONSTRAINT Check_Tuoi CHECK (NamSinh between 1966 and 1998 )

SET DATEFORMAT DMY

 
INSERT INTO LOAIPHONG VALUES ('T1',N'Thường đơn', '60000', '80000')
INSERT INTO LOAIPHONG VALUES ('T2',N'Thường đôi', '100000', '140000')
INSERT INTO LOAIPHONG VALUES ('V1',N'VIP đơn', '150000', '200000')
INSERT INTO LOAIPHONG VALUES ('V2',N'VIP đôi', '220000', '250000')




INSERT INTO PHONG VALUES ('P101',N'Phòng 101','V1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P102',N'Phòng 102','V1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P103',N'Phòng 103','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P104',N'Phòng 104','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P105',N'Phòng 105','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P106',N'Phòng 106','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P107',N'Phòng 107','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P108',N'Phòng 108','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P109',N'Phòng 109','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P110',N'Phòng 110','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P201',N'Phòng 201','V1', N'Trống','OK')
INSERT INTO PHONG VALUES ('P202',N'Phòng 202','V1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P203',N'Phòng 203','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P204',N'Phòng 204','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P205',N'Phòng 205','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P206',N'Phòng 206','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P207',N'Phòng 207','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P208',N'Phòng 208','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P209',N'Phòng 209','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P210',N'Phòng 210','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P301',N'Phòng 301','V1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P302',N'Phòng 302','V1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P303',N'Phòng 303','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P304',N'Phòng 304','V2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P305',N'Phòng 305','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P306',N'Phòng 306','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P307',N'Phòng 307','T1', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P308',N'Phòng 308','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P309',N'Phòng 309','T2', N'Trống','OK' )
INSERT INTO PHONG VALUES ('P310',N'Phòng 310','T1', N'Trống','OK' )




INSERT INTO KHACHHANG VALUES (N'Khách hàng ảo',N'Không rõ',000000000, N'Không có')
INSERT INTO KHACHHANG VALUES (N'Nguyen Van A',N'Nam',212326455, N'Bình Sơn')
INSERT INTO KHACHHANG VALUES (N'Tran Ngoc Han',N'Nữ',53455126455, N'Quảng Ngãi')
INSERT INTO KHACHHANG VALUES (N'Tran Ngoc Linh',N'Nam',784126455, N'Sơn Tịnh')
INSERT INTO KHACHHANG VALUES (N'Tran Minh Long',N'Nữ',4562326455, N'Nha Trang')
INSERT INTO KHACHHANG VALUES (N'Le Nhat Minh',N'Nam',76546455, N'Phan Thiết')
INSERT INTO KHACHHANG VALUES (N'Le Hoai Thuong',N'Nữ',3451326455, N'Bình Định')
INSERT INTO KHACHHANG VALUES (N'Nguyen Van Tam',N'Nam',13436455, N'Huế')
INSERT INTO KHACHHANG VALUES (N'Phan Thi Thanh',N'Nam',12334526455, N'HCM')
INSERT INTO KHACHHANG VALUES (N'Le Ha Vinh',N'Nam',345326455, N'Hà Nội')
INSERT INTO KHACHHANG VALUES (N'Ha Duy Lap',N'Nam',345316455, N'Đà Nẵng')
INSERT INTO KHACHHANG VALUES (N'Nguyen Nhu Nhut',N'Nam',643326455,N'Quảng Nam')
INSERT INTO KHACHHANG VALUES (N'Le Thi Phi Yen',N'Nam',435326455, N'Phú Yên')
INSERT INTO KHACHHANG VALUES (N'Nguyen Van B',N'Nữ',4654626455, N'Thanh Hóa')
INSERT INTO KHACHHANG VALUES (N'Ngo Thanh Tuan',N'Nữ',4351236455, N'Hà Tĩnh')
INSERT INTO KHACHHANG VALUES (N'Nguyen Thi Truc Thanh',N'Nữ',212326455, N'Nghệ AN')
INSERT INTO KHACHHANG VALUES (N'Ho Thanh Son',N'Nữ',2123412455, N'Hải Phòng')
INSERT INTO KHACHHANG VALUES (N'Tran Tam Thanh',N'Nữ',432126455, N'Cà Mau')
INSERT INTO KHACHHANG VALUES (N'Do Nghiem Phung',N'Nữ',212326455, N'Bến Tre')
INSERT INTO KHACHHANG VALUES (N'Tran Nam Son',N'Nữ',212334555, N'An Giang')
INSERT INTO KHACHHANG VALUES (N'Mai Thanh Danh',N'Nữ',2112326455, N'Long An')
INSERT INTO KHACHHANG VALUES (N'Tran Doan Hung',N'Nữ',212356455, N'Vĩnh Long')






INSERT INTO NHANVIEN VALUES('NV01','Do Nghiem Phung','1987',N'Nữ',N'Quản lý', 32432123, N'Bình Sơn',  N'ok',123)
INSERT INTO NHANVIEN VALUES('NV02','Tran Nam Son','1989',N'Nam',N'Quản lý', 3123412, N'Quảng Ngãi', N'ok',123)
INSERT INTO NHANVIEN VALUES('NV03','Mai Thanh Danh','1991',N'Nam',N'Lễ Tân', 6542312, N'Đồng Nai',  N'ok',123)
INSERT INTO NHANVIEN VALUES('NV04','Tran Doan Hung','1996',N'Không rõ',N'Lễ Tân', 76423432, N'Nha Trang',  N'ok',123)
INSERT INTO NHANVIEN VALUES('NV05','Nguyen Minh Thien','1996',N'Nam',N'Lễ Tân', 14520868, N'Đồng Nai',  N'ok',123)
INSERT INTO NHANVIEN VALUES('NV06','Le Thi Tran','1986',N'Nữ',N'Lễ Tân', 234252, 'Gia Lai', N'ok',123)





INSERT INTO DICHVU VALUES('BHL',N'Bia Heieneken lon','35000',N'Còn hàng')
INSERT INTO DICHVU VALUES('BSL',N'Bia Sapporo lon','25000',N'Còn hàng')
INSERT INTO DICHVU VALUES('BTL',N'Bia Tiger lon','20000',N'Còn hàng')
INSERT INTO DICHVU VALUES('B3L',N'Bia 333 lon','17000',N'Còn hàng')
INSERT INTO DICHVU VALUES('BSGL',N'Bia Sài gòn lon','15000',N'Còn hàng')
INSERT INTO DICHVU VALUES('CCL',N'Cocacola lon','10000',N'Còn hàng')
INSERT INTO DICHVU VALUES('PSlon',N'Pepsi lon','10000',N'Còn hàng')
INSERT INTO DICHVU VALUES('MnL',N'Mirinda Cam lon','10000',N'Còn hàng')
INSERT INTO DICHVU VALUES('MXL',N'Mirinda Xá xị lon','10000',N'Còn hàng')
INSERT INTO DICHVU VALUES('NiC',N'Nutri Boost Cam ','15000',N'Còn hàng')
INSERT INTO DICHVU VALUES('NiD',N'Nutri Boost Dâu','15000',N'Còn hàng')
INSERT INTO DICHVU VALUES('Sn',N'String dâu đỏ','15000',N'Còn hàng')
INSERT INTO DICHVU VALUES('NB1',N'Number 1','25000',N'Còn hàng')
INSERT INTO DICHVU VALUES('RB',N'Redbull','30000',N'Còn hàng')
INSERT INTO DICHVU VALUES('RV',N'Revive','15000',N'Còn hàng')
INSERT INTO DICHVU VALUES('NS',N'Nước Suối','7000',N'Còn hàng')
INSERT INTO DICHVU VALUES('0D',N'Trà xanh 0 độ','15000',N'Còn hàng')




INSERT INTO PHIEUTHUEPHONG VALUES('1','P105','KH001','30-11-2016','1', null)
INSERT INTO PHIEUTHUEPHONG VALUES('2','P109','KH002','01-12-2016','2', null)
INSERT INTO PHIEUTHUEPHONG VALUES('3','P203','KH003','02-12-2016','3', null)
INSERT INTO PHIEUTHUEPHONG VALUES('4','P310','KH004','03-12-2016','2', null)
INSERT INTO PHIEUTHUEPHONG VALUES('5','P109','KH005','04-12-2016','1', null)
INSERT INTO PHIEUTHUEPHONG VALUES('6','P207','KH006','04-12-2016','2', null)
INSERT INTO PHIEUTHUEPHONG VALUES('7','P305','KH007','04-12-2016','3', null)
INSERT INTO PHIEUTHUEPHONG VALUES('8','P102','KH008','04-12-2016','3', null)
INSERT INTO PHIEUTHUEPHONG VALUES('9','P206','KH009','04-12-2016','1', null)
INSERT INTO PHIEUTHUEPHONG VALUES('10','P303','KH010','04-12-2016','2', null)
INSERT INTO PHIEUTHUEPHONG VALUES('11','P102','KH011','04-12-2016','2', null)

Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P105'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P109'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P203'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P310'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P109'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P207'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P305'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P102'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P206'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P303'
Update PHONG set TinhTrang= N'Đang sử dụng' where MaPhong = 'P102'






INSERT INTO HOADON VALUES('1','1',null, null, null)
INSERT INTO HOADON VALUES('2','2',null, null, null)
INSERT INTO HOADON VALUES('3','3',null, null, null)
INSERT INTO HOADON VALUES('4','4',null, null, null)
INSERT INTO HOADON VALUES('5','5',null, null, null)
INSERT INTO HOADON VALUES('6','6',null, null, null)
INSERT INTO HOADON VALUES('7','7',null, null, null)
INSERT INTO HOADON VALUES('8','8',null, null, null)
INSERT INTO HOADON VALUES('9','9',null, null, null)
INSERT INTO HOADON VALUES('10','10',null, null, null)
INSERT INTO HOADON VALUES('11','11',null, null, null)






INSERT INTO ACCOUNT VALUES ('admin','admin','QL')
INSERT INTO ACCOUNT VALUES ('admin1','admin1','QL')
INSERT INTO ACCOUNT VALUES ('normal1','normal1','NV')
INSERT INTO ACCOUNT VALUES ('normal2','normal2','NV')


select * FROM PHONG

UPDATE PHONG SET TinhTrang =N'Đang sử dụng' where MaPhong=N'P301'




select * from NHANVIEN
select * from ACCOUNT


SELECT MaNV, TenNV, GioiTinh,NamSinh,ChucVu, SDT, DiaChi, nv.GhiChu
FROM NHANVIEN nv

select * from NHANVIEN


Use QLKS

select* from PHONG

SELECT Distinct MaPhong, TenPhong, TenLoaiP, GiaQuaDem, GiaGioDau, lp.GhiChu
FROM PHONG p, LOAIPHONG lp
where p.MaLoaiP=lp.MaLoaiP and TenLoaiP like '%VIP%'

SELECT Distinct MaPhong, TenPhong, TenLoaiP, GiaQuaDem, GiaGioDau, lp.GhiChu
FROM PHONG p, LOAIPHONG lp
where p.MaLoaiP=lp.MaLoaiP and MaPhong like N'%VIP%' or TenPhong like N'%VIP%' 
										or TenLoaiP like N'%VIP%' or GiaQuaDem like N'%VIP%' 
										or GiaQuaDem like N'%VIP%' or lp.GhiChu like N'%VIP"%'




select * from PHIEUTHUEPHONG


select * from HOADON

SELECT MaPhieuThue, p.TenPhong, kh.TenKH, NgayBDThue, SoLuongKH
                                FROM PHIEUTHUEPHONG pt,  PHONG p, KHACHHANG kh
                                WHERE  pt.MaPhong= p.MaPhong and pt.MaKH= kh.MaKH


SELECT MaPhieuThue, p.TenPhong, kh.TenKH, NgayBDThue, SoLuongKH
                                FROM PHIEUTHUEPHONG pt,  PHONG p, KHACHHANG kh
                                WHERE  pt.MaPhong= p.MaPhong and pt.MaKH= kh.MaKH
								and MaPhieuThue like N'%" + item + "%' or p.TenPhong like N'%" + item + "%' or kh.TenKH like N'%" + item + "%' or NgayBDThue like N'%" + item + "%' or SoLuongKH like N'%" + item + "%'




		select * from HOADON


		select hd.MaHD,TenPhong, TenKH, NgayBDThue, NgayKTThue, SoLuongKH, NguoiNcNgoai, TriGia
                                from PHIEUTHUEPHONG pt, PHONG p, KHACHHANG kh, HOADON hd
                                where pt.MaPhong=p.MaPhong and pt.MaKH=kh.MaKH and pt.MaPhieuThue= hd.MaPhieuThue

USE QLKS

update HOADON set NgayKTThue=N'2-12-2016', NguoiNcNgoai='2', TriGia=N'10000' where MaHD='5'


select * from HOADON

select * from PHONG