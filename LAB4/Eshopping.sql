CREATE DATABASE ESHOPPING_DB;
GO
USE ESHOPPING_DB;
GO

CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(120) NOT NULL,
    DateOfBirth DATE NULL,
    IDPassport NVARCHAR(30) NULL,
    Address NVARCHAR(255) NULL,
    Phone NVARCHAR(20) NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(150) NULL
);

CREATE TABLE DeliveryType (
    DeliveryTypeID INT IDENTITY(1,1) PRIMARY KEY,
    DeliveryTypeName NVARCHAR(100) NOT NULL,
    ProcessingHours INT NULL
);

CREATE TABLE DeliveryZone (
    ZoneID INT IDENTITY(1,1) PRIMARY KEY,
    ZoneName NVARCHAR(100) NOT NULL
);

CREATE TABLE DeliveryFee (
    DeliveryTypeID INT NOT NULL,
    ZoneID INT NOT NULL,
    Fee DECIMAL(18,2) NOT NULL DEFAULT 0,
    PRIMARY KEY (DeliveryTypeID, ZoneID),
    FOREIGN KEY (DeliveryTypeID) REFERENCES DeliveryType(DeliveryTypeID),
    FOREIGN KEY (ZoneID) REFERENCES DeliveryZone(ZoneID)
);

CREATE TABLE Cart (
    CartID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    UpdatedAt DATETIME2 NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE CartItem (
    CartID INT NOT NULL,
    ProductCode VARCHAR(50) NOT NULL,
    ProductName NVARCHAR(200) NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice >= 0),
    PRIMARY KEY (CartID, ProductCode),
    FOREIGN KEY (CartID) REFERENCES Cart(CartID)
);

CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    RecipientName NVARCHAR(120) NOT NULL,
    RecipientAddress NVARCHAR(255) NOT NULL,
    RecipientPhone NVARCHAR(20) NOT NULL,
    DeliveryTypeID INT NOT NULL,
    ZoneID INT NOT NULL,
    MerchandiseAmount DECIMAL(18,2) NOT NULL,
    ShippingFee DECIMAL(18,2) NOT NULL,
    OrderTotal AS (MerchandiseAmount + ShippingFee) PERSISTED,
    Status NVARCHAR(30) NOT NULL DEFAULT N'ChoThanhToan',
    ConfirmationEmail VARCHAR(150) NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (DeliveryTypeID) REFERENCES DeliveryType(DeliveryTypeID),
    FOREIGN KEY (ZoneID) REFERENCES DeliveryZone(ZoneID)
);

CREATE TABLE OrderItem (
    OrderID INT NOT NULL,
    ProductCode VARCHAR(50) NOT NULL,
    ProductNameSnapshot NVARCHAR(200) NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice >= 0),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    LineTotal AS (UnitPrice * Quantity) PERSISTED,
    PRIMARY KEY (OrderID, ProductCode),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    CardType VARCHAR(20) NOT NULL,
    MaskedCard VARCHAR(25) NULL,
    PaymentReference VARCHAR(100) NULL,
    Amount DECIMAL(18,2) NOT NULL,
    Status VARCHAR(30) NOT NULL,
    PaidAt DATETIME2 NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

-- Không lưu CVV/CSV trong CSDL.
-- Dữ liệu sản phẩm gốc được truy xuất từ hệ thống quản lý sản phẩm bên ngoài.

