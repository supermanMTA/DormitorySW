USE [master]
GO
/****** Object:  Database [Dorm_MS]    Script Date: 12/18/2017 8:36:27 AM ******/
CREATE DATABASE [Dorm_MS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dorm_MS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Dorm_MS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dorm_MS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Dorm_MS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dorm_MS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dorm_MS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dorm_MS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dorm_MS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dorm_MS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dorm_MS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dorm_MS] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dorm_MS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dorm_MS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Dorm_MS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dorm_MS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dorm_MS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dorm_MS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dorm_MS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dorm_MS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dorm_MS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dorm_MS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dorm_MS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dorm_MS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dorm_MS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dorm_MS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dorm_MS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dorm_MS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dorm_MS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dorm_MS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dorm_MS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dorm_MS] SET  MULTI_USER 
GO
ALTER DATABASE [Dorm_MS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dorm_MS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dorm_MS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dorm_MS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Dorm_MS]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillOfMonth] [int] NOT NULL,
	[BillOfYear] [int] NOT NULL,
	[Rent] [float] NULL,
	[ElectricCharge] [float] NULL,
	[WaterCharge] [float] NULL,
	[Surcharge] [float] NULL,
	[DateFounded] [date] NULL,
	[ID_Student] [int] NULL,
	[ID_Room] [int] NULL,
	[ID_Staff] [int] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Calendar]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendar](
	[Day] [date] NOT NULL,
	[ID_Staff] [int] NOT NULL,
	[Time] [time](7) NULL,
 CONSTRAINT [PK_Calendar] PRIMARY KEY CLUSTERED 
(
	[Day] ASC,
	[ID_Staff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Class]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ID_Faculty] [int] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compliment]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compliment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Reason] [nvarchar](100) NULL,
	[Degree] [nvarchar](30) NULL,
	[Date] [date] NULL,
	[Note] [nvarchar](200) NULL,
	[ID_Student] [int] NULL,
 CONSTRAINT [PK_Laudatory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contract]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Student] [int] NULL,
	[ID_Staff] [int] NULL,
	[ID_Room] [int] NOT NULL,
	[DateStart] [date] NULL,
	[DateEnd] [date] NULL,
	[Expired] [bit] NULL,
	[DateFound] [date] NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Discipline]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipline](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Reason] [nvarchar](200) NULL,
	[Degree] [nvarchar](30) NULL,
	[Date] [date] NULL,
	[Level_Dis] [nvarchar](100) NULL,
	[Note] [nvarchar](200) NULL,
	[ID_Student] [int] NULL,
 CONSTRAINT [PK_Discipline] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dormitory]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dormitory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[NumberRoom] [int] NULL,
 CONSTRAINT [PK_Domitory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RegistrationForm]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegistrationForm](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[Object] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Nation] [nvarchar](10) NULL,
	[Religion] [nvarchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[IdentityCard] [nvarchar](20) NULL,
	[NameFather] [nvarchar](50) NULL,
	[BirthDayOfFather] [date] NULL,
	[JobOfFather] [nvarchar](50) NULL,
	[NameMother] [nvarchar](50) NULL,
	[BirthDayOfMother] [date] NULL,
	[JobOfMother] [nvarchar](50) NULL,
	[ID_Class] [int] NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_RegistrationForm] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Relative]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relative](
	[Name] [nvarchar](50) NOT NULL,
	[ID_Student] [int] NOT NULL,
	[Relationship] [nchar](10) NULL,
	[Job] [nchar](20) NULL,
 CONSTRAINT [PK_Relative_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[ID_Student] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Dormitori] [int] NULL,
	[Number] [int] NULL,
	[MaxNumber] [int] NULL,
	[ID_TypeR] [int] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoomAssessment]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomAssessment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Staff] [int] NULL,
	[ID_Room] [int] NULL,
	[Purport] [nvarchar](50) NULL,
	[ID_Year] [int] NULL,
 CONSTRAINT [PK_RoomAssessment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SchoolYear]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SchoolYear](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[DateStart] [date] NULL,
	[DateEnd] [date] NULL,
 CONSTRAINT [PK_SchoolYear] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Nation] [nvarchar](20) NULL,
	[Religion] [nvarchar](30) NULL,
	[DateOfBirth] [date] NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_ManageStaff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[Object] [nvarchar](20) NULL,
	[Address] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Nation] [nvarchar](20) NULL,
	[Religion] [nvarchar](30) NULL,
	[IdentityCard] [nvarchar](20) NULL,
	[DateOfBirth] [date] NULL,
	[Class_ID] [int] NULL,
	[Room_ID] [int] NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TypeRoom]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeRoom](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NULL,
 CONSTRAINT [PK_TypeRoom] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Email] [varchar](50) NOT NULL,
	[Pass] [nchar](10) NOT NULL,
	[Object] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[ContractView]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ContractView]
AS
SELECT        dbo.Contract.ID, dbo.Student.Name, dbo.Contract.ID_Student, dbo.Staff.Name AS Expr1, dbo.Contract.DateStart, dbo.Contract.DateEnd
FROM            dbo.Contract INNER JOIN
                         dbo.Student ON dbo.Contract.ID = dbo.Student.ID INNER JOIN
                         dbo.Staff ON dbo.Contract.ID = dbo.Staff.ID

GO
/****** Object:  View [dbo].[StudentView]    Script Date: 12/18/2017 8:36:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StudentView]
AS
SELECT        ID, Name, Gender, Object, Address, PhoneNumber, Nation, Religion, IdentityCard, DateOfBirth, Class_ID, Room_ID
FROM            dbo.Student

GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([ID], [BillOfMonth], [BillOfYear], [Rent], [ElectricCharge], [WaterCharge], [Surcharge], [DateFounded], [ID_Student], [ID_Room], [ID_Staff]) VALUES (1, 1, 1, 100000, 300000, 300000, 0, CAST(N'2015-03-02' AS Date), 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ID], [Name], [ID_Faculty]) VALUES (1, N'Công nghệ thông tin 11', 1)
INSERT [dbo].[Class] ([ID], [Name], [ID_Faculty]) VALUES (2, N'Công nghệ thông tin k11', 1)
INSERT [dbo].[Class] ([ID], [Name], [ID_Faculty]) VALUES (3, N'Điện tử viễn thông 11', 2)
INSERT [dbo].[Class] ([ID], [Name], [ID_Faculty]) VALUES (4, N'Điện tử viễn thông 12', 2)
INSERT [dbo].[Class] ([ID], [Name], [ID_Faculty]) VALUES (5, N'Công nghệ hóa 11', 5)
SET IDENTITY_INSERT [dbo].[Class] OFF
SET IDENTITY_INSERT [dbo].[Compliment] ON 

INSERT [dbo].[Compliment] ([ID], [Name], [Reason], [Degree], [Date], [Note], [ID_Student]) VALUES (1, N'Bằng khen', N'Có thành tích cao trong hoạt động đoàn', N'Học viện', CAST(N'2016-02-18' AS Date), N'Giá trị khen thưởng 5.000.000', 1)
INSERT [dbo].[Compliment] ([ID], [Name], [Reason], [Degree], [Date], [Note], [ID_Student]) VALUES (2, N'Giấy khen', N'Có thành cao trong học tập', N'Khoa', CAST(N'2016-02-18' AS Date), N'Giá trị khen thưởng 3000000 nhận từ văn thư của khoa', 1)
SET IDENTITY_INSERT [dbo].[Compliment] OFF
SET IDENTITY_INSERT [dbo].[Contract] ON 

INSERT [dbo].[Contract] ([ID], [ID_Student], [ID_Staff], [ID_Room], [DateStart], [DateEnd], [Expired], [DateFound]) VALUES (3, 1, 1, 1, CAST(N'2017-12-17' AS Date), CAST(N'2018-12-17' AS Date), 1, CAST(N'2016-08-08' AS Date))
SET IDENTITY_INSERT [dbo].[Contract] OFF
SET IDENTITY_INSERT [dbo].[Discipline] ON 

INSERT [dbo].[Discipline] ([ID], [Reason], [Degree], [Date], [Level_Dis], [Note], [ID_Student]) VALUES (2, N'Gây gổ với bạn', N'Học viện', CAST(N'2016-02-02' AS Date), N'Cảnh cáo  ', N'Học sinh có hành vi gây gổ vớ bạn gây mất trật tự', 1)
SET IDENTITY_INSERT [dbo].[Discipline] OFF
SET IDENTITY_INSERT [dbo].[Dormitory] ON 

INSERT [dbo].[Dormitory] ([ID], [Name], [NumberRoom]) VALUES (1, N'S11', 50)
INSERT [dbo].[Dormitory] ([ID], [Name], [NumberRoom]) VALUES (2, N'S13', 50)
INSERT [dbo].[Dormitory] ([ID], [Name], [NumberRoom]) VALUES (3, N'S7', 100)
INSERT [dbo].[Dormitory] ([ID], [Name], [NumberRoom]) VALUES (4, N'S8', 50)
INSERT [dbo].[Dormitory] ([ID], [Name], [NumberRoom]) VALUES (5, N'S9', 75)
SET IDENTITY_INSERT [dbo].[Dormitory] OFF
SET IDENTITY_INSERT [dbo].[Faculty] ON 

INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (1, N'Công nghệ thông tin', N'Tầng 19 S1')
INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (2, N'Vô tuyến điện từ', N'Tầng 5 nhà S1')
INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (5, N'Hóa lý kỹ thuật', N'Tầng 7 nhà S1')
INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (6, N'Kỹ thuật điều khiển', N'Tầng 20 S1')
INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (7, N'Công trình', N'Tầng 9-S1')
INSERT [dbo].[Faculty] ([ID], [Name], [Address]) VALUES (8, N'Hóa lý kỹ thuật', N'Tầng 8-S1')
SET IDENTITY_INSERT [dbo].[Faculty] OFF
INSERT [dbo].[Relative] ([Name], [ID_Student], [Relationship], [Job]) VALUES (N'Hoàng', 1, N'Cha-con   ', N'Bộ đội              ')
INSERT [dbo].[Relative] ([Name], [ID_Student], [Relationship], [Job]) VALUES (N'Huyền ', 1, N'Mẹ-con    ', N'Giáo viên           ')
INSERT [dbo].[Relative] ([Name], [ID_Student], [Relationship], [Job]) VALUES (N'Nguyễn Văn Kiên', 1, N'em        ', N'học sinh            ')
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([ID], [ID_Dormitori], [Number], [MaxNumber], [ID_TypeR]) VALUES (1, 1, 3, 4, 1)
INSERT [dbo].[Room] ([ID], [ID_Dormitori], [Number], [MaxNumber], [ID_TypeR]) VALUES (2, 2, 3, 4, 2)
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[RoomAssessment] ON 

INSERT [dbo].[RoomAssessment] ([ID], [ID_Staff], [ID_Room], [Purport], [ID_Year]) VALUES (1, 3, 1, N'Hoàn thành tốt nhiệm vụ', 1)
INSERT [dbo].[RoomAssessment] ([ID], [ID_Staff], [ID_Room], [Purport], [ID_Year]) VALUES (3, 7, 1, N'Phòng đảm bảo kỷ luật, không xảy ra vi phạm.', 2)
SET IDENTITY_INSERT [dbo].[RoomAssessment] OFF
SET IDENTITY_INSERT [dbo].[SchoolYear] ON 

INSERT [dbo].[SchoolYear] ([ID], [Name], [DateStart], [DateEnd]) VALUES (1, N'2014-2015', CAST(N'2014-01-08' AS Date), CAST(N'2015-01-08' AS Date))
INSERT [dbo].[SchoolYear] ([ID], [Name], [DateStart], [DateEnd]) VALUES (2, N'2015-2016', CAST(N'2015-01-08' AS Date), CAST(N'2016-01-08' AS Date))
INSERT [dbo].[SchoolYear] ([ID], [Name], [DateStart], [DateEnd]) VALUES (3, N'2016-2017', CAST(N'2016-01-08' AS Date), CAST(N'2017-01-08' AS Date))
INSERT [dbo].[SchoolYear] ([ID], [Name], [DateStart], [DateEnd]) VALUES (4, N'2017-2018', CAST(N'2017-01-08' AS Date), CAST(N'2018-01-08' AS Date))
SET IDENTITY_INSERT [dbo].[SchoolYear] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (1, N'Nguyễn Văn Hoàng', N'0979869302', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Cầu Giấy, Hà Nội ')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (2, N'Nguyễn Hồng Minh', N'093683298', N'Kinh', N'Không', CAST(N'1974-02-03' AS Date), N'Nam Định')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (3, N'Nguyễn Minh Thái', N'0384478933', N'Tày ', N'Không', CAST(N'1975-03-04' AS Date), N'Bắc Ninh')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (4, N'Nguyễn Xuân Phúc', N'09876543', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Nam Định')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (5, N'Đào Văn Huấn', N'987654323', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Long Biên, Hà Nội')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (6, N'Nguyễn Trung Kiên', N'09876543', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Cầu Giấy, Hà Nội ')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (7, N'Nguyễn Huy Hoàng', N'016937382', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Mỹ Đình, Hà Nội ')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (8, N'Nguyễn Văn Tiến', N'094854859', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Vinh, Nghệ An')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (9, N'Nguyễn Thị Kim Soa', N'098322876', N'Kinh', N'Đạo hồi', CAST(N'1986-02-03' AS Date), N'Thanh Chương, Nghệ An')
INSERT [dbo].[Staff] ([ID], [Name], [PhoneNumber], [Nation], [Religion], [DateOfBirth], [Address]) VALUES (10, N'Nguyễn Văn Tuyến', N'0987654', N'Khơ me', N'Tin lành', CAST(N'1986-02-03' AS Date), N'Nam Định')
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([ID], [Name], [Gender], [Object], [Address], [PhoneNumber], [Nation], [Religion], [IdentityCard], [DateOfBirth], [Class_ID], [Room_ID], [Email]) VALUES (1, N'Bùi Thị Thu Trang', N'Nữ', N'Sinh viên', N'Kim Thành, Hải Dương', N'09876543', N'Kinh', N'Tin lành', N'986535780', CAST(N'2017-12-17' AS Date), 3, 1, N'trang@gmail.com')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Object], [Address], [PhoneNumber], [Nation], [Religion], [IdentityCard], [DateOfBirth], [Class_ID], [Room_ID], [Email]) VALUES (2, N'Nguyễn Thị Kim Soa', N'Nữ', N'Sinh viên', N'Nghệ An', N'098765432', N'Thái', N'Tin lành', N'987467908', CAST(N'1999-06-30' AS Date), 3, 2, N'soa@gmail.com')
INSERT [dbo].[Student] ([ID], [Name], [Gender], [Object], [Address], [PhoneNumber], [Nation], [Religion], [IdentityCard], [DateOfBirth], [Class_ID], [Room_ID], [Email]) VALUES (3, N'Nguyễn Tiến Hoàng', N'Nam', N'Sinh viên', N'Hà nội', N'0987654', N'Kinh', N'Không', N'987654349', CAST(N'1995-01-02' AS Date), 2, 1, N'hoa@gmail.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[TypeRoom] ON 

INSERT [dbo].[TypeRoom] ([ID], [Name]) VALUES (1, N'Nam                 ')
INSERT [dbo].[TypeRoom] ([ID], [Name]) VALUES (2, N'Nữ                  ')
SET IDENTITY_INSERT [dbo].[TypeRoom] OFF
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'admin@gmail.com', N'12345678  ', 1)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'anh@gmail.com', N'12345678  ', 2)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'Hoa@gmail.com', N'123       ', 2)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'soa@gmail.com', N'12345678  ', 2)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'tien@gmail.com', N'123456    ', 2)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'trang@gmail.com', N'12345678  ', 2)
INSERT [dbo].[User] ([Email], [Pass], [Object]) VALUES (N'trinh@gmail.com', N'123456    ', 1)
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Contract"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Staff"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ContractView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ContractView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 175
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StudentView'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StudentView'
GO
USE [master]
GO
ALTER DATABASE [Dorm_MS] SET  READ_WRITE 
GO
