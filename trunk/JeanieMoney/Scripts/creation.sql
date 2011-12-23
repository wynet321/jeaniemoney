/****** Object:  ForeignKey [FK_account_record_category]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] DROP CONSTRAINT [FK_account_record_category]
GO
/****** Object:  ForeignKey [FK_account_record_location]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] DROP CONSTRAINT [FK_account_record_location]
GO
/****** Object:  ForeignKey [FK_account_record_payer]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] DROP CONSTRAINT [FK_account_record_payer]
GO
/****** Object:  ForeignKey [FK_account_record_payment_category]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] DROP CONSTRAINT [FK_account_record_payment_category]
GO
/****** Object:  ForeignKey [FK_category_category]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] DROP CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_account_record]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_account_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] DROP CONSTRAINT [FK_consume_detail_record_account_record]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_beneficiary]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] DROP CONSTRAINT [FK_consume_detail_record_beneficiary]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_product]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] DROP CONSTRAINT [FK_consume_detail_record_product]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_specification]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_specification]
GO
/****** Object:  Table [dbo].[consume_detail_record]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[consume_detail_record]') AND type in (N'U'))
DROP TABLE [dbo].[consume_detail_record]
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
DROP VIEW [dbo].[journal_record]
GO
/****** Object:  Table [dbo].[account_record]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[account_record]') AND type in (N'U'))
DROP TABLE [dbo].[account_record]
GO
/****** Object:  Table [dbo].[product]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
DROP TABLE [dbo].[product]
GO
/****** Object:  Table [dbo].[specification]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[specification]') AND type in (N'U'))
DROP TABLE [dbo].[specification]
GO
/****** Object:  Table [dbo].[beneficiary]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[beneficiary]') AND type in (N'U'))
DROP TABLE [dbo].[beneficiary]
GO
/****** Object:  Table [dbo].[category]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
DROP TABLE [dbo].[category]
GO
/****** Object:  Table [dbo].[location]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
DROP TABLE [dbo].[location]
GO
/****** Object:  Table [dbo].[manufactory]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manufactory]') AND type in (N'U'))
DROP TABLE [dbo].[manufactory]
GO
/****** Object:  Table [dbo].[payer]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payer]') AND type in (N'U'))
DROP TABLE [dbo].[payer]
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 12/16/2011 16:55:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_category]') AND type in (N'U'))
DROP TABLE [dbo].[payment_category]
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[payment_category](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_payment_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'payment_category', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'credit card
cash
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'payment_category'
GO
/****** Object:  Table [dbo].[payer]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[payer](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[pinyin] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[manufactory]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manufactory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[manufactory](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[pinyin] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[address] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[tel] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_manufactory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[location]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[location](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[category]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[category](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[pinyin] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[parent_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[beneficiary]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[beneficiary]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[beneficiary](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[pinyin] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_beneficiary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[specification]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[specification]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[specification](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[unit_name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_specification] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Trigger [CategoryDeletion]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[CategoryDeletion]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[CategoryDeletion]
ON [dbo].[category]
INSTEAD OF DELETE
AS
	delete from dbo.category where dbo.category.parent_id in (select id from deleted)
	delete from dbo.category where dbo.category.id in (select id from deleted)
'
GO
/****** Object:  Table [dbo].[product]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[product](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[pinyin] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[price] [money] NOT NULL,
	[specification_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
	[specification_quantity] [int] NULL,
	[manufactory_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[account_record]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[account_record]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[account_record](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[payer_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[location_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[payment_category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[money] [money] NOT NULL,
	[date] [date] NOT NULL,
	[flag_in_out] [bit] NOT NULL,
 CONSTRAINT [PK_income_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[journal_record]
AS
SELECT        dbo.account_record.id, dbo.category.name, dbo.location.name AS location_name, dbo.payer.name AS payer_name, 
                         dbo.payment_category.name AS payment_category_name, dbo.account_record.money
FROM            dbo.account_record INNER JOIN
                         dbo.category ON dbo.account_record.category_id = dbo.category.id INNER JOIN
                         dbo.location ON dbo.account_record.location_id = dbo.location.id INNER JOIN
                         dbo.payer ON dbo.account_record.payer_id = dbo.payer.id INNER JOIN
                         dbo.payment_category ON dbo.account_record.payment_category_id = dbo.payment_category.id
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'journal_record', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[31] 2[17] 3) )"
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
         Begin Table = "account_record"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "category"
            Begin Extent = 
               Top = 6
               Left = 278
               Bottom = 135
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "location"
            Begin Extent = 
               Top = 6
               Left = 486
               Bottom = 101
               Right = 656
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "member"
            Begin Extent = 
               Top = 6
               Left = 694
               Bottom = 101
               Right = 864
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "payment_category"
            Begin Extent = 
               Top = 102
               Left = 486
               Bottom = 197
               Right = 656
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
         Column = 6270
         Alias = 900
         Table = 1170
         Output = 1005
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'journal_record'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane2' , N'SCHEMA',N'dbo', N'VIEW',N'journal_record', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'journal_record'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'journal_record', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'journal_record'
GO
/****** Object:  Table [dbo].[consume_detail_record]    Script Date: 12/16/2011 16:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[consume_detail_record]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[consume_detail_record](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[account_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[product_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [money] NOT NULL,
	[beneficiary_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL
)
END
GO
/****** Object:  ForeignKey [FK_account_record_category]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record]  WITH CHECK ADD  CONSTRAINT [FK_account_record_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] CHECK CONSTRAINT [FK_account_record_category]
GO
/****** Object:  ForeignKey [FK_account_record_location]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record]  WITH CHECK ADD  CONSTRAINT [FK_account_record_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[location] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] CHECK CONSTRAINT [FK_account_record_location]
GO
/****** Object:  ForeignKey [FK_account_record_payer]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record]  WITH CHECK ADD  CONSTRAINT [FK_account_record_payer] FOREIGN KEY([payer_id])
REFERENCES [dbo].[payer] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] CHECK CONSTRAINT [FK_account_record_payer]
GO
/****** Object:  ForeignKey [FK_account_record_payment_category]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record]  WITH CHECK ADD  CONSTRAINT [FK_account_record_payment_category] FOREIGN KEY([payment_category_id])
REFERENCES [dbo].[payment_category] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_account_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[account_record]'))
ALTER TABLE [dbo].[account_record] CHECK CONSTRAINT [FK_account_record_payment_category]
GO
/****** Object:  ForeignKey [FK_category_category]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_category] FOREIGN KEY([parent_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_account_record]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_account_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_detail_record_account_record] FOREIGN KEY([account_id])
REFERENCES [dbo].[account_record] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_account_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] CHECK CONSTRAINT [FK_consume_detail_record_account_record]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_beneficiary]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_detail_record_beneficiary] FOREIGN KEY([beneficiary_id])
REFERENCES [dbo].[beneficiary] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] CHECK CONSTRAINT [FK_consume_detail_record_beneficiary]
GO
/****** Object:  ForeignKey [FK_consume_detail_record_product]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_detail_record_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_detail_record_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_detail_record]'))
ALTER TABLE [dbo].[consume_detail_record] CHECK CONSTRAINT [FK_consume_detail_record_product]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_manufactory] FOREIGN KEY([manufactory_id])
REFERENCES [dbo].[manufactory] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_specification]    Script Date: 12/16/2011 16:55:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_specification] FOREIGN KEY([specification_id])
REFERENCES [dbo].[specification] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_specification]
GO
