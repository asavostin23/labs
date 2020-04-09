USE РЕКЛАМА_2
GO

/****** Object:  Table [dbo].[Передачи]    Script Date: 08.03.2020 15:35:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Передачи](
	[Название передачи] [varchar](100) NOT NULL,
	[Рейтинг] [real] NOT NULL,
 CONSTRAINT [PK_Передачи] PRIMARY KEY CLUSTERED 
(
	[Название передачи] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON G1

GO

SET ANSI_PADDING OFF
GO


