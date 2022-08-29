USE [master]
GO
/****** Object:  Database [Policy Registration]    Script Date: 08/29/2022 08:51:26 ******/
CREATE DATABASE [Policy Registration] ON  PRIMARY 
( NAME = N'Policy Registration', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Policy Registration.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Policy Registration_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Policy Registration_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Policy Registration] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Policy Registration].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Policy Registration] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Policy Registration] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Policy Registration] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Policy Registration] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Policy Registration] SET ARITHABORT OFF
GO
ALTER DATABASE [Policy Registration] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Policy Registration] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Policy Registration] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Policy Registration] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Policy Registration] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Policy Registration] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Policy Registration] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Policy Registration] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Policy Registration] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Policy Registration] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Policy Registration] SET  DISABLE_BROKER
GO
ALTER DATABASE [Policy Registration] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Policy Registration] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Policy Registration] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Policy Registration] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Policy Registration] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Policy Registration] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Policy Registration] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Policy Registration] SET  READ_WRITE
GO
ALTER DATABASE [Policy Registration] SET RECOVERY FULL
GO
ALTER DATABASE [Policy Registration] SET  MULTI_USER
GO
ALTER DATABASE [Policy Registration] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Policy Registration] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Policy Registration', N'ON'
GO
USE [Policy Registration]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 08/29/2022 08:51:29 ******/
DROP TABLE [dbo].[Address]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 08/29/2022 08:51:29 ******/
DROP TABLE [dbo].[CustomerDetails]
GO
/****** Object:  Table [dbo].[MstModule]    Script Date: 08/29/2022 08:51:29 ******/
DROP TABLE [dbo].[MstModule]
GO
/****** Object:  Table [dbo].[PolicyDtls]    Script Date: 08/29/2022 08:51:29 ******/
DROP TABLE [dbo].[PolicyDtls]
GO
/****** Object:  Table [dbo].[UserDtls]    Script Date: 08/29/2022 08:51:29 ******/
DROP TABLE [dbo].[UserDtls]
GO
/****** Object:  Table [dbo].[UserDtls]    Script Date: 08/29/2022 08:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDtls](
	[RecID] [nchar](10) NULL,
	[UserId] [nchar](10) NULL,
	[UserStatus] [nchar](10) NULL,
	[UserName] [nchar](10) NULL,
	[UserPin] [nchar](10) NULL,
	[LastPINChangedDate] [nchar](10) NULL,
	[LastAccessDate] [nchar](10) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDt] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDt] [datetime] NULL,
	[SessionID] [nchar](10) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PolicyDtls]    Script Date: 08/29/2022 08:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PolicyDtls](
	[RecID] [int] IDENTITY(1,1) NOT NULL,
	[CustID] [varchar](50) NULL,
	[PolicyNo] [varchar](50) NULL,
	[PolicyStatus] [varchar](50) NULL,
	[ProductCode] [varchar](50) NULL,
	[ProductType] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[PolicyTerm] [varchar](50) NULL,
	[StartDt] [datetime] NULL,
	[EndDt] [datetime] NULL,
	[LOB] [varchar](50) NULL,
	[PremiumAmt] [decimal](18, 0) NULL,
	[SumInsured] [decimal](18, 0) NULL,
	[AgtCode] [varchar](50) NULL,
	[ModeOfPremium] [varchar](50) NULL,
	[PolIssuedt] [varchar](50) NULL,
	[CurrentStatus] [varchar](50) NULL,
	[AnnualPremium] [varchar](50) NULL,
	[LastPremiumdt] [varchar](50) NULL,
	[PremDueDt] [varchar](50) NULL,
	[PREMIUM_PAYING_TERM] [varchar](50) NULL,
	[Manager_Code] [varchar](50) NULL,
	[OFFICE_CD] [varchar](50) NULL,
	[CHANNEL_ID] [varchar](50) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDt] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MstModule]    Script Date: 08/29/2022 08:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MstModule](
	[RecID] [nchar](10) NULL,
	[ModuleId] [nchar](10) NULL,
	[ModuleCode] [nchar](10) NULL,
	[ParentModuleId] [nchar](10) NULL,
	[RootModuleId] [nchar](10) NULL,
	[ModuleName] [nchar](10) NULL,
	[ModuleDesc01] [nchar](10) NULL,
	[ModuleDesc02] [nchar](10) NULL,
	[ModuleDesc03] [nchar](10) NULL,
	[Modusequence] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 08/29/2022 08:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[RecID] [int] IDENTITY(1,1) NOT NULL,
	[CustID] [varchar](50) NOT NULL,
	[FName] [char](50) NULL,
	[Mname] [char](50) NULL,
	[Lname] [char](50) NULL,
	[DOB] [varchar](12) NULL,
	[MobNo] [varchar](10) NULL,
	[TelNo] [varchar](10) NULL,
	[EmailId1] [varchar](50) NULL,
	[EmailId2] [varchar](50) NULL,
	[PanNo] [varchar](20) NULL,
	[MotherName] [char](50) NULL,
	[QualificationDetails] [varchar](50) NULL,
	[MaritalStatus] [char](50) NULL,
	[NomineeName] [char](50) NULL,
	[NomineeAge] [int] NULL,
	[NomineeContNo] [varchar](10) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDt] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDt] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_CustomerDetails] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Address]    Script Date: 08/29/2022 08:51:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[RecID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [varchar](50) NULL,
	[Address1] [varchar](50) NULL,
	[Address2] [varchar](50) NULL,
	[Address3] [varchar](50) NULL,
	[District] [varchar](100) NULL,
	[Pincode] [varchar](10) NULL,
	[State] [varchar](100) NULL,
	[Type] [varchar](100) NULL,
	[CreatedBy] [varchar](50) NULL,
	[CreatedDt] [datetime] NULL,
	[UpdatedBy] [varchar](50) NULL,
	[UpdatedDt] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
