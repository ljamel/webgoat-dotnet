CREATE DATABASE VulnDB;
GO
USE VulnDB;
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(100),
    Password NVARCHAR(100)
);
INSERT INTO Users (Username, Password) VALUES ('admin', 'admUhfezkjefezyggt4566azererIIOUY123');
