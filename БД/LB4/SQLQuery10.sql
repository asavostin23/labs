USE �������_2
GO

/****** Object:  Table [dbo].[������]    Script Date: 08.03.2020 15:34:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[������](
	[����� ������] [int] NOT NULL,
	[��������] [varchar](50) NOT NULL,
	[��������] [varchar](100) NOT NULL,
	[����] [date] NOT NULL,
	[������������ � �������] [smallint] NOT NULL,
	[��� �������] [nchar](10) NULL,
 CONSTRAINT [PK_������] PRIMARY KEY CLUSTERED 
(
	[����� ������] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON G1

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[������]  WITH CHECK ADD  CONSTRAINT [FK_������_���������] FOREIGN KEY([��������])
REFERENCES [dbo].[���������] ([��������])
GO

ALTER TABLE [dbo].[������] CHECK CONSTRAINT [FK_������_���������]
GO

ALTER TABLE [dbo].[������]  WITH CHECK ADD  CONSTRAINT [FK_������_��������] FOREIGN KEY([��������])
REFERENCES [dbo].[��������] ([�������� ��������])
GO

ALTER TABLE [dbo].[������] CHECK CONSTRAINT [FK_������_��������]
GO


