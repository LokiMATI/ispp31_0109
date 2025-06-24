-- Задание 1
UPDATE Book
SET Price = ROUND(Price, -1);

-- Задание 2
SELECT YEAR(OrderDate) Год, MONTH(OrderDate) Месяц, COUNT(*) Количество
FROM [Order]
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY YEAR(OrderDate) DESC, MONTH(OrderDate) DESC;

-- Задание 3
UPDATE Book
SET Price = Price * 0.9
WHERE BookId IN (SELECT b.BookId
					FROM Book b
						LEFT JOIN OrderedBook ob ON b.BookId = ob.BookId
						JOIN [Order] o ON ob.OrderId = o.OrderId
					WHERE YEAR(OrderDate) != YEAR(GETDATE()) OR OrderDate IS NULL);

-- Задание 4
SELECT CustomerId, UPPER(Surname + ' ' + LEFT(LTRIM([Name]), 1)) + '.'
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
	NULLIF(TRIM([Address]), '') [Address], 
	ISNULL(Phone, '-') Phone
FROM Customer;

-- Задание 7
SELECT  DISTINCT AuthorId, STRING_AGG(Title, ';') WITHIN GROUP (ORDER BY Title)
FROM Book
GROUP BY AuthorId;

-- Задание 8
SELECT STRING_AGG(CONCAT(Surname, ' ', [Name], ' ', Title), '; ')
FROM OrderedBook ob
	JOIN Book b ON ob.BookId = b.BookId
	JOIN Author a ON b.AuthorId = a.AuthorId
GROUP BY OrderId;

-- Задание 9
SELECT ROW_NUMBER() OVER (ORDER BY Title) AS #, Title
FROM Book;

-- Задание 10
SELECT ROW_NUMBER() OVER (PARTITION BY Genre ORDER BY Title) AS #, Genre, Title
FROM Book;