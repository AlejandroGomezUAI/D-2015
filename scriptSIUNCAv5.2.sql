USE [master]
GO
/****** Object:  Database [PruebaSIUNCA]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Alumno]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Alumno_MateriaCC]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Asistencia]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Carrera]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Curso]    Script Date: 23/08/2019 09:40:15 ******/
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
	[FechaFin] [date] NOT NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesDetMatPlanCorrPlan]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesDetMatPlanCorrPlan](
	[IdDetallesDetMatPlanCorrPlan] [int] IDENTITY(1,1) NOT NULL,
	[IdPlanDetalles] [int] NOT NULL,
	[IdPlanDetalles2] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[IdDetallesDetMatPlanCorrPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPlanDeEstudio]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Familia]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaFamilia]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaFamilia](
	[IdFamilia] [int] NOT NULL,
	[IdFamiliaHijo] [int] NOT NULL,
 CONSTRAINT [PK_FamiliaFamilia] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[IdFamilia] [int] NOT NULL,
	[IdPatente] [int] NOT NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaCC_Profesor]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[MateriaConCorrelativas]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Patente]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanDeEstudio]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDeEstudio](
	[IdPlanDeEstudio] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[Profesor]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[Promedio]    Script Date: 23/08/2019 09:40:15 ******/
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
/****** Object:  Table [dbo].[tbl_user]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioFamilia]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioFamilia](
	[IdUsuario] [int] NOT NULL,
	[IdFamilia] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioFamilia] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPatente]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPatente](
	[IdUsuario] [int] NOT NULL,
	[IdPatente] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPatente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Juan', N'Perez', N'Masculino', 1, N'jperez@gmail.com', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Federico', N'Lopez', N'Masculino', 2, N'fed21@gmail.com', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] ON 

INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 1, 11, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 1, 12, N'Cursando', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 1, 14, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (31, 1, 33, N'Desaprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (32, 1, 15, N'Desaprobado', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] OFF
SET IDENTITY_INSERT [dbo].[Carrera] ON 

INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Abogacia', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Carrera] OFF
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (4, 27, CAST(N'2019-06-19' AS Date), 14, 1, NULL, NULL, NULL, NULL, CAST(N'2019-06-19' AS Date), N'Noche')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (5, 20, CAST(N'2019-06-19' AS Date), 15, 1, NULL, NULL, NULL, NULL, CAST(N'2019-07-11' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (6, 27, CAST(N'2019-06-19' AS Date), 12, 1, NULL, NULL, NULL, NULL, CAST(N'2020-02-21' AS Date), N'Tarde')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (9, 42, CAST(N'2020-06-23' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2020-09-09' AS Date), N'Tarde')
SET IDENTITY_INSERT [dbo].[Curso] OFF
SET IDENTITY_INSERT [dbo].[DetallesDetMatPlanCorrPlan] ON 

INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (23, 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (24, 3, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (25, 4, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (27, 19, 20, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (28, 22, 21, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesDetMatPlanCorrPlan] OFF
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] ON 

INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, 3, 14, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, 3, 16, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 3, 15, N'Opcional', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 3, 12, N'Opcional', 4, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, 4, 11, N'Obligatoria', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 8, 12, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 8, 14, N'Obligatoria', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 9, 11, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, 9, 12, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (18, 3, 33, N'Obligatoria', 5, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (19, 12, 14, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (20, 12, 16, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (21, 12, 33, N'Obligatoria', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (22, 12, 15, N'Obligatoria', 4, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] OFF
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (1, N'Botón 1 y 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (2, N'Botón 2 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (3, N'Familia Id2 y Botón 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (4, N'Botón 7 y 9')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (5, N'Fam 3 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (6, N'Ban')
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (3, 2)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 3)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 4)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 1)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 2)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 4)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (3, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 7)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 9)
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] ON 

INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, N'Fisica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, N'Quimica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (15, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (16, N'Matematica2', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (29, N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (31, N'Fiolosofia', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (33, N'Ingles2', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] OFF
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (1, N'Botón 1')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (2, N'Botón 2')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (3, N'Botón 3')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (4, N'Botón 4')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (5, N'Botón 5')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (6, N'Botón 6')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (7, N'Botón 7')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (8, N'Botón 8')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (9, N'Botón 9')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (10, N'Botón 10')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (11, N'Botón 11')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (12, N'Botón 12')
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] ON 

INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 1, N'Plan1', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 1, N'sad', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, 1, N'plan 2', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, 2, N'plan3', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 1, N'PLAN4', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 1, N'PLAN551', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] OFF
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1, N'a', N'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', N'asd@asd.com', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (2, N'b', N'3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d', N'asd@asd2.com', N'Profesor')
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (2, 2)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (3, 5)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (4, 5)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 3)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 5)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 6)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 7)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (1, 8)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (2, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 12)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 7)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 10)
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
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan]  WITH CHECK ADD  CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio] FOREIGN KEY([IdPlanDetalles])
REFERENCES [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles])
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan] CHECK CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio]
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan]  WITH CHECK ADD  CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio1] FOREIGN KEY([IdPlanDetalles2])
REFERENCES [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles])
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan] CHECK CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio1]
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
/****** Object:  Trigger [dbo].[TG_ActualizarCupos2]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[TG_ActualizarCupos2]
   on [dbo].[Alumno_MateriaCC]
   for Insert
   as
   Update Curso set Curso.CuposMax = Curso.CuposMax-1
   from Curso inner join
   INSERTED as D on D.IdMateriaCC=Curso.IdMateriaCC
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] ENABLE TRIGGER [TG_ActualizarCupos2]
GO
/****** Object:  Trigger [dbo].[TG_ActualizarCuposAlEliminar]    Script Date: 23/08/2019 09:40:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[TG_ActualizarCuposAlEliminar]
   on [dbo].[Alumno_MateriaCC]
   for delete
   as
   Update Curso set Curso.CuposMax = Curso.CuposMax+1
   from Curso inner join
   INSERTED as D on D.IdMateriaCC=Curso.IdMateriaCC
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] ENABLE TRIGGER [TG_ActualizarCuposAlEliminar]
GO
USE [master]
GO
ALTER DATABASE [PruebaSIUNCA] SET  READ_WRITE 
GO
