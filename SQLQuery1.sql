USE [CrudDemoDb]
GO

CREATE TABLE [dbo].[Product]
(
	Id int NOT NULL,
	Name nchar (20) NOT NULL,
	Price nchar (10) NULL
) 

           
INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (2
           ,'Laptop'
           ,'500')
           
INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (3
           ,'Tablet'
           ,'500')
           
INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (4
           ,'Mobile'
           ,'500')
           
INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (5
           ,'Mice'
           ,'500')
           
INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (6
           ,'Printer'
           ,'500')

           INSERT INTO [dbo].[Product]
           ([Id]
           ,[Name]
           ,[Price])
     VALUES
           (7
           ,'Watch'
           ,'500')
GO


select * from [dbo].[Product]


--ALTER TABLE [dbo].[Product]
--ALTER COLUMN [Name] NCHAR(50) NOT NULL