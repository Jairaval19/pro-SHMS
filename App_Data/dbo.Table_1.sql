CREATE TABLE [dbo].[Registration]
(
	[Full name] VARCHAR(50) NOT NULL , 
    [UserName] VARCHAR(50) NOT NULL, 
    [Age] NUMERIC NOT NULL, 
    [Phone] NUMERIC NOT NULL, 
    [Password] CHAR(10) NOT NULL, 
    [Confirm password] CHAR(10) NOT NULL, 
    [Description] VARCHAR(50) NOT NULL, 
    PRIMARY KEY ([UserName])
)
