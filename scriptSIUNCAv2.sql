USE [master]
GO
/****** Object:  Database [PruebaSIUNCA]    Script Date: 20/05/2019 13:36:29 ******/
CREATE DATABASE [PruebaSIUNCA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaSIUNCA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PruebaSIUNCA.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PruebaSIUNCA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PruebaSIUNCA_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PruebaSIUNCA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaSIUNCA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaSIUNCA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaSIUNCA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebaSIUNCA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PruebaSIUNCA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebaSIUNCA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PruebaSIUNCA] SET  MULTI_USER 
GO
ALTER DATABASE [PruebaSIUNCA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebaSIUNCA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebaSIUNCA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebaSIUNCA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PruebaSIUNCA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PruebaSIUNCA]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 20/05/2019 13:36:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[LegajoAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[LegajoAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_MateriaCC]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_MateriaCC](
	[IdAlumno_Materia] [int] IDENTITY(1,1) NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Alumno_Curso] PRIMARY KEY CLUSTERED 
(
	[IdAlumno_Materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[IdAsistencia] [int] IDENTITY(1,1) NOT NULL,
	[Ausente] [varchar](50) NOT NULL,
	[Presente] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[IdCarrera] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[CuposMax] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesCorrelativa]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesCorrelativa](
	[IdDetallesCorrelativa] [int] IDENTITY(1,1) NOT NULL,
	[IdMateria] [int] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[NombreMateria] [varchar](50) NOT NULL,
	[NombreMateriaCC] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_DetallesCorrelativa] PRIMARY KEY CLUSTERED 
(
	[IdDetallesCorrelativa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPlanDeEstudio]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPlanDeEstudio](
	[IdPlanDetalles] [int] IDENTITY(1,1) NOT NULL,
	[IdPlanDeEstudio] [int] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Obligatoriedad] [varchar](50) NOT NULL,
	[NumeroMateria] [int] NOT NULL,
	[NombreMateria] [varchar](50) NOT NULL,
	[Año] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_DetallesPlanDeEstudio] PRIMARY KEY CLUSTERED 
(
	[IdPlanDetalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[IdEvaluacion] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[LegajoProfesor] [int] NOT NULL,
	[Nota] [float] NOT NULL,
	[TipoDeNota] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[IdEvaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaCC_Profesor]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaCC_Profesor](
	[IdMateriaCC_Profesor] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Legajo] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_MateriaCC_Profesor] PRIMARY KEY CLUSTERED 
(
	[IdMateriaCC_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaConCorrelativas]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaConCorrelativas](
	[IdMateriaCC] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_MateriaConCorrelativas] PRIMARY KEY CLUSTERED 
(
	[IdMateriaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materias]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Materias] PRIMARY KEY CLUSTERED 
(
	[IdMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanDeEstudio]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDeEstudio](
	[IdPlanDeEstudio] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[NombreCarrera] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_PlanDeEstudio_1] PRIMARY KEY CLUSTERED 
(
	[IdPlanDeEstudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promedio]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promedio](
	[IdPromedio] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[NotaPromedio] [float] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Promedio] PRIMARY KEY CLUSTERED 
(
	[IdPromedio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 20/05/2019 13:36:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Juan', N'Perez', N'Masculino', 1, N'jperez@gmail.com', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Federico', N'Lopez', N'Masculino', 2, N'fed21@gmail.com', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] ON 

INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 1, 11, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 1, 12, N'Desaprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 1, 14, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, 1, 16, N'Aprobado', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] OFF
SET IDENTITY_INSERT [dbo].[Carrera] ON 

INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Abogacia', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Carrera] OFF
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 50, CAST(N'2016-11-01' AS Date), 14, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, 50, CAST(N'2016-11-01' AS Date), 15, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (6, 21, CAST(N'2016-11-22' AS Date), 14, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Curso] OFF
SET IDENTITY_INSERT [dbo].[DetallesCorrelativa] ON 

INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 1, 11, N'Matematica', N'Fisica', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 2, 11, N'Matematica2', N'Fisica', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, 4, 12, N'Ingles', N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 7, 14, N'Ninguna', N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 7, 15, N'Ninguna', N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 1, 16, N'Matematica', N'Matematica2', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 2, 17, N'Matematica2', N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 1, 18, N'Matematica', N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (20, 5, 29, N'Ingles2', N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (21, 5, 30, N'Ingles2', N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (22, 7, 31, N'Ninguna', N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesCorrelativa] ([IdDetallesCorrelativa], [IdMateria], [IdMateriaCC], [NombreMateria], [NombreMateriaCC], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (23, 1, 32, N'Matematica', N'Matematica2', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesCorrelativa] OFF
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] ON 

INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, 3, 14, N'Obligatoria', 1, N'Matematica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, 3, 16, N'Obligatoria', 2, N'Matematica2', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 3, 15, N'Opcional', 3, N'Ingles', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 3, 12, N'Opcional', 4, N'Ingles3', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, 4, 11, N'Obligatoria', 1, N'Fisica', 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (6, 7, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, 7, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, 7, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 7, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 8, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 8, 12, N'Obligatoria', 2, N'Ingles3', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 8, 14, N'Obligatoria', 3, N'Matematica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 9, 11, N'Obligatoria', 1, N'Fisica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, 9, 12, N'Obligatoria', 1, N'Ingles3', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (15, 9, 18, N'Obligatoria', 3, N'Matematica', 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [NombreMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (16, 9, 30, N'Obligatoria', 4, N'Ingles', 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] OFF
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] ON 

INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, N'Fisica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (15, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (16, N'Matematica2', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (17, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (18, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (29, N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (30, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (31, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (32, N'Matematica2', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] OFF
SET IDENTITY_INSERT [dbo].[Materias] ON 

INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Matematica2', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, N'Fisica', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, N'Ingles2', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (6, N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[Materias] ([IdMateria], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, N'Ninguna', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Materias] OFF
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] ON 

INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [NombreCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 1, N'Plan1', N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [NombreCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 1, N'sad', N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [NombreCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, 1, N'plan 2', N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [NombreCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, 2, N'plan3', N'Abogacia', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [NombreCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 1, N'PLAN4', N'Sistemas', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] OFF
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Carrera]
GO
ALTER TABLE [dbo].[Alumno_MateriaCC]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Materia_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] CHECK CONSTRAINT [FK_Alumno_Materia_Alumno]
GO
ALTER TABLE [dbo].[Alumno_MateriaCC]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Materia_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] CHECK CONSTRAINT [FK_Alumno_Materia_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Alumno]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Carrera]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[DetallesCorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_DetallesCorrelativa_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[DetallesCorrelativa] CHECK CONSTRAINT [FK_DetallesCorrelativa_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[DetallesCorrelativa]  WITH CHECK ADD  CONSTRAINT [FK_DetallesCorrelativa_Materias] FOREIGN KEY([IdMateria])
REFERENCES [dbo].[Materias] ([IdMateria])
GO
ALTER TABLE [dbo].[DetallesCorrelativa] CHECK CONSTRAINT [FK_DetallesCorrelativa_Materias]
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPlanDeEstudio_MateriaConCorrelativas1] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio] CHECK CONSTRAINT [FK_DetallesPlanDeEstudio_MateriaConCorrelativas1]
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPlanDeEstudio_PlanDeEstudio] FOREIGN KEY([IdPlanDeEstudio])
REFERENCES [dbo].[PlanDeEstudio] ([IdPlanDeEstudio])
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio] CHECK CONSTRAINT [FK_DetallesPlanDeEstudio_PlanDeEstudio]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Alumno]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Profesor] FOREIGN KEY([LegajoProfesor])
REFERENCES [dbo].[Profesor] ([Legajo])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Profesor]
GO
ALTER TABLE [dbo].[MateriaCC_Profesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaCC_Profesor_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[MateriaCC_Profesor] CHECK CONSTRAINT [FK_MateriaCC_Profesor_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[MateriaCC_Profesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaCC_Profesor_Profesor] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Profesor] ([Legajo])
GO
ALTER TABLE [dbo].[MateriaCC_Profesor] CHECK CONSTRAINT [FK_MateriaCC_Profesor_Profesor]
GO
ALTER TABLE [dbo].[PlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_PlanDeEstudio_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[PlanDeEstudio] CHECK CONSTRAINT [FK_PlanDeEstudio_Carrera]
GO
ALTER TABLE [dbo].[Promedio]  WITH CHECK ADD  CONSTRAINT [FK_Promedio_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Promedio] CHECK CONSTRAINT [FK_Promedio_Alumno]
GO
ALTER TABLE [dbo].[Promedio]  WITH CHECK ADD  CONSTRAINT [FK_Promedio_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Promedio] CHECK CONSTRAINT [FK_Promedio_MateriaConCorrelativas]
GO
USE [master]
GO
ALTER DATABASE [PruebaSIUNCA] SET  READ_WRITE 
GO
