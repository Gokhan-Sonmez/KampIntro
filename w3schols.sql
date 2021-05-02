SELECT count(distinct Country) FROM Customers;

--distinc tekrarlanan değerlerden kurtarır

select * from Customers
where Country = 'Mexico'

select * from Customers
where CustomerID = 1

---Order by sıralama

select * from Customers
order by Country desc  -- tersten sırala

select * from  Customers
order by Country,CompanyName

select * from Customers
order by Country ASC,CompanyName desc

--insert into  -- yeni kayıt ekler

INSERT INTO Customers (CompanyName, City, Country)
VALUES ('Cardinal', 'Stavanger', 'Norway');

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;


DELETE FROM Customers WHERE CustomerName='Alfreds Futterkiste';

SELECT TOP 3 * FROM Customers;  ---  ilk 3 sıra göster
SELECT TOP 50 PERCENT * FROM Customers; -- ilk yuzde 50

SELECT MIN(UnitPrice) AS SmallestPrice
FROM Products; -- en ucuz ürünü bul
SELECT Max(UnitPrice) AS LargestPrice
FROM Products; -- en pahalı ürünü bul

SELECT count(*)
from Products
where UnitPrice = 18

SELECT * FROM Customers
WHERE CompanyName LIKE 'a%';

SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

SELECT *
FROM Orders
LEFT JOIN Customers
ON Orders.CustomerID = Customers.CustomerID

SELECT *
FROM Orders
INNER JOIN Customers
ON Orders.CustomerID=Customers.CustomerID;
