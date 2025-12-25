-- ============================================
-- Inventory Management System - Database Setup
-- Database: InventoryDB
-- Created: December 24, 2025
-- ============================================

-- Create Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'InventoryDB')
BEGIN
    CREATE DATABASE InventoryDB;
    PRINT 'Database InventoryDB created successfully.';
END
ELSE
BEGIN
    PRINT 'Database InventoryDB already exists.';
END
GO

-- Use the InventoryDB database
USE InventoryDB;
GO

-- ============================================
-- Create Logins Table
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Logins]') AND type in (N'U'))
BEGIN
    CREATE TABLE Logins (
        Username VARCHAR(50) PRIMARY KEY NOT NULL,
        Password VARCHAR(50) NOT NULL
    );
    PRINT 'Logins table created successfully.';
END
ELSE
BEGIN
    PRINT 'Logins table already exists.';
END
GO

-- Insert default admin user
IF NOT EXISTS (SELECT * FROM Logins WHERE Username = 'Admin')
BEGIN
    INSERT INTO Logins (Username, Password) 
    VALUES ('Admin', 'StockUser123');
    PRINT 'Default admin user added successfully.';
END
ELSE
BEGIN
    PRINT 'Admin user already exists.';
END
GO

-- ============================================
-- Create Inventory Table
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventory]') AND type in (N'U'))
BEGIN
    CREATE TABLE Inventory (
        ItemCode INT PRIMARY KEY NOT NULL,
        ItemName VARCHAR(100) NOT NULL,
        Category VARCHAR(50) NOT NULL,
        Quantity INT NOT NULL,
        UnitPrice DECIMAL(18, 2) NOT NULL,
        Supplier VARCHAR(100) NOT NULL,
        DateAdded DATE NOT NULL
    );
    PRINT 'Inventory table created successfully.';
END
ELSE
BEGIN
    PRINT 'Inventory table already exists.';
END
GO

-- ============================================
-- Insert Sample Data (Optional)
-- ============================================
IF NOT EXISTS (SELECT * FROM Inventory)
BEGIN
    INSERT INTO Inventory (ItemCode, ItemName, Category, Quantity, UnitPrice, Supplier, DateAdded)
    VALUES 
        (1001, 'Laptop Dell XPS', 'Electronics', 15, 1200.00, 'Dell Inc.', '2025-12-01'),
        (1002, 'Office Chair', 'Furniture', 50, 150.00, 'IKEA', '2025-12-05'),
        (1003, 'Printer HP LaserJet', 'Electronics', 20, 350.00, 'HP Inc.', '2025-12-10');
    PRINT 'Sample data inserted successfully.';
END
GO

-- ============================================
-- Verify Tables
-- ============================================
SELECT 'Logins Table' AS TableName, COUNT(*) AS RecordCount FROM Logins
UNION ALL
SELECT 'Inventory Table', COUNT(*) FROM Inventory;
GO

PRINT 'Database setup completed successfully!';
