CREATE TABLE [users]
(
	[id] INT IDENTITY(1,1) PRIMARY KEY,
	[uid] INT NOT NULL UNIQUE,
	[password] VARCHAR(20) NOT NULL, 
	[surname] VARCHAR(50) NOT NULL,
	[name] VARCHAR(50) NOT NULL ,
	[patronymic] VARCHAR(50) NOT NULL,
	[photo] IMAGE,
	[is_admin] BIT DEFAULT 'FALSE' 
)