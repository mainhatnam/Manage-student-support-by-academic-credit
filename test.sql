﻿CREATE DATABASE test
GO	
USE test
GO 
CREATE TABLE KHOACHUYENNGANH 
(

MAKHOA INT IDENTITY(1,1) PRIMARY KEY,
TENKHOA NVARCHAR(50) NOT NULL
)
CREATE TABLE PHANQUYEN 
(
MAQUYEN INT IDENTITY(1,1) PRIMARY KEY,
TENQUYEN NVARCHAR(30) NOT NULL, 
)
CREATE TABLE GIAOVIEN
(
MAGV INT IDENTITY(1,1) PRIMARY KEY,
TAIKHOAN NVARCHAR(20) NOT NULL,
MATKHAU NVARCHAR(20) NOT NULL,
TENGV NVARCHAR(50) NOT NULL,
GIOITINH NVARCHAR(10) NOT NULL,
MAKHOA int NOT NULL,
MAQUYEN INT NOT NULL  CONSTRAINT kiemtra CHECK(MAQUYEN != 2),
FOREIGN KEY (MAKHOA) REFERENCES dbo.KHOACHUYENNGANH(MAKHOA),
FOREIGN KEY (MAQUYEN) REFERENCES dbo.PHANQUYEN(MAQUYEN)
)
CREATE TABLE KHOA 
(

MAKHOASV INT IDENTITY(1,1) PRIMARY KEY,
TENKHOASV NVARCHAR(50) NOT NULL,
TINCHIHT INT NOT NULL
)
CREATE TABLE TINCHI
(
	MATC INT IDENTITY(1,1) PRIMARY KEY,
	TENTC NVARCHAR(50) NOT NULL,
	TIENTC BIGINT NOT NULL
)
CREATE TABLE MONHOC
(

MAMON INT IDENTITY(1,1) PRIMARY KEY,
TENMON NVARCHAR(50) NOT NULL,
TCMON INT NOT NULL,
TONGTIEN BIGINT NOT NULL,
MAKHOA INT NOT NULL,
MATC INT NULL
FOREIGN KEY (MAKHOA) REFERENCES dbo.KHOACHUYENNGANH(MAKHOA),
FOREIGN KEY (MATC) REFERENCES dbo.TINCHI(MATC)
)
CREATE TABLE HOCKYNAMHOC
(
MAHKNH INT IDENTITY(1,1) PRIMARY KEY,
TENHKNH NVARCHAR(50) NOT NULL
)
CREATE TABLE SINHVIEN
(
MASV INT IDENTITY(1,1) PRIMARY KEY,
TAIKHOANSV NVARCHAR(30) NOT NULL,
MATKHAUSV VARCHAR(30) NOT NULL,
TENSV NVARCHAR(50) NOT NULL,
GIOITINHSV NVARCHAR(10) NOT NULL,
NAMSINH DATE NOT NULL,
MAKHOASV INT NOT NULL,
MAKHOA INT NOT NULL,
MAQUYEN INT NOT NULL,
FOREIGN KEY (MAKHOASV) REFERENCES dbo.KHOA (MAKHOASV),
FOREIGN KEY (MAKHOA) REFERENCES dbo.KHOACHUYENNGANH (MAKHOA),
FOREIGN KEY (MAQUYEN) REFERENCES dbo.PHANQUYEN(MAQUYEN)
)
CREATE TABLE MONHOCSV
(
MAMHSV INT IDENTITY(1,1) PRIMARY KEY,
MAMON INT NOT NULL,
MASV INT NOT NULL,
MAHKNH INT NOT NULL,
FOREIGN KEY(MAMON) REFERENCES dbo.MONHOC(MAMON),
FOREIGN KEY (MASV) REFERENCES dbo.SINHVIEN(MASV),
FOREIGN KEY (MAHKNH) REFERENCES dbo.HOCKYNAMHOC(MAHKNH)
)

CREATE TABLE CHAMDIEMSV
(
MACD INT IDENTITY(1,1) PRIMARY KEY,
MAMHSV INT  NOT NULL,
DIEMQT FLOAT NOT NULL ,
DIEMGK FLOAT NOT NULL ,
DIEMTHI FLOAT NOT NULL,
DIEMHP FLOAT NOT NULL ,
DIEMCHU NVARCHAR(10) NOT NULL,
HE4 FLOAT NOT NULL,
GHICHU NVARCHAR(20) NOT NULL DEFAULT('KHONG'),
FOREIGN KEY (MAMHSV) REFERENCES dbo.MONHOCSV(MAMHSV)
)



----------------------------------
INSERT INTO dbo.PHANQUYEN
(
    TENQUYEN
)
VALUES
(N'GIÁO VIÊN' -- TENQUYEN - nvarchar(30)
    ),
(N'HỌC SINH' -- TENQUYEN - nvarchar(30)
    ),
(N'QUẢN TRỊ' -- TENQUYEN - nvarchar(30)
    )
----------------------------------
INSERT INTO dbo.KHOACHUYENNGANH
(
    TENKHOA
)
VALUES
(N'Công Nghệ Thông Tin' -- TENKHOA - nvarchar(50)
    )
--------------------------------
INSERT INTO dbo.GIAOVIEN
(
    TAIKHOAN,
    MATKHAU,
    TENGV,
    GIOITINH,
    MAKHOA,
    MAQUYEN
)
VALUES
(   N'admin', -- TAIKHOAN - nvarchar(20)
    N'123456', -- MATKHAU - nvarchar(20)
    N'admin', -- TENGV - nvarchar(50)
    N'Nam', -- GIOITINH - nvarchar(10)
    1,   -- MAKHOA - int
    3    -- MAQUYEN - int
    ),
	(
	 N'giaovien', -- TAIKHOAN - nvarchar(20)
    N'123456', -- MATKHAU - nvarchar(20)
    N'giaovien', -- TENGV - nvarchar(50)
    N'Nam', -- GIOITINH - nvarchar(10)
    1,   -- MAKHOA - int
    1    -- MAQUYEN - int
	)