CREATE TABLE Restaurant
(
    Id INT NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Zipcode NVARCHAR(50) NOT NULL,
    Rating FLOAT NOT NULL,
    UserReview NVARCHAR(50) NOT NULL,
    TotalRatings INT NOT NULL
)
SELECT * FROM Restaurant

CREATE TABLE Review
(
    Id INT NOT NULL PRIMARY KEY,
    UserId INT NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    Rating FLOAT NOT NULL,
    UserReview NVARCHAR(50) NOT NULL,
)
SELECT * FROM Review  

CREATE TABLE User
(
    UserId INT NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Zipcode NVARCHAR(50) NOT NULL,
    UserReview NVARCHAR(50) NOT NULL
)
SELECT * FROM User

INSERT INTO Restaurant (Id, Name, Zipcode, Rating, UserReview, TotalRatings) VALUES ('Id', 'Name', 'Zipcode', 'Rating', 'UserReview', 'TotalRatings')
INSERT INTO Review (Id, UserId, Name, Rating, UserReview) VALUES ('Id', 'UserId', 'Name', 'Rating', 'UserReview')
INSERT INTO User (Id, Username, Password, Zipcode) VALUES ('Id', 'Username', 'Password', 'Zipcode')

SELECT * FROM User
-- SUM(Rating)
AVG(Rating)