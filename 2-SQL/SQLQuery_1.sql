-- 1. insert two new records into the employee table.

SELECT * FROM Employee;
DECLARE @maxid INT;
SELECT @maxid = MAX(EmployeeId) FROM Employee;
INSERT INTO Employee (EmployeeId, LastName, FirstName) VALUES
    (@maxid + 1, 'Duck', 'Donald'),
    (@maxid + 2, 'Mouse', 'Mickey');