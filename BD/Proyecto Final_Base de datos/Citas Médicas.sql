USE [master]
GO
/****** Object:  Database [Citas Médicas ]    Script Date: 10/11/2022 08:39:09 ******/
CREATE DATABASE [Citas Médicas ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Citas Médicas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Citas Médicas .mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Citas Médicas _log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Citas Médicas _log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Citas Médicas ] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Citas Médicas ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Citas Médicas ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Citas Médicas ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Citas Médicas ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Citas Médicas ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Citas Médicas ] SET ARITHABORT OFF 
GO
ALTER DATABASE [Citas Médicas ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Citas Médicas ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Citas Médicas ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Citas Médicas ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Citas Médicas ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Citas Médicas ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Citas Médicas ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Citas Médicas ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Citas Médicas ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Citas Médicas ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Citas Médicas ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Citas Médicas ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Citas Médicas ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Citas Médicas ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Citas Médicas ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Citas Médicas ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Citas Médicas ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Citas Médicas ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Citas Médicas ] SET  MULTI_USER 
GO
ALTER DATABASE [Citas Médicas ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Citas Médicas ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Citas Médicas ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Citas Médicas ] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Citas Médicas ] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Citas Médicas ] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Citas Médicas ] SET QUERY_STORE = OFF
GO
USE [Citas Médicas ]
GO
/****** Object:  User [Karla]    Script Date: 10/11/2022 08:39:09 ******/
CREATE USER [Karla] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[num_Cargo] [numeric](18, 0) NOT NULL,
	[cargo] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[num_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo_Empleados]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo_Empleados](
	[num_Cargo] [numeric](18, 0) NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
	[cargo] [nvarchar](30) NOT NULL,
 CONSTRAINT [IX_Cargo_Empleados] UNIQUE NONCLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[cod_Cita] [numeric](18, 0) NOT NULL,
	[fechaCita] [date] NOT NULL,
	[horaCita] [time](7) NOT NULL,
	[precio] [numeric](18, 0) NOT NULL,
	[consultorio] [numeric](3, 0) NOT NULL,
	[cod_Medico] [numeric](4, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED 
(
	[cod_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Citas] UNIQUE NONCLUSTERED 
(
	[cod_Cita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correo_Empleados]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correo_Empleados](
	[num_Correo] [int] NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Correo_Empleados] PRIMARY KEY CLUSTERED 
(
	[num_Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Correo_Empleados] UNIQUE NONCLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correo_Médicos]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correo_Médicos](
	[num_Correo] [int] NOT NULL,
	[cod_Médico] [numeric](4, 0) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Correo_Médicos] PRIMARY KEY CLUSTERED 
(
	[num_Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Correo_Médicos] UNIQUE NONCLUSTERED 
(
	[cod_Médico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Correo_Pacientes]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Correo_Pacientes](
	[num_Correo] [numeric](18, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[correo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Correo_Pacientes] PRIMARY KEY CLUSTERED 
(
	[num_Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Correo_Pacientes] UNIQUE NONCLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credenciales_Empleados]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales_Empleados](
	[num_Usuario] [numeric](18, 0) NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
	[usuario] [nvarchar](25) NOT NULL,
	[contrasenha] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Credenciales_Empleados] PRIMARY KEY CLUSTERED 
(
	[num_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Credenciales_Empleados] UNIQUE NONCLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credenciales_Medicos]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales_Medicos](
	[num_Usuario] [int] NOT NULL,
	[cod_Medico] [numeric](4, 0) NOT NULL,
	[usuario] [nvarchar](25) NOT NULL,
	[contrasenha] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Credenciales_Medicos] PRIMARY KEY CLUSTERED 
(
	[num_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Credenciales_Medicos] UNIQUE NONCLUSTERED 
(
	[cod_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credenciales_Pacientes]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales_Pacientes](
	[num_Usuario] [numeric](18, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[usuario] [nvarchar](25) NOT NULL,
	[contrasenha] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Credenciales_Pacientes] PRIMARY KEY CLUSTERED 
(
	[num_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Credenciales_Pacientes] UNIQUE NONCLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dias_Consultas]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias_Consultas](
	[num_Dia] [numeric](1, 0) NOT NULL,
	[dia] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Dias_Consultas] PRIMARY KEY CLUSTERED 
(
	[num_Dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disponibilidad_Medicos]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidad_Medicos](
	[num_Dia] [numeric](1, 0) NOT NULL,
	[cod_Medico] [numeric](4, 0) NOT NULL,
	[disponibilidad] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Domicilio_Pacientes]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Domicilio_Pacientes](
	[num_Provincia] [numeric](1, 0) NOT NULL,
	[num_Domicilio] [numeric](1, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[canton] [nvarchar](30) NOT NULL,
	[Distrito] [nvarchar](30) NOT NULL,
	[otrasSenhas] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Domicilio_Pacientes] PRIMARY KEY CLUSTERED 
(
	[num_Domicilio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Domicilio_Pacientes] UNIQUE NONCLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_Empleado] [numeric](4, 0) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[apellido1] [nvarchar](30) NOT NULL,
	[apellido2] [nvarchar](30) NOT NULL,
	[tel] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad_Medicos]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad_Medicos](
	[cod_Especialidad] [numeric](2, 0) NOT NULL,
	[cod_Medico] [numeric](4, 0) NOT NULL,
	[especialidad] [nvarchar](25) NOT NULL,
 CONSTRAINT [IX_Especialidad_Medicos] UNIQUE NONCLUSTERED 
(
	[cod_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[cod_Especialidad] [numeric](2, 0) NOT NULL,
	[especialidad] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[cod_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[id_Factura] [numeric](18, 0) NOT NULL,
	[fechaPago] [date] NOT NULL,
	[subtotal] [numeric](18, 2) NOT NULL,
	[iva] [numeric](18, 2) NOT NULL,
	[total] [numeric](18, 2) NOT NULL,
	[cod_Cita] [numeric](18, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
 CONSTRAINT [PK_Facturacion] PRIMARY KEY CLUSTERED 
(
	[id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Facturacion] UNIQUE NONCLUSTERED 
(
	[id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial_Pacientes]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial_Pacientes](
	[num_Historial] [numeric](18, 0) NOT NULL,
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[historial] [nvarchar](300) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
 CONSTRAINT [PK_Historial_Pacientes] PRIMARY KEY CLUSTERED 
(
	[num_Historial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Historial_Pacientes] UNIQUE NONCLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horario_Empleados]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horario_Empleados](
	[id_Horario] [numeric](2, 0) NOT NULL,
	[id_Empleado] [numeric](4, 0) NOT NULL,
	[dia_Inicio] [nvarchar](10) NOT NULL,
	[dia_Final] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[id_Horario] [numeric](2, 0) NOT NULL,
	[dia_Inicio] [nvarchar](10) NOT NULL,
	[dia_Final] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Horarios] PRIMARY KEY CLUSTERED 
(
	[id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[cod_Médico] [numeric](4, 0) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[apellido1] [nvarchar](30) NOT NULL,
	[apellido2] [nvarchar](30) NOT NULL,
	[tel] [numeric](8, 0) NOT NULL,
 CONSTRAINT [PK_Medicos] PRIMARY KEY CLUSTERED 
(
	[cod_Médico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodo_Pago]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodo_Pago](
	[num_MetodoPago] [numeric](1, 0) NOT NULL,
	[tipo] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Metodo_Pago] PRIMARY KEY CLUSTERED 
(
	[num_MetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Metodo_Pago] UNIQUE NONCLUSTERED 
(
	[num_MetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[id_Paciente] [numeric](4, 0) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[apellido1] [nvarchar](30) NOT NULL,
	[apellido2] [nvarchar](30) NOT NULL,
	[edad] [numeric](3, 0) NOT NULL,
	[tel] [numeric](8, 0) NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Pacientes_1] UNIQUE NONCLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[num_Provincia] [numeric](1, 0) NOT NULL,
	[provincia] [nvarchar](10) NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[num_Provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 10/11/2022 08:39:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Pago](
	[num_MetodoPago] [numeric](1, 0) NOT NULL,
	[id_Factura] [numeric](18, 0) NOT NULL,
	[tipo] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Disponibilidad_Medicos]    Script Date: 10/11/2022 08:39:09 ******/
CREATE NONCLUSTERED INDEX [IX_Disponibilidad_Medicos] ON [dbo].[Disponibilidad_Medicos]
(
	[num_Dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cargo_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Empleados_Cargo] FOREIGN KEY([num_Cargo])
REFERENCES [dbo].[Cargo] ([num_Cargo])
GO
ALTER TABLE [dbo].[Cargo_Empleados] CHECK CONSTRAINT [FK_Cargo_Empleados_Cargo]
GO
ALTER TABLE [dbo].[Cargo_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Empleados_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Cargo_Empleados] CHECK CONSTRAINT [FK_Cargo_Empleados_Empleados]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Empleados]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Medicos] FOREIGN KEY([cod_Medico])
REFERENCES [dbo].[Medicos] ([cod_Médico])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Medicos]
GO
ALTER TABLE [dbo].[Citas]  WITH CHECK ADD  CONSTRAINT [FK_Citas_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Citas] CHECK CONSTRAINT [FK_Citas_Pacientes]
GO
ALTER TABLE [dbo].[Correo_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Correo_Empleados_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Correo_Empleados] CHECK CONSTRAINT [FK_Correo_Empleados_Empleados]
GO
ALTER TABLE [dbo].[Correo_Médicos]  WITH CHECK ADD  CONSTRAINT [FK_Correo_Médicos_Medicos] FOREIGN KEY([cod_Médico])
REFERENCES [dbo].[Medicos] ([cod_Médico])
GO
ALTER TABLE [dbo].[Correo_Médicos] CHECK CONSTRAINT [FK_Correo_Médicos_Medicos]
GO
ALTER TABLE [dbo].[Correo_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Correo_Pacientes_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Correo_Pacientes] CHECK CONSTRAINT [FK_Correo_Pacientes_Pacientes]
GO
ALTER TABLE [dbo].[Credenciales_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Credenciales_Empleados_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Credenciales_Empleados] CHECK CONSTRAINT [FK_Credenciales_Empleados_Empleados]
GO
ALTER TABLE [dbo].[Credenciales_Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Credenciales_Medicos_Medicos] FOREIGN KEY([cod_Medico])
REFERENCES [dbo].[Medicos] ([cod_Médico])
GO
ALTER TABLE [dbo].[Credenciales_Medicos] CHECK CONSTRAINT [FK_Credenciales_Medicos_Medicos]
GO
ALTER TABLE [dbo].[Credenciales_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Credenciales_Pacientes_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Credenciales_Pacientes] CHECK CONSTRAINT [FK_Credenciales_Pacientes_Pacientes]
GO
ALTER TABLE [dbo].[Disponibilidad_Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Disponibilidad_Medicos_Dias_Consultas] FOREIGN KEY([num_Dia])
REFERENCES [dbo].[Dias_Consultas] ([num_Dia])
GO
ALTER TABLE [dbo].[Disponibilidad_Medicos] CHECK CONSTRAINT [FK_Disponibilidad_Medicos_Dias_Consultas]
GO
ALTER TABLE [dbo].[Disponibilidad_Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Disponibilidad_Medicos_Medicos] FOREIGN KEY([cod_Medico])
REFERENCES [dbo].[Medicos] ([cod_Médico])
GO
ALTER TABLE [dbo].[Disponibilidad_Medicos] CHECK CONSTRAINT [FK_Disponibilidad_Medicos_Medicos]
GO
ALTER TABLE [dbo].[Domicilio_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Domicilio_Pacientes_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Domicilio_Pacientes] CHECK CONSTRAINT [FK_Domicilio_Pacientes_Pacientes]
GO
ALTER TABLE [dbo].[Domicilio_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Domicilio_Pacientes_Provincias] FOREIGN KEY([num_Domicilio])
REFERENCES [dbo].[Provincias] ([num_Provincia])
GO
ALTER TABLE [dbo].[Domicilio_Pacientes] CHECK CONSTRAINT [FK_Domicilio_Pacientes_Provincias]
GO
ALTER TABLE [dbo].[Especialidad_Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Especialidad_Medicos_Especialidades] FOREIGN KEY([cod_Especialidad])
REFERENCES [dbo].[Especialidades] ([cod_Especialidad])
GO
ALTER TABLE [dbo].[Especialidad_Medicos] CHECK CONSTRAINT [FK_Especialidad_Medicos_Especialidades]
GO
ALTER TABLE [dbo].[Especialidad_Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Especialidad_Medicos_Medicos] FOREIGN KEY([cod_Medico])
REFERENCES [dbo].[Medicos] ([cod_Médico])
GO
ALTER TABLE [dbo].[Especialidad_Medicos] CHECK CONSTRAINT [FK_Especialidad_Medicos_Medicos]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Citas] FOREIGN KEY([cod_Cita])
REFERENCES [dbo].[Citas] ([cod_Cita])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Citas]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Empleados]
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD  CONSTRAINT [FK_Facturacion_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Facturacion] CHECK CONSTRAINT [FK_Facturacion_Pacientes]
GO
ALTER TABLE [dbo].[Historial_Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Historial_Pacientes_Pacientes] FOREIGN KEY([id_Paciente])
REFERENCES [dbo].[Pacientes] ([id_Paciente])
GO
ALTER TABLE [dbo].[Historial_Pacientes] CHECK CONSTRAINT [FK_Historial_Pacientes_Pacientes]
GO
ALTER TABLE [dbo].[Horario_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Empleados_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleados] ([id_Empleado])
GO
ALTER TABLE [dbo].[Horario_Empleados] CHECK CONSTRAINT [FK_Horario_Empleados_Empleados]
GO
ALTER TABLE [dbo].[Horario_Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Empleados_Horarios] FOREIGN KEY([id_Horario])
REFERENCES [dbo].[Horarios] ([id_Horario])
GO
ALTER TABLE [dbo].[Horario_Empleados] CHECK CONSTRAINT [FK_Horario_Empleados_Horarios]
GO
ALTER TABLE [dbo].[Tipo_Pago]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Pago_Facturacion] FOREIGN KEY([id_Factura])
REFERENCES [dbo].[Facturacion] ([id_Factura])
GO
ALTER TABLE [dbo].[Tipo_Pago] CHECK CONSTRAINT [FK_Tipo_Pago_Facturacion]
GO
ALTER TABLE [dbo].[Tipo_Pago]  WITH CHECK ADD  CONSTRAINT [FK_Tipo_Pago_Metodo_Pago] FOREIGN KEY([num_MetodoPago])
REFERENCES [dbo].[Metodo_Pago] ([num_MetodoPago])
GO
ALTER TABLE [dbo].[Tipo_Pago] CHECK CONSTRAINT [FK_Tipo_Pago_Metodo_Pago]
GO
USE [master]
GO
ALTER DATABASE [Citas Médicas ] SET  READ_WRITE 
GO
