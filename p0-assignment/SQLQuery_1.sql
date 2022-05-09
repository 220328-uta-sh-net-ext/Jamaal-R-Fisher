CREATE TABLE Restaurant
(
    Id INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Zipcode NVARCHAR(50) NOT NULL,
    Rating FLOAT NOT NULL,
    Review NVARCHAR(50) NOT NULL,
    TotalRatings FLOAT NOT NULL
)
SELECT * FROM Restaurant   

CREATE TABLE Users
(
    Id INT NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Zipcode NVARCHAR(50) NOT NULL
)
SELECT * FROM Users

INSERT INTO Restaurant (Id, Name, Zipcode, Rating, Review, TotalRatings) VALUES ('', '')
INSERT INTO Users (Id, Username, Password, Zipcode) VALUES ('', '')

SELECT * FROM Users
SUM(Rating)