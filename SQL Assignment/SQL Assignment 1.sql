CREATE TABLE Customer
(ID int PRIMARY KEY, FirstName nvarchar(40) NOT NULL, LastName nvarchar(40),City nvarchar(40),Country nvarchar(40),Phone nvarchar(20)
);


CREATE TABLE Orders
(ID int PRIMARY KEY, OrderDate datetime, OrderNumber nvarchar(10), CustomerId int, TotoalAmount decimal(12,2)
FOREIGN KEY (CustomerId) REFERENCES Customer (ID)
);

CREATE TABLE Product 
(ID int PRIMARY KEY, ProductName nvarchar(50), UnitPrice decimal(12,2), Package nvarchar(30)
);


CREATE TABLE OrderItem
(ID int PRIMARY KEY, OrderId int, ProductId int, UnitPrice Decimal(12,2), Quantity int,
FOREIGN KEY (OrderId) REFERENCES Orders (ID),
FOREIGN KEY (ProductId) REFERENCES Product (ID)
);

ALTER TABLE Orders
ALTER COLUMN OrderDate datetime NOT NULL;

INSERT INTO Customer ( ID, FirstName, LastName, City, Country, Phone)
VALUES ('100', 'Amal', 'Krishna', 'Kerala', 'India', '8086055349'), 
('101', 'Shebin', 'Sukumar', 'Behrin', 'UAE', '7856354890'),
('102', 'Bilal', 'John', 'Kerala', 'India', '9873214560'),
('103', 'Britt', 'Robertson', 'California', 'USA', '9856321470'),
('104', 'Emilia', 'Clarke', 'Oxford', 'Britan', '9653278564');

exec sp_rename 'Orders.TotoalAmount', 'TotalAmount', 'Column';


INSERT INTO Orders (ID, OrderDate, OrderNumber, CustomerId, TotalAmount)
VALUES ('200', '2022-04-04', '0123', '100', '5000'),
('201', '2022-04-01', '6579', '101', '9574.99'),
('202', '2022-03-15', '7852', '102', '10000'),
('203', '2022-01-24', '9988', '103', '550.50'),
('204', '2022-03-30', '8778', '104', '900');

INSERT INTO Product(ID, ProductName, UnitPrice, Package)
VALUES ('300', 'Shoes', '1500', 'Cardboard'),
('301', 'Watch', '5000', 'Leather'),
('302', 'Toys', '5500.50', 'Metal'),
('303', 'Makeup Set', '350', 'Plastic'),
('304', 'Food Items', '250.25', 'Paper');

INSERT INTO OrderItem(ID, OrderId, ProductId, UnitPrice, Quantity)
VALUES ('400', '200', '300', '1500', '150'),
('401', '201', '301', '5000', '600'),
('402', '202', '302', '5500.50', '1000'),
('403', '203', '303', '350', '125'),
('404', '204', '304', '250.25', '900');


--Select the country of customer where first name starts with A OR S
SELECT Country FROM Customer
WHERE FirstName LIKE 'A%' 
OR 
FirstName LIKE 'S%';


--Select the customer where first name third letter is A
SELECT FirstName, LastName FROM Customer
WHERE FirstName LIKE '__a%'; 

SELECT * FROM Orders

UPDATE Customer
SET Phone = NULL
WHERE ID = 100;