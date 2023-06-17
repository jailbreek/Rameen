CREATE TABLE [dbo].[Role]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Meat]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[User]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [RoleId] INT NOT NULL,
    [Username] VARCHAR(50) NOT NULL,
    [Email] VARCHAR(50) NOT NULL,
    [Gender] VARCHAR(50) NOT NULL,
    [Password] VARCHAR(50) NOT NULL,
    CONSTRAINT [FK_User_ToRole] FOREIGN KEY ([RoleId]) REFERENCES [Role]([Id]) 
)

CREATE TABLE [dbo].[Header]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [CustomerId] INT NOT NULL,
    [StaffId] INT NOT NULL,
    [Date] DATE NOT NULL,
    CONSTRAINT [FK_Header_ToUser] FOREIGN KEY ([CustomerId]) REFERENCES [User]([Id])
)

CREATE TABLE [dbo].[Ramen]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [MeatId] INT NOT NULL,
    [Name] VARCHAR(50),
    [Borth] VARCHAR(50),
    [Price]  VARCHAR(50), 
    CONSTRAINT [FK_Ramen_ToMeat] FOREIGN KEY ([MeatId]) REFERENCES [Meat]([Id])
)

CREATE TABLE [dbo].[Detail]
(
    [HeaderId] INT NOT NULL,
    [RamenId] INT NOT NULL,
    [Quantity] INT NOT NULL, 
    CONSTRAINT [PK_Detail] PRIMARY KEY ([HeaderId], [RamenId]),
    CONSTRAINT [FK_Detail_ToHeader] FOREIGN KEY ([HeaderId]) REFERENCES [Header]([Id]), 
    CONSTRAINT [FK_Detail_ToRamen] FOREIGN KEY ([RamenId]) REFERENCES [Ramen]([Id])
)