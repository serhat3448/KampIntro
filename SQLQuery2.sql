--SELECT
--ANSII
--CASE INSENSITIVE

SELECT ContactName Adi, CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers WHERE City = 'London'

SELECT * FROM Products WHERE CategoryID=1 OR CategoryID=3

SELECT * FROM Products WHERE CategoryID=1 AND UnitPrice>=10

SELECT * FROM Products ORDER BY UnitPrice ASC
--ASC ASCENDING -- ARTAN

SELECT * FROM Products ORDER BY UnitPrice DESC
--DESC DESCENDING -- AZALAN

SELECT * FROM Products WHERE CategoryID=1 ORDER BY UnitPrice ASC

SELECT COUNT(*) Adet FROM Products WHERE CategoryID=2

SELECT CategoryID, COUNT(*) SAYI FROM Products GROUP BY CategoryID

SELECT CategoryID, COUNT(*) SAYI FROM Products where UnitPrice>20 GROUP BY CategoryID HAVING COUNT(*)<10
--Having cumulatiflere uygulanır 

SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
FROM Products INNER JOIN Categories 
ON Products.CategoryID = Categories.CategoryID 
WHERE Products.UnitPrice>10

--DTO DATA TRANSFORMATION OBJECT

SELECT * FROM Products p INNER JOIN [Order Details] od ON p.ProductID = od.ProductID INNER JOIN Orders o ON o.OrderID = od.OrderID

SELECT * FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID WHERE o.CustomerID IS NULL