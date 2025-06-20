-- Задание 1
UPDATE Book
SET Price = ROUND(Price, -1);

-- Задание 2
SELECT YEAR(OrderDate) Год, MONTH(OrderDate) Месяц, COUNT(*) Количество
FROM [Order]
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY YEAR(OrderDate), MONTH(OrderDate) DESC;

-- Задание 3
UPDATE Book
SET Price = Price * 0.9
WHERE BookId IN (SELECT b.BookId
					FROM Book b
						LEFT JOIN OrderedBook ob ON b.BookId = ob.BookId
						JOIN [Order] o ON ob.OrderId = o.OrderId
					WHERE YEAR(PublicationYear) != YEAR(GETDATE()) OR PublicationYear IS NULL);

-- Задание 4
SELECT CustomerId, UPPER(Surname) + ' ' + UPPER(LEFT(LTRIM([Name]), 1)) + '.'
FROM Customer;

-- Задание 5
SELECT REPLACE(TRIM([Login]), ' ', '_')
FROM Customer;

-- Задание 6
SELECT 
	CustomerId, 
	[Login], 
	Surname,
	[Name],
	CASE WHEN TRIM([Address]) != '' THEN [Address] ELSE NULL END [Address], 
	CASE WHEN Phone IS NULL THEN '-' ELSE Phone END Phone
FROM Customer;

-- Задание 7
SELECT  DISTINCT Title
FROM Book
GROUP BY BookId, Title