CREATE TABLE [dbo].[Cars]
(
  [Id] [uniqueidentifier] NOT NULL,
  [Make] [varchar](100) NOT NULL,
  [Model] [varchar](100) NOT NULL,
  [Year] [int] NOT NULL,
  [Color] [varchar](100) NOT NULL,
  PRIMARY KEY CLUSTERED ([Id] ASC)
)
