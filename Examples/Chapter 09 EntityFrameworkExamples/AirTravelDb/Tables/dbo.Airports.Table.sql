/****** Object:  Table [dbo].[Airports]    Script Date: 05/30/2012 18:11:48 ******/

CREATE TABLE [dbo].[Airports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AirportName] [nvarchar](255) NOT NULL,
	[CityName] [nvarchar](255) NULL,
	[Country] [nvarchar](255) NOT NULL,
	[AirportCode] [nvarchar](10) NULL,
	[Location] [geography] NULL,
	[Altitude] [int] NOT NULL,
	[TimezoneOffset] [float] NOT NULL,
	[DST] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_Airports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

