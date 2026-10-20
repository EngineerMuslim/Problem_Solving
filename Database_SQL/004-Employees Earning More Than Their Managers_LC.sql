alter table employee
add name varchar(50),
managerId int;

update employee
set name='Joe',managerId=3
where id=1;

update employee
set name='Henary',managerId=4
where id=2;

insert into employee(id,name,salary,managerId)
values
(5, 'Sam', 60000, NULL),
(4, 'Max', 90000, NULL);

SELECT * FROM Employee;

update employee
set salary=10000
where id=1;

update employee
set salary=50000
where id=2;

select e.name as Employee
from employee e
join employee m on m.id=e.managerId
where e.salary>m.salary;