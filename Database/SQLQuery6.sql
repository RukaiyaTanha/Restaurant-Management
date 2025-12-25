create table products
(
PID int primary key identity,
pName varchar(50),
pPrice float,
CategoryID int,
pImage image
)