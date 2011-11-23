/****** Object:  ForeignKey [FK_consume_record_category]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] DROP CONSTRAINT [FK_consume_record_category]
GO
/****** Object:  ForeignKey [FK_consume_record_location]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] DROP CONSTRAINT [FK_consume_record_location]
GO
/****** Object:  ForeignKey [FK_consume_record_member]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] DROP CONSTRAINT [FK_consume_record_member]
GO
/****** Object:  ForeignKey [FK_consume_record_payment_category]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] DROP CONSTRAINT [FK_consume_record_payment_category]
GO
/****** Object:  ForeignKey [FK_income_record_member]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_income_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[income_record]'))
ALTER TABLE [dbo].[income_record] DROP CONSTRAINT [FK_income_record_member]
GO
/****** Object:  Table [dbo].[consume_record]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[consume_record]') AND type in (N'U'))
DROP TABLE [dbo].[consume_record]
GO
/****** Object:  Table [dbo].[income_record]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[income_record]') AND type in (N'U'))
DROP TABLE [dbo].[income_record]
GO
/****** Object:  Table [dbo].[location]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[location]') AND type in (N'U'))
DROP TABLE [dbo].[location]
GO
/****** Object:  Table [dbo].[member]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[member]') AND type in (N'U'))
DROP TABLE [dbo].[member]
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[payment_category]') AND type in (N'U'))
DROP TABLE [dbo].[payment_category]
GO
/****** Object:  Table [dbo].[category]    Script Date: 11/23/2011 16:29:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
DROP TABLE [dbo].[category]
GO
/****** Object:  Table [dbo].[category]    Script Date: 11/23/2011 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[category](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[parent_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[payment_category]    Script Date: 11/23/2011 16:29:21 ******/
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
/****** Object:  Table [dbo].[member]    Script Date: 11/23/2011 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[member]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[member](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[location]    Script Date: 11/23/2011 16:29:21 ******/
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
/****** Object:  Table [dbo].[income_record]    Script Date: 11/23/2011 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[income_record]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[income_record](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varbinary](50) NOT NULL,
	[money] [money] NOT NULL,
	[member_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_income_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[consume_record]    Script Date: 11/23/2011 16:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[consume_record]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[consume_record](
	[id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[name] [varchar](50) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[unit_price] [money] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [money] NOT NULL,
	[date] [date] NOT NULL,
	[specification] [int] NULL,
	[category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[location_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[payer_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
	[beneficiary_id] [char](36) COLLATE Chinese_PRC_CI_AS NULL,
	[payment_category_id] [char](36) COLLATE Chinese_PRC_CI_AS NOT NULL,
 CONSTRAINT [PK_consume_record] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  ForeignKey [FK_consume_record_category]    Script Date: 11/23/2011 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_record_category] FOREIGN KEY([category_id])
REFERENCES [dbo].[category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] CHECK CONSTRAINT [FK_consume_record_category]
GO
/****** Object:  ForeignKey [FK_consume_record_location]    Script Date: 11/23/2011 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_record_location] FOREIGN KEY([location_id])
REFERENCES [dbo].[location] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_location]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] CHECK CONSTRAINT [FK_consume_record_location]
GO
/****** Object:  ForeignKey [FK_consume_record_member]    Script Date: 11/23/2011 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_record_member] FOREIGN KEY([payer_id])
REFERENCES [dbo].[member] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] CHECK CONSTRAINT [FK_consume_record_member]
GO
/****** Object:  ForeignKey [FK_consume_record_payment_category]    Script Date: 11/23/2011 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record]  WITH CHECK ADD  CONSTRAINT [FK_consume_record_payment_category] FOREIGN KEY([payment_category_id])
REFERENCES [dbo].[payment_category] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_consume_record_payment_category]') AND parent_object_id = OBJECT_ID(N'[dbo].[consume_record]'))
ALTER TABLE [dbo].[consume_record] CHECK CONSTRAINT [FK_consume_record_payment_category]
GO
/****** Object:  ForeignKey [FK_income_record_member]    Script Date: 11/23/2011 16:29:21 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_income_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[income_record]'))
ALTER TABLE [dbo].[income_record]  WITH CHECK ADD  CONSTRAINT [FK_income_record_member] FOREIGN KEY([member_id])
REFERENCES [dbo].[member] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_income_record_member]') AND parent_object_id = OBJECT_ID(N'[dbo].[income_record]'))
ALTER TABLE [dbo].[income_record] CHECK CONSTRAINT [FK_income_record_member]
GO
