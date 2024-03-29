SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dirigentes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Dirigentes](
	[idDirigente] [int] IDENTITY(1,1) NOT NULL,
	[codTipoDoc] [int] NULL,
	[NroDoc] [int] NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[Numero] [int] NULL,
	[Barrio] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[FechaNac] [datetime] NULL,
	[idEquipo] [int] NULL,
 CONSTRAINT [PK_Dirigente] PRIMARY KEY CLUSTERED 
(
	[idDirigente] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Progresiones]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Progresiones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Progresiones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cuotas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cuotas](
	[idCuotas] [int] IDENTITY(1,1) NOT NULL,
	[NroCuota] [int] NULL,
	[idBeneficiario] [int] NULL,
	[FechaVto] [datetime] NULL,
	[Monto] [float] NULL,
 CONSTRAINT [PK_Cuotas] PRIMARY KEY CLUSTERED 
(
	[idCuotas] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pagos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pagos](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idCuota] [int] NULL,
	[idBeneficiario] [int] NULL,
	[FechaPagoReal] [datetime] NULL,
	[Monto] [float] NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ActividadesxObjetivos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ActividadesxObjetivos](
	[idObjetivo] [int] NULL,
	[idActividad] [int] NULL,
	[idBeneficiario] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[idProgresion] [int] NULL,
	[idActividadObjetivo] [int] IDENTITY(1,1) NOT NULL,
	[idPrograma] [int] NULL,
	[FechaDesde] [datetime] NULL,
	[FechaHasta] [datetime] NULL,
 CONSTRAINT [PK_ActividadesxObjetivos] PRIMARY KEY CLUSTERED 
(
	[idActividadObjetivo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Actividades]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Actividades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Actividades] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Objetivos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Objetivos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Objetivos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Elementos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Elementos](
	[idElementos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_Elementos] PRIMARY KEY CLUSTERED 
(
	[idElementos] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Equipos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Equipos](
	[idEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CantidadIntegrantes] [int] NULL,
	[idRama] [int] NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[idEquipo] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Inventario](
	[idInventario] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Descripcion] [varchar](50) NULL,
	[idRama] [int] NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[idInventario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ElementosxInventario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ElementosxInventario](
	[idElementosInventarios] [int] IDENTITY(1,1) NOT NULL,
	[idInventario] [int] NULL,
	[idElemento] [int] NULL,
	[Cantidad] [varchar](50) NULL,
 CONSTRAINT [PK_ElementosxInventario] PRIMARY KEY CLUSTERED 
(
	[idElementosInventarios] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ramas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ramas](
	[idRama] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[EdadMin] [int] NULL,
	[EdadMax] [int] NULL,
 CONSTRAINT [PK_Ramas] PRIMARY KEY CLUSTERED 
(
	[idRama] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Estados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Estados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Programas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Programas](
	[idPrograma] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Lugar] [varchar](50) NULL,
	[idObjetivo] [int] NULL,
	[idRama] [int] NULL,
 CONSTRAINT [PK_Programas] PRIMARY KEY CLUSTERED 
(
	[idPrograma] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgresionesxBeneficiario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProgresionesxBeneficiario](
	[idProgresionesBene] [int] IDENTITY(1,1) NOT NULL,
	[idBeneficiario] [int] NULL,
 CONSTRAINT [PK_ProgresionesxBeneficiario] PRIMARY KEY CLUSTERED 
(
	[idProgresionesBene] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoDoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TipoDoc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_TipoDoc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Beneficiarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Beneficiarios](
	[idBeneficiario] [int] IDENTITY(1,1) NOT NULL,
	[codTipoDoc] [int] NULL,
	[NroDoc] [int] NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Calle] [varchar](50) NULL,
	[Numero] [int] NULL,
	[Barrio] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[FechaNac] [datetime] NULL,
	[idEquipo] [int] NULL,
 CONSTRAINT [PK_Beneficiarios] PRIMARY KEY CLUSTERED 
(
	[idBeneficiario] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
