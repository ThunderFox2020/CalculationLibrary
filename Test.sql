CREATE TABLE Products
(
    ProductID int PRIMARY KEY,
    ProductName nvarchar(50)
);

CREATE TABLE Categories
(
    CategoryID int PRIMARY KEY,
    CategoryName nvarchar(50)
);

CREATE TABLE ProductCategories (
    ProductID int,
    CategoryID int,
    PRIMARY KEY (ProductID, CategoryID)
);

INSERT INTO Products VALUES (1, 'Phone');
INSERT INTO Products VALUES (2, 'Table');
INSERT INTO Products VALUES (3, 'Microwave');
INSERT INTO Products VALUES (4, 'Blanket');
INSERT INTO Products VALUES (5, 'Book');

INSERT INTO Categories VALUES (1, 'Appliances');
INSERT INTO Categories VALUES (2, 'Automotive products');
INSERT INTO Categories VALUES (3, 'Furniture');
INSERT INTO Categories VALUES (4, 'Electronics');
INSERT INTO Categories VALUES (5, 'For home');

INSERT INTO ProductCategories VALUES (1, 4);
INSERT INTO ProductCategories VALUES (2, 3);
INSERT INTO ProductCategories VALUES (2, 5);
INSERT INTO ProductCategories VALUES (3, 1);
INSERT INTO ProductCategories VALUES (3, 4);
INSERT INTO ProductCategories VALUES (3, 5);
INSERT INTO ProductCategories VALUES (4, 5);

SELECT p.ProductName, ISNULL(c.CategoryName, 'No category') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID