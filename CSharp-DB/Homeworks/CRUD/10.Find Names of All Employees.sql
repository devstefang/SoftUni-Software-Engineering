USE SoftUni
SELECT e.FirstName + ' ' + e.MiddleName + ' '+ e.LastName 
	AS [Full Name] 
	FROM Employees AS e
	WHERE Salary IN (25000, 14000, 12500,23600)