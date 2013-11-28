CREATE TABLE [users]
(
	[id] INT IDENTITY(1,1) PRIMARY KEY,
	[uid] INT NOT NULL UNIQUE,
	[password] VARCHAR(255) NOT NULL, 
	[surname] VARCHAR(50) NOT NULL,
	[name] VARCHAR(50) NOT NULL ,
	[patronymic] VARCHAR(50) NOT NULL,
	[image_url] VARCHAR(100) NOT NULL,
	[is_admin] BIT DEFAULT 'FALSE' 
)