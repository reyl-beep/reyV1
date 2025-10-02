USE ReyV1;
GO

INSERT INTO dbo.AuditLog (EventType, Payload)
VALUES ('SEED', N'Base de datos inicializada correctamente');
GO
