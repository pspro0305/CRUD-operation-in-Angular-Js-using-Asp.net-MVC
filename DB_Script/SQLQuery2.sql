USE [master]
GO
/****** Object:  Database [AngularCRUD]    Script Date: 29-May-20 5:46:21 PM ******/
CREATE DATABASE [AngularCRUD] 
GO
USE [AngularCRUD]
GO
/****** Object:  Table [dbo].[M_Employee]    Script Date: 29-May-20 5:46:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[M_Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](150) NULL,
	[mobileno] [nvarchar](50) NULL,
 CONSTRAINT [PK_M_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [AngularCRUD] SET  READ_WRITE 
GO
