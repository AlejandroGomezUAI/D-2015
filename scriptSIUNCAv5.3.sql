USE [PruebaSIUNCA]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
	[IdEstado] [int] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[LegajoAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Alumno_MateriaCC]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetallesDetMatPlanCorrPlan]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[DetallesPlanDeEstudio]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[IdEstado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[IdEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FamiliaFamilia]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[MateriaCC_Profesor]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[MateriaConCorrelativas]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlanDeEstudio]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
	[iduser] [int] NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Promedio]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[tbl_user]    Script Date: 07/10/2019 05:45:47 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioFamilia]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
/****** Object:  Table [dbo].[UsuarioPatente]    Script Date: 07/10/2019 05:45:47 p.m. ******/
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
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Carrera]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Estado] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[Estado] ([IdEstado])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Estado]
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
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_Profesor_tbl_user] FOREIGN KEY([iduser])
REFERENCES [dbo].[tbl_user] ([iduser])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_Profesor_tbl_user]
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
