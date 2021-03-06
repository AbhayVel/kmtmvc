USE [students]
GO
/****** Object:  StoredProcedure [dbo].[AddUpdateSubject]    Script Date: 28-07-2021 09:40:30 ******/
DROP PROCEDURE [dbo].[AddUpdateSubject]
GO
ALTER TABLE [dbo].[TblStudents] DROP CONSTRAINT [FK_TblStudents_TblSubjects]
GO
/****** Object:  Table [dbo].[TblSubjects]    Script Date: 28-07-2021 09:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TblSubjects]') AND type in (N'U'))
DROP TABLE [dbo].[TblSubjects]
GO
/****** Object:  Table [dbo].[TblStudents]    Script Date: 28-07-2021 09:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TblStudents]') AND type in (N'U'))
DROP TABLE [dbo].[TblStudents]
GO
/****** Object:  Table [dbo].[TblLoginUser]    Script Date: 28-07-2021 09:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TblLoginUser]') AND type in (N'U'))
DROP TABLE [dbo].[TblLoginUser]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 28-07-2021 09:40:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__MigrationHistory]') AND type in (N'U'))
DROP TABLE [dbo].[__MigrationHistory]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 28-07-2021 09:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblLoginUser]    Script Date: 28-07-2021 09:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblLoginUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[password] [varchar](500) NULL,
 CONSTRAINT [PK_TblLoginUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudents]    Script Date: 28-07-2021 09:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudents](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Doj] [datetime] NULL,
	[Age] [decimal](18, 2) NULL,
	[SubjectID] [int] NULL,
 CONSTRAINT [PK_dbo.TblStudents] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSubjects]    Script Date: 28-07-2021 09:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSubjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.TblSubjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202107010313173_InitialCreate', N'first.studentsEntities', 0x1F8B0800000000000400CD59CD6EE33610BE17E83B083AB545D672B2976D60EF227592C2E8E6079177D1DB8296C60EB714A592546063D127EBA18FD457E850FF222D4B763769918B4CCD7CF3C38F9CD1E4EF3FFF9ABCDB44CC79022169CCA7EEE968EC3AC08338A47C3D7553B57AF5C67DF7F6DB6F265761B4713E9672AFB51C6A7239751F954ACE3D4F068F1011398A68206219AFD42888238F84B177361EFFE89D9E7A80102E6239CEE421E58A4690FDC09FB3980790A894B09B3804268B757CE367A8CE2D8940262480A9BBA2422AD7B96094A0711FD8CA7508E7B1220A5D3BFF20C15722E66B3FC105C216DB04506E459884C2E5F35A7CA8F7E333EDBD572B9650412A551C1D0878FABA488767AA1F9554B74A1726EC0A13ABB63AEA2C695377B164BE4A43E09834D3DCF98C092D5A647554CB9E38D9CA49B5E5C80CFD77E2CC52A65201530EA912849D38F7E992D1E017D82EE2DF804F79CA58D323F409DFB51670E95EC40908B57D8055E1270D5DC76BEB79A662A5D6D0C9FD9F73F5FACC756ED1385932A836BC11ABAF62013F0307411484F7442910B85F731D2EA6CCB26ED8BAD6F9D08FA549A4191E12D7B9219BF7C0D7EA71EAE2A3EB5CD30D84E54AE1C6074EF14CA1921229F4597A4F5EC8D065FCB9B471893959D0A857E5625DB97509018D08739D7B814FC5FDF1C675FC80E80D38EB83F2D3E56708D4FCD2D84343EB963CD175B68386BE266B0EE13A0FC03211F94893FC5218D5AF3FD5B496983511470F316B0134253E2D885803622EE2BD627E9C8AC0C8D7C4AB8F5FEFA12C7D1F722873D9973F94F3230EE5FC050FE5F31C93BD94AB88F435395792A9877325358770EE42CA38A0998716E95ADEB563BFE2A133CCD53CE9EDB031FBC8449A20F7D0A5A93B1E8D4EADF4F69AA84E60DB4459C5DA267E30D3D108DC3E83D8692842916E454E6461337B4B41EE388ED851142752167C31C3D1C03EA85D24A9F7664720565E6CA03C3B5D4065D20DA0460676A1B5B9D910DECF62F3B618CC942A2E2324EF60C492180662158B7955B513B1E3D05474A83B4E2F6F39CBD6D4EBE84D27372449F0BE69F4AAC58AE3E78DEAEC957F783B17E5185E2077747595B79525BC3DC91A8CB7681A3DCDFA152CEB6449F48D370B234BCC227F071F4B7336BFED1D2C595AEAE8E75CCF6C314DE53A83D718548412597CB073B36DE5EC6381302276F488B398A511EFEA33F76937BABE264863793856DDD735A1EAD5E14859E3D604C91686EB675D5C533F5B18AEDF68DD9A288D651B6BE219BB6B72C7B3C8639C66938F83D95ADE38C7B1B5B8648F636B97725766E7065BED066C9FB6CDAE2E663DF76EB46FDEAE2D6957A2EEE4B7E586DF0ABAA2747E35ECAA55769E06ED520374D786E964557E1CED6251FC06BA38E4DADBEB17D6899066DDE35CEA0EBEEA9D07076ED65F9B28561936452A9A56E5D828BB93A204F6CF8DAC9A988BE8CFD7F88986BA1EFA5BA9201A698191FF3B9B319AB569A5C00DE1740552E59F54EED9F8F4CC9843FD7F66429E94211B3C187AF1710DD579EDFDF6B33E1C0F9CD0F02722824722BE8BC8E6FB26DC3153987F05D698B48418ACCA262D874134262F61EFE4E530686B12936DCF6118C64DD0C0B13EA8E63C84CDD4FD92699E3BF35F3FB5944F9C3B81A7EDDC193B7FECF7E29871CB8B0F419E85EA4712F30566055F6F30507E251F3305D0FF628015089D5EC2B0BC4825B0C0585DCEBDA03CA00961761C769D1DC20C9DE30AD47C73090970EDBD1DE5106BBD5D46856F90B52F1507CE4CECAFCBA103919E79485E91F17E5BC6B8ED3989F77DDF770F4C7AE6255D863A4613FFE140A5637AD23B3C69E7DB6C939F6550627762C8BCC6FFF990FE92AE6B08DD61728CA5C9B94A66CE577179020C8F4A11E34ABC0145B0B6920BA1E88A040A5F0720653612FE48588A2257D112C239BF4B55922A0C19A2256B8D98F511DA673F9B06B57D9EDC25D910F86B84806E52DD1EDCF19F52CAC2CAEF6BBB247441E8B359D419BD974AD79BF5B642BA8DF940A0227DD595B28028610826EFB84F9EE018DF3E48780F6B126CCB86BA1BA47F23DA699F5C52B21624920546AD8F3F91C361B479FB0FD884DF01EE1E0000, N'6.4.4')
GO
SET IDENTITY_INSERT [dbo].[TblLoginUser] ON 

INSERT [dbo].[TblLoginUser] ([Id], [FirstName], [LastName], [UserName], [Role], [password]) VALUES (1, N'Abuzar', N's', N'abs', N'Admin', N'abc')
INSERT [dbo].[TblLoginUser] ([Id], [FirstName], [LastName], [UserName], [Role], [password]) VALUES (2, N'Shubhan', N'p', N'shu', N'Sales', N'abc')
INSERT [dbo].[TblLoginUser] ([Id], [FirstName], [LastName], [UserName], [Role], [password]) VALUES (3, N'rituja', N'k', N'rit', N'Trainer', N'abc')
SET IDENTITY_INSERT [dbo].[TblLoginUser] OFF
GO
SET IDENTITY_INSERT [dbo].[TblStudents] ON 

INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (1, N'Shubham', N'Parab', CAST(N'2019-04-12T00:00:00.000' AS DateTime), CAST(26.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (2, N'Abuzar', N'S', CAST(N'2021-06-11T00:00:00.000' AS DateTime), CAST(21.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (3, N'Shubham', N'P', NULL, CAST(23.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (4, N'Rituja', N'K', NULL, CAST(21.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (6, N'GF', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (7, N'HG', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (8, N'IH', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (9, N'JI', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (10, N'KJ', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (11, N'LK', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (12, N'ML', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (13, N'NM', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (14, N'ON', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (15, N'PO', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (16, N'QP', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (17, N'RQ', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (18, N'Swapnil', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (19, N'Salman', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (20, N'Sanju', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (21, N'Amy', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (22, N'Aayvya', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (23, N'Ind', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (24, N'Vivek', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (25, N'Alakh', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (26, N'Sandeep', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (27, N'Pradeep', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (28, N'Mayank', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (29, N'Nitish', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (30, N'manish', N's', NULL, CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblStudents] ([id], [FirstName], [LastName], [Doj], [Age], [SubjectID]) VALUES (1002, N'AV', N'aaa', NULL, CAST(23.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[TblStudents] OFF
GO
SET IDENTITY_INSERT [dbo].[TblSubjects] ON 

INSERT [dbo].[TblSubjects] ([Id], [Name]) VALUES (1, N'Dot net')
INSERT [dbo].[TblSubjects] ([Id], [Name]) VALUES (2, N'MVC')
INSERT [dbo].[TblSubjects] ([Id], [Name]) VALUES (3, N'Selenium')
INSERT [dbo].[TblSubjects] ([Id], [Name]) VALUES (6, N'Javascript')
INSERT [dbo].[TblSubjects] ([Id], [Name]) VALUES (10, N'Angular')
SET IDENTITY_INSERT [dbo].[TblSubjects] OFF
GO
ALTER TABLE [dbo].[TblStudents]  WITH CHECK ADD  CONSTRAINT [FK_TblStudents_TblSubjects] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[TblSubjects] ([Id])
GO
ALTER TABLE [dbo].[TblStudents] CHECK CONSTRAINT [FK_TblStudents_TblSubjects]
GO
/****** Object:  StoredProcedure [dbo].[AddUpdateSubject]    Script Date: 28-07-2021 09:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUpdateSubject]
	-- Add the parameters for the stored procedure here
	@Id int,
	@name Varchar(50)
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 if(isNUll(@Id,0)=0)
	 Begin 
	 insert into Dbo.TblSubjects
	 values(@name)
	 Select @id=@@IDENTITY
	 End
	 ELSE 
	 BEGIN

	 Update  Dbo.TblSubjects SET Name=@name Where id=@Id;

	 END 

	 Select Id as data, Name  from Dbo.TblSubjects where Id=@Id;
END
GO
