CREATE TABLE Accounts
(
    Id INT PRIMARY KEY IDENTITY,
    CardNumber NVARCHAR(50) NOT NULL,
    OwnerName NVARCHAR(50) NOT NULL,
    Balance DECIMAL(18, 2) NOT NULL,
    PinCode NVARCHAR(50) NOT NULL
)
TRUNCATE TABLE Accounts;
