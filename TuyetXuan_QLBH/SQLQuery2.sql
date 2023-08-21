-- T?o c? s? d? li?u
CREATE DATABASE TaiKhoan;

-- S? d?ng c? s? d? li?u
5

-- T?o b?ng dangnhap
CREATE TABLE dangnhap (
    id INT PRIMARY KEY,
    Username nVARCHAR(50) NOT NULL,
    Password nVARCHAR(100) NOT NULL
   
);

-- T?o b?ng products
CREATE TABLE sanpham (
    id INT PRIMARY KEY not null,
    name NVARCHAR(100) NOT NULL,
    price int NOT NULL,
	quantity_in_stock int,
	Image nvarchar(255),
    KichCo nvarchar(255)
);

-- T?o b?ng NhaCungCap
CREATE TABLE NhaCungCap (
    id INT PRIMARY KEY not null,
    Ten nVARCHAR(100) NOT NULL,
    DiaChi nVARCHAR(200),
    sdt nVARCHAR(20),
	KhuVuc nvarchar(255),
	email nvarchar(255)
);

-- T?o b?ng HoaDon
CREATE TABLE HoaDon (
    MaKhach INT PRIMARY KEY not null,
	TenKhach nvarchar(255),
	DienThoai nvarchar(255),
	KhuVuc  nvarchar(255),
	MaSanPham int,
	TenSP  nvarchar(255),
	NgaylapHD Datetime,
	Soluong  int,
	Gia  nvarchar(255),
	TongTien decimal
);




delete from sanpham