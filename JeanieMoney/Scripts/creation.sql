/****** Object:  ForeignKey [FK_category_category]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] DROP CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_unit]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] DROP CONSTRAINT [FK_product_unit]
GO
/****** Object:  ForeignKey [FK_trade_record_category]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_category]
GO
/****** Object:  ForeignKey [FK_trade_record_location]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_location]
GO
/****** Object:  ForeignKey [FK_trade_record_payer]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_payer]
GO
/****** Object:  ForeignKey [FK_trade_record_payment_mode]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_mode]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] DROP CONSTRAINT [FK_trade_record_payment_mode]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_beneficiary]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_beneficiary]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_product]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_product]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_trade_record]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] DROP CONSTRAINT [FK_trade_record_detail_trade_record]
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
DROP VIEW [dbo].[journal_record]
GO
/****** Object:  View [dbo].[product_unit_manufactory]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[product_unit_manufactory]'))
DROP VIEW [dbo].[product_unit_manufactory]
GO
/****** Object:  Table [dbo].[trade_record_detail]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record_detail]') AND type in (N'U'))
DROP TABLE [dbo].[trade_record_detail]
GO
/****** Object:  Table [dbo].[trade_record]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[trade_record]') AND type in (N'U'))
DROP TABLE [dbo].[trade_record]
GO
/****** Object:  Table [dbo].[product]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
DROP TABLE [dbo].[product]
GO
/****** Object:  Table [dbo].[beneficiary]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[beneficiary]') AND type in (N'U'))
DROP TABLE [dbo].[beneficiary]
GO
/****** Object:  Table [dbo].[category]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
DROP TABLE [dbo].[category]
GO
/****** Object:  Table [dbo].[location]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
DROP TABLE [dbo].[location]
GO
/****** Object:  Table [dbo].[manufactory]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[manufactory]') AND type in (N'U'))
DROP TABLE [dbo].[manufactory]
GO
/****** Object:  Table [dbo].[payer]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payer]') AND type in (N'U'))
DROP TABLE [dbo].[payer]
GO
/****** Object:  Table [dbo].[payment_mode]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_mode]') AND type in (N'U'))
DROP TABLE [dbo].[payment_mode]
GO
/****** Object:  Table [dbo].[unit]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[unit]') AND type in (N'U'))
DROP TABLE [dbo].[unit]
GO
/****** Object:  Default [DF_category_flag_in_out]    Script Date: 03/04/2012 18:15:57 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_category_flag_in_out]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_category_flag_in_out]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[category] DROP CONSTRAINT [DF_category_flag_in_out]
END


End
GO
/****** Object:  Table [dbo].[unit]    Script Date: 03/04/2012 18:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[unit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[unit](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_unit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'2051a9d0-151b-4b46-9c1d-c8b7aa44efec', N'克', N'ke')
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'92abb3cd-ddc6-44a5-9e0b-9b69daa9ac42', N'片', N'pian')
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'a0c7ecdb-e2c9-484f-8cf3-a92f62b79391', N'个', N'ge')
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'bbb                                 ', N'片', N'pian')
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'e91ee72c-a103-494a-87e8-77502d238bd5', N'盒', N'he')
INSERT [dbo].[unit] ([id], [name], [abbr]) VALUES (N'eb7e3396-44ec-4a4c-b276-e027a86d541c', N'袋', N'dai')
/****** Object:  Table [dbo].[payment_mode]    Script Date: 03/04/2012 18:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_mode]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[payment_mode](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_payment_mode] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'payment_mode', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'credit card
cash
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'payment_mode'
GO
INSERT [dbo].[payment_mode] ([id], [name], [abbr]) VALUES (N'be2ea06c-cd2e-4d03-a885-e3eb120ce6e2', N'信用卡4392260013786627', N'xyk6627')
INSERT [dbo].[payment_mode] ([id], [name], [abbr]) VALUES (N'f9c9c2fa-d58c-4063-9e49-6c2b549b6ec4', N'现金', N'xj')
/****** Object:  Table [dbo].[payer]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  Table [dbo].[manufactory]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  Table [dbo].[location]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  Table [dbo].[category]    Script Date: 03/04/2012 18:15:57 ******/
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
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'0bc06ef2-c5e2-482f-87e3-f6ab87db5eb2', N'有线电视', N'yxds', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'127f5693-c341-4aca-ae12-11b58db0fd79', N'服装', N'fz', 0, N'ea0131a2-7f6e-46f6-a03b-0fccd320e05c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'14e5932e-96ae-46c2-ab9a-8efb767c2456', N'食品', N'sp', 0, N'94f803aa-f3f1-4f24-8b35-c0603d464cf0')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'2b1d9c5d-72d2-46f5-9881-e637fad804ae', N'日用品', N'ryp', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'3963e2f4-2db1-49ec-a0d3-9c8143bd099f', N'基金收益', N'jjsy', 1, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'39ab4bae-3274-410d-8a10-367f82d3c023', N'汽车', N'qc', 0, N'8262c5c8-69ba-47cf-a690-c2bb2ba4e152')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'4b85025a-8135-45d7-882d-a0a244a23761', N'电费', N'df', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'4c472962-ae2f-45d5-8aa9-3aa9b363bc62', N'饮料', N'yl', 0, N'94f803aa-f3f1-4f24-8b35-c0603d464cf0')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'50fc7ac3-a2ed-4000-a647-d453931e74d0', N'份子', N'fz', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'529ec37e-766b-4249-88f6-494083270f0d', N'水费', N'sf', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'5c339f25-3f9f-4bc2-a61d-8c1e3997a9cb', N'工作', N'gz', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'5cc56265-065e-4333-a75f-cc0c9dfe4c30', N'鞋', N'xie', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'600f109a-a149-49a8-aca4-8a981b41a226', N'旅游', N'ly', 0, N'78e07df3-f17c-4cd1-afea-4efd5a9b738a')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'6a06e452-ab3f-46e5-8ee7-96f7733d275c', N'股票收益', N'gpsy', 1, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'71705986-66d8-4654-982a-82a86008b9ea', N'外衣', N'wy', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'73d97b87-9d40-4779-8289-0051efa2844e', N'工资', N'gz', 1, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'78e07df3-f17c-4cd1-afea-4efd5a9b738a', N'娱乐', N'yl', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'7bef3deb-441a-48ce-a7a9-cbc1bdc86ea5', N'存款利息', N'cklx', 1, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'8262c5c8-69ba-47cf-a690-c2bb2ba4e152', N'交通', N'jt', 0, N'5c339f25-3f9f-4bc2-a61d-8c1e3997a9cb')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'8aff36c6-cea3-4b85-986a-9282225c836d', N'化妆品', N'hzp', 0, N'ea0131a2-7f6e-46f6-a03b-0fccd320e05c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'94f803aa-f3f1-4f24-8b35-c0603d464cf0', N'饮食', N'ys', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'97e1c043-5a3b-405c-94e8-44b5f9492142', N'华府大', N'hfd', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'9c86da3c-3101-4186-a051-148836d7e24d', N'厨房用品', N'cfyp', 0, N'2b1d9c5d-72d2-46f5-9881-e637fad804ae')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'9cf03e36-27f1-4861-918b-f81db2a780c0', N'饰品', N'sp', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'a96d63fb-5ad7-4b81-90d5-41543aa0e2a4', N'内衣', N'ny', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'b17880d0-583c-4e26-b0fb-8df26ad85923', N'电器', N'dq', 0, N'78e07df3-f17c-4cd1-afea-4efd5a9b738a')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'b35534b0-1846-4edc-ad0b-364bcf51d3ab', N'玩具', N'wj', 0, N'78e07df3-f17c-4cd1-afea-4efd5a9b738a')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'b406bda7-8934-4f41-91b4-4bf8bfe2d252', N'房租', N'fz', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'b5e701df-2289-4511-95af-e0e80af51919', N'医疗', N'yl', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'c4683b4b-858c-4fcb-9fb6-4592cc40aee3', N'网费', N'wf', 0, N'd97d021b-911f-4b8f-923d-86765895f54c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'ce60f179-250b-4989-b1b6-8fc417ca7dec', N'药品', N'yp', 0, N'b5e701df-2289-4511-95af-e0e80af51919')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'd2a535bb-a44f-48d2-8a80-53b72c6af4f9', N'手机费', N'sjf', 0, N'd97d021b-911f-4b8f-923d-86765895f54c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'd65315e7-13c4-491a-aefd-d57a3a25bf08', N'书籍', N'sj', 0, N'e23a3581-5875-45a0-be00-82d3d726d306')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'd97d021b-911f-4b8f-923d-86765895f54c', N'通信', N'tx', 0, N'ea0131a2-7f6e-46f6-a03b-0fccd320e05c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'd9c06e5e-86de-463f-9127-7b2586b53a47', N'固话费', N'ghf', 0, N'd97d021b-911f-4b8f-923d-86765895f54c')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81', N'日常消耗', N'rcxh', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'e23a3581-5875-45a0-be00-82d3d726d306', N'学习', N'xx', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'e5851dcd-0206-4164-8db5-402e4faa11f1', N'偿还贷款', N'chdk', 0, N'de28d316-eb2c-42cf-a390-e2ff2cd3eb81')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'ea0131a2-7f6e-46f6-a03b-0fccd320e05c', N'交际', N'jj', 0, NULL)
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'f13bcb3e-f4f0-42bb-9383-f826793ac7c2', N'卫生用品', N'wsyp', 0, N'2b1d9c5d-72d2-46f5-9881-e637fad804ae')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'f829148f-cc34-4311-a196-96e78ab1acf8', N'帽', N'mao', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
INSERT [dbo].[category] ([id], [name], [abbr], [flag_in_out], [parent_id]) VALUES (N'fdf406ca-7b27-42d0-8e58-f737d62f7e5e', N'衬衣', N'cy', 0, N'127f5693-c341-4aca-ae12-11b58db0fd79')
/****** Object:  Table [dbo].[beneficiary]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  Table [dbo].[product]    Script Date: 03/04/2012 18:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[product](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[barcode] [varchar](13) COLLATE Chinese_PRC_CI_AS NULL,
	[abbr] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[unit_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
	[unit_quantity] [varchar](10) COLLATE Chinese_PRC_CI_AS NULL,
	[manufactory_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Trigger [CategoryDeletion]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  Table [dbo].[trade_record]    Script Date: 03/04/2012 18:15:57 ******/
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
	[payment_mode_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[money] [money] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_trade_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[trade_record_detail]    Script Date: 03/04/2012 18:15:57 ******/
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
/****** Object:  View [dbo].[product_unit_manufactory]    Script Date: 03/04/2012 18:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[product_unit_manufactory]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[product_unit_manufactory]
AS
SELECT        dbo.product.id, dbo.product.name, dbo.product.abbr, dbo.product.name + ''('' + dbo.product.unit_quantity + dbo.unit.name + '')'' AS name_unit,
                          dbo.product.unit_quantity + dbo.unit.name AS unit_name, dbo.unit.id AS unit_id, dbo.manufactory.id AS manufactory_id, 
                         dbo.manufactory.name AS manufactory_name, dbo.manufactory.address, dbo.manufactory.tel
FROM            dbo.product LEFT OUTER JOIN
                         dbo.manufactory ON dbo.manufactory.id = dbo.product.manufactory_id LEFT OUTER JOIN
                         dbo.unit ON dbo.product.unit_id = dbo.unit.id
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'product_unit_manufactory', NULL,NULL))
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
         Begin Table = "unit"
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
      Begin ColumnWidths = 11
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'product_unit_manufactory'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'product_unit_manufactory', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'product_unit_manufactory'
GO
/****** Object:  View [dbo].[journal_record]    Script Date: 03/04/2012 18:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[journal_record]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[journal_record]
AS
SELECT        dbo.trade_record.id, dbo.category.name, dbo.location.name AS location_name, dbo.payer.name AS payer_name, 
                         dbo.payment_mode.name AS payment_mode_name, dbo.trade_record.money
FROM            dbo.trade_record INNER JOIN
                         dbo.category ON dbo.trade_record.category_id = dbo.category.id INNER JOIN
                         dbo.location ON dbo.trade_record.location_id = dbo.location.id INNER JOIN
                         dbo.payer ON dbo.trade_record.payer_id = dbo.payer.id INNER JOIN
                         dbo.payment_mode ON dbo.trade_record.payment_mode_id = dbo.payment_mode.id
'
GO
/****** Object:  Default [DF_category_flag_in_out]    Script Date: 03/04/2012 18:15:57 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_category_flag_in_out]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_category_flag_in_out]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[category] ADD  CONSTRAINT [DF_category_flag_in_out]  DEFAULT ((0)) FOR [flag_in_out]
END


End
GO
/****** Object:  ForeignKey [FK_category_category]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_category] FOREIGN KEY([parent_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_category_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[category]'))
ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_category]
GO
/****** Object:  ForeignKey [FK_product_manufactory]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_manufactory] FOREIGN KEY([manufactory_id])
REFERENCES [dbo].[manufactory] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_manufactory]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_manufactory]
GO
/****** Object:  ForeignKey [FK_product_unit]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_unit] FOREIGN KEY([unit_id])
REFERENCES [dbo].[unit] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_product_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[product]'))
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_unit]
GO
/****** Object:  ForeignKey [FK_trade_record_category]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_category]
GO
/****** Object:  ForeignKey [FK_trade_record_location]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[location] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_location]
GO
/****** Object:  ForeignKey [FK_trade_record_payer]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_payer] FOREIGN KEY([payer_id])
REFERENCES [dbo].[payer] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payer]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_payer]
GO
/****** Object:  ForeignKey [FK_trade_record_payment_mode]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_mode]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_payment_mode] FOREIGN KEY([payment_mode_id])
REFERENCES [dbo].[payment_mode] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_payment_mode]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record]'))
ALTER TABLE [dbo].[trade_record] CHECK CONSTRAINT [FK_trade_record_payment_mode]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_beneficiary]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_beneficiary] FOREIGN KEY([beneficiary_id])
REFERENCES [dbo].[beneficiary] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_beneficiary]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_beneficiary]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_product]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_product]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_product]
GO
/****** Object:  ForeignKey [FK_trade_record_detail_trade_record]    Script Date: 03/04/2012 18:15:57 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail]  WITH CHECK ADD  CONSTRAINT [FK_trade_record_detail_trade_record] FOREIGN KEY([trade_record_id])
REFERENCES [dbo].[trade_record] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_trade_record_detail_trade_record]') AND parent_object_id = OBJECT_ID(N'[dbo].[trade_record_detail]'))
ALTER TABLE [dbo].[trade_record_detail] CHECK CONSTRAINT [FK_trade_record_detail_trade_record]
GO
