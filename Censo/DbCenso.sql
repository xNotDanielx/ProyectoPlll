USE [DbCenso]
GO
/****** Object:  Table [dbo].[Loguin]    Script Date: 04/06/2023 3:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loguin](
	[Admin] [bit] NOT NULL,
	[Numero_Documento] [varchar](10) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Tipo_Documento] [varchar](50) NOT NULL,
	[Cuentas_Registradas] [int] NOT NULL,
 CONSTRAINT [PK_Loguin] PRIMARY KEY CLUSTERED 
(
	[Numero_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_Login] UNIQUE NONCLUSTERED 
(
	[Numero_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 04/06/2023 3:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Documento] [varchar](10) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Apellido] [varchar](255) NOT NULL,
	[Sexo] [varchar](10) NOT NULL,
	[Edad] [varchar](3) NOT NULL,
	[Telefono] [varchar](10) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Barrio] [varchar](50) NOT NULL,
	[Tipo_Vivienda] [varchar](50) NOT NULL,
	[Sectores_Completados] [varchar](50) NOT NULL,
 CONSTRAINT [UC_Persona] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector_Economico]    Script Date: 04/06/2023 3:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector_Economico](
	[Documento] [varchar](10) NOT NULL,
	[Empleado] [int] NOT NULL,
	[Propietario_Negocio] [int] NULL,
	[Trabajador_Privado] [int] NULL,
	[Contratista_Independiente] [int] NULL,
	[Pensionado] [int] NULL,
	[Subsidiado] [int] NULL,
	[Accionistas] [int] NULL,
	[Trabajador_Publico] [int] NULL,
	[Ingreso_Actividades] [int] NULL,
	[Desempleado] [int] NULL,
	[Estrato] [varchar](3) NULL,
 CONSTRAINT [UC_SE] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector_Hogar]    Script Date: 04/06/2023 3:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector_Hogar](
	[Documento] [varchar](10) NOT NULL,
	[Zona] [varchar](50) NULL,
	[Propietario] [int] NULL,
	[Servicio_Agua] [int] NULL,
	[Servicio_Luz] [int] NULL,
	[Servicio_Gas] [int] NULL,
	[Saneamiento] [int] NULL,
	[Adicional] [int] NULL,
	[Habitaciones] [varchar](50) NULL,
	[Baños] [varchar](50) NULL,
	[Tipo_Vivienda] [varchar](50) NULL,
	[Ingreso] [varchar](50) NULL,
	[Internet] [int] NULL,
	[Cable] [int] NULL,
	[Telefono] [int] NULL,
	[Vehiculo] [int] NULL,
 CONSTRAINT [UC_SH] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SectorSocial]    Script Date: 04/06/2023 3:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SectorSocial](
	[Documento] [varchar](10) NULL,
	[Afliado] [int] NULL,
	[Victima_Conflicto] [int] NULL,
	[Etnia] [varchar](50) NULL,
	[Acceso_Estudio] [int] NULL,
	[Servicio_Transporte] [int] NULL,
	[Estado_Civil] [varchar](50) NULL,
	[NivelEducacion] [varchar](50) NULL,
 CONSTRAINT [UC_Ss] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
