﻿GO
SET IDENTITY_INSERT [dbo].[Categories] ON
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (1, N'Pizza', N'Pizza')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (2, N'Dessert', N'Dessert')
GO
INSERT [dbo].[Categories] ([Id], [Name], [Description]) VALUES (3, N'Beverages', N'Beverages')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF

------------------------------------------
GO
SET IDENTITY_INSERT [dbo].[ItemTypes] ON
GO
INSERT [dbo].[ItemTypes] ([Id], [Name]) VALUES (1, N'Veg')
GO
INSERT [dbo].[ItemTypes] ([Id], [Name]) VALUES (2, N'NonVeg')
GO
SET IDENTITY_INSERT [dbo].[ItemTypes] OFF