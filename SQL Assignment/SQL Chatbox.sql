CREATE TABLE Employeepatent(
Empid Int IDENTITY (1, 1) NOT NULL Primary key,
EmpNumber nvarchar(50) NOT NULL,
EmpFirstName varchar(150) NOT NULL,
EmpLastName varchar(150) NULL,
EmpEmail varchar(150) NULL,
Managerid int NULL,
Departmentid INT
)


CREATE TABLE [DepartmentChild](
[Departmenttid] [int] IDENTITY (1, 1) NOT NULL primary key,
[DepartmentName] [nvarchar](255) NOT NULL
)


insert into Employeepatent(EmpNumber,EmpFirstName,EmpLastName,EmpEmail,Managerid,Departmentid)values('A001','Samir','Singh','samir@abc.com',2,2)
insert into Employeepatent(EmpNumber,EmpFirstName,EmpLastName,EmpEmail,Managerid,Departmentid)values('A002','Amit','Kumar','amit@abc.com',1,1)
insert into Employeepatent (EmpNumber,EmpFirstName,EmpLastName,EmpEmail,Managerid,Departmentid)values('A003','Neha','Sharma','neha@abc.com',1,2)
insert into Employeepatent (EmpNumber,EmpFirstName,EmpLastName,EmpEmail,Managerid,Departmentid)values('A004','Vivek','Kumar','vivek@abc.com',1,NULL)


insert into [Departmentchild](DepartmentName)
values('Accounts')
insert into [Departmentchild](DepartmentName)
values('Admin')
insert into [Departmentchild](DepartmentName)
values('HR')
insert into [Departmentchild](DepartmentName)
values('Technology')

SELECT * FROM Employeepatent
SELECT * FROM DepartmentChild

--INNER JOIN
SELECT *
FROM Employeepatent
INNER JOIN DepartmentChild
ON Employeepatent.Departmentid = DepartmentChild.Departmenttid;

--LEFT JOIN
SELECT *
FROM Employeepatent
LEFT JOIN DepartmentChild
ON Employeepatent.Departmentid = DepartmentChild.Departmenttid;

--RIGHT JOIN
SELECT *
FROM DepartmentChild
RIGHT JOIN Employeepatent
ON DepartmentChild.Departmenttid = Employeepatent.Departmentid;

--SELF JOIN Wth Full Name
SELECT Empid, EmpNumber, EmpFirstName + ' ' + EmpLastName AS EmployeeName, EmpEmail, Managerid, Departmentid
FROM Employeepatent
INNER JOIN DepartmentChild
ON Employeepatent.Departmentid = DepartmentChild.Departmenttid;

--Full Outer Join
SELECT Empid, EmpNumber, EmpFirstName, EmpLastName, EmpEmail, Managerid,Departmentid, Dept.Departmenttid
FROM Employeepatent
FULL OUTER JOIN DepartmentChild Dept
ON Employeepatent.Departmentid = Dept.Departmenttid;

--Cross Join
SELECT Empid, EmpNumber, EmpFirstName + ' ' + EmpLastName AS EmployeeName, EmpEmail, Dept.DepartmentName
FROM Employeepatent
CROSS JOIN DepartmentChild Dept;