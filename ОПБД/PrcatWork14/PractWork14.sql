-- Задание 1
SELECT BookId, Title, Surname, [Name], Price
FROM Book b
	JOIN Author a ON b.AuthorId = a.AuthorId;

-- Задание 2
SELECT OrderId, b.BookId, Title, Surname, [Name], Price, Quantity, Price * Quantity Cost
FROM OrderedBook ob
	JOIN Book b ON ob.BookId = b.BookId
	JOIN Author a ON b.AuthorId = a.AuthorId;

-- Задание 3
SELECT o.OrderId, o.OrderDate, SUM(ob.Quantity * b.Price) 'Order cost'
FROM OrderedBook ob
	JOIN [Order] o ON ob.OrderId = o.OrderId
	JOIN Book b ON ob.BookId = b.BookId
GROUP BY o.OrderId, o.OrderDate
ORDER BY o.OrderDate DESC;

-- Задание 4
SELECT c.CustomerId, c.[Login], Count(OrderId) 'Number of orders'
FROM Customer c
	LEFT JOIN [Order] o ON c.CustomerId = o.CustomerId
GROUP BY c.CustomerId, c.[Login];

-- Задание 5
SELECT *
FROM [Order]
	WHERE OrderId NOT IN (SELECT DISTINCT OrderId
							FROM OrderedBook);

-- Задание 6
SELECT *
FROM Customer
WHERE CustomerId IN (SELECT DISTINCT CustomerId
					FROM [Order]);

-- Задание 7
SELECT Surname, [Name], 'Автор' [Role]
FROM Author
UNION SELECT Surname, [Name], 'Заказчик' [Role]
FROM Customer
ORDER BY Surname, [Name];