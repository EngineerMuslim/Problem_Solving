select *
from employee;

select distinct salary
from employee
order by salary desc;

create function getNthHighestSalary (@N int)
returns int
as
begin
    declare @Salary INT;

    SELECT @Salary = salary
    from
    (
        select
            salary,
            dense_rank() over (order by salary desc) as SalaryRank
        from Employee
    ) as RankedSalaries
    where SalaryRank = @N;

    return @Salary;
end;

select dbo.getNthHighestSalary(1);