-- Drop the database if it exists and disconnect existing connections
USE master;
GO

IF EXISTS (
    SELECT 1
    FROM sys.databases
    WHERE name = 'PolisDepartmani'
)
BEGIN
    ALTER DATABASE PolisDepartmani SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE PolisDepartmani;
END

-- Create the database
CREATE DATABASE PolisDepartmani;
GO

-- Use the created database
USE PolisDepartmani;
GO

-- Drop tables if they exist and have no foreign key references
IF OBJECT_ID('Gorevliler', 'U') IS NOT NULL
BEGIN
    IF NOT EXISTS (
        SELECT 1
        FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
        WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
          AND TABLE_NAME = 'Gorevliler'
    )
    BEGIN
        DROP TABLE Gorevliler;
    END
END

IF OBJECT_ID('Mahkumlar', 'U') IS NOT NULL
BEGIN
    IF NOT EXISTS (
        SELECT 1
        FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
        WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
          AND TABLE_NAME = 'Mahkumlar'
    )
    BEGIN
        DROP TABLE Mahkumlar;
    END
END

-- Create tables
CREATE TABLE Gorevliler (
    KullaniciID INT IDENTITY(1,1),
    KullaniciAdi NVARCHAR(100) PRIMARY KEY NOT NULL,
    Sifre NVARCHAR(100),
    Ad NVARCHAR(100) NOT NULL,
    Soyad NVARCHAR(100) NOT NULL,
    Telefon NVARCHAR(15),
    Gorevli BIT DEFAULT 0 NOT NULL
);
GO

CREATE TABLE Mahkumlar (
    MahkumID INT PRIMARY KEY IDENTITY(1,1),
    YetkiliKadi NVARCHAR(100) FOREIGN KEY REFERENCES Gorevliler(KullaniciAdi) NOT NULL,
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NOT NULL,
    Cinsiyet NVARCHAR(10) NOT NULL,
    CezaAlmaTarihi DATE NOT NULL,
    CezaBitisTarihi DATE NOT NULL,
    SucAdi NVARCHAR(200) NOT NULL,
    Telefon NVARCHAR(15)
);
GO

-- Insert sample data
INSERT INTO Gorevliler (KullaniciAdi, Sifre, Ad, Soyad, Telefon, Gorevli)
VALUES ('admin', '123', 'Admin', 'X', '1111111111', 1);
GO

INSERT INTO Mahkumlar (YetkiliKadi, Ad, Soyad, DogumTarihi, Cinsiyet, CezaAlmaTarihi, CezaBitisTarihi, SucAdi, Telefon)
VALUES ('admin', 'XXX', 'YYY', '1990-01-01', 'Erkek', '2023-01-01', '2024-01-01', 'Hırsızlık', NULL);
INSERT INTO Mahkumlar (YetkiliKadi, Ad, Soyad, DogumTarihi, Cinsiyet, CezaAlmaTarihi, CezaBitisTarihi, SucAdi, Telefon)
VALUES ('admin', 'ZZZ', 'AAA', '1990-01-01', 'Erkek', '2023-01-01', '2024-01-01', 'Cinayet', NULL);
GO
