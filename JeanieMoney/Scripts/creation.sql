/****** Object:  ForeignKey [FK_category_category]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] DROP CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_specification]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_specification]
GO
/****** Object:  ForeignKey [FK_trade_record_category]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_category]
GO
/****** Object:  ForeignKey [FK_trade_record_location]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_location]
GO
/****** Object:  ForeignKey [FK_trade_record_payer]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_payer]
GO
/****** Object:  ForeignKey [FK_trade_record_payment_category]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_payment_category]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_beneficiary]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_beneficiary]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_product]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_product]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_trade_record]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_trade_record]
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
DROP VIEW [dbo].[journal_record]
GO
/****** Object:  View [dbo].[product_specification_manufactory]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[product_specification_manufactory]'))
DROP VIEW [dbo].[product_specification_manufactory]
GO
/****** Object:  Table [dbo].[trade_record_detail]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record_detail]') AND type in (N'U'))
DROP TABLE [dbo].[trade_record_detail]
GO
/****** Object:  Table [dbo].[product]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
DROP TABLE [dbo].[product]
GO
/****** Object:  Table [dbo].[trade_record]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record]') AND type in (N'U'))
DROP TABLE [dbo].[trade_record]
GO
/****** Object:  Table [dbo].[specification]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[specification]') AND type in (N'U'))
DROP TABLE [dbo].[specification]
GO
/****** Object:  Table [dbo].[beneficiary]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[beneficiary]') AND type in (N'U'))
DROP TABLE [dbo].[beneficiary]
GO
/****** Object:  Table [dbo].[category]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
DROP TABLE [dbo].[category]
GO
/****** Object:  Table [dbo].[location]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
DROP TABLE [dbo].[location]
GO
/****** Object:  Table [dbo].[manufactory]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manufactory]') AND type in (N'U'))
DROP TABLE [dbo].[manufactory]
GO
/****** Object:  Table [dbo].[payer]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payer]') AND type in (N'U'))
DROP TABLE [dbo].[payer]
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_category]') AND type in (N'U'))
DROP TABLE [dbo].[payment_category]
GO
/****** Object:  Default [DF_category_flag_in_out]    Script Date: 01/19/2012 14:02:28 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_category_flag_in_out]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_category_flag_in_out]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[category] DROP CONSTRAINT [DF_category_flag_in_out]
END


End
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 01/19/2012 14:02:28 ******/
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
/****** Object:  Table [dbo].[payer]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[payer](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[manufactory]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manufactory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[manufactory](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[address] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
	[tel] [varchar](50) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_manufactory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[manufactory] ([id], [name], [abbr], [address], [tel]) VALUES (N'aaa                                 ', N'大华食品厂', N'dhspc', N'北京', N'82453471')
/****** Object:  Table [dbo].[location]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[location](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_location] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[category]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[category](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [nvarchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[flag_in_out] [bit] NOT NULL,
	[parent_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'3                                   ', N'daewq', N'dendd', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'321                                 ', N'花', N'hua', 0, N'32134                               ')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'32134                               ', N'是', N's', 0, N'3                                   ')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'34                                  ', N'华府', N'hf', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'97e1c043-5a3b-405c-94e8-44b5f9492142', N'华府大', N'hfd', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'd1561dbe-f3eb-4b52-858c-fa3329ffb550', N'dennis', N'dns', 1, NULL)
/****** Object:  Table [dbo].[beneficiary]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[beneficiary]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[beneficiary](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_beneficiary] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[specification]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[specification]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[specification](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_specification] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[specification] ([id], [name], [abbr]) VALUES (N'bbb                                 ', N'片', N'pian')
/****** Object:  Table [dbo].[trade_record]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[trade_record](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[payer_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[location_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[payment_category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[money] [money] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_trade_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[product]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[product](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[specification_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
	[specification_quantity] [varchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[manufactory_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[product] ([id], [name], [abbr], [specification_id], [specification_quantity], [manufactory_id]) VALUES (N'ccc                                 ', N'山楂片', N'szp', N'bbb                                 ', N'30', N'aaa                                 ')
/****** Object:  Trigger [CategoryDeletion]    Script Date: 01/19/2012 14:02:28 ******/
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
/****** Object:  Table [dbo].[trade_record_detail]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record_detail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[trade_record_detail](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[trade_record_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[product_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [money] NOT NULL,
	[beneficiary_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_trade_record_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  View [dbo].[product_specification_manufactory]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[product_specification_manufactory]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[product_specification_manufactory]
AS
SELECT        dbo.product.id, dbo.product.name, dbo.product.pinyin, 
                         dbo.product.name + ''('' + dbo.product.specification_quantity + dbo.specification.name + '')'' AS namespecificantion, 
                         dbo.product.specification_quantity + dbo.specification.name AS specificantion, dbo.specification.id AS specificationid, dbo.manufactory.id AS manufactoryid, 
                         dbo.manufactory.name AS manufactoryname, dbo.manufactory.address, dbo.manufactory.tel
FROM            dbo.product LEFT OUTER JOIN
                         dbo.manufactory ON dbo.manufactory.id = dbo.product.manufactory_id LEFT OUTER JOIN
                         dbo.specification ON dbo.product.specification_id = dbo.specification.id
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'product_specification_manufactory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "product"
            Begin Extent = 
               Top = 0
               Left = 23
               Bottom = 129
               Right = 228
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "manufactory"
            Begin Extent = 
               Top = 103
               Left = 269
               Bottom = 232
               Right = 439
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "specification"
            Begin Extent = 
               Top = 0
               Left = 269
               Bottom = 95
               Right = 439
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
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2130
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'product_specification_manufactory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'product_specification_manufactory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'product_specification_manufactory'
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 01/19/2012 14:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[journal_record]
AS
SELECT        dbo.trade_record.id, dbo.category.name, dbo.location.name AS location_name, dbo.payer.name AS payer_name, 
                         dbo.payment_category.name AS payment_category_name, dbo.trade_record.money
FROM            dbo.trade_record INNER JOIN
                         dbo.category ON dbo.trade_record.category_id = dbo.category.id INNER JOIN
                         dbo.location ON dbo.trade_record.location_id = dbo.location.id INNER JOIN
                         dbo.payer ON dbo.trade_record.payer_id = dbo.payer.id INNER JOIN
                         dbo.payment_category ON dbo.trade_record.payment_category_id = dbo.payment_category.id
'
GO
/****** Object:  Default [DF_category_flag_in_out]    Script Date: 01/19/2012 14:02:28 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_category_flag_in_out]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_category_flag_in_out]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[category] ADD  CONSTRAINT [DF_category_flag_in_out]  DEFAULT ((0)) FOR [flag_in_out]
END


End
GO
/****** Object:  ForeignKey [FK_category_category]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_category] FOREIGN KEY([parent_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_manufactory] FOREIGN KEY([manufactory_id])
REFERENCES [dbo].[manufactory] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_specification]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_specification] FOREIGN KEY([specification_id])
REFERENCES [dbo].[specification] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_specification]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_specification]
GO
/****** Object:  ForeignKey [FK_trade_record_category]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_category]
GO
/****** Object:  ForeignKey [FK_trade_record_location]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[location] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_location]
GO
/****** Object:  ForeignKey [FK_trade_record_payer]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_payer] FOREIGN KEY([payer_id])
REFERENCES [dbo].[payer] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_payer]
GO
/****** Object:  ForeignKey [FK_trade_record_payment_category]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_payment_category] FOREIGN KEY([payment_category_id])
REFERENCES [dbo].[payment_category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_payment_category]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_beneficiary]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_beneficiary] FOREIGN KEY([beneficiary_id])
REFERENCES [dbo].[beneficiary] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_beneficiary]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_product]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_product]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_trade_record]    Script Date: 01/19/2012 14:02:28 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_trade_record] FOREIGN KEY([trade_record_id])
REFERENCES [dbo].[trade_record] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_trade_record]
GO
