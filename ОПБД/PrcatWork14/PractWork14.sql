-- ������� 1
SELECT BookId, Title, Surname, [Name], Price
FROM Book b
	JOIN Author a ON b.AuthorId = a.AuthorId;

-- ������� 2
SELECT OrderId, b.BookId, Title, Surname, [Name], Price, Quantity, Price * Quantity '���������'
FROM OrderedBook ob
	JOIN Book b ON ob.BookId = b.BookId
	JOIN Author a ON b.AuthorId = a.AuthorId;

-- ������� 3
SELECT o.OrderId, o.OrderDate, SUM(ob.Quantity * b.Price) '��������� ������'
FROM OrderedBook ob
	JOIN [Order] o ON ob.OrderId = o.OrderId
	JOIN Book b ON ob.BookId = b.BookId
GROUP BY o.OrderId, o.OrderDate
ORDER BY o.OrderDate DESC;

-- ������� 4
SELECT c.CustomerId, c.[Login], Count(OrderId) '���-�� �������'
FROM Customer c
	LEFT JOIN [Order] o ON c.CustomerId = o.CustomerId
GROUP BY c.CustomerId, c.[Login]

-- ������� 5
SELECT *
FROM [Order]
	WHERE OrderId NOT IN (SELECT OrderId
							FROM OrderedBook);

-- ������� 6
SELECT *
FROM Customer
WHERE CustomerId IN (SELECT CustomerId
					FROM [Order]);

-- ������� 7
SELECT Surname, [Name], '�����' '����'
FROM Author
UNION SELECT Surname, [Name], '��������' '����'
FROM Customer
ORDER BY Surname, [Name];