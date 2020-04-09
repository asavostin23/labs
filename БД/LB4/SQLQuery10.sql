USE РЕКЛАМА_2
GO

/****** Object:  Table [dbo].[Заказы]    Script Date: 08.03.2020 15:34:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Заказы](
	[Номер заказа] [int] NOT NULL,
	[Заказчик] [varchar](50) NOT NULL,
	[Передача] [varchar](100) NOT NULL,
	[Дата] [date] NOT NULL,
	[Длительность в минутах] [smallint] NOT NULL,
	[Вид рекламы] [nchar](10) NULL,
 CONSTRAINT [PK_Заказы] PRIMARY KEY CLUSTERED 
(
	[Номер заказа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON G1

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Заказы]  WITH CHECK ADD  CONSTRAINT [FK_Заказы_Заказчики] FOREIGN KEY([Заказчик])
REFERENCES [dbo].[Заказчики] ([Заказчик])
GO

ALTER TABLE [dbo].[Заказы] CHECK CONSTRAINT [FK_Заказы_Заказчики]
GO

ALTER TABLE [dbo].[Заказы]  WITH CHECK ADD  CONSTRAINT [FK_Заказы_Передачи] FOREIGN KEY([Передача])
REFERENCES [dbo].[Передачи] ([Название передачи])
GO

ALTER TABLE [dbo].[Заказы] CHECK CONSTRAINT [FK_Заказы_Передачи]
GO


