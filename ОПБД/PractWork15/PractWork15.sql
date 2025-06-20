-- ������� 1
UPDATE Book
SET Price = ROUND(Price, -1);

-- ������� 2
SELECT YEAR(OrderDate) ���, MONTH(OrderDate) �����, COUNT(*) ����������
FROM [Order]
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY YEAR(OrderDate), MONTH(OrderDate) DESC;

-- ������� 3
UPDATE Book
SET Price = Price * 0.9
WHERE BookId IN (SELECT b.BookId
					FROM Book b
						LEFT JOIN OrderedBook ob ON b.BookId = ob.BookId
						JOIN [Order] o ON ob.OrderId = o.OrderId
					WHERE YEAR(PublicationYear) != YEAR(GETDATE()) OR PublicationYear IS NULL);

-- ������� 4
SELECT CustomerId, UPPER(Surname) + ' ' + UPPER(LEFT(LTRIM([Name]), 1)) + '.'
FROM Customer;

-- ������� 5
SELECT REPLACE(TRIM([Login]), ' ', '_')
FROM Customer;

-- ������� 6
SELECT 
	CustomerId, 
	[Login], 
	Surname,
	[Name],
	CASE WHEN TRIM([Address]) != '' THEN [Address] ELSE NULL END [Address], 
	CASE WHEN Phone IS NULL THEN '-' ELSE Phone END Phone
FROM Customer;

-- ������� 7
SELECT  DISTINCT Title
FROM Book
GROUP BY BookId, Title