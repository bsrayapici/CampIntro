--select 
Select ContactName Adı,CompanyName Sirketadi from Customers

select *from Customers where City = 'London'

--case insensitive
select *from Products where CategoryID=1 or CategoryID=3 and UnitPrice >= 10
select*from Categories

select *from products order by Categoryid asc --ascending zıttı descending = azalan

select *from products where CategoryID=1 order by UnitPrice

select count(*)from products where CategoryID=2 and UnitPrice>10
--Group by kullanılırken ; group by ile sıralamaya çalıştığımız şey yalnızca select ile seçilebilir.
select CategoryID, count (*) FROM Products group by CategoryID
--tekrar etmeyecek şekilde getir demek için ;
select categoryID from Products group by CategoryID 

-- groupy by da büyüktür ve küçüktür yapısını oturtmak için having yapısı count(*) ile kullanılır.
--Önce her zaman where conditionı çalışır.
select CategoryID, count (*) FROM Products where UnitPrice>20 group by CategoryID having count(*) <10

--ıd yerine isim getirmek istediğimizde join kullanırız.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where UnitPrice>10

--DTO Data Transformation Object
--solda olup sağda olmayanları getir yani örneğin satışı yapılamayan ürünler;
select *from Products p left join [Order Details] od
on p.ProductID=od.ProductID

select *from Customers c left join Orders o
on c.CustomerID=o.CustomerID
--sisteme kayıtlı olmuş ama ürün almamış ;
select *from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null
--birden fazla join ekleyebiliriz. ;

select*
from products p inner join [Order Details] od on p.ProductID=od.ProductID 
inner join [Orders] o 
on o.OrderID=od.OrderID





