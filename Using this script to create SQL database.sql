create database EzManage
GO

use EzManage
GO

set dateformat DMY
GO

CREATE TABLE MATKHAUNV
(
	USERNAME VARCHAR(100) PRIMARY KEY,
	PASS VARCHAR(20),
	ACCESSLEVEL INT
)
GO

INSERT INTO dbo.MATKHAUNV
(
    USERNAME,
    PASS,
    ACCESSLEVEL
)
VALUES
(   'user', -- USERNAME - varchar(100)
    '1', -- PASS - varchar(20)
    0   -- ACCESSLEVEL - int
    )
GO

INSERT INTO dbo.MATKHAUNV
(
    USERNAME,
    PASS,
    ACCESSLEVEL
)
VALUES
(   'user1', -- USERNAME - varchar(100)
    '1', -- PASS - varchar(20)
    0   -- ACCESSLEVEL - int
    )
GO

INSERT INTO dbo.MATKHAUNV
(
    USERNAME,
    PASS,
    ACCESSLEVEL
)
VALUES
(   'admin', -- USERNAME - varchar(100)
    '1', -- PASS - varchar(20)
    1   -- ACCESSLEVEL - int
    )
GO

INSERT INTO dbo.MATKHAUNV
(
    USERNAME,
    PASS,
    ACCESSLEVEL
)
VALUES
(   'admin1', -- USERNAME - varchar(100)
    '1', -- PASS - varchar(20)
    1   -- ACCESSLEVEL - int
    )
GO

SELECT * FROM dbo.MATKHAUNV

CREATE TABLE SACH -- Table lưu trữ thông tin những cuốn sách
(
MASACH varchar(50) PRIMARY KEY NOT NULL,
TENSACH nvarchar(100) NOT NULL,
TENTG nvarchar(100) NOT NULL,
NGAYXB smalldatetime NOT NULL,
LANTAIBAN int NOT NULL,
GIA int NOT NULL,
THELOAI nvarchar(100) NOT NULL,
GHICHU nvarchar(100) NOT NULL
)
GO

CREATE TABLE KHOSACH -- Table quản lý sách (số lượng, mã sách,...)
(
MASACH varchar(50) PRIMARY KEY NOT NULL,
TENSACH nvarchar(100) NOT NULL,
SOLUONG int NOT NULL,
NGAYNHAP smalldatetime NOT NULL,
GHICHU nvarchar(100) NOT NULL
)
GO


alter table KHOSACH
ADD CONSTRAINT FK_KHOSACH_SACH FOREIGN KEY (MASACH) REFERENCES SACH(MASACH)
---Thêm các ràng buộc cho bảng SACH---
alter table SACH add constraint dfLanTaiBan default(0) for LANTAIBAN
alter table SACH add constraint checkGia check (GIA>0)
alter table SACH add constraint dfTheLoai default('Khong xac dinh') for THELOAI

---Thêm các ràng buộc cho bảng KHOSACH---
alter table KHOSACH add constraint checkSoLuong check (SOLUONG>=0)
alter table KHOSACH add constraint dfNGAYNHAP default('1/1/2019') for NGAYNHAP --Ngày mở nhà sách


select * from SACH
