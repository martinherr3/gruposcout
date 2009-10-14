-- SQL Manager 2005 for SQL Server (2.0.5.1)
-- ---------------------------------------
-- Host     : localhost
-- Database : BDTPFinal


--
-- Structure for table Beneficiarios : 
--

CREATE TABLE [dbo].[Beneficiarios] (
  [idBeneficiario] int IDENTITY(1, 1) NOT NULL,
  [codTipoDoc] int,
  [NroDoc] int,
  [Apellido] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [Nombre] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [Calle] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [Numero] int,
  [Barrio] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [Email] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [Telefono] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [FechaNac] datetime,
  [idEquipo] int
)
ON [PRIMARY]
GO

--
-- Structure for table Equipos : 
--

CREATE TABLE [dbo].[Equipos] (
  [IdEquipo] int IDENTITY(1, 1) NOT NULL,
  [Nombre] varchar(100) COLLATE Modern_Spanish_CI_AS,
  [CantIntegrantes] int,
  [IdRama] int
)
ON [PRIMARY]
GO

--
-- Structure for table Ramas : 
--

CREATE TABLE [dbo].[Ramas] (
  [IdRama] int IDENTITY(1, 1) NOT NULL,
  [Nombre] varchar(50) COLLATE Modern_Spanish_CI_AS,
  [EdadMin] int,
  [EdadMax] int
)
ON [PRIMARY]
GO

--
-- Structure for table TipoDoc : 
--

CREATE TABLE [dbo].[TipoDoc] (
  [codTipoDoc] int IDENTITY(1, 1) NOT NULL,
  [Nombre] nchar(10) COLLATE Modern_Spanish_CI_AS NOT NULL
)
ON [PRIMARY]
GO

--
-- Data for table Beneficiarios  (LIMIT 0,500)
--

SET IDENTITY_INSERT [Beneficiarios] ON
GO

INSERT INTO [Beneficiarios] ([idBeneficiario], [codTipoDoc], [NroDoc], [Apellido], [Nombre], [Calle], [Numero], [Barrio], [Email], [Telefono], [FechaNac], [idEquipo])
VALUES 
  (13, 1, 27953971, 'SILVERA', 'RAMIRO', 'COLON', 1977, 'ALBERDI', 'rsilvera', '12938Y79', NULL, NULL)
GO

INSERT INTO [Beneficiarios] ([idBeneficiario], [codTipoDoc], [NroDoc], [Apellido], [Nombre], [Calle], [Numero], [Barrio], [Email], [Telefono], [FechaNac], [idEquipo])
VALUES 
  (14, 3, 27953971, 'SILVERA', 'RAMIRO', 'COLON', 879, 'NO', 'no', 'W', '29/09/2009 21:11:50', 1)
GO

INSERT INTO [Beneficiarios] ([idBeneficiario], [codTipoDoc], [NroDoc], [Apellido], [Nombre], [Calle], [Numero], [Barrio], [Email], [Telefono], [FechaNac], [idEquipo])
VALUES 
  (15, 1, 11, 'LAVIE', 'RAUL', 'COLON', 19, 'IU', 'wwe', '120', '03/10/2009 12:48:03', 1)
GO

SET IDENTITY_INSERT [Beneficiarios] OFF
GO

--
-- Data for table Equipos  (LIMIT 0,500)
--

SET IDENTITY_INSERT [Equipos] ON
GO

INSERT INTO [Equipos] ([IdEquipo], [Nombre], [CantIntegrantes], [IdRama])
VALUES 
  (1, 'Equipo 1', 5, 1)
GO

INSERT INTO [Equipos] ([IdEquipo], [Nombre], [CantIntegrantes], [IdRama])
VALUES 
  (2, 'Equipo 2', 5, 2)
GO

INSERT INTO [Equipos] ([IdEquipo], [Nombre], [CantIntegrantes], [IdRama])
VALUES 
  (3, 'Equipo 3', 5, 3)
GO

INSERT INTO [Equipos] ([IdEquipo], [Nombre], [CantIntegrantes], [IdRama])
VALUES 
  (4, 'Equipo 4', 5, 4)
GO

SET IDENTITY_INSERT [Equipos] OFF
GO

--
-- Data for table Ramas  (LIMIT 0,500)
--

SET IDENTITY_INSERT [Ramas] ON
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (1, 'Junior', 0, 8)
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (2, 'Infantiles', 9, 13)
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (3, 'Menores', 13, 17)
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (4, 'Cadetes', 18, 21)
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (5, 'Mayores', 21, 99)
GO

INSERT INTO [Ramas] ([IdRama], [Nombre], [EdadMin], [EdadMax])
VALUES 
  (6, 'Fuera de Rango', 100, 100000)
GO

SET IDENTITY_INSERT [Ramas] OFF
GO

--
-- Data for table TipoDoc  (LIMIT 0,500)
--

SET IDENTITY_INSERT [TipoDoc] ON
GO

INSERT INTO [TipoDoc] ([codTipoDoc], [Nombre])
VALUES 
  (1, 'DNI')
GO

INSERT INTO [TipoDoc] ([codTipoDoc], [Nombre])
VALUES 
  (3, 'LC')
GO

INSERT INTO [TipoDoc] ([codTipoDoc], [Nombre])
VALUES 
  (4, 'CEDULA')
GO

SET IDENTITY_INSERT [TipoDoc] OFF
GO

--
-- Definition for indices : 
--

ALTER TABLE [dbo].[Beneficiarios]
ADD CONSTRAINT [PK_Beneficiarios] 
PRIMARY KEY CLUSTERED ([idBeneficiario])
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Equipos]
ADD CONSTRAINT [PK_Equipos] 
PRIMARY KEY CLUSTERED ([IdEquipo])
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ramas]
ADD CONSTRAINT [PK_Ramas] 
PRIMARY KEY CLUSTERED ([IdRama])
ON [PRIMARY]
GO

ALTER TABLE [dbo].[TipoDoc]
ADD CONSTRAINT [PK_TipoDoc] 
PRIMARY KEY CLUSTERED ([codTipoDoc])
ON [PRIMARY]
GO

