USE [master]
GO
/****** Object:  Database [DbCenso]    Script Date: 04/06/2023 20:25:09 ******/
CREATE DATABASE [DbCenso]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbCenso', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DbCenso.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbCenso_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DbCenso_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DbCenso] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbCenso].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbCenso] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbCenso] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbCenso] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbCenso] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbCenso] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbCenso] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbCenso] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbCenso] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbCenso] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbCenso] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbCenso] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbCenso] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbCenso] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbCenso] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbCenso] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbCenso] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbCenso] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbCenso] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbCenso] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbCenso] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbCenso] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbCenso] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbCenso] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbCenso] SET  MULTI_USER 
GO
ALTER DATABASE [DbCenso] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbCenso] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbCenso] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbCenso] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbCenso] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbCenso] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DbCenso] SET QUERY_STORE = ON
GO
ALTER DATABASE [DbCenso] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DbCenso]
GO
/****** Object:  Table [dbo].[Loguin]    Script Date: 04/06/2023 20:25:09 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 04/06/2023 20:25:09 ******/
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
	[Sectores_Completados] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector_Economico]    Script Date: 04/06/2023 20:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector_Economico](
	[Documento] [varchar](10) NOT NULL,
	[Empleado] [int] NULL,
	[Propietario_Negocio] [int] NULL,
	[Trabajador_Privado] [int] NULL,
	[Contratista_Independiente] [int] NULL,
	[Pensionado] [int] NULL,
	[Subsidiado] [int] NULL,
	[Accionistas] [int] NULL,
	[Trabajador_Publico] [int] NULL,
	[Ingreso_Actividades] [int] NULL,
	[Desempleado] [int] NULL,
	[Estrato] [varchar](3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector_Hogar]    Script Date: 04/06/2023 20:25:09 ******/
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
	[Vehiculo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SectorSocial]    Script Date: 04/06/2023 20:25:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SectorSocial](
	[Documento] [varchar](10) NOT NULL,
	[Afliado] [int] NULL,
	[Victima_Conflicto] [int] NULL,
	[Etnia] [varchar](50) NULL,
	[Acceso_Estudio] [int] NULL,
	[Servicio_Transporte] [int] NULL,
	[Estado_Civil] [varchar](50) NULL,
	[NivelEducacion] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Loguin] ([Admin], [Numero_Documento], [Contraseña], [Tipo_Documento], [Cuentas_Registradas]) VALUES (0, N'1003266232', N'Juan0730', N'CC', 3)
INSERT [dbo].[Loguin] ([Admin], [Numero_Documento], [Contraseña], [Tipo_Documento], [Cuentas_Registradas]) VALUES (1, N'1003266310', N'Juliancho2002', N'CC', 1)
INSERT [dbo].[Loguin] ([Admin], [Numero_Documento], [Contraseña], [Tipo_Documento], [Cuentas_Registradas]) VALUES (1, N'1030528223', N'Danithor10', N'CC', 2)
INSERT [dbo].[Loguin] ([Admin], [Numero_Documento], [Contraseña], [Tipo_Documento], [Cuentas_Registradas]) VALUES (1, N'1067806286', N'David123', N'CC', 1)
INSERT [dbo].[Loguin] ([Admin], [Numero_Documento], [Contraseña], [Tipo_Documento], [Cuentas_Registradas]) VALUES (0, N'49792922', N'Juanvicandrejuan', N'CC', 4)
GO
INSERT [dbo].[Persona] ([Documento], [Nombre], [Apellido], [Sexo], [Edad], [Telefono], [FechaNacimiento], [Correo], [Direccion], [Barrio], [Tipo_Vivienda], [Sectores_Completados]) VALUES (N'1003266310', N'Julian Alexander', N'Santos Montero', N'Masculino', N'20', N'3052944612', CAST(N'2002-08-29T00:00:00.000' AS DateTime), N'Sin Correo', N'Cra10#13b67', N'Obrero', N'Hogar', N'Completado')
INSERT [dbo].[Persona] ([Documento], [Nombre], [Apellido], [Sexo], [Edad], [Telefono], [FechaNacimiento], [Correo], [Direccion], [Barrio], [Tipo_Vivienda], [Sectores_Completados]) VALUES (N'1030528223', N'Víctor Daniel', N'Torres Solano', N'Masculino', N'18', N'3123104826', CAST(N'2004-09-10T00:00:00.000' AS DateTime), N'Sin Correo', N'Cra31#31-60', N'San Francisco', N'Hogar', N'Completado')
INSERT [dbo].[Persona] ([Documento], [Nombre], [Apellido], [Sexo], [Edad], [Telefono], [FechaNacimiento], [Correo], [Direccion], [Barrio], [Tipo_Vivienda], [Sectores_Completados]) VALUES (N'1003266232', N'Juan Sebastian', N'Torres Solano', N'Masculino', N'20', N'3127802716', CAST(N'2002-10-10T00:00:00.000' AS DateTime), N'Sin Correo', N'Cra31#31-60', N'San Francisco', N'Hogar', N'Completado')
INSERT [dbo].[Persona] ([Documento], [Nombre], [Apellido], [Sexo], [Edad], [Telefono], [FechaNacimiento], [Correo], [Direccion], [Barrio], [Tipo_Vivienda], [Sectores_Completados]) VALUES (N'1067806286', N'David Jese', N'Coronel Hinojosa', N'Masculino', N'19', N'3108965403', CAST(N'2004-01-11T00:00:00.000' AS DateTime), N'Sin Correo', N'Cra15#30-14', N'12 De Cotubre', N'Hogar', N'Completado')
INSERT [dbo].[Persona] ([Documento], [Nombre], [Apellido], [Sexo], [Edad], [Telefono], [FechaNacimiento], [Correo], [Direccion], [Barrio], [Tipo_Vivienda], [Sectores_Completados]) VALUES (N'49792922', N'Lisbeth', N'Solano Duran', N'Femenino', N'45', N'3007678921', CAST(N'1977-09-01T00:00:00.000' AS DateTime), N'Sin Correo', N'Cra31#31-60', N'San Francisco', N'Hogar', N'Completado')
GO
INSERT [dbo].[Sector_Economico] ([Documento], [Empleado], [Propietario_Negocio], [Trabajador_Privado], [Contratista_Independiente], [Pensionado], [Subsidiado], [Accionistas], [Trabajador_Publico], [Ingreso_Actividades], [Desempleado], [Estrato]) VALUES (N'1003266310', 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, N'3')
INSERT [dbo].[Sector_Economico] ([Documento], [Empleado], [Propietario_Negocio], [Trabajador_Privado], [Contratista_Independiente], [Pensionado], [Subsidiado], [Accionistas], [Trabajador_Publico], [Ingreso_Actividades], [Desempleado], [Estrato]) VALUES (N'1030528223', 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, N'2')
INSERT [dbo].[Sector_Economico] ([Documento], [Empleado], [Propietario_Negocio], [Trabajador_Privado], [Contratista_Independiente], [Pensionado], [Subsidiado], [Accionistas], [Trabajador_Publico], [Ingreso_Actividades], [Desempleado], [Estrato]) VALUES (N'1003266232', 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, N'2')
INSERT [dbo].[Sector_Economico] ([Documento], [Empleado], [Propietario_Negocio], [Trabajador_Privado], [Contratista_Independiente], [Pensionado], [Subsidiado], [Accionistas], [Trabajador_Publico], [Ingreso_Actividades], [Desempleado], [Estrato]) VALUES (N'49792922', 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, N'2')
INSERT [dbo].[Sector_Economico] ([Documento], [Empleado], [Propietario_Negocio], [Trabajador_Privado], [Contratista_Independiente], [Pensionado], [Subsidiado], [Accionistas], [Trabajador_Publico], [Ingreso_Actividades], [Desempleado], [Estrato]) VALUES (N'1067806286', 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, N'3')
GO
INSERT [dbo].[Sector_Hogar] ([Documento], [Zona], [Propietario], [Servicio_Agua], [Servicio_Luz], [Servicio_Gas], [Saneamiento], [Adicional], [Habitaciones], [Baños], [Tipo_Vivienda], [Ingreso], [Internet], [Cable], [Telefono], [Vehiculo]) VALUES (N'1003266310', N'urbana', 0, 0, 1, 0, 1, 0, N'6', N'1', N'propia', N'bajo', 1, 0, 1, 0)
INSERT [dbo].[Sector_Hogar] ([Documento], [Zona], [Propietario], [Servicio_Agua], [Servicio_Luz], [Servicio_Gas], [Saneamiento], [Adicional], [Habitaciones], [Baños], [Tipo_Vivienda], [Ingreso], [Internet], [Cable], [Telefono], [Vehiculo]) VALUES (N'1030528223', N'Urbana', 0, 1, 1, 1, 1, 0, N'3', N'1', N'Propia', N'Bajo', 1, 0, 1, 1)
INSERT [dbo].[Sector_Hogar] ([Documento], [Zona], [Propietario], [Servicio_Agua], [Servicio_Luz], [Servicio_Gas], [Saneamiento], [Adicional], [Habitaciones], [Baños], [Tipo_Vivienda], [Ingreso], [Internet], [Cable], [Telefono], [Vehiculo]) VALUES (N'1003266232', N'Urbana', 0, 1, 1, 1, 1, 0, N'', N'1', N'Propia', N'Bajo', 1, 0, 1, 1)
INSERT [dbo].[Sector_Hogar] ([Documento], [Zona], [Propietario], [Servicio_Agua], [Servicio_Luz], [Servicio_Gas], [Saneamiento], [Adicional], [Habitaciones], [Baños], [Tipo_Vivienda], [Ingreso], [Internet], [Cable], [Telefono], [Vehiculo]) VALUES (N'49792922', N'Urbana', 0, 1, 1, 1, 1, 0, N'', N'1', N'Propia', N'Bajo', 1, 0, 1, 1)
INSERT [dbo].[Sector_Hogar] ([Documento], [Zona], [Propietario], [Servicio_Agua], [Servicio_Luz], [Servicio_Gas], [Saneamiento], [Adicional], [Habitaciones], [Baños], [Tipo_Vivienda], [Ingreso], [Internet], [Cable], [Telefono], [Vehiculo]) VALUES (N'1067806286', N'Urbana', 0, 1, 1, 1, 0, 0, N'', N'4', N'Propia', N'Medio', 1, 0, 0, 1)
GO
INSERT [dbo].[SectorSocial] ([Documento], [Afliado], [Victima_Conflicto], [Etnia], [Acceso_Estudio], [Servicio_Transporte], [Estado_Civil], [NivelEducacion]) VALUES (N'1003266310', 1, 0, N'Wiwa', 1, 1, N'Casado', N'Tecnico')
INSERT [dbo].[SectorSocial] ([Documento], [Afliado], [Victima_Conflicto], [Etnia], [Acceso_Estudio], [Servicio_Transporte], [Estado_Civil], [NivelEducacion]) VALUES (N'1030528223', 0, 1, N'Ninguno', 1, 1, N'Soltero', N'Secundaria')
INSERT [dbo].[SectorSocial] ([Documento], [Afliado], [Victima_Conflicto], [Etnia], [Acceso_Estudio], [Servicio_Transporte], [Estado_Civil], [NivelEducacion]) VALUES (N'1003266232', 0, 1, N'Arhuaco', 1, 1, N'Casado', N'Sin Estudio')
INSERT [dbo].[SectorSocial] ([Documento], [Afliado], [Victima_Conflicto], [Etnia], [Acceso_Estudio], [Servicio_Transporte], [Estado_Civil], [NivelEducacion]) VALUES (N'49792922', 0, 1, N'Ninguno', 1, 1, N'Divorciado', N'Tecnica')
INSERT [dbo].[SectorSocial] ([Documento], [Afliado], [Victima_Conflicto], [Etnia], [Acceso_Estudio], [Servicio_Transporte], [Estado_Civil], [NivelEducacion]) VALUES (N'1067806286', 1, 0, N'Ninguno', 1, 1, N'Soltero', N'Secundaria')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Login]    Script Date: 04/06/2023 20:25:10 ******/
ALTER TABLE [dbo].[Loguin] ADD  CONSTRAINT [UC_Login] UNIQUE NONCLUSTERED 
(
	[Numero_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Persona]    Script Date: 04/06/2023 20:25:10 ******/
ALTER TABLE [dbo].[Persona] ADD  CONSTRAINT [UC_Persona] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_SE]    Script Date: 04/06/2023 20:25:10 ******/
ALTER TABLE [dbo].[Sector_Economico] ADD  CONSTRAINT [UC_SE] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_SH]    Script Date: 04/06/2023 20:25:10 ******/
ALTER TABLE [dbo].[Sector_Hogar] ADD  CONSTRAINT [UC_SH] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UC_Ss]    Script Date: 04/06/2023 20:25:10 ******/
ALTER TABLE [dbo].[SectorSocial] ADD  CONSTRAINT [UC_Ss] UNIQUE NONCLUSTERED 
(
	[Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DbCenso] SET  READ_WRITE 
GO
