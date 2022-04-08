--Select the customer details where the country is India
SELECT * FROM Customer
WHERE Country = 'India';

--Combine First name and Last name
SELECT CONCAT (FirstName,' ', LastName) AS FullName
FROM  Customer;

--Customer details who has phone number
SELECT * FROM Customer
WHERE Phone IS NOT NULL; 

--Order Details where Unit price is greater than 1000 and less than 5500
SELECT * FROM OrderItem
WHERE UnitPrice >1000 
AND
UnitPrice <5500;

--Arrange the details by date
SELECT * FROM Orders
ORDER BY OrderDate;

--Print datas b/w 2 dates
SELECT * FROM Orders
WHERE OrderDate BETWEEN 1996 AND 2022-04-04; 

--AVG Quantity 
SELECT AVG (UnitPrice) AS UnitPriceAvg FROM Product;

--