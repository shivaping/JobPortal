CREATE TABLE [dbo].[User_Type] (
    [User_Type_Id]          INT             NOT NULL,
    [User_Type_Name]        VARCHAR (100)   NOT NULL,
    [User_Type_Description] VARBINARY (300) NOT NULL,
    [Created_Date]          DATETIME        NOT NULL,
    [Updated_Date]          DATETIME        NOT NULL,
    CONSTRAINT [Pk_User_Type] PRIMARY KEY CLUSTERED ([User_Type_Id] ASC)
);

