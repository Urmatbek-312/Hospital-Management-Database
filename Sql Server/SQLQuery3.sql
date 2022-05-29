USE [hospital]
GO

/****** Object:  Table [dbo].[AddPatient]    Script Date: 11.05.2022 14:12:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AddPatient](
	[Name] [varchar](150) NOT NULL,
	[Full_Address] [varchar](300) NOT NULL,
	[Contact] [bigint] NOT NULL,
	[Age] [int] NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Blood_Group] [varchar](20) NOT NULL,
	[Major_Disease] [varchar](400) NOT NULL
) ON [PRIMARY]
GO


SELECT * FROM AddPatient