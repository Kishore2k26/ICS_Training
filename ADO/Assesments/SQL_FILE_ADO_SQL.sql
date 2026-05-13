create database Employee_Management

use Employee_Management

create table Employee_Details(
	Emp_no int primary key,
	Emp_name varchar(30) not null,
	Emp_sal numeric(10,2) check (Emp_sal >= 25000),
	Emp_type char(1) check (Emp_type in ('F', 'P'))
);

insert into Employee_Details(Emp_no, Emp_name, Emp_sal, Emp_type) values 
(1, 'Kishore', 30000, 'F'),
(2, 'Rahul', 28000, 'F'),
(3, 'Anita', 26000, 'P'),
(4, 'Suresh', 45000, 'F'),
(5, 'Priya', 27000, 'P');

select * from Employee_Details

create procedure Add_Employee
    @Emp_name varchar(30),
    @Emp_sal numeric(10,2),
    @Emp_type char(1)
as  
begin
    declare @New_Empno int;

    select @New_Empno = isnull(max(Emp_no), 0) + 1 from Employee_Details;

    insert into Employee_Details(Emp_no, Emp_name, Emp_sal, Emp_type)
    values (@New_Empno, @Emp_name, @Emp_sal, @Emp_type);
end;

exec Add_Employee 'Ravi', 32000, 'F';

create procedure Update_Salary
    @Emp_no INT,
    @Updated_Sal numeric(10,2) output
as
begin
    update Employee_Details
    set Emp_sal = Emp_sal + 100
    where Emp_no = @Emp_no;

    select @Updated_Sal = Emp_sal from Employee_Details
    where Emp_no = @Emp_no;
end;
