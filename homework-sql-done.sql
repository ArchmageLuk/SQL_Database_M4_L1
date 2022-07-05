--------------------------ДОМАШКА----------------------------
USE [AdventureWorks2019]
----------------------ЗАДАНИЕ №1-----------------------------
--Вывести всю информацию из таблицы Sales.Customer 
-------------------------------------------------------------

SELECT * FROM Sales.Customer
GO

----------------------ЗАДАНИЕ №2-----------------------------
--Вывести всю информацию из таблицы Sales.Store отсортированную 
--по Name в алфавитном порядке
-------------------------------------------------------------
SELECT * FROM Sales.Store ORDER BY [Name]
GO

----------------------ЗАДАНИЕ №3-----------------------------
--Вывести из таблицы HumanResources.Employee всю информацию
--о десяти сотрудниках, которые родились позже 1989-09-28
-------------------------------------------------------------

SELECT TOP 10 * FROM HumanResources.Employee WHERE [BirthDate] > '19890928'
GO

----------------------ЗАДАНИЕ №4-----------------------------
--Вывести из таблицы HumanResources.Employee сотрудников
--у которых последний символ LoginID является 0.
--Вывести только NationalIDNumber, LoginID, JobTitle.
--Данные должны быть отсортированы по JobTitle по убиванию
-------------------------------------------------------------

SELECT NationalIDNumber, LoginID, JobTitle FROM HumanResources.Employee WHERE [LoginID] LIKE '%0' ORDER BY [JobTitle] DESC
GO

----------------------ЗАДАНИЕ №5-----------------------------
--Вывести из таблицы Person.Person всю информацию о записях, которые были 
--обновлены в 2008 году (ModifiedDate) и MiddleName содержит
--значение и Title не содержит значение 
-------------------------------------------------------------

SELECT * FROM Person.Person WHERE [ModifiedDate] BETWEEN '20080101' AND '20081231' AND [MiddleName] IS NOT NULL AND [Title] IS NULL
GO

----------------------ЗАДАНИЕ №6-----------------------------
--Вывести название отдела (HumanResources.Department.Name) БЕЗ повторений
--в которых есть сотрудники
--Использовать таблицы HumanResources.EmployeeDepartmentHistory и HumanResources.Department
-------------------------------------------------------------

SELECT DISTINCT [Name] FROM HumanResources.Department AS hrd INNER JOIN HumanResources.EmployeeDepartmentHistory AS hredh ON hrd.DepartmentID = hredh.DepartmentID
GO

----------------------ЗАДАНИЕ №7-----------------------------
--Сгрупировать данные из таблицы Sales.SalesPerson по TerritoryID
--и вывести сумму CommissionPct, если она больше 0
-------------------------------------------------------------

SELECT [TerritoryID], SUM ([CommissionPct]) FROM Sales.SalesPerson WHERE [CommissionPct] > 0 GROUP BY [TerritoryID]
GO

----------------------ЗАДАНИЕ №8-----------------------------
--Вывести всю информацию о сотрудниках (HumanResources.Employee) 
--которые имеют самое большое кол-во 
--отпуска (HumanResources.Employee.VacationHours)
-------------------------------------------------------------

SELECT * FROM HumanResources.Employee WHERE [VacationHours] > 80
GO

----------------------ЗАДАНИЕ №9-----------------------------
--Вывести всю информацию о сотрудниках (HumanResources.Employee) 
--которые имеют позицию (HumanResources.Employee.JobTitle)
--'Sales Representative' или 'Network Administrator' или 'Network Manager'
-------------------------------------------------------------

SELECT * FROM HumanResources.Employee WHERE [JobTitle] IN ('Sales Representative', 'Network Administrator', 'Network Manager')
GO

----------------------ЗАДАНИЕ №10-----------------------------
--Вывести всю информацию о сотрудниках (HumanResources.Employee) и 
--их заказах (Purchasing.PurchaseOrderHeader). ЕСЛИ У СОТРУДНИКА НЕТ
--ЗАКАЗОВ ОН ДОЛЖЕН БЫТЬ ВЫВЕДЕН ТОЖЕ!!!
-------------------------------------------------------------

SELECT * FROM HumanResources.Employee AS hre LEFT JOIN Purchasing.PurchaseOrderHeader AS poh ON hre.BusinessEntityID = poh.EmployeeID
GO

---------------------PRESENTATION TASKS--------------------
--GROUP BY и HAVING
SELECT [LastName] FROM Person.Person GROUP BY [LastName] HAVING LEN([LastName]) = 3
GO

--AGGREGATE FUNCTIONS
SELECT MIN ([SalesQuota]) AS 'MIN Quota', MAX ([Bonus]) AS 'MAX Bonus', AVG ([CommissionPct]) AS 'AVG Commission', SUM ([SalesLastYear]) AS 'SUM Last Year', COUNT ([SalesYTD]) AS 'COUNT SalesYTD' FROM Sales.SalesPerson
GO

--FULL JOIN
SELECT * FROM Sales.SalesPerson AS ssp FULL JOIN Sales.SalesTerritory AS sst ON ssp.TerritoryID = sst.TerritoryID
GO

--UPDATE/DELETE
--UPDATE all entries
SELECT * FROM Production.ProductInventory AS ppi
UPDATE Production.ProductInventory
SET [Quantity] = [Quantity] + 300

--UPDATE 1 entry
SELECT * FROM Production.ProductInventory
UPDATE Production.ProductInventory
SET [Bin] = '5' FROM (SELECT TOP 1 * FROM Production.ProductInventory WHERE [Bin] = 2) AS Sorted
WHERE ProductInventory.ProductID = Sorted.ProductID

--DELETE all entries/ some entries
DELETE Production.Location
DELETE Production.Location WHERE [LocationID] = 3

--TRANSACTION DELETE
BEGIN TRANSACTION
DELETE Production.Location FROM (SELECT TOP 3 * FROM Production.Location WHERE [CostRate] = 0) AS Zeros
WHERE Location.LocationID = Zeros.LocationID
ROLLBACK
COMMIT TRANSACTION

