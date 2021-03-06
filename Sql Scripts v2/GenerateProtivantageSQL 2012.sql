USE [master]
GO

/****** Object:  Login [Protivantagedb]    Script Date: 10/19/2015 1:43:59 PM ******/
CREATE LOGIN [Protivantagedb] WITH PASSWORD='Ciccm1m1', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

/****** Object:  Database [Protivantage]    Script Date: 08/03/2017 10:45:12 PM ******/
CREATE DATABASE [Protivantage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Protivantage', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Protivantage.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Protivantage_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Protivantage_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Protivantage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Protivantage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Protivantage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Protivantage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Protivantage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Protivantage] SET ARITHABORT OFF 
GO
ALTER DATABASE [Protivantage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Protivantage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Protivantage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Protivantage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Protivantage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Protivantage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Protivantage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Protivantage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Protivantage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Protivantage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Protivantage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Protivantage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Protivantage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Protivantage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Protivantage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Protivantage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Protivantage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Protivantage] SET RECOVERY FULL 
GO
ALTER DATABASE [Protivantage] SET  MULTI_USER 
GO
ALTER DATABASE [Protivantage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Protivantage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Protivantage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Protivantage] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Protivantage', N'ON'
GO
USE [Protivantage]
GO
/****** Object:  User [Protivantagedb]    Script Date: 08/03/2017 10:45:13 PM ******/
CREATE USER [Protivantagedb] FOR LOGIN [Protivantagedb] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Protivantagedb]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Protivantagedb]
GO
/****** Object:  Table [dbo].[tblDosingAlgorithm]    Script Date: 08/03/2017 10:45:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDosingAlgorithm](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Priority] [int] NOT NULL,
	[ReasonForTherapy] [nvarchar](45) NULL,
	[INRLowerLimit] [nvarchar](20) NULL,
	[INRUpperLimit] [nvarchar](20) NULL,
	[IncDec] [nvarchar](40) NULL,
	[PercentageChange] [numeric](18, 2) NULL,
	[VarianceAllowed] [numeric](18, 2) NULL,
	[Comment] [nvarchar](300) NULL,
	[Inactive] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSettings]    Script Date: 08/03/2017 10:45:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSettings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EnterpriseSetting] [bit] NULL,
	[PTCode] [nvarchar](12) NULL,
	[INRCode] [nvarchar](12) NULL,
	[DefaultOverdueInterval] [smallint] NULL,
	[OverdueIntervalAllowOverride] [bit] NULL,
	[DefaultNotify] [bit] NULL,
	[NotifyAllowOverride] [bit] NULL,
	[DefaultTaskPriority] [nchar](35) NULL,
	[TaskPriorityAllowOverride] [bit] NULL,
	[Email] [nvarchar](100) NULL,
	[UserID] [int] NULL,
	[PTDisplayAs] [nvarchar](20) NULL,
	[INRDisplayAs] [nvarchar](20) NULL,
	[MyInterval1] [smallint] NULL,
	[MyInterval2] [smallint] NULL,
	[DefaultTaskType] [nvarchar](35) NULL,
	[DefaultNoteType] [nvarchar](35) NULL,
	[FlowsheetName] [nvarchar](50) NULL,
	[DefaultOverdueTaskType] [nvarchar](35) NULL,
	[DefaultOverdueTaskPriority] [nchar](35) NULL,
	[OverdueTaskPriorityAllowOverride] [bit] NULL,
	[MyIntervalsAllowOverride] [bit] NULL,
	[AdminUser] [nvarchar](40) NULL,
	[InactivityTimeoutMins] [int] NULL,
	[AdminTaskType] [nvarchar](35) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTherapy]    Script Date: 08/03/2017 10:45:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTherapy](
	[TherapyID] [int] IDENTITY(1,1) NOT NULL,
	[TherapyStartDate] [datetime] NULL,
	[ReasonForTherapy] [nvarchar](45) NULL,
	[AdditionalReasonForTherapy] [nvarchar](45) NULL,
	[ExpectedLengthOfTherapy] [nvarchar](30) NULL,
	[PillSizeAtHome] [nchar](8) NULL,
	[INRRange] [nchar](12) NULL,
	[Notify] [bit] NULL,
	[NotifyInterval] [smallint] NULL,
	[PatientID] [bigint] NULL,
	[CurrentDosageInstructions] [nvarchar](200) NULL,
	[Comments] [nvarchar](300) NULL,
	[ManagedBy] [nvarchar](35) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTherapyDetails]    Script Date: 08/03/2017 10:45:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTherapyDetails](
	[TherapyDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [bigint] NOT NULL,
	[NextINR] [datetime] NULL,
	[Instructions] [nvarchar](200) NULL,
	[EvaluationDate] [datetime] NULL,
	[TaskOwner] [nvarchar](35) NULL,
	[Inactive] [bit] NULL,
	[EnteredBy] [int] NULL,
	[EIEBy] [int] NULL,
	[EnteredDTTM] [datetime] NULL,
	[EIEDTTM] [datetime] NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Protivantage] SET  READ_WRITE 
GO
