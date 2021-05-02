--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir From Customers

Select * from Customers where City = 'Berlin'

--case insensitive
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products where CategoryID = 1 order by UnitPrice desc --ascending artan  asc --descending azalan desc

Select COUNT(*)Adet from Products 

select CategoryID,count(*) Adet from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od    --inner join iki tarafta eşleşiyorsa
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
-- solda olup sağda olyanlarıda getir  

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null



Select p.ProductName,SUM(od.Quantity*od.UnitPrice) Ktutar from Products p 
inner join [Order Details] od on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID
group by p.ProductName


SELECT Products.ProductName as [Ürün Adı], sum([Order Details].Quantity * [Order Details].UnitPrice) as [Kazanılan Toplam Miktar]
From Products
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
INNER JOIN Orders ON [Order Details].OrderID = Orders.OrderID
GROUP BY Products.ProductName 
ORDER BY Products.ProductName

