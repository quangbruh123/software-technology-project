CREATE DATABASE GarageManagement
USE GarageManagement

CREATE TABLE HIEUXE (
	MaHieuXe	INT IDENTITY (1, 1) PRIMARY KEY,
	TenHieuXe	NVARCHAR(MAX)
)

CREATE TABLE XE (
	BienSo			NVARCHAR(50) PRIMARY KEY,
	TenChuXe		NVARCHAR(MAX),
	MaHieuXe		INT,
	DienThoai		NVARCHAR(20),
	DiaChi			NVARCHAR(MAX),
	Email			NVARCHAR(MAX),
	NgayTiepNhan	DATETIME,
	TienNo			BIGINT DEFAULT 0
)

CREATE TABLE PHIEUSUACHUA (
	MaPhieuSC	INT IDENTITY (1, 1)  PRIMARY KEY,
	BienSo		NVARCHAR(50),
	NgaySuaChua	SMALLDATETIME,
	TongTien	BIGINT DEFAULT 0
)

CREATE TABLE CT_PSC (
	MaCTPSC		INT IDENTITY (1, 1)  PRIMARY KEY,
	MaPhieuSC	INT,
	NoiDung		NVARCHAR(MAX),
	SoLan		INT DEFAULT 1,
	MaTienCong	INT,
	ThanhTien	BIGINT DEFAULT 0
)

CREATE TABLE CT_SUDUNGVATTU (
	MaCTPSC		INT,
	MaVatTu		INT,
	SoLuong		INT,
	DonGia		BIGINT,
	ThanhTien	BIGINT DEFAULT 0,
	CONSTRAINT CT_SDVT_PK PRIMARY KEY (MaCTPSC, MaVatTu)
)

CREATE TABLE VATTU (
	MaVatTu			INT IDENTITY (1, 1)  PRIMARY KEY,
	TenVatTu		NVARCHAR(MAX),
	DonGiaHienTai	BIGINT DEFAULT 0,
	SoLuongTon		INT
)

CREATE TABLE TIENCONG (
	MaTienCong	INT IDENTITY (1, 1)  PRIMARY KEY,
	TenTienCong	NVARCHAR(MAX),
	GiaTienCong BIGINT
)

CREATE TABLE PHIEUTHUTIEN (
	MaPTT		INT IDENTITY (1, 1)  PRIMARY KEY,
	NgayLap		SMALLDATETIME,
	BienSo		NVARCHAR(50),
	SoTienThu	BIGINT DEFAULT 0
)

CREATE TABLE PHIEUNHAPVATTU (
	MaPhieuNhap		INT IDENTITY (1, 1)  PRIMARY KEY,
	NgayNhap		SMALLDATETIME,
	TongTien		BIGINT DEFAULT 0
)

CREATE TABLE CT_PNVT (
	MaPhieuNhap	INT,
	MaVatTu		INT,
	SoLuong		INT,
	DonGiaNhap	BIGINT,
	DonGiaBan	BIGINT,
	ThanhTien	BIGINT DEFAULT 0,
	CONSTRAINT CT_PNVT_PK PRIMARY KEY (MaPhieuNhap, MaVatTu)
)

CREATE TABLE BAOCAOTON (
	MaBCT		INT IDENTITY (1, 1)  PRIMARY KEY,
	MaVatTu		INT,
	Thang		INT,
	Nam			INT,
	TonDau		INT,
	PhatSinh	INT DEFAULT 0,
	TonCuoi		INT,
)

CREATE TABLE BAOCAODOANHSO (
	MaBCDS			INT IDENTITY (1, 1)  PRIMARY KEY,
	Thang			INT,
	Nam				INT,
	TongDoanhThu	BIGINT DEFAULT 0
)

CREATE TABLE CT_BCDS (
	MaBCDS		INT,
	MaHieuXe	INT,
	SoLuotSua	INT DEFAULT 0,
	ThanhTien	BIGINT DEFAULT 0
	CONSTRAINT CT_BCDS_PK PRIMARY KEY (MaBCDS, MaHieuXe)
)

CREATE TABLE THAMSO (
	TenThamSo	NVARCHAR(50) PRIMARY KEY,
	GiaTri		INT
)

CREATE TABLE TAIKHOAN (
    MaTaiKhoan	INT IDENTITY (1, 1) PRIMARY KEY,
    HoTen       NVARCHAR(MAX),
    GioiTinh    NVARCHAR(10),
    TenTaiKhoan	NVARCHAR(MAX),
    Email       NVARCHAR(MAX) DEFAULT '',
    MatKhau     NVARCHAR(MAX),
    QuyenHan    INT
)

CREATE TABLE VAITRO (
	MaVaiTro	INT PRIMARY KEY,
	TenVaiTro	NVARCHAR(20)
)

ALTER TABLE XE ADD CONSTRAINT FK_XE_MaHieuXe FOREIGN KEY (MaHieuXe) REFERENCES HIEUXE(MaHieuXe)
ALTER TABLE PHIEUSUACHUA ADD CONSTRAINT FK_PSC_BienSo FOREIGN KEY (BienSo) REFERENCES XE(BienSo)
ALTER TABLE CT_PSC ADD CONSTRAINT FK_MaPhieuSC FOREIGN KEY (MaPhieuSC) REFERENCES PHIEUSUACHUA(MaPhieuSC)
ALTER TABLE CT_PSC ADD CONSTRAINT FK_MaTienCong FOREIGN KEY (MaTienCong) REFERENCES TIENCONG(MaTienCong)
ALTER TABLE CT_SUDUNGVATTU ADD CONSTRAINT FK_MaCTPSC FOREIGN KEY (MaCTPSC) REFERENCES CT_PSC (MaCTPSC)
ALTER TABLE CT_SUDUNGVATTU ADD CONSTRAINT FK_SDVT_MaVatTu FOREIGN KEY (MaVatTu) REFERENCES VATTU(MaVatTu)
ALTER TABLE PHIEUTHUTIEN ADD CONSTRAINT FK_PTT_BienSo FOREIGN KEY (BienSo) REFERENCES XE(BienSo)
ALTER TABLE CT_PNVT	ADD CONSTRAINT FK_MaPhieuNhap FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAPVATTU(MaPhieuNhap)
ALTER TABLE CT_PNVT	ADD CONSTRAINT FK_PNVT_MaVatTu FOREIGN KEY (MaVatTu) REFERENCES VATTU(MaVatTu)
ALTER TABLE BAOCAOTON ADD CONSTRAINT FK_BCT_MaVatTu FOREIGN KEY (MaVatTu) REFERENCES VATTU(MaVatTu)
ALTER TABLE CT_BCDS ADD CONSTRAINT FK_MaBCDS FOREIGN KEY (MaBCDS) REFERENCES BAOCAODOANHSO(MaBCDS)
ALTER TABLE CT_BCDS ADD CONSTRAINT FK_HieuXe FOREIGN KEY (MaHieuXe) REFERENCES HIEUXE(MaHieuXe)
ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_QuyenHan FOREIGN KEY (QuyenHan) REFERENCES VAITRO(MaVaiTro)

SET DATEFORMAT DMY 

INSERT INTO VAITRO VALUES (0, 'staff')
INSERT INTO VAITRO VALUES (1, 'admin')

INSERT INTO TAIKHOAN (TenTaiKhoan, MatKhau, QuyenHan) VALUES ('staff', '1562206543da764123c21bd524674f0a8aaf49c8a89744c97352fe677f7e4006', 0)
INSERT INTO TAIKHOAN (TenTaiKhoan, MatKhau, QuyenHan) VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1)


INSERT INTO HIEUXE (TenHieuXe) VALUES ('Honda')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Huyndai')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Mercedes')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Ford')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Toyota')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Kia')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Chevrolet')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Suzuki')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('Lexus')
INSERT INTO HIEUXE (TenHieuXe) VALUES ('BMW')

INSERT INTO VATTU (TenVatTu, DonGiaHienTai, SoLuongTon) VALUES
	(N'Phuộc trước', 10000000, 10),
	(N'Phuộc sau', 600000, 10),
	(N'Mâm ép', 2000000, 10),
	(N'Bố ly hợp', 1950000, 10),
	(N'Bố thắng trước', 1300000, 10),
	(N'Bố thắng sau', 1050000, 10),
	(N'Cao su chân máy', 750000, 10),
	(N'Rotuyn lái trong', 1500000, 10),
	(N'Máy phát điện', 7300000, 10),
	(N'Đồng hồ taplo', 9000000, 10),
	(N'Cảm biến ABS', 2800000, 10),
	(N'Lốc lạnh', 6500000, 10),
	(N'Dàn lạnh', 2500000, 10),
	(N'Dàn lạnh sau', 2200000, 10),
	(N'Dàn nóng', 4500000, 10),
	(N'Van tiết lưu', 400000, 10),
	(N'Đèn pha', 4100000, 10),
	(N'Đèn lái', 1100000, 10),
	(N'Đèn cản', 1200000, 10),
	(N'Cản trước', 1200000, 10),
	(N'Cửa xe', 7100000, 10),
	(N'Kính chiếu hậu', 3200000, 10),
	(N'Lọc gió', 1200000, 10);

INSERT INTO TIENCONG (TenTienCong, GiaTienCong) VALUES
    (N'Rửa xe', 300000),
    (N'Phủ Ceramic', 3000000),
    (N'Phủ thuỷ tinh', 2500000),
    (N'Vệ sinh xe cao cấp', 2000000),
    (N'Phủ gầm chống ồn chống gỉ', 4000000),
    (N'Đánh bóng, hiệu chỉnh mặt sơn', 3300000),
    (N'Sơn công nghệ cao', 3500000),
    (N'Gò phục hồi thân vỏ', 1500000),
    (N'Bảo dưỡng định kỳ', 2500000),
    (N'Kiểm tra tình trạng xe', 500000),
    (N'Sửa chữa Động cơ – Hộp số', 3000000),
    (N'Sửa chữa gầm bệ', 6000000),
    (N'Sửa chữa hệ thống điện', 4000000),
    (N'Dán phim cách nhiệt', 2000000);

INSERT INTO XE (MaHieuXe,TenChuXe, NgayTiepNhan, TienNo, BienSo) VALUES
(1,N'Nguyễn Duy Hào','13/05/2006',500000,N'20A000'),
(2,N'Dương Minh Thái','18/08/2010',490000,N'20B001'),
(3,N'Trương Đức Thiện','25/03/2015',900000,N'20C002'),
(4,N'Cấn Đức Quang','02/02/2019',500000,N'20D003'),
(5,N'Nguyễn Bá Công','05/06/2012',565000,N'20E004'),
(6,N'Châu Vĩnh Sinh','29/12/2018',500000,N'20F005'),
(7,N'Nguyễn Bá Công','20/03/2020',50000,N'20G006'),
(8,N'Tạ Hoàng Long','22/03/2022',5000000,N'20H007'),
(9,N'Nguyễn Minh Duy','26/04/2021',490000,N'20I008'),
(10,N'Mai Phúc Tâm','26/07/2017',300000,N'20J009'),
(1,N'Châu Vĩnh Sinh','05/06/2022',100000,N'21A000');

INSERT INTO THAMSO (TenThamSo, GiaTri) VALUES (N'Số xe sửa chữa trong ngày tối đa', 30)
INSERT INTO THAMSO (TenThamSo, GiaTri) VALUES (N'TodayVehicle', 0)