IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ReyV1')
BEGIN
    CREATE DATABASE ReyV1;
END;
GO

USE ReyV1;
GO

IF OBJECT_ID(N'dbo.AuditLog', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.AuditLog
    (
        AuditLogId INT IDENTITY(1, 1) PRIMARY KEY,
        EventDateUtc DATETIME2 NOT NULL DEFAULT (SYSUTCDATETIME()),
        EventType NVARCHAR(100) NOT NULL,
        Payload NVARCHAR(MAX) NULL
    );
END;
GO
