

create table users
(
userId int primary key identity,
username varchar(50) not null,
upass varchar(10) not null,
uName varchar(50) not null,
uphone varchar(20)
)

insert into users values('admin',123,'User 1','253-253666')

