
IF (EXISTS (SELECT 1 
            FROM INFORMATION_SCHEMA.TABLES 
            WHERE TABLE_SCHEMA = 'dbo' 
                  AND TABLE_NAME = 'Posts'))
BEGIN
    DROP TABLE [dbo].[Posts]
END 

IF (EXISTS (SELECT 1 
            FROM INFORMATION_SCHEMA.TABLES 
            WHERE TABLE_SCHEMA = 'dbo' 
                  AND TABLE_NAME = 'Users'))
BEGIN
    DROP TABLE [dbo].[Users]
END


CREATE TABLE [dbo].[Users] (
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [FirstName] NVARCHAR(100) NOT NULL,
    [LastName] NVARCHAR(100) NOT NULL,
)

CREATE TABLE [dbo].[Posts] (
    [Id] INT NOT NULL IDENTITY PRIMARY KEY,
    [UserId] INT NOT NULL FOREIGN KEY REFERENCES users(id),
    [Title] NVARCHAR(100) NOT NULL,
    [Body] NVARCHAR(MAX) NOT NULL
)

INSERT INTO Users(FirstName, LastName)
VALUES
('Barry', 'Balondo'),
('Dana', 'Festejo')

INSERT INTO Posts(UserId, Title, Body)
VALUES
(1, 'Title From Barry', 'Body from Barry.'),
(2, 'Title From Dana', 'Body from Dana.'),
(1, 'Title From Barry Two', 'Body from Barry Two.')