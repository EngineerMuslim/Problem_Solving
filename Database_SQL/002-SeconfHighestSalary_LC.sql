create table employee(
id int primary key,
salary int 
);

insert into employee (id,salary)
values
(1,100),
(2,200),
(3,300);

select Max(salary) as SecondHighestSalary
from employee
where salary <(
select Max(salary)
from employee
);