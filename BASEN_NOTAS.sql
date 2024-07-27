-- Crear la tabla Notas
CREATE TABLE Notas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(100) NOT NULL,
    Contenido NVARCHAR(MAX) NOT NULL,
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
    Completado BIT NOT NULL DEFAULT 0
);
