-- BBMS
-- CREATE DATABASE
CREATE DATABASE BBMS
ON PRIMARY
(
	NAME = 'BBMS_Primary',
	FILENAME = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS.mdf',
	SIZE = 10MB,
	FILEGROWTH = 20%,
	MAXSIZE = 50MB
)
LOG ON
(
	NAME = 'BBMS_log',
	FILENAME = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS_log.ldf',
	SIZE = 10MB,
	FILEGROWTH = 10%,
	MAXSIZE = 20MB
)
GO
-- SET RECOVERY
ALTER DATABASE BBMS SET RECOVERY FULL
GO
-- USE DATABASE
USE BBMS
GO
-- CREATE TABLE NguoiHienMau
CREATE TABLE NguoiHienMau (
MaNHM INT NOT NULL PRIMARY KEY IDENTITY,
Ho NVARCHAR(50) NOT NULL,
Ten NVARCHAR(10) NOT NULL,
NgaySinh DATE NOT NULL,
DiaChi NVARCHAR(200) NOT NULL,
GioiTinh BIT NOT NULL,
SDT VARCHAR(10) NOT NULL,
Email VARCHAR(320) NOT NULL
)
GO
-- CREATE TABLE KhoMau
CREATE TABLE KhoMau (
MaKho INT NOT NULL PRIMARY KEY IDENTITY,
TenKho NVARCHAR(20) NOT NULL,
DiaChi NVARCHAR(200) NOT NULL
)
GO
-- CREATE TABLE BenhVien
CREATE TABLE BenhVien (
MaBV INT NOT NULL PRIMARY KEY IDENTITY,
TenBV NVARCHAR(20) NOT NULL,
DiaChi NVARCHAR(200) NOT NULL
)
GO
-- CREATE TABLE BenhNhan
CREATE TABLE BenhNhan (
MaBN INT NOT NULL PRIMARY KEY IDENTITY,
Ho NVARCHAR(50) NOT NULL,
Ten NVARCHAR(10) NOT NULL,
NgaySinh DATE NOT NULL,
DiaChi NVARCHAR(200) NOT NULL,
GioiTinh BIT NOT NULL,
NhomMau VARCHAR(2) NOT NULL,
SDT VARCHAR(10) NOT NULL,
Email VARCHAR(320) NOT NULL,
MaBV INT NOT NULL,
FOREIGN KEY (MaBV) REFERENCES BenhVien(MaBV)
)
GO
-- CREATE TABLE XuatKho
CREATE TABLE XuatKho (
MaXK INT NOT NULL PRIMARY KEY IDENTITY,
MaBV INT NOT NULL,
FOREIGN KEY (MaBV) REFERENCES BenhVien(MaBV)
)
GO
-- CREATE TABLE KhoMau_XuatKho
CREATE TABLE KhoMau_XuatKho (
MaKho INT NOT NULL,
MaXK INT NOT NULL,
PRIMARY KEY (MaKho, MaXK),
FOREIGN KEY (MaKho) REFERENCES KhoMau(MaKho),
FOREIGN KEY (MaXK) REFERENCES XuatKho(MaXK)
)
GO
-- CREATE TABLE ThanhToan
CREATE TABLE ThanhToan (
MaTT INT NOT NULL PRIMARY KEY IDENTITY,
MaBV INT,
FOREIGN KEY (MaBV) REFERENCES BenhVien(MaBV),
MaBN INT,
FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN),
TongGiaTien MONEY NOT NULL
)
-- CREATE TABLE TuiMau
CREATE TABLE TuiMau (
MaTM INT NOT NULL PRIMARY KEY IDENTITY,
NhomMau VARCHAR(2) NOT NULL,
MaNHM INT NOT NULL,
FOREIGN KEY (MaNHM) REFERENCES NguoiHienMau(MaNHM),
NgayLayMau DATE NOT NULL,
NgayHetHan DATE NOT NULL,
MaKho INT,
FOREIGN KEY (MaKho) REFERENCES KhoMau(MaKho),
NgayNhapKho DATE,
MaXK INT,
FOREIGN KEY (MaXK) REFERENCES XuatKho(MaXK),
NgayXuatKho DATE,
MaTT INT
FOREIGN KEY (MaTT) REFERENCES ThanhToan(MaTT)
)
GO
-- CREATE TABLE KetQuaXetNghiem
CREATE TABLE KetQuaXetNghiem (
MaXN INT NOT NULL PRIMARY KEY IDENTITY,
MaTM INT NOT NULL,
FOREIGN KEY (MaTM) REFERENCES TuiMau(MaTM),
NgayXetNghiem DATE NOT NULL,
MauNhiemBenh BIT NOT NULL
)
GO
-- ADD DATA TO NguoiHienMau
INSERT INTO NguoiHienMau (Ho, Ten, NgaySinh, DiaChi, GioiTinh, SDT, Email)
VALUES (N'Võ Sơn', N'Tùng', '2000-12-20', N'202 Đ. Hoàng Văn Thụ, Phường 9, Phú Nhuận, Thành phố Hồ Chí Minh, Việt Nam', 1, '0851542454', 'tung.vs@gmail.com'),
	(N'Thoa Thành', N'Vinh', '2001-06-10', N'37 Phan Thúc Duyện, Phường 4, Tân Bình, Thành phố Hồ Chí Minh 700000, Việt Nam', 1, '0357548787', 'vinh.tt@gmail.com'),
	(N'Nguyễn Phương', N'Triều', '1997-05-06', N'69-69A Đường A4, Phường 12, Tân Bình, Thành phố Hồ Chí Minh 700000, Việt Nam', 1, '0157877871', 'trieu.np@gmail.com'),
	(N'Tạ Chấn', N'Phong', '1989-08-01', N'794 Đ. Âu Cơ, Phường 10, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 1, '0945454215', 'phong.tc@gmail.com'),
	(N'Ngọc Hoàng', N'Minh', '1995-10-09', N'624 Lạc Long Quân, Phường 5, Quận 11, Thành phố Hồ Chí Minh, Việt Nam', 1, '0935462145', 'minh.nh@gmail.com'),
	(N'Hề Minh', N'Khang', '2003-11-02', N'84C Hòa Bình, Phường 5, Quận 11, Thành phố Hồ Chí Minh, Việt Nam', 1, '0954875164', 'khang.hm@gmail.com'),
	(N'Ong Quang', N'Bửu', '2004-10-10', N'145-145B Thạch Lam, Phú Thạnh, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 1, '0754871544', 'buu.oq@gmail.com'),
	(N'Chu Công', N'Bằng', '1988-03-04', N'8A Đ. Gò Xoài, Bình Hưng Hoà A, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0915484213', 'bang.cc@gmail.com'),
	(N'Nghiêm Việt', N'Anh', '2001-12-25', N'909 TL10, Bình Trị Đông B, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0546414646', 'anh.nv@gmail.com'),
	(N'Luyện Kiên', N'Bình', '2002-07-04', N'228 Đ. Trần Văn Giàu, Bình Trị Đông B, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0354566545', 'binh.lk@gmail.com'),
	(N'Khuất Hữu', N'Canh', '2001-11-28', N'221 Đ. Số 1, Bình Trị Đông B, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0546465464', 'canh.kh@gmail.com'),
	(N'Danh Minh', N'Hào', '1994-12-30', N'65 Đường số 19, Bình Trị Đông B, Bình Tân, Thành phố Hồ Chí Minh 123456, Việt Nam', 1, '0121313245', 'hao.dm@gmail.com'),
	(N'Tôn Việt', N'Nhân', '1992-02-21', N'52-54 Đường số 14, An Lạc A, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0864156541', 'nhan.tv@gmail.com'),
	(N'Đống Kim', N'Phú', '1994-05-31', N'223 Đ. Số 6, An Lạc A, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0414541564', 'phu.dk@gmail.com'),
	(N'Liên Minh', N'Tú', '2002-06-14', N'45 Đường số 6A, Bình Trị Đông B, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0224534646', 'tu.lm@gmail.com'),
	(N'Ngọc Minh', N'Thái', '2001-10-13', N'213e Phan Anh, Bình Trị Đông, Bình Tân, Thành phố Hồ Chí Minh, Việt Nam', 1, '0344564456', 'thai.nm@gmail.com'),
	(N'Lý Bích', N'Hảo', '1996-07-20', N'199 Hoàng Hoa Thám, Phường 13, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0454614464', 'hao.lb@gmail.com'),
	(N'Lò Giáng', N'Ngọc', '1993-02-25', N'155 Hoàng Hoa Thám, Phường 13, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0702641124', 'ngoc.lg@gmail.com'),
	(N'Điền Kiều', N'Mỹ', '1996-07-20', N'622/44 Đ. Cộng Hòa, Phường 15, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0654444454', 'my.dk@gmail.com'),
	(N'Bế Lam', N'Tuyền', '1999-11-14', N'321 Đ. Tân Kỳ Tân Quý, Tân Quý, Thành phố Hồ Chí Minh, 700000, Việt Nam', 0, '0154544984', 'tuyen.bl@gmail.com'),
	(N'Lô Phước', N'Huệ', '1995-12-14', N'12/32 Đ. Tân Kỳ Tân Quý, Sơn Kỳ, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0401545264', 'hue.lp@gmail.com'),
	(N'Đăng Thanh', N'Hường', '1994-08-16', N'130 Nguyễn Cửu Đàm, Tân Sơn Nhì, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0636465461', 'huong.dt@gmail.com'),
	(N'Thẩm Thảo', N'Nghi', '1994-04-08', N'338 Đ. Tân Sơn Nhì, Tân Sơn Nhì, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0715484548', 'nghi.tt@gmail.com'),
	(N'Lô Tố', N'Quyên', '1991-02-12', N'69 Đ. Yên Đỗ, Tân Thành, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0215451141', 'quyen.lt@gmail.com'),
	(N'Thôi Diệu', N'Hồng', '1993-10-20', N'38 Đ. Vườn Lài, Tân Thành, Tân Phú, Thành phố Hồ Chí Minh 700000, Việt Nam', 0, '0615464465', 'hong.td@gmail.com'),
	(N'Tôn Thất Hồng', N'Linh', '2000-08-20', N'19 Lê Văn Phan, Phú Thọ Hoà, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0542156461', 'linh.tth@gmail.com'),
	(N'Giàng Kim', N'Quyên', '1994-12-01', N'44 Đ. Vườn Lài, Tân Thành, Tân Phú, Thành phố Hồ Chí Minh, Việt Nam', 0, '0802156221', 'quyen.gk@gmail.com'),
	(N'Hứa Mai', N'Liên', '1996-10-07', N'117 Trương Công Định, Phường 14, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0520322565', 'lien.hm@gmail.com'),
	(N'Ngân Quỳnh', N'Dung', '1996-12-10', N'24 Bàu Cát 7, Phường 14, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0714656559', 'dung.nq@gmail.com'),
	(N'Tri Thanh', N'Kiều', '2000-03-20', N'772 Đ. Âu Cơ, Phường 14, Tân Bình, Thành phố Hồ Chí Minh 700000, Việt Nam', 0, '0310654646', 'kieu.tt@gmail.com'),
	(N'Lâm Thiên', N'Phương', '2003-04-04', N'740 Đ. Âu Cơ, Phường 13, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', 0, '0135465464', 'phuong.lt@gmail.com'),
	(N'Chử Ý', N'Bình', '2001-10-31', N'36/6 Tự Lập, Phường 4, Tân Bình, Thành phố Hồ Chí Minh 700000, Việt Nam', 0, '0523475563', 'binh.cy@gmail.com');
GO
-- SHOW TABLE
SELECT * FROM NguoiHienMau
GO
-- BACKUP
BACKUP DATABASE BBMS
TO DISK = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS.bak'
GO
BACKUP LOG BBMS
TO DISK = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS_log.trn'
GO
-- RESTORE
RESTORE DATABASE BBMS
FILE = 'BBMS_Primary'
FROM DISK = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS.bak'
WITH NORECOVERY
GO
RESTORE LOG BBMS
FROM DISK = 'D:\DRIVE\Shared\BloodBankManagementSystem\Database\BBMS_log.trn'
WITH RECOVERY
GO
-- DROP DATABASE
DROP DATABASE IF EXISTS BBMS
GO