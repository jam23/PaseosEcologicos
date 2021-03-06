USE [master]
GO
/****** Object:  Database [PaseosEcologicos]    Script Date: 04/09/2014 22:14:55 ******/
CREATE DATABASE [PaseosEcologicos] ON  PRIMARY 
( NAME = N'PaseosEcologicos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\PaseosEcologicos.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PaseosEcologicos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\PaseosEcologicos_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PaseosEcologicos] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PaseosEcologicos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PaseosEcologicos] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [PaseosEcologicos] SET ANSI_NULLS OFF
GO
ALTER DATABASE [PaseosEcologicos] SET ANSI_PADDING OFF
GO
ALTER DATABASE [PaseosEcologicos] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [PaseosEcologicos] SET ARITHABORT OFF
GO
ALTER DATABASE [PaseosEcologicos] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [PaseosEcologicos] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [PaseosEcologicos] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [PaseosEcologicos] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [PaseosEcologicos] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [PaseosEcologicos] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [PaseosEcologicos] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [PaseosEcologicos] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [PaseosEcologicos] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [PaseosEcologicos] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [PaseosEcologicos] SET  ENABLE_BROKER
GO
ALTER DATABASE [PaseosEcologicos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [PaseosEcologicos] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [PaseosEcologicos] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [PaseosEcologicos] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [PaseosEcologicos] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [PaseosEcologicos] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [PaseosEcologicos] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [PaseosEcologicos] SET  READ_WRITE
GO
ALTER DATABASE [PaseosEcologicos] SET RECOVERY FULL
GO
ALTER DATABASE [PaseosEcologicos] SET  MULTI_USER
GO
ALTER DATABASE [PaseosEcologicos] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [PaseosEcologicos] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'PaseosEcologicos', N'ON'
GO
USE [PaseosEcologicos]
GO
/****** Object:  Table [dbo].[Tipos_De_Servicios]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tipos_De_Servicios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](60) NULL,
	[Descripcion] [text] NULL,
 CONSTRAINT [PK_Tipos_De_Servicios_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tipos_De_Servicios] ON
INSERT [dbo].[Tipos_De_Servicios] ([Id], [Titulo], [Descripcion]) VALUES (1, N'Alojamientos', NULL)
INSERT [dbo].[Tipos_De_Servicios] ([Id], [Titulo], [Descripcion]) VALUES (2, N'Comidas', NULL)
INSERT [dbo].[Tipos_De_Servicios] ([Id], [Titulo], [Descripcion]) VALUES (3, N'Deportes', NULL)
SET IDENTITY_INSERT [dbo].[Tipos_De_Servicios] OFF
/****** Object:  Table [dbo].[Clientes]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AfiliadorId] [int] NULL,
	[Nombre] [varchar](60) NULL,
	[Apellido] [varchar](60) NULL,
	[Celular] [varchar](15) NULL,
	[Correo] [text] NULL,
 CONSTRAINT [PK_Clientes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON
INSERT [dbo].[Clientes] ([Id], [AfiliadorId], [Nombre], [Apellido], [Celular], [Correo]) VALUES (1, NULL, N'Juan', N'Acosta', N'21412', N'correo')
INSERT [dbo].[Clientes] ([Id], [AfiliadorId], [Nombre], [Apellido], [Celular], [Correo]) VALUES (2, NULL, N'Anthony', N'Del rosario', N'q212', N'sgs')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
/****** Object:  Table [dbo].[Paseos]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paseos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](60) NULL,
	[Descripcion] [text] NULL,
	[FechaDePartida] [datetime] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Paseos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Paseos] ON
INSERT [dbo].[Paseos] ([Id], [Titulo], [Descripcion], [FechaDePartida], [Precio]) VALUES (1, N'Paseo 1', N'Paseo 1', CAST(0x0000901A00000000 AS DateTime), 23.0000)
INSERT [dbo].[Paseos] ([Id], [Titulo], [Descripcion], [FechaDePartida], [Precio]) VALUES (2, N'p', N'p', NULL, 6768.0000)
SET IDENTITY_INSERT [dbo].[Paseos] OFF
/****** Object:  Table [dbo].[Servicios]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Servicios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoId] [int] NULL,
	[Titulo] [varchar](60) NULL,
	[Descripcion] [text] NULL,
	[Precio] [money] NULL,
	[Implementos_Obligatorios] [bit] NULL,
 CONSTRAINT [PK_Servicios_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Servicios] ON
INSERT [dbo].[Servicios] ([Id], [TipoId], [Titulo], [Descripcion], [Precio], [Implementos_Obligatorios]) VALUES (1, 1, N'Cabana', NULL, 21.0000, 0)
INSERT [dbo].[Servicios] ([Id], [TipoId], [Titulo], [Descripcion], [Precio], [Implementos_Obligatorios]) VALUES (2, 3, N'Deporte', NULL, 3.0000, NULL)
SET IDENTITY_INSERT [dbo].[Servicios] OFF
/****** Object:  Table [dbo].[Reservaciones]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reservaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NULL,
	[PaseoId] [int] NULL,
	[Cantidad_De_Personas] [int] NULL,
	[Codigo_Verificacion] [varchar](10) NULL,
 CONSTRAINT [PK_Reservaciones_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Reservaciones] ON
INSERT [dbo].[Reservaciones] ([Id], [ClienteId], [PaseoId], [Cantidad_De_Personas], [Codigo_Verificacion]) VALUES (3, 1, 1, 15, N'1111')
INSERT [dbo].[Reservaciones] ([Id], [ClienteId], [PaseoId], [Cantidad_De_Personas], [Codigo_Verificacion]) VALUES (4, 2, 1, 45, N'fdhsdf')
SET IDENTITY_INSERT [dbo].[Reservaciones] OFF
/****** Object:  Table [dbo].[Servicios_Consumidos]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios_Consumidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservacionId] [int] NULL,
	[ClienteId] [int] NULL,
	[ServicioId] [int] NULL,
 CONSTRAINT [PK_ServiciosConsumidos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Implementos]    Script Date: 04/09/2014 22:14:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Implementos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServicioId] [int] NULL,
	[Titulo] [varchar](60) NULL,
	[Descripcion] [text] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Implementos_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__Servicios__Imple__09DE7BCC]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Servicios] ADD  DEFAULT ((0)) FOR [Implementos_Obligatorios]
GO
/****** Object:  ForeignKey [FK_Clientes_Clientes_AfiliadorId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Clientes_AfiliadorId] FOREIGN KEY([AfiliadorId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Clientes_AfiliadorId]
GO
/****** Object:  ForeignKey [FK_Servicios_Tipos_De_Servicios_TipoId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Servicios]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_Tipos_De_Servicios_TipoId] FOREIGN KEY([TipoId])
REFERENCES [dbo].[Tipos_De_Servicios] ([Id])
GO
ALTER TABLE [dbo].[Servicios] CHECK CONSTRAINT [FK_Servicios_Tipos_De_Servicios_TipoId]
GO
/****** Object:  ForeignKey [FK_Reservaciones_Clientes_ClienteId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Clientes_ClienteId]
GO
/****** Object:  ForeignKey [FK_Reservaciones_Paseos_PaseoId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Paseos_PaseoId] FOREIGN KEY([PaseoId])
REFERENCES [dbo].[Paseos] ([Id])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Paseos_PaseoId]
GO
/****** Object:  ForeignKey [FK_Servicios_Consumidos_ReservacionId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Servicios_Consumidos]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_Consumidos_ReservacionId] FOREIGN KEY([ReservacionId])
REFERENCES [dbo].[Reservaciones] ([Id])
GO
ALTER TABLE [dbo].[Servicios_Consumidos] CHECK CONSTRAINT [FK_Servicios_Consumidos_ReservacionId]
GO
/****** Object:  ForeignKey [FK_ServiciosConsumidos_Clientes_ClienteId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Servicios_Consumidos]  WITH CHECK ADD  CONSTRAINT [FK_ServiciosConsumidos_Clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Servicios_Consumidos] CHECK CONSTRAINT [FK_ServiciosConsumidos_Clientes_ClienteId]
GO
/****** Object:  ForeignKey [FK_ServiciosConsumidos_Servicios_ServicioId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Servicios_Consumidos]  WITH CHECK ADD  CONSTRAINT [FK_ServiciosConsumidos_Servicios_ServicioId] FOREIGN KEY([ServicioId])
REFERENCES [dbo].[Servicios] ([Id])
GO
ALTER TABLE [dbo].[Servicios_Consumidos] CHECK CONSTRAINT [FK_ServiciosConsumidos_Servicios_ServicioId]
GO
/****** Object:  ForeignKey [FK_Implementos_Servicios_ServicioId]    Script Date: 04/09/2014 22:14:56 ******/
ALTER TABLE [dbo].[Implementos]  WITH CHECK ADD  CONSTRAINT [FK_Implementos_Servicios_ServicioId] FOREIGN KEY([ServicioId])
REFERENCES [dbo].[Servicios] ([Id])
GO
ALTER TABLE [dbo].[Implementos] CHECK CONSTRAINT [FK_Implementos_Servicios_ServicioId]
GO
