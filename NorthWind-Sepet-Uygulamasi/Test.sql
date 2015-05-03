use Northwind
DECLARE @OrderID int;
SELECT TOP 1  @OrderID = OrderID  FROM ORDERS ORDER BY OrderID DESC
SELECT O.OrderID, O.CustomerID, C.CompanyName, C.ContactName FROM [Orders] O
	JOIN Customers C ON C.CustomerID = O.CustomerID
WHERE OrderID = @OrderID
SELECT OD.*, P.ProductName FROM [Order Details] OD
	JOIN Products P ON P.ProductID = OD.ProductID
WHERE OrderID = @OrderID 

-- DELETE [ORDER DETAILS]; DELETE ORDERS; 
-- SELECT COUNT(*) FROM ORDERS