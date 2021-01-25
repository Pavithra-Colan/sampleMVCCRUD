select * from  [dbo].[empdetails]

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[empdetails](
	[serialno] [decimal](18, 0) NOT NULL,
	[empid] [nchar](10) NULL,
	[empname] [varchar](50) NULL,
	[empadd] [varchar](50) NULL,
	[desgn] [varchar](50) NULL,
	[salary] [int] NULL,
 CONSTRAINT [PK_empdetails] PRIMARY KEY CLUSTERED 
(
	[serialno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO