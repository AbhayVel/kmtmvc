USE [Workday]
GO
/****** Object:  StoredProcedure [dbo].[GetSubject]    Script Date: 28-07-2021 09:59:35 ******/
DROP PROCEDURE [dbo].[GetSubject]
GO
/****** Object:  StoredProcedure [dbo].[GetData]    Script Date: 28-07-2021 09:59:35 ******/
DROP PROCEDURE [dbo].[GetData]
GO
/****** Object:  StoredProcedure [dbo].[AddUpdateDepartment]    Script Date: 28-07-2021 09:59:35 ******/
DROP PROCEDURE [dbo].[AddUpdateDepartment]
GO
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK__User__Dept_Id]
GO
/****** Object:  Table [dbo].[User]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type in (N'U'))
DROP TABLE [dbo].[Subject]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
DROP TABLE [dbo].[LoginUser]
GO
/****** Object:  Table [dbo].[Entity2]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entity2]') AND type in (N'U'))
DROP TABLE [dbo].[Entity2]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Entity]') AND type in (N'U'))
DROP TABLE [dbo].[Entity]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 28-07-2021 09:59:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Department]') AND type in (N'U'))
DROP TABLE [dbo].[Department]
GO
USE [master]
GO
/****** Object:  Database [Workday]    Script Date: 28-07-2021 09:59:35 ******/
DROP DATABASE [Workday]
GO
/****** Object:  Database [Workday]    Script Date: 28-07-2021 09:59:35 ******/
CREATE DATABASE [Workday]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Workday', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workday.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Workday_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Workday_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Workday] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Workday].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Workday] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Workday] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Workday] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Workday] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Workday] SET ARITHABORT OFF 
GO
ALTER DATABASE [Workday] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Workday] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Workday] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Workday] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Workday] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Workday] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Workday] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Workday] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Workday] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Workday] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Workday] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Workday] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Workday] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Workday] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Workday] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Workday] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Workday] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Workday] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Workday] SET  MULTI_USER 
GO
ALTER DATABASE [Workday] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Workday] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Workday] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Workday] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Workday] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Workday] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Workday] SET QUERY_STORE = OFF
GO
USE [Workday]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](400) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entity2]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entity2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](400) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginUser](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[FIrstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Age] [decimal](18, 10) NULL,
	[Dept_Id] [int] NULL,
	[Gender] [varchar](10) NULL,
	[address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'C sharp')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'A')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (3, N'Selenium')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (4, N'Javascript')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (5, N'Javascript')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (6, N'aa')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (7, N'aa')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (8, N'aa')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (9, N'Spring')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Entity] ON 

INSERT [dbo].[Entity] ([id], [name]) VALUES (1, N'Table')
INSERT [dbo].[Entity] ([id], [name]) VALUES (2, N'Person')
SET IDENTITY_INSERT [dbo].[Entity] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginUser] ON 

INSERT [dbo].[LoginUser] ([id], [UserName], [Password], [Role], [FIrstName], [LastName]) VALUES (1, N'abhayv', N'abc', N'Admin', N'Abhay', N'Velankar')
INSERT [dbo].[LoginUser] ([id], [UserName], [Password], [Role], [FIrstName], [LastName]) VALUES (2, N'sanojs', N'abc', N'sales', N'Sanoj', N'S')
INSERT [dbo].[LoginUser] ([id], [UserName], [Password], [Role], [FIrstName], [LastName]) VALUES (3, N'ajayy', N'abc', N'dept', N'Ajay', N'Y')
SET IDENTITY_INSERT [dbo].[LoginUser] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Id], [Name]) VALUES (1, N'Angular   ')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (2, N'Selenium  ')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (3, N'Java      ')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (4, N'.Net      ')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (5, N'MVC       ')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (6, N'Protractor')
INSERT [dbo].[Subject] ([Id], [Name]) VALUES (7, N'JMEter    ')
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Age], [Dept_Id], [Gender], [address]) VALUES (2, N'Ajay', N'Y', CAST(21.0000000000 AS Decimal(18, 10)), 2, N'Male', NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Age], [Dept_Id], [Gender], [address]) VALUES (3, N'Ajay', N'S', CAST(23.0000000000 AS Decimal(18, 10)), 1, N'Male', NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Age], [Dept_Id], [Gender], [address]) VALUES (4, N'Aniket', N'k', CAST(23.0000000000 AS Decimal(18, 10)), 1, N'Male', NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [Age], [Dept_Id], [Gender], [address]) VALUES (5, N'Rajkapoor', N'y', CAST(35.0000000000 AS Decimal(18, 10)), 2, N'Male', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK__User__Dept_Id] FOREIGN KEY([Dept_Id])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK__User__Dept_Id]
GO
/****** Object:  StoredProcedure [dbo].[AddUpdateDepartment]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUpdateDepartment]
	-- Add the parameters for the stored procedure here

	@Id int,
	@name Varchar(50)
 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;



	if(@id=0)
	Begin
			insert into [dbo].[Department]
			Values(@name)
			Select @id =@@IDENTITY
	End
	else 
	Begin
	Update [dbo].[Department] set name=@name Where id=@id

	End

	Select *, 'd' as Data from [dbo].[Department] Where id=@id
 
 
END
GO
/****** Object:  StoredProcedure [dbo].[GetData]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetData](

@OrderBy Varchar(500)
)
As
Begin

	Select  u.Id, FirstName, LastName, Age, Dept_Id, Gender,  address , d.Name as 
	Department from 
	[dbo].[User] u inner join 
	[dbo].[Department] d on u.Dept_Id=d.Id Where 1= 1  Order By Age asc  

End
GO
/****** Object:  StoredProcedure [dbo].[GetSubject]    Script Date: 28-07-2021 09:59:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create  PROCEDURE [dbo].[GetSubject]
	-- Add the parameters for the stored procedure here
	@id int,
	@name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if(@id=0)
	BEGIN
	Select @id=null;
	END
    -- Insert statements for procedure here
	Select id, Name from dbo.Subject Where Id=ISNULL(@id,Id)  and Name like '%' + ISNULL(@name,Name) + '%' ;
END
GO
USE [master]
GO
ALTER DATABASE [Workday] SET  READ_WRITE 
GO
