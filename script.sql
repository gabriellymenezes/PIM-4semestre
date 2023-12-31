USE [master]
GO
/****** Object:  Database [Tbmahalo]    Script Date: 05/11/2023 22:21:49 ******/
CREATE DATABASE [Tbmahalo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tbmahalo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tbmahalo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tbmahalo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tbmahalo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Tbmahalo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tbmahalo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tbmahalo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tbmahalo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tbmahalo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tbmahalo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tbmahalo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tbmahalo] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Tbmahalo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tbmahalo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tbmahalo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tbmahalo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tbmahalo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tbmahalo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tbmahalo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tbmahalo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tbmahalo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Tbmahalo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tbmahalo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tbmahalo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tbmahalo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tbmahalo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tbmahalo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tbmahalo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tbmahalo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tbmahalo] SET  MULTI_USER 
GO
ALTER DATABASE [Tbmahalo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tbmahalo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tbmahalo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tbmahalo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tbmahalo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tbmahalo] SET QUERY_STORE = OFF
GO
USE [Tbmahalo]
GO
/****** Object:  Table [dbo].[dados_Pessoais]    Script Date: 05/11/2023 22:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dados_Pessoais](
	[IDFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Locala] [varchar](100) NOT NULL,
	[Sexo] [varchar](100) NOT NULL,
	[Estadocivil] [varchar](100) NOT NULL,
	[Escolaridade] [varchar](100) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[CEP] [varchar](10) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[Bairro] [varchar](100) NOT NULL,
	[CPF] [varchar](14) NOT NULL,
	[TipodeContrato] [varchar](100) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Setor] [varchar](50) NOT NULL,
	[Inicio] [date] NOT NULL,
	[Fim] [date] NULL,
	[DataDeNascimento] [date] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[salario] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ferias]    Script Date: 05/11/2023 22:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ferias](
	[id_ferias] [int] IDENTITY(1,1) NOT NULL,
	[IDFuncionario] [int] NOT NULL,
	[dataInicioFerias] [date] NOT NULL,
	[dataTerminoFerias] [date] NOT NULL,
	[duracaoFerias] [int] NOT NULL,
	[valorFerias] [float] NOT NULL,
	[diasAbono] [int] NOT NULL,
	[statusFerias] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ferias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FolhaPagamento]    Script Date: 05/11/2023 22:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FolhaPagamento](
	[IDFolha] [int] IDENTITY(1,1) NOT NULL,
	[IDFuncionario] [int] NOT NULL,
	[mes] [varchar](20) NULL,
	[ano] [int] NOT NULL,
	[horasTrabalhadas] [varchar](50) NOT NULL,
	[horaExtra] [varchar](50) NOT NULL,
	[statusPagamento] [varchar](50) NOT NULL,
	[NovaColunaHorasTrabalhadas] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFolha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistroPonto]    Script Date: 05/11/2023 22:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroPonto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDFuncionario] [int] NOT NULL,
	[Data] [date] NOT NULL,
	[Entrada] [time](7) NULL,
	[Saida] [time](7) NULL,
	[AlmocoInicio] [time](7) NULL,
	[AlmocoFim] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 05/11/2023 22:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Tbmahalo] SET  READ_WRITE 
GO
