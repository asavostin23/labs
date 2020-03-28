USE РЕКЛАМА_2
GO

/****** Object:  Table [dbo].[Заказчики]    Script Date: 08.03.2020 15:33:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Заказчики](
	[Заказчик] [varchar](50) NOT NULL,
	[Банковские реквизиты] [bigint] NOT NULL,
	[Телефон] [int] NOT NULL,
	[Контактное лицо] [varchar](100) NULL,
 CONSTRAINT [PK_Заказчики] PRIMARY KEY CLUSTERED 
(
	[Заказчик] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


