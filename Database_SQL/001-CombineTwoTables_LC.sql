create table person (
personId int primary key ,
lastName varchar(50),
firstName varchar(50)
);

create table address(
addressId int primary key,
personId int,
city varchar(100),
state varchar(50),
foreign key (personId)references person (personId)
);

insert into person(personId,lastName,firstName)
values
(1,'Essam','Omar'),
(2,'Mohamed','Anas');

insert into address (addressId,personId,city,state)
values
(1,1,'Qena','Qena'),
(2,2,'KafrElsheikh','KafrElsheikh');


select p.firstName,p.lastName,a.city ,a.state
from person p left join address a 
on p.personId = a.personId;
