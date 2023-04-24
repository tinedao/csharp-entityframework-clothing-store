create database ClothingStore
use ClothingStore
-- Tạo bảng Product
CREATE TABLE Product (
    id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255),
    star FLOAT,
    price DECIMAL(18,2),
    size NVARCHAR(50),
    color NVARCHAR(50),
    quantity INT,
    idCate INT
);

INSERT INTO Product(name,star,price,size,color,quantity,idCate) values ('Nike Script',3,2000,'xl','red',3,1),('Nike Shot',2,1000,'m','green',2,2)
-- Tạo bảng Category
CREATE TABLE Category (
    id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255)
);
INSERT INTO Category(name) values(N'Quần'),(N'Áo')

-- Tạo bảng Users
CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY,
    firstName NVARCHAR(50),
    lastName NVARCHAR(50),
    phone NVARCHAR(20),
    address NVARCHAR(255),
    email NVARCHAR(255),
    password NVARCHAR(255)
);

-- Tạo bảng Cart
CREATE TABLE Cart (
    id INT PRIMARY KEY IDENTITY,
    idPro INT,
    total DECIMAL(18,2)
);

-- Tạo bảng Wishlist
CREATE TABLE Wishlist (
    id INT PRIMARY KEY IDENTITY,
    idPro INT
);

-- Tạo bảng Checkout
CREATE TABLE Checkout (
    id INT PRIMARY KEY IDENTITY,
    idUser INT,
    country NVARCHAR(100),
    city NVARCHAR(100),
    state NVARCHAR(100),
    zipCode NVARCHAR(20),
    payment NVARCHAR(100),
    shipcode NVARCHAR(100),
    idcart INT
);

-- Tạo bảng Brand
CREATE TABLE Brand (
    id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255),
    imgBrand NVARCHAR(255)
);

-- Tạo bảng Preview
CREATE TABLE Preview (
    id INT PRIMARY KEY IDENTITY,
    idUser INT,
    preview NVARCHAR(MAX)
);

-- Tạo bảng Contact
CREATE TABLE Contact (
    id INT PRIMARY KEY IDENTITY,
    name NVARCHAR(255),
    email NVARCHAR(255),
    subject NVARCHAR(255),
    message NVARCHAR(MAX)
);

-- Thêm ràng buộc khóa ngoại cho trường idCate trong bảng Product, liên kết với trường id trong bảng Category
ALTER TABLE Product
ADD FOREIGN KEY (idCate)
REFERENCES Category (id);

-- Thêm ràng buộc khóa ngoại cho trường idPro trong bảng Cart, liên kết với trường id trong bảng Product
ALTER TABLE Cart
ADD FOREIGN KEY (idPro)
REFERENCES Product (id);

-- Thêm ràng buộc khóa ngoại cho trường idPro trong bảng Wishlist, liên kết với trường id trong bảng Product
ALTER TABLE Wishlist
ADD FOREIGN KEY (idPro)
REFERENCES Product (id);

-- Thêm ràng buộc khóa ngoại cho trường idUser trong bảng Checkout, liên kết với trường id trong bảng Users
ALTER TABLE Checkout
ADD FOREIGN KEY (idUser)
REFERENCES Users (id);

-- Thêm ràng buộc khóa ngoại cho trường idcart trong bảng Checkout, liên kết với trường id trong bảng Cart
ALTER TABLE Checkout
ADD FOREIGN KEY (idcart)
REFERENCES Cart (id);

-- Thêm ràng buộc khóa ngoại cho trường idUser trong bảng Preview, liên kết với trường id trong bảng Users
ALTER TABLE Preview
ADD FOREIGN KEY (idUser)
REFERENCES Users (id);

use master
drop database ClothingStore

