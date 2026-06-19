
USE master
GO
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'LabCoreSoftMedico'
)
CREATE DATABASE LabCoreSoftMedico
GO
Use LabCoreSoftMedico
GO
IF OBJECT_ID('[dbo].[TiposDocumento]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[TiposDocumento]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
        [Tipo] NVARCHAR(200) NOT NULL,
    );
END
GO

IF OBJECT_ID('[dbo].[Departamentos]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Departamentos]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
        [Nombre] NVARCHAR(200) NOT NULL,
    );
END
GO

IF OBJECT_ID('[dbo].[Ciudades]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Ciudades]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
        [Nombre] NVARCHAR(200) NOT NULL,
        [IdDepartamento] INT
        FOREIGN KEY (IdDepartamento) REFERENCES Departamentos(Id)
    );
END
GO

IF OBJECT_ID('[dbo].[Pacientes]', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Pacientes]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
        [Nombres] NVARCHAR(200) NOT NULL,
        [Apellidos] NVARCHAR(200) NOT NULL,
        [IdTipoDocumento] INT,
        [NumeroDocumento] VARCHAR(50),
        [FechaNacimiento] DATETIME,
        [IdCiudad] INT
        FOREIGN KEY (IdTipoDocumento) REFERENCES TiposDocumento(Id),
        FOREIGN KEY (IdCiudad) REFERENCES Ciudades(Id),
        CONSTRAINT UC_TipoDocumento_NumeroDocumento UNIQUE (IdTipoDocumento, NumeroDocumento)
    );
END

GO
IF (SELECT COUNT(1) FROM TiposDocumento) = 0
BEGIN
    INSERT INTO TiposDocumento
    VALUES ('Cédula de Ciudadania'),
    ('Cédula de Extranjeria'),
    ('Registro Civil'),
    ('Tarjeta de Identidad'),
    ('Pasaporte')
END
GO

IF (SELECT COUNT(1) FROM Departamentos) = 0
BEGIN
    INSERT INTO Departamentos
    VALUES ('Antioquia'),
    ('Boyacá'),
    ('Cundinamarca'),
    ('Tolima')
END

GO

IF (SELECT COUNT(1) FROM Ciudades) = 0
BEGIN
    INSERT INTO Ciudades
    VALUES  ('Abejorral', 1),
            ('Medellín', 1),
            ('Bogotá', 2),
            ('Soacha', 2),
            ('Paipa', 3),
            ('Tunja', 3),
            ('Ibague', 4),
            ('Saldaña', 4)
END

GO

IF (SELECT COUNT(1) FROM Pacientes) = 0
BEGIN
    INSERT INTO Pacientes
    VALUES  ('Pepito', 'Perez', 1, '12345678', '1980-01-01', 4)
END
