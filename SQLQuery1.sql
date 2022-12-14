select * from clients
select * from Accounts

drop table Accounts

insert into Accounts (AccountType, UserID)  values ('checking', 1)
insert into Accounts values ('checking', 1)

create table Accounts (AccountNumber int not null identity(1000, 1) primary key, AccountType varchar(10) not null, UserId int, Balance float default(0))