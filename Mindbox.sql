select [dbo].[Product].[name] as �������, [dbo].[Category].[name] as ��������� from
	[dbo].[Product] left join [dbo].[Product and Category] on
		[dbo].[Product].[id] = [dbo].[Product and Category].[id_product]
	left join [dbo].[Category] on [dbo].[Category].[id]=[dbo].[Product and Category].[id_category];